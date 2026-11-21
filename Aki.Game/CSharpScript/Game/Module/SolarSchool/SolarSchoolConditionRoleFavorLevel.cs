using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A0 RID: 22688
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionRoleFavorLevel : ActivityConditionProgressBase
	{
		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x06037E57 RID: 228951 RVA: 0x00FA0C6D File Offset: 0x00F9EE6D
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E58 RID: 228952 RVA: 0x00FA0C70 File Offset: 0x00F9EE70
		protected override bool OnInitialize(ConditionParams p)
		{
			this.RoleIds = p.GetIntList("RoleId").ToArray();
			this.MinLevel = p.GetInt("Min", int.MinValue);
			this.MaxLevel = p.GetInt("Max", int.MaxValue);
			this.TargetCount = p.GetInt("Count", this.RoleIds.Length);
			return true;
		}

		// Token: 0x06037E59 RID: 228953 RVA: 0x00FA0CDC File Offset: 0x00F9EEDC
		public override int GetCurrent()
		{
			int num = 0;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			foreach (int roleId in this.RoleIds)
			{
				int conditionFavorLevel = instance.GetConditionFavorLevel(roleId);
				if (conditionFavorLevel >= this.MinLevel && conditionFavorLevel <= this.MaxLevel)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06037E5A RID: 228954 RVA: 0x00FA0D2E File Offset: 0x00F9EF2E
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E5B RID: 228955 RVA: 0x00FA0D36 File Offset: 0x00F9EF36
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E5C RID: 228956 RVA: 0x00FA0D54 File Offset: 0x00F9EF54
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E5D RID: 228957 RVA: 0x00FA0D72 File Offset: 0x00F9EF72
		protected override void OnClear()
		{
			this.RoleIds = Array.Empty<int>();
			this.MinLevel = 0;
			this.MaxLevel = 0;
			this.TargetCount = 0;
		}

		// Token: 0x06037E5E RID: 228958 RVA: 0x00FA0D94 File Offset: 0x00F9EF94
		private void OnFavorChanged(int roleId)
		{
			if (Array.IndexOf<int>(this.RoleIds, roleId) >= 0)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7E6 RID: 120806
		private int[] RoleIds = Array.Empty<int>();

		// Token: 0x0401D7E7 RID: 120807
		private int MinLevel;

		// Token: 0x0401D7E8 RID: 120808
		private int MaxLevel;

		// Token: 0x0401D7E9 RID: 120809
		private int TargetCount;
	}
}
