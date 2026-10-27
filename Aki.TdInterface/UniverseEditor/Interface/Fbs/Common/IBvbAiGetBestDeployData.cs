using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2E RID: 23854
	public struct IBvbAiGetBestDeployData : IFlatbufferObject
	{
		// Token: 0x1700B2CB RID: 45771
		// (get) Token: 0x06028C6D RID: 167021 RVA: 0x00599F5C File Offset: 0x0059815C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C6E RID: 167022 RVA: 0x00599F69 File Offset: 0x00598169
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C6F RID: 167023 RVA: 0x00599F70 File Offset: 0x00598170
		public static IBvbAiGetBestDeployData GetRootAsIBvbAiGetBestDeployData(ByteBuffer _bb)
		{
			return IBvbAiGetBestDeployData.GetRootAsIBvbAiGetBestDeployData(_bb, default(IBvbAiGetBestDeployData));
		}

		// Token: 0x06028C70 RID: 167024 RVA: 0x00599F8C File Offset: 0x0059818C
		public static IBvbAiGetBestDeployData GetRootAsIBvbAiGetBestDeployData(ByteBuffer _bb, IBvbAiGetBestDeployData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C71 RID: 167025 RVA: 0x00599FA9 File Offset: 0x005981A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C72 RID: 167026 RVA: 0x00599FB8 File Offset: 0x005981B8
		public IBvbAiGetBestDeployData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2CC RID: 45772
		// (get) Token: 0x06028C73 RID: 167027 RVA: 0x00599FC8 File Offset: 0x005981C8
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

		// Token: 0x1700B2CD RID: 45773
		// (get) Token: 0x06028C74 RID: 167028 RVA: 0x0059A004 File Offset: 0x00598204
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

		// Token: 0x06028C75 RID: 167029 RVA: 0x0059A040 File Offset: 0x00598240
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C76 RID: 167030 RVA: 0x0059A084 File Offset: 0x00598284
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028C77 RID: 167031 RVA: 0x0059A0A0 File Offset: 0x005982A0
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028C78 RID: 167032 RVA: 0x0059A0BC File Offset: 0x005982BC
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028C79 RID: 167033 RVA: 0x0059A0D8 File Offset: 0x005982D8
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028C7A RID: 167034 RVA: 0x0059A0F4 File Offset: 0x005982F4
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2CE RID: 45774
		// (get) Token: 0x06028C7B RID: 167035 RVA: 0x0059A110 File Offset: 0x00598310
		public TVarRef BoardPosStoredType
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

		// Token: 0x06028C7C RID: 167036 RVA: 0x0059A150 File Offset: 0x00598350
		public TTable? BoardPosStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C7D RID: 167037 RVA: 0x0059A198 File Offset: 0x00598398
		public IConstVarRef BoardPosStoredAsIConstVarRef()
		{
			return this.BoardPosStored<IConstVarRef>().Value;
		}

		// Token: 0x06028C7E RID: 167038 RVA: 0x0059A1B4 File Offset: 0x005983B4
		public IGlobalVarRef BoardPosStoredAsIGlobalVarRef()
		{
			return this.BoardPosStored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028C7F RID: 167039 RVA: 0x0059A1D0 File Offset: 0x005983D0
		public IOtherVarRef BoardPosStoredAsIOtherVarRef()
		{
			return this.BoardPosStored<IOtherVarRef>().Value;
		}

		// Token: 0x06028C80 RID: 167040 RVA: 0x0059A1EC File Offset: 0x005983EC
		public ISelfVarRef BoardPosStoredAsISelfVarRef()
		{
			return this.BoardPosStored<ISelfVarRef>().Value;
		}

		// Token: 0x06028C81 RID: 167041 RVA: 0x0059A208 File Offset: 0x00598408
		public ISystemVarRef BoardPosStoredAsISystemVarRef()
		{
			return this.BoardPosStored<ISystemVarRef>().Value;
		}

		// Token: 0x06028C82 RID: 167042 RVA: 0x0059A223 File Offset: 0x00598423
		public static Offset<IBvbAiGetBestDeployData> CreateIBvbAiGetBestDeployData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0, TVarRef BoardPosStored_type = TVarRef.NONE, int BoardPosStoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestDeployData.AddBoardPosStored(builder, BoardPosStoredOffset);
			IBvbAiGetBestDeployData.AddHandCard(builder, HandCardOffset);
			IBvbAiGetBestDeployData.AddBoardPosStoredType(builder, BoardPosStored_type);
			IBvbAiGetBestDeployData.AddHandCardType(builder, HandCard_type);
			IBvbAiGetBestDeployData.AddType(builder, Type);
			return IBvbAiGetBestDeployData.EndIBvbAiGetBestDeployData(builder);
		}

		// Token: 0x06028C83 RID: 167043 RVA: 0x0059A257 File Offset: 0x00598457
		public static void StartIBvbAiGetBestDeployData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028C84 RID: 167044 RVA: 0x0059A260 File Offset: 0x00598460
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C85 RID: 167045 RVA: 0x0059A26B File Offset: 0x0059846B
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06028C86 RID: 167046 RVA: 0x0059A276 File Offset: 0x00598476
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x06028C87 RID: 167047 RVA: 0x0059A281 File Offset: 0x00598481
		public static void AddBoardPosStoredType(FlatBufferBuilder builder, TVarRef boardPosStoredType)
		{
			builder.AddByte(3, (byte)boardPosStoredType, 0);
		}

		// Token: 0x06028C88 RID: 167048 RVA: 0x0059A28C File Offset: 0x0059848C
		public static void AddBoardPosStored(FlatBufferBuilder builder, int boardPosStoredOffset)
		{
			builder.AddOffset(4, boardPosStoredOffset, 0);
		}

		// Token: 0x06028C89 RID: 167049 RVA: 0x0059A297 File Offset: 0x00598497
		public static Offset<IBvbAiGetBestDeployData> EndIBvbAiGetBestDeployData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestDeployData>(builder.EndTable());
		}

		// Token: 0x06028C8A RID: 167050 RVA: 0x0059A2A4 File Offset: 0x005984A4
		public IBvbAiGetBestDeployDataT UnPack()
		{
			IBvbAiGetBestDeployDataT bvbAiGetBestDeployDataT = new IBvbAiGetBestDeployDataT();
			this.UnPackTo(bvbAiGetBestDeployDataT);
			return bvbAiGetBestDeployDataT;
		}

		// Token: 0x06028C8B RID: 167051 RVA: 0x0059A2C0 File Offset: 0x005984C0
		public void UnPackTo(IBvbAiGetBestDeployDataT _o)
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
			_o.BoardPosStored = new TVarRefUnion();
			_o.BoardPosStored.Type = this.BoardPosStoredType;
			switch (this.BoardPosStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IConstVarRef>() != null) ? this.BoardPosStored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IGlobalVarRef>() != null) ? this.BoardPosStored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IOtherVarRef>() != null) ? this.BoardPosStored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISelfVarRef>() != null) ? this.BoardPosStored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISystemVarRef>() != null) ? this.BoardPosStored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028C8C RID: 167052 RVA: 0x0059A58C File Offset: 0x0059878C
		public static Offset<IBvbAiGetBestDeployData> Pack(FlatBufferBuilder builder, IBvbAiGetBestDeployDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestDeployData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			TVarRef boardPosStored_type = (_o.BoardPosStored == null) ? TVarRef.NONE : _o.BoardPosStored.Type;
			int boardPosStoredOffset = (_o.BoardPosStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPosStored);
			return IBvbAiGetBestDeployData.CreateIBvbAiGetBestDeployData(builder, _o.Type, handCard_type, handCardOffset, boardPosStored_type, boardPosStoredOffset);
		}

		// Token: 0x0400F6DF RID: 63199
		private Table __p;
	}
}
