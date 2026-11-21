using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A26 RID: 27174
	public struct IClientEventUiFlyingFlower : IFlatbufferObject
	{
		// Token: 0x1700C7BE RID: 51134
		// (get) Token: 0x0602E9D3 RID: 190931 RVA: 0x0065B1A5 File Offset: 0x006593A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9D4 RID: 190932 RVA: 0x0065B1B2 File Offset: 0x006593B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9D5 RID: 190933 RVA: 0x0065B1BC File Offset: 0x006593BC
		public static IClientEventUiFlyingFlower GetRootAsIClientEventUiFlyingFlower(ByteBuffer _bb)
		{
			return IClientEventUiFlyingFlower.GetRootAsIClientEventUiFlyingFlower(_bb, default(IClientEventUiFlyingFlower));
		}

		// Token: 0x0602E9D6 RID: 190934 RVA: 0x0065B1D8 File Offset: 0x006593D8
		public static IClientEventUiFlyingFlower GetRootAsIClientEventUiFlyingFlower(ByteBuffer _bb, IClientEventUiFlyingFlower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9D7 RID: 190935 RVA: 0x0065B1F5 File Offset: 0x006593F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9D8 RID: 190936 RVA: 0x0065B204 File Offset: 0x00659404
		public IClientEventUiFlyingFlower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7BF RID: 51135
		// (get) Token: 0x0602E9D9 RID: 190937 RVA: 0x0065B214 File Offset: 0x00659414
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

		// Token: 0x1700C7C0 RID: 51136
		// (get) Token: 0x0602E9DA RID: 190938 RVA: 0x0065B250 File Offset: 0x00659450
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

		// Token: 0x0602E9DB RID: 190939 RVA: 0x0065B2AD File Offset: 0x006594AD
		public static Offset<IClientEventUiFlyingFlower> CreateIClientEventUiFlyingFlower(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano, Offset<IClientEventFlyingFlowerUpdateSubtitle> EventTypeOffset = default(Offset<IClientEventFlyingFlowerUpdateSubtitle>))
		{
			builder.StartTable(2);
			IClientEventUiFlyingFlower.AddEventType(builder, EventTypeOffset);
			IClientEventUiFlyingFlower.AddType(builder, Type);
			return IClientEventUiFlyingFlower.EndIClientEventUiFlyingFlower(builder);
		}

		// Token: 0x0602E9DC RID: 190940 RVA: 0x0065B2CA File Offset: 0x006594CA
		public static void StartIClientEventUiFlyingFlower(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E9DD RID: 190941 RVA: 0x0065B2D3 File Offset: 0x006594D3
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9DE RID: 190942 RVA: 0x0065B2DE File Offset: 0x006594DE
		public static void AddEventType(FlatBufferBuilder builder, Offset<IClientEventFlyingFlowerUpdateSubtitle> eventTypeOffset)
		{
			builder.AddOffset(1, eventTypeOffset.Value, 0);
		}

		// Token: 0x0602E9DF RID: 190943 RVA: 0x0065B2EE File Offset: 0x006594EE
		public static Offset<IClientEventUiFlyingFlower> EndIClientEventUiFlyingFlower(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUiFlyingFlower>(builder.EndTable());
		}

		// Token: 0x0602E9E0 RID: 190944 RVA: 0x0065B2FC File Offset: 0x006594FC
		public IClientEventUiFlyingFlowerT UnPack()
		{
			IClientEventUiFlyingFlowerT clientEventUiFlyingFlowerT = new IClientEventUiFlyingFlowerT();
			this.UnPackTo(clientEventUiFlyingFlowerT);
			return clientEventUiFlyingFlowerT;
		}

		// Token: 0x0602E9E1 RID: 190945 RVA: 0x0065B318 File Offset: 0x00659518
		public void UnPackTo(IClientEventUiFlyingFlowerT _o)
		{
			_o.Type = this.Type;
			_o.EventType = ((this.EventType != null) ? this.EventType.Value.UnPack() : null);
		}

		// Token: 0x0602E9E2 RID: 190946 RVA: 0x0065B360 File Offset: 0x00659560
		public static Offset<IClientEventUiFlyingFlower> Pack(FlatBufferBuilder builder, IClientEventUiFlyingFlowerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventUiFlyingFlower>);
			}
			Offset<IClientEventFlyingFlowerUpdateSubtitle> eventTypeOffset = (_o.EventType == null) ? default(Offset<IClientEventFlyingFlowerUpdateSubtitle>) : IClientEventFlyingFlowerUpdateSubtitle.Pack(builder, _o.EventType);
			return IClientEventUiFlyingFlower.CreateIClientEventUiFlyingFlower(builder, _o.Type, eventTypeOffset);
		}

		// Token: 0x0401179E RID: 71582
		private Table __p;
	}
}
