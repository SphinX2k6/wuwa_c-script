using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004956 RID: 18774
	public struct ILevelPlayExploratoryConfig : IFlatbufferObject
	{
		// Token: 0x17008348 RID: 33608
		// (get) Token: 0x0601BF78 RID: 114552 RVA: 0x003F4874 File Offset: 0x003F2A74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF79 RID: 114553 RVA: 0x003F4881 File Offset: 0x003F2A81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF7A RID: 114554 RVA: 0x003F4888 File Offset: 0x003F2A88
		public static ILevelPlayExploratoryConfig GetRootAsILevelPlayExploratoryConfig(ByteBuffer _bb)
		{
			return ILevelPlayExploratoryConfig.GetRootAsILevelPlayExploratoryConfig(_bb, default(ILevelPlayExploratoryConfig));
		}

		// Token: 0x0601BF7B RID: 114555 RVA: 0x003F48A4 File Offset: 0x003F2AA4
		public static ILevelPlayExploratoryConfig GetRootAsILevelPlayExploratoryConfig(ByteBuffer _bb, ILevelPlayExploratoryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF7C RID: 114556 RVA: 0x003F48C1 File Offset: 0x003F2AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF7D RID: 114557 RVA: 0x003F48D0 File Offset: 0x003F2AD0
		public ILevelPlayExploratoryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008349 RID: 33609
		// (get) Token: 0x0601BF7E RID: 114558 RVA: 0x003F48E0 File Offset: 0x003F2AE0
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

		// Token: 0x1700834A RID: 33610
		// (get) Token: 0x0601BF7F RID: 114559 RVA: 0x003F491C File Offset: 0x003F2B1C
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

		// Token: 0x1700834B RID: 33611
		// (get) Token: 0x0601BF80 RID: 114560 RVA: 0x003F497C File Offset: 0x003F2B7C
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

		// Token: 0x1700834C RID: 33612
		// (get) Token: 0x0601BF81 RID: 114561 RVA: 0x003F49B8 File Offset: 0x003F2BB8
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

		// Token: 0x1700834D RID: 33613
		// (get) Token: 0x0601BF82 RID: 114562 RVA: 0x003F49F8 File Offset: 0x003F2BF8
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

		// Token: 0x0601BF83 RID: 114563 RVA: 0x003F4A35 File Offset: 0x003F2C35
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

		// Token: 0x0601BF84 RID: 114564 RVA: 0x003F4A69 File Offset: 0x003F2C69
		public static void StartILevelPlayExploratoryConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601BF85 RID: 114565 RVA: 0x003F4A72 File Offset: 0x003F2C72
		public static void AddWhen(FlatBufferBuilder builder, ELevelPlayExploratoryCheckTiming when)
		{
			builder.AddByte(0, (byte)when, 0);
		}

		// Token: 0x0601BF86 RID: 114566 RVA: 0x003F4A7D File Offset: 0x003F2C7D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601BF87 RID: 114567 RVA: 0x003F4A8D File Offset: 0x003F2C8D
		public static void AddAddType(FlatBufferBuilder builder, int addType)
		{
			builder.AddInt(2, addType, 0);
		}

		// Token: 0x0601BF88 RID: 114568 RVA: 0x003F4A98 File Offset: 0x003F2C98
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(3, areaId, 0);
		}

		// Token: 0x0601BF89 RID: 114569 RVA: 0x003F4AA3 File Offset: 0x003F2CA3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601BF8A RID: 114570 RVA: 0x003F4AAE File Offset: 0x003F2CAE
		public static Offset<ILevelPlayExploratoryConfig> EndILevelPlayExploratoryConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayExploratoryConfig>(builder.EndTable());
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x003F4ABC File Offset: 0x003F2CBC
		public ILevelPlayExploratoryConfigT UnPack()
		{
			ILevelPlayExploratoryConfigT levelPlayExploratoryConfigT = new ILevelPlayExploratoryConfigT();
			this.UnPackTo(levelPlayExploratoryConfigT);
			return levelPlayExploratoryConfigT;
		}

		// Token: 0x0601BF8C RID: 114572 RVA: 0x003F4AD8 File Offset: 0x003F2CD8
		public void UnPackTo(ILevelPlayExploratoryConfigT _o)
		{
			_o.When = this.When;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.AddType = this.AddType;
			_o.AreaId = this.AreaId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BF8D RID: 114573 RVA: 0x003F4B44 File Offset: 0x003F2D44
		public static Offset<ILevelPlayExploratoryConfig> Pack(FlatBufferBuilder builder, ILevelPlayExploratoryConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayExploratoryConfig>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ILevelPlayExploratoryConfig.CreateILevelPlayExploratoryConfig(builder, _o.When, conditionOffset, _o.AddType, _o.AreaId, _o.NullMask);
		}

		// Token: 0x0400CF74 RID: 53108
		private Table __p;
	}
}
