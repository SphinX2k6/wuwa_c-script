using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.RoleMorph.Handle;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleMorph
{
	// Token: 0x02003D2E RID: 15662
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RoleMorphController : UiControllerBase
	{
		// Token: 0x060281F3 RID: 164339 RVA: 0x00B3B114 File Offset: 0x00B39314
		protected override bool OnLeaveLevel()
		{
			if (this.CurMorphHandle != null)
			{
				this.CurMorphHandle.EndMorph();
				this.CurMorphHandle = null;
			}
			return true;
		}

		// Token: 0x060281F4 RID: 164340 RVA: 0x00B3B131 File Offset: 0x00B39331
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		}

		// Token: 0x060281F5 RID: 164341 RVA: 0x00B3B14F File Offset: 0x00B3934F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		}

		// Token: 0x060281F6 RID: 164342 RVA: 0x00B3B170 File Offset: 0x00B39370
		private void OnChangeRole(int _1, int _2)
		{
			this.EndMorph();
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData == null)
			{
				return;
			}
			BattleUiRoleData battleUiRoleData = curRoleData;
			int? num = (battleUiRoleData.RoleConfig != null) ? new int?(battleUiRoleData.RoleConfig.GetValueOrDefault().Id) : null;
			if (num == null)
			{
				return;
			}
			Func<RoleMorphHandleBase> func;
			if (this.HandleMap.TryGetValue(num.Value, out func))
			{
				this.CurMorphHandle = func();
				this.CurMorphHandle.BeginMorph();
			}
		}

		// Token: 0x060281F7 RID: 164343 RVA: 0x00B3B1F7 File Offset: 0x00B393F7
		public void EndMorph()
		{
			if (this.CurMorphHandle != null)
			{
				this.CurMorphHandle.EndMorph();
				this.CurMorphHandle = null;
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x060281F8 RID: 164344 RVA: 0x00B3B213 File Offset: 0x00B39413
		public static RoleMorphController Instance
		{
			get
			{
				return RoleMorphController._Instance;
			}
		}

		// Token: 0x060281F9 RID: 164345 RVA: 0x00B3B21A File Offset: 0x00B3941A
		public static RoleMorphController GetOrCreateInstance()
		{
			if (RoleMorphController._Instance == null)
			{
				RoleMorphController.CreateInstance();
			}
			return RoleMorphController._Instance;
		}

		// Token: 0x060281FA RID: 164346 RVA: 0x00B3B22E File Offset: 0x00B3942E
		public static bool CreateInstance()
		{
			if (RoleMorphController._Instance != null)
			{
				return true;
			}
			RoleMorphController._Instance = new RoleMorphController();
			return true;
		}

		// Token: 0x060281FB RID: 164347 RVA: 0x00B3B244 File Offset: 0x00B39444
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060281FC RID: 164348 RVA: 0x00B3B246 File Offset: 0x00B39446
		public static void ResetStaticDefaultValue()
		{
			RoleMorphController._Instance = null;
		}

		// Token: 0x060281FD RID: 164349 RVA: 0x00B3B24E File Offset: 0x00B3944E
		static RoleMorphController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleMorphController.CreateStaticDefaultValue), new Action(RoleMorphController.ResetStaticDefaultValue));
		}

		// Token: 0x060281FE RID: 164350 RVA: 0x00B3B270 File Offset: 0x00B39470
		public RoleMorphController()
		{
			Dictionary<int, Func<RoleMorphHandleBase>> dictionary = new Dictionary<int, Func<RoleMorphHandleBase>>();
			dictionary.Add(5012, () => new RoleMorphPaoTaiHandle());
			dictionary.Add(5020, () => new RoleMorphLiuLiDaoLingHandle());
			dictionary.Add(5021, () => new RoleMorphGuYingXiongKaiHandle());
			this.HandleMap = dictionary;
			base..ctor();
		}

		// Token: 0x04015CE3 RID: 89315
		private readonly Dictionary<int, Func<RoleMorphHandleBase>> HandleMap;

		// Token: 0x04015CE4 RID: 89316
		[Nullable(2)]
		private RoleMorphHandleBase CurMorphHandle;

		// Token: 0x04015CE5 RID: 89317
		[Nullable(2)]
		private static RoleMorphController _Instance;
	}
}
