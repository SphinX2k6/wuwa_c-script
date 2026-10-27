using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE1 RID: 27873
	public struct IPlayDynamicSettlement : IFlatbufferObject
	{
		// Token: 0x1700CFA2 RID: 53154
		// (get) Token: 0x0603125A RID: 201306 RVA: 0x006AB2F0 File Offset: 0x006A94F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603125B RID: 201307 RVA: 0x006AB2FD File Offset: 0x006A94FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603125C RID: 201308 RVA: 0x006AB304 File Offset: 0x006A9504
		public static IPlayDynamicSettlement GetRootAsIPlayDynamicSettlement(ByteBuffer _bb)
		{
			return IPlayDynamicSettlement.GetRootAsIPlayDynamicSettlement(_bb, default(IPlayDynamicSettlement));
		}

		// Token: 0x0603125D RID: 201309 RVA: 0x006AB320 File Offset: 0x006A9520
		public static IPlayDynamicSettlement GetRootAsIPlayDynamicSettlement(ByteBuffer _bb, IPlayDynamicSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603125E RID: 201310 RVA: 0x006AB33D File Offset: 0x006A953D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603125F RID: 201311 RVA: 0x006AB34C File Offset: 0x006A954C
		public IPlayDynamicSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFA3 RID: 53155
		// (get) Token: 0x06031260 RID: 201312 RVA: 0x006AB35C File Offset: 0x006A955C
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

		// Token: 0x06031261 RID: 201313 RVA: 0x006AB398 File Offset: 0x006A9598
		public TTable? DynamicSettlementConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031262 RID: 201314 RVA: 0x006AB3DC File Offset: 0x006A95DC
		public IBattleSettlement DynamicSettlementConfigAsIBattleSettlement()
		{
			return this.DynamicSettlementConfig<IBattleSettlement>().Value;
		}

		// Token: 0x06031263 RID: 201315 RVA: 0x006AB3F8 File Offset: 0x006A95F8
		public ISoaringChallengeSettlement DynamicSettlementConfigAsISoaringChallengeSettlement()
		{
			return this.DynamicSettlementConfig<ISoaringChallengeSettlement>().Value;
		}

		// Token: 0x06031264 RID: 201316 RVA: 0x006AB413 File Offset: 0x006A9613
		public static Offset<IPlayDynamicSettlement> CreateIPlayDynamicSettlement(FlatBufferBuilder builder, TDynamicSettlementConfig DynamicSettlementConfig_type = TDynamicSettlementConfig.NONE, int DynamicSettlementConfigOffset = 0)
		{
			builder.StartTable(2);
			IPlayDynamicSettlement.AddDynamicSettlementConfig(builder, DynamicSettlementConfigOffset);
			IPlayDynamicSettlement.AddDynamicSettlementConfigType(builder, DynamicSettlementConfig_type);
			return IPlayDynamicSettlement.EndIPlayDynamicSettlement(builder);
		}

		// Token: 0x06031265 RID: 201317 RVA: 0x006AB430 File Offset: 0x006A9630
		public static void StartIPlayDynamicSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031266 RID: 201318 RVA: 0x006AB439 File Offset: 0x006A9639
		public static void AddDynamicSettlementConfigType(FlatBufferBuilder builder, TDynamicSettlementConfig dynamicSettlementConfigType)
		{
			builder.AddByte(0, (byte)dynamicSettlementConfigType, 0);
		}

		// Token: 0x06031267 RID: 201319 RVA: 0x006AB444 File Offset: 0x006A9644
		public static void AddDynamicSettlementConfig(FlatBufferBuilder builder, int dynamicSettlementConfigOffset)
		{
			builder.AddOffset(1, dynamicSettlementConfigOffset, 0);
		}

		// Token: 0x06031268 RID: 201320 RVA: 0x006AB44F File Offset: 0x006A964F
		public static Offset<IPlayDynamicSettlement> EndIPlayDynamicSettlement(FlatBufferBuilder builder)
		{
			return new Offset<IPlayDynamicSettlement>(builder.EndTable());
		}

		// Token: 0x06031269 RID: 201321 RVA: 0x006AB45C File Offset: 0x006A965C
		public IPlayDynamicSettlementT UnPack()
		{
			IPlayDynamicSettlementT playDynamicSettlementT = new IPlayDynamicSettlementT();
			this.UnPackTo(playDynamicSettlementT);
			return playDynamicSettlementT;
		}

		// Token: 0x0603126A RID: 201322 RVA: 0x006AB478 File Offset: 0x006A9678
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

		// Token: 0x0603126B RID: 201323 RVA: 0x006AB51C File Offset: 0x006A971C
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

		// Token: 0x04011659 RID: 71257
		private Table __p;
	}
}
