using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACE RID: 2766
	public struct ActivityTab : IFlatbufferObject
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x001CD8C1 File Offset: 0x001CBAC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x001CD8CE File Offset: 0x001CBACE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x001CD8D8 File Offset: 0x001CBAD8
		public static ActivityTab GetRootAsActivityTab(ByteBuffer _bb)
		{
			return ActivityTab.GetRootAsActivityTab(_bb, default(ActivityTab));
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x001CD8F4 File Offset: 0x001CBAF4
		public static ActivityTab GetRootAsActivityTab(ByteBuffer _bb, ActivityTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x001CD911 File Offset: 0x001CBB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x001CD920 File Offset: 0x001CBB20
		public ActivityTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x001CD930 File Offset: 0x001CBB30
		public int Type
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x001CD96C File Offset: 0x001CBB6C
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x001CD9A3 File Offset: 0x001CBBA3
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001CD9B2 File Offset: 0x001CBBB2
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x001CD9CC File Offset: 0x001CBBCC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x001CDA03 File Offset: 0x001CBC03
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x001CDA12 File Offset: 0x001CBC12
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AAB RID: 19115
		private Table __p;
	}
}
