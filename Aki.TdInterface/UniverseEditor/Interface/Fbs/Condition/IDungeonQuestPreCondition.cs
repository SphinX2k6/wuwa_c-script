using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E8 RID: 20712
	public struct IDungeonQuestPreCondition : IFlatbufferObject
	{
		// Token: 0x1700946F RID: 37999
		// (get) Token: 0x060208AB RID: 133291 RVA: 0x00483C24 File Offset: 0x00481E24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208AC RID: 133292 RVA: 0x00483C31 File Offset: 0x00481E31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208AD RID: 133293 RVA: 0x00483C38 File Offset: 0x00481E38
		public static IDungeonQuestPreCondition GetRootAsIDungeonQuestPreCondition(ByteBuffer _bb)
		{
			return IDungeonQuestPreCondition.GetRootAsIDungeonQuestPreCondition(_bb, default(IDungeonQuestPreCondition));
		}

		// Token: 0x060208AE RID: 133294 RVA: 0x00483C54 File Offset: 0x00481E54
		public static IDungeonQuestPreCondition GetRootAsIDungeonQuestPreCondition(ByteBuffer _bb, IDungeonQuestPreCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208AF RID: 133295 RVA: 0x00483C71 File Offset: 0x00481E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208B0 RID: 133296 RVA: 0x00483C80 File Offset: 0x00481E80
		public IDungeonQuestPreCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009470 RID: 38000
		// (get) Token: 0x060208B1 RID: 133297 RVA: 0x00483C90 File Offset: 0x00481E90
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009471 RID: 38001
		// (get) Token: 0x060208B2 RID: 133298 RVA: 0x00483CCC File Offset: 0x00481ECC
		public IQuestPreConditionDungeonId? Dungeon
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IQuestPreConditionDungeonId?(default(IQuestPreConditionDungeonId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060208B3 RID: 133299 RVA: 0x00483D29 File Offset: 0x00481F29
		public static Offset<IDungeonQuestPreCondition> CreateIDungeonQuestPreCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, Offset<IQuestPreConditionDungeonId> DungeonOffset = default(Offset<IQuestPreConditionDungeonId>))
		{
			builder.StartTable(2);
			IDungeonQuestPreCondition.AddDungeon(builder, DungeonOffset);
			IDungeonQuestPreCondition.AddType(builder, Type);
			return IDungeonQuestPreCondition.EndIDungeonQuestPreCondition(builder);
		}

		// Token: 0x060208B4 RID: 133300 RVA: 0x00483D46 File Offset: 0x00481F46
		public static void StartIDungeonQuestPreCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060208B5 RID: 133301 RVA: 0x00483D4F File Offset: 0x00481F4F
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060208B6 RID: 133302 RVA: 0x00483D5A File Offset: 0x00481F5A
		public static void AddDungeon(FlatBufferBuilder builder, Offset<IQuestPreConditionDungeonId> dungeonOffset)
		{
			builder.AddOffset(1, dungeonOffset.Value, 0);
		}

		// Token: 0x060208B7 RID: 133303 RVA: 0x00483D6A File Offset: 0x00481F6A
		public static Offset<IDungeonQuestPreCondition> EndIDungeonQuestPreCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonQuestPreCondition>(builder.EndTable());
		}

		// Token: 0x060208B8 RID: 133304 RVA: 0x00483D78 File Offset: 0x00481F78
		public IDungeonQuestPreConditionT UnPack()
		{
			IDungeonQuestPreConditionT dungeonQuestPreConditionT = new IDungeonQuestPreConditionT();
			this.UnPackTo(dungeonQuestPreConditionT);
			return dungeonQuestPreConditionT;
		}

		// Token: 0x060208B9 RID: 133305 RVA: 0x00483D94 File Offset: 0x00481F94
		public void UnPackTo(IDungeonQuestPreConditionT _o)
		{
			_o.Type = this.Type;
			_o.Dungeon = ((this.Dungeon != null) ? this.Dungeon.Value.UnPack() : null);
		}

		// Token: 0x060208BA RID: 133306 RVA: 0x00483DDC File Offset: 0x00481FDC
		public static Offset<IDungeonQuestPreCondition> Pack(FlatBufferBuilder builder, IDungeonQuestPreConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonQuestPreCondition>);
			}
			Offset<IQuestPreConditionDungeonId> dungeonOffset = (_o.Dungeon == null) ? default(Offset<IQuestPreConditionDungeonId>) : IQuestPreConditionDungeonId.Pack(builder, _o.Dungeon);
			return IDungeonQuestPreCondition.CreateIDungeonQuestPreCondition(builder, _o.Type, dungeonOffset);
		}

		// Token: 0x0400E09F RID: 57503
		private Table __p;
	}
}
