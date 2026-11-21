using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006362 RID: 25442
	public struct IBvbAiEvolutionData : IFlatbufferObject
	{
		// Token: 0x1700BC25 RID: 48165
		// (get) Token: 0x0602B2AF RID: 176815 RVA: 0x005E2220 File Offset: 0x005E0420
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2B0 RID: 176816 RVA: 0x005E222D File Offset: 0x005E042D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2B1 RID: 176817 RVA: 0x005E2234 File Offset: 0x005E0434
		public static IBvbAiEvolutionData GetRootAsIBvbAiEvolutionData(ByteBuffer _bb)
		{
			return IBvbAiEvolutionData.GetRootAsIBvbAiEvolutionData(_bb, default(IBvbAiEvolutionData));
		}

		// Token: 0x0602B2B2 RID: 176818 RVA: 0x005E2250 File Offset: 0x005E0450
		public static IBvbAiEvolutionData GetRootAsIBvbAiEvolutionData(ByteBuffer _bb, IBvbAiEvolutionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2B3 RID: 176819 RVA: 0x005E226D File Offset: 0x005E046D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2B4 RID: 176820 RVA: 0x005E227C File Offset: 0x005E047C
		public IBvbAiEvolutionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC26 RID: 48166
		// (get) Token: 0x0602B2B5 RID: 176821 RVA: 0x005E228C File Offset: 0x005E048C
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC27 RID: 48167
		// (get) Token: 0x0602B2B6 RID: 176822 RVA: 0x005E22C8 File Offset: 0x005E04C8
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

		// Token: 0x0602B2B7 RID: 176823 RVA: 0x005E2304 File Offset: 0x005E0504
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B2B8 RID: 176824 RVA: 0x005E2348 File Offset: 0x005E0548
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B2B9 RID: 176825 RVA: 0x005E2364 File Offset: 0x005E0564
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B2BA RID: 176826 RVA: 0x005E2380 File Offset: 0x005E0580
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B2BB RID: 176827 RVA: 0x005E239C File Offset: 0x005E059C
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B2BC RID: 176828 RVA: 0x005E23B8 File Offset: 0x005E05B8
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC28 RID: 48168
		// (get) Token: 0x0602B2BD RID: 176829 RVA: 0x005E23D4 File Offset: 0x005E05D4
		public TVarRef BoardCardType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B2BE RID: 176830 RVA: 0x005E2414 File Offset: 0x005E0614
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B2BF RID: 176831 RVA: 0x005E245C File Offset: 0x005E065C
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B2C0 RID: 176832 RVA: 0x005E2478 File Offset: 0x005E0678
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B2C1 RID: 176833 RVA: 0x005E2494 File Offset: 0x005E0694
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B2C2 RID: 176834 RVA: 0x005E24B0 File Offset: 0x005E06B0
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B2C3 RID: 176835 RVA: 0x005E24CC File Offset: 0x005E06CC
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x0602B2C4 RID: 176836 RVA: 0x005E24E7 File Offset: 0x005E06E7
		public static Offset<IBvbAiEvolutionData> CreateIBvbAiEvolutionData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0, TVarRef BoardCard_type = TVarRef.NONE, int BoardCardOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiEvolutionData.AddBoardCard(builder, BoardCardOffset);
			IBvbAiEvolutionData.AddHandCard(builder, HandCardOffset);
			IBvbAiEvolutionData.AddBoardCardType(builder, BoardCard_type);
			IBvbAiEvolutionData.AddHandCardType(builder, HandCard_type);
			IBvbAiEvolutionData.AddType(builder, Type);
			return IBvbAiEvolutionData.EndIBvbAiEvolutionData(builder);
		}

		// Token: 0x0602B2C5 RID: 176837 RVA: 0x005E251B File Offset: 0x005E071B
		public static void StartIBvbAiEvolutionData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B2C6 RID: 176838 RVA: 0x005E2524 File Offset: 0x005E0724
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B2C7 RID: 176839 RVA: 0x005E252F File Offset: 0x005E072F
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0602B2C8 RID: 176840 RVA: 0x005E253A File Offset: 0x005E073A
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0602B2C9 RID: 176841 RVA: 0x005E2545 File Offset: 0x005E0745
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(3, (byte)boardCardType, 0);
		}

		// Token: 0x0602B2CA RID: 176842 RVA: 0x005E2550 File Offset: 0x005E0750
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(4, boardCardOffset, 0);
		}

		// Token: 0x0602B2CB RID: 176843 RVA: 0x005E255B File Offset: 0x005E075B
		public static Offset<IBvbAiEvolutionData> EndIBvbAiEvolutionData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiEvolutionData>(builder.EndTable());
		}

		// Token: 0x0602B2CC RID: 176844 RVA: 0x005E2568 File Offset: 0x005E0768
		public IBvbAiEvolutionDataT UnPack()
		{
			IBvbAiEvolutionDataT bvbAiEvolutionDataT = new IBvbAiEvolutionDataT();
			this.UnPackTo(bvbAiEvolutionDataT);
			return bvbAiEvolutionDataT;
		}

		// Token: 0x0602B2CD RID: 176845 RVA: 0x005E2584 File Offset: 0x005E0784
		public void UnPackTo(IBvbAiEvolutionDataT _o)
		{
			_o.Type = this.Type;
			_o.HandCard = new TVarRefUnion();
			_o.HandCard.Type = this.HandCardType;
			switch (this.HandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.HandCard.Value = ((this.HandCard<IConstVarRef>() != null) ? this.HandCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.HandCard.Value = ((this.HandCard<IGlobalVarRef>() != null) ? this.HandCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.HandCard.Value = ((this.HandCard<IOtherVarRef>() != null) ? this.HandCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.HandCard.Value = ((this.HandCard<ISelfVarRef>() != null) ? this.HandCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.HandCard.Value = ((this.HandCard<ISystemVarRef>() != null) ? this.HandCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardCard = new TVarRefUnion();
			_o.BoardCard.Type = this.BoardCardType;
			switch (this.BoardCardType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IConstVarRef>() != null) ? this.BoardCard<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IGlobalVarRef>() != null) ? this.BoardCard<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IOtherVarRef>() != null) ? this.BoardCard<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISelfVarRef>() != null) ? this.BoardCard<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISystemVarRef>() != null) ? this.BoardCard<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B2CE RID: 176846 RVA: 0x005E2850 File Offset: 0x005E0A50
		public static Offset<IBvbAiEvolutionData> Pack(FlatBufferBuilder builder, IBvbAiEvolutionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiEvolutionData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			TVarRef boardCard_type = (_o.BoardCard == null) ? TVarRef.NONE : _o.BoardCard.Type;
			int boardCardOffset = (_o.BoardCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard);
			return IBvbAiEvolutionData.CreateIBvbAiEvolutionData(builder, _o.Type, handCard_type, handCardOffset, boardCard_type, boardCardOffset);
		}

		// Token: 0x0401042D RID: 66605
		private Table __p;
	}
}
