using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0D RID: 23053
	public struct ISunSpiritPlayerBattleConfig : IFlatbufferObject
	{
		// Token: 0x1700AD3C RID: 44348
		// (get) Token: 0x0602722A RID: 160298 RVA: 0x00562308 File Offset: 0x00560508
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602722B RID: 160299 RVA: 0x00562315 File Offset: 0x00560515
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602722C RID: 160300 RVA: 0x0056231C File Offset: 0x0056051C
		public static ISunSpiritPlayerBattleConfig GetRootAsISunSpiritPlayerBattleConfig(ByteBuffer _bb)
		{
			return ISunSpiritPlayerBattleConfig.GetRootAsISunSpiritPlayerBattleConfig(_bb, default(ISunSpiritPlayerBattleConfig));
		}

		// Token: 0x0602722D RID: 160301 RVA: 0x00562338 File Offset: 0x00560538
		public static ISunSpiritPlayerBattleConfig GetRootAsISunSpiritPlayerBattleConfig(ByteBuffer _bb, ISunSpiritPlayerBattleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602722E RID: 160302 RVA: 0x00562355 File Offset: 0x00560555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602722F RID: 160303 RVA: 0x00562364 File Offset: 0x00560564
		public ISunSpiritPlayerBattleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06027230 RID: 160304 RVA: 0x00562374 File Offset: 0x00560574
		public static void StartISunSpiritPlayerBattleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06027231 RID: 160305 RVA: 0x0056237D File Offset: 0x0056057D
		public static Offset<ISunSpiritPlayerBattleConfig> EndISunSpiritPlayerBattleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritPlayerBattleConfig>(builder.EndTable());
		}

		// Token: 0x06027232 RID: 160306 RVA: 0x0056238C File Offset: 0x0056058C
		public ISunSpiritPlayerBattleConfigT UnPack()
		{
			ISunSpiritPlayerBattleConfigT sunSpiritPlayerBattleConfigT = new ISunSpiritPlayerBattleConfigT();
			this.UnPackTo(sunSpiritPlayerBattleConfigT);
			return sunSpiritPlayerBattleConfigT;
		}

		// Token: 0x06027233 RID: 160307 RVA: 0x005623A7 File Offset: 0x005605A7
		public void UnPackTo(ISunSpiritPlayerBattleConfigT _o)
		{
		}

		// Token: 0x06027234 RID: 160308 RVA: 0x005623AC File Offset: 0x005605AC
		public static Offset<ISunSpiritPlayerBattleConfig> Pack(FlatBufferBuilder builder, ISunSpiritPlayerBattleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritPlayerBattleConfig>);
			}
			ISunSpiritPlayerBattleConfig.StartISunSpiritPlayerBattleConfig(builder);
			return ISunSpiritPlayerBattleConfig.EndISunSpiritPlayerBattleConfig(builder);
		}

		// Token: 0x0400F056 RID: 61526
		private Table __p;
	}
}
