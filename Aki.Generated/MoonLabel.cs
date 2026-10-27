using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E21 RID: 3617
	public struct MoonLabel : IFlatbufferObject
	{
		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x060095C1 RID: 38337 RVA: 0x00289019 File Offset: 0x00287219
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x00289026 File Offset: 0x00287226
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x00289030 File Offset: 0x00287230
		public static MoonLabel GetRootAsMoonLabel(ByteBuffer _bb)
		{
			return MoonLabel.GetRootAsMoonLabel(_bb, default(MoonLabel));
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x0028904C File Offset: 0x0028724C
		public static MoonLabel GetRootAsMoonLabel(ByteBuffer _bb, MoonLabel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x00289069 File Offset: 0x00287269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x00289078 File Offset: 0x00287278
		public MoonLabel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x060095C7 RID: 38343 RVA: 0x00289088 File Offset: 0x00287288
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

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x002890C4 File Offset: 0x002872C4
		public string MoonText1
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

		// Token: 0x060095C9 RID: 38345 RVA: 0x002890FB File Offset: 0x002872FB
		public Span<byte> GetMoonText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x0028910A File Offset: 0x0028730A
		public byte[] GetMoonText1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x00289124 File Offset: 0x00287324
		public string MoonText2
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

		// Token: 0x060095CC RID: 38348 RVA: 0x0028915B File Offset: 0x0028735B
		public Span<byte> GetMoonText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x0028916A File Offset: 0x0028736A
		public byte[] GetMoonText2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x00289184 File Offset: 0x00287384
		public string MoonLabelName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x002891BC File Offset: 0x002873BC
		public Span<byte> GetMoonLabelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x002891CC File Offset: 0x002873CC
		public byte[] GetMoonLabelNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EC6 RID: 20166
		private Table __p;
	}
}
