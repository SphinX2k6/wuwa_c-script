using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004226 RID: 16934
	public struct IDungeonSubTypeCondition : IFlatbufferObject
	{
		// Token: 0x1700735E RID: 29534
		// (get) Token: 0x06017884 RID: 96388 RVA: 0x0035BE64 File Offset: 0x0035A064
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017885 RID: 96389 RVA: 0x0035BE71 File Offset: 0x0035A071
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017886 RID: 96390 RVA: 0x0035BE78 File Offset: 0x0035A078
		public static IDungeonSubTypeCondition GetRootAsIDungeonSubTypeCondition(ByteBuffer _bb)
		{
			return IDungeonSubTypeCondition.GetRootAsIDungeonSubTypeCondition(_bb, default(IDungeonSubTypeCondition));
		}

		// Token: 0x06017887 RID: 96391 RVA: 0x0035BE94 File Offset: 0x0035A094
		public static IDungeonSubTypeCondition GetRootAsIDungeonSubTypeCondition(ByteBuffer _bb, IDungeonSubTypeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017888 RID: 96392 RVA: 0x0035BEB1 File Offset: 0x0035A0B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017889 RID: 96393 RVA: 0x0035BEC0 File Offset: 0x0035A0C0
		public IDungeonSubTypeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700735F RID: 29535
		// (get) Token: 0x0601788A RID: 96394 RVA: 0x0035BED0 File Offset: 0x0035A0D0
		public EDungeonConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return (EDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007360 RID: 29536
		// (get) Token: 0x0601788B RID: 96395 RVA: 0x0035BF0C File Offset: 0x0035A10C
		public int Count
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

		// Token: 0x17007361 RID: 29537
		// (get) Token: 0x0601788C RID: 96396 RVA: 0x0035BF48 File Offset: 0x0035A148
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007362 RID: 29538
		// (get) Token: 0x0601788D RID: 96397 RVA: 0x0035BF88 File Offset: 0x0035A188
		public EDungeonSubType DungeonSubType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDungeonSubType.Test;
				}
				return (EDungeonSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007363 RID: 29539
		// (get) Token: 0x0601788E RID: 96398 RVA: 0x0035BFC8 File Offset: 0x0035A1C8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601788F RID: 96399 RVA: 0x0035C005 File Offset: 0x0035A205
		public static Offset<IDungeonSubTypeCondition> CreateIDungeonSubTypeCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int Count = 0, bool IsExitDungeon = false, EDungeonSubType DungeonSubType = EDungeonSubType.Test, byte NullMask = 0)
		{
			builder.StartTable(5);
			IDungeonSubTypeCondition.AddCount(builder, Count);
			IDungeonSubTypeCondition.AddNullMask(builder, NullMask);
			IDungeonSubTypeCondition.AddDungeonSubType(builder, DungeonSubType);
			IDungeonSubTypeCondition.AddIsExitDungeon(builder, IsExitDungeon);
			IDungeonSubTypeCondition.AddType(builder, Type);
			return IDungeonSubTypeCondition.EndIDungeonSubTypeCondition(builder);
		}

		// Token: 0x06017890 RID: 96400 RVA: 0x0035C039 File Offset: 0x0035A239
		public static void StartIDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017891 RID: 96401 RVA: 0x0035C042 File Offset: 0x0035A242
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017892 RID: 96402 RVA: 0x0035C04D File Offset: 0x0035A24D
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06017893 RID: 96403 RVA: 0x0035C058 File Offset: 0x0035A258
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06017894 RID: 96404 RVA: 0x0035C063 File Offset: 0x0035A263
		public static void AddDungeonSubType(FlatBufferBuilder builder, EDungeonSubType dungeonSubType)
		{
			builder.AddByte(3, (byte)dungeonSubType, 0);
		}

		// Token: 0x06017895 RID: 96405 RVA: 0x0035C06E File Offset: 0x0035A26E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017896 RID: 96406 RVA: 0x0035C079 File Offset: 0x0035A279
		public static Offset<IDungeonSubTypeCondition> EndIDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonSubTypeCondition>(builder.EndTable());
		}

		// Token: 0x06017897 RID: 96407 RVA: 0x0035C088 File Offset: 0x0035A288
		public IDungeonSubTypeConditionT UnPack()
		{
			IDungeonSubTypeConditionT dungeonSubTypeConditionT = new IDungeonSubTypeConditionT();
			this.UnPackTo(dungeonSubTypeConditionT);
			return dungeonSubTypeConditionT;
		}

		// Token: 0x06017898 RID: 96408 RVA: 0x0035C0A3 File Offset: 0x0035A2A3
		public void UnPackTo(IDungeonSubTypeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.DungeonSubType = this.DungeonSubType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017899 RID: 96409 RVA: 0x0035C0E4 File Offset: 0x0035A2E4
		public static Offset<IDungeonSubTypeCondition> Pack(FlatBufferBuilder builder, IDungeonSubTypeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonSubTypeCondition>);
			}
			return IDungeonSubTypeCondition.CreateIDungeonSubTypeCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.DungeonSubType, _o.NullMask);
		}

		// Token: 0x0400C111 RID: 49425
		private Table __p;
	}
}
