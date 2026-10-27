using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B5 RID: 25525
	public struct IClientEventUiFlyingFlower : IFlatbufferObject
	{
		// Token: 0x1700BE3A RID: 48698
		// (get) Token: 0x0602C271 RID: 180849 RVA: 0x0061016D File Offset: 0x0060E36D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C272 RID: 180850 RVA: 0x0061017A File Offset: 0x0060E37A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C273 RID: 180851 RVA: 0x00610184 File Offset: 0x0060E384
		public static IClientEventUiFlyingFlower GetRootAsIClientEventUiFlyingFlower(ByteBuffer _bb)
		{
			return IClientEventUiFlyingFlower.GetRootAsIClientEventUiFlyingFlower(_bb, default(IClientEventUiFlyingFlower));
		}

		// Token: 0x0602C274 RID: 180852 RVA: 0x006101A0 File Offset: 0x0060E3A0
		public static IClientEventUiFlyingFlower GetRootAsIClientEventUiFlyingFlower(ByteBuffer _bb, IClientEventUiFlyingFlower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C275 RID: 180853 RVA: 0x006101BD File Offset: 0x0060E3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C276 RID: 180854 RVA: 0x006101CC File Offset: 0x0060E3CC
		public IClientEventUiFlyingFlower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE3B RID: 48699
		// (get) Token: 0x0602C277 RID: 180855 RVA: 0x006101DC File Offset: 0x0060E3DC
		public EClientEventUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventUiType.PlayPiano;
				}
				return (EClientEventUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE3C RID: 48700
		// (get) Token: 0x0602C278 RID: 180856 RVA: 0x00610218 File Offset: 0x0060E418
		public IClientEventFlyingFlowerUpdateSubtitle? EventType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IClientEventFlyingFlowerUpdateSubtitle?(default(IClientEventFlyingFlowerUpdateSubtitle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602C279 RID: 180857 RVA: 0x00610275 File Offset: 0x0060E475
		public static Offset<IClientEventUiFlyingFlower> CreateIClientEventUiFlyingFlower(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano, Offset<IClientEventFlyingFlowerUpdateSubtitle> EventTypeOffset = default(Offset<IClientEventFlyingFlowerUpdateSubtitle>))
		{
			builder.StartTable(2);
			IClientEventUiFlyingFlower.AddEventType(builder, EventTypeOffset);
			IClientEventUiFlyingFlower.AddType(builder, Type);
			return IClientEventUiFlyingFlower.EndIClientEventUiFlyingFlower(builder);
		}

		// Token: 0x0602C27A RID: 180858 RVA: 0x00610292 File Offset: 0x0060E492
		public static void StartIClientEventUiFlyingFlower(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C27B RID: 180859 RVA: 0x0061029B File Offset: 0x0060E49B
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C27C RID: 180860 RVA: 0x006102A6 File Offset: 0x0060E4A6
		public static void AddEventType(FlatBufferBuilder builder, Offset<IClientEventFlyingFlowerUpdateSubtitle> eventTypeOffset)
		{
			builder.AddOffset(1, eventTypeOffset.Value, 0);
		}

		// Token: 0x0602C27D RID: 180861 RVA: 0x006102B6 File Offset: 0x0060E4B6
		public static Offset<IClientEventUiFlyingFlower> EndIClientEventUiFlyingFlower(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUiFlyingFlower>(builder.EndTable());
		}

		// Token: 0x0602C27E RID: 180862 RVA: 0x006102C4 File Offset: 0x0060E4C4
		public IClientEventUiFlyingFlowerT UnPack()
		{
			IClientEventUiFlyingFlowerT clientEventUiFlyingFlowerT = new IClientEventUiFlyingFlowerT();
			this.UnPackTo(clientEventUiFlyingFlowerT);
			return clientEventUiFlyingFlowerT;
		}

		// Token: 0x0602C27F RID: 180863 RVA: 0x006102E0 File Offset: 0x0060E4E0
		public void UnPackTo(IClientEventUiFlyingFlowerT _o)
		{
			_o.Type = this.Type;
			_o.EventType = ((this.EventType != null) ? this.EventType.Value.UnPack() : null);
		}

		// Token: 0x0602C280 RID: 180864 RVA: 0x00610328 File Offset: 0x0060E528
		public static Offset<IClientEventUiFlyingFlower> Pack(FlatBufferBuilder builder, IClientEventUiFlyingFlowerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventUiFlyingFlower>);
			}
			Offset<IClientEventFlyingFlowerUpdateSubtitle> eventTypeOffset = (_o.EventType == null) ? default(Offset<IClientEventFlyingFlowerUpdateSubtitle>) : IClientEventFlyingFlowerUpdateSubtitle.Pack(builder, _o.EventType);
			return IClientEventUiFlyingFlower.CreateIClientEventUiFlyingFlower(builder, _o.Type, eventTypeOffset);
		}

		// Token: 0x0401098B RID: 67979
		private Table __p;
	}
}
