using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D22 RID: 23842
	public struct IBvbAiDeployData : IFlatbufferObject
	{
		// Token: 0x1700B2AF RID: 45743
		// (get) Token: 0x06028BDE RID: 166878 RVA: 0x005986D0 File Offset: 0x005968D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BDF RID: 166879 RVA: 0x005986DD File Offset: 0x005968DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BE0 RID: 166880 RVA: 0x005986E4 File Offset: 0x005968E4
		public static IBvbAiDeployData GetRootAsIBvbAiDeployData(ByteBuffer _bb)
		{
			return IBvbAiDeployData.GetRootAsIBvbAiDeployData(_bb, default(IBvbAiDeployData));
		}

		// Token: 0x06028BE1 RID: 166881 RVA: 0x00598700 File Offset: 0x00596900
		public static IBvbAiDeployData GetRootAsIBvbAiDeployData(ByteBuffer _bb, IBvbAiDeployData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028BE2 RID: 166882 RVA: 0x0059871D File Offset: 0x0059691D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028BE3 RID: 166883 RVA: 0x0059872C File Offset: 0x0059692C
		public IBvbAiDeployData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2B0 RID: 45744
		// (get) Token: 0x06028BE4 RID: 166884 RVA: 0x0059873C File Offset: 0x0059693C
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

		// Token: 0x1700B2B1 RID: 45745
		// (get) Token: 0x06028BE5 RID: 166885 RVA: 0x00598778 File Offset: 0x00596978
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

		// Token: 0x06028BE6 RID: 166886 RVA: 0x005987B4 File Offset: 0x005969B4
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028BE7 RID: 166887 RVA: 0x005987F8 File Offset: 0x005969F8
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028BE8 RID: 166888 RVA: 0x00598814 File Offset: 0x00596A14
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028BE9 RID: 166889 RVA: 0x00598830 File Offset: 0x00596A30
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028BEA RID: 166890 RVA: 0x0059884C File Offset: 0x00596A4C
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028BEB RID: 166891 RVA: 0x00598868 File Offset: 0x00596A68
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2B2 RID: 45746
		// (get) Token: 0x06028BEC RID: 166892 RVA: 0x00598884 File Offset: 0x00596A84
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

		// Token: 0x06028BED RID: 166893 RVA: 0x005988C4 File Offset: 0x00596AC4
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028BEE RID: 166894 RVA: 0x0059890C File Offset: 0x00596B0C
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x06028BEF RID: 166895 RVA: 0x00598928 File Offset: 0x00596B28
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x06028BF0 RID: 166896 RVA: 0x00598944 File Offset: 0x00596B44
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x06028BF1 RID: 166897 RVA: 0x00598960 File Offset: 0x00596B60
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x06028BF2 RID: 166898 RVA: 0x0059897C File Offset: 0x00596B7C
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x06028BF3 RID: 166899 RVA: 0x00598997 File Offset: 0x00596B97
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

		// Token: 0x06028BF4 RID: 166900 RVA: 0x005989CB File Offset: 0x00596BCB
		public static void StartIBvbAiDeployData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028BF5 RID: 166901 RVA: 0x005989D4 File Offset: 0x00596BD4
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028BF6 RID: 166902 RVA: 0x005989DF File Offset: 0x00596BDF
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06028BF7 RID: 166903 RVA: 0x005989EA File Offset: 0x00596BEA
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x06028BF8 RID: 166904 RVA: 0x005989F5 File Offset: 0x00596BF5
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x06028BF9 RID: 166905 RVA: 0x00598A00 File Offset: 0x00596C00
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x06028BFA RID: 166906 RVA: 0x00598A0B File Offset: 0x00596C0B
		public static Offset<IBvbAiDeployData> EndIBvbAiDeployData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDeployData>(builder.EndTable());
		}

		// Token: 0x06028BFB RID: 166907 RVA: 0x00598A18 File Offset: 0x00596C18
		public IBvbAiDeployDataT UnPack()
		{
			IBvbAiDeployDataT bvbAiDeployDataT = new IBvbAiDeployDataT();
			this.UnPackTo(bvbAiDeployDataT);
			return bvbAiDeployDataT;
		}

		// Token: 0x06028BFC RID: 166908 RVA: 0x00598A34 File Offset: 0x00596C34
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

		// Token: 0x06028BFD RID: 166909 RVA: 0x00598D00 File Offset: 0x00596F00
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

		// Token: 0x0400F6CF RID: 63183
		private Table __p;
	}
}
