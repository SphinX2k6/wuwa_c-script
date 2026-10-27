using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010CC RID: 4300
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestUnlockDelayTime
	{
		// Token: 0x0600611E RID: 24862 RVA: 0x000EA90C File Offset: 0x000E8B0C
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

		// Token: 0x0600611F RID: 24863 RVA: 0x000EA944 File Offset: 0x000E8B44
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

		// Token: 0x06006120 RID: 24864 RVA: 0x000EA957 File Offset: 0x000E8B57
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

		// Token: 0x06006121 RID: 24865 RVA: 0x000EA96A File Offset: 0x000E8B6A
		public IQuestUnlockDelayTime_SetValue ToSetValue()
		{
			return new IQuestUnlockDelayTime_SetValue
			{
				Day = this.Day,
				Hour = this.Hour,
				Minute = this.Minute
			};
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06006122 RID: 24866 RVA: 0x000EA995 File Offset: 0x000E8B95
		// (set) Token: 0x06006123 RID: 24867 RVA: 0x000EA9C0 File Offset: 0x000E8BC0
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

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x000EA9CE File Offset: 0x000E8BCE
		// (set) Token: 0x06006125 RID: 24869 RVA: 0x000EA9F9 File Offset: 0x000E8BF9
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

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06006126 RID: 24870 RVA: 0x000EAA07 File Offset: 0x000E8C07
		// (set) Token: 0x06006127 RID: 24871 RVA: 0x000EAA32 File Offset: 0x000E8C32
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

		// Token: 0x04003A76 RID: 14966
		[Nullable(2)]
		protected IQuestUnlockDelayTime FbInstance;

		// Token: 0x04003A77 RID: 14967
		[Nullable(2)]
		protected IQuestUnlockDelayTime_SetValue PocoInterface;
	}
}
