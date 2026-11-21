using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200792F RID: 31023
	public struct ISoaringChallengeSettlement : IFlatbufferObject
	{
		// Token: 0x1700E393 RID: 58259
		// (get) Token: 0x06036A1A RID: 223770 RVA: 0x0074F809 File Offset: 0x0074DA09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A1B RID: 223771 RVA: 0x0074F816 File Offset: 0x0074DA16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A1C RID: 223772 RVA: 0x0074F820 File Offset: 0x0074DA20
		public static ISoaringChallengeSettlement GetRootAsISoaringChallengeSettlement(ByteBuffer _bb)
		{
			return ISoaringChallengeSettlement.GetRootAsISoaringChallengeSettlement(_bb, default(ISoaringChallengeSettlement));
		}

		// Token: 0x06036A1D RID: 223773 RVA: 0x0074F83C File Offset: 0x0074DA3C
		public static ISoaringChallengeSettlement GetRootAsISoaringChallengeSettlement(ByteBuffer _bb, ISoaringChallengeSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A1E RID: 223774 RVA: 0x0074F859 File Offset: 0x0074DA59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A1F RID: 223775 RVA: 0x0074F868 File Offset: 0x0074DA68
		public ISoaringChallengeSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E394 RID: 58260
		// (get) Token: 0x06036A20 RID: 223776 RVA: 0x0074F878 File Offset: 0x0074DA78
		public EDynamicSettlementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicSettlementType.Battle;
				}
				return (EDynamicSettlementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A21 RID: 223777 RVA: 0x0074F8B4 File Offset: 0x0074DAB4
		public static Offset<ISoaringChallengeSettlement> CreateISoaringChallengeSettlement(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle)
		{
			builder.StartTable(1);
			ISoaringChallengeSettlement.AddType(builder, Type);
			return ISoaringChallengeSettlement.EndISoaringChallengeSettlement(builder);
		}

		// Token: 0x06036A22 RID: 223778 RVA: 0x0074F8CA File Offset: 0x0074DACA
		public static void StartISoaringChallengeSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036A23 RID: 223779 RVA: 0x0074F8D3 File Offset: 0x0074DAD3
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A24 RID: 223780 RVA: 0x0074F8DE File Offset: 0x0074DADE
		public static Offset<ISoaringChallengeSettlement> EndISoaringChallengeSettlement(FlatBufferBuilder builder)
		{
			return new Offset<ISoaringChallengeSettlement>(builder.EndTable());
		}

		// Token: 0x06036A25 RID: 223781 RVA: 0x0074F8EC File Offset: 0x0074DAEC
		public ISoaringChallengeSettlementT UnPack()
		{
			ISoaringChallengeSettlementT soaringChallengeSettlementT = new ISoaringChallengeSettlementT();
			this.UnPackTo(soaringChallengeSettlementT);
			return soaringChallengeSettlementT;
		}

		// Token: 0x06036A26 RID: 223782 RVA: 0x0074F907 File Offset: 0x0074DB07
		public void UnPackTo(ISoaringChallengeSettlementT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036A27 RID: 223783 RVA: 0x0074F918 File Offset: 0x0074DB18
		public static Offset<ISoaringChallengeSettlement> Pack(FlatBufferBuilder builder, ISoaringChallengeSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoaringChallengeSettlement>);
			}
			return ISoaringChallengeSettlement.CreateISoaringChallengeSettlement(builder, _o.Type);
		}

		// Token: 0x04012BF6 RID: 76790
		private Table __p;
	}
}
