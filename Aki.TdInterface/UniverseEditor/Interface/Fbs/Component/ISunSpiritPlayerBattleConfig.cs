using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200601A RID: 24602
	public struct ISunSpiritPlayerBattleConfig : IFlatbufferObject
	{
		// Token: 0x1700B674 RID: 46708
		// (get) Token: 0x060297A2 RID: 169890 RVA: 0x005A92CC File Offset: 0x005A74CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060297A3 RID: 169891 RVA: 0x005A92D9 File Offset: 0x005A74D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060297A4 RID: 169892 RVA: 0x005A92E0 File Offset: 0x005A74E0
		public static ISunSpiritPlayerBattleConfig GetRootAsISunSpiritPlayerBattleConfig(ByteBuffer _bb)
		{
			return ISunSpiritPlayerBattleConfig.GetRootAsISunSpiritPlayerBattleConfig(_bb, default(ISunSpiritPlayerBattleConfig));
		}

		// Token: 0x060297A5 RID: 169893 RVA: 0x005A92FC File Offset: 0x005A74FC
		public static ISunSpiritPlayerBattleConfig GetRootAsISunSpiritPlayerBattleConfig(ByteBuffer _bb, ISunSpiritPlayerBattleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060297A6 RID: 169894 RVA: 0x005A9319 File Offset: 0x005A7519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060297A7 RID: 169895 RVA: 0x005A9328 File Offset: 0x005A7528
		public ISunSpiritPlayerBattleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060297A8 RID: 169896 RVA: 0x005A9338 File Offset: 0x005A7538
		public static void StartISunSpiritPlayerBattleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060297A9 RID: 169897 RVA: 0x005A9341 File Offset: 0x005A7541
		public static Offset<ISunSpiritPlayerBattleConfig> EndISunSpiritPlayerBattleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritPlayerBattleConfig>(builder.EndTable());
		}

		// Token: 0x060297AA RID: 169898 RVA: 0x005A9350 File Offset: 0x005A7550
		public ISunSpiritPlayerBattleConfigT UnPack()
		{
			ISunSpiritPlayerBattleConfigT sunSpiritPlayerBattleConfigT = new ISunSpiritPlayerBattleConfigT();
			this.UnPackTo(sunSpiritPlayerBattleConfigT);
			return sunSpiritPlayerBattleConfigT;
		}

		// Token: 0x060297AB RID: 169899 RVA: 0x005A936B File Offset: 0x005A756B
		public void UnPackTo(ISunSpiritPlayerBattleConfigT _o)
		{
		}

		// Token: 0x060297AC RID: 169900 RVA: 0x005A9370 File Offset: 0x005A7570
		public static Offset<ISunSpiritPlayerBattleConfig> Pack(FlatBufferBuilder builder, ISunSpiritPlayerBattleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritPlayerBattleConfig>);
			}
			ISunSpiritPlayerBattleConfig.StartISunSpiritPlayerBattleConfig(builder);
			return ISunSpiritPlayerBattleConfig.EndISunSpiritPlayerBattleConfig(builder);
		}

		// Token: 0x0400FD4D RID: 64845
		private Table __p;
	}
}
