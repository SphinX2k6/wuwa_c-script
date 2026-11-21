using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F1 RID: 18417
	public struct IAreaOccupationData : IFlatbufferObject
	{
		// Token: 0x17008074 RID: 32884
		// (get) Token: 0x0601B33F RID: 111423 RVA: 0x003DAF27 File Offset: 0x003D9127
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B340 RID: 111424 RVA: 0x003DAF34 File Offset: 0x003D9134
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B341 RID: 111425 RVA: 0x003DAF3C File Offset: 0x003D913C
		public static IAreaOccupationData GetRootAsIAreaOccupationData(ByteBuffer _bb)
		{
			return IAreaOccupationData.GetRootAsIAreaOccupationData(_bb, default(IAreaOccupationData));
		}

		// Token: 0x0601B342 RID: 111426 RVA: 0x003DAF58 File Offset: 0x003D9158
		public static IAreaOccupationData GetRootAsIAreaOccupationData(ByteBuffer _bb, IAreaOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B343 RID: 111427 RVA: 0x003DAF75 File Offset: 0x003D9175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B344 RID: 111428 RVA: 0x003DAF84 File Offset: 0x003D9184
		public IAreaOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008075 RID: 32885
		// (get) Token: 0x0601B345 RID: 111429 RVA: 0x003DAF94 File Offset: 0x003D9194
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008076 RID: 32886
		// (get) Token: 0x0601B346 RID: 111430 RVA: 0x003DAFD0 File Offset: 0x003D91D0
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008077 RID: 32887
		// (get) Token: 0x0601B347 RID: 111431 RVA: 0x003DB00C File Offset: 0x003D920C
		public int IdentifyEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B348 RID: 111432 RVA: 0x003DB048 File Offset: 0x003D9248
		public static Offset<IAreaOccupationData> CreateIAreaOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc, int LevelId = 0, int IdentifyEntityId = 0)
		{
			builder.StartTable(3);
			IAreaOccupationData.AddIdentifyEntityId(builder, IdentifyEntityId);
			IAreaOccupationData.AddLevelId(builder, LevelId);
			IAreaOccupationData.AddType(builder, Type);
			return IAreaOccupationData.EndIAreaOccupationData(builder);
		}

		// Token: 0x0601B349 RID: 111433 RVA: 0x003DB06C File Offset: 0x003D926C
		public static void StartIAreaOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B34A RID: 111434 RVA: 0x003DB075 File Offset: 0x003D9275
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B34B RID: 111435 RVA: 0x003DB080 File Offset: 0x003D9280
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601B34C RID: 111436 RVA: 0x003DB08B File Offset: 0x003D928B
		public static void AddIdentifyEntityId(FlatBufferBuilder builder, int identifyEntityId)
		{
			builder.AddInt(2, identifyEntityId, 0);
		}

		// Token: 0x0601B34D RID: 111437 RVA: 0x003DB096 File Offset: 0x003D9296
		public static Offset<IAreaOccupationData> EndIAreaOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IAreaOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B34E RID: 111438 RVA: 0x003DB0A4 File Offset: 0x003D92A4
		public IAreaOccupationDataT UnPack()
		{
			IAreaOccupationDataT areaOccupationDataT = new IAreaOccupationDataT();
			this.UnPackTo(areaOccupationDataT);
			return areaOccupationDataT;
		}

		// Token: 0x0601B34F RID: 111439 RVA: 0x003DB0BF File Offset: 0x003D92BF
		public void UnPackTo(IAreaOccupationDataT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.IdentifyEntityId = this.IdentifyEntityId;
		}

		// Token: 0x0601B350 RID: 111440 RVA: 0x003DB0E8 File Offset: 0x003D92E8
		public static Offset<IAreaOccupationData> Pack(FlatBufferBuilder builder, IAreaOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaOccupationData>);
			}
			return IAreaOccupationData.CreateIAreaOccupationData(builder, _o.Type, _o.LevelId, _o.IdentifyEntityId);
		}

		// Token: 0x0400CBE1 RID: 52193
		private Table __p;
	}
}
