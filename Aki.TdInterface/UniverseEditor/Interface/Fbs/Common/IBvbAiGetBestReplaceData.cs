using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D34 RID: 23860
	public struct IBvbAiGetBestReplaceData : IFlatbufferObject
	{
		// Token: 0x1700B2D9 RID: 45785
		// (get) Token: 0x06028CBD RID: 167101 RVA: 0x0059AEB4 File Offset: 0x005990B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028CBE RID: 167102 RVA: 0x0059AEC1 File Offset: 0x005990C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028CBF RID: 167103 RVA: 0x0059AEC8 File Offset: 0x005990C8
		public static IBvbAiGetBestReplaceData GetRootAsIBvbAiGetBestReplaceData(ByteBuffer _bb)
		{
			return IBvbAiGetBestReplaceData.GetRootAsIBvbAiGetBestReplaceData(_bb, default(IBvbAiGetBestReplaceData));
		}

		// Token: 0x06028CC0 RID: 167104 RVA: 0x0059AEE4 File Offset: 0x005990E4
		public static IBvbAiGetBestReplaceData GetRootAsIBvbAiGetBestReplaceData(ByteBuffer _bb, IBvbAiGetBestReplaceData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028CC1 RID: 167105 RVA: 0x0059AF01 File Offset: 0x00599101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028CC2 RID: 167106 RVA: 0x0059AF10 File Offset: 0x00599110
		public IBvbAiGetBestReplaceData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2DA RID: 45786
		// (get) Token: 0x06028CC3 RID: 167107 RVA: 0x0059AF20 File Offset: 0x00599120
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

		// Token: 0x1700B2DB RID: 45787
		// (get) Token: 0x06028CC4 RID: 167108 RVA: 0x0059AF5C File Offset: 0x0059915C
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

		// Token: 0x06028CC5 RID: 167109 RVA: 0x0059AF98 File Offset: 0x00599198
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028CC6 RID: 167110 RVA: 0x0059AFDC File Offset: 0x005991DC
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028CC7 RID: 167111 RVA: 0x0059AFF8 File Offset: 0x005991F8
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CC8 RID: 167112 RVA: 0x0059B014 File Offset: 0x00599214
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028CC9 RID: 167113 RVA: 0x0059B030 File Offset: 0x00599230
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028CCA RID: 167114 RVA: 0x0059B04C File Offset: 0x0059924C
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2DC RID: 45788
		// (get) Token: 0x06028CCB RID: 167115 RVA: 0x0059B068 File Offset: 0x00599268
		public TVarRef BoardCardStoredType
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

		// Token: 0x06028CCC RID: 167116 RVA: 0x0059B0A8 File Offset: 0x005992A8
		public TTable? BoardCardStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028CCD RID: 167117 RVA: 0x0059B0F0 File Offset: 0x005992F0
		public IConstVarRef BoardCardStoredAsIConstVarRef()
		{
			return this.BoardCardStored<IConstVarRef>().Value;
		}

		// Token: 0x06028CCE RID: 167118 RVA: 0x0059B10C File Offset: 0x0059930C
		public IGlobalVarRef BoardCardStoredAsIGlobalVarRef()
		{
			return this.BoardCardStored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CCF RID: 167119 RVA: 0x0059B128 File Offset: 0x00599328
		public IOtherVarRef BoardCardStoredAsIOtherVarRef()
		{
			return this.BoardCardStored<IOtherVarRef>().Value;
		}

		// Token: 0x06028CD0 RID: 167120 RVA: 0x0059B144 File Offset: 0x00599344
		public ISelfVarRef BoardCardStoredAsISelfVarRef()
		{
			return this.BoardCardStored<ISelfVarRef>().Value;
		}

		// Token: 0x06028CD1 RID: 167121 RVA: 0x0059B160 File Offset: 0x00599360
		public ISystemVarRef BoardCardStoredAsISystemVarRef()
		{
			return this.BoardCardStored<ISystemVarRef>().Value;
		}

		// Token: 0x06028CD2 RID: 167122 RVA: 0x0059B17B File Offset: 0x0059937B
		public static Offset<IBvbAiGetBestReplaceData> CreateIBvbAiGetBestReplaceData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0, TVarRef BoardCardStored_type = TVarRef.NONE, int BoardCardStoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestReplaceData.AddBoardCardStored(builder, BoardCardStoredOffset);
			IBvbAiGetBestReplaceData.AddHandCard(builder, HandCardOffset);
			IBvbAiGetBestReplaceData.AddBoardCardStoredType(builder, BoardCardStored_type);
			IBvbAiGetBestReplaceData.AddHandCardType(builder, HandCard_type);
			IBvbAiGetBestReplaceData.AddType(builder, Type);
			return IBvbAiGetBestReplaceData.EndIBvbAiGetBestReplaceData(builder);
		}

		// Token: 0x06028CD3 RID: 167123 RVA: 0x0059B1AF File Offset: 0x005993AF
		public static void StartIBvbAiGetBestReplaceData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028CD4 RID: 167124 RVA: 0x0059B1B8 File Offset: 0x005993B8
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028CD5 RID: 167125 RVA: 0x0059B1C3 File Offset: 0x005993C3
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06028CD6 RID: 167126 RVA: 0x0059B1CE File Offset: 0x005993CE
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x06028CD7 RID: 167127 RVA: 0x0059B1D9 File Offset: 0x005993D9
		public static void AddBoardCardStoredType(FlatBufferBuilder builder, TVarRef boardCardStoredType)
		{
			builder.AddByte(3, (byte)boardCardStoredType, 0);
		}

		// Token: 0x06028CD8 RID: 167128 RVA: 0x0059B1E4 File Offset: 0x005993E4
		public static void AddBoardCardStored(FlatBufferBuilder builder, int boardCardStoredOffset)
		{
			builder.AddOffset(4, boardCardStoredOffset, 0);
		}

		// Token: 0x06028CD9 RID: 167129 RVA: 0x0059B1EF File Offset: 0x005993EF
		public static Offset<IBvbAiGetBestReplaceData> EndIBvbAiGetBestReplaceData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestReplaceData>(builder.EndTable());
		}

		// Token: 0x06028CDA RID: 167130 RVA: 0x0059B1FC File Offset: 0x005993FC
		public IBvbAiGetBestReplaceDataT UnPack()
		{
			IBvbAiGetBestReplaceDataT bvbAiGetBestReplaceDataT = new IBvbAiGetBestReplaceDataT();
			this.UnPackTo(bvbAiGetBestReplaceDataT);
			return bvbAiGetBestReplaceDataT;
		}

		// Token: 0x06028CDB RID: 167131 RVA: 0x0059B218 File Offset: 0x00599418
		public void UnPackTo(IBvbAiGetBestReplaceDataT _o)
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
			_o.BoardCardStored = new TVarRefUnion();
			_o.BoardCardStored.Type = this.BoardCardStoredType;
			switch (this.BoardCardStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IConstVarRef>() != null) ? this.BoardCardStored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IGlobalVarRef>() != null) ? this.BoardCardStored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IOtherVarRef>() != null) ? this.BoardCardStored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISelfVarRef>() != null) ? this.BoardCardStored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISystemVarRef>() != null) ? this.BoardCardStored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028CDC RID: 167132 RVA: 0x0059B4E4 File Offset: 0x005996E4
		public static Offset<IBvbAiGetBestReplaceData> Pack(FlatBufferBuilder builder, IBvbAiGetBestReplaceDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestReplaceData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			TVarRef boardCardStored_type = (_o.BoardCardStored == null) ? TVarRef.NONE : _o.BoardCardStored.Type;
			int boardCardStoredOffset = (_o.BoardCardStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCardStored);
			return IBvbAiGetBestReplaceData.CreateIBvbAiGetBestReplaceData(builder, _o.Type, handCard_type, handCardOffset, boardCardStored_type, boardCardStoredOffset);
		}

		// Token: 0x0400F6E7 RID: 63207
		private Table __p;
	}
}
