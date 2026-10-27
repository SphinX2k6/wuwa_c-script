using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2A RID: 18986
	public struct ICheckFlForestMusicBeats : IFlatbufferObject
	{
		// Token: 0x1700896F RID: 35183
		// (get) Token: 0x0601DB5B RID: 121691 RVA: 0x0042DC92 File Offset: 0x0042BE92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB5C RID: 121692 RVA: 0x0042DC9F File Offset: 0x0042BE9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB5D RID: 121693 RVA: 0x0042DCA8 File Offset: 0x0042BEA8
		public static ICheckFlForestMusicBeats GetRootAsICheckFlForestMusicBeats(ByteBuffer _bb)
		{
			return ICheckFlForestMusicBeats.GetRootAsICheckFlForestMusicBeats(_bb, default(ICheckFlForestMusicBeats));
		}

		// Token: 0x0601DB5E RID: 121694 RVA: 0x0042DCC4 File Offset: 0x0042BEC4
		public static ICheckFlForestMusicBeats GetRootAsICheckFlForestMusicBeats(ByteBuffer _bb, ICheckFlForestMusicBeats obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB5F RID: 121695 RVA: 0x0042DCE1 File Offset: 0x0042BEE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB60 RID: 121696 RVA: 0x0042DCF0 File Offset: 0x0042BEF0
		public ICheckFlForestMusicBeats __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008970 RID: 35184
		// (get) Token: 0x0601DB61 RID: 121697 RVA: 0x0042DD00 File Offset: 0x0042BF00
		public EMusicEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMusicEventType.HcMusicBattle;
				}
				return (EMusicEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008971 RID: 35185
		// (get) Token: 0x0601DB62 RID: 121698 RVA: 0x0042DD3C File Offset: 0x0042BF3C
		public string BeatType
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

		// Token: 0x0601DB63 RID: 121699 RVA: 0x0042DD73 File Offset: 0x0042BF73
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DB64 RID: 121700 RVA: 0x0042DD82 File Offset: 0x0042BF82
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601DB65 RID: 121701 RVA: 0x0042DD90 File Offset: 0x0042BF90
		public static Offset<ICheckFlForestMusicBeats> CreateICheckFlForestMusicBeats(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle, StringOffset BeatTypeOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICheckFlForestMusicBeats.AddBeatType(builder, BeatTypeOffset);
			ICheckFlForestMusicBeats.AddType(builder, Type);
			return ICheckFlForestMusicBeats.EndICheckFlForestMusicBeats(builder);
		}

		// Token: 0x0601DB66 RID: 121702 RVA: 0x0042DDAD File Offset: 0x0042BFAD
		public static void StartICheckFlForestMusicBeats(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DB67 RID: 121703 RVA: 0x0042DDB6 File Offset: 0x0042BFB6
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB68 RID: 121704 RVA: 0x0042DDC1 File Offset: 0x0042BFC1
		public static void AddBeatType(FlatBufferBuilder builder, StringOffset beatTypeOffset)
		{
			builder.AddOffset(1, beatTypeOffset.Value, 0);
		}

		// Token: 0x0601DB69 RID: 121705 RVA: 0x0042DDD1 File Offset: 0x0042BFD1
		public static Offset<ICheckFlForestMusicBeats> EndICheckFlForestMusicBeats(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlForestMusicBeats>(builder.EndTable());
		}

		// Token: 0x0601DB6A RID: 121706 RVA: 0x0042DDE0 File Offset: 0x0042BFE0
		public ICheckFlForestMusicBeatsT UnPack()
		{
			ICheckFlForestMusicBeatsT checkFlForestMusicBeatsT = new ICheckFlForestMusicBeatsT();
			this.UnPackTo(checkFlForestMusicBeatsT);
			return checkFlForestMusicBeatsT;
		}

		// Token: 0x0601DB6B RID: 121707 RVA: 0x0042DDFB File Offset: 0x0042BFFB
		public void UnPackTo(ICheckFlForestMusicBeatsT _o)
		{
			_o.Type = this.Type;
			_o.BeatType = this.BeatType;
		}

		// Token: 0x0601DB6C RID: 121708 RVA: 0x0042DE18 File Offset: 0x0042C018
		public static Offset<ICheckFlForestMusicBeats> Pack(FlatBufferBuilder builder, ICheckFlForestMusicBeatsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlForestMusicBeats>);
			}
			StringOffset beatTypeOffset = (_o.BeatType == null) ? default(StringOffset) : builder.CreateString(_o.BeatType);
			return ICheckFlForestMusicBeats.CreateICheckFlForestMusicBeats(builder, _o.Type, beatTypeOffset);
		}

		// Token: 0x0400D27C RID: 53884
		private Table __p;
	}
}
