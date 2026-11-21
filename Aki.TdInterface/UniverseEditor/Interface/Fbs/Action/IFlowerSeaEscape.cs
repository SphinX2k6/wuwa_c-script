using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E90 RID: 28304
	public struct IFlowerSeaEscape : IFlatbufferObject
	{
		// Token: 0x1700CF68 RID: 53096
		// (get) Token: 0x06030E80 RID: 200320 RVA: 0x006A21ED File Offset: 0x006A03ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E81 RID: 200321 RVA: 0x006A21FA File Offset: 0x006A03FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E82 RID: 200322 RVA: 0x006A2204 File Offset: 0x006A0404
		public static IFlowerSeaEscape GetRootAsIFlowerSeaEscape(ByteBuffer _bb)
		{
			return IFlowerSeaEscape.GetRootAsIFlowerSeaEscape(_bb, default(IFlowerSeaEscape));
		}

		// Token: 0x06030E83 RID: 200323 RVA: 0x006A2220 File Offset: 0x006A0420
		public static IFlowerSeaEscape GetRootAsIFlowerSeaEscape(ByteBuffer _bb, IFlowerSeaEscape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E84 RID: 200324 RVA: 0x006A223D File Offset: 0x006A043D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E85 RID: 200325 RVA: 0x006A224C File Offset: 0x006A044C
		public IFlowerSeaEscape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF69 RID: 53097
		// (get) Token: 0x06030E86 RID: 200326 RVA: 0x006A225C File Offset: 0x006A045C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF6A RID: 53098
		// (get) Token: 0x06030E87 RID: 200327 RVA: 0x006A2298 File Offset: 0x006A0498
		public int EndAreaEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF6B RID: 53099
		// (get) Token: 0x06030E88 RID: 200328 RVA: 0x006A22D4 File Offset: 0x006A04D4
		public string ConfigDa
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030E89 RID: 200329 RVA: 0x006A230B File Offset: 0x006A050B
		public Span<byte> GetConfigDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030E8A RID: 200330 RVA: 0x006A231A File Offset: 0x006A051A
		public byte[] GetConfigDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CF6C RID: 53100
		// (get) Token: 0x06030E8B RID: 200331 RVA: 0x006A2328 File Offset: 0x006A0528
		public string SpreadingState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030E8C RID: 200332 RVA: 0x006A2360 File Offset: 0x006A0560
		public Span<byte> GetSpreadingStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06030E8D RID: 200333 RVA: 0x006A2370 File Offset: 0x006A0570
		public byte[] GetSpreadingStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700CF6D RID: 53101
		// (get) Token: 0x06030E8E RID: 200334 RVA: 0x006A2380 File Offset: 0x006A0580
		public string PausedState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030E8F RID: 200335 RVA: 0x006A23B8 File Offset: 0x006A05B8
		public Span<byte> GetPausedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06030E90 RID: 200336 RVA: 0x006A23C8 File Offset: 0x006A05C8
		public byte[] GetPausedStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700CF6E RID: 53102
		// (get) Token: 0x06030E91 RID: 200337 RVA: 0x006A23D8 File Offset: 0x006A05D8
		public string ResetState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030E92 RID: 200338 RVA: 0x006A2410 File Offset: 0x006A0610
		public Span<byte> GetResetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06030E93 RID: 200339 RVA: 0x006A2420 File Offset: 0x006A0620
		public byte[] GetResetStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x06030E94 RID: 200340 RVA: 0x006A242F File Offset: 0x006A062F
		public static Offset<IFlowerSeaEscape> CreateIFlowerSeaEscape(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int EndAreaEntityId = 0, StringOffset ConfigDaOffset = default(StringOffset), StringOffset SpreadingStateOffset = default(StringOffset), StringOffset PausedStateOffset = default(StringOffset), StringOffset ResetStateOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IFlowerSeaEscape.AddResetState(builder, ResetStateOffset);
			IFlowerSeaEscape.AddPausedState(builder, PausedStateOffset);
			IFlowerSeaEscape.AddSpreadingState(builder, SpreadingStateOffset);
			IFlowerSeaEscape.AddConfigDa(builder, ConfigDaOffset);
			IFlowerSeaEscape.AddEndAreaEntityId(builder, EndAreaEntityId);
			IFlowerSeaEscape.AddType(builder, Type);
			return IFlowerSeaEscape.EndIFlowerSeaEscape(builder);
		}

		// Token: 0x06030E95 RID: 200341 RVA: 0x006A246B File Offset: 0x006A066B
		public static void StartIFlowerSeaEscape(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030E96 RID: 200342 RVA: 0x006A2474 File Offset: 0x006A0674
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E97 RID: 200343 RVA: 0x006A247F File Offset: 0x006A067F
		public static void AddEndAreaEntityId(FlatBufferBuilder builder, int endAreaEntityId)
		{
			builder.AddInt(1, endAreaEntityId, 0);
		}

		// Token: 0x06030E98 RID: 200344 RVA: 0x006A248A File Offset: 0x006A068A
		public static void AddConfigDa(FlatBufferBuilder builder, StringOffset configDaOffset)
		{
			builder.AddOffset(2, configDaOffset.Value, 0);
		}

		// Token: 0x06030E99 RID: 200345 RVA: 0x006A249A File Offset: 0x006A069A
		public static void AddSpreadingState(FlatBufferBuilder builder, StringOffset spreadingStateOffset)
		{
			builder.AddOffset(3, spreadingStateOffset.Value, 0);
		}

		// Token: 0x06030E9A RID: 200346 RVA: 0x006A24AA File Offset: 0x006A06AA
		public static void AddPausedState(FlatBufferBuilder builder, StringOffset pausedStateOffset)
		{
			builder.AddOffset(4, pausedStateOffset.Value, 0);
		}

		// Token: 0x06030E9B RID: 200347 RVA: 0x006A24BA File Offset: 0x006A06BA
		public static void AddResetState(FlatBufferBuilder builder, StringOffset resetStateOffset)
		{
			builder.AddOffset(5, resetStateOffset.Value, 0);
		}

		// Token: 0x06030E9C RID: 200348 RVA: 0x006A24CA File Offset: 0x006A06CA
		public static Offset<IFlowerSeaEscape> EndIFlowerSeaEscape(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerSeaEscape>(builder.EndTable());
		}

		// Token: 0x06030E9D RID: 200349 RVA: 0x006A24D8 File Offset: 0x006A06D8
		public IFlowerSeaEscapeT UnPack()
		{
			IFlowerSeaEscapeT flowerSeaEscapeT = new IFlowerSeaEscapeT();
			this.UnPackTo(flowerSeaEscapeT);
			return flowerSeaEscapeT;
		}

		// Token: 0x06030E9E RID: 200350 RVA: 0x006A24F4 File Offset: 0x006A06F4
		public void UnPackTo(IFlowerSeaEscapeT _o)
		{
			_o.Type = this.Type;
			_o.EndAreaEntityId = this.EndAreaEntityId;
			_o.ConfigDa = this.ConfigDa;
			_o.SpreadingState = this.SpreadingState;
			_o.PausedState = this.PausedState;
			_o.ResetState = this.ResetState;
		}

		// Token: 0x06030E9F RID: 200351 RVA: 0x006A254C File Offset: 0x006A074C
		public static Offset<IFlowerSeaEscape> Pack(FlatBufferBuilder builder, IFlowerSeaEscapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowerSeaEscape>);
			}
			StringOffset configDaOffset = (_o.ConfigDa == null) ? default(StringOffset) : builder.CreateString(_o.ConfigDa);
			StringOffset spreadingStateOffset = (_o.SpreadingState == null) ? default(StringOffset) : builder.CreateString(_o.SpreadingState);
			StringOffset pausedStateOffset = (_o.PausedState == null) ? default(StringOffset) : builder.CreateString(_o.PausedState);
			StringOffset resetStateOffset = (_o.ResetState == null) ? default(StringOffset) : builder.CreateString(_o.ResetState);
			return IFlowerSeaEscape.CreateIFlowerSeaEscape(builder, _o.Type, _o.EndAreaEntityId, configDaOffset, spreadingStateOffset, pausedStateOffset, resetStateOffset);
		}

		// Token: 0x04011D66 RID: 73062
		private Table __p;
	}
}
