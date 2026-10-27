using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B0 RID: 17328
	public struct IOccupationData : IFlatbufferObject
	{
		// Token: 0x17007A80 RID: 31360
		// (get) Token: 0x06019CEA RID: 105706 RVA: 0x003B1BCD File Offset: 0x003AFDCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CEB RID: 105707 RVA: 0x003B1BDA File Offset: 0x003AFDDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CEC RID: 105708 RVA: 0x003B1BE4 File Offset: 0x003AFDE4
		public static IOccupationData GetRootAsIOccupationData(ByteBuffer _bb)
		{
			return IOccupationData.GetRootAsIOccupationData(_bb, default(IOccupationData));
		}

		// Token: 0x06019CED RID: 105709 RVA: 0x003B1C00 File Offset: 0x003AFE00
		public static IOccupationData GetRootAsIOccupationData(ByteBuffer _bb, IOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019CEE RID: 105710 RVA: 0x003B1C1D File Offset: 0x003AFE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019CEF RID: 105711 RVA: 0x003B1C2C File Offset: 0x003AFE2C
		public IOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019CF0 RID: 105712 RVA: 0x003B1C3C File Offset: 0x003AFE3C
		public string Npc(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A81 RID: 31361
		// (get) Token: 0x06019CF1 RID: 105713 RVA: 0x003B1C78 File Offset: 0x003AFE78
		public int NpcLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019CF2 RID: 105714 RVA: 0x003B1CA4 File Offset: 0x003AFEA4
		public IOccupationExportConfig? NpcConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IOccupationExportConfig?(default(IOccupationExportConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A82 RID: 31362
		// (get) Token: 0x06019CF3 RID: 105715 RVA: 0x003B1D04 File Offset: 0x003AFF04
		public int NpcConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019CF4 RID: 105716 RVA: 0x003B1D30 File Offset: 0x003AFF30
		public string Area(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A83 RID: 31363
		// (get) Token: 0x06019CF5 RID: 105717 RVA: 0x003B1D6C File Offset: 0x003AFF6C
		public int AreaLength
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

		// Token: 0x06019CF6 RID: 105718 RVA: 0x003B1D98 File Offset: 0x003AFF98
		public IAreaExportData? AreaConfig(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IAreaExportData?(default(IAreaExportData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A84 RID: 31364
		// (get) Token: 0x06019CF7 RID: 105719 RVA: 0x003B1DFC File Offset: 0x003AFFFC
		public int AreaConfigLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019CF8 RID: 105720 RVA: 0x003B1E28 File Offset: 0x003B0028
		public ISilentAreaExportData? SilentArea(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ISilentAreaExportData?(default(ISilentAreaExportData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A85 RID: 31365
		// (get) Token: 0x06019CF9 RID: 105721 RVA: 0x003B1E8C File Offset: 0x003B008C
		public int SilentAreaLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007A86 RID: 31366
		// (get) Token: 0x06019CFA RID: 105722 RVA: 0x003B1EB8 File Offset: 0x003B00B8
		public string ScreenResource
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

		// Token: 0x06019CFB RID: 105723 RVA: 0x003B1EF0 File Offset: 0x003B00F0
		public Span<byte> GetScreenResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06019CFC RID: 105724 RVA: 0x003B1F00 File Offset: 0x003B0100
		public byte[] GetScreenResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17007A87 RID: 31367
		// (get) Token: 0x06019CFD RID: 105725 RVA: 0x003B1F10 File Offset: 0x003B0110
		public string TimeOccupation
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

		// Token: 0x06019CFE RID: 105726 RVA: 0x003B1F48 File Offset: 0x003B0148
		public Span<byte> GetTimeOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06019CFF RID: 105727 RVA: 0x003B1F58 File Offset: 0x003B0158
		public byte[] GetTimeOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17007A88 RID: 31368
		// (get) Token: 0x06019D00 RID: 105728 RVA: 0x003B1F68 File Offset: 0x003B0168
		public string ClosedSegmentOccupation
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

		// Token: 0x06019D01 RID: 105729 RVA: 0x003B1FA0 File Offset: 0x003B01A0
		public Span<byte> GetClosedSegmentOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06019D02 RID: 105730 RVA: 0x003B1FB0 File Offset: 0x003B01B0
		public byte[] GetClosedSegmentOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x06019D03 RID: 105731 RVA: 0x003B1FC0 File Offset: 0x003B01C0
		public string ClosedSegments(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A89 RID: 31369
		// (get) Token: 0x06019D04 RID: 105732 RVA: 0x003B1FFC File Offset: 0x003B01FC
		public int ClosedSegmentsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019D05 RID: 105733 RVA: 0x003B2028 File Offset: 0x003B0228
		public static Offset<IOccupationData> CreateIOccupationData(FlatBufferBuilder builder, VectorOffset NpcOffset = default(VectorOffset), VectorOffset NpcConfigOffset = default(VectorOffset), VectorOffset AreaOffset = default(VectorOffset), VectorOffset AreaConfigOffset = default(VectorOffset), VectorOffset SilentAreaOffset = default(VectorOffset), StringOffset ScreenResourceOffset = default(StringOffset), StringOffset TimeOccupationOffset = default(StringOffset), StringOffset ClosedSegmentOccupationOffset = default(StringOffset), VectorOffset ClosedSegmentsOffset = default(VectorOffset))
		{
			builder.StartTable(9);
			IOccupationData.AddClosedSegments(builder, ClosedSegmentsOffset);
			IOccupationData.AddClosedSegmentOccupation(builder, ClosedSegmentOccupationOffset);
			IOccupationData.AddTimeOccupation(builder, TimeOccupationOffset);
			IOccupationData.AddScreenResource(builder, ScreenResourceOffset);
			IOccupationData.AddSilentArea(builder, SilentAreaOffset);
			IOccupationData.AddAreaConfig(builder, AreaConfigOffset);
			IOccupationData.AddArea(builder, AreaOffset);
			IOccupationData.AddNpcConfig(builder, NpcConfigOffset);
			IOccupationData.AddNpc(builder, NpcOffset);
			return IOccupationData.EndIOccupationData(builder);
		}

		// Token: 0x06019D06 RID: 105734 RVA: 0x003B2088 File Offset: 0x003B0288
		public static void StartIOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019D07 RID: 105735 RVA: 0x003B2092 File Offset: 0x003B0292
		public static void AddNpc(FlatBufferBuilder builder, VectorOffset npcOffset)
		{
			builder.AddOffset(0, npcOffset.Value, 0);
		}

		// Token: 0x06019D08 RID: 105736 RVA: 0x003B20A4 File Offset: 0x003B02A4
		public static VectorOffset CreateNpcVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D09 RID: 105737 RVA: 0x003B20E4 File Offset: 0x003B02E4
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D0A RID: 105738 RVA: 0x003B20FE File Offset: 0x003B02FE
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D0B RID: 105739 RVA: 0x003B211C File Offset: 0x003B031C
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D0C RID: 105740 RVA: 0x003B2135 File Offset: 0x003B0335
		public static void StartNpcVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D0D RID: 105741 RVA: 0x003B2140 File Offset: 0x003B0340
		public static void AddNpcConfig(FlatBufferBuilder builder, VectorOffset npcConfigOffset)
		{
			builder.AddOffset(1, npcConfigOffset.Value, 0);
		}

		// Token: 0x06019D0E RID: 105742 RVA: 0x003B2150 File Offset: 0x003B0350
		public static VectorOffset CreateNpcConfigVector(FlatBufferBuilder builder, Offset<IOccupationExportConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D0F RID: 105743 RVA: 0x003B2190 File Offset: 0x003B0390
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, Offset<IOccupationExportConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IOccupationExportConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D10 RID: 105744 RVA: 0x003B21AA File Offset: 0x003B03AA
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IOccupationExportConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IOccupationExportConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D11 RID: 105745 RVA: 0x003B21C8 File Offset: 0x003B03C8
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IOccupationExportConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D12 RID: 105746 RVA: 0x003B21E1 File Offset: 0x003B03E1
		public static void StartNpcConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D13 RID: 105747 RVA: 0x003B21EC File Offset: 0x003B03EC
		public static void AddArea(FlatBufferBuilder builder, VectorOffset areaOffset)
		{
			builder.AddOffset(2, areaOffset.Value, 0);
		}

		// Token: 0x06019D14 RID: 105748 RVA: 0x003B21FC File Offset: 0x003B03FC
		public static VectorOffset CreateAreaVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D15 RID: 105749 RVA: 0x003B223C File Offset: 0x003B043C
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D16 RID: 105750 RVA: 0x003B2256 File Offset: 0x003B0456
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D17 RID: 105751 RVA: 0x003B2274 File Offset: 0x003B0474
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D18 RID: 105752 RVA: 0x003B228D File Offset: 0x003B048D
		public static void StartAreaVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D19 RID: 105753 RVA: 0x003B2298 File Offset: 0x003B0498
		public static void AddAreaConfig(FlatBufferBuilder builder, VectorOffset areaConfigOffset)
		{
			builder.AddOffset(3, areaConfigOffset.Value, 0);
		}

		// Token: 0x06019D1A RID: 105754 RVA: 0x003B22A8 File Offset: 0x003B04A8
		public static VectorOffset CreateAreaConfigVector(FlatBufferBuilder builder, Offset<IAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D1B RID: 105755 RVA: 0x003B22E8 File Offset: 0x003B04E8
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, Offset<IAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D1C RID: 105756 RVA: 0x003B2302 File Offset: 0x003B0502
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaExportData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D1D RID: 105757 RVA: 0x003B2320 File Offset: 0x003B0520
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaExportData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D1E RID: 105758 RVA: 0x003B2339 File Offset: 0x003B0539
		public static void StartAreaConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D1F RID: 105759 RVA: 0x003B2344 File Offset: 0x003B0544
		public static void AddSilentArea(FlatBufferBuilder builder, VectorOffset silentAreaOffset)
		{
			builder.AddOffset(4, silentAreaOffset.Value, 0);
		}

		// Token: 0x06019D20 RID: 105760 RVA: 0x003B2354 File Offset: 0x003B0554
		public static VectorOffset CreateSilentAreaVector(FlatBufferBuilder builder, Offset<ISilentAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D21 RID: 105761 RVA: 0x003B2394 File Offset: 0x003B0594
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, Offset<ISilentAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISilentAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D22 RID: 105762 RVA: 0x003B23AE File Offset: 0x003B05AE
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISilentAreaExportData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISilentAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D23 RID: 105763 RVA: 0x003B23CC File Offset: 0x003B05CC
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISilentAreaExportData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D24 RID: 105764 RVA: 0x003B23E5 File Offset: 0x003B05E5
		public static void StartSilentAreaVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D25 RID: 105765 RVA: 0x003B23F0 File Offset: 0x003B05F0
		public static void AddScreenResource(FlatBufferBuilder builder, StringOffset screenResourceOffset)
		{
			builder.AddOffset(5, screenResourceOffset.Value, 0);
		}

		// Token: 0x06019D26 RID: 105766 RVA: 0x003B2400 File Offset: 0x003B0600
		public static void AddTimeOccupation(FlatBufferBuilder builder, StringOffset timeOccupationOffset)
		{
			builder.AddOffset(6, timeOccupationOffset.Value, 0);
		}

		// Token: 0x06019D27 RID: 105767 RVA: 0x003B2410 File Offset: 0x003B0610
		public static void AddClosedSegmentOccupation(FlatBufferBuilder builder, StringOffset closedSegmentOccupationOffset)
		{
			builder.AddOffset(7, closedSegmentOccupationOffset.Value, 0);
		}

		// Token: 0x06019D28 RID: 105768 RVA: 0x003B2420 File Offset: 0x003B0620
		public static void AddClosedSegments(FlatBufferBuilder builder, VectorOffset closedSegmentsOffset)
		{
			builder.AddOffset(8, closedSegmentsOffset.Value, 0);
		}

		// Token: 0x06019D29 RID: 105769 RVA: 0x003B2430 File Offset: 0x003B0630
		public static VectorOffset CreateClosedSegmentsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D2A RID: 105770 RVA: 0x003B2470 File Offset: 0x003B0670
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D2B RID: 105771 RVA: 0x003B248A File Offset: 0x003B068A
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D2C RID: 105772 RVA: 0x003B24A8 File Offset: 0x003B06A8
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D2D RID: 105773 RVA: 0x003B24C1 File Offset: 0x003B06C1
		public static void StartClosedSegmentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D2E RID: 105774 RVA: 0x003B24CC File Offset: 0x003B06CC
		public static Offset<IOccupationData> EndIOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationData>(builder.EndTable());
		}

		// Token: 0x06019D2F RID: 105775 RVA: 0x003B24DC File Offset: 0x003B06DC
		public IOccupationDataT UnPack()
		{
			IOccupationDataT occupationDataT = new IOccupationDataT();
			this.UnPackTo(occupationDataT);
			return occupationDataT;
		}

		// Token: 0x06019D30 RID: 105776 RVA: 0x003B24F8 File Offset: 0x003B06F8
		public void UnPackTo(IOccupationDataT _o)
		{
			_o.Npc = new List<string>();
			for (int i = 0; i < this.NpcLength; i++)
			{
				_o.Npc.Add(this.Npc(i));
			}
			_o.NpcConfig = new List<IOccupationExportConfigT>();
			for (int j = 0; j < this.NpcConfigLength; j++)
			{
				_o.NpcConfig.Add((this.NpcConfig(j) != null) ? this.NpcConfig(j).Value.UnPack() : null);
			}
			_o.Area = new List<string>();
			for (int k = 0; k < this.AreaLength; k++)
			{
				_o.Area.Add(this.Area(k));
			}
			_o.AreaConfig = new List<IAreaExportDataT>();
			for (int l = 0; l < this.AreaConfigLength; l++)
			{
				_o.AreaConfig.Add((this.AreaConfig(l) != null) ? this.AreaConfig(l).Value.UnPack() : null);
			}
			_o.SilentArea = new List<ISilentAreaExportDataT>();
			for (int m = 0; m < this.SilentAreaLength; m++)
			{
				_o.SilentArea.Add((this.SilentArea(m) != null) ? this.SilentArea(m).Value.UnPack() : null);
			}
			_o.ScreenResource = this.ScreenResource;
			_o.TimeOccupation = this.TimeOccupation;
			_o.ClosedSegmentOccupation = this.ClosedSegmentOccupation;
			_o.ClosedSegments = new List<string>();
			for (int n = 0; n < this.ClosedSegmentsLength; n++)
			{
				_o.ClosedSegments.Add(this.ClosedSegments(n));
			}
		}

		// Token: 0x06019D31 RID: 105777 RVA: 0x003B26C8 File Offset: 0x003B08C8
		public static Offset<IOccupationData> Pack(FlatBufferBuilder builder, IOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOccupationData>);
			}
			VectorOffset npcOffset = default(VectorOffset);
			if (_o.Npc != null)
			{
				StringOffset[] array = new StringOffset[_o.Npc.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Npc[i]);
				}
				npcOffset = IOccupationData.CreateNpcVector(builder, array);
			}
			VectorOffset npcConfigOffset = default(VectorOffset);
			if (_o.NpcConfig != null)
			{
				Offset<IOccupationExportConfig>[] array2 = new Offset<IOccupationExportConfig>[_o.NpcConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IOccupationExportConfig.Pack(builder, _o.NpcConfig[j]);
				}
				npcConfigOffset = IOccupationData.CreateNpcConfigVector(builder, array2);
			}
			VectorOffset areaOffset = default(VectorOffset);
			if (_o.Area != null)
			{
				StringOffset[] array3 = new StringOffset[_o.Area.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.Area[k]);
				}
				areaOffset = IOccupationData.CreateAreaVector(builder, array3);
			}
			VectorOffset areaConfigOffset = default(VectorOffset);
			if (_o.AreaConfig != null)
			{
				Offset<IAreaExportData>[] array4 = new Offset<IAreaExportData>[_o.AreaConfig.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IAreaExportData.Pack(builder, _o.AreaConfig[l]);
				}
				areaConfigOffset = IOccupationData.CreateAreaConfigVector(builder, array4);
			}
			VectorOffset silentAreaOffset = default(VectorOffset);
			if (_o.SilentArea != null)
			{
				Offset<ISilentAreaExportData>[] array5 = new Offset<ISilentAreaExportData>[_o.SilentArea.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = ISilentAreaExportData.Pack(builder, _o.SilentArea[m]);
				}
				silentAreaOffset = IOccupationData.CreateSilentAreaVector(builder, array5);
			}
			StringOffset screenResourceOffset = (_o.ScreenResource == null) ? default(StringOffset) : builder.CreateString(_o.ScreenResource);
			StringOffset timeOccupationOffset = (_o.TimeOccupation == null) ? default(StringOffset) : builder.CreateString(_o.TimeOccupation);
			StringOffset closedSegmentOccupationOffset = (_o.ClosedSegmentOccupation == null) ? default(StringOffset) : builder.CreateString(_o.ClosedSegmentOccupation);
			VectorOffset closedSegmentsOffset = default(VectorOffset);
			if (_o.ClosedSegments != null)
			{
				StringOffset[] array6 = new StringOffset[_o.ClosedSegments.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = builder.CreateString(_o.ClosedSegments[n]);
				}
				closedSegmentsOffset = IOccupationData.CreateClosedSegmentsVector(builder, array6);
			}
			return IOccupationData.CreateIOccupationData(builder, npcOffset, npcConfigOffset, areaOffset, areaConfigOffset, silentAreaOffset, screenResourceOffset, timeOccupationOffset, closedSegmentOccupationOffset, closedSegmentsOffset);
		}

		// Token: 0x0400C1E8 RID: 49640
		private Table __p;
	}
}
