using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044EE RID: 17646
	public struct ILevelPlayExploratoryConfig : IFlatbufferObject
	{
		// Token: 0x17007D07 RID: 32007
		// (get) Token: 0x0601A7A3 RID: 108451 RVA: 0x003C85D8 File Offset: 0x003C67D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A7A4 RID: 108452 RVA: 0x003C85E5 File Offset: 0x003C67E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A7A5 RID: 108453 RVA: 0x003C85EC File Offset: 0x003C67EC
		public static ILevelPlayExploratoryConfig GetRootAsILevelPlayExploratoryConfig(ByteBuffer _bb)
		{
			return ILevelPlayExploratoryConfig.GetRootAsILevelPlayExploratoryConfig(_bb, default(ILevelPlayExploratoryConfig));
		}

		// Token: 0x0601A7A6 RID: 108454 RVA: 0x003C8608 File Offset: 0x003C6808
		public static ILevelPlayExploratoryConfig GetRootAsILevelPlayExploratoryConfig(ByteBuffer _bb, ILevelPlayExploratoryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A7A7 RID: 108455 RVA: 0x003C8625 File Offset: 0x003C6825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A7A8 RID: 108456 RVA: 0x003C8634 File Offset: 0x003C6834
		public ILevelPlayExploratoryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D08 RID: 32008
		// (get) Token: 0x0601A7A9 RID: 108457 RVA: 0x003C8644 File Offset: 0x003C6844
		public ELevelPlayExploratoryCheckTiming When
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayExploratoryCheckTiming.OnCompletion;
				}
				return (ELevelPlayExploratoryCheckTiming)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D09 RID: 32009
		// (get) Token: 0x0601A7AA RID: 108458 RVA: 0x003C8680 File Offset: 0x003C6880
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D0A RID: 32010
		// (get) Token: 0x0601A7AB RID: 108459 RVA: 0x003C86E0 File Offset: 0x003C68E0
		public int AddType
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

		// Token: 0x17007D0B RID: 32011
		// (get) Token: 0x0601A7AC RID: 108460 RVA: 0x003C871C File Offset: 0x003C691C
		public int AreaId
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

		// Token: 0x17007D0C RID: 32012
		// (get) Token: 0x0601A7AD RID: 108461 RVA: 0x003C875C File Offset: 0x003C695C
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

		// Token: 0x0601A7AE RID: 108462 RVA: 0x003C8799 File Offset: 0x003C6999
		public static Offset<ILevelPlayExploratoryConfig> CreateILevelPlayExploratoryConfig(FlatBufferBuilder builder, ELevelPlayExploratoryCheckTiming When = ELevelPlayExploratoryCheckTiming.OnCompletion, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int AddType = 0, int AreaId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPlayExploratoryConfig.AddAreaId(builder, AreaId);
			ILevelPlayExploratoryConfig.AddAddType(builder, AddType);
			ILevelPlayExploratoryConfig.AddCondition(builder, ConditionOffset);
			ILevelPlayExploratoryConfig.AddNullMask(builder, NullMask);
			ILevelPlayExploratoryConfig.AddWhen(builder, When);
			return ILevelPlayExploratoryConfig.EndILevelPlayExploratoryConfig(builder);
		}

		// Token: 0x0601A7AF RID: 108463 RVA: 0x003C87CD File Offset: 0x003C69CD
		public static void StartILevelPlayExploratoryConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A7B0 RID: 108464 RVA: 0x003C87D6 File Offset: 0x003C69D6
		public static void AddWhen(FlatBufferBuilder builder, ELevelPlayExploratoryCheckTiming when)
		{
			builder.AddByte(0, (byte)when, 0);
		}

		// Token: 0x0601A7B1 RID: 108465 RVA: 0x003C87E1 File Offset: 0x003C69E1
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601A7B2 RID: 108466 RVA: 0x003C87F1 File Offset: 0x003C69F1
		public static void AddAddType(FlatBufferBuilder builder, int addType)
		{
			builder.AddInt(2, addType, 0);
		}

		// Token: 0x0601A7B3 RID: 108467 RVA: 0x003C87FC File Offset: 0x003C69FC
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(3, areaId, 0);
		}

		// Token: 0x0601A7B4 RID: 108468 RVA: 0x003C8807 File Offset: 0x003C6A07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A7B5 RID: 108469 RVA: 0x003C8812 File Offset: 0x003C6A12
		public static Offset<ILevelPlayExploratoryConfig> EndILevelPlayExploratoryConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayExploratoryConfig>(builder.EndTable());
		}

		// Token: 0x0601A7B6 RID: 108470 RVA: 0x003C8820 File Offset: 0x003C6A20
		public ILevelPlayExploratoryConfigT UnPack()
		{
			ILevelPlayExploratoryConfigT levelPlayExploratoryConfigT = new ILevelPlayExploratoryConfigT();
			this.UnPackTo(levelPlayExploratoryConfigT);
			return levelPlayExploratoryConfigT;
		}

		// Token: 0x0601A7B7 RID: 108471 RVA: 0x003C883C File Offset: 0x003C6A3C
		public void UnPackTo(ILevelPlayExploratoryConfigT _o)
		{
			_o.When = this.When;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.AddType = this.AddType;
			_o.AreaId = this.AreaId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A7B8 RID: 108472 RVA: 0x003C88A8 File Offset: 0x003C6AA8
		public static Offset<ILevelPlayExploratoryConfig> Pack(FlatBufferBuilder builder, ILevelPlayExploratoryConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayExploratoryConfig>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ILevelPlayExploratoryConfig.CreateILevelPlayExploratoryConfig(builder, _o.When, conditionOffset, _o.AddType, _o.AreaId, _o.NullMask);
		}

		// Token: 0x0400C545 RID: 50501
		private Table __p;
	}
}
