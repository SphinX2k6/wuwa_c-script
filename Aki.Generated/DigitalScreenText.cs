using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF0 RID: 3056
	public struct DigitalScreenText : IFlatbufferObject
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600621C RID: 25116 RVA: 0x00213255 File Offset: 0x00211455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x00213262 File Offset: 0x00211462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x0021326C File Offset: 0x0021146C
		public static DigitalScreenText GetRootAsDigitalScreenText(ByteBuffer _bb)
		{
			return DigitalScreenText.GetRootAsDigitalScreenText(_bb, default(DigitalScreenText));
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00213288 File Offset: 0x00211488
		public static DigitalScreenText GetRootAsDigitalScreenText(ByteBuffer _bb, DigitalScreenText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x002132A5 File Offset: 0x002114A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x002132B4 File Offset: 0x002114B4
		public DigitalScreenText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06006222 RID: 25122 RVA: 0x002132C4 File Offset: 0x002114C4
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x00213300 File Offset: 0x00211500
		public string TextContentId
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

		// Token: 0x06006224 RID: 25124 RVA: 0x00213337 File Offset: 0x00211537
		public Span<byte> GetTextContentIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x00213346 File Offset: 0x00211546
		public byte[] GetTextContentIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06006226 RID: 25126 RVA: 0x00213360 File Offset: 0x00211560
		public int Alignment
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06006227 RID: 25127 RVA: 0x0021339C File Offset: 0x0021159C
		public int FontSize
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06006228 RID: 25128 RVA: 0x002133DC File Offset: 0x002115DC
		public float ShowStartFrame
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06006229 RID: 25129 RVA: 0x00213420 File Offset: 0x00211620
		public float ShowEndFrame
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600622A RID: 25130 RVA: 0x00213464 File Offset: 0x00211664
		public float HideFrame
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600622B RID: 25131 RVA: 0x002134A8 File Offset: 0x002116A8
		public int Effect
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004C1D RID: 19485
		private Table __p;
	}
}
