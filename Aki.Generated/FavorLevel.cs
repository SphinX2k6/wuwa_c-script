using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D44 RID: 3396
	public struct FavorLevel : IFlatbufferObject
	{
		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060072EB RID: 29419 RVA: 0x0024AC2C File Offset: 0x00248E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x0024AC39 File Offset: 0x00248E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x0024AC40 File Offset: 0x00248E40
		public static FavorLevel GetRootAsFavorLevel(ByteBuffer _bb)
		{
			return FavorLevel.GetRootAsFavorLevel(_bb, default(FavorLevel));
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x0024AC5C File Offset: 0x00248E5C
		public static FavorLevel GetRootAsFavorLevel(ByteBuffer _bb, FavorLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x0024AC79 File Offset: 0x00248E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x0024AC88 File Offset: 0x00248E88
		public FavorLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060072F1 RID: 29425 RVA: 0x0024AC98 File Offset: 0x00248E98
		public int Level
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

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x0024ACD4 File Offset: 0x00248ED4
		public int LevelUpExp
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

		// Token: 0x0400528F RID: 21135
		private Table __p;
	}
}
