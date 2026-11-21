using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006365 RID: 25445
	public struct IBvbAiGetBestDeployData : IFlatbufferObject
	{
		// Token: 0x1700BC2C RID: 48172
		// (get) Token: 0x0602B2D7 RID: 176855 RVA: 0x005E29CC File Offset: 0x005E0BCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2D8 RID: 176856 RVA: 0x005E29D9 File Offset: 0x005E0BD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2D9 RID: 176857 RVA: 0x005E29E0 File Offset: 0x005E0BE0
		public static IBvbAiGetBestDeployData GetRootAsIBvbAiGetBestDeployData(ByteBuffer _bb)
		{
			return IBvbAiGetBestDeployData.GetRootAsIBvbAiGetBestDeployData(_bb, default(IBvbAiGetBestDeployData));
		}

		// Token: 0x0602B2DA RID: 176858 RVA: 0x005E29FC File Offset: 0x005E0BFC
		public static IBvbAiGetBestDeployData GetRootAsIBvbAiGetBestDeployData(ByteBuffer _bb, IBvbAiGetBestDeployData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2DB RID: 176859 RVA: 0x005E2A19 File Offset: 0x005E0C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2DC RID: 176860 RVA: 0x005E2A28 File Offset: 0x005E0C28
		public IBvbAiGetBestDeployData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC2D RID: 48173
		// (get) Token: 0x0602B2DD RID: 176861 RVA: 0x005E2A38 File Offset: 0x005E0C38
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

		// Token: 0x1700BC2E RID: 48174
		// (get) Token: 0x0602B2DE RID: 176862 RVA: 0x005E2A74 File Offset: 0x005E0C74
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

		// Token: 0x0602B2DF RID: 176863 RVA: 0x005E2AB0 File Offset: 0x005E0CB0
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B2E0 RID: 176864 RVA: 0x005E2AF4 File Offset: 0x005E0CF4
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B2E1 RID: 176865 RVA: 0x005E2B10 File Offset: 0x005E0D10
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B2E2 RID: 176866 RVA: 0x005E2B2C File Offset: 0x005E0D2C
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B2E3 RID: 176867 RVA: 0x005E2B48 File Offset: 0x005E0D48
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B2E4 RID: 176868 RVA: 0x005E2B64 File Offset: 0x005E0D64
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC2F RID: 48175
		// (get) Token: 0x0602B2E5 RID: 176869 RVA: 0x005E2B80 File Offset: 0x005E0D80
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

		// Token: 0x0602B2E6 RID: 176870 RVA: 0x005E2BC0 File Offset: 0x005E0DC0
		public TTable? BoardPosStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B2E7 RID: 176871 RVA: 0x005E2C08 File Offset: 0x005E0E08
		public IConstVarRef BoardPosStoredAsIConstVarRef()
		{
			return this.BoardPosStored<IConstVarRef>().Value;
		}

		// Token: 0x0602B2E8 RID: 176872 RVA: 0x005E2C24 File Offset: 0x005E0E24
		public IGlobalVarRef BoardPosStoredAsIGlobalVarRef()
		{
			return this.BoardPosStored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B2E9 RID: 176873 RVA: 0x005E2C40 File Offset: 0x005E0E40
		public IOtherVarRef BoardPosStoredAsIOtherVarRef()
		{
			return this.BoardPosStored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B2EA RID: 176874 RVA: 0x005E2C5C File Offset: 0x005E0E5C
		public ISelfVarRef BoardPosStoredAsISelfVarRef()
		{
			return this.BoardPosStored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B2EB RID: 176875 RVA: 0x005E2C78 File Offset: 0x005E0E78
		public ISystemVarRef BoardPosStoredAsISystemVarRef()
		{
			return this.BoardPosStored<ISystemVarRef>().Value;
		}

		// Token: 0x0602B2EC RID: 176876 RVA: 0x005E2C93 File Offset: 0x005E0E93
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

		// Token: 0x0602B2ED RID: 176877 RVA: 0x005E2CC7 File Offset: 0x005E0EC7
		public static void StartIBvbAiGetBestDeployData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B2EE RID: 176878 RVA: 0x005E2CD0 File Offset: 0x005E0ED0
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B2EF RID: 176879 RVA: 0x005E2CDB File Offset: 0x005E0EDB
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0602B2F0 RID: 176880 RVA: 0x005E2CE6 File Offset: 0x005E0EE6
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0602B2F1 RID: 176881 RVA: 0x005E2CF1 File Offset: 0x005E0EF1
		public static void AddBoardPosStoredType(FlatBufferBuilder builder, TVarRef boardPosStoredType)
		{
			builder.AddByte(3, (byte)boardPosStoredType, 0);
		}

		// Token: 0x0602B2F2 RID: 176882 RVA: 0x005E2CFC File Offset: 0x005E0EFC
		public static void AddBoardPosStored(FlatBufferBuilder builder, int boardPosStoredOffset)
		{
			builder.AddOffset(4, boardPosStoredOffset, 0);
		}

		// Token: 0x0602B2F3 RID: 176883 RVA: 0x005E2D07 File Offset: 0x005E0F07
		public static Offset<IBvbAiGetBestDeployData> EndIBvbAiGetBestDeployData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestDeployData>(builder.EndTable());
		}

		// Token: 0x0602B2F4 RID: 176884 RVA: 0x005E2D14 File Offset: 0x005E0F14
		public IBvbAiGetBestDeployDataT UnPack()
		{
			IBvbAiGetBestDeployDataT bvbAiGetBestDeployDataT = new IBvbAiGetBestDeployDataT();
			this.UnPackTo(bvbAiGetBestDeployDataT);
			return bvbAiGetBestDeployDataT;
		}

		// Token: 0x0602B2F5 RID: 176885 RVA: 0x005E2D30 File Offset: 0x005E0F30
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

		// Token: 0x0602B2F6 RID: 176886 RVA: 0x005E2FFC File Offset: 0x005E11FC
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

		// Token: 0x04010431 RID: 66609
		private Table __p;
	}
}
