using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002137 RID: 8503
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsAddBuff : ActionParams
	{
		// Token: 0x0600BB44 RID: 47940 RVA: 0x001B087C File Offset: 0x001AEA7C
		private ReignsAddBuff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsAddBuff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsAddBuff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsAddBuff_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x001B08B4 File Offset: 0x001AEAB4
		public static ReignsAddBuff Create([Nullable(2)] ReignsAddBuff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x001B08C7 File Offset: 0x001AEAC7
		public static ReignsAddBuff CreateFromSetValue([Nullable(2)] ReignsAddBuff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x001B08DA File Offset: 0x001AEADA
		public ReignsAddBuff_SetValue ToSetValue()
		{
			return new ReignsAddBuff_SetValue
			{
				BuffId = this.BuffId
			};
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x001B08ED File Offset: 0x001AEAED
		// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x001B0918 File Offset: 0x001AEB18
		public virtual int BuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BuffId;
			}
			set
			{
				this.GetOrCreatePoco().BuffId = value;
			}
		}

		// Token: 0x04007005 RID: 28677
		[Nullable(2)]
		protected new ReignsAddBuff FbInstance;

		// Token: 0x04007006 RID: 28678
		[Nullable(2)]
		protected ReignsAddBuff_SetValue PocoInterface;
	}
}
