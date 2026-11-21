using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200635C RID: 25436
	public struct IBvbAiDiscardData : IFlatbufferObject
	{
		// Token: 0x1700BC17 RID: 48151
		// (get) Token: 0x0602B270 RID: 176752 RVA: 0x005E18EC File Offset: 0x005DFAEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B271 RID: 176753 RVA: 0x005E18F9 File Offset: 0x005DFAF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B272 RID: 176754 RVA: 0x005E1900 File Offset: 0x005DFB00
		public static IBvbAiDiscardData GetRootAsIBvbAiDiscardData(ByteBuffer _bb)
		{
			return IBvbAiDiscardData.GetRootAsIBvbAiDiscardData(_bb, default(IBvbAiDiscardData));
		}

		// Token: 0x0602B273 RID: 176755 RVA: 0x005E191C File Offset: 0x005DFB1C
		public static IBvbAiDiscardData GetRootAsIBvbAiDiscardData(ByteBuffer _bb, IBvbAiDiscardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B274 RID: 176756 RVA: 0x005E1939 File Offset: 0x005DFB39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B275 RID: 176757 RVA: 0x005E1948 File Offset: 0x005DFB48
		public IBvbAiDiscardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC18 RID: 48152
		// (get) Token: 0x0602B276 RID: 176758 RVA: 0x005E1958 File Offset: 0x005DFB58
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

		// Token: 0x1700BC19 RID: 48153
		// (get) Token: 0x0602B277 RID: 176759 RVA: 0x005E1994 File Offset: 0x005DFB94
		public TVarRef ReserveHandCardType
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

		// Token: 0x0602B278 RID: 176760 RVA: 0x005E19D0 File Offset: 0x005DFBD0
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B279 RID: 176761 RVA: 0x005E1A14 File Offset: 0x005DFC14
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B27A RID: 176762 RVA: 0x005E1A30 File Offset: 0x005DFC30
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B27B RID: 176763 RVA: 0x005E1A4C File Offset: 0x005DFC4C
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B27C RID: 176764 RVA: 0x005E1A68 File Offset: 0x005DFC68
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B27D RID: 176765 RVA: 0x005E1A84 File Offset: 0x005DFC84
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC1A RID: 48154
		// (get) Token: 0x0602B27E RID: 176766 RVA: 0x005E1AA0 File Offset: 0x005DFCA0
		public EDiscardStrategy Strategy
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDiscardStrategy.LowestScore;
				}
				return (EDiscardStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B27F RID: 176767 RVA: 0x005E1ADD File Offset: 0x005DFCDD
		public static Offset<IBvbAiDiscardData> CreateIBvbAiDiscardData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef ReserveHandCard_type = TVarRef.NONE, int ReserveHandCardOffset = 0, EDiscardStrategy Strategy = EDiscardStrategy.LowestScore)
		{
			builder.StartTable(4);
			IBvbAiDiscardData.AddReserveHandCard(builder, ReserveHandCardOffset);
			IBvbAiDiscardData.AddStrategy(builder, Strategy);
			IBvbAiDiscardData.AddReserveHandCardType(builder, ReserveHandCard_type);
			IBvbAiDiscardData.AddType(builder, Type);
			return IBvbAiDiscardData.EndIBvbAiDiscardData(builder);
		}

		// Token: 0x0602B280 RID: 176768 RVA: 0x005E1B09 File Offset: 0x005DFD09
		public static void StartIBvbAiDiscardData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B281 RID: 176769 RVA: 0x005E1B12 File Offset: 0x005DFD12
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B282 RID: 176770 RVA: 0x005E1B1D File Offset: 0x005DFD1D
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(1, (byte)reserveHandCardType, 0);
		}

		// Token: 0x0602B283 RID: 176771 RVA: 0x005E1B28 File Offset: 0x005DFD28
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(2, reserveHandCardOffset, 0);
		}

		// Token: 0x0602B284 RID: 176772 RVA: 0x005E1B33 File Offset: 0x005DFD33
		public static void AddStrategy(FlatBufferBuilder builder, EDiscardStrategy strategy)
		{
			builder.AddByte(3, (byte)strategy, 0);
		}

		// Token: 0x0602B285 RID: 176773 RVA: 0x005E1B3E File Offset: 0x005DFD3E
		public static Offset<IBvbAiDiscardData> EndIBvbAiDiscardData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDiscardData>(builder.EndTable());
		}

		// Token: 0x0602B286 RID: 176774 RVA: 0x005E1B4C File Offset: 0x005DFD4C
		public IBvbAiDiscardDataT UnPack()
		{
			IBvbAiDiscardDataT bvbAiDiscardDataT = new IBvbAiDiscardDataT();
			this.UnPackTo(bvbAiDiscardDataT);
			return bvbAiDiscardDataT;
		}

		// Token: 0x0602B287 RID: 176775 RVA: 0x005E1B68 File Offset: 0x005DFD68
		public void UnPackTo(IBvbAiDiscardDataT _o)
		{
			_o.Type = this.Type;
			_o.ReserveHandCard = new TVarRefUnion();
			_o.ReserveHandCard.Type = this.ReserveHandCardType;
			switch (this.ReserveHandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IConstVarRef>() != null) ? this.ReserveHandCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IGlobalVarRef>() != null) ? this.ReserveHandCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IOtherVarRef>() != null) ? this.ReserveHandCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISelfVarRef>() != null) ? this.ReserveHandCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISystemVarRef>() != null) ? this.ReserveHandCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.Strategy = this.Strategy;
		}

		// Token: 0x0602B288 RID: 176776 RVA: 0x005E1CF0 File Offset: 0x005DFEF0
		public static Offset<IBvbAiDiscardData> Pack(FlatBufferBuilder builder, IBvbAiDiscardDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiDiscardData>);
			}
			TVarRef reserveHandCard_type = (_o.ReserveHandCard == null) ? TVarRef.NONE : _o.ReserveHandCard.Type;
			int reserveHandCardOffset = (_o.ReserveHandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReserveHandCard);
			return IBvbAiDiscardData.CreateIBvbAiDiscardData(builder, _o.Type, reserveHandCard_type, reserveHandCardOffset, _o.Strategy);
		}

		// Token: 0x04010425 RID: 66597
		private Table __p;
	}
}
