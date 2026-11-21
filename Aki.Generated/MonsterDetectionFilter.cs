using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF7 RID: 3831
	public struct MonsterDetectionFilter : IFlatbufferObject
	{
		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06009AEC RID: 39660 RVA: 0x002A4E4B File Offset: 0x002A304B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x002A4E58 File Offset: 0x002A3058
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x002A4E60 File Offset: 0x002A3060
		public static MonsterDetectionFilter GetRootAsMonsterDetectionFilter(ByteBuffer _bb)
		{
			return MonsterDetectionFilter.GetRootAsMonsterDetectionFilter(_bb, default(MonsterDetectionFilter));
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x002A4E7C File Offset: 0x002A307C
		public static MonsterDetectionFilter GetRootAsMonsterDetectionFilter(ByteBuffer _bb, MonsterDetectionFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x002A4E99 File Offset: 0x002A3099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AF1 RID: 39665 RVA: 0x002A4EA8 File Offset: 0x002A30A8
		public MonsterDetectionFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x002A4EB8 File Offset: 0x002A30B8
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06009AF3 RID: 39667 RVA: 0x002A4EF4 File Offset: 0x002A30F4
		public int EntityConfigId
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

		// Token: 0x0400549C RID: 21660
		private Table __p;
	}
}
