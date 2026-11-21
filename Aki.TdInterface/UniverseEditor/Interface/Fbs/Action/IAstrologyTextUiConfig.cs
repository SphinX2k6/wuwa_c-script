using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006817 RID: 26647
	public struct IAstrologyTextUiConfig : IFlatbufferObject
	{
		// Token: 0x1700C3DA RID: 50138
		// (get) Token: 0x0602D845 RID: 186437 RVA: 0x0063AE8E File Offset: 0x0063908E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D846 RID: 186438 RVA: 0x0063AE9B File Offset: 0x0063909B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D847 RID: 186439 RVA: 0x0063AEA4 File Offset: 0x006390A4
		public static IAstrologyTextUiConfig GetRootAsIAstrologyTextUiConfig(ByteBuffer _bb)
		{
			return IAstrologyTextUiConfig.GetRootAsIAstrologyTextUiConfig(_bb, default(IAstrologyTextUiConfig));
		}

		// Token: 0x0602D848 RID: 186440 RVA: 0x0063AEC0 File Offset: 0x006390C0
		public static IAstrologyTextUiConfig GetRootAsIAstrologyTextUiConfig(ByteBuffer _bb, IAstrologyTextUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D849 RID: 186441 RVA: 0x0063AEDD File Offset: 0x006390DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D84A RID: 186442 RVA: 0x0063AEEC File Offset: 0x006390EC
		public IAstrologyTextUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3DB RID: 50139
		// (get) Token: 0x0602D84B RID: 186443 RVA: 0x0063AEFC File Offset: 0x006390FC
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

		// Token: 0x1700C3DC RID: 50140
		// (get) Token: 0x0602D84C RID: 186444 RVA: 0x0063AF38 File Offset: 0x00639138
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

		// Token: 0x0602D84D RID: 186445 RVA: 0x0063AF6F File Offset: 0x0063916F
		public Span<byte> GetInitTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D84E RID: 186446 RVA: 0x0063AF7E File Offset: 0x0063917E
		public byte[] GetInitTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C3DD RID: 50141
		// (get) Token: 0x0602D84F RID: 186447 RVA: 0x0063AF8C File Offset: 0x0063918C
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

		// Token: 0x0602D850 RID: 186448 RVA: 0x0063AFC3 File Offset: 0x006391C3
		public Span<byte> GetProgressTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602D851 RID: 186449 RVA: 0x0063AFD2 File Offset: 0x006391D2
		public byte[] GetProgressTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C3DE RID: 50142
		// (get) Token: 0x0602D852 RID: 186450 RVA: 0x0063AFE0 File Offset: 0x006391E0
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

		// Token: 0x0602D853 RID: 186451 RVA: 0x0063B018 File Offset: 0x00639218
		public Span<byte> GetSkipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602D854 RID: 186452 RVA: 0x0063B028 File Offset: 0x00639228
		public byte[] GetSkipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C3DF RID: 50143
		// (get) Token: 0x0602D855 RID: 186453 RVA: 0x0063B038 File Offset: 0x00639238
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

		// Token: 0x0602D856 RID: 186454 RVA: 0x0063B070 File Offset: 0x00639270
		public Span<byte> GetFinishTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602D857 RID: 186455 RVA: 0x0063B080 File Offset: 0x00639280
		public byte[] GetFinishTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602D858 RID: 186456 RVA: 0x0063B090 File Offset: 0x00639290
		public string InitDialogues(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C3E0 RID: 50144
		// (get) Token: 0x0602D859 RID: 186457 RVA: 0x0063B0CC File Offset: 0x006392CC
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

		// Token: 0x1700C3E1 RID: 50145
		// (get) Token: 0x0602D85A RID: 186458 RVA: 0x0063B0F8 File Offset: 0x006392F8
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

		// Token: 0x1700C3E2 RID: 50146
		// (get) Token: 0x0602D85B RID: 186459 RVA: 0x0063B138 File Offset: 0x00639338
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

		// Token: 0x0602D85C RID: 186460 RVA: 0x0063B170 File Offset: 0x00639370
		public Span<byte> GetLoopAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602D85D RID: 186461 RVA: 0x0063B180 File Offset: 0x00639380
		public byte[] GetLoopAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700C3E3 RID: 50147
		// (get) Token: 0x0602D85E RID: 186462 RVA: 0x0063B190 File Offset: 0x00639390
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

		// Token: 0x0602D85F RID: 186463 RVA: 0x0063B1D0 File Offset: 0x006393D0
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

		// Token: 0x0602D860 RID: 186464 RVA: 0x0063B230 File Offset: 0x00639430
		public static void StartIAstrologyTextUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602D861 RID: 186465 RVA: 0x0063B23A File Offset: 0x0063943A
		public static void AddType(FlatBufferBuilder builder, ETextUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D862 RID: 186466 RVA: 0x0063B245 File Offset: 0x00639445
		public static void AddInitTipText(FlatBufferBuilder builder, StringOffset initTipTextOffset)
		{
			builder.AddOffset(1, initTipTextOffset.Value, 0);
		}

		// Token: 0x0602D863 RID: 186467 RVA: 0x0063B255 File Offset: 0x00639455
		public static void AddProgressTipText(FlatBufferBuilder builder, StringOffset progressTipTextOffset)
		{
			builder.AddOffset(2, progressTipTextOffset.Value, 0);
		}

		// Token: 0x0602D864 RID: 186468 RVA: 0x0063B265 File Offset: 0x00639465
		public static void AddSkipText(FlatBufferBuilder builder, StringOffset skipTextOffset)
		{
			builder.AddOffset(3, skipTextOffset.Value, 0);
		}

		// Token: 0x0602D865 RID: 186469 RVA: 0x0063B275 File Offset: 0x00639475
		public static void AddFinishText(FlatBufferBuilder builder, StringOffset finishTextOffset)
		{
			builder.AddOffset(4, finishTextOffset.Value, 0);
		}

		// Token: 0x0602D866 RID: 186470 RVA: 0x0063B285 File Offset: 0x00639485
		public static void AddInitDialogues(FlatBufferBuilder builder, VectorOffset initDialoguesOffset)
		{
			builder.AddOffset(5, initDialoguesOffset.Value, 0);
		}

		// Token: 0x0602D867 RID: 186471 RVA: 0x0063B298 File Offset: 0x00639498
		public static VectorOffset CreateInitDialoguesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D868 RID: 186472 RVA: 0x0063B2D8 File Offset: 0x006394D8
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D869 RID: 186473 RVA: 0x0063B2F2 File Offset: 0x006394F2
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D86A RID: 186474 RVA: 0x0063B310 File Offset: 0x00639510
		public static VectorOffset CreateInitDialoguesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D86B RID: 186475 RVA: 0x0063B329 File Offset: 0x00639529
		public static void StartInitDialoguesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D86C RID: 186476 RVA: 0x0063B334 File Offset: 0x00639534
		public static void AddSkipConfirmBoxId(FlatBufferBuilder builder, int skipConfirmBoxId)
		{
			builder.AddInt(6, skipConfirmBoxId, 0);
		}

		// Token: 0x0602D86D RID: 186477 RVA: 0x0063B33F File Offset: 0x0063953F
		public static void AddLoopAudioEvent(FlatBufferBuilder builder, StringOffset loopAudioEventOffset)
		{
			builder.AddOffset(7, loopAudioEventOffset.Value, 0);
		}

		// Token: 0x0602D86E RID: 186478 RVA: 0x0063B34F File Offset: 0x0063954F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602D86F RID: 186479 RVA: 0x0063B35A File Offset: 0x0063955A
		public static Offset<IAstrologyTextUiConfig> EndIAstrologyTextUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAstrologyTextUiConfig>(builder.EndTable());
		}

		// Token: 0x0602D870 RID: 186480 RVA: 0x0063B368 File Offset: 0x00639568
		public IAstrologyTextUiConfigT UnPack()
		{
			IAstrologyTextUiConfigT astrologyTextUiConfigT = new IAstrologyTextUiConfigT();
			this.UnPackTo(astrologyTextUiConfigT);
			return astrologyTextUiConfigT;
		}

		// Token: 0x0602D871 RID: 186481 RVA: 0x0063B384 File Offset: 0x00639584
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

		// Token: 0x0602D872 RID: 186482 RVA: 0x0063B420 File Offset: 0x00639620
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

		// Token: 0x040114CF RID: 70863
		private Table __p;
	}
}
