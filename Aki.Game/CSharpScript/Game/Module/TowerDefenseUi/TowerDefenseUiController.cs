using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TowerDefenseUi.HeadState;

namespace CSharpScript.Game.Module.TowerDefenseUi
{
	// Token: 0x02004AFC RID: 19196
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class TowerDefenseUiController : ControllerBase
	{
		// Token: 0x06031B64 RID: 203620 RVA: 0x00B8B7E1 File Offset: 0x00B899E1
		protected override bool OnInit()
		{
			this.HeadStateManager = new TowerDefenseHeadStateManager();
			this.HeadStateManager.Init();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x06031B65 RID: 203621 RVA: 0x00B8B816 File Offset: 0x00B89A16
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

		// Token: 0x06031B66 RID: 203622 RVA: 0x00B8B831 File Offset: 0x00B89A31
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

		// Token: 0x06031B67 RID: 203623 RVA: 0x00B8B871 File Offset: 0x00B89A71
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

		// Token: 0x06031B68 RID: 203624 RVA: 0x00B8B89F File Offset: 0x00B89A9F
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

		// Token: 0x17007AF6 RID: 31478
		// (get) Token: 0x06031B69 RID: 203625 RVA: 0x00B8B8BB File Offset: 0x00B89ABB
		public static TowerDefenseUiController Instance
		{
			get
			{
				return TowerDefenseUiController._Instance;
			}
		}

		// Token: 0x06031B6A RID: 203626 RVA: 0x00B8B8C2 File Offset: 0x00B89AC2
		public static TowerDefenseUiController GetOrCreateInstance()
		{
			if (TowerDefenseUiController._Instance == null)
			{
				TowerDefenseUiController.CreateInstance();
			}
			return TowerDefenseUiController._Instance;
		}

		// Token: 0x06031B6B RID: 203627 RVA: 0x00B8B8D6 File Offset: 0x00B89AD6
		public static bool CreateInstance()
		{
			if (TowerDefenseUiController._Instance != null)
			{
				return true;
			}
			TowerDefenseUiController._Instance = new TowerDefenseUiController();
			return true;
		}

		// Token: 0x06031B6C RID: 203628 RVA: 0x00B8B8EC File Offset: 0x00B89AEC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031B6D RID: 203629 RVA: 0x00B8B8EE File Offset: 0x00B89AEE
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseUiController._Instance = null;
		}

		// Token: 0x06031B6E RID: 203630 RVA: 0x00B8B8F6 File Offset: 0x00B89AF6
		static TowerDefenseUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseUiController.CreateStaticDefaultValue), new Action(TowerDefenseUiController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A8B6 RID: 108726
		private Stat TickStat = Stat.Create("TowerDefenseUiController.OnTick", "", "");

		// Token: 0x0401A8B7 RID: 108727
		[Nullable(2)]
		public TowerDefenseHeadStateManager HeadStateManager;

		// Token: 0x0401A8B8 RID: 108728
		public bool IsEnable;

		// Token: 0x0401A8B9 RID: 108729
		[Nullable(2)]
		private static TowerDefenseUiController _Instance;
	}
}
