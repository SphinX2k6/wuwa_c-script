using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006356 RID: 25430
	public struct IBvbAiChangeData : IFlatbufferObject
	{
		// Token: 0x1700BC0B RID: 48139
		// (get) Token: 0x0602B22B RID: 176683 RVA: 0x005E0CB1 File Offset: 0x005DEEB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B22C RID: 176684 RVA: 0x005E0CBE File Offset: 0x005DEEBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B22D RID: 176685 RVA: 0x005E0CC8 File Offset: 0x005DEEC8
		public static IBvbAiChangeData GetRootAsIBvbAiChangeData(ByteBuffer _bb)
		{
			return IBvbAiChangeData.GetRootAsIBvbAiChangeData(_bb, default(IBvbAiChangeData));
		}

		// Token: 0x0602B22E RID: 176686 RVA: 0x005E0CE4 File Offset: 0x005DEEE4
		public static IBvbAiChangeData GetRootAsIBvbAiChangeData(ByteBuffer _bb, IBvbAiChangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B22F RID: 176687 RVA: 0x005E0D01 File Offset: 0x005DEF01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B230 RID: 176688 RVA: 0x005E0D10 File Offset: 0x005DEF10
		public IBvbAiChangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC0C RID: 48140
		// (get) Token: 0x0602B231 RID: 176689 RVA: 0x005E0D20 File Offset: 0x005DEF20
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

		// Token: 0x1700BC0D RID: 48141
		// (get) Token: 0x0602B232 RID: 176690 RVA: 0x005E0D5C File Offset: 0x005DEF5C
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

		// Token: 0x0602B233 RID: 176691 RVA: 0x005E0D98 File Offset: 0x005DEF98
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B234 RID: 176692 RVA: 0x005E0DDC File Offset: 0x005DEFDC
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B235 RID: 176693 RVA: 0x005E0DF8 File Offset: 0x005DEFF8
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B236 RID: 176694 RVA: 0x005E0E14 File Offset: 0x005DF014
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B237 RID: 176695 RVA: 0x005E0E30 File Offset: 0x005DF030
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B238 RID: 176696 RVA: 0x005E0E4C File Offset: 0x005DF04C
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x0602B239 RID: 176697 RVA: 0x005E0E67 File Offset: 0x005DF067
		public static Offset<IBvbAiChangeData> CreateIBvbAiChangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0)
		{
			builder.StartTable(3);
			IBvbAiChangeData.AddHandCard(builder, HandCardOffset);
			IBvbAiChangeData.AddHandCardType(builder, HandCard_type);
			IBvbAiChangeData.AddType(builder, Type);
			return IBvbAiChangeData.EndIBvbAiChangeData(builder);
		}

		// Token: 0x0602B23A RID: 176698 RVA: 0x005E0E8B File Offset: 0x005DF08B
		public static void StartIBvbAiChangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B23B RID: 176699 RVA: 0x005E0E94 File Offset: 0x005DF094
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B23C RID: 176700 RVA: 0x005E0E9F File Offset: 0x005DF09F
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0602B23D RID: 176701 RVA: 0x005E0EAA File Offset: 0x005DF0AA
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0602B23E RID: 176702 RVA: 0x005E0EB5 File Offset: 0x005DF0B5
		public static Offset<IBvbAiChangeData> EndIBvbAiChangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiChangeData>(builder.EndTable());
		}

		// Token: 0x0602B23F RID: 176703 RVA: 0x005E0EC4 File Offset: 0x005DF0C4
		public IBvbAiChangeDataT UnPack()
		{
			IBvbAiChangeDataT bvbAiChangeDataT = new IBvbAiChangeDataT();
			this.UnPackTo(bvbAiChangeDataT);
			return bvbAiChangeDataT;
		}

		// Token: 0x0602B240 RID: 176704 RVA: 0x005E0EE0 File Offset: 0x005DF0E0
		public void UnPackTo(IBvbAiChangeDataT _o)
		{
			_o.Type = this.Type;
			_o.HandCard = new TVarRefUnion();
			_o.HandCard.Type = this.HandCardType;
			switch (this.HandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.HandCard.Value = ((this.HandCard<IConstVarRef>() != null) ? this.HandCard<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.HandCard.Value = ((this.HandCard<IGlobalVarRef>() != null) ? this.HandCard<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.HandCard.Value = ((this.HandCard<IOtherVarRef>() != null) ? this.HandCard<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.HandCard.Value = ((this.HandCard<ISelfVarRef>() != null) ? this.HandCard<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.HandCard.Value = ((this.HandCard<ISystemVarRef>() != null) ? this.HandCard<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B241 RID: 176705 RVA: 0x005E104C File Offset: 0x005DF24C
		public static Offset<IBvbAiChangeData> Pack(FlatBufferBuilder builder, IBvbAiChangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiChangeData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			return IBvbAiChangeData.CreateIBvbAiChangeData(builder, _o.Type, handCard_type, handCardOffset);
		}

		// Token: 0x0401041E RID: 66590
		private Table __p;
	}
}
