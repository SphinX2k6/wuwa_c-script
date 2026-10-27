using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BFB RID: 19451
	public struct IDungeonQuestPreCondition : IFlatbufferObject
	{
		// Token: 0x17008D4B RID: 36171
		// (get) Token: 0x0601ECC5 RID: 126149 RVA: 0x004505BC File Offset: 0x0044E7BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECC6 RID: 126150 RVA: 0x004505C9 File Offset: 0x0044E7C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECC7 RID: 126151 RVA: 0x004505D0 File Offset: 0x0044E7D0
		public static IDungeonQuestPreCondition GetRootAsIDungeonQuestPreCondition(ByteBuffer _bb)
		{
			return IDungeonQuestPreCondition.GetRootAsIDungeonQuestPreCondition(_bb, default(IDungeonQuestPreCondition));
		}

		// Token: 0x0601ECC8 RID: 126152 RVA: 0x004505EC File Offset: 0x0044E7EC
		public static IDungeonQuestPreCondition GetRootAsIDungeonQuestPreCondition(ByteBuffer _bb, IDungeonQuestPreCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECC9 RID: 126153 RVA: 0x00450609 File Offset: 0x0044E809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECCA RID: 126154 RVA: 0x00450618 File Offset: 0x0044E818
		public IDungeonQuestPreCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D4C RID: 36172
		// (get) Token: 0x0601ECCB RID: 126155 RVA: 0x00450628 File Offset: 0x0044E828
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

		// Token: 0x17008D4D RID: 36173
		// (get) Token: 0x0601ECCC RID: 126156 RVA: 0x00450664 File Offset: 0x0044E864
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

		// Token: 0x0601ECCD RID: 126157 RVA: 0x004506C1 File Offset: 0x0044E8C1
		public static Offset<IDungeonQuestPreCondition> CreateIDungeonQuestPreCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, Offset<IQuestPreConditionDungeonId> DungeonOffset = default(Offset<IQuestPreConditionDungeonId>))
		{
			builder.StartTable(2);
			IDungeonQuestPreCondition.AddDungeon(builder, DungeonOffset);
			IDungeonQuestPreCondition.AddType(builder, Type);
			return IDungeonQuestPreCondition.EndIDungeonQuestPreCondition(builder);
		}

		// Token: 0x0601ECCE RID: 126158 RVA: 0x004506DE File Offset: 0x0044E8DE
		public static void StartIDungeonQuestPreCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ECCF RID: 126159 RVA: 0x004506E7 File Offset: 0x0044E8E7
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ECD0 RID: 126160 RVA: 0x004506F2 File Offset: 0x0044E8F2
		public static void AddDungeon(FlatBufferBuilder builder, Offset<IQuestPreConditionDungeonId> dungeonOffset)
		{
			builder.AddOffset(1, dungeonOffset.Value, 0);
		}

		// Token: 0x0601ECD1 RID: 126161 RVA: 0x00450702 File Offset: 0x0044E902
		public static Offset<IDungeonQuestPreCondition> EndIDungeonQuestPreCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonQuestPreCondition>(builder.EndTable());
		}

		// Token: 0x0601ECD2 RID: 126162 RVA: 0x00450710 File Offset: 0x0044E910
		public IDungeonQuestPreConditionT UnPack()
		{
			IDungeonQuestPreConditionT dungeonQuestPreConditionT = new IDungeonQuestPreConditionT();
			this.UnPackTo(dungeonQuestPreConditionT);
			return dungeonQuestPreConditionT;
		}

		// Token: 0x0601ECD3 RID: 126163 RVA: 0x0045072C File Offset: 0x0044E92C
		public void UnPackTo(IDungeonQuestPreConditionT _o)
		{
			_o.Type = this.Type;
			_o.Dungeon = ((this.Dungeon != null) ? this.Dungeon.Value.UnPack() : null);
		}

		// Token: 0x0601ECD4 RID: 126164 RVA: 0x00450774 File Offset: 0x0044E974
		public static Offset<IDungeonQuestPreCondition> Pack(FlatBufferBuilder builder, IDungeonQuestPreConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonQuestPreCondition>);
			}
			Offset<IQuestPreConditionDungeonId> dungeonOffset = (_o.Dungeon == null) ? default(Offset<IQuestPreConditionDungeonId>) : IQuestPreConditionDungeonId.Pack(builder, _o.Dungeon);
			return IDungeonQuestPreCondition.CreateIDungeonQuestPreCondition(builder, _o.Type, dungeonOffset);
		}

		// Token: 0x0400D588 RID: 54664
		private Table __p;
	}
}
