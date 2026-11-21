using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D3 RID: 5587
	[JsonConverter(typeof(SetPlayerOperationRestrictionConverter))]
	public class SetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x06007E0A RID: 32266 RVA: 0x0012B92C File Offset: 0x00129B2C
		private SetPlayerOperationRestriction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPlayerOperationRestriction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPlayerOperationRestriction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPlayerOperationRestriction_SetValue());
			}
			return result;
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0012B964 File Offset: 0x00129B64
		public static SetPlayerOperationRestriction Create([Nullable(2)] SetPlayerOperationRestriction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerOperationRestriction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0012B977 File Offset: 0x00129B77
		public static SetPlayerOperationRestriction CreateFromSetValue([Nullable(2)] SetPlayerOperationRestriction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPlayerOperationRestriction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0012B98A File Offset: 0x00129B8A
		public SetPlayerOperationRestriction_SetValue ToSetValue()
		{
			return new SetPlayerOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06007E0E RID: 32270 RVA: 0x0012B99D File Offset: 0x00129B9D
		// (set) Token: 0x06007E0F RID: 32271 RVA: 0x0012B9C8 File Offset: 0x00129BC8
		public virtual EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040048F0 RID: 18672
		[Nullable(1)]
		public string Json = "";

		// Token: 0x040048F1 RID: 18673
		[Nullable(2)]
		protected new SetPlayerOperationRestriction FbInstance;

		// Token: 0x040048F2 RID: 18674
		[Nullable(2)]
		protected SetPlayerOperationRestriction_SetValue PocoInterface;
	}
}
