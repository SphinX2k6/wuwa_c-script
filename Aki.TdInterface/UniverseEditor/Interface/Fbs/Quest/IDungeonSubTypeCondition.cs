using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DEB RID: 15851
	public struct IDungeonSubTypeCondition : IFlatbufferObject
	{
		// Token: 0x17006D7E RID: 28030
		// (get) Token: 0x06016265 RID: 90725 RVA: 0x00333460 File Offset: 0x00331660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016266 RID: 90726 RVA: 0x0033346D File Offset: 0x0033166D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016267 RID: 90727 RVA: 0x00333474 File Offset: 0x00331674
		public static IDungeonSubTypeCondition GetRootAsIDungeonSubTypeCondition(ByteBuffer _bb)
		{
			return IDungeonSubTypeCondition.GetRootAsIDungeonSubTypeCondition(_bb, default(IDungeonSubTypeCondition));
		}

		// Token: 0x06016268 RID: 90728 RVA: 0x00333490 File Offset: 0x00331690
		public static IDungeonSubTypeCondition GetRootAsIDungeonSubTypeCondition(ByteBuffer _bb, IDungeonSubTypeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016269 RID: 90729 RVA: 0x003334AD File Offset: 0x003316AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601626A RID: 90730 RVA: 0x003334BC File Offset: 0x003316BC
		public IDungeonSubTypeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D7F RID: 28031
		// (get) Token: 0x0601626B RID: 90731 RVA: 0x003334CC File Offset: 0x003316CC
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

		// Token: 0x17006D80 RID: 28032
		// (get) Token: 0x0601626C RID: 90732 RVA: 0x00333508 File Offset: 0x00331708
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

		// Token: 0x17006D81 RID: 28033
		// (get) Token: 0x0601626D RID: 90733 RVA: 0x00333544 File Offset: 0x00331744
		public bool IsExitDungeon
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D82 RID: 28034
		// (get) Token: 0x0601626E RID: 90734 RVA: 0x00333584 File Offset: 0x00331784
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

		// Token: 0x17006D83 RID: 28035
		// (get) Token: 0x0601626F RID: 90735 RVA: 0x003335C4 File Offset: 0x003317C4
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

		// Token: 0x06016270 RID: 90736 RVA: 0x00333601 File Offset: 0x00331801
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

		// Token: 0x06016271 RID: 90737 RVA: 0x00333635 File Offset: 0x00331835
		public static void StartIDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016272 RID: 90738 RVA: 0x0033363E File Offset: 0x0033183E
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016273 RID: 90739 RVA: 0x00333649 File Offset: 0x00331849
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06016274 RID: 90740 RVA: 0x00333654 File Offset: 0x00331854
		public static void AddIsExitDungeon(FlatBufferBuilder builder, bool isExitDungeon)
		{
			builder.AddBool(2, isExitDungeon, false);
		}

		// Token: 0x06016275 RID: 90741 RVA: 0x0033365F File Offset: 0x0033185F
		public static void AddDungeonSubType(FlatBufferBuilder builder, EDungeonSubType dungeonSubType)
		{
			builder.AddByte(3, (byte)dungeonSubType, 0);
		}

		// Token: 0x06016276 RID: 90742 RVA: 0x0033366A File Offset: 0x0033186A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016277 RID: 90743 RVA: 0x00333675 File Offset: 0x00331875
		public static Offset<IDungeonSubTypeCondition> EndIDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonSubTypeCondition>(builder.EndTable());
		}

		// Token: 0x06016278 RID: 90744 RVA: 0x00333684 File Offset: 0x00331884
		public IDungeonSubTypeConditionT UnPack()
		{
			IDungeonSubTypeConditionT dungeonSubTypeConditionT = new IDungeonSubTypeConditionT();
			this.UnPackTo(dungeonSubTypeConditionT);
			return dungeonSubTypeConditionT;
		}

		// Token: 0x06016279 RID: 90745 RVA: 0x0033369F File Offset: 0x0033189F
		public void UnPackTo(IDungeonSubTypeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.IsExitDungeon = this.IsExitDungeon;
			_o.DungeonSubType = this.DungeonSubType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601627A RID: 90746 RVA: 0x003336E0 File Offset: 0x003318E0
		public static Offset<IDungeonSubTypeCondition> Pack(FlatBufferBuilder builder, IDungeonSubTypeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonSubTypeCondition>);
			}
			return IDungeonSubTypeCondition.CreateIDungeonSubTypeCondition(builder, _o.Type, _o.Count, _o.IsExitDungeon, _o.DungeonSubType, _o.NullMask);
		}

		// Token: 0x0400B73D RID: 46909
		private Table __p;
	}
}
