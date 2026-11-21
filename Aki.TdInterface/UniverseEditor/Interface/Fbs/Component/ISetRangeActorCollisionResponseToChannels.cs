using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F10 RID: 24336
	public struct ISetRangeActorCollisionResponseToChannels : IFlatbufferObject
	{
		// Token: 0x1700B3FE RID: 46078
		// (get) Token: 0x06028D88 RID: 167304 RVA: 0x00594FFC File Offset: 0x005931FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D89 RID: 167305 RVA: 0x00595009 File Offset: 0x00593209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06028D8A RID: 167306 RVA: 0x00595018 File Offset: 0x00593218
		public ISetRangeActorCollisionResponseToChannels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3FF RID: 46079
		// (get) Token: 0x06028D8B RID: 167307 RVA: 0x00595028 File Offset: 0x00593228
		public ECollisionChannelType CollisionChannelType
		{
			get
			{
				return (ECollisionChannelType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700B400 RID: 46080
		// (get) Token: 0x06028D8C RID: 167308 RVA: 0x00595045 File Offset: 0x00593245
		public ECollisionResponseType CollisionResponseType
		{
			get
			{
				return (ECollisionResponseType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x06028D8D RID: 167309 RVA: 0x00595064 File Offset: 0x00593264
		public static Offset<ISetRangeActorCollisionResponseToChannels> CreateISetRangeActorCollisionResponseToChannels(FlatBufferBuilder builder, ECollisionChannelType CollisionChannelType, ECollisionResponseType CollisionResponseType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)CollisionResponseType);
			builder.PutByte((byte)CollisionChannelType);
			return new Offset<ISetRangeActorCollisionResponseToChannels>(builder.Offset);
		}

		// Token: 0x06028D8E RID: 167310 RVA: 0x00595088 File Offset: 0x00593288
		public ISetRangeActorCollisionResponseToChannelsT UnPack()
		{
			ISetRangeActorCollisionResponseToChannelsT setRangeActorCollisionResponseToChannelsT = new ISetRangeActorCollisionResponseToChannelsT();
			this.UnPackTo(setRangeActorCollisionResponseToChannelsT);
			return setRangeActorCollisionResponseToChannelsT;
		}

		// Token: 0x06028D8F RID: 167311 RVA: 0x005950A3 File Offset: 0x005932A3
		public void UnPackTo(ISetRangeActorCollisionResponseToChannelsT _o)
		{
			_o.CollisionChannelType = this.CollisionChannelType;
			_o.CollisionResponseType = this.CollisionResponseType;
		}

		// Token: 0x06028D90 RID: 167312 RVA: 0x005950C0 File Offset: 0x005932C0
		public static Offset<ISetRangeActorCollisionResponseToChannels> Pack(FlatBufferBuilder builder, ISetRangeActorCollisionResponseToChannelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRangeActorCollisionResponseToChannels>);
			}
			return ISetRangeActorCollisionResponseToChannels.CreateISetRangeActorCollisionResponseToChannels(builder, _o.CollisionChannelType, _o.CollisionResponseType);
		}

		// Token: 0x0400FB97 RID: 64407
		private Struct __p;
	}
}
