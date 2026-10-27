using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E12 RID: 3602
	public struct MonsterDetectionFilter : IFlatbufferObject
	{
		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x060094CC RID: 38092 RVA: 0x00287067 File Offset: 0x00285267
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x00287074 File Offset: 0x00285274
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x0028707C File Offset: 0x0028527C
		public static MonsterDetectionFilter GetRootAsMonsterDetectionFilter(ByteBuffer _bb)
		{
			return MonsterDetectionFilter.GetRootAsMonsterDetectionFilter(_bb, default(MonsterDetectionFilter));
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00287098 File Offset: 0x00285298
		public static MonsterDetectionFilter GetRootAsMonsterDetectionFilter(ByteBuffer _bb, MonsterDetectionFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x002870B5 File Offset: 0x002852B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x002870C4 File Offset: 0x002852C4
		public MonsterDetectionFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x002870D4 File Offset: 0x002852D4
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

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x060094D3 RID: 38099 RVA: 0x00287110 File Offset: 0x00285310
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

		// Token: 0x04004EB7 RID: 20151
		private Table __p;
	}
}
