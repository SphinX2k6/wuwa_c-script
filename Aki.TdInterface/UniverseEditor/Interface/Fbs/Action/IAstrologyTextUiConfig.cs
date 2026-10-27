using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A9 RID: 25001
	public struct IAstrologyTextUiConfig : IFlatbufferObject
	{
		// Token: 0x1700BA57 RID: 47703
		// (get) Token: 0x0602B0FE RID: 176382 RVA: 0x005F041A File Offset: 0x005EE61A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B0FF RID: 176383 RVA: 0x005F0427 File Offset: 0x005EE627
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B100 RID: 176384 RVA: 0x005F0430 File Offset: 0x005EE630
		public static IAstrologyTextUiConfig GetRootAsIAstrologyTextUiConfig(ByteBuffer _bb)
		{
			return IAstrologyTextUiConfig.GetRootAsIAstrologyTextUiConfig(_bb, default(IAstrologyTextUiConfig));
		}

		// Token: 0x0602B101 RID: 176385 RVA: 0x005F044C File Offset: 0x005EE64C
		public static IAstrologyTextUiConfig GetRootAsIAstrologyTextUiConfig(ByteBuffer _bb, IAstrologyTextUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B102 RID: 176386 RVA: 0x005F0469 File Offset: 0x005EE669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B103 RID: 176387 RVA: 0x005F0478 File Offset: 0x005EE678
		public IAstrologyTextUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA58 RID: 47704
		// (get) Token: 0x0602B104 RID: 176388 RVA: 0x005F0488 File Offset: 0x005EE688
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

		// Token: 0x1700BA59 RID: 47705
		// (get) Token: 0x0602B105 RID: 176389 RVA: 0x005F04C4 File Offset: 0x005EE6C4
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

		// Token: 0x0602B106 RID: 176390 RVA: 0x005F04FB File Offset: 0x005EE6FB
		public Span<byte> GetInitTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B107 RID: 176391 RVA: 0x005F050A File Offset: 0x005EE70A
		public byte[] GetInitTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BA5A RID: 47706
		// (get) Token: 0x0602B108 RID: 176392 RVA: 0x005F0518 File Offset: 0x005EE718
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

		// Token: 0x0602B109 RID: 176393 RVA: 0x005F054F File Offset: 0x005EE74F
		public Span<byte> GetProgressTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602B10A RID: 176394 RVA: 0x005F055E File Offset: 0x005EE75E
		public byte[] GetProgressTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BA5B RID: 47707
		// (get) Token: 0x0602B10B RID: 176395 RVA: 0x005F056C File Offset: 0x005EE76C
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

		// Token: 0x0602B10C RID: 176396 RVA: 0x005F05A4 File Offset: 0x005EE7A4
		public Span<byte> GetSkipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602B10D RID: 176397 RVA: 0x005F05B4 File Offset: 0x005EE7B4
		public byte[] GetSkipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BA5C RID: 47708
		// (get) Token: 0x0602B10E RID: 176398 RVA: 0x005F05C4 File Offset: 0x005EE7C4
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

		// Token: 0x0602B10F RID: 176399 RVA: 0x005F05FC File Offset: 0x005EE7FC
		public Span<byte> GetFinishTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602B110 RID: 176400 RVA: 0x005F060C File Offset: 0x005EE80C
		public byte[] GetFinishTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602B111 RID: 176401 RVA: 0x005F061C File Offset: 0x005EE81C
		public string InitDialogues(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BA5D RID: 47709
		// (get) Token: 0x0602B112 RID: 176402 RVA: 0x005F0658 File Offset: 0x005EE858
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

		// Token: 0x1700BA5E RID: 47710
		// (get) Token: 0x0602B113 RID: 176403 RVA: 0x005F0684 File Offset: 0x005EE884
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

		// Token: 0x1700BA5F RID: 47711
		// (get) Token: 0x0602B114 RID: 176404 RVA: 0x005F06C4 File Offset: 0x005EE8C4
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

		// Token: 0x0602B115 RID: 176405 RVA: 0x005F06FC File Offset: 0x005EE8FC
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602B116 RID: 176406 RVA: 0x005F070C File Offset: 0x005EE90C
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700BA60 RID: 47712
		// (get) Token: 0x0602B117 RID: 176407 RVA: 0x005F071C File Offset: 0x005EE91C
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

		// Token: 0x0602B118 RID: 176408 RVA: 0x005F075C File Offset: 0x005EE95C
		public static Offset<IAstrologyTextUiConfig> CreateIAstrologyTextUiConfig(FlatBufferBuilder builder, ETextUiType Type = ETextUiType.Astrology, StringOffset InitTipTextOffset = default(StringOffset), StringOffset ProgressTipTextOffset = default(StringOffset), StringOffset SkipTextOffset = default(StringOffset), StringOffset FinishTextOffset = default(StringOffset), VectorOffset InitDialoguesOffset = default(VectorOffset), int SkipConfirmBoxId = 0, StringOffset LoopAudioEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IAstrologyTextUiConfig.AddLoopAudioEvent(builder, LoopAudioEventOffset);
			IAstrologyTextUiConfig.AddSkipConfirmBoxId(builder, SkipConfirmBoxId);
			IAstrologyTextUiConfig.AddInitDialogues(builder, InitDialoguesOffset);
			IAstrologyTextUiConfig.AddFinishText(builder, FinishTextOffset);
			IAstrologyTextUiConfig.AddSkipText(builder, SkipTextOffset);
			IAstrologyTextUiConfig.AddProgressTipText(builder, ProgressTipTextOffset);
			IAstrologyTextUiConfig.AddInitTipText(builder, InitTipTextOffset);
			IAstrologyTextUiConfig.AddNullMask(builder, NullMask);
			IAstrologyTextUiConfig.AddType(builder, Type);
			return IAstrologyTextUiConfig.EndIAstrologyTextUiConfig(builder);
		}

		// Token: 0x0602B119 RID: 176409 RVA: 0x005F07BC File Offset: 0x005EE9BC
		public static void StartIAstrologyTextUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602B11A RID: 176410 RVA: 0x005F07C6 File Offset: 0x005EE9C6
		public static void AddType(FlatBufferBuilder builder, ETextUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B11B RID: 176411 RVA: 0x005F07D1 File Offset: 0x005EE9D1
		public static void AddInitTipText(FlatBufferBuilder builder, StringOffset initTipTextOffset)
		{
			builder.AddOffset(1, initTipTextOffset.Value, 0);
		}

		// Token: 0x0602B11C RID: 176412 RVA: 0x005F07E1 File Offset: 0x005EE9E1
		public static void AddProgressTipText(FlatBufferBuilder builder, StringOffset progressTipTextOffset)
		{
			builder.AddOffset(2, progressTipTextOffset.Value, 0);
		}

		// Token: 0x0602B11D RID: 176413 RVA: 0x005F07F1 File Offset: 0x005EE9F1
		public static void AddSkipText(FlatBufferBuilder builder, StringOffset skipTextOffset)
		{
			builder.AddOffset(3, skipTextOffset.Value, 0);
		}

		// Token: 0x0602B11E RID: 176414 RVA: 0x005F0801 File Offset: 0x005EEA01
		public static void AddFinishText(FlatBufferBuilder builder, StringOffset finishTextOffset)
		{
			builder.AddOffset(4, finishTextOffset.Value, 0);
		}

		// Token: 0x0602B11F RID: 176415 RVA: 0x005F0811 File Offset: 0x005EEA11
		public static void AddInitDialogues(FlatBufferBuilder builder, VectorOffset initDialoguesOffset)
		{
			builder.AddOffset(5, initDialoguesOffset.Value, 0);
		}

		// Token: 0x0602B120 RID: 176416 RVA: 0x005F0824 File Offset: 0x005EEA24
		public static VectorOffset CreateInitDialoguesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B121 RID: 176417 RVA: 0x005F0864 File Offset: 0x005EEA64
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B122 RID: 176418 RVA: 0x005F087E File Offset: 0x005EEA7E
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B123 RID: 176419 RVA: 0x005F089C File Offset: 0x005EEA9C
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B124 RID: 176420 RVA: 0x005F08B5 File Offset: 0x005EEAB5
		public static void StartInitDialoguesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B125 RID: 176421 RVA: 0x005F08C0 File Offset: 0x005EEAC0
		public static void AddSkipConfirmBoxId(FlatBufferBuilder builder, int skipConfirmBoxId)
		{
			builder.AddInt(6, skipConfirmBoxId, 0);
		}

		// Token: 0x0602B126 RID: 176422 RVA: 0x005F08CB File Offset: 0x005EEACB
		public static void AddLoopAudioEvent(FlatBufferBuilder builder, StringOffset loopAudioEventOffset)
		{
			builder.AddOffset(7, loopAudioEventOffset.Value, 0);
		}

		// Token: 0x0602B127 RID: 176423 RVA: 0x005F08DB File Offset: 0x005EEADB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602B128 RID: 176424 RVA: 0x005F08E6 File Offset: 0x005EEAE6
		public static Offset<IAstrologyTextUiConfig> EndIAstrologyTextUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAstrologyTextUiConfig>(builder.EndTable());
		}

		// Token: 0x0602B129 RID: 176425 RVA: 0x005F08F4 File Offset: 0x005EEAF4
		public IAstrologyTextUiConfigT UnPack()
		{
			IAstrologyTextUiConfigT astrologyTextUiConfigT = new IAstrologyTextUiConfigT();
			this.UnPackTo(astrologyTextUiConfigT);
			return astrologyTextUiConfigT;
		}

		// Token: 0x0602B12A RID: 176426 RVA: 0x005F0910 File Offset: 0x005EEB10
		public void UnPackTo(IAstrologyTextUiConfigT _o)
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

		// Token: 0x0602B12B RID: 176427 RVA: 0x005F09AC File Offset: 0x005EEBAC
		public static Offset<IAstrologyTextUiConfig> Pack(FlatBufferBuilder builder, IAstrologyTextUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAstrologyTextUiConfig>);
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
				initDialoguesOffset = IAstrologyTextUiConfig.CreateInitDialoguesVector(builder, array);
			}
			StringOffset loopAudioEventOffset = (_o.LoopAudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.LoopAudioEvent);
			return IAstrologyTextUiConfig.CreateIAstrologyTextUiConfig(builder, _o.Type, initTipTextOffset, progressTipTextOffset, skipTextOffset, finishTextOffset, initDialoguesOffset, _o.SkipConfirmBoxId, loopAudioEventOffset, _o.NullMask);
		}

		// Token: 0x040106BD RID: 67261
		private Table __p;
	}
}
