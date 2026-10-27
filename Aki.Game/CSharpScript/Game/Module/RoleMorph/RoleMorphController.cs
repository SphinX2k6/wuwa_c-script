using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.RoleMorph.Handle;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleMorph
{
	// Token: 0x02004D65 RID: 19813
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RoleMorphController : UiControllerBase
	{
		// Token: 0x06033385 RID: 209797 RVA: 0x00BF1EF0 File Offset: 0x00BF00F0
		protected override bool OnLeaveLevel()
		{
			if (this.CurMorphHandle != null)
			{
				this.CurMorphHandle.EndMorph();
				this.CurMorphHandle = null;
			}
			return true;
		}

		// Token: 0x06033386 RID: 209798 RVA: 0x00BF1F0D File Offset: 0x00BF010D
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		}

		// Token: 0x06033387 RID: 209799 RVA: 0x00BF1F2B File Offset: 0x00BF012B
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		}

		// Token: 0x06033388 RID: 209800 RVA: 0x00BF1F4C File Offset: 0x00BF014C
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

		// Token: 0x06033389 RID: 209801 RVA: 0x00BF1FD3 File Offset: 0x00BF01D3
		public void EndMorph()
		{
			if (this.CurMorphHandle != null)
			{
				this.CurMorphHandle.EndMorph();
				this.CurMorphHandle = null;
			}
		}

		// Token: 0x17007E66 RID: 32358
		// (get) Token: 0x0603338A RID: 209802 RVA: 0x00BF1FEF File Offset: 0x00BF01EF
		public static RoleMorphController Instance
		{
			get
			{
				return RoleMorphController._Instance;
			}
		}

		// Token: 0x0603338B RID: 209803 RVA: 0x00BF1FF6 File Offset: 0x00BF01F6
		public static RoleMorphController GetOrCreateInstance()
		{
			if (RoleMorphController._Instance == null)
			{
				RoleMorphController.CreateInstance();
			}
			return RoleMorphController._Instance;
		}

		// Token: 0x0603338C RID: 209804 RVA: 0x00BF200A File Offset: 0x00BF020A
		public static bool CreateInstance()
		{
			if (RoleMorphController._Instance != null)
			{
				return true;
			}
			RoleMorphController._Instance = new RoleMorphController();
			return true;
		}

		// Token: 0x0603338D RID: 209805 RVA: 0x00BF2020 File Offset: 0x00BF0220
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603338E RID: 209806 RVA: 0x00BF2022 File Offset: 0x00BF0222
		public static void ResetStaticDefaultValue()
		{
			RoleMorphController._Instance = null;
		}

		// Token: 0x0603338F RID: 209807 RVA: 0x00BF202A File Offset: 0x00BF022A
		static RoleMorphController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleMorphController.CreateStaticDefaultValue), new Action(RoleMorphController.ResetStaticDefaultValue));
		}

		// Token: 0x06033390 RID: 209808 RVA: 0x00BF204C File Offset: 0x00BF024C
		public RoleMorphController()
		{
			Dictionary<int, Func<RoleMorphHandleBase>> dictionary = new Dictionary<int, Func<RoleMorphHandleBase>>();
			dictionary.Add(5012, () => new RoleMorphPaoTaiHandle());
			dictionary.Add(5020, () => new RoleMorphLiuLiDaoLingHandle());
			dictionary.Add(5021, () => new RoleMorphGuYingXiongKaiHandle());
			this.HandleMap = dictionary;
			base..ctor();
		}

		// Token: 0x0401B311 RID: 111377
		private readonly Dictionary<int, Func<RoleMorphHandleBase>> HandleMap;

		// Token: 0x0401B312 RID: 111378
		[Nullable(2)]
		private RoleMorphHandleBase CurMorphHandle;

		// Token: 0x0401B313 RID: 111379
		[Nullable(2)]
		private static RoleMorphController _Instance;
	}
}
