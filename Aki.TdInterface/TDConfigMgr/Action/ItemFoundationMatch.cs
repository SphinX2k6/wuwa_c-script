using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FD RID: 8701
	public class ItemFoundationMatch : ActionParams
	{
		// Token: 0x0600BDAA RID: 48554 RVA: 0x001B6874 File Offset: 0x001B4A74
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

		// Token: 0x0600BDAB RID: 48555 RVA: 0x001B68AC File Offset: 0x001B4AAC
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

		// Token: 0x0600BDAC RID: 48556 RVA: 0x001B68BF File Offset: 0x001B4ABF
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

		// Token: 0x0600BDAD RID: 48557 RVA: 0x001B68D2 File Offset: 0x001B4AD2
		public ItemFoundationMatch_SetValue ToSetValue()
		{
			return new ItemFoundationMatch_SetValue
			{
				MatchEntityId = this.MatchEntityId
			};
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600BDAE RID: 48558 RVA: 0x001B68E5 File Offset: 0x001B4AE5
		// (set) Token: 0x0600BDAF RID: 48559 RVA: 0x001B6910 File Offset: 0x001B4B10
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

		// Token: 0x040071DE RID: 29150
		[Nullable(2)]
		protected new ItemFoundationMatch FbInstance;

		// Token: 0x040071DF RID: 29151
		[Nullable(2)]
		protected ItemFoundationMatch_SetValue PocoInterface;
	}
}
