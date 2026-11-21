using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A57 RID: 6743
	public class IClientSendTagEventToControlCharacter : IExecClientBattleActionType
	{
		// Token: 0x06008F51 RID: 36689 RVA: 0x00151C2C File Offset: 0x0014FE2C
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

		// Token: 0x06008F52 RID: 36690 RVA: 0x00151C64 File Offset: 0x0014FE64
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

		// Token: 0x06008F53 RID: 36691 RVA: 0x00151C77 File Offset: 0x0014FE77
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

		// Token: 0x06008F54 RID: 36692 RVA: 0x00151C8A File Offset: 0x0014FE8A
		public new IClientSendTagEventToControlCharacter_SetValue ToSetValue()
		{
			return new IClientSendTagEventToControlCharacter_SetValue
			{
				Type = this.Type,
				EventTags = this.EventTags
			};
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x06008F55 RID: 36693 RVA: 0x00151CA9 File Offset: 0x0014FEA9
		// (set) Token: 0x06008F56 RID: 36694 RVA: 0x00151CD4 File Offset: 0x0014FED4
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

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x06008F57 RID: 36695 RVA: 0x00151CE2 File Offset: 0x0014FEE2
		// (set) Token: 0x06008F58 RID: 36696 RVA: 0x00151D09 File Offset: 0x0014FF09
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

		// Token: 0x040059D9 RID: 23001
		[Nullable(2)]
		protected new IClientSendTagEventToControlCharacter FbInstance;

		// Token: 0x040059DA RID: 23002
		[Nullable(2)]
		protected new IClientSendTagEventToControlCharacter_SetValue PocoInterface;
	}
}
