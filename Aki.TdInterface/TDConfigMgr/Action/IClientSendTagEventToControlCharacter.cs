using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C6 RID: 6342
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientSendTagEventToControlCharacter : IExecClientBattleActionType
	{
		// Token: 0x06008809 RID: 34825 RVA: 0x001420B4 File Offset: 0x001402B4
		private IClientSendTagEventToControlCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientSendTagEventToControlCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientSendTagEventToControlCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientSendTagEventToControlCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x001420EC File Offset: 0x001402EC
		public static IClientSendTagEventToControlCharacter Create([Nullable(2)] IClientSendTagEventToControlCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientSendTagEventToControlCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x001420FF File Offset: 0x001402FF
		public static IClientSendTagEventToControlCharacter CreateFromSetValue([Nullable(2)] IClientSendTagEventToControlCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientSendTagEventToControlCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x00142112 File Offset: 0x00140312
		public new IClientSendTagEventToControlCharacter_SetValue ToSetValue()
		{
			return new IClientSendTagEventToControlCharacter_SetValue
			{
				Type = this.Type,
				EventTags = this.EventTags
			};
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x00142131 File Offset: 0x00140331
		// (set) Token: 0x0600880E RID: 34830 RVA: 0x0014215C File Offset: 0x0014035C
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600880F RID: 34831 RVA: 0x0014216A File Offset: 0x0014036A
		// (set) Token: 0x06008810 RID: 34832 RVA: 0x00142191 File Offset: 0x00140391
		public virtual List<string> EventTags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventTags;
				}
				IClientSendTagEventToControlCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventTags;
			}
			set
			{
				this.GetOrCreatePoco().EventTags = value;
			}
		}

		// Token: 0x0400557F RID: 21887
		[Nullable(2)]
		protected new IClientSendTagEventToControlCharacter FbInstance;

		// Token: 0x04005580 RID: 21888
		[Nullable(2)]
		protected new IClientSendTagEventToControlCharacter_SetValue PocoInterface;
	}
}
