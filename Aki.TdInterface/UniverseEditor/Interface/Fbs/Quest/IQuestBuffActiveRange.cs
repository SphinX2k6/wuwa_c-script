using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCB RID: 16331
	public struct IQuestBuffActiveRange : IFlatbufferObject
	{
		// Token: 0x17007263 RID: 29283
		// (get) Token: 0x060176C7 RID: 95943 RVA: 0x00360DA3 File Offset: 0x0035EFA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176C8 RID: 95944 RVA: 0x00360DB0 File Offset: 0x0035EFB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x00360DB8 File Offset: 0x0035EFB8
		public static IQuestBuffActiveRange GetRootAsIQuestBuffActiveRange(ByteBuffer _bb)
		{
			return IQuestBuffActiveRange.GetRootAsIQuestBuffActiveRange(_bb, default(IQuestBuffActiveRange));
		}

		// Token: 0x060176CA RID: 95946 RVA: 0x00360DD4 File Offset: 0x0035EFD4
		public static IQuestBuffActiveRange GetRootAsIQuestBuffActiveRange(ByteBuffer _bb, IQuestBuffActiveRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176CB RID: 95947 RVA: 0x00360DF1 File Offset: 0x0035EFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176CC RID: 95948 RVA: 0x00360E00 File Offset: 0x0035F000
		public IQuestBuffActiveRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007264 RID: 29284
		// (get) Token: 0x060176CD RID: 95949 RVA: 0x00360E10 File Offset: 0x0035F010
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

		// Token: 0x060176CE RID: 95950 RVA: 0x00360E70 File Offset: 0x0035F070
		public int QuestBuffActiveRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007265 RID: 29285
		// (get) Token: 0x060176CF RID: 95951 RVA: 0x00360EB0 File Offset: 0x0035F0B0
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

		// Token: 0x060176D0 RID: 95952 RVA: 0x00360EDB File Offset: 0x0035F0DB
		public Span<int> GetQuestBuffActiveRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060176D1 RID: 95953 RVA: 0x00360EEA File Offset: 0x0035F0EA
		public int[] GetQuestBuffActiveRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060176D2 RID: 95954 RVA: 0x00360EF8 File Offset: 0x0035F0F8
		public int QuestBuffActiveRangeAreaIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007266 RID: 29286
		// (get) Token: 0x060176D3 RID: 95955 RVA: 0x00360F38 File Offset: 0x0035F138
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

		// Token: 0x060176D4 RID: 95956 RVA: 0x00360F63 File Offset: 0x0035F163
		public Span<int> GetQuestBuffActiveRangeAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060176D5 RID: 95957 RVA: 0x00360F72 File Offset: 0x0035F172
		public int[] GetQuestBuffActiveRangeAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007267 RID: 29287
		// (get) Token: 0x060176D6 RID: 95958 RVA: 0x00360F80 File Offset: 0x0035F180
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

		// Token: 0x060176D7 RID: 95959 RVA: 0x00360FBD File Offset: 0x0035F1BD
		public static Offset<IQuestBuffActiveRange> CreateIQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveCenterRange> QuestBuffActiveCenterRangeOffset = default(Offset<IQuestBuffActiveCenterRange>), VectorOffset QuestBuffActiveRangeEntitiesOffset = default(VectorOffset), VectorOffset QuestBuffActiveRangeAreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestBuffActiveRange.AddQuestBuffActiveRangeAreaIds(builder, QuestBuffActiveRangeAreaIdsOffset);
			IQuestBuffActiveRange.AddQuestBuffActiveRangeEntities(builder, QuestBuffActiveRangeEntitiesOffset);
			IQuestBuffActiveRange.AddQuestBuffActiveCenterRange(builder, QuestBuffActiveCenterRangeOffset);
			IQuestBuffActiveRange.AddNullMask(builder, NullMask);
			return IQuestBuffActiveRange.EndIQuestBuffActiveRange(builder);
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x00360FE9 File Offset: 0x0035F1E9
		public static void StartIQuestBuffActiveRange(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060176D9 RID: 95961 RVA: 0x00360FF2 File Offset: 0x0035F1F2
		public static void AddQuestBuffActiveCenterRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveCenterRange> questBuffActiveCenterRangeOffset)
		{
			builder.AddOffset(0, questBuffActiveCenterRangeOffset.Value, 0);
		}

		// Token: 0x060176DA RID: 95962 RVA: 0x00361002 File Offset: 0x0035F202
		public static void AddQuestBuffActiveRangeEntities(FlatBufferBuilder builder, VectorOffset questBuffActiveRangeEntitiesOffset)
		{
			builder.AddOffset(1, questBuffActiveRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x00361014 File Offset: 0x0035F214
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060176DC RID: 95964 RVA: 0x0036104B File Offset: 0x0035F24B
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060176DD RID: 95965 RVA: 0x00361065 File Offset: 0x0035F265
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060176DE RID: 95966 RVA: 0x00361083 File Offset: 0x0035F283
		public static VectorOffset CreateQuestBuffActiveRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060176DF RID: 95967 RVA: 0x0036109C File Offset: 0x0035F29C
		public static void StartQuestBuffActiveRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060176E0 RID: 95968 RVA: 0x003610A7 File Offset: 0x0035F2A7
		public static void AddQuestBuffActiveRangeAreaIds(FlatBufferBuilder builder, VectorOffset questBuffActiveRangeAreaIdsOffset)
		{
			builder.AddOffset(2, questBuffActiveRangeAreaIdsOffset.Value, 0);
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x003610B8 File Offset: 0x0035F2B8
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060176E2 RID: 95970 RVA: 0x003610EF File Offset: 0x0035F2EF
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060176E3 RID: 95971 RVA: 0x00361109 File Offset: 0x0035F309
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060176E4 RID: 95972 RVA: 0x00361127 File Offset: 0x0035F327
		public static VectorOffset CreateQuestBuffActiveRangeAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060176E5 RID: 95973 RVA: 0x00361140 File Offset: 0x0035F340
		public static void StartQuestBuffActiveRangeAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060176E6 RID: 95974 RVA: 0x0036114B File Offset: 0x0035F34B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060176E7 RID: 95975 RVA: 0x00361156 File Offset: 0x0035F356
		public static Offset<IQuestBuffActiveRange> EndIQuestBuffActiveRange(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBuffActiveRange>(builder.EndTable());
		}

		// Token: 0x060176E8 RID: 95976 RVA: 0x00361164 File Offset: 0x0035F364
		public IQuestBuffActiveRangeT UnPack()
		{
			IQuestBuffActiveRangeT questBuffActiveRangeT = new IQuestBuffActiveRangeT();
			this.UnPackTo(questBuffActiveRangeT);
			return questBuffActiveRangeT;
		}

		// Token: 0x060176E9 RID: 95977 RVA: 0x00361180 File Offset: 0x0035F380
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

		// Token: 0x060176EA RID: 95978 RVA: 0x00361224 File Offset: 0x0035F424
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

		// Token: 0x0400BA69 RID: 47721
		private Table __p;
	}
}
