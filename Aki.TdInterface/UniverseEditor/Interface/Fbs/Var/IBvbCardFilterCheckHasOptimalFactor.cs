using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E0B RID: 15883
	public struct IBvbCardFilterCheckHasOptimalFactor : IFlatbufferObject
	{
		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x06015587 RID: 87431 RVA: 0x003157E7 File Offset: 0x003139E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015588 RID: 87432 RVA: 0x003157F4 File Offset: 0x003139F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015589 RID: 87433 RVA: 0x003157FC File Offset: 0x003139FC
		public static IBvbCardFilterCheckHasOptimalFactor GetRootAsIBvbCardFilterCheckHasOptimalFactor(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckHasOptimalFactor.GetRootAsIBvbCardFilterCheckHasOptimalFactor(_bb, default(IBvbCardFilterCheckHasOptimalFactor));
		}

		// Token: 0x0601558A RID: 87434 RVA: 0x00315818 File Offset: 0x00313A18
		public static IBvbCardFilterCheckHasOptimalFactor GetRootAsIBvbCardFilterCheckHasOptimalFactor(ByteBuffer _bb, IBvbCardFilterCheckHasOptimalFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601558B RID: 87435 RVA: 0x00315835 File Offset: 0x00313A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601558C RID: 87436 RVA: 0x00315844 File Offset: 0x00313A44
		public IBvbCardFilterCheckHasOptimalFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x0601558D RID: 87437 RVA: 0x00315854 File Offset: 0x00313A54
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

		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x0601558E RID: 87438 RVA: 0x00315890 File Offset: 0x00313A90
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

		// Token: 0x0601558F RID: 87439 RVA: 0x003158CC File Offset: 0x00313ACC
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015590 RID: 87440 RVA: 0x00315910 File Offset: 0x00313B10
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06015591 RID: 87441 RVA: 0x0031592C File Offset: 0x00313B2C
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06015592 RID: 87442 RVA: 0x00315948 File Offset: 0x00313B48
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06015593 RID: 87443 RVA: 0x00315964 File Offset: 0x00313B64
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06015594 RID: 87444 RVA: 0x00315980 File Offset: 0x00313B80
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x06015595 RID: 87445 RVA: 0x0031599B File Offset: 0x00313B9B
		public static Offset<IBvbCardFilterCheckHasOptimalFactor> CreateIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbCardFilterCheckHasOptimalFactor.AddHandCard(builder, HandCardOffset);
			IBvbCardFilterCheckHasOptimalFactor.AddHandCardType(builder, HandCard_type);
			IBvbCardFilterCheckHasOptimalFactor.AddType(builder, Type);
			return IBvbCardFilterCheckHasOptimalFactor.EndIBvbCardFilterCheckHasOptimalFactor(builder);
		}

		// Token: 0x06015596 RID: 87446 RVA: 0x003159BF File Offset: 0x00313BBF
		public static void StartIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015597 RID: 87447 RVA: 0x003159C8 File Offset: 0x00313BC8
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015598 RID: 87448 RVA: 0x003159D3 File Offset: 0x00313BD3
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06015599 RID: 87449 RVA: 0x003159DE File Offset: 0x00313BDE
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0601559A RID: 87450 RVA: 0x003159E9 File Offset: 0x00313BE9
		public static Offset<IBvbCardFilterCheckHasOptimalFactor> EndIBvbCardFilterCheckHasOptimalFactor(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckHasOptimalFactor>(builder.EndTable());
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x003159F8 File Offset: 0x00313BF8
		public IBvbCardFilterCheckHasOptimalFactorT UnPack()
		{
			IBvbCardFilterCheckHasOptimalFactorT bvbCardFilterCheckHasOptimalFactorT = new IBvbCardFilterCheckHasOptimalFactorT();
			this.UnPackTo(bvbCardFilterCheckHasOptimalFactorT);
			return bvbCardFilterCheckHasOptimalFactorT;
		}

		// Token: 0x0601559C RID: 87452 RVA: 0x00315A14 File Offset: 0x00313C14
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

		// Token: 0x0601559D RID: 87453 RVA: 0x00315B80 File Offset: 0x00313D80
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

		// Token: 0x0400B7D1 RID: 47057
		private Table __p;
	}
}
