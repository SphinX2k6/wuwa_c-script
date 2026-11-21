using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EED RID: 20205
	public struct ICheckFlForestMusicBeats : IFlatbufferObject
	{
		// Token: 0x17009044 RID: 36932
		// (get) Token: 0x0601F5E4 RID: 128484 RVA: 0x0045EB8A File Offset: 0x0045CD8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F5E5 RID: 128485 RVA: 0x0045EB97 File Offset: 0x0045CD97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F5E6 RID: 128486 RVA: 0x0045EBA0 File Offset: 0x0045CDA0
		public static ICheckFlForestMusicBeats GetRootAsICheckFlForestMusicBeats(ByteBuffer _bb)
		{
			return ICheckFlForestMusicBeats.GetRootAsICheckFlForestMusicBeats(_bb, default(ICheckFlForestMusicBeats));
		}

		// Token: 0x0601F5E7 RID: 128487 RVA: 0x0045EBBC File Offset: 0x0045CDBC
		public static ICheckFlForestMusicBeats GetRootAsICheckFlForestMusicBeats(ByteBuffer _bb, ICheckFlForestMusicBeats obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F5E8 RID: 128488 RVA: 0x0045EBD9 File Offset: 0x0045CDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F5E9 RID: 128489 RVA: 0x0045EBE8 File Offset: 0x0045CDE8
		public ICheckFlForestMusicBeats __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009045 RID: 36933
		// (get) Token: 0x0601F5EA RID: 128490 RVA: 0x0045EBF8 File Offset: 0x0045CDF8
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

		// Token: 0x17009046 RID: 36934
		// (get) Token: 0x0601F5EB RID: 128491 RVA: 0x0045EC34 File Offset: 0x0045CE34
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

		// Token: 0x0601F5EC RID: 128492 RVA: 0x0045EC6B File Offset: 0x0045CE6B
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F5ED RID: 128493 RVA: 0x0045EC7A File Offset: 0x0045CE7A
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601F5EE RID: 128494 RVA: 0x0045EC88 File Offset: 0x0045CE88
		public static Offset<ICheckFlForestMusicBeats> CreateICheckFlForestMusicBeats(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle, StringOffset BeatTypeOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICheckFlForestMusicBeats.AddBeatType(builder, BeatTypeOffset);
			ICheckFlForestMusicBeats.AddType(builder, Type);
			return ICheckFlForestMusicBeats.EndICheckFlForestMusicBeats(builder);
		}

		// Token: 0x0601F5EF RID: 128495 RVA: 0x0045ECA5 File Offset: 0x0045CEA5
		public static void StartICheckFlForestMusicBeats(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F5F0 RID: 128496 RVA: 0x0045ECAE File Offset: 0x0045CEAE
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F5F1 RID: 128497 RVA: 0x0045ECB9 File Offset: 0x0045CEB9
		public static void AddBeatType(FlatBufferBuilder builder, StringOffset beatTypeOffset)
		{
			builder.AddOffset(1, beatTypeOffset.Value, 0);
		}

		// Token: 0x0601F5F2 RID: 128498 RVA: 0x0045ECC9 File Offset: 0x0045CEC9
		public static Offset<ICheckFlForestMusicBeats> EndICheckFlForestMusicBeats(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlForestMusicBeats>(builder.EndTable());
		}

		// Token: 0x0601F5F3 RID: 128499 RVA: 0x0045ECD8 File Offset: 0x0045CED8
		public ICheckFlForestMusicBeatsT UnPack()
		{
			ICheckFlForestMusicBeatsT checkFlForestMusicBeatsT = new ICheckFlForestMusicBeatsT();
			this.UnPackTo(checkFlForestMusicBeatsT);
			return checkFlForestMusicBeatsT;
		}

		// Token: 0x0601F5F4 RID: 128500 RVA: 0x0045ECF3 File Offset: 0x0045CEF3
		public void UnPackTo(ICheckFlForestMusicBeatsT _o)
		{
			_o.Type = this.Type;
			_o.BeatType = this.BeatType;
		}

		// Token: 0x0601F5F5 RID: 128501 RVA: 0x0045ED10 File Offset: 0x0045CF10
		public static Offset<ICheckFlForestMusicBeats> Pack(FlatBufferBuilder builder, ICheckFlForestMusicBeatsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlForestMusicBeats>);
			}
			StringOffset beatTypeOffset = (_o.BeatType == null) ? default(StringOffset) : builder.CreateString(_o.BeatType);
			return ICheckFlForestMusicBeats.CreateICheckFlForestMusicBeats(builder, _o.Type, beatTypeOffset);
		}

		// Token: 0x0400DD53 RID: 56659
		private Table __p;
	}
}
