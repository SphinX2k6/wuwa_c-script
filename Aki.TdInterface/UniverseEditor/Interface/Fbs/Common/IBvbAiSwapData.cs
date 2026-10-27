using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D40 RID: 23872
	public struct IBvbAiSwapData : IFlatbufferObject
	{
		// Token: 0x1700B2F3 RID: 45811
		// (get) Token: 0x06028D52 RID: 167250 RVA: 0x0059CA44 File Offset: 0x0059AC44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D53 RID: 167251 RVA: 0x0059CA51 File Offset: 0x0059AC51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D54 RID: 167252 RVA: 0x0059CA58 File Offset: 0x0059AC58
		public static IBvbAiSwapData GetRootAsIBvbAiSwapData(ByteBuffer _bb)
		{
			return IBvbAiSwapData.GetRootAsIBvbAiSwapData(_bb, default(IBvbAiSwapData));
		}

		// Token: 0x06028D55 RID: 167253 RVA: 0x0059CA74 File Offset: 0x0059AC74
		public static IBvbAiSwapData GetRootAsIBvbAiSwapData(ByteBuffer _bb, IBvbAiSwapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D56 RID: 167254 RVA: 0x0059CA91 File Offset: 0x0059AC91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D57 RID: 167255 RVA: 0x0059CAA0 File Offset: 0x0059ACA0
		public IBvbAiSwapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2F4 RID: 45812
		// (get) Token: 0x06028D58 RID: 167256 RVA: 0x0059CAB0 File Offset: 0x0059ACB0
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

		// Token: 0x1700B2F5 RID: 45813
		// (get) Token: 0x06028D59 RID: 167257 RVA: 0x0059CAEC File Offset: 0x0059ACEC
		public TVarRef BoardCard1Type
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

		// Token: 0x06028D5A RID: 167258 RVA: 0x0059CB28 File Offset: 0x0059AD28
		public TTable? BoardCard1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028D5B RID: 167259 RVA: 0x0059CB6C File Offset: 0x0059AD6C
		public IConstVarRef BoardCard1AsIConstVarRef()
		{
			return this.BoardCard1<IConstVarRef>().Value;
		}

		// Token: 0x06028D5C RID: 167260 RVA: 0x0059CB88 File Offset: 0x0059AD88
		public IGlobalVarRef BoardCard1AsIGlobalVarRef()
		{
			return this.BoardCard1<IGlobalVarRef>().Value;
		}

		// Token: 0x06028D5D RID: 167261 RVA: 0x0059CBA4 File Offset: 0x0059ADA4
		public IOtherVarRef BoardCard1AsIOtherVarRef()
		{
			return this.BoardCard1<IOtherVarRef>().Value;
		}

		// Token: 0x06028D5E RID: 167262 RVA: 0x0059CBC0 File Offset: 0x0059ADC0
		public ISelfVarRef BoardCard1AsISelfVarRef()
		{
			return this.BoardCard1<ISelfVarRef>().Value;
		}

		// Token: 0x06028D5F RID: 167263 RVA: 0x0059CBDC File Offset: 0x0059ADDC
		public ISystemVarRef BoardCard1AsISystemVarRef()
		{
			return this.BoardCard1<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2F6 RID: 45814
		// (get) Token: 0x06028D60 RID: 167264 RVA: 0x0059CBF8 File Offset: 0x0059ADF8
		public TVarRef BoardCard2Type
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

		// Token: 0x06028D61 RID: 167265 RVA: 0x0059CC38 File Offset: 0x0059AE38
		public TTable? BoardCard2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028D62 RID: 167266 RVA: 0x0059CC80 File Offset: 0x0059AE80
		public IConstVarRef BoardCard2AsIConstVarRef()
		{
			return this.BoardCard2<IConstVarRef>().Value;
		}

		// Token: 0x06028D63 RID: 167267 RVA: 0x0059CC9C File Offset: 0x0059AE9C
		public IGlobalVarRef BoardCard2AsIGlobalVarRef()
		{
			return this.BoardCard2<IGlobalVarRef>().Value;
		}

		// Token: 0x06028D64 RID: 167268 RVA: 0x0059CCB8 File Offset: 0x0059AEB8
		public IOtherVarRef BoardCard2AsIOtherVarRef()
		{
			return this.BoardCard2<IOtherVarRef>().Value;
		}

		// Token: 0x06028D65 RID: 167269 RVA: 0x0059CCD4 File Offset: 0x0059AED4
		public ISelfVarRef BoardCard2AsISelfVarRef()
		{
			return this.BoardCard2<ISelfVarRef>().Value;
		}

		// Token: 0x06028D66 RID: 167270 RVA: 0x0059CCF0 File Offset: 0x0059AEF0
		public ISystemVarRef BoardCard2AsISystemVarRef()
		{
			return this.BoardCard2<ISystemVarRef>().Value;
		}

		// Token: 0x06028D67 RID: 167271 RVA: 0x0059CD0B File Offset: 0x0059AF0B
		public static Offset<IBvbAiSwapData> CreateIBvbAiSwapData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard1_type = TVarRef.NONE, int BoardCard1Offset = 0, TVarRef BoardCard2_type = TVarRef.NONE, int BoardCard2Offset = 0)
		{
			builder.StartTable(5);
			IBvbAiSwapData.AddBoardCard2(builder, BoardCard2Offset);
			IBvbAiSwapData.AddBoardCard1(builder, BoardCard1Offset);
			IBvbAiSwapData.AddBoardCard2Type(builder, BoardCard2_type);
			IBvbAiSwapData.AddBoardCard1Type(builder, BoardCard1_type);
			IBvbAiSwapData.AddType(builder, Type);
			return IBvbAiSwapData.EndIBvbAiSwapData(builder);
		}

		// Token: 0x06028D68 RID: 167272 RVA: 0x0059CD3F File Offset: 0x0059AF3F
		public static void StartIBvbAiSwapData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028D69 RID: 167273 RVA: 0x0059CD48 File Offset: 0x0059AF48
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D6A RID: 167274 RVA: 0x0059CD53 File Offset: 0x0059AF53
		public static void AddBoardCard1Type(FlatBufferBuilder builder, TVarRef boardCard1Type)
		{
			builder.AddByte(1, (byte)boardCard1Type, 0);
		}

		// Token: 0x06028D6B RID: 167275 RVA: 0x0059CD5E File Offset: 0x0059AF5E
		public static void AddBoardCard1(FlatBufferBuilder builder, int boardCard1Offset)
		{
			builder.AddOffset(2, boardCard1Offset, 0);
		}

		// Token: 0x06028D6C RID: 167276 RVA: 0x0059CD69 File Offset: 0x0059AF69
		public static void AddBoardCard2Type(FlatBufferBuilder builder, TVarRef boardCard2Type)
		{
			builder.AddByte(3, (byte)boardCard2Type, 0);
		}

		// Token: 0x06028D6D RID: 167277 RVA: 0x0059CD74 File Offset: 0x0059AF74
		public static void AddBoardCard2(FlatBufferBuilder builder, int boardCard2Offset)
		{
			builder.AddOffset(4, boardCard2Offset, 0);
		}

		// Token: 0x06028D6E RID: 167278 RVA: 0x0059CD7F File Offset: 0x0059AF7F
		public static Offset<IBvbAiSwapData> EndIBvbAiSwapData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiSwapData>(builder.EndTable());
		}

		// Token: 0x06028D6F RID: 167279 RVA: 0x0059CD8C File Offset: 0x0059AF8C
		public IBvbAiSwapDataT UnPack()
		{
			IBvbAiSwapDataT bvbAiSwapDataT = new IBvbAiSwapDataT();
			this.UnPackTo(bvbAiSwapDataT);
			return bvbAiSwapDataT;
		}

		// Token: 0x06028D70 RID: 167280 RVA: 0x0059CDA8 File Offset: 0x0059AFA8
		public void UnPackTo(IBvbAiSwapDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCard1 = new TVarRefUnion();
			_o.BoardCard1.Type = this.BoardCard1Type;
			switch (this.BoardCard1Type)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IConstVarRef>() != null) ? this.BoardCard1<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IGlobalVarRef>() != null) ? this.BoardCard1<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IOtherVarRef>() != null) ? this.BoardCard1<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<ISelfVarRef>() != null) ? this.BoardCard1<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<ISystemVarRef>() != null) ? this.BoardCard1<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardCard2 = new TVarRefUnion();
			_o.BoardCard2.Type = this.BoardCard2Type;
			switch (this.BoardCard2Type)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IConstVarRef>() != null) ? this.BoardCard2<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IGlobalVarRef>() != null) ? this.BoardCard2<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IOtherVarRef>() != null) ? this.BoardCard2<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<ISelfVarRef>() != null) ? this.BoardCard2<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<ISystemVarRef>() != null) ? this.BoardCard2<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028D71 RID: 167281 RVA: 0x0059D074 File Offset: 0x0059B274
		public static Offset<IBvbAiSwapData> Pack(FlatBufferBuilder builder, IBvbAiSwapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiSwapData>);
			}
			TVarRef boardCard1_type = (_o.BoardCard1 == null) ? TVarRef.NONE : _o.BoardCard1.Type;
			int boardCard1Offset = (_o.BoardCard1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard1);
			TVarRef boardCard2_type = (_o.BoardCard2 == null) ? TVarRef.NONE : _o.BoardCard2.Type;
			int boardCard2Offset = (_o.BoardCard2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard2);
			return IBvbAiSwapData.CreateIBvbAiSwapData(builder, _o.Type, boardCard1_type, boardCard1Offset, boardCard2_type, boardCard2Offset);
		}

		// Token: 0x0400F6F6 RID: 63222
		private Table __p;
	}
}
