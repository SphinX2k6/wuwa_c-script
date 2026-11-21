using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0E RID: 27150
	public struct IClientEventFlyingFlowerUpdateSubtitle : IFlatbufferObject
	{
		// Token: 0x1700C7A2 RID: 51106
		// (get) Token: 0x0602E93F RID: 190783 RVA: 0x0065A38E File Offset: 0x0065858E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E940 RID: 190784 RVA: 0x0065A39B File Offset: 0x0065859B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E941 RID: 190785 RVA: 0x0065A3A4 File Offset: 0x006585A4
		public static IClientEventFlyingFlowerUpdateSubtitle GetRootAsIClientEventFlyingFlowerUpdateSubtitle(ByteBuffer _bb)
		{
			return IClientEventFlyingFlowerUpdateSubtitle.GetRootAsIClientEventFlyingFlowerUpdateSubtitle(_bb, default(IClientEventFlyingFlowerUpdateSubtitle));
		}

		// Token: 0x0602E942 RID: 190786 RVA: 0x0065A3C0 File Offset: 0x006585C0
		public static IClientEventFlyingFlowerUpdateSubtitle GetRootAsIClientEventFlyingFlowerUpdateSubtitle(ByteBuffer _bb, IClientEventFlyingFlowerUpdateSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E943 RID: 190787 RVA: 0x0065A3DD File Offset: 0x006585DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E944 RID: 190788 RVA: 0x0065A3EC File Offset: 0x006585EC
		public IClientEventFlyingFlowerUpdateSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7A3 RID: 51107
		// (get) Token: 0x0602E945 RID: 190789 RVA: 0x0065A3FC File Offset: 0x006585FC
		public EClientEventFlyingFlowerEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventFlyingFlowerEventType.UpdateSubtitle;
				}
				return (EClientEventFlyingFlowerEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7A4 RID: 51108
		// (get) Token: 0x0602E946 RID: 190790 RVA: 0x0065A438 File Offset: 0x00658638
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E947 RID: 190791 RVA: 0x0065A495 File Offset: 0x00658695
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> CreateIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType Type = EClientEventFlyingFlowerEventType.UpdateSubtitle, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IClientEventFlyingFlowerUpdateSubtitle.AddFlow(builder, FlowOffset);
			IClientEventFlyingFlowerUpdateSubtitle.AddType(builder, Type);
			return IClientEventFlyingFlowerUpdateSubtitle.EndIClientEventFlyingFlowerUpdateSubtitle(builder);
		}

		// Token: 0x0602E948 RID: 190792 RVA: 0x0065A4B2 File Offset: 0x006586B2
		public static void StartIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E949 RID: 190793 RVA: 0x0065A4BB File Offset: 0x006586BB
		public static void AddType(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E94A RID: 190794 RVA: 0x0065A4C6 File Offset: 0x006586C6
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0602E94B RID: 190795 RVA: 0x0065A4D6 File Offset: 0x006586D6
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> EndIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventFlyingFlowerUpdateSubtitle>(builder.EndTable());
		}

		// Token: 0x0602E94C RID: 190796 RVA: 0x0065A4E4 File Offset: 0x006586E4
		public IClientEventFlyingFlowerUpdateSubtitleT UnPack()
		{
			IClientEventFlyingFlowerUpdateSubtitleT clientEventFlyingFlowerUpdateSubtitleT = new IClientEventFlyingFlowerUpdateSubtitleT();
			this.UnPackTo(clientEventFlyingFlowerUpdateSubtitleT);
			return clientEventFlyingFlowerUpdateSubtitleT;
		}

		// Token: 0x0602E94D RID: 190797 RVA: 0x0065A500 File Offset: 0x00658700
		public void UnPackTo(IClientEventFlyingFlowerUpdateSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0602E94E RID: 190798 RVA: 0x0065A548 File Offset: 0x00658748
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> Pack(FlatBufferBuilder builder, IClientEventFlyingFlowerUpdateSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventFlyingFlowerUpdateSubtitle>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IClientEventFlyingFlowerUpdateSubtitle.CreateIClientEventFlyingFlowerUpdateSubtitle(builder, _o.Type, flowOffset);
		}

		// Token: 0x04011781 RID: 71553
		private Table __p;
	}
}
