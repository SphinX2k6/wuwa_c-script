using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA9 RID: 19625
	public struct IQuestStateEqualCondition : IFlatbufferObject
	{
		// Token: 0x17008E77 RID: 36471
		// (get) Token: 0x0601F20F RID: 127503 RVA: 0x00459122 File Offset: 0x00457322
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F210 RID: 127504 RVA: 0x0045912F File Offset: 0x0045732F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F211 RID: 127505 RVA: 0x00459138 File Offset: 0x00457338
		public static IQuestStateEqualCondition GetRootAsIQuestStateEqualCondition(ByteBuffer _bb)
		{
			return IQuestStateEqualCondition.GetRootAsIQuestStateEqualCondition(_bb, default(IQuestStateEqualCondition));
		}

		// Token: 0x0601F212 RID: 127506 RVA: 0x00459154 File Offset: 0x00457354
		public static IQuestStateEqualCondition GetRootAsIQuestStateEqualCondition(ByteBuffer _bb, IQuestStateEqualCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F213 RID: 127507 RVA: 0x00459171 File Offset: 0x00457371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F214 RID: 127508 RVA: 0x00459180 File Offset: 0x00457380
		public IQuestStateEqualCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E78 RID: 36472
		// (get) Token: 0x0601F215 RID: 127509 RVA: 0x00459190 File Offset: 0x00457390
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E79 RID: 36473
		// (get) Token: 0x0601F216 RID: 127510 RVA: 0x004591CC File Offset: 0x004573CC
		public int QuestId
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

		// Token: 0x17008E7A RID: 36474
		// (get) Token: 0x0601F217 RID: 127511 RVA: 0x00459208 File Offset: 0x00457408
		public EQuestState State
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EQuestState.InActive;
				}
				return (EQuestState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E7B RID: 36475
		// (get) Token: 0x0601F218 RID: 127512 RVA: 0x00459244 File Offset: 0x00457444
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F219 RID: 127513 RVA: 0x00459281 File Offset: 0x00457481
		public static Offset<IQuestStateEqualCondition> CreateIQuestStateEqualCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, EQuestState State = EQuestState.InActive, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			IQuestStateEqualCondition.AddQuestId(builder, QuestId);
			IQuestStateEqualCondition.AddCompare(builder, Compare);
			IQuestStateEqualCondition.AddState(builder, State);
			IQuestStateEqualCondition.AddType(builder, Type);
			return IQuestStateEqualCondition.EndIQuestStateEqualCondition(builder);
		}

		// Token: 0x0601F21A RID: 127514 RVA: 0x004592AD File Offset: 0x004574AD
		public static void StartIQuestStateEqualCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F21B RID: 127515 RVA: 0x004592B6 File Offset: 0x004574B6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F21C RID: 127516 RVA: 0x004592C1 File Offset: 0x004574C1
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601F21D RID: 127517 RVA: 0x004592CC File Offset: 0x004574CC
		public static void AddState(FlatBufferBuilder builder, EQuestState state)
		{
			builder.AddByte(2, (byte)state, 0);
		}

		// Token: 0x0601F21E RID: 127518 RVA: 0x004592D7 File Offset: 0x004574D7
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F21F RID: 127519 RVA: 0x004592E2 File Offset: 0x004574E2
		public static Offset<IQuestStateEqualCondition> EndIQuestStateEqualCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStateEqualCondition>(builder.EndTable());
		}

		// Token: 0x0601F220 RID: 127520 RVA: 0x004592F0 File Offset: 0x004574F0
		public IQuestStateEqualConditionT UnPack()
		{
			IQuestStateEqualConditionT questStateEqualConditionT = new IQuestStateEqualConditionT();
			this.UnPackTo(questStateEqualConditionT);
			return questStateEqualConditionT;
		}

		// Token: 0x0601F221 RID: 127521 RVA: 0x0045930B File Offset: 0x0045750B
		public void UnPackTo(IQuestStateEqualConditionT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.State = this.State;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601F222 RID: 127522 RVA: 0x00459340 File Offset: 0x00457540
		public static Offset<IQuestStateEqualCondition> Pack(FlatBufferBuilder builder, IQuestStateEqualConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStateEqualCondition>);
			}
			return IQuestStateEqualCondition.CreateIQuestStateEqualCondition(builder, _o.Type, _o.QuestId, _o.State, _o.Compare);
		}

		// Token: 0x0400D666 RID: 54886
		private Table __p;
	}
}
