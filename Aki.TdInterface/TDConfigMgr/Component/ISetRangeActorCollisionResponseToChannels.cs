using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C4 RID: 1732
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetRangeActorCollisionResponseToChannels
	{
		// Token: 0x06002538 RID: 9528 RVA: 0x00064660 File Offset: 0x00062860
		private ISetRangeActorCollisionResponseToChannels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetRangeActorCollisionResponseToChannels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetRangeActorCollisionResponseToChannels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetRangeActorCollisionResponseToChannels_SetValue());
			}
			return result;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00064698 File Offset: 0x00062898
		public static ISetRangeActorCollisionResponseToChannels Create([Nullable(2)] ISetRangeActorCollisionResponseToChannels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000646AB File Offset: 0x000628AB
		public static ISetRangeActorCollisionResponseToChannels CreateFromSetValue([Nullable(2)] ISetRangeActorCollisionResponseToChannels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000646BE File Offset: 0x000628BE
		public ISetRangeActorCollisionResponseToChannels_SetValue ToSetValue()
		{
			return new ISetRangeActorCollisionResponseToChannels_SetValue
			{
				CollisionChannelType = this.CollisionChannelType,
				CollisionResponseType = this.CollisionResponseType
			};
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000646DD File Offset: 0x000628DD
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x00064708 File Offset: 0x00062908
		public virtual ECollisionChannelType CollisionChannelType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionChannelType;
				}
				if (this.PocoInterface == null)
				{
					return ECollisionChannelType.WorldStatic;
				}
				return this.PocoInterface.CollisionChannelType;
			}
			set
			{
				this.GetOrCreatePoco().CollisionChannelType = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x00064716 File Offset: 0x00062916
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x00064741 File Offset: 0x00062941
		public virtual ECollisionResponseType CollisionResponseType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionResponseType;
				}
				if (this.PocoInterface == null)
				{
					return ECollisionResponseType.Ignore;
				}
				return this.PocoInterface.CollisionResponseType;
			}
			set
			{
				this.GetOrCreatePoco().CollisionResponseType = value;
			}
		}

		// Token: 0x04001973 RID: 6515
		[Nullable(2)]
		protected ISetRangeActorCollisionResponseToChannels FbInstance;

		// Token: 0x04001974 RID: 6516
		[Nullable(2)]
		protected ISetRangeActorCollisionResponseToChannels_SetValue PocoInterface;
	}
}
