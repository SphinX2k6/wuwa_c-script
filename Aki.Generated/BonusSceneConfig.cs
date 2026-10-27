using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3E RID: 2878
	public struct BonusSceneConfig : IFlatbufferObject
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x001E5571 File Offset: 0x001E3771
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x001E557E File Offset: 0x001E377E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x001E5588 File Offset: 0x001E3788
		public static BonusSceneConfig GetRootAsBonusSceneConfig(ByteBuffer _bb)
		{
			return BonusSceneConfig.GetRootAsBonusSceneConfig(_bb, default(BonusSceneConfig));
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x001E55A4 File Offset: 0x001E37A4
		public static BonusSceneConfig GetRootAsBonusSceneConfig(ByteBuffer _bb, BonusSceneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x001E55C1 File Offset: 0x001E37C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x001E55D0 File Offset: 0x001E37D0
		public BonusSceneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06004E1A RID: 19994 RVA: 0x001E55E0 File Offset: 0x001E37E0
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x001E561C File Offset: 0x001E381C
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

		// Token: 0x04004B39 RID: 19257
		private Table __p;
	}
}
