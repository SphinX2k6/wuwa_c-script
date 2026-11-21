using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001961 RID: 6497
	public class IAssistCharacterMoveType
	{
		// Token: 0x06008A2B RID: 35371 RVA: 0x001489D8 File Offset: 0x00146BD8
		private IAssistCharacterMoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssistCharacterMoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssistCharacterMoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssistCharacterMoveType_SetValue());
			}
			return result;
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x00148A10 File Offset: 0x00146C10
		public static IAssistCharacterMoveType Create([Nullable(2)] IAssistCharacterMoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterMoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x00148A23 File Offset: 0x00146C23
		public static IAssistCharacterMoveType CreateFromSetValue([Nullable(2)] IAssistCharacterMoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssistCharacterMoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00148A36 File Offset: 0x00146C36
		public IAssistCharacterMoveType_SetValue ToSetValue()
		{
			return new IAssistCharacterMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x00148A49 File Offset: 0x00146C49
		// (set) Token: 0x06008A30 RID: 35376 RVA: 0x00148A74 File Offset: 0x00146C74
		public virtual EAssistCharacterMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005785 RID: 22405
		[Nullable(2)]
		protected IAssistCharacterMoveType FbInstance;

		// Token: 0x04005786 RID: 22406
		[Nullable(2)]
		protected IAssistCharacterMoveType_SetValue PocoInterface;
	}
}
