using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9C RID: 2972
	public struct Contrast : IFlatbufferObject
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06005921 RID: 22817 RVA: 0x001FF0DD File Offset: 0x001FD2DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x001FF0EA File Offset: 0x001FD2EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x001FF0F4 File Offset: 0x001FD2F4
		public static Contrast GetRootAsContrast(ByteBuffer _bb)
		{
			return Contrast.GetRootAsContrast(_bb, default(Contrast));
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x001FF110 File Offset: 0x001FD310
		public static Contrast GetRootAsContrast(ByteBuffer _bb, Contrast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x001FF12D File Offset: 0x001FD32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x001FF13C File Offset: 0x001FD33C
		public Contrast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x001FF14C File Offset: 0x001FD34C
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06005928 RID: 22824 RVA: 0x001FF188 File Offset: 0x001FD388
		public string BaseString
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

		// Token: 0x06005929 RID: 22825 RVA: 0x001FF1BF File Offset: 0x001FD3BF
		public Span<byte> GetBaseStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x001FF1CE File Offset: 0x001FD3CE
		public byte[] GetBaseStringArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x001FF1E8 File Offset: 0x001FD3E8
		public int TargetInt
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

		// Token: 0x04004BBD RID: 19389
		private Table __p;
	}
}
