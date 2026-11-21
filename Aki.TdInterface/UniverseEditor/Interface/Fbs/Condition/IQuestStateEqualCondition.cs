using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A2 RID: 20898
	public struct IQuestStateEqualCondition : IFlatbufferObject
	{
		// Token: 0x170095A5 RID: 38309
		// (get) Token: 0x06020E31 RID: 134705 RVA: 0x0048CC72 File Offset: 0x0048AE72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E32 RID: 134706 RVA: 0x0048CC7F File Offset: 0x0048AE7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E33 RID: 134707 RVA: 0x0048CC88 File Offset: 0x0048AE88
		public static IQuestStateEqualCondition GetRootAsIQuestStateEqualCondition(ByteBuffer _bb)
		{
			return IQuestStateEqualCondition.GetRootAsIQuestStateEqualCondition(_bb, default(IQuestStateEqualCondition));
		}

		// Token: 0x06020E34 RID: 134708 RVA: 0x0048CCA4 File Offset: 0x0048AEA4
		public static IQuestStateEqualCondition GetRootAsIQuestStateEqualCondition(ByteBuffer _bb, IQuestStateEqualCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E35 RID: 134709 RVA: 0x0048CCC1 File Offset: 0x0048AEC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E36 RID: 134710 RVA: 0x0048CCD0 File Offset: 0x0048AED0
		public IQuestStateEqualCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095A6 RID: 38310
		// (get) Token: 0x06020E37 RID: 134711 RVA: 0x0048CCE0 File Offset: 0x0048AEE0
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

		// Token: 0x170095A7 RID: 38311
		// (get) Token: 0x06020E38 RID: 134712 RVA: 0x0048CD1C File Offset: 0x0048AF1C
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

		// Token: 0x170095A8 RID: 38312
		// (get) Token: 0x06020E39 RID: 134713 RVA: 0x0048CD58 File Offset: 0x0048AF58
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

		// Token: 0x170095A9 RID: 38313
		// (get) Token: 0x06020E3A RID: 134714 RVA: 0x0048CD94 File Offset: 0x0048AF94
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

		// Token: 0x06020E3B RID: 134715 RVA: 0x0048CDD1 File Offset: 0x0048AFD1
		public static Offset<IQuestStateEqualCondition> CreateIQuestStateEqualCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, EQuestState State = EQuestState.InActive, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			IQuestStateEqualCondition.AddQuestId(builder, QuestId);
			IQuestStateEqualCondition.AddCompare(builder, Compare);
			IQuestStateEqualCondition.AddState(builder, State);
			IQuestStateEqualCondition.AddType(builder, Type);
			return IQuestStateEqualCondition.EndIQuestStateEqualCondition(builder);
		}

		// Token: 0x06020E3C RID: 134716 RVA: 0x0048CDFD File Offset: 0x0048AFFD
		public static void StartIQuestStateEqualCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020E3D RID: 134717 RVA: 0x0048CE06 File Offset: 0x0048B006
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E3E RID: 134718 RVA: 0x0048CE11 File Offset: 0x0048B011
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x06020E3F RID: 134719 RVA: 0x0048CE1C File Offset: 0x0048B01C
		public static void AddState(FlatBufferBuilder builder, EQuestState state)
		{
			builder.AddByte(2, (byte)state, 0);
		}

		// Token: 0x06020E40 RID: 134720 RVA: 0x0048CE27 File Offset: 0x0048B027
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x06020E41 RID: 134721 RVA: 0x0048CE32 File Offset: 0x0048B032
		public static Offset<IQuestStateEqualCondition> EndIQuestStateEqualCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStateEqualCondition>(builder.EndTable());
		}

		// Token: 0x06020E42 RID: 134722 RVA: 0x0048CE40 File Offset: 0x0048B040
		public IQuestStateEqualConditionT UnPack()
		{
			IQuestStateEqualConditionT questStateEqualConditionT = new IQuestStateEqualConditionT();
			this.UnPackTo(questStateEqualConditionT);
			return questStateEqualConditionT;
		}

		// Token: 0x06020E43 RID: 134723 RVA: 0x0048CE5B File Offset: 0x0048B05B
		public void UnPackTo(IQuestStateEqualConditionT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.State = this.State;
			_o.Compare = this.Compare;
		}

		// Token: 0x06020E44 RID: 134724 RVA: 0x0048CE90 File Offset: 0x0048B090
		public static Offset<IQuestStateEqualCondition> Pack(FlatBufferBuilder builder, IQuestStateEqualConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStateEqualCondition>);
			}
			return IQuestStateEqualCondition.CreateIQuestStateEqualCondition(builder, _o.Type, _o.QuestId, _o.State, _o.Compare);
		}

		// Token: 0x0400E18D RID: 57741
		private Table __p;
	}
}
