using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001227 RID: 4647
	public struct SpringSign : IFlatbufferObject
	{
		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600E6A5 RID: 59045 RVA: 0x0034C964 File Offset: 0x0034AB64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x0034C971 File Offset: 0x0034AB71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x0034C978 File Offset: 0x0034AB78
		public static SpringSign GetRootAsSpringSign(ByteBuffer _bb)
		{
			return SpringSign.GetRootAsSpringSign(_bb, default(SpringSign));
		}

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x0034C994 File Offset: 0x0034AB94
		public static SpringSign GetRootAsSpringSign(ByteBuffer _bb, SpringSign obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x0034C9B1 File Offset: 0x0034ABB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x0034C9C0 File Offset: 0x0034ABC0
		public SpringSign __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x0034C9D0 File Offset: 0x0034ABD0
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

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x0034CA0C File Offset: 0x0034AC0C
		public int ActivityId
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

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600E6AD RID: 59053 RVA: 0x0034CA48 File Offset: 0x0034AC48
		public int ResourceTypeId
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

		// Token: 0x04005868 RID: 22632
		private Table __p;
	}
}
