using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001097 RID: 4247
	public struct RegressMarkTime : IFlatbufferObject
	{
		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600C152 RID: 49490 RVA: 0x002F88EC File Offset: 0x002F6AEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x002F88F9 File Offset: 0x002F6AF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C154 RID: 49492 RVA: 0x002F8900 File Offset: 0x002F6B00
		public static RegressMarkTime GetRootAsRegressMarkTime(ByteBuffer _bb)
		{
			return RegressMarkTime.GetRootAsRegressMarkTime(_bb, default(RegressMarkTime));
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x002F891C File Offset: 0x002F6B1C
		public static RegressMarkTime GetRootAsRegressMarkTime(ByteBuffer _bb, RegressMarkTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x002F8939 File Offset: 0x002F6B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x002F8948 File Offset: 0x002F6B48
		public RegressMarkTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0600C158 RID: 49496 RVA: 0x002F8958 File Offset: 0x002F6B58
		public int ActivityId
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

		// Token: 0x04005670 RID: 22128
		private Table __p;
	}
}
