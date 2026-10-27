using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE2 RID: 15842
	public struct IDungeonCondition : IFlatbufferObject
	{
		// Token: 0x17006D68 RID: 28008
		// (get) Token: 0x06016217 RID: 90647 RVA: 0x00332C4A File Offset: 0x00330E4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016218 RID: 90648 RVA: 0x00332C57 File Offset: 0x00330E57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016219 RID: 90649 RVA: 0x00332C60 File Offset: 0x00330E60
		public static IDungeonCondition GetRootAsIDungeonCondition(ByteBuffer _bb)
		{
			return IDungeonCondition.GetRootAsIDungeonCondition(_bb, default(IDungeonCondition));
		}

		// Token: 0x0601621A RID: 90650 RVA: 0x00332C7C File Offset: 0x00330E7C
		public static IDungeonCondition GetRootAsIDungeonCondition(ByteBuffer _bb, IDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601621B RID: 90651 RVA: 0x00332C99 File Offset: 0x00330E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601621C RID: 90652 RVA: 0x00332CA8 File Offset: 0x00330EA8
		public IDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D69 RID: 28009
		// (get) Token: 0x0601621D RID: 90653 RVA: 0x00332CB8 File Offset: 0x00330EB8
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

		// Token: 0x17006D6A RID: 28010
		// (get) Token: 0x0601621E RID: 90654 RVA: 0x00332CF4 File Offset: 0x00330EF4
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

		// Token: 0x17006D6B RID: 28011
		// (get) Token: 0x0601621F RID: 90655 RVA: 0x00332D30 File Offset: 0x00330F30
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D6C RID: 28012
		// (get) Token: 0x06016220 RID: 90656 RVA: 0x00332D70 File Offset: 0x00330F70
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

		// Token: 0x06016221 RID: 90657 RVA: 0x00332DAD File Offset: 0x00330FAD
		public static Offset<IDungeonCondition> CreateIDungeonCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, int Count = 0, bool IsExitDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDungeonCondition.AddCount(builder, Count);
			IDungeonCondition.AddNullMask(builder, NullMask);
			IDungeonCondition.AddIsExitDungeon(builder, IsExitDungeon);
			IDungeonCondition.AddType(builder, Type);
			return IDungeonCondition.EndIDungeonCondition(builder);
		}

		// Token: 0x06016222 RID: 90658 RVA: 0x00332DD9 File Offset: 0x00330FD9
		public static void StartIDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016223 RID: 90659 RVA: 0x00332DE2 File Offset: 0x00330FE2
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016224 RID: 90660 RVA: 0x00332DED File Offset: 0x00330FED
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06016225 RID: 90661 RVA: 0x00332DF8 File Offset: 0x00330FF8
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06016226 RID: 90662 RVA: 0x00332E03 File Offset: 0x00331003
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016227 RID: 90663 RVA: 0x00332E0E File Offset: 0x0033100E
		public static Offset<IDungeonCondition> EndIDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06016228 RID: 90664 RVA: 0x00332E1C File Offset: 0x0033101C
		public IDungeonConditionT UnPack()
		{
			IDungeonConditionT dungeonConditionT = new IDungeonConditionT();
			this.UnPackTo(dungeonConditionT);
			return dungeonConditionT;
		}

		// Token: 0x06016229 RID: 90665 RVA: 0x00332E37 File Offset: 0x00331037
		public void UnPackTo(IDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601622A RID: 90666 RVA: 0x00332E6C File Offset: 0x0033106C
		public static Offset<IDungeonCondition> Pack(FlatBufferBuilder builder, IDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonCondition>);
			}
			return IDungeonCondition.CreateIDungeonCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.NullMask);
		}

		// Token: 0x0400B72B RID: 46891
		private Table __p;
	}
}
