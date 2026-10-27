using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE3 RID: 3043
	public struct DaySelectPreset : IFlatbufferObject
	{
		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06006128 RID: 24872 RVA: 0x00211200 File Offset: 0x0020F400
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x0021120D File Offset: 0x0020F40D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00211214 File Offset: 0x0020F414
		public static DaySelectPreset GetRootAsDaySelectPreset(ByteBuffer _bb)
		{
			return DaySelectPreset.GetRootAsDaySelectPreset(_bb, default(DaySelectPreset));
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00211230 File Offset: 0x0020F430
		public static DaySelectPreset GetRootAsDaySelectPreset(ByteBuffer _bb, DaySelectPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x0021124D File Offset: 0x0020F44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x0021125C File Offset: 0x0020F45C
		public DaySelectPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600612E RID: 24878 RVA: 0x0021126C File Offset: 0x0020F46C
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x002112A8 File Offset: 0x0020F4A8
		public string Title
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

		// Token: 0x06006130 RID: 24880 RVA: 0x002112DF File Offset: 0x0020F4DF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x002112EE File Offset: 0x0020F4EE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x00211308 File Offset: 0x0020F508
		public int ChangeDayNum
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

		// Token: 0x04004C10 RID: 19472
		private Table __p;
	}
}
