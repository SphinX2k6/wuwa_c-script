using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420B RID: 16907
	public struct IDetectCombatStateCondition : IFlatbufferObject
	{
		// Token: 0x17007320 RID: 29472
		// (get) Token: 0x0601778E RID: 96142 RVA: 0x0035A25E File Offset: 0x0035845E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601778F RID: 96143 RVA: 0x0035A26B File Offset: 0x0035846B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017790 RID: 96144 RVA: 0x0035A274 File Offset: 0x00358474
		public static IDetectCombatStateCondition GetRootAsIDetectCombatStateCondition(ByteBuffer _bb)
		{
			return IDetectCombatStateCondition.GetRootAsIDetectCombatStateCondition(_bb, default(IDetectCombatStateCondition));
		}

		// Token: 0x06017791 RID: 96145 RVA: 0x0035A290 File Offset: 0x00358490
		public static IDetectCombatStateCondition GetRootAsIDetectCombatStateCondition(ByteBuffer _bb, IDetectCombatStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017792 RID: 96146 RVA: 0x0035A2AD File Offset: 0x003584AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017793 RID: 96147 RVA: 0x0035A2BC File Offset: 0x003584BC
		public IDetectCombatStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007321 RID: 29473
		// (get) Token: 0x06017794 RID: 96148 RVA: 0x0035A2CC File Offset: 0x003584CC
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007322 RID: 29474
		// (get) Token: 0x06017795 RID: 96149 RVA: 0x0035A308 File Offset: 0x00358508
		public IConditionGroup? PreConditions
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

		// Token: 0x17007323 RID: 29475
		// (get) Token: 0x06017796 RID: 96150 RVA: 0x0035A368 File Offset: 0x00358568
		public int EntityId
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

		// Token: 0x17007324 RID: 29476
		// (get) Token: 0x06017797 RID: 96151 RVA: 0x0035A3A4 File Offset: 0x003585A4
		public string State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017798 RID: 96152 RVA: 0x0035A3DC File Offset: 0x003585DC
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06017799 RID: 96153 RVA: 0x0035A3EC File Offset: 0x003585EC
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007325 RID: 29477
		// (get) Token: 0x0601779A RID: 96154 RVA: 0x0035A3FC File Offset: 0x003585FC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007326 RID: 29478
		// (get) Token: 0x0601779B RID: 96155 RVA: 0x0035A43C File Offset: 0x0035863C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601779C RID: 96156 RVA: 0x0035A479 File Offset: 0x00358679
		public static Offset<IDetectCombatStateCondition> CreateIDetectCombatStateCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityId = 0, StringOffset StateOffset = default(StringOffset), ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(6);
			IDetectCombatStateCondition.AddState(builder, StateOffset);
			IDetectCombatStateCondition.AddEntityId(builder, EntityId);
			IDetectCombatStateCondition.AddPreConditions(builder, PreConditionsOffset);
			IDetectCombatStateCondition.AddNullMask(builder, NullMask);
			IDetectCombatStateCondition.AddCompare(builder, Compare);
			IDetectCombatStateCondition.AddType(builder, Type);
			return IDetectCombatStateCondition.EndIDetectCombatStateCondition(builder);
		}

		// Token: 0x0601779D RID: 96157 RVA: 0x0035A4B5 File Offset: 0x003586B5
		public static void StartIDetectCombatStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601779E RID: 96158 RVA: 0x0035A4BE File Offset: 0x003586BE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601779F RID: 96159 RVA: 0x0035A4C9 File Offset: 0x003586C9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060177A0 RID: 96160 RVA: 0x0035A4D9 File Offset: 0x003586D9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x060177A1 RID: 96161 RVA: 0x0035A4E4 File Offset: 0x003586E4
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x060177A2 RID: 96162 RVA: 0x0035A4F4 File Offset: 0x003586F4
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x060177A3 RID: 96163 RVA: 0x0035A4FF File Offset: 0x003586FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060177A4 RID: 96164 RVA: 0x0035A50A File Offset: 0x0035870A
		public static Offset<IDetectCombatStateCondition> EndIDetectCombatStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDetectCombatStateCondition>(builder.EndTable());
		}

		// Token: 0x060177A5 RID: 96165 RVA: 0x0035A518 File Offset: 0x00358718
		public IDetectCombatStateConditionT UnPack()
		{
			IDetectCombatStateConditionT detectCombatStateConditionT = new IDetectCombatStateConditionT();
			this.UnPackTo(detectCombatStateConditionT);
			return detectCombatStateConditionT;
		}

		// Token: 0x060177A6 RID: 96166 RVA: 0x0035A534 File Offset: 0x00358734
		public void UnPackTo(IDetectCombatStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060177A7 RID: 96167 RVA: 0x0035A5AC File Offset: 0x003587AC
		public static Offset<IDetectCombatStateCondition> Pack(FlatBufferBuilder builder, IDetectCombatStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectCombatStateCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IDetectCombatStateCondition.CreateIDetectCombatStateCondition(builder, _o.Type, preConditionsOffset, _o.EntityId, stateOffset, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400C0E8 RID: 49384
		private Table __p;
	}
}
