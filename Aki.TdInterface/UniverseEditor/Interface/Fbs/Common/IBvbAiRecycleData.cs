using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006374 RID: 25460
	public struct IBvbAiRecycleData : IFlatbufferObject
	{
		// Token: 0x1700BC4F RID: 48207
		// (get) Token: 0x0602B39F RID: 177055 RVA: 0x005E5028 File Offset: 0x005E3228
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3A0 RID: 177056 RVA: 0x005E5035 File Offset: 0x005E3235
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3A1 RID: 177057 RVA: 0x005E503C File Offset: 0x005E323C
		public static IBvbAiRecycleData GetRootAsIBvbAiRecycleData(ByteBuffer _bb)
		{
			return IBvbAiRecycleData.GetRootAsIBvbAiRecycleData(_bb, default(IBvbAiRecycleData));
		}

		// Token: 0x0602B3A2 RID: 177058 RVA: 0x005E5058 File Offset: 0x005E3258
		public static IBvbAiRecycleData GetRootAsIBvbAiRecycleData(ByteBuffer _bb, IBvbAiRecycleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3A3 RID: 177059 RVA: 0x005E5075 File Offset: 0x005E3275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3A4 RID: 177060 RVA: 0x005E5084 File Offset: 0x005E3284
		public IBvbAiRecycleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC50 RID: 48208
		// (get) Token: 0x0602B3A5 RID: 177061 RVA: 0x005E5094 File Offset: 0x005E3294
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

		// Token: 0x1700BC51 RID: 48209
		// (get) Token: 0x0602B3A6 RID: 177062 RVA: 0x005E50D0 File Offset: 0x005E32D0
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

		// Token: 0x0602B3A7 RID: 177063 RVA: 0x005E510C File Offset: 0x005E330C
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B3A8 RID: 177064 RVA: 0x005E5150 File Offset: 0x005E3350
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B3A9 RID: 177065 RVA: 0x005E516C File Offset: 0x005E336C
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B3AA RID: 177066 RVA: 0x005E5188 File Offset: 0x005E3388
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B3AB RID: 177067 RVA: 0x005E51A4 File Offset: 0x005E33A4
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B3AC RID: 177068 RVA: 0x005E51C0 File Offset: 0x005E33C0
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x0602B3AD RID: 177069 RVA: 0x005E51DB File Offset: 0x005E33DB
		public static Offset<IBvbAiRecycleData> CreateIBvbAiRecycleData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard_type = TVarRef.NONE, int BoardCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbAiRecycleData.AddBoardCard(builder, BoardCardOffset);
			IBvbAiRecycleData.AddBoardCardType(builder, BoardCard_type);
			IBvbAiRecycleData.AddType(builder, Type);
			return IBvbAiRecycleData.EndIBvbAiRecycleData(builder);
		}

		// Token: 0x0602B3AE RID: 177070 RVA: 0x005E51FF File Offset: 0x005E33FF
		public static void StartIBvbAiRecycleData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B3AF RID: 177071 RVA: 0x005E5208 File Offset: 0x005E3408
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B3B0 RID: 177072 RVA: 0x005E5213 File Offset: 0x005E3413
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(1, (byte)boardCardType, 0);
		}

		// Token: 0x0602B3B1 RID: 177073 RVA: 0x005E521E File Offset: 0x005E341E
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(2, boardCardOffset, 0);
		}

		// Token: 0x0602B3B2 RID: 177074 RVA: 0x005E5229 File Offset: 0x005E3429
		public static Offset<IBvbAiRecycleData> EndIBvbAiRecycleData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiRecycleData>(builder.EndTable());
		}

		// Token: 0x0602B3B3 RID: 177075 RVA: 0x005E5238 File Offset: 0x005E3438
		public IBvbAiRecycleDataT UnPack()
		{
			IBvbAiRecycleDataT bvbAiRecycleDataT = new IBvbAiRecycleDataT();
			this.UnPackTo(bvbAiRecycleDataT);
			return bvbAiRecycleDataT;
		}

		// Token: 0x0602B3B4 RID: 177076 RVA: 0x005E5254 File Offset: 0x005E3454
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

		// Token: 0x0602B3B5 RID: 177077 RVA: 0x005E53C0 File Offset: 0x005E35C0
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

		// Token: 0x04010445 RID: 66629
		private Table __p;
	}
}
