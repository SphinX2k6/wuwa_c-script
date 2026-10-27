using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200147A RID: 5242
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(SetPlayerOperationRestrictionConverter))]
	public class SetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600773D RID: 30525 RVA: 0x0011CD20 File Offset: 0x0011AF20
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

		// Token: 0x0600773E RID: 30526 RVA: 0x0011CD58 File Offset: 0x0011AF58
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

		// Token: 0x0600773F RID: 30527 RVA: 0x0011CD6B File Offset: 0x0011AF6B
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

		// Token: 0x06007740 RID: 30528 RVA: 0x0011CD7E File Offset: 0x0011AF7E
		public SetPlayerOperationRestriction_SetValue ToSetValue()
		{
			return new SetPlayerOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x0011CD91 File Offset: 0x0011AF91
		// (set) Token: 0x06007742 RID: 30530 RVA: 0x0011CDBC File Offset: 0x0011AFBC
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

		// Token: 0x04004555 RID: 17749
		public string Json = "";

		// Token: 0x04004556 RID: 17750
		[Nullable(2)]
		protected new SetPlayerOperationRestriction FbInstance;

		// Token: 0x04004557 RID: 17751
		[Nullable(2)]
		protected SetPlayerOperationRestriction_SetValue PocoInterface;
	}
}
