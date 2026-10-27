using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A3F RID: 14911
	public struct IBvbCardFilterCompareCost : IFlatbufferObject
	{
		// Token: 0x1700662C RID: 26156
		// (get) Token: 0x060142E0 RID: 82656 RVA: 0x002F3286 File Offset: 0x002F1486
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060142E1 RID: 82657 RVA: 0x002F3293 File Offset: 0x002F1493
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060142E2 RID: 82658 RVA: 0x002F329C File Offset: 0x002F149C
		public static IBvbCardFilterCompareCost GetRootAsIBvbCardFilterCompareCost(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareCost.GetRootAsIBvbCardFilterCompareCost(_bb, default(IBvbCardFilterCompareCost));
		}

		// Token: 0x060142E3 RID: 82659 RVA: 0x002F32B8 File Offset: 0x002F14B8
		public static IBvbCardFilterCompareCost GetRootAsIBvbCardFilterCompareCost(ByteBuffer _bb, IBvbCardFilterCompareCost obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060142E4 RID: 82660 RVA: 0x002F32D5 File Offset: 0x002F14D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060142E5 RID: 82661 RVA: 0x002F32E4 File Offset: 0x002F14E4
		public IBvbCardFilterCompareCost __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700662D RID: 26157
		// (get) Token: 0x060142E6 RID: 82662 RVA: 0x002F32F4 File Offset: 0x002F14F4
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700662E RID: 26158
		// (get) Token: 0x060142E7 RID: 82663 RVA: 0x002F3330 File Offset: 0x002F1530
		public EVarCompare CompareType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarCompare.Eq;
				}
				return (EVarCompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x060142E8 RID: 82664 RVA: 0x002F336C File Offset: 0x002F156C
		public int Cost
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

		// Token: 0x060142E9 RID: 82665 RVA: 0x002F33A8 File Offset: 0x002F15A8
		public static Offset<IBvbCardFilterCompareCost> CreateIBvbCardFilterCompareCost(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, EVarCompare CompareType = EVarCompare.Eq, int Cost = 0)
		{
			builder.StartTable(3);
			IBvbCardFilterCompareCost.AddCost(builder, Cost);
			IBvbCardFilterCompareCost.AddCompareType(builder, CompareType);
			IBvbCardFilterCompareCost.AddType(builder, Type);
			return IBvbCardFilterCompareCost.EndIBvbCardFilterCompareCost(builder);
		}

		// Token: 0x060142EA RID: 82666 RVA: 0x002F33CC File Offset: 0x002F15CC
		public static void StartIBvbCardFilterCompareCost(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060142EB RID: 82667 RVA: 0x002F33D5 File Offset: 0x002F15D5
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060142EC RID: 82668 RVA: 0x002F33E0 File Offset: 0x002F15E0
		public static void AddCompareType(FlatBufferBuilder builder, EVarCompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x060142ED RID: 82669 RVA: 0x002F33EB File Offset: 0x002F15EB
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(2, cost, 0);
		}

		// Token: 0x060142EE RID: 82670 RVA: 0x002F33F6 File Offset: 0x002F15F6
		public static Offset<IBvbCardFilterCompareCost> EndIBvbCardFilterCompareCost(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareCost>(builder.EndTable());
		}

		// Token: 0x060142EF RID: 82671 RVA: 0x002F3404 File Offset: 0x002F1604
		public IBvbCardFilterCompareCostT UnPack()
		{
			IBvbCardFilterCompareCostT bvbCardFilterCompareCostT = new IBvbCardFilterCompareCostT();
			this.UnPackTo(bvbCardFilterCompareCostT);
			return bvbCardFilterCompareCostT;
		}

		// Token: 0x060142F0 RID: 82672 RVA: 0x002F341F File Offset: 0x002F161F
		public void UnPackTo(IBvbCardFilterCompareCostT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Cost = this.Cost;
		}

		// Token: 0x060142F1 RID: 82673 RVA: 0x002F3448 File Offset: 0x002F1648
		public static Offset<IBvbCardFilterCompareCost> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareCostT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareCost>);
			}
			return IBvbCardFilterCompareCost.CreateIBvbCardFilterCompareCost(builder, _o.Type, _o.CompareType, _o.Cost);
		}

		// Token: 0x0400AEBE RID: 44734
		private Table __p;
	}
}
