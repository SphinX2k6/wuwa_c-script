using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D25 RID: 23845
	public struct IBvbAiDiscardData : IFlatbufferObject
	{
		// Token: 0x1700B2B6 RID: 45750
		// (get) Token: 0x06028C06 RID: 166918 RVA: 0x00598E7C File Offset: 0x0059707C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C07 RID: 166919 RVA: 0x00598E89 File Offset: 0x00597089
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C08 RID: 166920 RVA: 0x00598E90 File Offset: 0x00597090
		public static IBvbAiDiscardData GetRootAsIBvbAiDiscardData(ByteBuffer _bb)
		{
			return IBvbAiDiscardData.GetRootAsIBvbAiDiscardData(_bb, default(IBvbAiDiscardData));
		}

		// Token: 0x06028C09 RID: 166921 RVA: 0x00598EAC File Offset: 0x005970AC
		public static IBvbAiDiscardData GetRootAsIBvbAiDiscardData(ByteBuffer _bb, IBvbAiDiscardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C0A RID: 166922 RVA: 0x00598EC9 File Offset: 0x005970C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C0B RID: 166923 RVA: 0x00598ED8 File Offset: 0x005970D8
		public IBvbAiDiscardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2B7 RID: 45751
		// (get) Token: 0x06028C0C RID: 166924 RVA: 0x00598EE8 File Offset: 0x005970E8
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

		// Token: 0x1700B2B8 RID: 45752
		// (get) Token: 0x06028C0D RID: 166925 RVA: 0x00598F24 File Offset: 0x00597124
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

		// Token: 0x06028C0E RID: 166926 RVA: 0x00598F60 File Offset: 0x00597160
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C0F RID: 166927 RVA: 0x00598FA4 File Offset: 0x005971A4
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028C10 RID: 166928 RVA: 0x00598FC0 File Offset: 0x005971C0
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028C11 RID: 166929 RVA: 0x00598FDC File Offset: 0x005971DC
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028C12 RID: 166930 RVA: 0x00598FF8 File Offset: 0x005971F8
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028C13 RID: 166931 RVA: 0x00599014 File Offset: 0x00597214
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2B9 RID: 45753
		// (get) Token: 0x06028C14 RID: 166932 RVA: 0x00599030 File Offset: 0x00597230
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

		// Token: 0x06028C15 RID: 166933 RVA: 0x0059906D File Offset: 0x0059726D
		public static Offset<IBvbAiDiscardData> CreateIBvbAiDiscardData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef ReserveHandCard_type = TVarRef.NONE, int ReserveHandCardOffset = 0, EDiscardStrategy Strategy = EDiscardStrategy.LowestScore)
		{
			builder.StartTable(4);
			IBvbAiDiscardData.AddReserveHandCard(builder, ReserveHandCardOffset);
			IBvbAiDiscardData.AddStrategy(builder, Strategy);
			IBvbAiDiscardData.AddReserveHandCardType(builder, ReserveHandCard_type);
			IBvbAiDiscardData.AddType(builder, Type);
			return IBvbAiDiscardData.EndIBvbAiDiscardData(builder);
		}

		// Token: 0x06028C16 RID: 166934 RVA: 0x00599099 File Offset: 0x00597299
		public static void StartIBvbAiDiscardData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028C17 RID: 166935 RVA: 0x005990A2 File Offset: 0x005972A2
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C18 RID: 166936 RVA: 0x005990AD File Offset: 0x005972AD
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(1, (byte)reserveHandCardType, 0);
		}

		// Token: 0x06028C19 RID: 166937 RVA: 0x005990B8 File Offset: 0x005972B8
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(2, reserveHandCardOffset, 0);
		}

		// Token: 0x06028C1A RID: 166938 RVA: 0x005990C3 File Offset: 0x005972C3
		public static void AddStrategy(FlatBufferBuilder builder, EDiscardStrategy strategy)
		{
			builder.AddByte(3, (byte)strategy, 0);
		}

		// Token: 0x06028C1B RID: 166939 RVA: 0x005990CE File Offset: 0x005972CE
		public static Offset<IBvbAiDiscardData> EndIBvbAiDiscardData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDiscardData>(builder.EndTable());
		}

		// Token: 0x06028C1C RID: 166940 RVA: 0x005990DC File Offset: 0x005972DC
		public IBvbAiDiscardDataT UnPack()
		{
			IBvbAiDiscardDataT bvbAiDiscardDataT = new IBvbAiDiscardDataT();
			this.UnPackTo(bvbAiDiscardDataT);
			return bvbAiDiscardDataT;
		}

		// Token: 0x06028C1D RID: 166941 RVA: 0x005990F8 File Offset: 0x005972F8
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

		// Token: 0x06028C1E RID: 166942 RVA: 0x00599280 File Offset: 0x00597480
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

		// Token: 0x0400F6D3 RID: 63187
		private Table __p;
	}
}
