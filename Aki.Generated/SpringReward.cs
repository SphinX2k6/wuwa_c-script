using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F0 RID: 4336
	public struct SpringReward : IFlatbufferObject
	{
		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600D94D RID: 55629 RVA: 0x00321239 File Offset: 0x0031F439
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D94E RID: 55630 RVA: 0x00321246 File Offset: 0x0031F446
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D94F RID: 55631 RVA: 0x00321250 File Offset: 0x0031F450
		public static SpringReward GetRootAsSpringReward(ByteBuffer _bb)
		{
			return SpringReward.GetRootAsSpringReward(_bb, default(SpringReward));
		}

		// Token: 0x0600D950 RID: 55632 RVA: 0x0032126C File Offset: 0x0031F46C
		public static SpringReward GetRootAsSpringReward(ByteBuffer _bb, SpringReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D951 RID: 55633 RVA: 0x00321289 File Offset: 0x0031F489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D952 RID: 55634 RVA: 0x00321298 File Offset: 0x0031F498
		public SpringReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600D953 RID: 55635 RVA: 0x003212A8 File Offset: 0x0031F4A8
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

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600D954 RID: 55636 RVA: 0x003212E4 File Offset: 0x0031F4E4
		public int TaskThreshold
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

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600D955 RID: 55637 RVA: 0x00321320 File Offset: 0x0031F520
		public int ActivityId
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

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x0032135C File Offset: 0x0031F55C
		public int TaskReward
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

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600D957 RID: 55639 RVA: 0x0032139C File Offset: 0x0031F59C
		public string TaskTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x003213D4 File Offset: 0x0031F5D4
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x003213E4 File Offset: 0x0031F5E4
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005224 RID: 21028
		private Table __p;
	}
}
