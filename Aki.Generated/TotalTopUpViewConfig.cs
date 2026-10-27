using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001134 RID: 4404
	public struct TotalTopUpViewConfig : IFlatbufferObject
	{
		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x0032EE5C File Offset: 0x0032D05C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x0032EE69 File Offset: 0x0032D069
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF50 RID: 57168 RVA: 0x0032EE70 File Offset: 0x0032D070
		public static TotalTopUpViewConfig GetRootAsTotalTopUpViewConfig(ByteBuffer _bb)
		{
			return TotalTopUpViewConfig.GetRootAsTotalTopUpViewConfig(_bb, default(TotalTopUpViewConfig));
		}

		// Token: 0x0600DF51 RID: 57169 RVA: 0x0032EE8C File Offset: 0x0032D08C
		public static TotalTopUpViewConfig GetRootAsTotalTopUpViewConfig(ByteBuffer _bb, TotalTopUpViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF52 RID: 57170 RVA: 0x0032EEA9 File Offset: 0x0032D0A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF53 RID: 57171 RVA: 0x0032EEB8 File Offset: 0x0032D0B8
		public TotalTopUpViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x0032EEC8 File Offset: 0x0032D0C8
		public int ActivityId
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

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600DF55 RID: 57173 RVA: 0x0032EF04 File Offset: 0x0032D104
		public string ScoreIcon
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

		// Token: 0x0600DF56 RID: 57174 RVA: 0x0032EF3B File Offset: 0x0032D13B
		public Span<byte> GetScoreIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DF57 RID: 57175 RVA: 0x0032EF4A File Offset: 0x0032D14A
		public byte[] GetScoreIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600DF58 RID: 57176 RVA: 0x0032EF64 File Offset: 0x0032D164
		public int ViewType
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

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600DF59 RID: 57177 RVA: 0x0032EFA0 File Offset: 0x0032D1A0
		public string EnterResourcesId
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

		// Token: 0x0600DF5A RID: 57178 RVA: 0x0032EFD8 File Offset: 0x0032D1D8
		public Span<byte> GetEnterResourcesIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x0032EFE8 File Offset: 0x0032D1E8
		public byte[] GetEnterResourcesIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600DF5C RID: 57180 RVA: 0x0032F000 File Offset: 0x0032D200
		public string TagResourcesId
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

		// Token: 0x0600DF5D RID: 57181 RVA: 0x0032F038 File Offset: 0x0032D238
		public Span<byte> GetTagResourcesIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DF5E RID: 57182 RVA: 0x0032F048 File Offset: 0x0032D248
		public byte[] GetTagResourcesIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005275 RID: 21109
		private Table __p;
	}
}
