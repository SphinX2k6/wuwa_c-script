using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3D RID: 23869
	public struct IBvbAiRecycleData : IFlatbufferObject
	{
		// Token: 0x1700B2EE RID: 45806
		// (get) Token: 0x06028D35 RID: 167221 RVA: 0x0059C5B8 File Offset: 0x0059A7B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D36 RID: 167222 RVA: 0x0059C5C5 File Offset: 0x0059A7C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D37 RID: 167223 RVA: 0x0059C5CC File Offset: 0x0059A7CC
		public static IBvbAiRecycleData GetRootAsIBvbAiRecycleData(ByteBuffer _bb)
		{
			return IBvbAiRecycleData.GetRootAsIBvbAiRecycleData(_bb, default(IBvbAiRecycleData));
		}

		// Token: 0x06028D38 RID: 167224 RVA: 0x0059C5E8 File Offset: 0x0059A7E8
		public static IBvbAiRecycleData GetRootAsIBvbAiRecycleData(ByteBuffer _bb, IBvbAiRecycleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D39 RID: 167225 RVA: 0x0059C605 File Offset: 0x0059A805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D3A RID: 167226 RVA: 0x0059C614 File Offset: 0x0059A814
		public IBvbAiRecycleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2EF RID: 45807
		// (get) Token: 0x06028D3B RID: 167227 RVA: 0x0059C624 File Offset: 0x0059A824
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

		// Token: 0x1700B2F0 RID: 45808
		// (get) Token: 0x06028D3C RID: 167228 RVA: 0x0059C660 File Offset: 0x0059A860
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

		// Token: 0x06028D3D RID: 167229 RVA: 0x0059C69C File Offset: 0x0059A89C
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028D3E RID: 167230 RVA: 0x0059C6E0 File Offset: 0x0059A8E0
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x06028D3F RID: 167231 RVA: 0x0059C6FC File Offset: 0x0059A8FC
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028D40 RID: 167232 RVA: 0x0059C718 File Offset: 0x0059A918
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028D41 RID: 167233 RVA: 0x0059C734 File Offset: 0x0059A934
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028D42 RID: 167234 RVA: 0x0059C750 File Offset: 0x0059A950
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x06028D43 RID: 167235 RVA: 0x0059C76B File Offset: 0x0059A96B
		public static Offset<IBvbAiRecycleData> CreateIBvbAiRecycleData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard_type = TVarRef.NONE, int BoardCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbAiRecycleData.AddBoardCard(builder, BoardCardOffset);
			IBvbAiRecycleData.AddBoardCardType(builder, BoardCard_type);
			IBvbAiRecycleData.AddType(builder, Type);
			return IBvbAiRecycleData.EndIBvbAiRecycleData(builder);
		}

		// Token: 0x06028D44 RID: 167236 RVA: 0x0059C78F File Offset: 0x0059A98F
		public static void StartIBvbAiRecycleData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028D45 RID: 167237 RVA: 0x0059C798 File Offset: 0x0059A998
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D46 RID: 167238 RVA: 0x0059C7A3 File Offset: 0x0059A9A3
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(1, (byte)boardCardType, 0);
		}

		// Token: 0x06028D47 RID: 167239 RVA: 0x0059C7AE File Offset: 0x0059A9AE
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(2, boardCardOffset, 0);
		}

		// Token: 0x06028D48 RID: 167240 RVA: 0x0059C7B9 File Offset: 0x0059A9B9
		public static Offset<IBvbAiRecycleData> EndIBvbAiRecycleData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiRecycleData>(builder.EndTable());
		}

		// Token: 0x06028D49 RID: 167241 RVA: 0x0059C7C8 File Offset: 0x0059A9C8
		public IBvbAiRecycleDataT UnPack()
		{
			IBvbAiRecycleDataT bvbAiRecycleDataT = new IBvbAiRecycleDataT();
			this.UnPackTo(bvbAiRecycleDataT);
			return bvbAiRecycleDataT;
		}

		// Token: 0x06028D4A RID: 167242 RVA: 0x0059C7E4 File Offset: 0x0059A9E4
		public void UnPackTo(IBvbAiRecycleDataT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x06028D4B RID: 167243 RVA: 0x0059C950 File Offset: 0x0059AB50
		public static Offset<IBvbAiRecycleData> Pack(FlatBufferBuilder builder, IBvbAiRecycleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiRecycleData>);
			}
			TVarRef boardCard_type = (_o.BoardCard == null) ? TVarRef.NONE : _o.BoardCard.Type;
			int boardCardOffset = (_o.BoardCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard);
			return IBvbAiRecycleData.CreateIBvbAiRecycleData(builder, _o.Type, boardCard_type, boardCardOffset);
		}

		// Token: 0x0400F6F3 RID: 63219
		private Table __p;
	}
}
