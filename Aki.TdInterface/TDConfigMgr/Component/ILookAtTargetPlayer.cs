using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D4 RID: 1236
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtTargetPlayer : ILookAtTargetBase
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x0004A788 File Offset: 0x00048988
		private ILookAtTargetPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTargetPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTargetPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTargetPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0004A7C0 File Offset: 0x000489C0
		public static ILookAtTargetPlayer Create([Nullable(2)] ILookAtTargetPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0004A7D3 File Offset: 0x000489D3
		public static ILookAtTargetPlayer CreateFromSetValue([Nullable(2)] ILookAtTargetPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTargetPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0004A7E6 File Offset: 0x000489E6
		public new ILookAtTargetPlayer_SetValue ToSetValue()
		{
			return new ILookAtTargetPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0004A7F9 File Offset: 0x000489F9
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0004A824 File Offset: 0x00048A24
		public override ELookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400127A RID: 4730
		[Nullable(2)]
		protected new ILookAtTargetPlayer FbInstance;

		// Token: 0x0400127B RID: 4731
		[Nullable(2)]
		protected new ILookAtTargetPlayer_SetValue PocoInterface;
	}
}
