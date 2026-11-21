using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001158 RID: 4440
	public struct RoleTowerStarGroup : IFlatbufferObject
	{
		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0031FDA4 File Offset: 0x0031DFA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2FF RID: 54015 RVA: 0x0031FDB1 File Offset: 0x0031DFB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x0031FDB8 File Offset: 0x0031DFB8
		public static RoleTowerStarGroup GetRootAsRoleTowerStarGroup(ByteBuffer _bb)
		{
			return RoleTowerStarGroup.GetRootAsRoleTowerStarGroup(_bb, default(RoleTowerStarGroup));
		}

		// Token: 0x0600D301 RID: 54017 RVA: 0x0031FDD4 File Offset: 0x0031DFD4
		public static RoleTowerStarGroup GetRootAsRoleTowerStarGroup(ByteBuffer _bb, RoleTowerStarGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D302 RID: 54018 RVA: 0x0031FDF1 File Offset: 0x0031DFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D303 RID: 54019 RVA: 0x0031FE00 File Offset: 0x0031E000
		public RoleTowerStarGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600D304 RID: 54020 RVA: 0x0031FE10 File Offset: 0x0031E010
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

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600D305 RID: 54021 RVA: 0x0031FE4C File Offset: 0x0031E04C
		public int Type
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

		// Token: 0x04005760 RID: 22368
		private Table __p;
	}
}
