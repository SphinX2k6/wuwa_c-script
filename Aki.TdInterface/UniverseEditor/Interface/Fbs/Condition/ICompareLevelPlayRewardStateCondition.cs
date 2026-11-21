using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005097 RID: 20631
	public struct ICompareLevelPlayRewardStateCondition : IFlatbufferObject
	{
		// Token: 0x170093BD RID: 37821
		// (get) Token: 0x06020484 RID: 132228 RVA: 0x00478EDC File Offset: 0x004770DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020485 RID: 132229 RVA: 0x00478EE9 File Offset: 0x004770E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020486 RID: 132230 RVA: 0x00478EF0 File Offset: 0x004770F0
		public static ICompareLevelPlayRewardStateCondition GetRootAsICompareLevelPlayRewardStateCondition(ByteBuffer _bb)
		{
			return ICompareLevelPlayRewardStateCondition.GetRootAsICompareLevelPlayRewardStateCondition(_bb, default(ICompareLevelPlayRewardStateCondition));
		}

		// Token: 0x06020487 RID: 132231 RVA: 0x00478F0C File Offset: 0x0047710C
		public static ICompareLevelPlayRewardStateCondition GetRootAsICompareLevelPlayRewardStateCondition(ByteBuffer _bb, ICompareLevelPlayRewardStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020488 RID: 132232 RVA: 0x00478F29 File Offset: 0x00477129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020489 RID: 132233 RVA: 0x00478F38 File Offset: 0x00477138
		public ICompareLevelPlayRewardStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093BE RID: 37822
		// (get) Token: 0x0602048A RID: 132234 RVA: 0x00478F48 File Offset: 0x00477148
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

		// Token: 0x170093BF RID: 37823
		// (get) Token: 0x0602048B RID: 132235 RVA: 0x00478F84 File Offset: 0x00477184
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602048C RID: 132236 RVA: 0x00478FC0 File Offset: 0x004771C0
		public static Offset<ICompareLevelPlayRewardStateCondition> CreateICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			ICompareLevelPlayRewardStateCondition.AddCompare(builder, Compare);
			ICompareLevelPlayRewardStateCondition.AddType(builder, Type);
			return ICompareLevelPlayRewardStateCondition.EndICompareLevelPlayRewardStateCondition(builder);
		}

		// Token: 0x0602048D RID: 132237 RVA: 0x00478FDD File Offset: 0x004771DD
		public static void StartICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602048E RID: 132238 RVA: 0x00478FE6 File Offset: 0x004771E6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602048F RID: 132239 RVA: 0x00478FF1 File Offset: 0x004771F1
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020490 RID: 132240 RVA: 0x00478FFC File Offset: 0x004771FC
		public static Offset<ICompareLevelPlayRewardStateCondition> EndICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareLevelPlayRewardStateCondition>(builder.EndTable());
		}

		// Token: 0x06020491 RID: 132241 RVA: 0x0047900C File Offset: 0x0047720C
		public ICompareLevelPlayRewardStateConditionT UnPack()
		{
			ICompareLevelPlayRewardStateConditionT compareLevelPlayRewardStateConditionT = new ICompareLevelPlayRewardStateConditionT();
			this.UnPackTo(compareLevelPlayRewardStateConditionT);
			return compareLevelPlayRewardStateConditionT;
		}

		// Token: 0x06020492 RID: 132242 RVA: 0x00479027 File Offset: 0x00477227
		public void UnPackTo(ICompareLevelPlayRewardStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
		}

		// Token: 0x06020493 RID: 132243 RVA: 0x00479044 File Offset: 0x00477244
		public static Offset<ICompareLevelPlayRewardStateCondition> Pack(FlatBufferBuilder builder, ICompareLevelPlayRewardStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareLevelPlayRewardStateCondition>);
			}
			return ICompareLevelPlayRewardStateCondition.CreateICompareLevelPlayRewardStateCondition(builder, _o.Type, _o.Compare);
		}

		// Token: 0x0400DF94 RID: 57236
		private Table __p;
	}
}
