using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421D RID: 16925
	public struct IDungeonCondition : IFlatbufferObject
	{
		// Token: 0x17007348 RID: 29512
		// (get) Token: 0x06017836 RID: 96310 RVA: 0x0035B64E File Offset: 0x0035984E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017837 RID: 96311 RVA: 0x0035B65B File Offset: 0x0035985B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017838 RID: 96312 RVA: 0x0035B664 File Offset: 0x00359864
		public static IDungeonCondition GetRootAsIDungeonCondition(ByteBuffer _bb)
		{
			return IDungeonCondition.GetRootAsIDungeonCondition(_bb, default(IDungeonCondition));
		}

		// Token: 0x06017839 RID: 96313 RVA: 0x0035B680 File Offset: 0x00359880
		public static IDungeonCondition GetRootAsIDungeonCondition(ByteBuffer _bb, IDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601783A RID: 96314 RVA: 0x0035B69D File Offset: 0x0035989D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601783B RID: 96315 RVA: 0x0035B6AC File Offset: 0x003598AC
		public IDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007349 RID: 29513
		// (get) Token: 0x0601783C RID: 96316 RVA: 0x0035B6BC File Offset: 0x003598BC
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

		// Token: 0x1700734A RID: 29514
		// (get) Token: 0x0601783D RID: 96317 RVA: 0x0035B6F8 File Offset: 0x003598F8
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

		// Token: 0x1700734B RID: 29515
		// (get) Token: 0x0601783E RID: 96318 RVA: 0x0035B734 File Offset: 0x00359934
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700734C RID: 29516
		// (get) Token: 0x0601783F RID: 96319 RVA: 0x0035B774 File Offset: 0x00359974
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

		// Token: 0x06017840 RID: 96320 RVA: 0x0035B7B1 File Offset: 0x003599B1
		public static Offset<IDungeonCondition> CreateIDungeonCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int Count = 0, bool IsExitDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDungeonCondition.AddCount(builder, Count);
			IDungeonCondition.AddNullMask(builder, NullMask);
			IDungeonCondition.AddIsExitDungeon(builder, IsExitDungeon);
			IDungeonCondition.AddType(builder, Type);
			return IDungeonCondition.EndIDungeonCondition(builder);
		}

		// Token: 0x06017841 RID: 96321 RVA: 0x0035B7DD File Offset: 0x003599DD
		public static void StartIDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017842 RID: 96322 RVA: 0x0035B7E6 File Offset: 0x003599E6
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017843 RID: 96323 RVA: 0x0035B7F1 File Offset: 0x003599F1
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06017844 RID: 96324 RVA: 0x0035B7FC File Offset: 0x003599FC
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06017845 RID: 96325 RVA: 0x0035B807 File Offset: 0x00359A07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06017846 RID: 96326 RVA: 0x0035B812 File Offset: 0x00359A12
		public static Offset<IDungeonCondition> EndIDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06017847 RID: 96327 RVA: 0x0035B820 File Offset: 0x00359A20
		public IDungeonConditionT UnPack()
		{
			IDungeonConditionT dungeonConditionT = new IDungeonConditionT();
			this.UnPackTo(dungeonConditionT);
			return dungeonConditionT;
		}

		// Token: 0x06017848 RID: 96328 RVA: 0x0035B83B File Offset: 0x00359A3B
		public void UnPackTo(IDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017849 RID: 96329 RVA: 0x0035B870 File Offset: 0x00359A70
		public static Offset<IDungeonCondition> Pack(FlatBufferBuilder builder, IDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonCondition>);
			}
			return IDungeonCondition.CreateIDungeonCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.NullMask);
		}

		// Token: 0x0400C0FF RID: 49407
		private Table __p;
	}
}
