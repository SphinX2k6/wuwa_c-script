using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BAD RID: 19373
	public struct ICompareLevelPlayRewardStateCondition : IFlatbufferObject
	{
		// Token: 0x17008CA4 RID: 36004
		// (get) Token: 0x0601E8D8 RID: 125144 RVA: 0x00446378 File Offset: 0x00444578
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8D9 RID: 125145 RVA: 0x00446385 File Offset: 0x00444585
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8DA RID: 125146 RVA: 0x0044638C File Offset: 0x0044458C
		public static ICompareLevelPlayRewardStateCondition GetRootAsICompareLevelPlayRewardStateCondition(ByteBuffer _bb)
		{
			return ICompareLevelPlayRewardStateCondition.GetRootAsICompareLevelPlayRewardStateCondition(_bb, default(ICompareLevelPlayRewardStateCondition));
		}

		// Token: 0x0601E8DB RID: 125147 RVA: 0x004463A8 File Offset: 0x004445A8
		public static ICompareLevelPlayRewardStateCondition GetRootAsICompareLevelPlayRewardStateCondition(ByteBuffer _bb, ICompareLevelPlayRewardStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8DC RID: 125148 RVA: 0x004463C5 File Offset: 0x004445C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8DD RID: 125149 RVA: 0x004463D4 File Offset: 0x004445D4
		public ICompareLevelPlayRewardStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CA5 RID: 36005
		// (get) Token: 0x0601E8DE RID: 125150 RVA: 0x004463E4 File Offset: 0x004445E4
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

		// Token: 0x17008CA6 RID: 36006
		// (get) Token: 0x0601E8DF RID: 125151 RVA: 0x00446420 File Offset: 0x00444620
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

		// Token: 0x0601E8E0 RID: 125152 RVA: 0x0044645C File Offset: 0x0044465C
		public static Offset<ICompareLevelPlayRewardStateCondition> CreateICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			ICompareLevelPlayRewardStateCondition.AddCompare(builder, Compare);
			ICompareLevelPlayRewardStateCondition.AddType(builder, Type);
			return ICompareLevelPlayRewardStateCondition.EndICompareLevelPlayRewardStateCondition(builder);
		}

		// Token: 0x0601E8E1 RID: 125153 RVA: 0x00446479 File Offset: 0x00444679
		public static void StartICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E8E2 RID: 125154 RVA: 0x00446482 File Offset: 0x00444682
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E8E3 RID: 125155 RVA: 0x0044648D File Offset: 0x0044468D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E8E4 RID: 125156 RVA: 0x00446498 File Offset: 0x00444698
		public static Offset<ICompareLevelPlayRewardStateCondition> EndICompareLevelPlayRewardStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareLevelPlayRewardStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E8E5 RID: 125157 RVA: 0x004464A8 File Offset: 0x004446A8
		public ICompareLevelPlayRewardStateConditionT UnPack()
		{
			ICompareLevelPlayRewardStateConditionT compareLevelPlayRewardStateConditionT = new ICompareLevelPlayRewardStateConditionT();
			this.UnPackTo(compareLevelPlayRewardStateConditionT);
			return compareLevelPlayRewardStateConditionT;
		}

		// Token: 0x0601E8E6 RID: 125158 RVA: 0x004464C3 File Offset: 0x004446C3
		public void UnPackTo(ICompareLevelPlayRewardStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E8E7 RID: 125159 RVA: 0x004464E0 File Offset: 0x004446E0
		public static Offset<ICompareLevelPlayRewardStateCondition> Pack(FlatBufferBuilder builder, ICompareLevelPlayRewardStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareLevelPlayRewardStateCondition>);
			}
			return ICompareLevelPlayRewardStateCondition.CreateICompareLevelPlayRewardStateCondition(builder, _o.Type, _o.Compare);
		}

		// Token: 0x0400D48F RID: 54415
		private Table __p;
	}
}
