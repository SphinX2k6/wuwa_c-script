using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE1 RID: 3297
	public struct GachaRoleDevelopIns : IFlatbufferObject
	{
		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x00245F29 File Offset: 0x00244129
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00245F36 File Offset: 0x00244136
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00245F40 File Offset: 0x00244140
		public static GachaRoleDevelopIns GetRootAsGachaRoleDevelopIns(ByteBuffer _bb)
		{
			return GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(_bb, default(GachaRoleDevelopIns));
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00245F5C File Offset: 0x0024415C
		public static GachaRoleDevelopIns GetRootAsGachaRoleDevelopIns(ByteBuffer _bb, GachaRoleDevelopIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00245F79 File Offset: 0x00244179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00245F88 File Offset: 0x00244188
		public GachaRoleDevelopIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x00245F98 File Offset: 0x00244198
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

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600782D RID: 30765 RVA: 0x00245FD4 File Offset: 0x002441D4
		public int RoleId
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

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x00246010 File Offset: 0x00244210
		public int AdventureGuide
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600782F RID: 30767 RVA: 0x0024604C File Offset: 0x0024424C
		public int DungeonDetection
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x0024608C File Offset: 0x0024428C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06007831 RID: 30769 RVA: 0x002460CC File Offset: 0x002442CC
		public int DungeonEntranceId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x0024610C File Offset: 0x0024430C
		public int LevelPlayParam
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 36;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D52 RID: 19794
		private Table __p;
	}
}
