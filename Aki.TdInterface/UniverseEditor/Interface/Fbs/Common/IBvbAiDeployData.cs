using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006359 RID: 25433
	public struct IBvbAiDeployData : IFlatbufferObject
	{
		// Token: 0x1700BC10 RID: 48144
		// (get) Token: 0x0602B248 RID: 176712 RVA: 0x005E1140 File Offset: 0x005DF340
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B249 RID: 176713 RVA: 0x005E114D File Offset: 0x005DF34D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B24A RID: 176714 RVA: 0x005E1154 File Offset: 0x005DF354
		public static IBvbAiDeployData GetRootAsIBvbAiDeployData(ByteBuffer _bb)
		{
			return IBvbAiDeployData.GetRootAsIBvbAiDeployData(_bb, default(IBvbAiDeployData));
		}

		// Token: 0x0602B24B RID: 176715 RVA: 0x005E1170 File Offset: 0x005DF370
		public static IBvbAiDeployData GetRootAsIBvbAiDeployData(ByteBuffer _bb, IBvbAiDeployData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B24C RID: 176716 RVA: 0x005E118D File Offset: 0x005DF38D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B24D RID: 176717 RVA: 0x005E119C File Offset: 0x005DF39C
		public IBvbAiDeployData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC11 RID: 48145
		// (get) Token: 0x0602B24E RID: 176718 RVA: 0x005E11AC File Offset: 0x005DF3AC
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

		// Token: 0x1700BC12 RID: 48146
		// (get) Token: 0x0602B24F RID: 176719 RVA: 0x005E11E8 File Offset: 0x005DF3E8
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

		// Token: 0x0602B250 RID: 176720 RVA: 0x005E1224 File Offset: 0x005DF424
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B251 RID: 176721 RVA: 0x005E1268 File Offset: 0x005DF468
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B252 RID: 176722 RVA: 0x005E1284 File Offset: 0x005DF484
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B253 RID: 176723 RVA: 0x005E12A0 File Offset: 0x005DF4A0
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B254 RID: 176724 RVA: 0x005E12BC File Offset: 0x005DF4BC
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B255 RID: 176725 RVA: 0x005E12D8 File Offset: 0x005DF4D8
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC13 RID: 48147
		// (get) Token: 0x0602B256 RID: 176726 RVA: 0x005E12F4 File Offset: 0x005DF4F4
		public TVarRef BoardPosType
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

		// Token: 0x0602B257 RID: 176727 RVA: 0x005E1334 File Offset: 0x005DF534
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B258 RID: 176728 RVA: 0x005E137C File Offset: 0x005DF57C
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x0602B259 RID: 176729 RVA: 0x005E1398 File Offset: 0x005DF598
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B25A RID: 176730 RVA: 0x005E13B4 File Offset: 0x005DF5B4
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x0602B25B RID: 176731 RVA: 0x005E13D0 File Offset: 0x005DF5D0
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x0602B25C RID: 176732 RVA: 0x005E13EC File Offset: 0x005DF5EC
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x0602B25D RID: 176733 RVA: 0x005E1407 File Offset: 0x005DF607
		public static Offset<IBvbAiDeployData> CreateIBvbAiDeployData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0, TVarRef BoardPos_type = TVarRef.NONE, int BoardPosOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiDeployData.AddBoardPos(builder, BoardPosOffset);
			IBvbAiDeployData.AddHandCard(builder, HandCardOffset);
			IBvbAiDeployData.AddBoardPosType(builder, BoardPos_type);
			IBvbAiDeployData.AddHandCardType(builder, HandCard_type);
			IBvbAiDeployData.AddType(builder, Type);
			return IBvbAiDeployData.EndIBvbAiDeployData(builder);
		}

		// Token: 0x0602B25E RID: 176734 RVA: 0x005E143B File Offset: 0x005DF63B
		public static void StartIBvbAiDeployData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B25F RID: 176735 RVA: 0x005E1444 File Offset: 0x005DF644
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B260 RID: 176736 RVA: 0x005E144F File Offset: 0x005DF64F
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0602B261 RID: 176737 RVA: 0x005E145A File Offset: 0x005DF65A
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0602B262 RID: 176738 RVA: 0x005E1465 File Offset: 0x005DF665
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x0602B263 RID: 176739 RVA: 0x005E1470 File Offset: 0x005DF670
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x0602B264 RID: 176740 RVA: 0x005E147B File Offset: 0x005DF67B
		public static Offset<IBvbAiDeployData> EndIBvbAiDeployData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDeployData>(builder.EndTable());
		}

		// Token: 0x0602B265 RID: 176741 RVA: 0x005E1488 File Offset: 0x005DF688
		public IBvbAiDeployDataT UnPack()
		{
			IBvbAiDeployDataT bvbAiDeployDataT = new IBvbAiDeployDataT();
			this.UnPackTo(bvbAiDeployDataT);
			return bvbAiDeployDataT;
		}

		// Token: 0x0602B266 RID: 176742 RVA: 0x005E14A4 File Offset: 0x005DF6A4
		public void UnPackTo(IBvbAiDeployDataT _o)
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
			_o.BoardPos = new TVarRefUnion();
			_o.BoardPos.Type = this.BoardPosType;
			switch (this.BoardPosType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IConstVarRef>() != null) ? this.BoardPos<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IGlobalVarRef>() != null) ? this.BoardPos<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IOtherVarRef>() != null) ? this.BoardPos<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISelfVarRef>() != null) ? this.BoardPos<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISystemVarRef>() != null) ? this.BoardPos<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B267 RID: 176743 RVA: 0x005E1770 File Offset: 0x005DF970
		public static Offset<IBvbAiDeployData> Pack(FlatBufferBuilder builder, IBvbAiDeployDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiDeployData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			TVarRef boardPos_type = (_o.BoardPos == null) ? TVarRef.NONE : _o.BoardPos.Type;
			int boardPosOffset = (_o.BoardPos == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPos);
			return IBvbAiDeployData.CreateIBvbAiDeployData(builder, _o.Type, handCard_type, handCardOffset, boardPos_type, boardPosOffset);
		}

		// Token: 0x04010421 RID: 66593
		private Table __p;
	}
}
