using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1E RID: 3102
	public struct BonusSceneConfig : IFlatbufferObject
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x00205899 File Offset: 0x00203A99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x002058A6 File Offset: 0x00203AA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x002058B0 File Offset: 0x00203AB0
		public static BonusSceneConfig GetRootAsBonusSceneConfig(ByteBuffer _bb)
		{
			return BonusSceneConfig.GetRootAsBonusSceneConfig(_bb, default(BonusSceneConfig));
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x002058CC File Offset: 0x00203ACC
		public static BonusSceneConfig GetRootAsBonusSceneConfig(ByteBuffer _bb, BonusSceneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x002058E9 File Offset: 0x00203AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x002058F8 File Offset: 0x00203AF8
		public BonusSceneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x00205908 File Offset: 0x00203B08
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060053DD RID: 21469 RVA: 0x00205944 File Offset: 0x00203B44
		public int CD
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005119 RID: 20761
		private Table __p;
	}
}
