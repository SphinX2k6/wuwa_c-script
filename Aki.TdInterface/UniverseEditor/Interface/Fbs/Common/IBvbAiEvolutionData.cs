using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2B RID: 23851
	public struct IBvbAiEvolutionData : IFlatbufferObject
	{
		// Token: 0x1700B2C4 RID: 45764
		// (get) Token: 0x06028C45 RID: 166981 RVA: 0x005997B0 File Offset: 0x005979B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C46 RID: 166982 RVA: 0x005997BD File Offset: 0x005979BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C47 RID: 166983 RVA: 0x005997C4 File Offset: 0x005979C4
		public static IBvbAiEvolutionData GetRootAsIBvbAiEvolutionData(ByteBuffer _bb)
		{
			return IBvbAiEvolutionData.GetRootAsIBvbAiEvolutionData(_bb, default(IBvbAiEvolutionData));
		}

		// Token: 0x06028C48 RID: 166984 RVA: 0x005997E0 File Offset: 0x005979E0
		public static IBvbAiEvolutionData GetRootAsIBvbAiEvolutionData(ByteBuffer _bb, IBvbAiEvolutionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C49 RID: 166985 RVA: 0x005997FD File Offset: 0x005979FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C4A RID: 166986 RVA: 0x0059980C File Offset: 0x00597A0C
		public IBvbAiEvolutionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2C5 RID: 45765
		// (get) Token: 0x06028C4B RID: 166987 RVA: 0x0059981C File Offset: 0x00597A1C
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

		// Token: 0x1700B2C6 RID: 45766
		// (get) Token: 0x06028C4C RID: 166988 RVA: 0x00599858 File Offset: 0x00597A58
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

		// Token: 0x06028C4D RID: 166989 RVA: 0x00599894 File Offset: 0x00597A94
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C4E RID: 166990 RVA: 0x005998D8 File Offset: 0x00597AD8
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028C4F RID: 166991 RVA: 0x005998F4 File Offset: 0x00597AF4
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028C50 RID: 166992 RVA: 0x00599910 File Offset: 0x00597B10
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028C51 RID: 166993 RVA: 0x0059992C File Offset: 0x00597B2C
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028C52 RID: 166994 RVA: 0x00599948 File Offset: 0x00597B48
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2C7 RID: 45767
		// (get) Token: 0x06028C53 RID: 166995 RVA: 0x00599964 File Offset: 0x00597B64
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

		// Token: 0x06028C54 RID: 166996 RVA: 0x005999A4 File Offset: 0x00597BA4
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C55 RID: 166997 RVA: 0x005999EC File Offset: 0x00597BEC
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x06028C56 RID: 166998 RVA: 0x00599A08 File Offset: 0x00597C08
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028C57 RID: 166999 RVA: 0x00599A24 File Offset: 0x00597C24
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028C58 RID: 167000 RVA: 0x00599A40 File Offset: 0x00597C40
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028C59 RID: 167001 RVA: 0x00599A5C File Offset: 0x00597C5C
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x06028C5A RID: 167002 RVA: 0x00599A77 File Offset: 0x00597C77
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

		// Token: 0x06028C5B RID: 167003 RVA: 0x00599AAB File Offset: 0x00597CAB
		public static void StartIBvbAiEvolutionData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028C5C RID: 167004 RVA: 0x00599AB4 File Offset: 0x00597CB4
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C5D RID: 167005 RVA: 0x00599ABF File Offset: 0x00597CBF
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x06028C5E RID: 167006 RVA: 0x00599ACA File Offset: 0x00597CCA
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x06028C5F RID: 167007 RVA: 0x00599AD5 File Offset: 0x00597CD5
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(3, (byte)boardCardType, 0);
		}

		// Token: 0x06028C60 RID: 167008 RVA: 0x00599AE0 File Offset: 0x00597CE0
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(4, boardCardOffset, 0);
		}

		// Token: 0x06028C61 RID: 167009 RVA: 0x00599AEB File Offset: 0x00597CEB
		public static Offset<IBvbAiEvolutionData> EndIBvbAiEvolutionData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiEvolutionData>(builder.EndTable());
		}

		// Token: 0x06028C62 RID: 167010 RVA: 0x00599AF8 File Offset: 0x00597CF8
		public IBvbAiEvolutionDataT UnPack()
		{
			IBvbAiEvolutionDataT bvbAiEvolutionDataT = new IBvbAiEvolutionDataT();
			this.UnPackTo(bvbAiEvolutionDataT);
			return bvbAiEvolutionDataT;
		}

		// Token: 0x06028C63 RID: 167011 RVA: 0x00599B14 File Offset: 0x00597D14
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

		// Token: 0x06028C64 RID: 167012 RVA: 0x00599DE0 File Offset: 0x00597FE0
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

		// Token: 0x0400F6DB RID: 63195
		private Table __p;
	}
}
