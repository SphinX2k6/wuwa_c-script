using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006403 RID: 25603
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentData
	{
		// Token: 0x06040680 RID: 263808 RVA: 0x00F94F12 File Offset: 0x00F93112
		public MotorFightTalentData(MotorFightTalent config)
		{
			this.Config = config;
		}

		// Token: 0x1700945D RID: 37981
		// (get) Token: 0x06040682 RID: 263810 RVA: 0x00F94F2A File Offset: 0x00F9312A
		// (set) Token: 0x06040681 RID: 263809 RVA: 0x00F94F21 File Offset: 0x00F93121
		public bool IsUnLock
		{
			get
			{
				return this.IsUnLockInternal;
			}
			set
			{
				this.IsUnLockInternal = value;
			}
		}

		// Token: 0x1700945E RID: 37982
		// (get) Token: 0x06040684 RID: 263812 RVA: 0x00F94F3B File Offset: 0x00F9313B
		// (set) Token: 0x06040683 RID: 263811 RVA: 0x00F94F32 File Offset: 0x00F93132
		public bool IsFinishPreCondition
		{
			get
			{
				return this.IsFinishPreConditionInternal;
			}
			set
			{
				this.IsFinishPreConditionInternal = value;
			}
		}

		// Token: 0x1700945F RID: 37983
		// (get) Token: 0x06040685 RID: 263813 RVA: 0x00F94F43 File Offset: 0x00F93143
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17009460 RID: 37984
		// (get) Token: 0x06040686 RID: 263814 RVA: 0x00F94F50 File Offset: 0x00F93150
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17009461 RID: 37985
		// (get) Token: 0x06040687 RID: 263815 RVA: 0x00F94F5D File Offset: 0x00F9315D
		public int Column
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x17009462 RID: 37986
		// (get) Token: 0x06040688 RID: 263816 RVA: 0x00F94F6A File Offset: 0x00F9316A
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x17009463 RID: 37987
		// (get) Token: 0x06040689 RID: 263817 RVA: 0x00F94F77 File Offset: 0x00F93177
		public int Cost
		{
			get
			{
				return this.Config.Consume;
			}
		}

		// Token: 0x17009464 RID: 37988
		// (get) Token: 0x0604068A RID: 263818 RVA: 0x00F94F84 File Offset: 0x00F93184
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17009465 RID: 37989
		// (get) Token: 0x0604068B RID: 263819 RVA: 0x00F94F91 File Offset: 0x00F93191
		public string[] DescParams
		{
			get
			{
				return this.Config.DescParam();
			}
		}

		// Token: 0x17009466 RID: 37990
		// (get) Token: 0x0604068C RID: 263820 RVA: 0x00F94F9E File Offset: 0x00F9319E
		[Nullable(0)]
		public Span<int> PreNode
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetPreNodeBytes();
			}
		}

		// Token: 0x17009467 RID: 37991
		// (get) Token: 0x0604068D RID: 263821 RVA: 0x00F94FAB File Offset: 0x00F931AB
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x17009468 RID: 37992
		// (get) Token: 0x0604068E RID: 263822 RVA: 0x00F94FB8 File Offset: 0x00F931B8
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x040217E1 RID: 137185
		private MotorFightTalent Config;

		// Token: 0x040217E2 RID: 137186
		private bool IsFinishPreConditionInternal;

		// Token: 0x040217E3 RID: 137187
		private bool IsUnLockInternal;
	}
}
