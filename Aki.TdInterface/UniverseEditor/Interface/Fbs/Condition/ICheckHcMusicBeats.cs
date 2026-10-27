using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A48 RID: 19016
	public struct ICheckHcMusicBeats : IFlatbufferObject
	{
		// Token: 0x170089AB RID: 35243
		// (get) Token: 0x0601DC70 RID: 121968 RVA: 0x0042FC60 File Offset: 0x0042DE60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC71 RID: 121969 RVA: 0x0042FC6D File Offset: 0x0042DE6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC72 RID: 121970 RVA: 0x0042FC74 File Offset: 0x0042DE74
		public static ICheckHcMusicBeats GetRootAsICheckHcMusicBeats(ByteBuffer _bb)
		{
			return ICheckHcMusicBeats.GetRootAsICheckHcMusicBeats(_bb, default(ICheckHcMusicBeats));
		}

		// Token: 0x0601DC73 RID: 121971 RVA: 0x0042FC90 File Offset: 0x0042DE90
		public static ICheckHcMusicBeats GetRootAsICheckHcMusicBeats(ByteBuffer _bb, ICheckHcMusicBeats obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC74 RID: 121972 RVA: 0x0042FCAD File Offset: 0x0042DEAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC75 RID: 121973 RVA: 0x0042FCBC File Offset: 0x0042DEBC
		public ICheckHcMusicBeats __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089AC RID: 35244
		// (get) Token: 0x0601DC76 RID: 121974 RVA: 0x0042FCCC File Offset: 0x0042DECC
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

		// Token: 0x170089AD RID: 35245
		// (get) Token: 0x0601DC77 RID: 121975 RVA: 0x0042FD08 File Offset: 0x0042DF08
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

		// Token: 0x0601DC78 RID: 121976 RVA: 0x0042FD3F File Offset: 0x0042DF3F
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DC79 RID: 121977 RVA: 0x0042FD4E File Offset: 0x0042DF4E
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601DC7A RID: 121978 RVA: 0x0042FD5C File Offset: 0x0042DF5C
		public static Offset<ICheckHcMusicBeats> CreateICheckHcMusicBeats(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle, StringOffset BeatTypeOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICheckHcMusicBeats.AddBeatType(builder, BeatTypeOffset);
			ICheckHcMusicBeats.AddType(builder, Type);
			return ICheckHcMusicBeats.EndICheckHcMusicBeats(builder);
		}

		// Token: 0x0601DC7B RID: 121979 RVA: 0x0042FD79 File Offset: 0x0042DF79
		public static void StartICheckHcMusicBeats(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DC7C RID: 121980 RVA: 0x0042FD82 File Offset: 0x0042DF82
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC7D RID: 121981 RVA: 0x0042FD8D File Offset: 0x0042DF8D
		public static void AddBeatType(FlatBufferBuilder builder, StringOffset beatTypeOffset)
		{
			builder.AddOffset(1, beatTypeOffset.Value, 0);
		}

		// Token: 0x0601DC7E RID: 121982 RVA: 0x0042FD9D File Offset: 0x0042DF9D
		public static Offset<ICheckHcMusicBeats> EndICheckHcMusicBeats(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHcMusicBeats>(builder.EndTable());
		}

		// Token: 0x0601DC7F RID: 121983 RVA: 0x0042FDAC File Offset: 0x0042DFAC
		public ICheckHcMusicBeatsT UnPack()
		{
			ICheckHcMusicBeatsT checkHcMusicBeatsT = new ICheckHcMusicBeatsT();
			this.UnPackTo(checkHcMusicBeatsT);
			return checkHcMusicBeatsT;
		}

		// Token: 0x0601DC80 RID: 121984 RVA: 0x0042FDC7 File Offset: 0x0042DFC7
		public void UnPackTo(ICheckHcMusicBeatsT _o)
		{
			_o.Type = this.Type;
			_o.BeatType = this.BeatType;
		}

		// Token: 0x0601DC81 RID: 121985 RVA: 0x0042FDE4 File Offset: 0x0042DFE4
		public static Offset<ICheckHcMusicBeats> Pack(FlatBufferBuilder builder, ICheckHcMusicBeatsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHcMusicBeats>);
			}
			StringOffset beatTypeOffset = (_o.BeatType == null) ? default(StringOffset) : builder.CreateString(_o.BeatType);
			return ICheckHcMusicBeats.CreateICheckHcMusicBeats(builder, _o.Type, beatTypeOffset);
		}

		// Token: 0x0400D29F RID: 53919
		private Table __p;
	}
}
