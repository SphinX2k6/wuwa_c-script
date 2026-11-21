using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004223 RID: 16931
	public struct IDungeonIdCondition : IFlatbufferObject
	{
		// Token: 0x17007353 RID: 29523
		// (get) Token: 0x06017862 RID: 96354 RVA: 0x0035BAB8 File Offset: 0x00359CB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017863 RID: 96355 RVA: 0x0035BAC5 File Offset: 0x00359CC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017864 RID: 96356 RVA: 0x0035BACC File Offset: 0x00359CCC
		public static IDungeonIdCondition GetRootAsIDungeonIdCondition(ByteBuffer _bb)
		{
			return IDungeonIdCondition.GetRootAsIDungeonIdCondition(_bb, default(IDungeonIdCondition));
		}

		// Token: 0x06017865 RID: 96357 RVA: 0x0035BAE8 File Offset: 0x00359CE8
		public static IDungeonIdCondition GetRootAsIDungeonIdCondition(ByteBuffer _bb, IDungeonIdCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017866 RID: 96358 RVA: 0x0035BB05 File Offset: 0x00359D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017867 RID: 96359 RVA: 0x0035BB14 File Offset: 0x00359D14
		public IDungeonIdCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007354 RID: 29524
		// (get) Token: 0x06017868 RID: 96360 RVA: 0x0035BB24 File Offset: 0x00359D24
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

		// Token: 0x17007355 RID: 29525
		// (get) Token: 0x06017869 RID: 96361 RVA: 0x0035BB60 File Offset: 0x00359D60
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

		// Token: 0x17007356 RID: 29526
		// (get) Token: 0x0601786A RID: 96362 RVA: 0x0035BB9C File Offset: 0x00359D9C
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007357 RID: 29527
		// (get) Token: 0x0601786B RID: 96363 RVA: 0x0035BBDC File Offset: 0x00359DDC
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

		// Token: 0x17007358 RID: 29528
		// (get) Token: 0x0601786C RID: 96364 RVA: 0x0035BC1C File Offset: 0x00359E1C
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

		// Token: 0x0601786D RID: 96365 RVA: 0x0035BC59 File Offset: 0x00359E59
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

		// Token: 0x0601786E RID: 96366 RVA: 0x0035BC8D File Offset: 0x00359E8D
		public static void StartIDungeonIdCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601786F RID: 96367 RVA: 0x0035BC96 File Offset: 0x00359E96
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017870 RID: 96368 RVA: 0x0035BCA1 File Offset: 0x00359EA1
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06017871 RID: 96369 RVA: 0x0035BCAC File Offset: 0x00359EAC
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06017872 RID: 96370 RVA: 0x0035BCB7 File Offset: 0x00359EB7
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(3, dungeonId, 0);
		}

		// Token: 0x06017873 RID: 96371 RVA: 0x0035BCC2 File Offset: 0x00359EC2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017874 RID: 96372 RVA: 0x0035BCCD File Offset: 0x00359ECD
		public static Offset<IDungeonIdCondition> EndIDungeonIdCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonIdCondition>(builder.EndTable());
		}

		// Token: 0x06017875 RID: 96373 RVA: 0x0035BCDC File Offset: 0x00359EDC
		public IDungeonIdConditionT UnPack()
		{
			IDungeonIdConditionT dungeonIdConditionT = new IDungeonIdConditionT();
			this.UnPackTo(dungeonIdConditionT);
			return dungeonIdConditionT;
		}

		// Token: 0x06017876 RID: 96374 RVA: 0x0035BCF7 File Offset: 0x00359EF7
		public void UnPackTo(IDungeonIdConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.DungeonId = this.DungeonId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017877 RID: 96375 RVA: 0x0035BD38 File Offset: 0x00359F38
		public static Offset<IDungeonIdCondition> Pack(FlatBufferBuilder builder, IDungeonIdConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonIdCondition>);
			}
			return IDungeonIdCondition.CreateIDungeonIdCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.DungeonId, _o.NullMask);
		}

		// Token: 0x0400C10B RID: 49419
		private Table __p;
	}
}
