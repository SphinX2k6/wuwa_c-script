using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005381 RID: 21377
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentData
	{
		// Token: 0x06035341 RID: 217921 RVA: 0x00EDBEB2 File Offset: 0x00EDA0B2
		public MotorFightTalentData(MotorFightTalent config)
		{
			this.Config = config;
		}

		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x06035343 RID: 217923 RVA: 0x00EDBECA File Offset: 0x00EDA0CA
		// (set) Token: 0x06035342 RID: 217922 RVA: 0x00EDBEC1 File Offset: 0x00EDA0C1
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

		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x06035345 RID: 217925 RVA: 0x00EDBEDB File Offset: 0x00EDA0DB
		// (set) Token: 0x06035344 RID: 217924 RVA: 0x00EDBED2 File Offset: 0x00EDA0D2
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

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x06035346 RID: 217926 RVA: 0x00EDBEE3 File Offset: 0x00EDA0E3
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x06035347 RID: 217927 RVA: 0x00EDBEF0 File Offset: 0x00EDA0F0
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x06035348 RID: 217928 RVA: 0x00EDBEFD File Offset: 0x00EDA0FD
		public int Column
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x06035349 RID: 217929 RVA: 0x00EDBF0A File Offset: 0x00EDA10A
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x0603534A RID: 217930 RVA: 0x00EDBF17 File Offset: 0x00EDA117
		public int Cost
		{
			get
			{
				return this.Config.Consume;
			}
		}

		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x0603534B RID: 217931 RVA: 0x00EDBF24 File Offset: 0x00EDA124
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x0603534C RID: 217932 RVA: 0x00EDBF31 File Offset: 0x00EDA131
		public string[] DescParams
		{
			get
			{
				return this.Config.DescParam();
			}
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x0603534D RID: 217933 RVA: 0x00EDBF3E File Offset: 0x00EDA13E
		[Nullable(0)]
		public Span<int> PreNode
		{
			[NullableContext(0)]
			get
			{
				return this.Config.GetPreNodeBytes();
			}
		}

		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x0603534E RID: 217934 RVA: 0x00EDBF4B File Offset: 0x00EDA14B
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x0603534F RID: 217935 RVA: 0x00EDBF58 File Offset: 0x00EDA158
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x0401C110 RID: 114960
		private MotorFightTalent Config;

		// Token: 0x0401C111 RID: 114961
		private bool IsFinishPreConditionInternal;

		// Token: 0x0401C112 RID: 114962
		private bool IsUnLockInternal;
	}
}
