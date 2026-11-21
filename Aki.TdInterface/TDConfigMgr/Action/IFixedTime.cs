using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C06 RID: 7174
	public class IFixedTime
	{
		// Token: 0x0600985E RID: 39006 RVA: 0x00161A24 File Offset: 0x0015FC24
		private IFixedTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedTime_SetValue());
			}
			return result;
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x00161A5C File Offset: 0x0015FC5C
		public static IFixedTime Create([Nullable(2)] IFixedTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x00161A6F File Offset: 0x0015FC6F
		public static IFixedTime CreateFromSetValue([Nullable(2)] IFixedTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00161A82 File Offset: 0x0015FC82
		public IFixedTime_SetValue ToSetValue()
		{
			return new IFixedTime_SetValue
			{
				Hour = this.Hour,
				Minutes = this.Minutes
			};
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06009862 RID: 39010 RVA: 0x00161AA1 File Offset: 0x0015FCA1
		// (set) Token: 0x06009863 RID: 39011 RVA: 0x00161ACC File Offset: 0x0015FCCC
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

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06009864 RID: 39012 RVA: 0x00161ADA File Offset: 0x0015FCDA
		// (set) Token: 0x06009865 RID: 39013 RVA: 0x00161B05 File Offset: 0x0015FD05
		public virtual int Minutes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minutes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minutes;
			}
			set
			{
				this.GetOrCreatePoco().Minutes = value;
			}
		}

		// Token: 0x04005DDC RID: 24028
		[Nullable(2)]
		protected IFixedTime FbInstance;

		// Token: 0x04005DDD RID: 24029
		[Nullable(2)]
		protected IFixedTime_SetValue PocoInterface;
	}
}
