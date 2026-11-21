using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E1A RID: 15898
	public struct IBvbCardFilterCompareCost : IFlatbufferObject
	{
		// Token: 0x17006B5C RID: 27484
		// (get) Token: 0x060155FC RID: 87548 RVA: 0x00316472 File Offset: 0x00314672
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155FD RID: 87549 RVA: 0x0031647F File Offset: 0x0031467F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155FE RID: 87550 RVA: 0x00316488 File Offset: 0x00314688
		public static IBvbCardFilterCompareCost GetRootAsIBvbCardFilterCompareCost(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareCost.GetRootAsIBvbCardFilterCompareCost(_bb, default(IBvbCardFilterCompareCost));
		}

		// Token: 0x060155FF RID: 87551 RVA: 0x003164A4 File Offset: 0x003146A4
		public static IBvbCardFilterCompareCost GetRootAsIBvbCardFilterCompareCost(ByteBuffer _bb, IBvbCardFilterCompareCost obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015600 RID: 87552 RVA: 0x003164C1 File Offset: 0x003146C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015601 RID: 87553 RVA: 0x003164D0 File Offset: 0x003146D0
		public IBvbCardFilterCompareCost __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B5D RID: 27485
		// (get) Token: 0x06015602 RID: 87554 RVA: 0x003164E0 File Offset: 0x003146E0
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

		// Token: 0x17006B5E RID: 27486
		// (get) Token: 0x06015603 RID: 87555 RVA: 0x0031651C File Offset: 0x0031471C
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

		// Token: 0x17006B5F RID: 27487
		// (get) Token: 0x06015604 RID: 87556 RVA: 0x00316558 File Offset: 0x00314758
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

		// Token: 0x06015605 RID: 87557 RVA: 0x00316594 File Offset: 0x00314794
		public static Offset<IBvbCardFilterCompareCost> CreateIBvbCardFilterCompareCost(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, EVarCompare CompareType = EVarCompare.Eq, int Cost = 0)
		{
			builder.StartTable(3);
			IBvbCardFilterCompareCost.AddCost(builder, Cost);
			IBvbCardFilterCompareCost.AddCompareType(builder, CompareType);
			IBvbCardFilterCompareCost.AddType(builder, Type);
			return IBvbCardFilterCompareCost.EndIBvbCardFilterCompareCost(builder);
		}

		// Token: 0x06015606 RID: 87558 RVA: 0x003165B8 File Offset: 0x003147B8
		public static void StartIBvbCardFilterCompareCost(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015607 RID: 87559 RVA: 0x003165C1 File Offset: 0x003147C1
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015608 RID: 87560 RVA: 0x003165CC File Offset: 0x003147CC
		public static void AddCompareType(FlatBufferBuilder builder, EVarCompare compareType)
		{
			builder.AddByte(1, (byte)compareType, 0);
		}

		// Token: 0x06015609 RID: 87561 RVA: 0x003165D7 File Offset: 0x003147D7
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(2, cost, 0);
		}

		// Token: 0x0601560A RID: 87562 RVA: 0x003165E2 File Offset: 0x003147E2
		public static Offset<IBvbCardFilterCompareCost> EndIBvbCardFilterCompareCost(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareCost>(builder.EndTable());
		}

		// Token: 0x0601560B RID: 87563 RVA: 0x003165F0 File Offset: 0x003147F0
		public IBvbCardFilterCompareCostT UnPack()
		{
			IBvbCardFilterCompareCostT bvbCardFilterCompareCostT = new IBvbCardFilterCompareCostT();
			this.UnPackTo(bvbCardFilterCompareCostT);
			return bvbCardFilterCompareCostT;
		}

		// Token: 0x0601560C RID: 87564 RVA: 0x0031660B File Offset: 0x0031480B
		public void UnPackTo(IBvbCardFilterCompareCostT _o)
		{
			_o.Type = this.Type;
			_o.CompareType = this.CompareType;
			_o.Cost = this.Cost;
		}

		// Token: 0x0601560D RID: 87565 RVA: 0x00316634 File Offset: 0x00314834
		public static Offset<IBvbCardFilterCompareCost> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareCostT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareCost>);
			}
			return IBvbCardFilterCompareCost.CreateIBvbCardFilterCompareCost(builder, _o.Type, _o.CompareType, _o.Cost);
		}

		// Token: 0x0400B7E0 RID: 47072
		private Table __p;
	}
}
