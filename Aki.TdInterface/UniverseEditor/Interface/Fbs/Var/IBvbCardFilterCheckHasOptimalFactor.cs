using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A30 RID: 14896
	public struct IBvbCardFilterCheckHasOptimalFactor : IFlatbufferObject
	{
		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x0601426B RID: 82539 RVA: 0x002F25FB File Offset: 0x002F07FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601426C RID: 82540 RVA: 0x002F2608 File Offset: 0x002F0808
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601426D RID: 82541 RVA: 0x002F2610 File Offset: 0x002F0810
		public static IBvbCardFilterCheckHasOptimalFactor GetRootAsIBvbCardFilterCheckHasOptimalFactor(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckHasOptimalFactor.GetRootAsIBvbCardFilterCheckHasOptimalFactor(_bb, default(IBvbCardFilterCheckHasOptimalFactor));
		}

		// Token: 0x0601426E RID: 82542 RVA: 0x002F262C File Offset: 0x002F082C
		public static IBvbCardFilterCheckHasOptimalFactor GetRootAsIBvbCardFilterCheckHasOptimalFactor(ByteBuffer _bb, IBvbCardFilterCheckHasOptimalFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601426F RID: 82543 RVA: 0x002F2649 File Offset: 0x002F0849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014270 RID: 82544 RVA: 0x002F2658 File Offset: 0x002F0858
		public IBvbCardFilterCheckHasOptimalFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x06014271 RID: 82545 RVA: 0x002F2668 File Offset: 0x002F0868
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

		// Token: 0x17006615 RID: 26133
		// (get) Token: 0x06014272 RID: 82546 RVA: 0x002F26A4 File Offset: 0x002F08A4
		public TVarRef HandCardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014273 RID: 82547 RVA: 0x002F26E0 File Offset: 0x002F08E0
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014274 RID: 82548 RVA: 0x002F2724 File Offset: 0x002F0924
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06014275 RID: 82549 RVA: 0x002F2740 File Offset: 0x002F0940
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06014276 RID: 82550 RVA: 0x002F275C File Offset: 0x002F095C
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06014277 RID: 82551 RVA: 0x002F2778 File Offset: 0x002F0978
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06014278 RID: 82552 RVA: 0x002F2794 File Offset: 0x002F0994
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x06014279 RID: 82553 RVA: 0x002F27AF File Offset: 0x002F09AF
		public static Offset<IBvbCardFilterCheckHasOptimalFactor> CreateIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbCardFilterCheckHasOptimalFactor.AddHandCard(builder, HandCardOffset);
			IBvbCardFilterCheckHasOptimalFactor.AddHandCardType(builder, HandCard_type);
			IBvbCardFilterCheckHasOptimalFactor.AddType(builder, Type);
			return IBvbCardFilterCheckHasOptimalFactor.EndIBvbCardFilterCheckHasOptimalFactor(builder);
		}

		// Token: 0x0601427A RID: 82554 RVA: 0x002F27D3 File Offset: 0x002F09D3
		public static void StartIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601427B RID: 82555 RVA: 0x002F27DC File Offset: 0x002F09DC
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601427C RID: 82556 RVA: 0x002F27E7 File Offset: 0x002F09E7
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0601427D RID: 82557 RVA: 0x002F27F2 File Offset: 0x002F09F2
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0601427E RID: 82558 RVA: 0x002F27FD File Offset: 0x002F09FD
		public static Offset<IBvbCardFilterCheckHasOptimalFactor> EndIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckHasOptimalFactor>(builder.EndTable());
		}

		// Token: 0x0601427F RID: 82559 RVA: 0x002F280C File Offset: 0x002F0A0C
		public IBvbCardFilterCheckHasOptimalFactorT UnPack()
		{
			IBvbCardFilterCheckHasOptimalFactorT bvbCardFilterCheckHasOptimalFactorT = new IBvbCardFilterCheckHasOptimalFactorT();
			this.UnPackTo(bvbCardFilterCheckHasOptimalFactorT);
			return bvbCardFilterCheckHasOptimalFactorT;
		}

		// Token: 0x06014280 RID: 82560 RVA: 0x002F2828 File Offset: 0x002F0A28
		public void UnPackTo(IBvbCardFilterCheckHasOptimalFactorT _o)
		{
			_o.Type = this.Type;
			_o.HandCard = new TVarRefUnion();
			_o.HandCard.Type = this.HandCardType;
			switch (this.HandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.HandCard.Value = ((this.HandCard<IConstVarRef>() != null) ? this.HandCard<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.HandCard.Value = ((this.HandCard<IGlobalVarRef>() != null) ? this.HandCard<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.HandCard.Value = ((this.HandCard<IOtherVarRef>() != null) ? this.HandCard<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.HandCard.Value = ((this.HandCard<ISelfVarRef>() != null) ? this.HandCard<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.HandCard.Value = ((this.HandCard<ISystemVarRef>() != null) ? this.HandCard<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06014281 RID: 82561 RVA: 0x002F2994 File Offset: 0x002F0B94
		public static Offset<IBvbCardFilterCheckHasOptimalFactor> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckHasOptimalFactorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckHasOptimalFactor>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			return IBvbCardFilterCheckHasOptimalFactor.CreateIBvbCardFilterCheckHasOptimalFactor(builder, _o.Type, handCard_type, handCardOffset);
		}

		// Token: 0x0400AEAF RID: 44719
		private Table __p;
	}
}
