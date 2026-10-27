using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200438F RID: 17295
	public struct IAreaOccupationData : IFlatbufferObject
	{
		// Token: 0x17007A3F RID: 31295
		// (get) Token: 0x06019BB1 RID: 105393 RVA: 0x003AF4FF File Offset: 0x003AD6FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019BB2 RID: 105394 RVA: 0x003AF50C File Offset: 0x003AD70C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019BB3 RID: 105395 RVA: 0x003AF514 File Offset: 0x003AD714
		public static IAreaOccupationData GetRootAsIAreaOccupationData(ByteBuffer _bb)
		{
			return IAreaOccupationData.GetRootAsIAreaOccupationData(_bb, default(IAreaOccupationData));
		}

		// Token: 0x06019BB4 RID: 105396 RVA: 0x003AF530 File Offset: 0x003AD730
		public static IAreaOccupationData GetRootAsIAreaOccupationData(ByteBuffer _bb, IAreaOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019BB5 RID: 105397 RVA: 0x003AF54D File Offset: 0x003AD74D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019BB6 RID: 105398 RVA: 0x003AF55C File Offset: 0x003AD75C
		public IAreaOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A40 RID: 31296
		// (get) Token: 0x06019BB7 RID: 105399 RVA: 0x003AF56C File Offset: 0x003AD76C
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

		// Token: 0x17007A41 RID: 31297
		// (get) Token: 0x06019BB8 RID: 105400 RVA: 0x003AF5A8 File Offset: 0x003AD7A8
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

		// Token: 0x17007A42 RID: 31298
		// (get) Token: 0x06019BB9 RID: 105401 RVA: 0x003AF5E4 File Offset: 0x003AD7E4
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

		// Token: 0x06019BBA RID: 105402 RVA: 0x003AF620 File Offset: 0x003AD820
		public static Offset<IAreaOccupationData> CreateIAreaOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc, int LevelId = 0, int IdentifyEntityId = 0)
		{
			builder.StartTable(3);
			IAreaOccupationData.AddIdentifyEntityId(builder, IdentifyEntityId);
			IAreaOccupationData.AddLevelId(builder, LevelId);
			IAreaOccupationData.AddType(builder, Type);
			return IAreaOccupationData.EndIAreaOccupationData(builder);
		}

		// Token: 0x06019BBB RID: 105403 RVA: 0x003AF644 File Offset: 0x003AD844
		public static void StartIAreaOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019BBC RID: 105404 RVA: 0x003AF64D File Offset: 0x003AD84D
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019BBD RID: 105405 RVA: 0x003AF658 File Offset: 0x003AD858
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x06019BBE RID: 105406 RVA: 0x003AF663 File Offset: 0x003AD863
		public static void AddIdentifyEntityId(FlatBufferBuilder builder, int identifyEntityId)
		{
			builder.AddInt(2, identifyEntityId, 0);
		}

		// Token: 0x06019BBF RID: 105407 RVA: 0x003AF66E File Offset: 0x003AD86E
		public static Offset<IAreaOccupationData> EndIAreaOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IAreaOccupationData>(builder.EndTable());
		}

		// Token: 0x06019BC0 RID: 105408 RVA: 0x003AF67C File Offset: 0x003AD87C
		public IAreaOccupationDataT UnPack()
		{
			IAreaOccupationDataT areaOccupationDataT = new IAreaOccupationDataT();
			this.UnPackTo(areaOccupationDataT);
			return areaOccupationDataT;
		}

		// Token: 0x06019BC1 RID: 105409 RVA: 0x003AF697 File Offset: 0x003AD897
		public void UnPackTo(IAreaOccupationDataT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.IdentifyEntityId = this.IdentifyEntityId;
		}

		// Token: 0x06019BC2 RID: 105410 RVA: 0x003AF6C0 File Offset: 0x003AD8C0
		public static Offset<IAreaOccupationData> Pack(FlatBufferBuilder builder, IAreaOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaOccupationData>);
			}
			return IAreaOccupationData.CreateIAreaOccupationData(builder, _o.Type, _o.LevelId, _o.IdentifyEntityId);
		}

		// Token: 0x0400C1C2 RID: 49602
		private Table __p;
	}
}
