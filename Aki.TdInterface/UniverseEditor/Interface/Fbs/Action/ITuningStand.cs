using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007493 RID: 29843
	public struct ITuningStand : IFlatbufferObject
	{
		// Token: 0x1700E28E RID: 57998
		// (get) Token: 0x060363C6 RID: 222150 RVA: 0x0075F7BB File Offset: 0x0075D9BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060363C7 RID: 222151 RVA: 0x0075F7C8 File Offset: 0x0075D9C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060363C8 RID: 222152 RVA: 0x0075F7D0 File Offset: 0x0075D9D0
		public static ITuningStand GetRootAsITuningStand(ByteBuffer _bb)
		{
			return ITuningStand.GetRootAsITuningStand(_bb, default(ITuningStand));
		}

		// Token: 0x060363C9 RID: 222153 RVA: 0x0075F7EC File Offset: 0x0075D9EC
		public static ITuningStand GetRootAsITuningStand(ByteBuffer _bb, ITuningStand obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060363CA RID: 222154 RVA: 0x0075F809 File Offset: 0x0075DA09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060363CB RID: 222155 RVA: 0x0075F818 File Offset: 0x0075DA18
		public ITuningStand __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E28F RID: 57999
		// (get) Token: 0x060363CC RID: 222156 RVA: 0x0075F828 File Offset: 0x0075DA28
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

		// Token: 0x1700E290 RID: 58000
		// (get) Token: 0x060363CD RID: 222157 RVA: 0x0075F864 File Offset: 0x0075DA64
		public ETuningStandVisualType VisualType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETuningStandVisualType.Tuning;
				}
				return (ETuningStandVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060363CE RID: 222158 RVA: 0x0075F8A0 File Offset: 0x0075DAA0
		public ITuningStandBubbleConfig? BubbleConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITuningStandBubbleConfig?(default(ITuningStandBubbleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E291 RID: 58001
		// (get) Token: 0x060363CF RID: 222159 RVA: 0x0075F900 File Offset: 0x0075DB00
		public int BubbleConfigLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E292 RID: 58002
		// (get) Token: 0x060363D0 RID: 222160 RVA: 0x0075F92C File Offset: 0x0075DB2C
		public string GuidancePath
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

		// Token: 0x060363D1 RID: 222161 RVA: 0x0075F964 File Offset: 0x0075DB64
		public Span<byte> GetGuidancePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060363D2 RID: 222162 RVA: 0x0075F974 File Offset: 0x0075DB74
		public byte[] GetGuidancePathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E293 RID: 58003
		// (get) Token: 0x060363D3 RID: 222163 RVA: 0x0075F984 File Offset: 0x0075DB84
		public string MusicScorePath
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

		// Token: 0x060363D4 RID: 222164 RVA: 0x0075F9BC File Offset: 0x0075DBBC
		public Span<byte> GetMusicScorePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060363D5 RID: 222165 RVA: 0x0075F9CC File Offset: 0x0075DBCC
		public byte[] GetMusicScorePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700E294 RID: 58004
		// (get) Token: 0x060363D6 RID: 222166 RVA: 0x0075F9DC File Offset: 0x0075DBDC
		public string NoteSequence
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

		// Token: 0x060363D7 RID: 222167 RVA: 0x0075FA14 File Offset: 0x0075DC14
		public Span<byte> GetNoteSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060363D8 RID: 222168 RVA: 0x0075FA24 File Offset: 0x0075DC24
		public byte[] GetNoteSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700E295 RID: 58005
		// (get) Token: 0x060363D9 RID: 222169 RVA: 0x0075FA34 File Offset: 0x0075DC34
		public string CompleteMusic
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060363DA RID: 222170 RVA: 0x0075FA6C File Offset: 0x0075DC6C
		public Span<byte> GetCompleteMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060363DB RID: 222171 RVA: 0x0075FA7C File Offset: 0x0075DC7C
		public byte[] GetCompleteMusicArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700E296 RID: 58006
		// (get) Token: 0x060363DC RID: 222172 RVA: 0x0075FA8C File Offset: 0x0075DC8C
		public ITuningStandGridBoard? BoardConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITuningStandGridBoard?(default(ITuningStandGridBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E297 RID: 58007
		// (get) Token: 0x060363DD RID: 222173 RVA: 0x0075FAEC File Offset: 0x0075DCEC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060363DE RID: 222174 RVA: 0x0075FB2C File Offset: 0x0075DD2C
		public static Offset<ITuningStand> CreateITuningStand(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, ETuningStandVisualType VisualType = ETuningStandVisualType.Tuning, VectorOffset BubbleConfigOffset = default(VectorOffset), StringOffset GuidancePathOffset = default(StringOffset), StringOffset MusicScorePathOffset = default(StringOffset), StringOffset NoteSequenceOffset = default(StringOffset), StringOffset CompleteMusicOffset = default(StringOffset), Offset<ITuningStandGridBoard> BoardConfigOffset = default(Offset<ITuningStandGridBoard>), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITuningStand.AddBoardConfig(builder, BoardConfigOffset);
			ITuningStand.AddCompleteMusic(builder, CompleteMusicOffset);
			ITuningStand.AddNoteSequence(builder, NoteSequenceOffset);
			ITuningStand.AddMusicScorePath(builder, MusicScorePathOffset);
			ITuningStand.AddGuidancePath(builder, GuidancePathOffset);
			ITuningStand.AddBubbleConfig(builder, BubbleConfigOffset);
			ITuningStand.AddNullMask(builder, NullMask);
			ITuningStand.AddVisualType(builder, VisualType);
			ITuningStand.AddType(builder, Type);
			return ITuningStand.EndITuningStand(builder);
		}

		// Token: 0x060363DF RID: 222175 RVA: 0x0075FB8C File Offset: 0x0075DD8C
		public static void StartITuningStand(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060363E0 RID: 222176 RVA: 0x0075FB96 File Offset: 0x0075DD96
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060363E1 RID: 222177 RVA: 0x0075FBA1 File Offset: 0x0075DDA1
		public static void AddVisualType(FlatBufferBuilder builder, ETuningStandVisualType visualType)
		{
			builder.AddByte(1, (byte)visualType, 0);
		}

		// Token: 0x060363E2 RID: 222178 RVA: 0x0075FBAC File Offset: 0x0075DDAC
		public static void AddBubbleConfig(FlatBufferBuilder builder, VectorOffset bubbleConfigOffset)
		{
			builder.AddOffset(2, bubbleConfigOffset.Value, 0);
		}

		// Token: 0x060363E3 RID: 222179 RVA: 0x0075FBBC File Offset: 0x0075DDBC
		public static VectorOffset CreateBubbleConfigVector(FlatBufferBuilder builder, Offset<ITuningStandBubbleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060363E4 RID: 222180 RVA: 0x0075FBFC File Offset: 0x0075DDFC
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, Offset<ITuningStandBubbleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITuningStandBubbleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060363E5 RID: 222181 RVA: 0x0075FC16 File Offset: 0x0075DE16
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITuningStandBubbleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITuningStandBubbleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060363E6 RID: 222182 RVA: 0x0075FC34 File Offset: 0x0075DE34
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITuningStandBubbleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060363E7 RID: 222183 RVA: 0x0075FC4D File Offset: 0x0075DE4D
		public static void StartBubbleConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060363E8 RID: 222184 RVA: 0x0075FC58 File Offset: 0x0075DE58
		public static void AddGuidancePath(FlatBufferBuilder builder, StringOffset guidancePathOffset)
		{
			builder.AddOffset(3, guidancePathOffset.Value, 0);
		}

		// Token: 0x060363E9 RID: 222185 RVA: 0x0075FC68 File Offset: 0x0075DE68
		public static void AddMusicScorePath(FlatBufferBuilder builder, StringOffset musicScorePathOffset)
		{
			builder.AddOffset(4, musicScorePathOffset.Value, 0);
		}

		// Token: 0x060363EA RID: 222186 RVA: 0x0075FC78 File Offset: 0x0075DE78
		public static void AddNoteSequence(FlatBufferBuilder builder, StringOffset noteSequenceOffset)
		{
			builder.AddOffset(5, noteSequenceOffset.Value, 0);
		}

		// Token: 0x060363EB RID: 222187 RVA: 0x0075FC88 File Offset: 0x0075DE88
		public static void AddCompleteMusic(FlatBufferBuilder builder, StringOffset completeMusicOffset)
		{
			builder.AddOffset(6, completeMusicOffset.Value, 0);
		}

		// Token: 0x060363EC RID: 222188 RVA: 0x0075FC98 File Offset: 0x0075DE98
		public static void AddBoardConfig(FlatBufferBuilder builder, Offset<ITuningStandGridBoard> boardConfigOffset)
		{
			builder.AddOffset(7, boardConfigOffset.Value, 0);
		}

		// Token: 0x060363ED RID: 222189 RVA: 0x0075FCA8 File Offset: 0x0075DEA8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060363EE RID: 222190 RVA: 0x0075FCB3 File Offset: 0x0075DEB3
		public static Offset<ITuningStand> EndITuningStand(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStand>(builder.EndTable());
		}

		// Token: 0x060363EF RID: 222191 RVA: 0x0075FCC0 File Offset: 0x0075DEC0
		public ITuningStandT UnPack()
		{
			ITuningStandT tuningStandT = new ITuningStandT();
			this.UnPackTo(tuningStandT);
			return tuningStandT;
		}

		// Token: 0x060363F0 RID: 222192 RVA: 0x0075FCDC File Offset: 0x0075DEDC
		public void UnPackTo(ITuningStandT _o)
		{
			_o.Type = this.Type;
			_o.VisualType = this.VisualType;
			_o.BubbleConfig = new List<ITuningStandBubbleConfigT>();
			for (int i = 0; i < this.BubbleConfigLength; i++)
			{
				_o.BubbleConfig.Add((this.BubbleConfig(i) != null) ? this.BubbleConfig(i).Value.UnPack() : null);
			}
			_o.GuidancePath = this.GuidancePath;
			_o.MusicScorePath = this.MusicScorePath;
			_o.NoteSequence = this.NoteSequence;
			_o.CompleteMusic = this.CompleteMusic;
			_o.BoardConfig = ((this.BoardConfig != null) ? this.BoardConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060363F1 RID: 222193 RVA: 0x0075FDC0 File Offset: 0x0075DFC0
		public static Offset<ITuningStand> Pack(FlatBufferBuilder builder, ITuningStandT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITuningStand>);
			}
			VectorOffset bubbleConfigOffset = default(VectorOffset);
			if (_o.BubbleConfig != null)
			{
				Offset<ITuningStandBubbleConfig>[] array = new Offset<ITuningStandBubbleConfig>[_o.BubbleConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITuningStandBubbleConfig.Pack(builder, _o.BubbleConfig[i]);
				}
				bubbleConfigOffset = ITuningStand.CreateBubbleConfigVector(builder, array);
			}
			StringOffset guidancePathOffset = (_o.GuidancePath == null) ? default(StringOffset) : builder.CreateString(_o.GuidancePath);
			StringOffset musicScorePathOffset = (_o.MusicScorePath == null) ? default(StringOffset) : builder.CreateString(_o.MusicScorePath);
			StringOffset noteSequenceOffset = (_o.NoteSequence == null) ? default(StringOffset) : builder.CreateString(_o.NoteSequence);
			StringOffset completeMusicOffset = (_o.CompleteMusic == null) ? default(StringOffset) : builder.CreateString(_o.CompleteMusic);
			Offset<ITuningStandGridBoard> boardConfigOffset = (_o.BoardConfig == null) ? default(Offset<ITuningStandGridBoard>) : ITuningStandGridBoard.Pack(builder, _o.BoardConfig);
			return ITuningStand.CreateITuningStand(builder, _o.Type, _o.VisualType, bubbleConfigOffset, guidancePathOffset, musicScorePathOffset, noteSequenceOffset, completeMusicOffset, boardConfigOffset, _o.NullMask);
		}

		// Token: 0x0401232B RID: 74539
		private Table __p;
	}
}
