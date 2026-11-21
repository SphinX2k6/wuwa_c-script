using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0F RID: 23567
	public struct INpcUiInteractOnChengXiaoShanShop : IFlatbufferObject
	{
		// Token: 0x1700AC97 RID: 44183
		// (get) Token: 0x06026F52 RID: 159570 RVA: 0x00555582 File Offset: 0x00553782
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F53 RID: 159571 RVA: 0x0055558F File Offset: 0x0055378F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F54 RID: 159572 RVA: 0x00555598 File Offset: 0x00553798
		public static INpcUiInteractOnChengXiaoShanShop GetRootAsINpcUiInteractOnChengXiaoShanShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnChengXiaoShanShop.GetRootAsINpcUiInteractOnChengXiaoShanShop(_bb, default(INpcUiInteractOnChengXiaoShanShop));
		}

		// Token: 0x06026F55 RID: 159573 RVA: 0x005555B4 File Offset: 0x005537B4
		public static INpcUiInteractOnChengXiaoShanShop GetRootAsINpcUiInteractOnChengXiaoShanShop(ByteBuffer _bb, INpcUiInteractOnChengXiaoShanShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F56 RID: 159574 RVA: 0x005555D1 File Offset: 0x005537D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F57 RID: 159575 RVA: 0x005555E0 File Offset: 0x005537E0
		public INpcUiInteractOnChengXiaoShanShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC98 RID: 44184
		// (get) Token: 0x06026F58 RID: 159576 RVA: 0x005555F0 File Offset: 0x005537F0
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC99 RID: 44185
		// (get) Token: 0x06026F59 RID: 159577 RVA: 0x0055562C File Offset: 0x0055382C
		public string EnterMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F5A RID: 159578 RVA: 0x00555663 File Offset: 0x00553863
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026F5B RID: 159579 RVA: 0x00555672 File Offset: 0x00553872
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AC9A RID: 44186
		// (get) Token: 0x06026F5C RID: 159580 RVA: 0x00555680 File Offset: 0x00553880
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F5D RID: 159581 RVA: 0x005556B7 File Offset: 0x005538B7
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026F5E RID: 159582 RVA: 0x005556C6 File Offset: 0x005538C6
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AC9B RID: 44187
		// (get) Token: 0x06026F5F RID: 159583 RVA: 0x005556D4 File Offset: 0x005538D4
		public string ShopSuccessMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F60 RID: 159584 RVA: 0x0055570C File Offset: 0x0055390C
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026F61 RID: 159585 RVA: 0x0055571C File Offset: 0x0055391C
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AC9C RID: 44188
		// (get) Token: 0x06026F62 RID: 159586 RVA: 0x0055572C File Offset: 0x0055392C
		public IPlayFlow? EnterFlow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC9D RID: 44189
		// (get) Token: 0x06026F63 RID: 159587 RVA: 0x0055578C File Offset: 0x0055398C
		public IPlayFlow? ShopSuccessFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC9E RID: 44190
		// (get) Token: 0x06026F64 RID: 159588 RVA: 0x005557EC File Offset: 0x005539EC
		public IPlayFlow? ShopFailedFlow
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC9F RID: 44191
		// (get) Token: 0x06026F65 RID: 159589 RVA: 0x0055584C File Offset: 0x00553A4C
		public string UpgradeSequence
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F66 RID: 159590 RVA: 0x00555884 File Offset: 0x00553A84
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06026F67 RID: 159591 RVA: 0x00555894 File Offset: 0x00553A94
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700ACA0 RID: 44192
		// (get) Token: 0x06026F68 RID: 159592 RVA: 0x005558A4 File Offset: 0x00553AA4
		public string FinishDeliverySequence
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F69 RID: 159593 RVA: 0x005558DC File Offset: 0x00553ADC
		public Span<byte> GetFinishDeliverySequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06026F6A RID: 159594 RVA: 0x005558EC File Offset: 0x00553AEC
		public byte[] GetFinishDeliverySequenceArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700ACA1 RID: 44193
		// (get) Token: 0x06026F6B RID: 159595 RVA: 0x005558FC File Offset: 0x00553AFC
		public bool ShowNpcWhilePlayingSequence
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ACA2 RID: 44194
		// (get) Token: 0x06026F6C RID: 159596 RVA: 0x0055593C File Offset: 0x00553B3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F6D RID: 159597 RVA: 0x0055597C File Offset: 0x00553B7C
		public static Offset<INpcUiInteractOnChengXiaoShanShop> CreateINpcUiInteractOnChengXiaoShanShop(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), StringOffset UpgradeSequenceOffset = default(StringOffset), StringOffset FinishDeliverySequenceOffset = default(StringOffset), bool ShowNpcWhilePlayingSequence = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			INpcUiInteractOnChengXiaoShanShop.AddFinishDeliverySequence(builder, FinishDeliverySequenceOffset);
			INpcUiInteractOnChengXiaoShanShop.AddUpgradeSequence(builder, UpgradeSequenceOffset);
			INpcUiInteractOnChengXiaoShanShop.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnChengXiaoShanShop.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnChengXiaoShanShop.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnChengXiaoShanShop.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnChengXiaoShanShop.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnChengXiaoShanShop.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnChengXiaoShanShop.AddNullMask(builder, NullMask);
			INpcUiInteractOnChengXiaoShanShop.AddShowNpcWhilePlayingSequence(builder, ShowNpcWhilePlayingSequence);
			INpcUiInteractOnChengXiaoShanShop.AddType(builder, Type);
			return INpcUiInteractOnChengXiaoShanShop.EndINpcUiInteractOnChengXiaoShanShop(builder);
		}

		// Token: 0x06026F6E RID: 159598 RVA: 0x005559EC File Offset: 0x00553BEC
		public static void StartINpcUiInteractOnChengXiaoShanShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06026F6F RID: 159599 RVA: 0x005559F6 File Offset: 0x00553BF6
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026F70 RID: 159600 RVA: 0x00555A01 File Offset: 0x00553C01
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06026F71 RID: 159601 RVA: 0x00555A11 File Offset: 0x00553C11
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06026F72 RID: 159602 RVA: 0x00555A21 File Offset: 0x00553C21
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06026F73 RID: 159603 RVA: 0x00555A31 File Offset: 0x00553C31
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06026F74 RID: 159604 RVA: 0x00555A41 File Offset: 0x00553C41
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06026F75 RID: 159605 RVA: 0x00555A51 File Offset: 0x00553C51
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06026F76 RID: 159606 RVA: 0x00555A61 File Offset: 0x00553C61
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06026F77 RID: 159607 RVA: 0x00555A71 File Offset: 0x00553C71
		public static void AddFinishDeliverySequence(FlatBufferBuilder builder, StringOffset finishDeliverySequenceOffset)
		{
			builder.AddOffset(8, finishDeliverySequenceOffset.Value, 0);
		}

		// Token: 0x06026F78 RID: 159608 RVA: 0x00555A81 File Offset: 0x00553C81
		public static void AddShowNpcWhilePlayingSequence(FlatBufferBuilder builder, bool showNpcWhilePlayingSequence)
		{
			builder.AddBool(9, showNpcWhilePlayingSequence, false);
		}

		// Token: 0x06026F79 RID: 159609 RVA: 0x00555A8D File Offset: 0x00553C8D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06026F7A RID: 159610 RVA: 0x00555A99 File Offset: 0x00553C99
		public static Offset<INpcUiInteractOnChengXiaoShanShop> EndINpcUiInteractOnChengXiaoShanShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnChengXiaoShanShop>(builder.EndTable());
		}

		// Token: 0x06026F7B RID: 159611 RVA: 0x00555AA8 File Offset: 0x00553CA8
		public INpcUiInteractOnChengXiaoShanShopT UnPack()
		{
			INpcUiInteractOnChengXiaoShanShopT npcUiInteractOnChengXiaoShanShopT = new INpcUiInteractOnChengXiaoShanShopT();
			this.UnPackTo(npcUiInteractOnChengXiaoShanShopT);
			return npcUiInteractOnChengXiaoShanShopT;
		}

		// Token: 0x06026F7C RID: 159612 RVA: 0x00555AC4 File Offset: 0x00553CC4
		public void UnPackTo(INpcUiInteractOnChengXiaoShanShopT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.ShopSuccessMontage = this.ShopSuccessMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.ShopSuccessFlow = ((this.ShopSuccessFlow != null) ? this.ShopSuccessFlow.Value.UnPack() : null);
			_o.ShopFailedFlow = ((this.ShopFailedFlow != null) ? this.ShopFailedFlow.Value.UnPack() : null);
			_o.UpgradeSequence = this.UpgradeSequence;
			_o.FinishDeliverySequence = this.FinishDeliverySequence;
			_o.ShowNpcWhilePlayingSequence = this.ShowNpcWhilePlayingSequence;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026F7D RID: 159613 RVA: 0x00555BC0 File Offset: 0x00553DC0
		public static Offset<INpcUiInteractOnChengXiaoShanShop> Pack(FlatBufferBuilder builder, INpcUiInteractOnChengXiaoShanShopT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnChengXiaoShanShop>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset shopSuccessMontageOffset = (_o.ShopSuccessMontage == null) ? default(StringOffset) : builder.CreateString(_o.ShopSuccessMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> shopSuccessFlowOffset = (_o.ShopSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopSuccessFlow);
			Offset<IPlayFlow> shopFailedFlowOffset = (_o.ShopFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopFailedFlow);
			StringOffset upgradeSequenceOffset = (_o.UpgradeSequence == null) ? default(StringOffset) : builder.CreateString(_o.UpgradeSequence);
			StringOffset finishDeliverySequenceOffset = (_o.FinishDeliverySequence == null) ? default(StringOffset) : builder.CreateString(_o.FinishDeliverySequence);
			return INpcUiInteractOnChengXiaoShanShop.CreateINpcUiInteractOnChengXiaoShanShop(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, upgradeSequenceOffset, finishDeliverySequenceOffset, _o.ShowNpcWhilePlayingSequence, _o.NullMask);
		}

		// Token: 0x0400F6A5 RID: 63141
		private Table __p;
	}
}
