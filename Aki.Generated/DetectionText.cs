using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE9 RID: 3049
	public struct DetectionText : IFlatbufferObject
	{
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600617F RID: 24959 RVA: 0x00211C81 File Offset: 0x0020FE81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x00211C8E File Offset: 0x0020FE8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x00211C98 File Offset: 0x0020FE98
		public static DetectionText GetRootAsDetectionText(ByteBuffer _bb)
		{
			return DetectionText.GetRootAsDetectionText(_bb, default(DetectionText));
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00211CB4 File Offset: 0x0020FEB4
		public static DetectionText GetRootAsDetectionText(ByteBuffer _bb, DetectionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x00211CD1 File Offset: 0x0020FED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x00211CE0 File Offset: 0x0020FEE0
		public DetectionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x00211CF0 File Offset: 0x0020FEF0
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x00211D2C File Offset: 0x0020FF2C
		public int ConditionGroupId
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06006187 RID: 24967 RVA: 0x00211D68 File Offset: 0x0020FF68
		public string Text
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

		// Token: 0x06006188 RID: 24968 RVA: 0x00211D9F File Offset: 0x0020FF9F
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x00211DAE File Offset: 0x0020FFAE
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x00211DC8 File Offset: 0x0020FFC8
		public string SubText
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

		// Token: 0x0600618B RID: 24971 RVA: 0x00211E00 File Offset: 0x00210000
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x00211E10 File Offset: 0x00210010
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600618D RID: 24973 RVA: 0x00211E28 File Offset: 0x00210028
		public string Icon
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

		// Token: 0x0600618E RID: 24974 RVA: 0x00211E60 File Offset: 0x00210060
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00211E70 File Offset: 0x00210070
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06006190 RID: 24976 RVA: 0x00211E88 File Offset: 0x00210088
		public int HelpGroupId
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

		// Token: 0x04004C16 RID: 19478
		private Table __p;
	}
}
