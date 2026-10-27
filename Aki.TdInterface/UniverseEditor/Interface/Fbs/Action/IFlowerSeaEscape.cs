using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006810 RID: 26640
	public struct IFlowerSeaEscape : IFlatbufferObject
	{
		// Token: 0x1700C5B2 RID: 50610
		// (get) Token: 0x0602E63A RID: 190010 RVA: 0x00654AA9 File Offset: 0x00652CA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E63B RID: 190011 RVA: 0x00654AB6 File Offset: 0x00652CB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E63C RID: 190012 RVA: 0x00654AC0 File Offset: 0x00652CC0
		public static IFlowerSeaEscape GetRootAsIFlowerSeaEscape(ByteBuffer _bb)
		{
			return IFlowerSeaEscape.GetRootAsIFlowerSeaEscape(_bb, default(IFlowerSeaEscape));
		}

		// Token: 0x0602E63D RID: 190013 RVA: 0x00654ADC File Offset: 0x00652CDC
		public static IFlowerSeaEscape GetRootAsIFlowerSeaEscape(ByteBuffer _bb, IFlowerSeaEscape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E63E RID: 190014 RVA: 0x00654AF9 File Offset: 0x00652CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E63F RID: 190015 RVA: 0x00654B08 File Offset: 0x00652D08
		public IFlowerSeaEscape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5B3 RID: 50611
		// (get) Token: 0x0602E640 RID: 190016 RVA: 0x00654B18 File Offset: 0x00652D18
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

		// Token: 0x1700C5B4 RID: 50612
		// (get) Token: 0x0602E641 RID: 190017 RVA: 0x00654B54 File Offset: 0x00652D54
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

		// Token: 0x1700C5B5 RID: 50613
		// (get) Token: 0x0602E642 RID: 190018 RVA: 0x00654B90 File Offset: 0x00652D90
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

		// Token: 0x0602E643 RID: 190019 RVA: 0x00654BC7 File Offset: 0x00652DC7
		public Span<byte> GetConfigDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E644 RID: 190020 RVA: 0x00654BD6 File Offset: 0x00652DD6
		public byte[] GetConfigDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C5B6 RID: 50614
		// (get) Token: 0x0602E645 RID: 190021 RVA: 0x00654BE4 File Offset: 0x00652DE4
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

		// Token: 0x0602E646 RID: 190022 RVA: 0x00654C1C File Offset: 0x00652E1C
		public Span<byte> GetSpreadingStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602E647 RID: 190023 RVA: 0x00654C2C File Offset: 0x00652E2C
		public byte[] GetSpreadingStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C5B7 RID: 50615
		// (get) Token: 0x0602E648 RID: 190024 RVA: 0x00654C3C File Offset: 0x00652E3C
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

		// Token: 0x0602E649 RID: 190025 RVA: 0x00654C74 File Offset: 0x00652E74
		public Span<byte> GetPausedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602E64A RID: 190026 RVA: 0x00654C84 File Offset: 0x00652E84
		public byte[] GetPausedStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C5B8 RID: 50616
		// (get) Token: 0x0602E64B RID: 190027 RVA: 0x00654C94 File Offset: 0x00652E94
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

		// Token: 0x0602E64C RID: 190028 RVA: 0x00654CCC File Offset: 0x00652ECC
		public Span<byte> GetResetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602E64D RID: 190029 RVA: 0x00654CDC File Offset: 0x00652EDC
		public byte[] GetResetStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602E64E RID: 190030 RVA: 0x00654CEB File Offset: 0x00652EEB
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

		// Token: 0x0602E64F RID: 190031 RVA: 0x00654D27 File Offset: 0x00652F27
		public static void StartIFlowerSeaEscape(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E650 RID: 190032 RVA: 0x00654D30 File Offset: 0x00652F30
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E651 RID: 190033 RVA: 0x00654D3B File Offset: 0x00652F3B
		public static void AddEndAreaEntityId(FlatBufferBuilder builder, int endAreaEntityId)
		{
			builder.AddInt(1, endAreaEntityId, 0);
		}

		// Token: 0x0602E652 RID: 190034 RVA: 0x00654D46 File Offset: 0x00652F46
		public static void AddConfigDa(FlatBufferBuilder builder, StringOffset configDaOffset)
		{
			builder.AddOffset(2, configDaOffset.Value, 0);
		}

		// Token: 0x0602E653 RID: 190035 RVA: 0x00654D56 File Offset: 0x00652F56
		public static void AddSpreadingState(FlatBufferBuilder builder, StringOffset spreadingStateOffset)
		{
			builder.AddOffset(3, spreadingStateOffset.Value, 0);
		}

		// Token: 0x0602E654 RID: 190036 RVA: 0x00654D66 File Offset: 0x00652F66
		public static void AddPausedState(FlatBufferBuilder builder, StringOffset pausedStateOffset)
		{
			builder.AddOffset(4, pausedStateOffset.Value, 0);
		}

		// Token: 0x0602E655 RID: 190037 RVA: 0x00654D76 File Offset: 0x00652F76
		public static void AddResetState(FlatBufferBuilder builder, StringOffset resetStateOffset)
		{
			builder.AddOffset(5, resetStateOffset.Value, 0);
		}

		// Token: 0x0602E656 RID: 190038 RVA: 0x00654D86 File Offset: 0x00652F86
		public static Offset<IFlowerSeaEscape> EndIFlowerSeaEscape(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerSeaEscape>(builder.EndTable());
		}

		// Token: 0x0602E657 RID: 190039 RVA: 0x00654D94 File Offset: 0x00652F94
		public IFlowerSeaEscapeT UnPack()
		{
			IFlowerSeaEscapeT flowerSeaEscapeT = new IFlowerSeaEscapeT();
			this.UnPackTo(flowerSeaEscapeT);
			return flowerSeaEscapeT;
		}

		// Token: 0x0602E658 RID: 190040 RVA: 0x00654DB0 File Offset: 0x00652FB0
		public void UnPackTo(IFlowerSeaEscapeT _o)
		{
			_o.Type = this.Type;
			_o.EndAreaEntityId = this.EndAreaEntityId;
			_o.ConfigDa = this.ConfigDa;
			_o.SpreadingState = this.SpreadingState;
			_o.PausedState = this.PausedState;
			_o.ResetState = this.ResetState;
		}

		// Token: 0x0602E659 RID: 190041 RVA: 0x00654E08 File Offset: 0x00653008
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

		// Token: 0x04010F34 RID: 69428
		private Table __p;
	}
}
