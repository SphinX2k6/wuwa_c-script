using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200639D RID: 25501
	public struct IClientEventFlyingFlowerUpdateSubtitle : IFlatbufferObject
	{
		// Token: 0x1700BE1E RID: 48670
		// (get) Token: 0x0602C1DD RID: 180701 RVA: 0x0060F356 File Offset: 0x0060D556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1DE RID: 180702 RVA: 0x0060F363 File Offset: 0x0060D563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1DF RID: 180703 RVA: 0x0060F36C File Offset: 0x0060D56C
		public static IClientEventFlyingFlowerUpdateSubtitle GetRootAsIClientEventFlyingFlowerUpdateSubtitle(ByteBuffer _bb)
		{
			return IClientEventFlyingFlowerUpdateSubtitle.GetRootAsIClientEventFlyingFlowerUpdateSubtitle(_bb, default(IClientEventFlyingFlowerUpdateSubtitle));
		}

		// Token: 0x0602C1E0 RID: 180704 RVA: 0x0060F388 File Offset: 0x0060D588
		public static IClientEventFlyingFlowerUpdateSubtitle GetRootAsIClientEventFlyingFlowerUpdateSubtitle(ByteBuffer _bb, IClientEventFlyingFlowerUpdateSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1E1 RID: 180705 RVA: 0x0060F3A5 File Offset: 0x0060D5A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1E2 RID: 180706 RVA: 0x0060F3B4 File Offset: 0x0060D5B4
		public IClientEventFlyingFlowerUpdateSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE1F RID: 48671
		// (get) Token: 0x0602C1E3 RID: 180707 RVA: 0x0060F3C4 File Offset: 0x0060D5C4
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

		// Token: 0x1700BE20 RID: 48672
		// (get) Token: 0x0602C1E4 RID: 180708 RVA: 0x0060F400 File Offset: 0x0060D600
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

		// Token: 0x0602C1E5 RID: 180709 RVA: 0x0060F45D File Offset: 0x0060D65D
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> CreateIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType Type = EClientEventFlyingFlowerEventType.UpdateSubtitle, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IClientEventFlyingFlowerUpdateSubtitle.AddFlow(builder, FlowOffset);
			IClientEventFlyingFlowerUpdateSubtitle.AddType(builder, Type);
			return IClientEventFlyingFlowerUpdateSubtitle.EndIClientEventFlyingFlowerUpdateSubtitle(builder);
		}

		// Token: 0x0602C1E6 RID: 180710 RVA: 0x0060F47A File Offset: 0x0060D67A
		public static void StartIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C1E7 RID: 180711 RVA: 0x0060F483 File Offset: 0x0060D683
		public static void AddType(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C1E8 RID: 180712 RVA: 0x0060F48E File Offset: 0x0060D68E
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0602C1E9 RID: 180713 RVA: 0x0060F49E File Offset: 0x0060D69E
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> EndIClientEventFlyingFlowerUpdateSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventFlyingFlowerUpdateSubtitle>(builder.EndTable());
		}

		// Token: 0x0602C1EA RID: 180714 RVA: 0x0060F4AC File Offset: 0x0060D6AC
		public IClientEventFlyingFlowerUpdateSubtitleT UnPack()
		{
			IClientEventFlyingFlowerUpdateSubtitleT clientEventFlyingFlowerUpdateSubtitleT = new IClientEventFlyingFlowerUpdateSubtitleT();
			this.UnPackTo(clientEventFlyingFlowerUpdateSubtitleT);
			return clientEventFlyingFlowerUpdateSubtitleT;
		}

		// Token: 0x0602C1EB RID: 180715 RVA: 0x0060F4C8 File Offset: 0x0060D6C8
		public void UnPackTo(IClientEventFlyingFlowerUpdateSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0602C1EC RID: 180716 RVA: 0x0060F510 File Offset: 0x0060D710
		public static Offset<IClientEventFlyingFlowerUpdateSubtitle> Pack(FlatBufferBuilder builder, IClientEventFlyingFlowerUpdateSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventFlyingFlowerUpdateSubtitle>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IClientEventFlyingFlowerUpdateSubtitle.CreateIClientEventFlyingFlowerUpdateSubtitle(builder, _o.Type, flowOffset);
		}

		// Token: 0x0401096E RID: 67950
		private Table __p;
	}
}
