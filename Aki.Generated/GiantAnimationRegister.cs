using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF8 RID: 3320
	public struct GiantAnimationRegister : IFlatbufferObject
	{
		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x0024A725 File Offset: 0x00248925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0024A732 File Offset: 0x00248932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0024A73C File Offset: 0x0024893C
		public static GiantAnimationRegister GetRootAsGiantAnimationRegister(ByteBuffer _bb)
		{
			return GiantAnimationRegister.GetRootAsGiantAnimationRegister(_bb, default(GiantAnimationRegister));
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0024A758 File Offset: 0x00248958
		public static GiantAnimationRegister GetRootAsGiantAnimationRegister(ByteBuffer _bb, GiantAnimationRegister obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0024A775 File Offset: 0x00248975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0024A784 File Offset: 0x00248984
		public GiantAnimationRegister __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06007A30 RID: 31280 RVA: 0x0024A794 File Offset: 0x00248994
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06007A31 RID: 31281 RVA: 0x0024A7D0 File Offset: 0x002489D0
		public string Desc
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

		// Token: 0x06007A32 RID: 31282 RVA: 0x0024A807 File Offset: 0x00248A07
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x0024A816 File Offset: 0x00248A16
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x0024A830 File Offset: 0x00248A30
		public string AnimData
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

		// Token: 0x06007A35 RID: 31285 RVA: 0x0024A867 File Offset: 0x00248A67
		public Span<byte> GetAnimDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x0024A876 File Offset: 0x00248A76
		public byte[] GetAnimDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D6B RID: 19819
		private Table __p;
	}
}
