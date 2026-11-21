using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F96 RID: 3990
	public struct PayShopCondition : IFlatbufferObject
	{
		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600A933 RID: 43315 RVA: 0x002C3CD2 File Offset: 0x002C1ED2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x002C3CDF File Offset: 0x002C1EDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x002C3CE8 File Offset: 0x002C1EE8
		public static PayShopCondition GetRootAsPayShopCondition(ByteBuffer _bb)
		{
			return PayShopCondition.GetRootAsPayShopCondition(_bb, default(PayShopCondition));
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x002C3D04 File Offset: 0x002C1F04
		public static PayShopCondition GetRootAsPayShopCondition(ByteBuffer _bb, PayShopCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x002C3D21 File Offset: 0x002C1F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x002C3D30 File Offset: 0x002C1F30
		public PayShopCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600A939 RID: 43321 RVA: 0x002C3D40 File Offset: 0x002C1F40
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

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x0600A93A RID: 43322 RVA: 0x002C3D7C File Offset: 0x002C1F7C
		public string ConditionText
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

		// Token: 0x0600A93B RID: 43323 RVA: 0x002C3DB3 File Offset: 0x002C1FB3
		public Span<byte> GetConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x002C3DC2 File Offset: 0x002C1FC2
		public byte[] GetConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400554C RID: 21836
		private Table __p;
	}
}
