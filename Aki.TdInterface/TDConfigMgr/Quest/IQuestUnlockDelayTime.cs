using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011FA RID: 4602
	public class IQuestUnlockDelayTime
	{
		// Token: 0x06006717 RID: 26391 RVA: 0x000F7A2C File Offset: 0x000F5C2C
		private IQuestUnlockDelayTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestUnlockDelayTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestUnlockDelayTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestUnlockDelayTime_SetValue());
			}
			return result;
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x000F7A64 File Offset: 0x000F5C64
		public static IQuestUnlockDelayTime Create([Nullable(2)] IQuestUnlockDelayTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestUnlockDelayTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x000F7A77 File Offset: 0x000F5C77
		public static IQuestUnlockDelayTime CreateFromSetValue([Nullable(2)] IQuestUnlockDelayTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestUnlockDelayTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x000F7A8A File Offset: 0x000F5C8A
		public IQuestUnlockDelayTime_SetValue ToSetValue()
		{
			return new IQuestUnlockDelayTime_SetValue
			{
				Day = this.Day,
				Hour = this.Hour,
				Minute = this.Minute
			};
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x0600671B RID: 26395 RVA: 0x000F7AB5 File Offset: 0x000F5CB5
		// (set) Token: 0x0600671C RID: 26396 RVA: 0x000F7AE0 File Offset: 0x000F5CE0
		public virtual int Day
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Day;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Day;
			}
			set
			{
				this.GetOrCreatePoco().Day = value;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x0600671D RID: 26397 RVA: 0x000F7AEE File Offset: 0x000F5CEE
		// (set) Token: 0x0600671E RID: 26398 RVA: 0x000F7B19 File Offset: 0x000F5D19
		public virtual int Hour
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hour;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hour;
			}
			set
			{
				this.GetOrCreatePoco().Hour = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x0600671F RID: 26399 RVA: 0x000F7B27 File Offset: 0x000F5D27
		// (set) Token: 0x06006720 RID: 26400 RVA: 0x000F7B52 File Offset: 0x000F5D52
		public virtual int Minute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minute;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minute;
			}
			set
			{
				this.GetOrCreatePoco().Minute = value;
			}
		}

		// Token: 0x04003DC3 RID: 15811
		[Nullable(2)]
		protected IQuestUnlockDelayTime FbInstance;

		// Token: 0x04003DC4 RID: 15812
		[Nullable(2)]
		protected IQuestUnlockDelayTime_SetValue PocoInterface;
	}
}
