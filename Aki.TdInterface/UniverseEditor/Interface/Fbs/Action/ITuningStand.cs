using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C86 RID: 31878
	public struct ITuningStand : IFlatbufferObject
	{
		// Token: 0x1700EEAD RID: 61101
		// (get) Token: 0x060397B3 RID: 235443 RVA: 0x007C2577 File Offset: 0x007C0777
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060397B4 RID: 235444 RVA: 0x007C2584 File Offset: 0x007C0784
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060397B5 RID: 235445 RVA: 0x007C258C File Offset: 0x007C078C
		public static ITuningStand GetRootAsITuningStand(ByteBuffer _bb)
		{
			return ITuningStand.GetRootAsITuningStand(_bb, default(ITuningStand));
		}

		// Token: 0x060397B6 RID: 235446 RVA: 0x007C25A8 File Offset: 0x007C07A8
		public static ITuningStand GetRootAsITuningStand(ByteBuffer _bb, ITuningStand obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060397B7 RID: 235447 RVA: 0x007C25C5 File Offset: 0x007C07C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060397B8 RID: 235448 RVA: 0x007C25D4 File Offset: 0x007C07D4
		public ITuningStand __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEAE RID: 61102
		// (get) Token: 0x060397B9 RID: 235449 RVA: 0x007C25E4 File Offset: 0x007C07E4
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

		// Token: 0x1700EEAF RID: 61103
		// (get) Token: 0x060397BA RID: 235450 RVA: 0x007C2620 File Offset: 0x007C0820
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

		// Token: 0x060397BB RID: 235451 RVA: 0x007C265C File Offset: 0x007C085C
		public ITuningStandBubbleConfig? BubbleConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITuningStandBubbleConfig?(default(ITuningStandBubbleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EEB0 RID: 61104
		// (get) Token: 0x060397BC RID: 235452 RVA: 0x007C26BC File Offset: 0x007C08BC
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

		// Token: 0x1700EEB1 RID: 61105
		// (get) Token: 0x060397BD RID: 235453 RVA: 0x007C26E8 File Offset: 0x007C08E8
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

		// Token: 0x060397BE RID: 235454 RVA: 0x007C2720 File Offset: 0x007C0920
		public Span<byte> GetGuidancePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060397BF RID: 235455 RVA: 0x007C2730 File Offset: 0x007C0930
		public byte[] GetGuidancePathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700EEB2 RID: 61106
		// (get) Token: 0x060397C0 RID: 235456 RVA: 0x007C2740 File Offset: 0x007C0940
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

		// Token: 0x060397C1 RID: 235457 RVA: 0x007C2778 File Offset: 0x007C0978
		public Span<byte> GetMusicScorePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060397C2 RID: 235458 RVA: 0x007C2788 File Offset: 0x007C0988
		public byte[] GetMusicScorePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700EEB3 RID: 61107
		// (get) Token: 0x060397C3 RID: 235459 RVA: 0x007C2798 File Offset: 0x007C0998
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

		// Token: 0x060397C4 RID: 235460 RVA: 0x007C27D0 File Offset: 0x007C09D0
		public Span<byte> GetNoteSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060397C5 RID: 235461 RVA: 0x007C27E0 File Offset: 0x007C09E0
		public byte[] GetNoteSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700EEB4 RID: 61108
		// (get) Token: 0x060397C6 RID: 235462 RVA: 0x007C27F0 File Offset: 0x007C09F0
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

		// Token: 0x060397C7 RID: 235463 RVA: 0x007C2828 File Offset: 0x007C0A28
		public Span<byte> GetCompleteMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060397C8 RID: 235464 RVA: 0x007C2838 File Offset: 0x007C0A38
		public byte[] GetCompleteMusicArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700EEB5 RID: 61109
		// (get) Token: 0x060397C9 RID: 235465 RVA: 0x007C2848 File Offset: 0x007C0A48
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

		// Token: 0x1700EEB6 RID: 61110
		// (get) Token: 0x060397CA RID: 235466 RVA: 0x007C28A8 File Offset: 0x007C0AA8
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

		// Token: 0x060397CB RID: 235467 RVA: 0x007C28E8 File Offset: 0x007C0AE8
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

		// Token: 0x060397CC RID: 235468 RVA: 0x007C2948 File Offset: 0x007C0B48
		public static void StartITuningStand(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060397CD RID: 235469 RVA: 0x007C2952 File Offset: 0x007C0B52
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060397CE RID: 235470 RVA: 0x007C295D File Offset: 0x007C0B5D
		public static void AddVisualType(FlatBufferBuilder builder, ETuningStandVisualType visualType)
		{
			builder.AddByte(1, (byte)visualType, 0);
		}

		// Token: 0x060397CF RID: 235471 RVA: 0x007C2968 File Offset: 0x007C0B68
		public static void AddBubbleConfig(FlatBufferBuilder builder, VectorOffset bubbleConfigOffset)
		{
			builder.AddOffset(2, bubbleConfigOffset.Value, 0);
		}

		// Token: 0x060397D0 RID: 235472 RVA: 0x007C2978 File Offset: 0x007C0B78
		public static VectorOffset CreateBubbleConfigVector(FlatBufferBuilder builder, Offset<ITuningStandBubbleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060397D1 RID: 235473 RVA: 0x007C29B8 File Offset: 0x007C0BB8
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, Offset<ITuningStandBubbleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITuningStandBubbleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060397D2 RID: 235474 RVA: 0x007C29D2 File Offset: 0x007C0BD2
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITuningStandBubbleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITuningStandBubbleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060397D3 RID: 235475 RVA: 0x007C29F0 File Offset: 0x007C0BF0
		public static VectorOffset CreateBubbleConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITuningStandBubbleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060397D4 RID: 235476 RVA: 0x007C2A09 File Offset: 0x007C0C09
		public static void StartBubbleConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060397D5 RID: 235477 RVA: 0x007C2A14 File Offset: 0x007C0C14
		public static void AddGuidancePath(FlatBufferBuilder builder, StringOffset guidancePathOffset)
		{
			builder.AddOffset(3, guidancePathOffset.Value, 0);
		}

		// Token: 0x060397D6 RID: 235478 RVA: 0x007C2A24 File Offset: 0x007C0C24
		public static void AddMusicScorePath(FlatBufferBuilder builder, StringOffset musicScorePathOffset)
		{
			builder.AddOffset(4, musicScorePathOffset.Value, 0);
		}

		// Token: 0x060397D7 RID: 235479 RVA: 0x007C2A34 File Offset: 0x007C0C34
		public static void AddNoteSequence(FlatBufferBuilder builder, StringOffset noteSequenceOffset)
		{
			builder.AddOffset(5, noteSequenceOffset.Value, 0);
		}

		// Token: 0x060397D8 RID: 235480 RVA: 0x007C2A44 File Offset: 0x007C0C44
		public static void AddCompleteMusic(FlatBufferBuilder builder, StringOffset completeMusicOffset)
		{
			builder.AddOffset(6, completeMusicOffset.Value, 0);
		}

		// Token: 0x060397D9 RID: 235481 RVA: 0x007C2A54 File Offset: 0x007C0C54
		public static void AddBoardConfig(FlatBufferBuilder builder, Offset<ITuningStandGridBoard> boardConfigOffset)
		{
			builder.AddOffset(7, boardConfigOffset.Value, 0);
		}

		// Token: 0x060397DA RID: 235482 RVA: 0x007C2A64 File Offset: 0x007C0C64
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060397DB RID: 235483 RVA: 0x007C2A6F File Offset: 0x007C0C6F
		public static Offset<ITuningStand> EndITuningStand(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStand>(builder.EndTable());
		}

		// Token: 0x060397DC RID: 235484 RVA: 0x007C2A7C File Offset: 0x007C0C7C
		public ITuningStandT UnPack()
		{
			ITuningStandT tuningStandT = new ITuningStandT();
			this.UnPackTo(tuningStandT);
			return tuningStandT;
		}

		// Token: 0x060397DD RID: 235485 RVA: 0x007C2A98 File Offset: 0x007C0C98
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

		// Token: 0x060397DE RID: 235486 RVA: 0x007C2B7C File Offset: 0x007C0D7C
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

		// Token: 0x04013353 RID: 78675
		private Table __p;
	}
}
