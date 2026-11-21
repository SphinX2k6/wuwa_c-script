using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9C RID: 2972
	public struct ActivityFilter : IFlatbufferObject
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x001EB841 File Offset: 0x001E9A41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x001EB84E File Offset: 0x001E9A4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x001EB858 File Offset: 0x001E9A58
		public static ActivityFilter GetRootAsActivityFilter(ByteBuffer _bb)
		{
			return ActivityFilter.GetRootAsActivityFilter(_bb, default(ActivityFilter));
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x001EB874 File Offset: 0x001E9A74
		public static ActivityFilter GetRootAsActivityFilter(ByteBuffer _bb, ActivityFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x001EB891 File Offset: 0x001E9A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x001EB8A0 File Offset: 0x001E9AA0
		public ActivityFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x001EB8B0 File Offset: 0x001E9AB0
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x001EB8EC File Offset: 0x001E9AEC
		public string FilterIcon
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

		// Token: 0x06004881 RID: 18561 RVA: 0x001EB923 File Offset: 0x001E9B23
		public Span<byte> GetFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x001EB932 File Offset: 0x001E9B32
		public byte[] GetFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x001EB94C File Offset: 0x001E9B4C
		public string FilterName
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

		// Token: 0x06004884 RID: 18564 RVA: 0x001EB983 File Offset: 0x001E9B83
		public Span<byte> GetFilterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x001EB992 File Offset: 0x001E9B92
		public byte[] GetFilterNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x001EB9AC File Offset: 0x001E9BAC
		public int SortId
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

		// Token: 0x04005078 RID: 20600
		private Table __p;
	}
}
