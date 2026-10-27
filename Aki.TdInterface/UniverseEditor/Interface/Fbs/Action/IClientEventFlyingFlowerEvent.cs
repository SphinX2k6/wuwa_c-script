using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006397 RID: 25495
	public struct IClientEventFlyingFlowerEvent : IFlatbufferObject
	{
		// Token: 0x1700BE19 RID: 48665
		// (get) Token: 0x0602C1BF RID: 180671 RVA: 0x0060F0E1 File Offset: 0x0060D2E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1C0 RID: 180672 RVA: 0x0060F0EE File Offset: 0x0060D2EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1C1 RID: 180673 RVA: 0x0060F0F8 File Offset: 0x0060D2F8
		public static IClientEventFlyingFlowerEvent GetRootAsIClientEventFlyingFlowerEvent(ByteBuffer _bb)
		{
			return IClientEventFlyingFlowerEvent.GetRootAsIClientEventFlyingFlowerEvent(_bb, default(IClientEventFlyingFlowerEvent));
		}

		// Token: 0x0602C1C2 RID: 180674 RVA: 0x0060F114 File Offset: 0x0060D314
		public static IClientEventFlyingFlowerEvent GetRootAsIClientEventFlyingFlowerEvent(ByteBuffer _bb, IClientEventFlyingFlowerEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1C3 RID: 180675 RVA: 0x0060F131 File Offset: 0x0060D331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1C4 RID: 180676 RVA: 0x0060F140 File Offset: 0x0060D340
		public IClientEventFlyingFlowerEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE1A RID: 48666
		// (get) Token: 0x0602C1C5 RID: 180677 RVA: 0x0060F150 File Offset: 0x0060D350
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

		// Token: 0x0602C1C6 RID: 180678 RVA: 0x0060F18C File Offset: 0x0060D38C
		public static Offset<IClientEventFlyingFlowerEvent> CreateIClientEventFlyingFlowerEvent(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType Type = EClientEventFlyingFlowerEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventFlyingFlowerEvent.AddType(builder, Type);
			return IClientEventFlyingFlowerEvent.EndIClientEventFlyingFlowerEvent(builder);
		}

		// Token: 0x0602C1C7 RID: 180679 RVA: 0x0060F1A2 File Offset: 0x0060D3A2
		public static void StartIClientEventFlyingFlowerEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C1C8 RID: 180680 RVA: 0x0060F1AB File Offset: 0x0060D3AB
		public static void AddType(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C1C9 RID: 180681 RVA: 0x0060F1B6 File Offset: 0x0060D3B6
		public static Offset<IClientEventFlyingFlowerEvent> EndIClientEventFlyingFlowerEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventFlyingFlowerEvent>(builder.EndTable());
		}

		// Token: 0x0602C1CA RID: 180682 RVA: 0x0060F1C4 File Offset: 0x0060D3C4
		public IClientEventFlyingFlowerEventT UnPack()
		{
			IClientEventFlyingFlowerEventT clientEventFlyingFlowerEventT = new IClientEventFlyingFlowerEventT();
			this.UnPackTo(clientEventFlyingFlowerEventT);
			return clientEventFlyingFlowerEventT;
		}

		// Token: 0x0602C1CB RID: 180683 RVA: 0x0060F1DF File Offset: 0x0060D3DF
		public void UnPackTo(IClientEventFlyingFlowerEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C1CC RID: 180684 RVA: 0x0060F1F0 File Offset: 0x0060D3F0
		public static Offset<IClientEventFlyingFlowerEvent> Pack(FlatBufferBuilder builder, IClientEventFlyingFlowerEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventFlyingFlowerEvent>);
			}
			return IClientEventFlyingFlowerEvent.CreateIClientEventFlyingFlowerEvent(builder, _o.Type);
		}

		// Token: 0x04010966 RID: 67942
		private Table __p;
	}
}
