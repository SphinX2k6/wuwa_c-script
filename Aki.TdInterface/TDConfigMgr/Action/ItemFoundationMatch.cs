using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBA RID: 8122
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundationMatch : ActionParams
	{
		// Token: 0x0600B2A6 RID: 45734 RVA: 0x001A04C4 File Offset: 0x0019E6C4
		private ItemFoundationMatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ItemFoundationMatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ItemFoundationMatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ItemFoundationMatch_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x001A04FC File Offset: 0x0019E6FC
		public static ItemFoundationMatch Create([Nullable(2)] ItemFoundationMatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundationMatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x001A050F File Offset: 0x0019E70F
		public static ItemFoundationMatch CreateFromSetValue([Nullable(2)] ItemFoundationMatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ItemFoundationMatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x001A0522 File Offset: 0x0019E722
		public ItemFoundationMatch_SetValue ToSetValue()
		{
			return new ItemFoundationMatch_SetValue
			{
				MatchEntityId = this.MatchEntityId
			};
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x001A0535 File Offset: 0x0019E735
		// (set) Token: 0x0600B2AB RID: 45739 RVA: 0x001A0560 File Offset: 0x0019E760
		public virtual int MatchEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MatchEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MatchEntityId;
			}
			set
			{
				this.GetOrCreatePoco().MatchEntityId = value;
			}
		}

		// Token: 0x04006BE3 RID: 27619
		[Nullable(2)]
		protected new ItemFoundationMatch FbInstance;

		// Token: 0x04006BE4 RID: 27620
		[Nullable(2)]
		protected ItemFoundationMatch_SetValue PocoInterface;
	}
}
