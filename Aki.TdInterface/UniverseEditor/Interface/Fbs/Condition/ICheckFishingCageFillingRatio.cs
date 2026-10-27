using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A24 RID: 18980
	public struct ICheckFishingCageFillingRatio : IFlatbufferObject
	{
		// Token: 0x17008963 RID: 35171
		// (get) Token: 0x0601DB2B RID: 121643 RVA: 0x0042D804 File Offset: 0x0042BA04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB2C RID: 121644 RVA: 0x0042D811 File Offset: 0x0042BA11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB2D RID: 121645 RVA: 0x0042D818 File Offset: 0x0042BA18
		public static ICheckFishingCageFillingRatio GetRootAsICheckFishingCageFillingRatio(ByteBuffer _bb)
		{
			return ICheckFishingCageFillingRatio.GetRootAsICheckFishingCageFillingRatio(_bb, default(ICheckFishingCageFillingRatio));
		}

		// Token: 0x0601DB2E RID: 121646 RVA: 0x0042D834 File Offset: 0x0042BA34
		public static ICheckFishingCageFillingRatio GetRootAsICheckFishingCageFillingRatio(ByteBuffer _bb, ICheckFishingCageFillingRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB2F RID: 121647 RVA: 0x0042D851 File Offset: 0x0042BA51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x0042D860 File Offset: 0x0042BA60
		public ICheckFishingCageFillingRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008964 RID: 35172
		// (get) Token: 0x0601DB31 RID: 121649 RVA: 0x0042D870 File Offset: 0x0042BA70
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

		// Token: 0x17008965 RID: 35173
		// (get) Token: 0x0601DB32 RID: 121650 RVA: 0x0042D8AC File Offset: 0x0042BAAC
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

		// Token: 0x17008966 RID: 35174
		// (get) Token: 0x0601DB33 RID: 121651 RVA: 0x0042D8E8 File Offset: 0x0042BAE8
		public int Ratio
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

		// Token: 0x0601DB34 RID: 121652 RVA: 0x0042D924 File Offset: 0x0042BB24
		public static Offset<ICheckFishingCageFillingRatio> CreateICheckFishingCageFillingRatio(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Ratio = 0)
		{
			builder.StartTable(3);
			ICheckFishingCageFillingRatio.AddRatio(builder, Ratio);
			ICheckFishingCageFillingRatio.AddCompare(builder, Compare);
			ICheckFishingCageFillingRatio.AddType(builder, Type);
			return ICheckFishingCageFillingRatio.EndICheckFishingCageFillingRatio(builder);
		}

		// Token: 0x0601DB35 RID: 121653 RVA: 0x0042D948 File Offset: 0x0042BB48
		public static void StartICheckFishingCageFillingRatio(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DB36 RID: 121654 RVA: 0x0042D951 File Offset: 0x0042BB51
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB37 RID: 121655 RVA: 0x0042D95C File Offset: 0x0042BB5C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601DB38 RID: 121656 RVA: 0x0042D967 File Offset: 0x0042BB67
		public static void AddRatio(FlatBufferBuilder builder, int ratio)
		{
			builder.AddInt(2, ratio, 0);
		}

		// Token: 0x0601DB39 RID: 121657 RVA: 0x0042D972 File Offset: 0x0042BB72
		public static Offset<ICheckFishingCageFillingRatio> EndICheckFishingCageFillingRatio(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFishingCageFillingRatio>(builder.EndTable());
		}

		// Token: 0x0601DB3A RID: 121658 RVA: 0x0042D980 File Offset: 0x0042BB80
		public ICheckFishingCageFillingRatioT UnPack()
		{
			ICheckFishingCageFillingRatioT checkFishingCageFillingRatioT = new ICheckFishingCageFillingRatioT();
			this.UnPackTo(checkFishingCageFillingRatioT);
			return checkFishingCageFillingRatioT;
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x0042D99B File Offset: 0x0042BB9B
		public void UnPackTo(ICheckFishingCageFillingRatioT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Ratio = this.Ratio;
		}

		// Token: 0x0601DB3C RID: 121660 RVA: 0x0042D9C4 File Offset: 0x0042BBC4
		public static Offset<ICheckFishingCageFillingRatio> Pack(FlatBufferBuilder builder, ICheckFishingCageFillingRatioT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFishingCageFillingRatio>);
			}
			return ICheckFishingCageFillingRatio.CreateICheckFishingCageFillingRatio(builder, _o.Type, _o.Compare, _o.Ratio);
		}

		// Token: 0x0400D275 RID: 53877
		private Table __p;
	}
}
