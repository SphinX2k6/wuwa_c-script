using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD1 RID: 2769
	public struct ActivityViewName : IFlatbufferObject
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x001CDF6C File Offset: 0x001CC16C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x001CDF79 File Offset: 0x001CC179
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001CDF80 File Offset: 0x001CC180
		public static ActivityViewName GetRootAsActivityViewName(ByteBuffer _bb)
		{
			return ActivityViewName.GetRootAsActivityViewName(_bb, default(ActivityViewName));
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001CDF9C File Offset: 0x001CC19C
		public static ActivityViewName GetRootAsActivityViewName(ByteBuffer _bb, ActivityViewName obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x001CDFB9 File Offset: 0x001CC1B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x001CDFC8 File Offset: 0x001CC1C8
		public ActivityViewName __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x001CDFD8 File Offset: 0x001CC1D8
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x001CE014 File Offset: 0x001CC214
		public int Type
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x001CE050 File Offset: 0x001CC250
		public string ViewName
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

		// Token: 0x06004446 RID: 17478 RVA: 0x001CE087 File Offset: 0x001CC287
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x001CE096 File Offset: 0x001CC296
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AAE RID: 19118
		private Table __p;
	}
}
