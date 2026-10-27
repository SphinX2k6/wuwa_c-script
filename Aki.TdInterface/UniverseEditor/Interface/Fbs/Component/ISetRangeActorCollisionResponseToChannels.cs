using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005903 RID: 22787
	public struct ISetRangeActorCollisionResponseToChannels : IFlatbufferObject
	{
		// Token: 0x1700AACA RID: 43722
		// (get) Token: 0x0602681E RID: 157726 RVA: 0x0054E390 File Offset: 0x0054C590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602681F RID: 157727 RVA: 0x0054E39D File Offset: 0x0054C59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06026820 RID: 157728 RVA: 0x0054E3AC File Offset: 0x0054C5AC
		public ISetRangeActorCollisionResponseToChannels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AACB RID: 43723
		// (get) Token: 0x06026821 RID: 157729 RVA: 0x0054E3BC File Offset: 0x0054C5BC
		public ECollisionChannelType CollisionChannelType
		{
			get
			{
				return (ECollisionChannelType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700AACC RID: 43724
		// (get) Token: 0x06026822 RID: 157730 RVA: 0x0054E3D9 File Offset: 0x0054C5D9
		public ECollisionResponseType CollisionResponseType
		{
			get
			{
				return (ECollisionResponseType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x06026823 RID: 157731 RVA: 0x0054E3F8 File Offset: 0x0054C5F8
		public static Offset<ISetRangeActorCollisionResponseToChannels> CreateISetRangeActorCollisionResponseToChannels(FlatBufferBuilder builder, ECollisionChannelType CollisionChannelType, ECollisionResponseType CollisionResponseType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)CollisionResponseType);
			builder.PutByte((byte)CollisionChannelType);
			return new Offset<ISetRangeActorCollisionResponseToChannels>(builder.Offset);
		}

		// Token: 0x06026824 RID: 157732 RVA: 0x0054E41C File Offset: 0x0054C61C
		public ISetRangeActorCollisionResponseToChannelsT UnPack()
		{
			ISetRangeActorCollisionResponseToChannelsT setRangeActorCollisionResponseToChannelsT = new ISetRangeActorCollisionResponseToChannelsT();
			this.UnPackTo(setRangeActorCollisionResponseToChannelsT);
			return setRangeActorCollisionResponseToChannelsT;
		}

		// Token: 0x06026825 RID: 157733 RVA: 0x0054E437 File Offset: 0x0054C637
		public void UnPackTo(ISetRangeActorCollisionResponseToChannelsT _o)
		{
			_o.CollisionChannelType = this.CollisionChannelType;
			_o.CollisionResponseType = this.CollisionResponseType;
		}

		// Token: 0x06026826 RID: 157734 RVA: 0x0054E454 File Offset: 0x0054C654
		public static Offset<ISetRangeActorCollisionResponseToChannels> Pack(FlatBufferBuilder builder, ISetRangeActorCollisionResponseToChannelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRangeActorCollisionResponseToChannels>);
			}
			return ISetRangeActorCollisionResponseToChannels.CreateISetRangeActorCollisionResponseToChannels(builder, _o.CollisionChannelType, _o.CollisionResponseType);
		}

		// Token: 0x0400EEA2 RID: 61090
		private Struct __p;
	}
}
