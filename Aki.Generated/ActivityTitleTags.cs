using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAA RID: 2986
	public struct ActivityTitleTags : IFlatbufferObject
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x001ED86F File Offset: 0x001EBA6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x001ED87C File Offset: 0x001EBA7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x001ED884 File Offset: 0x001EBA84
		public static ActivityTitleTags GetRootAsActivityTitleTags(ByteBuffer _bb)
		{
			return ActivityTitleTags.GetRootAsActivityTitleTags(_bb, default(ActivityTitleTags));
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x001ED8A0 File Offset: 0x001EBAA0
		public static ActivityTitleTags GetRootAsActivityTitleTags(ByteBuffer _bb, ActivityTitleTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x001ED8BD File Offset: 0x001EBABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x001ED8CC File Offset: 0x001EBACC
		public ActivityTitleTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x001ED8DC File Offset: 0x001EBADC
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x001ED918 File Offset: 0x001EBB18
		public string TogIcon
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

		// Token: 0x06004979 RID: 18809 RVA: 0x001ED94F File Offset: 0x001EBB4F
		public Span<byte> GetTogIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x001ED95E File Offset: 0x001EBB5E
		public byte[] GetTogIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x001ED978 File Offset: 0x001EBB78
		public string TagIcon
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

		// Token: 0x0600497C RID: 18812 RVA: 0x001ED9AF File Offset: 0x001EBBAF
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001ED9BE File Offset: 0x001EBBBE
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x001ED9D8 File Offset: 0x001EBBD8
		public string TagName
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

		// Token: 0x0600497F RID: 18815 RVA: 0x001EDA10 File Offset: 0x001EBC10
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x001EDA20 File Offset: 0x001EBC20
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x001EDA38 File Offset: 0x001EBC38
		public string DescInTip
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

		// Token: 0x06004982 RID: 18818 RVA: 0x001EDA70 File Offset: 0x001EBC70
		public Span<byte> GetDescInTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001EDA80 File Offset: 0x001EBC80
		public byte[] GetDescInTipArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005087 RID: 20615
		private Table __p;
	}
}
