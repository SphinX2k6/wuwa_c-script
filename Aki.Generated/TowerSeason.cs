using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001279 RID: 4729
	public struct TowerSeason : IFlatbufferObject
	{
		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x0035CB0E File Offset: 0x0035AD0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDDA RID: 60890 RVA: 0x0035CB1B File Offset: 0x0035AD1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDDB RID: 60891 RVA: 0x0035CB24 File Offset: 0x0035AD24
		public static TowerSeason GetRootAsTowerSeason(ByteBuffer _bb)
		{
			return TowerSeason.GetRootAsTowerSeason(_bb, default(TowerSeason));
		}

		// Token: 0x0600EDDC RID: 60892 RVA: 0x0035CB40 File Offset: 0x0035AD40
		public static TowerSeason GetRootAsTowerSeason(ByteBuffer _bb, TowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDDD RID: 60893 RVA: 0x0035CB5D File Offset: 0x0035AD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDDE RID: 60894 RVA: 0x0035CB6C File Offset: 0x0035AD6C
		public TowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600EDDF RID: 60895 RVA: 0x0035CB7C File Offset: 0x0035AD7C
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

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0035CBB8 File Offset: 0x0035ADB8
		public int RewardGroup
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

		// Token: 0x040058C8 RID: 22728
		private Table __p;
	}
}
