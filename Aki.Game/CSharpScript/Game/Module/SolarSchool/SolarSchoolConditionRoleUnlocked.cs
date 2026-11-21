using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A2 RID: 22690
	public class SolarSchoolConditionRoleUnlocked : ActivityConditionBase
	{
		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x06037E68 RID: 228968 RVA: 0x00FA0E84 File Offset: 0x00F9F084
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E69 RID: 228969 RVA: 0x00FA0E87 File Offset: 0x00F9F087
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.RoleId = p.GetInt("RoleId", 0);
			return true;
		}

		// Token: 0x06037E6A RID: 228970 RVA: 0x00FA0E9C File Offset: 0x00F9F09C
		protected override bool OnCheck()
		{
			return SolarSchoolGamePlayModel.Instance.IsConditionRoleUnlocked(this.RoleId);
		}

		// Token: 0x06037E6B RID: 228971 RVA: 0x00FA0EAE File Offset: 0x00F9F0AE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E6C RID: 228972 RVA: 0x00FA0ECC File Offset: 0x00F9F0CC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E6D RID: 228973 RVA: 0x00FA0EEA File Offset: 0x00F9F0EA
		protected override void OnClear()
		{
			this.RoleId = 0;
		}

		// Token: 0x06037E6E RID: 228974 RVA: 0x00FA0EF3 File Offset: 0x00F9F0F3
		private void OnFavorChanged(int roleId)
		{
			if (roleId == this.RoleId)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7EC RID: 120812
		private int RoleId;
	}
}
