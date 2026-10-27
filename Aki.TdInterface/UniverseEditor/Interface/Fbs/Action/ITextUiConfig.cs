using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D3 RID: 29651
	public struct ITextUiConfig : IFlatbufferObject
	{
		// Token: 0x1700E13A RID: 57658
		// (get) Token: 0x06035DBF RID: 220607 RVA: 0x00754CCC File Offset: 0x00752ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035DC0 RID: 220608 RVA: 0x00754CD9 File Offset: 0x00752ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035DC1 RID: 220609 RVA: 0x00754CE0 File Offset: 0x00752EE0
		public static ITextUiConfig GetRootAsITextUiConfig(ByteBuffer _bb)
		{
			return ITextUiConfig.GetRootAsITextUiConfig(_bb, default(ITextUiConfig));
		}

		// Token: 0x06035DC2 RID: 220610 RVA: 0x00754CFC File Offset: 0x00752EFC
		public static ITextUiConfig GetRootAsITextUiConfig(ByteBuffer _bb, ITextUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035DC3 RID: 220611 RVA: 0x00754D19 File Offset: 0x00752F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035DC4 RID: 220612 RVA: 0x00754D28 File Offset: 0x00752F28
		public ITextUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E13B RID: 57659
		// (get) Token: 0x06035DC5 RID: 220613 RVA: 0x00754D38 File Offset: 0x00752F38
		public ETextUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETextUiType.Astrology;
				}
				return (ETextUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E13C RID: 57660
		// (get) Token: 0x06035DC6 RID: 220614 RVA: 0x00754D74 File Offset: 0x00752F74
		public string InitTipText
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

		// Token: 0x06035DC7 RID: 220615 RVA: 0x00754DAB File Offset: 0x00752FAB
		public Span<byte> GetInitTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035DC8 RID: 220616 RVA: 0x00754DBA File Offset: 0x00752FBA
		public byte[] GetInitTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E13D RID: 57661
		// (get) Token: 0x06035DC9 RID: 220617 RVA: 0x00754DC8 File Offset: 0x00752FC8
		public string ProgressTipText
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

		// Token: 0x06035DCA RID: 220618 RVA: 0x00754DFF File Offset: 0x00752FFF
		public Span<byte> GetProgressTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06035DCB RID: 220619 RVA: 0x00754E0E File Offset: 0x0075300E
		public byte[] GetProgressTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E13E RID: 57662
		// (get) Token: 0x06035DCC RID: 220620 RVA: 0x00754E1C File Offset: 0x0075301C
		public string SkipText
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

		// Token: 0x06035DCD RID: 220621 RVA: 0x00754E54 File Offset: 0x00753054
		public Span<byte> GetSkipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035DCE RID: 220622 RVA: 0x00754E64 File Offset: 0x00753064
		public byte[] GetSkipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E13F RID: 57663
		// (get) Token: 0x06035DCF RID: 220623 RVA: 0x00754E74 File Offset: 0x00753074
		public string FinishText
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

		// Token: 0x06035DD0 RID: 220624 RVA: 0x00754EAC File Offset: 0x007530AC
		public Span<byte> GetFinishTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035DD1 RID: 220625 RVA: 0x00754EBC File Offset: 0x007530BC
		public byte[] GetFinishTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06035DD2 RID: 220626 RVA: 0x00754ECC File Offset: 0x007530CC
		public string InitDialogues(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E140 RID: 57664
		// (get) Token: 0x06035DD3 RID: 220627 RVA: 0x00754F08 File Offset: 0x00753108
		public int InitDialoguesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E141 RID: 57665
		// (get) Token: 0x06035DD4 RID: 220628 RVA: 0x00754F34 File Offset: 0x00753134
		public int SkipConfirmBoxId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E142 RID: 57666
		// (get) Token: 0x06035DD5 RID: 220629 RVA: 0x00754F74 File Offset: 0x00753174
		public string LoopAudioEvent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DD6 RID: 220630 RVA: 0x00754FAC File Offset: 0x007531AC
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06035DD7 RID: 220631 RVA: 0x00754FBC File Offset: 0x007531BC
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700E143 RID: 57667
		// (get) Token: 0x06035DD8 RID: 220632 RVA: 0x00754FCC File Offset: 0x007531CC
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

		// Token: 0x06035DD9 RID: 220633 RVA: 0x0075500C File Offset: 0x0075320C
		public static Offset<ITextUiConfig> CreateITextUiConfig(FlatBufferBuilder builder, ETextUiType Type = ETextUiType.Astrology, StringOffset InitTipTextOffset = default(StringOffset), StringOffset ProgressTipTextOffset = default(StringOffset), StringOffset SkipTextOffset = default(StringOffset), StringOffset FinishTextOffset = default(StringOffset), VectorOffset InitDialoguesOffset = default(VectorOffset), int SkipConfirmBoxId = 0, StringOffset LoopAudioEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITextUiConfig.AddLoopAudioEvent(builder, LoopAudioEventOffset);
			ITextUiConfig.AddSkipConfirmBoxId(builder, SkipConfirmBoxId);
			ITextUiConfig.AddInitDialogues(builder, InitDialoguesOffset);
			ITextUiConfig.AddFinishText(builder, FinishTextOffset);
			ITextUiConfig.AddSkipText(builder, SkipTextOffset);
			ITextUiConfig.AddProgressTipText(builder, ProgressTipTextOffset);
			ITextUiConfig.AddInitTipText(builder, InitTipTextOffset);
			ITextUiConfig.AddNullMask(builder, NullMask);
			ITextUiConfig.AddType(builder, Type);
			return ITextUiConfig.EndITextUiConfig(builder);
		}

		// Token: 0x06035DDA RID: 220634 RVA: 0x0075506C File Offset: 0x0075326C
		public static void StartITextUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06035DDB RID: 220635 RVA: 0x00755076 File Offset: 0x00753276
		public static void AddType(FlatBufferBuilder builder, ETextUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035DDC RID: 220636 RVA: 0x00755081 File Offset: 0x00753281
		public static void AddInitTipText(FlatBufferBuilder builder, StringOffset initTipTextOffset)
		{
			builder.AddOffset(1, initTipTextOffset.Value, 0);
		}

		// Token: 0x06035DDD RID: 220637 RVA: 0x00755091 File Offset: 0x00753291
		public static void AddProgressTipText(FlatBufferBuilder builder, StringOffset progressTipTextOffset)
		{
			builder.AddOffset(2, progressTipTextOffset.Value, 0);
		}

		// Token: 0x06035DDE RID: 220638 RVA: 0x007550A1 File Offset: 0x007532A1
		public static void AddSkipText(FlatBufferBuilder builder, StringOffset skipTextOffset)
		{
			builder.AddOffset(3, skipTextOffset.Value, 0);
		}

		// Token: 0x06035DDF RID: 220639 RVA: 0x007550B1 File Offset: 0x007532B1
		public static void AddFinishText(FlatBufferBuilder builder, StringOffset finishTextOffset)
		{
			builder.AddOffset(4, finishTextOffset.Value, 0);
		}

		// Token: 0x06035DE0 RID: 220640 RVA: 0x007550C1 File Offset: 0x007532C1
		public static void AddInitDialogues(FlatBufferBuilder builder, VectorOffset initDialoguesOffset)
		{
			builder.AddOffset(5, initDialoguesOffset.Value, 0);
		}

		// Token: 0x06035DE1 RID: 220641 RVA: 0x007550D4 File Offset: 0x007532D4
		public static VectorOffset CreateInitDialoguesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035DE2 RID: 220642 RVA: 0x00755114 File Offset: 0x00753314
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06035DE3 RID: 220643 RVA: 0x0075512E File Offset: 0x0075332E
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06035DE4 RID: 220644 RVA: 0x0075514C File Offset: 0x0075334C
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035DE5 RID: 220645 RVA: 0x00755165 File Offset: 0x00753365
		public static void StartInitDialoguesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035DE6 RID: 220646 RVA: 0x00755170 File Offset: 0x00753370
		public static void AddSkipConfirmBoxId(FlatBufferBuilder builder, int skipConfirmBoxId)
		{
			builder.AddInt(6, skipConfirmBoxId, 0);
		}

		// Token: 0x06035DE7 RID: 220647 RVA: 0x0075517B File Offset: 0x0075337B
		public static void AddLoopAudioEvent(FlatBufferBuilder builder, StringOffset loopAudioEventOffset)
		{
			builder.AddOffset(7, loopAudioEventOffset.Value, 0);
		}

		// Token: 0x06035DE8 RID: 220648 RVA: 0x0075518B File Offset: 0x0075338B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06035DE9 RID: 220649 RVA: 0x00755196 File Offset: 0x00753396
		public static Offset<ITextUiConfig> EndITextUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITextUiConfig>(builder.EndTable());
		}

		// Token: 0x06035DEA RID: 220650 RVA: 0x007551A4 File Offset: 0x007533A4
		public ITextUiConfigT UnPack()
		{
			ITextUiConfigT textUiConfigT = new ITextUiConfigT();
			this.UnPackTo(textUiConfigT);
			return textUiConfigT;
		}

		// Token: 0x06035DEB RID: 220651 RVA: 0x007551C0 File Offset: 0x007533C0
		public void UnPackTo(ITextUiConfigT _o)
		{
			_o.Type = this.Type;
			_o.InitTipText = this.InitTipText;
			_o.ProgressTipText = this.ProgressTipText;
			_o.SkipText = this.SkipText;
			_o.FinishText = this.FinishText;
			_o.InitDialogues = new List<string>();
			for (int i = 0; i < this.InitDialoguesLength; i++)
			{
				_o.InitDialogues.Add(this.InitDialogues(i));
			}
			_o.SkipConfirmBoxId = this.SkipConfirmBoxId;
			_o.LoopAudioEvent = this.LoopAudioEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035DEC RID: 220652 RVA: 0x0075525C File Offset: 0x0075345C
		public static Offset<ITextUiConfig> Pack(FlatBufferBuilder builder, ITextUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITextUiConfig>);
			}
			StringOffset initTipTextOffset = (_o.InitTipText == null) ? default(StringOffset) : builder.CreateString(_o.InitTipText);
			StringOffset progressTipTextOffset = (_o.ProgressTipText == null) ? default(StringOffset) : builder.CreateString(_o.ProgressTipText);
			StringOffset skipTextOffset = (_o.SkipText == null) ? default(StringOffset) : builder.CreateString(_o.SkipText);
			StringOffset finishTextOffset = (_o.FinishText == null) ? default(StringOffset) : builder.CreateString(_o.FinishText);
			VectorOffset initDialoguesOffset = default(VectorOffset);
			if (_o.InitDialogues != null)
			{
				StringOffset[] array = new StringOffset[_o.InitDialogues.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.InitDialogues[i]);
				}
				initDialoguesOffset = ITextUiConfig.CreateInitDialoguesVector(builder, array);
			}
			StringOffset loopAudioEventOffset = (_o.LoopAudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.LoopAudioEvent);
			return ITextUiConfig.CreateITextUiConfig(builder, _o.Type, initTipTextOffset, progressTipTextOffset, skipTextOffset, finishTextOffset, initDialoguesOffset, _o.SkipConfirmBoxId, loopAudioEventOffset, _o.NullMask);
		}

		// Token: 0x0401221F RID: 74271
		private Table __p;
	}
}
