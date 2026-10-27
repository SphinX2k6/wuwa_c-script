using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005698 RID: 22168
	public struct IOnDollGrabDeliveryPerform : IFlatbufferObject
	{
		// Token: 0x1700A4D7 RID: 42199
		// (get) Token: 0x06024FDE RID: 151518 RVA: 0x0051BF2B File Offset: 0x0051A12B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FDF RID: 151519 RVA: 0x0051BF38 File Offset: 0x0051A138
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FE0 RID: 151520 RVA: 0x0051BF40 File Offset: 0x0051A140
		public static IOnDollGrabDeliveryPerform GetRootAsIOnDollGrabDeliveryPerform(ByteBuffer _bb)
		{
			return IOnDollGrabDeliveryPerform.GetRootAsIOnDollGrabDeliveryPerform(_bb, default(IOnDollGrabDeliveryPerform));
		}

		// Token: 0x06024FE1 RID: 151521 RVA: 0x0051BF5C File Offset: 0x0051A15C
		public static IOnDollGrabDeliveryPerform GetRootAsIOnDollGrabDeliveryPerform(ByteBuffer _bb, IOnDollGrabDeliveryPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FE2 RID: 151522 RVA: 0x0051BF79 File Offset: 0x0051A179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FE3 RID: 151523 RVA: 0x0051BF88 File Offset: 0x0051A188
		public IOnDollGrabDeliveryPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4D8 RID: 42200
		// (get) Token: 0x06024FE4 RID: 151524 RVA: 0x0051BF98 File Offset: 0x0051A198
		public string EventMontage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FE5 RID: 151525 RVA: 0x0051BFCF File Offset: 0x0051A1CF
		public Span<byte> GetEventMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024FE6 RID: 151526 RVA: 0x0051BFDE File Offset: 0x0051A1DE
		public byte[] GetEventMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A4D9 RID: 42201
		// (get) Token: 0x06024FE7 RID: 151527 RVA: 0x0051BFEC File Offset: 0x0051A1EC
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FE8 RID: 151528 RVA: 0x0051C023 File Offset: 0x0051A223
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024FE9 RID: 151529 RVA: 0x0051C032 File Offset: 0x0051A232
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A4DA RID: 42202
		// (get) Token: 0x06024FEA RID: 151530 RVA: 0x0051C040 File Offset: 0x0051A240
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A4DB RID: 42203
		// (get) Token: 0x06024FEB RID: 151531 RVA: 0x0051C0A0 File Offset: 0x0051A2A0
		public float PerformDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4DC RID: 42204
		// (get) Token: 0x06024FEC RID: 151532 RVA: 0x0051C0E4 File Offset: 0x0051A2E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FED RID: 151533 RVA: 0x0051C121 File Offset: 0x0051A321
		public static Offset<IOnDollGrabDeliveryPerform> CreateIOnDollGrabDeliveryPerform(FlatBufferBuilder builder, StringOffset EventMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), float PerformDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IOnDollGrabDeliveryPerform.AddPerformDuration(builder, PerformDuration);
			IOnDollGrabDeliveryPerform.AddFlow(builder, FlowOffset);
			IOnDollGrabDeliveryPerform.AddStandByMontage(builder, StandByMontageOffset);
			IOnDollGrabDeliveryPerform.AddEventMontage(builder, EventMontageOffset);
			IOnDollGrabDeliveryPerform.AddNullMask(builder, NullMask);
			return IOnDollGrabDeliveryPerform.EndIOnDollGrabDeliveryPerform(builder);
		}

		// Token: 0x06024FEE RID: 151534 RVA: 0x0051C155 File Offset: 0x0051A355
		public static void StartIOnDollGrabDeliveryPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024FEF RID: 151535 RVA: 0x0051C15E File Offset: 0x0051A35E
		public static void AddEventMontage(FlatBufferBuilder builder, StringOffset eventMontageOffset)
		{
			builder.AddOffset(0, eventMontageOffset.Value, 0);
		}

		// Token: 0x06024FF0 RID: 151536 RVA: 0x0051C16E File Offset: 0x0051A36E
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(1, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024FF1 RID: 151537 RVA: 0x0051C17E File Offset: 0x0051A37E
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x06024FF2 RID: 151538 RVA: 0x0051C18E File Offset: 0x0051A38E
		public static void AddPerformDuration(FlatBufferBuilder builder, float performDuration)
		{
			builder.AddFloat(3, performDuration, 0.0);
		}

		// Token: 0x06024FF3 RID: 151539 RVA: 0x0051C1A1 File Offset: 0x0051A3A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024FF4 RID: 151540 RVA: 0x0051C1AC File Offset: 0x0051A3AC
		public static Offset<IOnDollGrabDeliveryPerform> EndIOnDollGrabDeliveryPerform(FlatBufferBuilder builder)
		{
			return new Offset<IOnDollGrabDeliveryPerform>(builder.EndTable());
		}

		// Token: 0x06024FF5 RID: 151541 RVA: 0x0051C1BC File Offset: 0x0051A3BC
		public IOnDollGrabDeliveryPerformT UnPack()
		{
			IOnDollGrabDeliveryPerformT onDollGrabDeliveryPerformT = new IOnDollGrabDeliveryPerformT();
			this.UnPackTo(onDollGrabDeliveryPerformT);
			return onDollGrabDeliveryPerformT;
		}

		// Token: 0x06024FF6 RID: 151542 RVA: 0x0051C1D8 File Offset: 0x0051A3D8
		public void UnPackTo(IOnDollGrabDeliveryPerformT _o)
		{
			_o.EventMontage = this.EventMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.PerformDuration = this.PerformDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024FF7 RID: 151543 RVA: 0x0051C244 File Offset: 0x0051A444
		public static Offset<IOnDollGrabDeliveryPerform> Pack(FlatBufferBuilder builder, IOnDollGrabDeliveryPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnDollGrabDeliveryPerform>);
			}
			StringOffset eventMontageOffset = (_o.EventMontage == null) ? default(StringOffset) : builder.CreateString(_o.EventMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IOnDollGrabDeliveryPerform.CreateIOnDollGrabDeliveryPerform(builder, eventMontageOffset, standByMontageOffset, flowOffset, _o.PerformDuration, _o.NullMask);
		}

		// Token: 0x0400EAB9 RID: 60089
		private Table __p;
	}
}
