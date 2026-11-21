using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BBA RID: 31674
	public struct ITextUiConfig : IFlatbufferObject
	{
		// Token: 0x1700ED4A RID: 60746
		// (get) Token: 0x0603915A RID: 233818 RVA: 0x007B720C File Offset: 0x007B540C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603915B RID: 233819 RVA: 0x007B7219 File Offset: 0x007B5419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603915C RID: 233820 RVA: 0x007B7220 File Offset: 0x007B5420
		public static ITextUiConfig GetRootAsITextUiConfig(ByteBuffer _bb)
		{
			return ITextUiConfig.GetRootAsITextUiConfig(_bb, default(ITextUiConfig));
		}

		// Token: 0x0603915D RID: 233821 RVA: 0x007B723C File Offset: 0x007B543C
		public static ITextUiConfig GetRootAsITextUiConfig(ByteBuffer _bb, ITextUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603915E RID: 233822 RVA: 0x007B7259 File Offset: 0x007B5459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603915F RID: 233823 RVA: 0x007B7268 File Offset: 0x007B5468
		public ITextUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED4B RID: 60747
		// (get) Token: 0x06039160 RID: 233824 RVA: 0x007B7278 File Offset: 0x007B5478
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

		// Token: 0x1700ED4C RID: 60748
		// (get) Token: 0x06039161 RID: 233825 RVA: 0x007B72B4 File Offset: 0x007B54B4
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

		// Token: 0x06039162 RID: 233826 RVA: 0x007B72EB File Offset: 0x007B54EB
		public Span<byte> GetInitTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039163 RID: 233827 RVA: 0x007B72FA File Offset: 0x007B54FA
		public byte[] GetInitTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ED4D RID: 60749
		// (get) Token: 0x06039164 RID: 233828 RVA: 0x007B7308 File Offset: 0x007B5508
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

		// Token: 0x06039165 RID: 233829 RVA: 0x007B733F File Offset: 0x007B553F
		public Span<byte> GetProgressTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039166 RID: 233830 RVA: 0x007B734E File Offset: 0x007B554E
		public byte[] GetProgressTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ED4E RID: 60750
		// (get) Token: 0x06039167 RID: 233831 RVA: 0x007B735C File Offset: 0x007B555C
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

		// Token: 0x06039168 RID: 233832 RVA: 0x007B7394 File Offset: 0x007B5594
		public Span<byte> GetSkipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06039169 RID: 233833 RVA: 0x007B73A4 File Offset: 0x007B55A4
		public byte[] GetSkipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ED4F RID: 60751
		// (get) Token: 0x0603916A RID: 233834 RVA: 0x007B73B4 File Offset: 0x007B55B4
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

		// Token: 0x0603916B RID: 233835 RVA: 0x007B73EC File Offset: 0x007B55EC
		public Span<byte> GetFinishTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0603916C RID: 233836 RVA: 0x007B73FC File Offset: 0x007B55FC
		public byte[] GetFinishTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0603916D RID: 233837 RVA: 0x007B740C File Offset: 0x007B560C
		public string InitDialogues(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700ED50 RID: 60752
		// (get) Token: 0x0603916E RID: 233838 RVA: 0x007B7448 File Offset: 0x007B5648
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

		// Token: 0x1700ED51 RID: 60753
		// (get) Token: 0x0603916F RID: 233839 RVA: 0x007B7474 File Offset: 0x007B5674
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

		// Token: 0x1700ED52 RID: 60754
		// (get) Token: 0x06039170 RID: 233840 RVA: 0x007B74B4 File Offset: 0x007B56B4
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

		// Token: 0x06039171 RID: 233841 RVA: 0x007B74EC File Offset: 0x007B56EC
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06039172 RID: 233842 RVA: 0x007B74FC File Offset: 0x007B56FC
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700ED53 RID: 60755
		// (get) Token: 0x06039173 RID: 233843 RVA: 0x007B750C File Offset: 0x007B570C
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

		// Token: 0x06039174 RID: 233844 RVA: 0x007B754C File Offset: 0x007B574C
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

		// Token: 0x06039175 RID: 233845 RVA: 0x007B75AC File Offset: 0x007B57AC
		public static void StartITextUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06039176 RID: 233846 RVA: 0x007B75B6 File Offset: 0x007B57B6
		public static void AddType(FlatBufferBuilder builder, ETextUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039177 RID: 233847 RVA: 0x007B75C1 File Offset: 0x007B57C1
		public static void AddInitTipText(FlatBufferBuilder builder, StringOffset initTipTextOffset)
		{
			builder.AddOffset(1, initTipTextOffset.Value, 0);
		}

		// Token: 0x06039178 RID: 233848 RVA: 0x007B75D1 File Offset: 0x007B57D1
		public static void AddProgressTipText(FlatBufferBuilder builder, StringOffset progressTipTextOffset)
		{
			builder.AddOffset(2, progressTipTextOffset.Value, 0);
		}

		// Token: 0x06039179 RID: 233849 RVA: 0x007B75E1 File Offset: 0x007B57E1
		public static void AddSkipText(FlatBufferBuilder builder, StringOffset skipTextOffset)
		{
			builder.AddOffset(3, skipTextOffset.Value, 0);
		}

		// Token: 0x0603917A RID: 233850 RVA: 0x007B75F1 File Offset: 0x007B57F1
		public static void AddFinishText(FlatBufferBuilder builder, StringOffset finishTextOffset)
		{
			builder.AddOffset(4, finishTextOffset.Value, 0);
		}

		// Token: 0x0603917B RID: 233851 RVA: 0x007B7601 File Offset: 0x007B5801
		public static void AddInitDialogues(FlatBufferBuilder builder, VectorOffset initDialoguesOffset)
		{
			builder.AddOffset(5, initDialoguesOffset.Value, 0);
		}

		// Token: 0x0603917C RID: 233852 RVA: 0x007B7614 File Offset: 0x007B5814
		public static VectorOffset CreateInitDialoguesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603917D RID: 233853 RVA: 0x007B7654 File Offset: 0x007B5854
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603917E RID: 233854 RVA: 0x007B766E File Offset: 0x007B586E
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603917F RID: 233855 RVA: 0x007B768C File Offset: 0x007B588C
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039180 RID: 233856 RVA: 0x007B76A5 File Offset: 0x007B58A5
		public static void StartInitDialoguesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039181 RID: 233857 RVA: 0x007B76B0 File Offset: 0x007B58B0
		public static void AddSkipConfirmBoxId(FlatBufferBuilder builder, int skipConfirmBoxId)
		{
			builder.AddInt(6, skipConfirmBoxId, 0);
		}

		// Token: 0x06039182 RID: 233858 RVA: 0x007B76BB File Offset: 0x007B58BB
		public static void AddLoopAudioEvent(FlatBufferBuilder builder, StringOffset loopAudioEventOffset)
		{
			builder.AddOffset(7, loopAudioEventOffset.Value, 0);
		}

		// Token: 0x06039183 RID: 233859 RVA: 0x007B76CB File Offset: 0x007B58CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06039184 RID: 233860 RVA: 0x007B76D6 File Offset: 0x007B58D6
		public static Offset<ITextUiConfig> EndITextUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITextUiConfig>(builder.EndTable());
		}

		// Token: 0x06039185 RID: 233861 RVA: 0x007B76E4 File Offset: 0x007B58E4
		public ITextUiConfigT UnPack()
		{
			ITextUiConfigT textUiConfigT = new ITextUiConfigT();
			this.UnPackTo(textUiConfigT);
			return textUiConfigT;
		}

		// Token: 0x06039186 RID: 233862 RVA: 0x007B7700 File Offset: 0x007B5900
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

		// Token: 0x06039187 RID: 233863 RVA: 0x007B779C File Offset: 0x007B599C
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

		// Token: 0x04013238 RID: 78392
		private Table __p;
	}
}
