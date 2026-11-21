using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012EA RID: 4842
	public struct CycleTime : IFlatbufferObject
	{
		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0600F752 RID: 63314 RVA: 0x00371D6C File Offset: 0x0036FF6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x00371D79 File Offset: 0x0036FF79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x00371D80 File Offset: 0x0036FF80
		public static CycleTime GetRootAsCycleTime(ByteBuffer _bb)
		{
			return CycleTime.GetRootAsCycleTime(_bb, default(CycleTime));
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x00371D9C File Offset: 0x0036FF9C
		public static CycleTime GetRootAsCycleTime(ByteBuffer _bb, CycleTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x00371DB9 File Offset: 0x0036FFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x00371DC8 File Offset: 0x0036FFC8
		public CycleTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0600F758 RID: 63320 RVA: 0x00371DD8 File Offset: 0x0036FFD8
		public int CycleType
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

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0600F759 RID: 63321 RVA: 0x00371E14 File Offset: 0x00370014
		public int CycleParam
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

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x0600F75A RID: 63322 RVA: 0x00371E50 File Offset: 0x00370050
		public string TimeParam
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

		// Token: 0x0600F75B RID: 63323 RVA: 0x00371E87 File Offset: 0x00370087
		public Span<byte> GetTimeParamBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x00371E96 File Offset: 0x00370096
		public byte[] GetTimeParamArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005948 RID: 22856
		private Table __p;
	}
}
