using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007456 RID: 29782
	public struct IPlayDynamicSettlement : IFlatbufferObject
	{
		// Token: 0x1700DAE1 RID: 56033
		// (get) Token: 0x0603422E RID: 213550 RVA: 0x0070655E File Offset: 0x0070475E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603422F RID: 213551 RVA: 0x0070656B File Offset: 0x0070476B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034230 RID: 213552 RVA: 0x00706574 File Offset: 0x00704774
		public static IPlayDynamicSettlement GetRootAsIPlayDynamicSettlement(ByteBuffer _bb)
		{
			return IPlayDynamicSettlement.GetRootAsIPlayDynamicSettlement(_bb, default(IPlayDynamicSettlement));
		}

		// Token: 0x06034231 RID: 213553 RVA: 0x00706590 File Offset: 0x00704790
		public static IPlayDynamicSettlement GetRootAsIPlayDynamicSettlement(ByteBuffer _bb, IPlayDynamicSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034232 RID: 213554 RVA: 0x007065AD File Offset: 0x007047AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034233 RID: 213555 RVA: 0x007065BC File Offset: 0x007047BC
		public IPlayDynamicSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAE2 RID: 56034
		// (get) Token: 0x06034234 RID: 213556 RVA: 0x007065CC File Offset: 0x007047CC
		public TDynamicSettlementConfig DynamicSettlementConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TDynamicSettlementConfig.NONE;
				}
				return (TDynamicSettlementConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034235 RID: 213557 RVA: 0x00706608 File Offset: 0x00704808
		public TTable? DynamicSettlementConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034236 RID: 213558 RVA: 0x0070664C File Offset: 0x0070484C
		public IBattleSettlement DynamicSettlementConfigAsIBattleSettlement()
		{
			return this.DynamicSettlementConfig<IBattleSettlement>().Value;
		}

		// Token: 0x06034237 RID: 213559 RVA: 0x00706668 File Offset: 0x00704868
		public ISoaringChallengeSettlement DynamicSettlementConfigAsISoaringChallengeSettlement()
		{
			return this.DynamicSettlementConfig<ISoaringChallengeSettlement>().Value;
		}

		// Token: 0x06034238 RID: 213560 RVA: 0x00706683 File Offset: 0x00704883
		public static Offset<IPlayDynamicSettlement> CreateIPlayDynamicSettlement(FlatBufferBuilder builder, TDynamicSettlementConfig DynamicSettlementConfig_type = TDynamicSettlementConfig.NONE, int DynamicSettlementConfigOffset = 0)
		{
			builder.StartTable(2);
			IPlayDynamicSettlement.AddDynamicSettlementConfig(builder, DynamicSettlementConfigOffset);
			IPlayDynamicSettlement.AddDynamicSettlementConfigType(builder, DynamicSettlementConfig_type);
			return IPlayDynamicSettlement.EndIPlayDynamicSettlement(builder);
		}

		// Token: 0x06034239 RID: 213561 RVA: 0x007066A0 File Offset: 0x007048A0
		public static void StartIPlayDynamicSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603423A RID: 213562 RVA: 0x007066A9 File Offset: 0x007048A9
		public static void AddDynamicSettlementConfigType(FlatBufferBuilder builder, TDynamicSettlementConfig dynamicSettlementConfigType)
		{
			builder.AddByte(0, (byte)dynamicSettlementConfigType, 0);
		}

		// Token: 0x0603423B RID: 213563 RVA: 0x007066B4 File Offset: 0x007048B4
		public static void AddDynamicSettlementConfig(FlatBufferBuilder builder, int dynamicSettlementConfigOffset)
		{
			builder.AddOffset(1, dynamicSettlementConfigOffset, 0);
		}

		// Token: 0x0603423C RID: 213564 RVA: 0x007066BF File Offset: 0x007048BF
		public static Offset<IPlayDynamicSettlement> EndIPlayDynamicSettlement(FlatBufferBuilder builder)
		{
			return new Offset<IPlayDynamicSettlement>(builder.EndTable());
		}

		// Token: 0x0603423D RID: 213565 RVA: 0x007066CC File Offset: 0x007048CC
		public IPlayDynamicSettlementT UnPack()
		{
			IPlayDynamicSettlementT playDynamicSettlementT = new IPlayDynamicSettlementT();
			this.UnPackTo(playDynamicSettlementT);
			return playDynamicSettlementT;
		}

		// Token: 0x0603423E RID: 213566 RVA: 0x007066E8 File Offset: 0x007048E8
		public void UnPackTo(IPlayDynamicSettlementT _o)
		{
			_o.DynamicSettlementConfig = new TDynamicSettlementConfigUnion();
			_o.DynamicSettlementConfig.Type = this.DynamicSettlementConfigType;
			TDynamicSettlementConfig dynamicSettlementConfigType = this.DynamicSettlementConfigType;
			if (dynamicSettlementConfigType == TDynamicSettlementConfig.IBattleSettlement)
			{
				_o.DynamicSettlementConfig.Value = ((this.DynamicSettlementConfig<IBattleSettlement>() != null) ? this.DynamicSettlementConfig<IBattleSettlement>().Value.UnPack() : null);
				return;
			}
			if (dynamicSettlementConfigType != TDynamicSettlementConfig.ISoaringChallengeSettlement)
			{
				return;
			}
			_o.DynamicSettlementConfig.Value = ((this.DynamicSettlementConfig<ISoaringChallengeSettlement>() != null) ? this.DynamicSettlementConfig<ISoaringChallengeSettlement>().Value.UnPack() : null);
		}

		// Token: 0x0603423F RID: 213567 RVA: 0x0070678C File Offset: 0x0070498C
		public static Offset<IPlayDynamicSettlement> Pack(FlatBufferBuilder builder, IPlayDynamicSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayDynamicSettlement>);
			}
			TDynamicSettlementConfig dynamicSettlementConfig_type = (_o.DynamicSettlementConfig == null) ? TDynamicSettlementConfig.NONE : _o.DynamicSettlementConfig.Type;
			int dynamicSettlementConfigOffset = (_o.DynamicSettlementConfig == null) ? 0 : TDynamicSettlementConfigUnion.Pack(builder, _o.DynamicSettlementConfig);
			return IPlayDynamicSettlement.CreateIPlayDynamicSettlement(builder, dynamicSettlementConfig_type, dynamicSettlementConfigOffset);
		}

		// Token: 0x040125CA RID: 75210
		private Table __p;
	}
}
