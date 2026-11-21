using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TowerDefenseUi.HeadState;

namespace CSharpScript.Game.Module.TowerDefenseUi
{
	// Token: 0x02003AA4 RID: 15012
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class TowerDefenseUiController : ControllerBase
	{
		// Token: 0x060268F4 RID: 157940 RVA: 0x00ACF83D File Offset: 0x00ACDA3D
		protected override bool OnInit()
		{
			this.HeadStateManager = new TowerDefenseHeadStateManager();
			this.HeadStateManager.Init();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x060268F5 RID: 157941 RVA: 0x00ACF872 File Offset: 0x00ACDA72
		protected override bool OnLeaveLevel()
		{
			TowerDefenseHeadStateManager headStateManager = this.HeadStateManager;
			if (headStateManager != null)
			{
				headStateManager.Clear();
			}
			this.IsEnable = false;
			return true;
		}

		// Token: 0x060268F6 RID: 157942 RVA: 0x00ACF88D File Offset: 0x00ACDA8D
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			if (this.HeadStateManager != null)
			{
				this.HeadStateManager.Clear();
				this.HeadStateManager = null;
			}
			this.IsEnable = false;
			return true;
		}

		// Token: 0x060268F7 RID: 157943 RVA: 0x00ACF8CD File Offset: 0x00ACDACD
		private void OnWorldDone()
		{
			this.IsEnable = (KuroSimpleCombatController.Instance.CurSubController != null);
			if (!this.IsEnable)
			{
				return;
			}
			TowerDefenseHeadStateManager headStateManager = this.HeadStateManager;
			if (headStateManager == null)
			{
				return;
			}
			headStateManager.OnWorldDone();
		}

		// Token: 0x060268F8 RID: 157944 RVA: 0x00ACF8FB File Offset: 0x00ACDAFB
		protected override void OnTick(float delta)
		{
			if (!this.IsEnable)
			{
				return;
			}
			TowerDefenseHeadStateManager headStateManager = this.HeadStateManager;
			if (headStateManager == null)
			{
				return;
			}
			headStateManager.Tick(delta);
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x060268F9 RID: 157945 RVA: 0x00ACF917 File Offset: 0x00ACDB17
		public static TowerDefenseUiController Instance
		{
			get
			{
				return TowerDefenseUiController._Instance;
			}
		}

		// Token: 0x060268FA RID: 157946 RVA: 0x00ACF91E File Offset: 0x00ACDB1E
		public static TowerDefenseUiController GetOrCreateInstance()
		{
			if (TowerDefenseUiController._Instance == null)
			{
				TowerDefenseUiController.CreateInstance();
			}
			return TowerDefenseUiController._Instance;
		}

		// Token: 0x060268FB RID: 157947 RVA: 0x00ACF932 File Offset: 0x00ACDB32
		public static bool CreateInstance()
		{
			if (TowerDefenseUiController._Instance != null)
			{
				return true;
			}
			TowerDefenseUiController._Instance = new TowerDefenseUiController();
			return true;
		}

		// Token: 0x060268FC RID: 157948 RVA: 0x00ACF948 File Offset: 0x00ACDB48
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060268FD RID: 157949 RVA: 0x00ACF94A File Offset: 0x00ACDB4A
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseUiController._Instance = null;
		}

		// Token: 0x060268FE RID: 157950 RVA: 0x00ACF952 File Offset: 0x00ACDB52
		static TowerDefenseUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseUiController.CreateStaticDefaultValue), new Action(TowerDefenseUiController.ResetStaticDefaultValue));
		}

		// Token: 0x04015208 RID: 86536
		private Stat TickStat = Stat.Create("TowerDefenseUiController.OnTick", "", "");

		// Token: 0x04015209 RID: 86537
		[Nullable(2)]
		public TowerDefenseHeadStateManager HeadStateManager;

		// Token: 0x0401520A RID: 86538
		public bool IsEnable;

		// Token: 0x0401520B RID: 86539
		[Nullable(2)]
		private static TowerDefenseUiController _Instance;
	}
}
