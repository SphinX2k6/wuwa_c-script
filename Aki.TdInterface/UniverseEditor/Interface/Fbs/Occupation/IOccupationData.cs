using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004812 RID: 18450
	public struct IOccupationData : IFlatbufferObject
	{
		// Token: 0x170080B5 RID: 32949
		// (get) Token: 0x0601B479 RID: 111737 RVA: 0x003DD64D File Offset: 0x003DB84D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B47A RID: 111738 RVA: 0x003DD65A File Offset: 0x003DB85A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B47B RID: 111739 RVA: 0x003DD664 File Offset: 0x003DB864
		public static IOccupationData GetRootAsIOccupationData(ByteBuffer _bb)
		{
			return IOccupationData.GetRootAsIOccupationData(_bb, default(IOccupationData));
		}

		// Token: 0x0601B47C RID: 111740 RVA: 0x003DD680 File Offset: 0x003DB880
		public static IOccupationData GetRootAsIOccupationData(ByteBuffer _bb, IOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B47D RID: 111741 RVA: 0x003DD69D File Offset: 0x003DB89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B47E RID: 111742 RVA: 0x003DD6AC File Offset: 0x003DB8AC
		public IOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B47F RID: 111743 RVA: 0x003DD6BC File Offset: 0x003DB8BC
		public string Npc(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080B6 RID: 32950
		// (get) Token: 0x0601B480 RID: 111744 RVA: 0x003DD6F8 File Offset: 0x003DB8F8
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

		// Token: 0x0601B481 RID: 111745 RVA: 0x003DD724 File Offset: 0x003DB924
		public IOccupationExportConfig? NpcConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IOccupationExportConfig?(default(IOccupationExportConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080B7 RID: 32951
		// (get) Token: 0x0601B482 RID: 111746 RVA: 0x003DD784 File Offset: 0x003DB984
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

		// Token: 0x0601B483 RID: 111747 RVA: 0x003DD7B0 File Offset: 0x003DB9B0
		public string Area(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080B8 RID: 32952
		// (get) Token: 0x0601B484 RID: 111748 RVA: 0x003DD7EC File Offset: 0x003DB9EC
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

		// Token: 0x0601B485 RID: 111749 RVA: 0x003DD818 File Offset: 0x003DBA18
		public IAreaExportData? AreaConfig(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IAreaExportData?(default(IAreaExportData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080B9 RID: 32953
		// (get) Token: 0x0601B486 RID: 111750 RVA: 0x003DD87C File Offset: 0x003DBA7C
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

		// Token: 0x0601B487 RID: 111751 RVA: 0x003DD8A8 File Offset: 0x003DBAA8
		public ISilentAreaExportData? SilentArea(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ISilentAreaExportData?(default(ISilentAreaExportData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080BA RID: 32954
		// (get) Token: 0x0601B488 RID: 111752 RVA: 0x003DD90C File Offset: 0x003DBB0C
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

		// Token: 0x170080BB RID: 32955
		// (get) Token: 0x0601B489 RID: 111753 RVA: 0x003DD938 File Offset: 0x003DBB38
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

		// Token: 0x0601B48A RID: 111754 RVA: 0x003DD970 File Offset: 0x003DBB70
		public Span<byte> GetScreenResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601B48B RID: 111755 RVA: 0x003DD980 File Offset: 0x003DBB80
		public byte[] GetScreenResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170080BC RID: 32956
		// (get) Token: 0x0601B48C RID: 111756 RVA: 0x003DD990 File Offset: 0x003DBB90
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

		// Token: 0x0601B48D RID: 111757 RVA: 0x003DD9C8 File Offset: 0x003DBBC8
		public Span<byte> GetTimeOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601B48E RID: 111758 RVA: 0x003DD9D8 File Offset: 0x003DBBD8
		public byte[] GetTimeOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x170080BD RID: 32957
		// (get) Token: 0x0601B48F RID: 111759 RVA: 0x003DD9E8 File Offset: 0x003DBBE8
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

		// Token: 0x0601B490 RID: 111760 RVA: 0x003DDA20 File Offset: 0x003DBC20
		public Span<byte> GetClosedSegmentOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601B491 RID: 111761 RVA: 0x003DDA30 File Offset: 0x003DBC30
		public byte[] GetClosedSegmentOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0601B492 RID: 111762 RVA: 0x003DDA40 File Offset: 0x003DBC40
		public string ClosedSegments(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080BE RID: 32958
		// (get) Token: 0x0601B493 RID: 111763 RVA: 0x003DDA7C File Offset: 0x003DBC7C
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

		// Token: 0x0601B494 RID: 111764 RVA: 0x003DDAA8 File Offset: 0x003DBCA8
		public string SeasonRotation(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170080BF RID: 32959
		// (get) Token: 0x0601B495 RID: 111765 RVA: 0x003DDAE4 File Offset: 0x003DBCE4
		public int SeasonRotationLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601B496 RID: 111766 RVA: 0x003DDB10 File Offset: 0x003DBD10
		public static Offset<IOccupationData> CreateIOccupationData(FlatBufferBuilder builder, VectorOffset NpcOffset = default(VectorOffset), VectorOffset NpcConfigOffset = default(VectorOffset), VectorOffset AreaOffset = default(VectorOffset), VectorOffset AreaConfigOffset = default(VectorOffset), VectorOffset SilentAreaOffset = default(VectorOffset), StringOffset ScreenResourceOffset = default(StringOffset), StringOffset TimeOccupationOffset = default(StringOffset), StringOffset ClosedSegmentOccupationOffset = default(StringOffset), VectorOffset ClosedSegmentsOffset = default(VectorOffset), VectorOffset SeasonRotationOffset = default(VectorOffset))
		{
			builder.StartTable(10);
			IOccupationData.AddSeasonRotation(builder, SeasonRotationOffset);
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

		// Token: 0x0601B497 RID: 111767 RVA: 0x003DDB78 File Offset: 0x003DBD78
		public static void StartIOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601B498 RID: 111768 RVA: 0x003DDB82 File Offset: 0x003DBD82
		public static void AddNpc(FlatBufferBuilder builder, VectorOffset npcOffset)
		{
			builder.AddOffset(0, npcOffset.Value, 0);
		}

		// Token: 0x0601B499 RID: 111769 RVA: 0x003DDB94 File Offset: 0x003DBD94
		public static VectorOffset CreateNpcVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B49A RID: 111770 RVA: 0x003DDBD4 File Offset: 0x003DBDD4
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B49B RID: 111771 RVA: 0x003DDBEE File Offset: 0x003DBDEE
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B49C RID: 111772 RVA: 0x003DDC0C File Offset: 0x003DBE0C
		public static VectorOffset CreateNpcVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B49D RID: 111773 RVA: 0x003DDC25 File Offset: 0x003DBE25
		public static void StartNpcVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B49E RID: 111774 RVA: 0x003DDC30 File Offset: 0x003DBE30
		public static void AddNpcConfig(FlatBufferBuilder builder, VectorOffset npcConfigOffset)
		{
			builder.AddOffset(1, npcConfigOffset.Value, 0);
		}

		// Token: 0x0601B49F RID: 111775 RVA: 0x003DDC40 File Offset: 0x003DBE40
		public static VectorOffset CreateNpcConfigVector(FlatBufferBuilder builder, Offset<IOccupationExportConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4A0 RID: 111776 RVA: 0x003DDC80 File Offset: 0x003DBE80
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, Offset<IOccupationExportConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IOccupationExportConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4A1 RID: 111777 RVA: 0x003DDC9A File Offset: 0x003DBE9A
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IOccupationExportConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IOccupationExportConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4A2 RID: 111778 RVA: 0x003DDCB8 File Offset: 0x003DBEB8
		public static VectorOffset CreateNpcConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IOccupationExportConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4A3 RID: 111779 RVA: 0x003DDCD1 File Offset: 0x003DBED1
		public static void StartNpcConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4A4 RID: 111780 RVA: 0x003DDCDC File Offset: 0x003DBEDC
		public static void AddArea(FlatBufferBuilder builder, VectorOffset areaOffset)
		{
			builder.AddOffset(2, areaOffset.Value, 0);
		}

		// Token: 0x0601B4A5 RID: 111781 RVA: 0x003DDCEC File Offset: 0x003DBEEC
		public static VectorOffset CreateAreaVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4A6 RID: 111782 RVA: 0x003DDD2C File Offset: 0x003DBF2C
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4A7 RID: 111783 RVA: 0x003DDD46 File Offset: 0x003DBF46
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4A8 RID: 111784 RVA: 0x003DDD64 File Offset: 0x003DBF64
		public static VectorOffset CreateAreaVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4A9 RID: 111785 RVA: 0x003DDD7D File Offset: 0x003DBF7D
		public static void StartAreaVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4AA RID: 111786 RVA: 0x003DDD88 File Offset: 0x003DBF88
		public static void AddAreaConfig(FlatBufferBuilder builder, VectorOffset areaConfigOffset)
		{
			builder.AddOffset(3, areaConfigOffset.Value, 0);
		}

		// Token: 0x0601B4AB RID: 111787 RVA: 0x003DDD98 File Offset: 0x003DBF98
		public static VectorOffset CreateAreaConfigVector(FlatBufferBuilder builder, Offset<IAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4AC RID: 111788 RVA: 0x003DDDD8 File Offset: 0x003DBFD8
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, Offset<IAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4AD RID: 111789 RVA: 0x003DDDF2 File Offset: 0x003DBFF2
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaExportData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4AE RID: 111790 RVA: 0x003DDE10 File Offset: 0x003DC010
		public static VectorOffset CreateAreaConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaExportData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4AF RID: 111791 RVA: 0x003DDE29 File Offset: 0x003DC029
		public static void StartAreaConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4B0 RID: 111792 RVA: 0x003DDE34 File Offset: 0x003DC034
		public static void AddSilentArea(FlatBufferBuilder builder, VectorOffset silentAreaOffset)
		{
			builder.AddOffset(4, silentAreaOffset.Value, 0);
		}

		// Token: 0x0601B4B1 RID: 111793 RVA: 0x003DDE44 File Offset: 0x003DC044
		public static VectorOffset CreateSilentAreaVector(FlatBufferBuilder builder, Offset<ISilentAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4B2 RID: 111794 RVA: 0x003DDE84 File Offset: 0x003DC084
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, Offset<ISilentAreaExportData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISilentAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4B3 RID: 111795 RVA: 0x003DDE9E File Offset: 0x003DC09E
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISilentAreaExportData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISilentAreaExportData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4B4 RID: 111796 RVA: 0x003DDEBC File Offset: 0x003DC0BC
		public static VectorOffset CreateSilentAreaVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISilentAreaExportData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4B5 RID: 111797 RVA: 0x003DDED5 File Offset: 0x003DC0D5
		public static void StartSilentAreaVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4B6 RID: 111798 RVA: 0x003DDEE0 File Offset: 0x003DC0E0
		public static void AddScreenResource(FlatBufferBuilder builder, StringOffset screenResourceOffset)
		{
			builder.AddOffset(5, screenResourceOffset.Value, 0);
		}

		// Token: 0x0601B4B7 RID: 111799 RVA: 0x003DDEF0 File Offset: 0x003DC0F0
		public static void AddTimeOccupation(FlatBufferBuilder builder, StringOffset timeOccupationOffset)
		{
			builder.AddOffset(6, timeOccupationOffset.Value, 0);
		}

		// Token: 0x0601B4B8 RID: 111800 RVA: 0x003DDF00 File Offset: 0x003DC100
		public static void AddClosedSegmentOccupation(FlatBufferBuilder builder, StringOffset closedSegmentOccupationOffset)
		{
			builder.AddOffset(7, closedSegmentOccupationOffset.Value, 0);
		}

		// Token: 0x0601B4B9 RID: 111801 RVA: 0x003DDF10 File Offset: 0x003DC110
		public static void AddClosedSegments(FlatBufferBuilder builder, VectorOffset closedSegmentsOffset)
		{
			builder.AddOffset(8, closedSegmentsOffset.Value, 0);
		}

		// Token: 0x0601B4BA RID: 111802 RVA: 0x003DDF20 File Offset: 0x003DC120
		public static VectorOffset CreateClosedSegmentsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x003DDF60 File Offset: 0x003DC160
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x003DDF7A File Offset: 0x003DC17A
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4BD RID: 111805 RVA: 0x003DDF98 File Offset: 0x003DC198
		public static VectorOffset CreateClosedSegmentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4BE RID: 111806 RVA: 0x003DDFB1 File Offset: 0x003DC1B1
		public static void StartClosedSegmentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4BF RID: 111807 RVA: 0x003DDFBC File Offset: 0x003DC1BC
		public static void AddSeasonRotation(FlatBufferBuilder builder, VectorOffset seasonRotationOffset)
		{
			builder.AddOffset(9, seasonRotationOffset.Value, 0);
		}

		// Token: 0x0601B4C0 RID: 111808 RVA: 0x003DDFD0 File Offset: 0x003DC1D0
		public static VectorOffset CreateSeasonRotationVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B4C1 RID: 111809 RVA: 0x003DE010 File Offset: 0x003DC210
		public static VectorOffset CreateSeasonRotationVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4C2 RID: 111810 RVA: 0x003DE02A File Offset: 0x003DC22A
		public static VectorOffset CreateSeasonRotationVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B4C3 RID: 111811 RVA: 0x003DE048 File Offset: 0x003DC248
		public static VectorOffset CreateSeasonRotationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B4C4 RID: 111812 RVA: 0x003DE061 File Offset: 0x003DC261
		public static void StartSeasonRotationVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B4C5 RID: 111813 RVA: 0x003DE06C File Offset: 0x003DC26C
		public static Offset<IOccupationData> EndIOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B4C6 RID: 111814 RVA: 0x003DE07C File Offset: 0x003DC27C
		public IOccupationDataT UnPack()
		{
			IOccupationDataT occupationDataT = new IOccupationDataT();
			this.UnPackTo(occupationDataT);
			return occupationDataT;
		}

		// Token: 0x0601B4C7 RID: 111815 RVA: 0x003DE098 File Offset: 0x003DC298
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
			_o.SeasonRotation = new List<string>();
			for (int num = 0; num < this.SeasonRotationLength; num++)
			{
				_o.SeasonRotation.Add(this.SeasonRotation(num));
			}
		}

		// Token: 0x0601B4C8 RID: 111816 RVA: 0x003DE298 File Offset: 0x003DC498
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
			VectorOffset seasonRotationOffset = default(VectorOffset);
			if (_o.SeasonRotation != null)
			{
				StringOffset[] array7 = new StringOffset[_o.SeasonRotation.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = builder.CreateString(_o.SeasonRotation[num]);
				}
				seasonRotationOffset = IOccupationData.CreateSeasonRotationVector(builder, array7);
			}
			return IOccupationData.CreateIOccupationData(builder, npcOffset, npcConfigOffset, areaOffset, areaConfigOffset, silentAreaOffset, screenResourceOffset, timeOccupationOffset, closedSegmentOccupationOffset, closedSegmentsOffset, seasonRotationOffset);
		}

		// Token: 0x0400CC07 RID: 52231
		private Table __p;
	}
}
