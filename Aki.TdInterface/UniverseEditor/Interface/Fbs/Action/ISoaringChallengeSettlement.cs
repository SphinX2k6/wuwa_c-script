using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007163 RID: 29027
	public struct ISoaringChallengeSettlement : IFlatbufferObject
	{
		// Token: 0x1700D7AE RID: 55214
		// (get) Token: 0x06033770 RID: 210800 RVA: 0x006EEFFD File Offset: 0x006ED1FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033771 RID: 210801 RVA: 0x006EF00A File Offset: 0x006ED20A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033772 RID: 210802 RVA: 0x006EF014 File Offset: 0x006ED214
		public static ISoaringChallengeSettlement GetRootAsISoaringChallengeSettlement(ByteBuffer _bb)
		{
			return ISoaringChallengeSettlement.GetRootAsISoaringChallengeSettlement(_bb, default(ISoaringChallengeSettlement));
		}

		// Token: 0x06033773 RID: 210803 RVA: 0x006EF030 File Offset: 0x006ED230
		public static ISoaringChallengeSettlement GetRootAsISoaringChallengeSettlement(ByteBuffer _bb, ISoaringChallengeSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033774 RID: 210804 RVA: 0x006EF04D File Offset: 0x006ED24D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033775 RID: 210805 RVA: 0x006EF05C File Offset: 0x006ED25C
		public ISoaringChallengeSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7AF RID: 55215
		// (get) Token: 0x06033776 RID: 210806 RVA: 0x006EF06C File Offset: 0x006ED26C
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

		// Token: 0x06033777 RID: 210807 RVA: 0x006EF0A8 File Offset: 0x006ED2A8
		public static Offset<ISoaringChallengeSettlement> CreateISoaringChallengeSettlement(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle)
		{
			builder.StartTable(1);
			ISoaringChallengeSettlement.AddType(builder, Type);
			return ISoaringChallengeSettlement.EndISoaringChallengeSettlement(builder);
		}

		// Token: 0x06033778 RID: 210808 RVA: 0x006EF0BE File Offset: 0x006ED2BE
		public static void StartISoaringChallengeSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033779 RID: 210809 RVA: 0x006EF0C7 File Offset: 0x006ED2C7
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603377A RID: 210810 RVA: 0x006EF0D2 File Offset: 0x006ED2D2
		public static Offset<ISoaringChallengeSettlement> EndISoaringChallengeSettlement(FlatBufferBuilder builder)
		{
			return new Offset<ISoaringChallengeSettlement>(builder.EndTable());
		}

		// Token: 0x0603377B RID: 210811 RVA: 0x006EF0E0 File Offset: 0x006ED2E0
		public ISoaringChallengeSettlementT UnPack()
		{
			ISoaringChallengeSettlementT soaringChallengeSettlementT = new ISoaringChallengeSettlementT();
			this.UnPackTo(soaringChallengeSettlementT);
			return soaringChallengeSettlementT;
		}

		// Token: 0x0603377C RID: 210812 RVA: 0x006EF0FB File Offset: 0x006ED2FB
		public void UnPackTo(ISoaringChallengeSettlementT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603377D RID: 210813 RVA: 0x006EF10C File Offset: 0x006ED30C
		public static Offset<ISoaringChallengeSettlement> Pack(FlatBufferBuilder builder, ISoaringChallengeSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoaringChallengeSettlement>);
			}
			return ISoaringChallengeSettlement.CreateISoaringChallengeSettlement(builder, _o.Type);
		}

		// Token: 0x04011C07 RID: 72711
		private Table __p;
	}
}
