using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B2 RID: 20658
	public struct ICompareTeammateDieCondition : IFlatbufferObject
	{
		// Token: 0x17009402 RID: 37890
		// (get) Token: 0x0602058B RID: 132491 RVA: 0x0047AD54 File Offset: 0x00478F54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602058C RID: 132492 RVA: 0x0047AD61 File Offset: 0x00478F61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602058D RID: 132493 RVA: 0x0047AD68 File Offset: 0x00478F68
		public static ICompareTeammateDieCondition GetRootAsICompareTeammateDieCondition(ByteBuffer _bb)
		{
			return ICompareTeammateDieCondition.GetRootAsICompareTeammateDieCondition(_bb, default(ICompareTeammateDieCondition));
		}

		// Token: 0x0602058E RID: 132494 RVA: 0x0047AD84 File Offset: 0x00478F84
		public static ICompareTeammateDieCondition GetRootAsICompareTeammateDieCondition(ByteBuffer _bb, ICompareTeammateDieCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602058F RID: 132495 RVA: 0x0047ADA1 File Offset: 0x00478FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020590 RID: 132496 RVA: 0x0047ADB0 File Offset: 0x00478FB0
		public ICompareTeammateDieCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009403 RID: 37891
		// (get) Token: 0x06020591 RID: 132497 RVA: 0x0047ADC0 File Offset: 0x00478FC0
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

		// Token: 0x17009404 RID: 37892
		// (get) Token: 0x06020592 RID: 132498 RVA: 0x0047ADFC File Offset: 0x00478FFC
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

		// Token: 0x17009405 RID: 37893
		// (get) Token: 0x06020593 RID: 132499 RVA: 0x0047AE38 File Offset: 0x00479038
		public int DieCount
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

		// Token: 0x06020594 RID: 132500 RVA: 0x0047AE74 File Offset: 0x00479074
		public static Offset<ICompareTeammateDieCondition> CreateICompareTeammateDieCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int DieCount = 0)
		{
			builder.StartTable(3);
			ICompareTeammateDieCondition.AddDieCount(builder, DieCount);
			ICompareTeammateDieCondition.AddCompare(builder, Compare);
			ICompareTeammateDieCondition.AddType(builder, Type);
			return ICompareTeammateDieCondition.EndICompareTeammateDieCondition(builder);
		}

		// Token: 0x06020595 RID: 132501 RVA: 0x0047AE98 File Offset: 0x00479098
		public static void StartICompareTeammateDieCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020596 RID: 132502 RVA: 0x0047AEA1 File Offset: 0x004790A1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x0047AEAC File Offset: 0x004790AC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x0047AEB7 File Offset: 0x004790B7
		public static void AddDieCount(FlatBufferBuilder builder, int dieCount)
		{
			builder.AddInt(2, dieCount, 0);
		}

		// Token: 0x06020599 RID: 132505 RVA: 0x0047AEC2 File Offset: 0x004790C2
		public static Offset<ICompareTeammateDieCondition> EndICompareTeammateDieCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareTeammateDieCondition>(builder.EndTable());
		}

		// Token: 0x0602059A RID: 132506 RVA: 0x0047AED0 File Offset: 0x004790D0
		public ICompareTeammateDieConditionT UnPack()
		{
			ICompareTeammateDieConditionT compareTeammateDieConditionT = new ICompareTeammateDieConditionT();
			this.UnPackTo(compareTeammateDieConditionT);
			return compareTeammateDieConditionT;
		}

		// Token: 0x0602059B RID: 132507 RVA: 0x0047AEEB File Offset: 0x004790EB
		public void UnPackTo(ICompareTeammateDieConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.DieCount = this.DieCount;
		}

		// Token: 0x0602059C RID: 132508 RVA: 0x0047AF14 File Offset: 0x00479114
		public static Offset<ICompareTeammateDieCondition> Pack(FlatBufferBuilder builder, ICompareTeammateDieConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareTeammateDieCondition>);
			}
			return ICompareTeammateDieCondition.CreateICompareTeammateDieCondition(builder, _o.Type, _o.Compare, _o.DieCount);
		}

		// Token: 0x0400DFBB RID: 57275
		private Table __p;
	}
}
