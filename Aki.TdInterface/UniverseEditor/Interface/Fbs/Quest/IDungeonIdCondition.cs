using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE8 RID: 15848
	public struct IDungeonIdCondition : IFlatbufferObject
	{
		// Token: 0x17006D73 RID: 28019
		// (get) Token: 0x06016243 RID: 90691 RVA: 0x003330B4 File Offset: 0x003312B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016244 RID: 90692 RVA: 0x003330C1 File Offset: 0x003312C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016245 RID: 90693 RVA: 0x003330C8 File Offset: 0x003312C8
		public static IDungeonIdCondition GetRootAsIDungeonIdCondition(ByteBuffer _bb)
		{
			return IDungeonIdCondition.GetRootAsIDungeonIdCondition(_bb, default(IDungeonIdCondition));
		}

		// Token: 0x06016246 RID: 90694 RVA: 0x003330E4 File Offset: 0x003312E4
		public static IDungeonIdCondition GetRootAsIDungeonIdCondition(ByteBuffer _bb, IDungeonIdCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016247 RID: 90695 RVA: 0x00333101 File Offset: 0x00331301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016248 RID: 90696 RVA: 0x00333110 File Offset: 0x00331310
		public IDungeonIdCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D74 RID: 28020
		// (get) Token: 0x06016249 RID: 90697 RVA: 0x00333120 File Offset: 0x00331320
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

		// Token: 0x17006D75 RID: 28021
		// (get) Token: 0x0601624A RID: 90698 RVA: 0x0033315C File Offset: 0x0033135C
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

		// Token: 0x17006D76 RID: 28022
		// (get) Token: 0x0601624B RID: 90699 RVA: 0x00333198 File Offset: 0x00331398
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D77 RID: 28023
		// (get) Token: 0x0601624C RID: 90700 RVA: 0x003331D8 File Offset: 0x003313D8
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D78 RID: 28024
		// (get) Token: 0x0601624D RID: 90701 RVA: 0x00333218 File Offset: 0x00331418
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

		// Token: 0x0601624E RID: 90702 RVA: 0x00333255 File Offset: 0x00331455
		public static Offset<IDungeonIdCondition> CreateIDungeonIdCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int Count = 0, bool IsExitDungeon = false, int DungeonId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IDungeonIdCondition.AddDungeonId(builder, DungeonId);
			IDungeonIdCondition.AddCount(builder, Count);
			IDungeonIdCondition.AddNullMask(builder, NullMask);
			IDungeonIdCondition.AddIsExitDungeon(builder, IsExitDungeon);
			IDungeonIdCondition.AddType(builder, Type);
			return IDungeonIdCondition.EndIDungeonIdCondition(builder);
		}

		// Token: 0x0601624F RID: 90703 RVA: 0x00333289 File Offset: 0x00331489
		public static void StartIDungeonIdCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016250 RID: 90704 RVA: 0x00333292 File Offset: 0x00331492
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016251 RID: 90705 RVA: 0x0033329D File Offset: 0x0033149D
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06016252 RID: 90706 RVA: 0x003332A8 File Offset: 0x003314A8
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06016253 RID: 90707 RVA: 0x003332B3 File Offset: 0x003314B3
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(3, dungeonId, 0);
		}

		// Token: 0x06016254 RID: 90708 RVA: 0x003332BE File Offset: 0x003314BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016255 RID: 90709 RVA: 0x003332C9 File Offset: 0x003314C9
		public static Offset<IDungeonIdCondition> EndIDungeonIdCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonIdCondition>(builder.EndTable());
		}

		// Token: 0x06016256 RID: 90710 RVA: 0x003332D8 File Offset: 0x003314D8
		public IDungeonIdConditionT UnPack()
		{
			IDungeonIdConditionT dungeonIdConditionT = new IDungeonIdConditionT();
			this.UnPackTo(dungeonIdConditionT);
			return dungeonIdConditionT;
		}

		// Token: 0x06016257 RID: 90711 RVA: 0x003332F3 File Offset: 0x003314F3
		public void UnPackTo(IDungeonIdConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.DungeonId = this.DungeonId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016258 RID: 90712 RVA: 0x00333334 File Offset: 0x00331534
		public static Offset<IDungeonIdCondition> Pack(FlatBufferBuilder builder, IDungeonIdConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonIdCondition>);
			}
			return IDungeonIdCondition.CreateIDungeonIdCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.DungeonId, _o.NullMask);
		}

		// Token: 0x0400B737 RID: 46903
		private Table __p;
	}
}
