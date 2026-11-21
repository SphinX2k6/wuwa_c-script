using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D99 RID: 3481
	public struct FloroRanchTarget : IFlatbufferObject
	{
		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06007A81 RID: 31361 RVA: 0x0025C916 File Offset: 0x0025AB16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x0025C923 File Offset: 0x0025AB23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x0025C92C File Offset: 0x0025AB2C
		public static FloroRanchTarget GetRootAsFloroRanchTarget(ByteBuffer _bb)
		{
			return FloroRanchTarget.GetRootAsFloroRanchTarget(_bb, default(FloroRanchTarget));
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x0025C948 File Offset: 0x0025AB48
		public static FloroRanchTarget GetRootAsFloroRanchTarget(ByteBuffer _bb, FloroRanchTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x0025C965 File Offset: 0x0025AB65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x0025C974 File Offset: 0x0025AB74
		public FloroRanchTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x0025C984 File Offset: 0x0025AB84
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

		// Token: 0x04005304 RID: 21252
		private Table __p;
	}
}
