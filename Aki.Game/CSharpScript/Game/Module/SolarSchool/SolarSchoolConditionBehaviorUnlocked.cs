using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005894 RID: 22676
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionBehaviorUnlocked : ActivityConditionProgressBase
	{
		// Token: 0x17006B3A RID: 27450
		// (get) Token: 0x06037DF2 RID: 228850 RVA: 0x00FA015E File Offset: 0x00F9E35E
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DF3 RID: 228851 RVA: 0x00FA0161 File Offset: 0x00F9E361
		protected override bool OnInitialize(ConditionParams p)
		{
			this.BehaviorIds = p.GetIntList("BehaviorId").ToArray();
			this.TargetCount = p.GetInt("Count", this.BehaviorIds.Length);
			return true;
		}

		// Token: 0x06037DF4 RID: 228852 RVA: 0x00FA0194 File Offset: 0x00F9E394
		public override int GetCurrent()
		{
			int num = 0;
			foreach (int behaviorId in this.BehaviorIds)
			{
				if (SolarSchoolGamePlayModel.Instance.IsBehaviorUnlocked(behaviorId))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06037DF5 RID: 228853 RVA: 0x00FA01CE File Offset: 0x00F9E3CE
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037DF6 RID: 228854 RVA: 0x00FA01D6 File Offset: 0x00F9E3D6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolBehaviorUnlocked, new Action<int>(this.OnBehaviorUnlocked));
		}

		// Token: 0x06037DF7 RID: 228855 RVA: 0x00FA01F4 File Offset: 0x00F9E3F4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolBehaviorUnlocked, new Action<int>(this.OnBehaviorUnlocked));
		}

		// Token: 0x06037DF8 RID: 228856 RVA: 0x00FA0212 File Offset: 0x00F9E412
		protected override void OnClear()
		{
			this.BehaviorIds = Array.Empty<int>();
			this.TargetCount = 0;
		}

		// Token: 0x06037DF9 RID: 228857 RVA: 0x00FA0226 File Offset: 0x00F9E426
		private void OnBehaviorUnlocked(int behaviorId)
		{
			if (Array.IndexOf<int>(this.BehaviorIds, behaviorId) >= 0)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7CD RID: 120781
		private int[] BehaviorIds = Array.Empty<int>();

		// Token: 0x0401D7CE RID: 120782
		private int TargetCount;
	}
}
