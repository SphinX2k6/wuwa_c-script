using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440C RID: 17420
	public struct IQuestBuffActiveRange : IFlatbufferObject
	{
		// Token: 0x17007863 RID: 30819
		// (get) Token: 0x06018D5A RID: 101722 RVA: 0x0038AACB File Offset: 0x00388CCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D5B RID: 101723 RVA: 0x0038AAD8 File Offset: 0x00388CD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D5C RID: 101724 RVA: 0x0038AAE0 File Offset: 0x00388CE0
		public static IQuestBuffActiveRange GetRootAsIQuestBuffActiveRange(ByteBuffer _bb)
		{
			return IQuestBuffActiveRange.GetRootAsIQuestBuffActiveRange(_bb, default(IQuestBuffActiveRange));
		}

		// Token: 0x06018D5D RID: 101725 RVA: 0x0038AAFC File Offset: 0x00388CFC
		public static IQuestBuffActiveRange GetRootAsIQuestBuffActiveRange(ByteBuffer _bb, IQuestBuffActiveRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D5E RID: 101726 RVA: 0x0038AB19 File Offset: 0x00388D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D5F RID: 101727 RVA: 0x0038AB28 File Offset: 0x00388D28
		public IQuestBuffActiveRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007864 RID: 30820
		// (get) Token: 0x06018D60 RID: 101728 RVA: 0x0038AB38 File Offset: 0x00388D38
		public IQuestBuffActiveCenterRange? QuestBuffActiveCenterRange
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IQuestBuffActiveCenterRange?(default(IQuestBuffActiveCenterRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018D61 RID: 101729 RVA: 0x0038AB98 File Offset: 0x00388D98
		public int QuestBuffActiveRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007865 RID: 30821
		// (get) Token: 0x06018D62 RID: 101730 RVA: 0x0038ABD8 File Offset: 0x00388DD8
		public int QuestBuffActiveRangeEntitiesLength
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

		// Token: 0x06018D63 RID: 101731 RVA: 0x0038AC03 File Offset: 0x00388E03
		public Span<int> GetQuestBuffActiveRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018D64 RID: 101732 RVA: 0x0038AC12 File Offset: 0x00388E12
		public int[] GetQuestBuffActiveRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018D65 RID: 101733 RVA: 0x0038AC20 File Offset: 0x00388E20
		public int QuestBuffActiveRangeAreaIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007866 RID: 30822
		// (get) Token: 0x06018D66 RID: 101734 RVA: 0x0038AC60 File Offset: 0x00388E60
		public int QuestBuffActiveRangeAreaIdsLength
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

		// Token: 0x06018D67 RID: 101735 RVA: 0x0038AC8B File Offset: 0x00388E8B
		public Span<int> GetQuestBuffActiveRangeAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06018D68 RID: 101736 RVA: 0x0038AC9A File Offset: 0x00388E9A
		public int[] GetQuestBuffActiveRangeAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007867 RID: 30823
		// (get) Token: 0x06018D69 RID: 101737 RVA: 0x0038ACA8 File Offset: 0x00388EA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018D6A RID: 101738 RVA: 0x0038ACE5 File Offset: 0x00388EE5
		public static Offset<IQuestBuffActiveRange> CreateIQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveCenterRange> QuestBuffActiveCenterRangeOffset = default(Offset<IQuestBuffActiveCenterRange>), VectorOffset QuestBuffActiveRangeEntitiesOffset = default(VectorOffset), VectorOffset QuestBuffActiveRangeAreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestBuffActiveRange.AddQuestBuffActiveRangeAreaIds(builder, QuestBuffActiveRangeAreaIdsOffset);
			IQuestBuffActiveRange.AddQuestBuffActiveRangeEntities(builder, QuestBuffActiveRangeEntitiesOffset);
			IQuestBuffActiveRange.AddQuestBuffActiveCenterRange(builder, QuestBuffActiveCenterRangeOffset);
			IQuestBuffActiveRange.AddNullMask(builder, NullMask);
			return IQuestBuffActiveRange.EndIQuestBuffActiveRange(builder);
		}

		// Token: 0x06018D6B RID: 101739 RVA: 0x0038AD11 File Offset: 0x00388F11
		public static void StartIQuestBuffActiveRange(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018D6C RID: 101740 RVA: 0x0038AD1A File Offset: 0x00388F1A
		public static void AddQuestBuffActiveCenterRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveCenterRange> questBuffActiveCenterRangeOffset)
		{
			builder.AddOffset(0, questBuffActiveCenterRangeOffset.Value, 0);
		}

		// Token: 0x06018D6D RID: 101741 RVA: 0x0038AD2A File Offset: 0x00388F2A
		public static void AddQuestBuffActiveRangeEntities(FlatBufferBuilder builder, VectorOffset questBuffActiveRangeEntitiesOffset)
		{
			builder.AddOffset(1, questBuffActiveRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06018D6E RID: 101742 RVA: 0x0038AD3C File Offset: 0x00388F3C
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018D6F RID: 101743 RVA: 0x0038AD73 File Offset: 0x00388F73
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018D70 RID: 101744 RVA: 0x0038AD8D File Offset: 0x00388F8D
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018D71 RID: 101745 RVA: 0x0038ADAB File Offset: 0x00388FAB
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018D72 RID: 101746 RVA: 0x0038ADC4 File Offset: 0x00388FC4
		public static void StartQuestBuffActiveRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018D73 RID: 101747 RVA: 0x0038ADCF File Offset: 0x00388FCF
		public static void AddQuestBuffActiveRangeAreaIds(FlatBufferBuilder builder, VectorOffset questBuffActiveRangeAreaIdsOffset)
		{
			builder.AddOffset(2, questBuffActiveRangeAreaIdsOffset.Value, 0);
		}

		// Token: 0x06018D74 RID: 101748 RVA: 0x0038ADE0 File Offset: 0x00388FE0
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018D75 RID: 101749 RVA: 0x0038AE17 File Offset: 0x00389017
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018D76 RID: 101750 RVA: 0x0038AE31 File Offset: 0x00389031
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018D77 RID: 101751 RVA: 0x0038AE4F File Offset: 0x0038904F
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018D78 RID: 101752 RVA: 0x0038AE68 File Offset: 0x00389068
		public static void StartQuestBuffActiveRangeAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018D79 RID: 101753 RVA: 0x0038AE73 File Offset: 0x00389073
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018D7A RID: 101754 RVA: 0x0038AE7E File Offset: 0x0038907E
		public static Offset<IQuestBuffActiveRange> EndIQuestBuffActiveRange(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBuffActiveRange>(builder.EndTable());
		}

		// Token: 0x06018D7B RID: 101755 RVA: 0x0038AE8C File Offset: 0x0038908C
		public IQuestBuffActiveRangeT UnPack()
		{
			IQuestBuffActiveRangeT questBuffActiveRangeT = new IQuestBuffActiveRangeT();
			this.UnPackTo(questBuffActiveRangeT);
			return questBuffActiveRangeT;
		}

		// Token: 0x06018D7C RID: 101756 RVA: 0x0038AEA8 File Offset: 0x003890A8
		public void UnPackTo(IQuestBuffActiveRangeT _o)
		{
			_o.QuestBuffActiveCenterRange = ((this.QuestBuffActiveCenterRange != null) ? this.QuestBuffActiveCenterRange.Value.UnPack() : null);
			_o.QuestBuffActiveRangeEntities = new List<int>();
			for (int i = 0; i < this.QuestBuffActiveRangeEntitiesLength; i++)
			{
				_o.QuestBuffActiveRangeEntities.Add(this.QuestBuffActiveRangeEntities(i));
			}
			_o.QuestBuffActiveRangeAreaIds = new List<int>();
			for (int j = 0; j < this.QuestBuffActiveRangeAreaIdsLength; j++)
			{
				_o.QuestBuffActiveRangeAreaIds.Add(this.QuestBuffActiveRangeAreaIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018D7D RID: 101757 RVA: 0x0038AF4C File Offset: 0x0038914C
		public static Offset<IQuestBuffActiveRange> Pack(FlatBufferBuilder builder, IQuestBuffActiveRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBuffActiveRange>);
			}
			Offset<IQuestBuffActiveCenterRange> questBuffActiveCenterRangeOffset = (_o.QuestBuffActiveCenterRange == null) ? default(Offset<IQuestBuffActiveCenterRange>) : IQuestBuffActiveCenterRange.Pack(builder, _o.QuestBuffActiveCenterRange);
			VectorOffset questBuffActiveRangeEntitiesOffset = default(VectorOffset);
			if (_o.QuestBuffActiveRangeEntities != null)
			{
				int[] data = _o.QuestBuffActiveRangeEntities.ToArray();
				questBuffActiveRangeEntitiesOffset = IQuestBuffActiveRange.CreateQuestBuffActiveRangeEntitiesVector(builder, data);
			}
			VectorOffset questBuffActiveRangeAreaIdsOffset = default(VectorOffset);
			if (_o.QuestBuffActiveRangeAreaIds != null)
			{
				int[] data2 = _o.QuestBuffActiveRangeAreaIds.ToArray();
				questBuffActiveRangeAreaIdsOffset = IQuestBuffActiveRange.CreateQuestBuffActiveRangeAreaIdsVector(builder, data2);
			}
			return IQuestBuffActiveRange.CreateIQuestBuffActiveRange(builder, questBuffActiveCenterRangeOffset, questBuffActiveRangeEntitiesOffset, questBuffActiveRangeAreaIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C44F RID: 50255
		private Table __p;
	}
}
