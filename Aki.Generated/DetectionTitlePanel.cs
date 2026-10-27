using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEA RID: 3050
	public struct DetectionTitlePanel : IFlatbufferObject
	{
		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06006191 RID: 24977 RVA: 0x00211EC5 File Offset: 0x002100C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00211ED2 File Offset: 0x002100D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00211EDC File Offset: 0x002100DC
		public static DetectionTitlePanel GetRootAsDetectionTitlePanel(ByteBuffer _bb)
		{
			return DetectionTitlePanel.GetRootAsDetectionTitlePanel(_bb, default(DetectionTitlePanel));
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00211EF8 File Offset: 0x002100F8
		public static DetectionTitlePanel GetRootAsDetectionTitlePanel(ByteBuffer _bb, DetectionTitlePanel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00211F15 File Offset: 0x00210115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00211F24 File Offset: 0x00210124
		public DetectionTitlePanel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06006197 RID: 24983 RVA: 0x00211F34 File Offset: 0x00210134
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x00211F70 File Offset: 0x00210170
		public string TitleText
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

		// Token: 0x06006199 RID: 24985 RVA: 0x00211FA7 File Offset: 0x002101A7
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00211FB6 File Offset: 0x002101B6
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600619B RID: 24987 RVA: 0x00211FD0 File Offset: 0x002101D0
		public string SubTitleText
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

		// Token: 0x0600619C RID: 24988 RVA: 0x00212007 File Offset: 0x00210207
		public Span<byte> GetSubTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00212016 File Offset: 0x00210216
		public byte[] GetSubTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600619E RID: 24990 RVA: 0x00212030 File Offset: 0x00210230
		public string BgTexture
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

		// Token: 0x0600619F RID: 24991 RVA: 0x00212068 File Offset: 0x00210268
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00212078 File Offset: 0x00210278
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C17 RID: 19479
		private Table __p;
	}
}
