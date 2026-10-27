using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007322 RID: 29474
	public struct ITalkOptionCondition : IFlatbufferObject
	{
		// Token: 0x1700DFEC RID: 57324
		// (get) Token: 0x060357E2 RID: 219106 RVA: 0x00749D35 File Offset: 0x00747F35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357E3 RID: 219107 RVA: 0x00749D42 File Offset: 0x00747F42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357E4 RID: 219108 RVA: 0x00749D4C File Offset: 0x00747F4C
		public static ITalkOptionCondition GetRootAsITalkOptionCondition(ByteBuffer _bb)
		{
			return ITalkOptionCondition.GetRootAsITalkOptionCondition(_bb, default(ITalkOptionCondition));
		}

		// Token: 0x060357E5 RID: 219109 RVA: 0x00749D68 File Offset: 0x00747F68
		public static ITalkOptionCondition GetRootAsITalkOptionCondition(ByteBuffer _bb, ITalkOptionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357E6 RID: 219110 RVA: 0x00749D85 File Offset: 0x00747F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357E7 RID: 219111 RVA: 0x00749D94 File Offset: 0x00747F94
		public ITalkOptionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFED RID: 57325
		// (get) Token: 0x060357E8 RID: 219112 RVA: 0x00749DA4 File Offset: 0x00747FA4
		public ETalkOptionPreConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return (ETalkOptionPreConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFEE RID: 57326
		// (get) Token: 0x060357E9 RID: 219113 RVA: 0x00749DE0 File Offset: 0x00747FE0
		public IConditionGroup? Conditions
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

		// Token: 0x060357EA RID: 219114 RVA: 0x00749E3D File Offset: 0x0074803D
		public static Offset<ITalkOptionCondition> CreateITalkOptionCondition(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ITalkOptionCondition.AddConditions(builder, ConditionsOffset);
			ITalkOptionCondition.AddType(builder, Type);
			return ITalkOptionCondition.EndITalkOptionCondition(builder);
		}

		// Token: 0x060357EB RID: 219115 RVA: 0x00749E5A File Offset: 0x0074805A
		public static void StartITalkOptionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060357EC RID: 219116 RVA: 0x00749E63 File Offset: 0x00748063
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060357ED RID: 219117 RVA: 0x00749E6E File Offset: 0x0074806E
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x060357EE RID: 219118 RVA: 0x00749E7E File Offset: 0x0074807E
		public static Offset<ITalkOptionCondition> EndITalkOptionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionCondition>(builder.EndTable());
		}

		// Token: 0x060357EF RID: 219119 RVA: 0x00749E8C File Offset: 0x0074808C
		public ITalkOptionConditionT UnPack()
		{
			ITalkOptionConditionT talkOptionConditionT = new ITalkOptionConditionT();
			this.UnPackTo(talkOptionConditionT);
			return talkOptionConditionT;
		}

		// Token: 0x060357F0 RID: 219120 RVA: 0x00749EA8 File Offset: 0x007480A8
		public void UnPackTo(ITalkOptionConditionT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
		}

		// Token: 0x060357F1 RID: 219121 RVA: 0x00749EF0 File Offset: 0x007480F0
		public static Offset<ITalkOptionCondition> Pack(FlatBufferBuilder builder, ITalkOptionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionCondition>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return ITalkOptionCondition.CreateITalkOptionCondition(builder, _o.Type, conditionsOffset);
		}

		// Token: 0x0401210E RID: 73998
		private Table __p;
	}
}
