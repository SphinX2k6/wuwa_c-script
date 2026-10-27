using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001132 RID: 4402
	public struct TotalTopUpRotation : IFlatbufferObject
	{
		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600DF32 RID: 57138 RVA: 0x0032EAB8 File Offset: 0x0032CCB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF33 RID: 57139 RVA: 0x0032EAC5 File Offset: 0x0032CCC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF34 RID: 57140 RVA: 0x0032EACC File Offset: 0x0032CCCC
		public static TotalTopUpRotation GetRootAsTotalTopUpRotation(ByteBuffer _bb)
		{
			return TotalTopUpRotation.GetRootAsTotalTopUpRotation(_bb, default(TotalTopUpRotation));
		}

		// Token: 0x0600DF35 RID: 57141 RVA: 0x0032EAE8 File Offset: 0x0032CCE8
		public static TotalTopUpRotation GetRootAsTotalTopUpRotation(ByteBuffer _bb, TotalTopUpRotation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF36 RID: 57142 RVA: 0x0032EB05 File Offset: 0x0032CD05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF37 RID: 57143 RVA: 0x0032EB14 File Offset: 0x0032CD14
		public TotalTopUpRotation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x0032EB24 File Offset: 0x0032CD24
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

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600DF39 RID: 57145 RVA: 0x0032EB60 File Offset: 0x0032CD60
		public int ActivityId
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

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x0032EB9C File Offset: 0x0032CD9C
		public int Sort
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

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600DF3B RID: 57147 RVA: 0x0032EBD8 File Offset: 0x0032CDD8
		public int PreviewType
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

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x0032EC18 File Offset: 0x0032CE18
		public string ResourcePath
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

		// Token: 0x0600DF3D RID: 57149 RVA: 0x0032EC50 File Offset: 0x0032CE50
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DF3E RID: 57150 RVA: 0x0032EC60 File Offset: 0x0032CE60
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600DF3F RID: 57151 RVA: 0x0032EC78 File Offset: 0x0032CE78
		public int ShowDuration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x0032ECB8 File Offset: 0x0032CEB8
		public string PreviewName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x0032ECF0 File Offset: 0x0032CEF0
		public Span<byte> GetPreviewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DF42 RID: 57154 RVA: 0x0032ED00 File Offset: 0x0032CF00
		public byte[] GetPreviewNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600DF43 RID: 57155 RVA: 0x0032ED18 File Offset: 0x0032CF18
		public string MusicName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DF44 RID: 57156 RVA: 0x0032ED50 File Offset: 0x0032CF50
		public Span<byte> GetMusicNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x0032ED60 File Offset: 0x0032CF60
		public byte[] GetMusicNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005273 RID: 21107
		private Table __p;
	}
}
