using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3A RID: 23866
	public struct IBvbAiRearrangeData : IFlatbufferObject
	{
		// Token: 0x1700B2E7 RID: 45799
		// (get) Token: 0x06028D0D RID: 167181 RVA: 0x0059BE0C File Offset: 0x0059A00C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D0E RID: 167182 RVA: 0x0059BE19 File Offset: 0x0059A019
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D0F RID: 167183 RVA: 0x0059BE20 File Offset: 0x0059A020
		public static IBvbAiRearrangeData GetRootAsIBvbAiRearrangeData(ByteBuffer _bb)
		{
			return IBvbAiRearrangeData.GetRootAsIBvbAiRearrangeData(_bb, default(IBvbAiRearrangeData));
		}

		// Token: 0x06028D10 RID: 167184 RVA: 0x0059BE3C File Offset: 0x0059A03C
		public static IBvbAiRearrangeData GetRootAsIBvbAiRearrangeData(ByteBuffer _bb, IBvbAiRearrangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D11 RID: 167185 RVA: 0x0059BE59 File Offset: 0x0059A059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D12 RID: 167186 RVA: 0x0059BE68 File Offset: 0x0059A068
		public IBvbAiRearrangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2E8 RID: 45800
		// (get) Token: 0x06028D13 RID: 167187 RVA: 0x0059BE78 File Offset: 0x0059A078
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

		// Token: 0x1700B2E9 RID: 45801
		// (get) Token: 0x06028D14 RID: 167188 RVA: 0x0059BEB4 File Offset: 0x0059A0B4
		public TVarRef BoardCardType
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

		// Token: 0x06028D15 RID: 167189 RVA: 0x0059BEF0 File Offset: 0x0059A0F0
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028D16 RID: 167190 RVA: 0x0059BF34 File Offset: 0x0059A134
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x06028D17 RID: 167191 RVA: 0x0059BF50 File Offset: 0x0059A150
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028D18 RID: 167192 RVA: 0x0059BF6C File Offset: 0x0059A16C
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028D19 RID: 167193 RVA: 0x0059BF88 File Offset: 0x0059A188
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028D1A RID: 167194 RVA: 0x0059BFA4 File Offset: 0x0059A1A4
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2EA RID: 45802
		// (get) Token: 0x06028D1B RID: 167195 RVA: 0x0059BFC0 File Offset: 0x0059A1C0
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

		// Token: 0x06028D1C RID: 167196 RVA: 0x0059C000 File Offset: 0x0059A200
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028D1D RID: 167197 RVA: 0x0059C048 File Offset: 0x0059A248
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x06028D1E RID: 167198 RVA: 0x0059C064 File Offset: 0x0059A264
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x06028D1F RID: 167199 RVA: 0x0059C080 File Offset: 0x0059A280
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x06028D20 RID: 167200 RVA: 0x0059C09C File Offset: 0x0059A29C
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x06028D21 RID: 167201 RVA: 0x0059C0B8 File Offset: 0x0059A2B8
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x06028D22 RID: 167202 RVA: 0x0059C0D3 File Offset: 0x0059A2D3
		public static Offset<IBvbAiRearrangeData> CreateIBvbAiRearrangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard_type = TVarRef.NONE, int BoardCardOffset = 0, TVarRef BoardPos_type = TVarRef.NONE, int BoardPosOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiRearrangeData.AddBoardPos(builder, BoardPosOffset);
			IBvbAiRearrangeData.AddBoardCard(builder, BoardCardOffset);
			IBvbAiRearrangeData.AddBoardPosType(builder, BoardPos_type);
			IBvbAiRearrangeData.AddBoardCardType(builder, BoardCard_type);
			IBvbAiRearrangeData.AddType(builder, Type);
			return IBvbAiRearrangeData.EndIBvbAiRearrangeData(builder);
		}

		// Token: 0x06028D23 RID: 167203 RVA: 0x0059C107 File Offset: 0x0059A307
		public static void StartIBvbAiRearrangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028D24 RID: 167204 RVA: 0x0059C110 File Offset: 0x0059A310
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D25 RID: 167205 RVA: 0x0059C11B File Offset: 0x0059A31B
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(1, (byte)boardCardType, 0);
		}

		// Token: 0x06028D26 RID: 167206 RVA: 0x0059C126 File Offset: 0x0059A326
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(2, boardCardOffset, 0);
		}

		// Token: 0x06028D27 RID: 167207 RVA: 0x0059C131 File Offset: 0x0059A331
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x06028D28 RID: 167208 RVA: 0x0059C13C File Offset: 0x0059A33C
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x06028D29 RID: 167209 RVA: 0x0059C147 File Offset: 0x0059A347
		public static Offset<IBvbAiRearrangeData> EndIBvbAiRearrangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiRearrangeData>(builder.EndTable());
		}

		// Token: 0x06028D2A RID: 167210 RVA: 0x0059C154 File Offset: 0x0059A354
		public IBvbAiRearrangeDataT UnPack()
		{
			IBvbAiRearrangeDataT bvbAiRearrangeDataT = new IBvbAiRearrangeDataT();
			this.UnPackTo(bvbAiRearrangeDataT);
			return bvbAiRearrangeDataT;
		}

		// Token: 0x06028D2B RID: 167211 RVA: 0x0059C170 File Offset: 0x0059A370
		public void UnPackTo(IBvbAiRearrangeDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCard = new TVarRefUnion();
			_o.BoardCard.Type = this.BoardCardType;
			switch (this.BoardCardType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IConstVarRef>() != null) ? this.BoardCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IGlobalVarRef>() != null) ? this.BoardCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IOtherVarRef>() != null) ? this.BoardCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISelfVarRef>() != null) ? this.BoardCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISystemVarRef>() != null) ? this.BoardCard<ISystemVarRef>().Value.UnPack() : null);
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

		// Token: 0x06028D2C RID: 167212 RVA: 0x0059C43C File Offset: 0x0059A63C
		public static Offset<IBvbAiRearrangeData> Pack(FlatBufferBuilder builder, IBvbAiRearrangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiRearrangeData>);
			}
			TVarRef boardCard_type = (_o.BoardCard == null) ? TVarRef.NONE : _o.BoardCard.Type;
			int boardCardOffset = (_o.BoardCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard);
			TVarRef boardPos_type = (_o.BoardPos == null) ? TVarRef.NONE : _o.BoardPos.Type;
			int boardPosOffset = (_o.BoardPos == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPos);
			return IBvbAiRearrangeData.CreateIBvbAiRearrangeData(builder, _o.Type, boardCard_type, boardCardOffset, boardPos_type, boardPosOffset);
		}

		// Token: 0x0400F6EF RID: 63215
		private Table __p;
	}
}
