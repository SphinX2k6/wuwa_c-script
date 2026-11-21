using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE7 RID: 20199
	public struct ICheckFishingCageFillingRatio : IFlatbufferObject
	{
		// Token: 0x17009038 RID: 36920
		// (get) Token: 0x0601F5B4 RID: 128436 RVA: 0x0045E6FC File Offset: 0x0045C8FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x0045E709 File Offset: 0x0045C909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F5B6 RID: 128438 RVA: 0x0045E710 File Offset: 0x0045C910
		public static ICheckFishingCageFillingRatio GetRootAsICheckFishingCageFillingRatio(ByteBuffer _bb)
		{
			return ICheckFishingCageFillingRatio.GetRootAsICheckFishingCageFillingRatio(_bb, default(ICheckFishingCageFillingRatio));
		}

		// Token: 0x0601F5B7 RID: 128439 RVA: 0x0045E72C File Offset: 0x0045C92C
		public static ICheckFishingCageFillingRatio GetRootAsICheckFishingCageFillingRatio(ByteBuffer _bb, ICheckFishingCageFillingRatio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x0045E749 File Offset: 0x0045C949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x0045E758 File Offset: 0x0045C958
		public ICheckFishingCageFillingRatio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009039 RID: 36921
		// (get) Token: 0x0601F5BA RID: 128442 RVA: 0x0045E768 File Offset: 0x0045C968
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

		// Token: 0x1700903A RID: 36922
		// (get) Token: 0x0601F5BB RID: 128443 RVA: 0x0045E7A4 File Offset: 0x0045C9A4
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

		// Token: 0x1700903B RID: 36923
		// (get) Token: 0x0601F5BC RID: 128444 RVA: 0x0045E7E0 File Offset: 0x0045C9E0
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

		// Token: 0x0601F5BD RID: 128445 RVA: 0x0045E81C File Offset: 0x0045CA1C
		public static Offset<ICheckFishingCageFillingRatio> CreateICheckFishingCageFillingRatio(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Ratio = 0)
		{
			builder.StartTable(3);
			ICheckFishingCageFillingRatio.AddRatio(builder, Ratio);
			ICheckFishingCageFillingRatio.AddCompare(builder, Compare);
			ICheckFishingCageFillingRatio.AddType(builder, Type);
			return ICheckFishingCageFillingRatio.EndICheckFishingCageFillingRatio(builder);
		}

		// Token: 0x0601F5BE RID: 128446 RVA: 0x0045E840 File Offset: 0x0045CA40
		public static void StartICheckFishingCageFillingRatio(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F5BF RID: 128447 RVA: 0x0045E849 File Offset: 0x0045CA49
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F5C0 RID: 128448 RVA: 0x0045E854 File Offset: 0x0045CA54
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F5C1 RID: 128449 RVA: 0x0045E85F File Offset: 0x0045CA5F
		public static void AddRatio(FlatBufferBuilder builder, int ratio)
		{
			builder.AddInt(2, ratio, 0);
		}

		// Token: 0x0601F5C2 RID: 128450 RVA: 0x0045E86A File Offset: 0x0045CA6A
		public static Offset<ICheckFishingCageFillingRatio> EndICheckFishingCageFillingRatio(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFishingCageFillingRatio>(builder.EndTable());
		}

		// Token: 0x0601F5C3 RID: 128451 RVA: 0x0045E878 File Offset: 0x0045CA78
		public ICheckFishingCageFillingRatioT UnPack()
		{
			ICheckFishingCageFillingRatioT checkFishingCageFillingRatioT = new ICheckFishingCageFillingRatioT();
			this.UnPackTo(checkFishingCageFillingRatioT);
			return checkFishingCageFillingRatioT;
		}

		// Token: 0x0601F5C4 RID: 128452 RVA: 0x0045E893 File Offset: 0x0045CA93
		public void UnPackTo(ICheckFishingCageFillingRatioT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Ratio = this.Ratio;
		}

		// Token: 0x0601F5C5 RID: 128453 RVA: 0x0045E8BC File Offset: 0x0045CABC
		public static Offset<ICheckFishingCageFillingRatio> Pack(FlatBufferBuilder builder, ICheckFishingCageFillingRatioT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFishingCageFillingRatio>);
			}
			return ICheckFishingCageFillingRatio.CreateICheckFishingCageFillingRatio(builder, _o.Type, _o.Compare, _o.Ratio);
		}

		// Token: 0x0400DD4C RID: 56652
		private Table __p;
	}
}
