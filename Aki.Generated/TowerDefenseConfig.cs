using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001274 RID: 4724
	public struct TowerDefenseConfig : IFlatbufferObject
	{
		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x0035C1D5 File Offset: 0x0035A3D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED97 RID: 60823 RVA: 0x0035C1E2 File Offset: 0x0035A3E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED98 RID: 60824 RVA: 0x0035C1EC File Offset: 0x0035A3EC
		public static TowerDefenseConfig GetRootAsTowerDefenseConfig(ByteBuffer _bb)
		{
			return TowerDefenseConfig.GetRootAsTowerDefenseConfig(_bb, default(TowerDefenseConfig));
		}

		// Token: 0x0600ED99 RID: 60825 RVA: 0x0035C208 File Offset: 0x0035A408
		public static TowerDefenseConfig GetRootAsTowerDefenseConfig(ByteBuffer _bb, TowerDefenseConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED9A RID: 60826 RVA: 0x0035C225 File Offset: 0x0035A425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED9B RID: 60827 RVA: 0x0035C234 File Offset: 0x0035A434
		public TowerDefenseConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x0035C244 File Offset: 0x0035A444
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

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600ED9D RID: 60829 RVA: 0x0035C280 File Offset: 0x0035A480
		public bool ShowDifferent
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600ED9E RID: 60830 RVA: 0x0035C2C0 File Offset: 0x0035A4C0
		public int ActivityType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600ED9F RID: 60831 RVA: 0x0035C2FC File Offset: 0x0035A4FC
		public int EntranceId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040058C2 RID: 22722
		private Table __p;
	}
}
