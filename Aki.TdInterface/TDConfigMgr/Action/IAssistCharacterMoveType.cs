using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017DA RID: 6106
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssistCharacterMoveType
	{
		// Token: 0x06008319 RID: 33561 RVA: 0x001393F0 File Offset: 0x001375F0
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

		// Token: 0x0600831A RID: 33562 RVA: 0x00139428 File Offset: 0x00137628
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

		// Token: 0x0600831B RID: 33563 RVA: 0x0013943B File Offset: 0x0013763B
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

		// Token: 0x0600831C RID: 33564 RVA: 0x0013944E File Offset: 0x0013764E
		public IAssistCharacterMoveType_SetValue ToSetValue()
		{
			return new IAssistCharacterMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600831D RID: 33565 RVA: 0x00139461 File Offset: 0x00137661
		// (set) Token: 0x0600831E RID: 33566 RVA: 0x0013948C File Offset: 0x0013768C
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

		// Token: 0x04005341 RID: 21313
		[Nullable(2)]
		protected IAssistCharacterMoveType FbInstance;

		// Token: 0x04005342 RID: 21314
		[Nullable(2)]
		protected IAssistCharacterMoveType_SetValue PocoInterface;
	}
}
