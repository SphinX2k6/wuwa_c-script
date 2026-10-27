using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566E RID: 22126
	public struct INpcUiInteractOnChengXiaoShanShop : IFlatbufferObject
	{
		// Token: 0x1700A408 RID: 41992
		// (get) Token: 0x06024D19 RID: 150809 RVA: 0x005149E6 File Offset: 0x00512BE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D1A RID: 150810 RVA: 0x005149F3 File Offset: 0x00512BF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D1B RID: 150811 RVA: 0x005149FC File Offset: 0x00512BFC
		public static INpcUiInteractOnChengXiaoShanShop GetRootAsINpcUiInteractOnChengXiaoShanShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnChengXiaoShanShop.GetRootAsINpcUiInteractOnChengXiaoShanShop(_bb, default(INpcUiInteractOnChengXiaoShanShop));
		}

		// Token: 0x06024D1C RID: 150812 RVA: 0x00514A18 File Offset: 0x00512C18
		public static INpcUiInteractOnChengXiaoShanShop GetRootAsINpcUiInteractOnChengXiaoShanShop(ByteBuffer _bb, INpcUiInteractOnChengXiaoShanShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D1D RID: 150813 RVA: 0x00514A35 File Offset: 0x00512C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D1E RID: 150814 RVA: 0x00514A44 File Offset: 0x00512C44
		public INpcUiInteractOnChengXiaoShanShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A409 RID: 41993
		// (get) Token: 0x06024D1F RID: 150815 RVA: 0x00514A54 File Offset: 0x00512C54
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

		// Token: 0x1700A40A RID: 41994
		// (get) Token: 0x06024D20 RID: 150816 RVA: 0x00514A90 File Offset: 0x00512C90
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

		// Token: 0x06024D21 RID: 150817 RVA: 0x00514AC7 File Offset: 0x00512CC7
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024D22 RID: 150818 RVA: 0x00514AD6 File Offset: 0x00512CD6
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A40B RID: 41995
		// (get) Token: 0x06024D23 RID: 150819 RVA: 0x00514AE4 File Offset: 0x00512CE4
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

		// Token: 0x06024D24 RID: 150820 RVA: 0x00514B1B File Offset: 0x00512D1B
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024D25 RID: 150821 RVA: 0x00514B2A File Offset: 0x00512D2A
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A40C RID: 41996
		// (get) Token: 0x06024D26 RID: 150822 RVA: 0x00514B38 File Offset: 0x00512D38
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

		// Token: 0x06024D27 RID: 150823 RVA: 0x00514B70 File Offset: 0x00512D70
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024D28 RID: 150824 RVA: 0x00514B80 File Offset: 0x00512D80
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A40D RID: 41997
		// (get) Token: 0x06024D29 RID: 150825 RVA: 0x00514B90 File Offset: 0x00512D90
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

		// Token: 0x1700A40E RID: 41998
		// (get) Token: 0x06024D2A RID: 150826 RVA: 0x00514BF0 File Offset: 0x00512DF0
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

		// Token: 0x1700A40F RID: 41999
		// (get) Token: 0x06024D2B RID: 150827 RVA: 0x00514C50 File Offset: 0x00512E50
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

		// Token: 0x1700A410 RID: 42000
		// (get) Token: 0x06024D2C RID: 150828 RVA: 0x00514CB0 File Offset: 0x00512EB0
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

		// Token: 0x06024D2D RID: 150829 RVA: 0x00514CE8 File Offset: 0x00512EE8
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06024D2E RID: 150830 RVA: 0x00514CF8 File Offset: 0x00512EF8
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A411 RID: 42001
		// (get) Token: 0x06024D2F RID: 150831 RVA: 0x00514D08 File Offset: 0x00512F08
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

		// Token: 0x06024D30 RID: 150832 RVA: 0x00514D40 File Offset: 0x00512F40
		public Span<byte> GetFinishDeliverySequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06024D31 RID: 150833 RVA: 0x00514D50 File Offset: 0x00512F50
		public byte[] GetFinishDeliverySequenceArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700A412 RID: 42002
		// (get) Token: 0x06024D32 RID: 150834 RVA: 0x00514D60 File Offset: 0x00512F60
		public bool ShowNpcWhilePlayingSequence
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A413 RID: 42003
		// (get) Token: 0x06024D33 RID: 150835 RVA: 0x00514DA0 File Offset: 0x00512FA0
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

		// Token: 0x06024D34 RID: 150836 RVA: 0x00514DE0 File Offset: 0x00512FE0
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

		// Token: 0x06024D35 RID: 150837 RVA: 0x00514E50 File Offset: 0x00513050
		public static void StartINpcUiInteractOnChengXiaoShanShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024D36 RID: 150838 RVA: 0x00514E5A File Offset: 0x0051305A
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024D37 RID: 150839 RVA: 0x00514E65 File Offset: 0x00513065
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024D38 RID: 150840 RVA: 0x00514E75 File Offset: 0x00513075
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024D39 RID: 150841 RVA: 0x00514E85 File Offset: 0x00513085
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024D3A RID: 150842 RVA: 0x00514E95 File Offset: 0x00513095
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024D3B RID: 150843 RVA: 0x00514EA5 File Offset: 0x005130A5
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024D3C RID: 150844 RVA: 0x00514EB5 File Offset: 0x005130B5
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024D3D RID: 150845 RVA: 0x00514EC5 File Offset: 0x005130C5
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06024D3E RID: 150846 RVA: 0x00514ED5 File Offset: 0x005130D5
		public static void AddFinishDeliverySequence(FlatBufferBuilder builder, StringOffset finishDeliverySequenceOffset)
		{
			builder.AddOffset(8, finishDeliverySequenceOffset.Value, 0);
		}

		// Token: 0x06024D3F RID: 150847 RVA: 0x00514EE5 File Offset: 0x005130E5
		public static void AddShowNpcWhilePlayingSequence(FlatBufferBuilder builder, bool showNpcWhilePlayingSequence)
		{
			builder.AddBool(9, showNpcWhilePlayingSequence, false);
		}

		// Token: 0x06024D40 RID: 150848 RVA: 0x00514EF1 File Offset: 0x005130F1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06024D41 RID: 150849 RVA: 0x00514EFD File Offset: 0x005130FD
		public static Offset<INpcUiInteractOnChengXiaoShanShop> EndINpcUiInteractOnChengXiaoShanShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnChengXiaoShanShop>(builder.EndTable());
		}

		// Token: 0x06024D42 RID: 150850 RVA: 0x00514F0C File Offset: 0x0051310C
		public INpcUiInteractOnChengXiaoShanShopT UnPack()
		{
			INpcUiInteractOnChengXiaoShanShopT npcUiInteractOnChengXiaoShanShopT = new INpcUiInteractOnChengXiaoShanShopT();
			this.UnPackTo(npcUiInteractOnChengXiaoShanShopT);
			return npcUiInteractOnChengXiaoShanShopT;
		}

		// Token: 0x06024D43 RID: 150851 RVA: 0x00514F28 File Offset: 0x00513128
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

		// Token: 0x06024D44 RID: 150852 RVA: 0x00515024 File Offset: 0x00513224
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

		// Token: 0x0400EA3C RID: 59964
		private Table __p;
	}
}
