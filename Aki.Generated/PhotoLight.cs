using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0F RID: 3855
	public struct PhotoLight : IFlatbufferObject
	{
		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600AC43 RID: 44099 RVA: 0x002BB795 File Offset: 0x002B9995
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x002BB7A2 File Offset: 0x002B99A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC45 RID: 44101 RVA: 0x002BB7AC File Offset: 0x002B99AC
		public static PhotoLight GetRootAsPhotoLight(ByteBuffer _bb)
		{
			return PhotoLight.GetRootAsPhotoLight(_bb, default(PhotoLight));
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x002BB7C8 File Offset: 0x002B99C8
		public static PhotoLight GetRootAsPhotoLight(ByteBuffer _bb, PhotoLight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x002BB7E5 File Offset: 0x002B99E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x002BB7F4 File Offset: 0x002B99F4
		public PhotoLight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600AC49 RID: 44105 RVA: 0x002BB804 File Offset: 0x002B9A04
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

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x0600AC4A RID: 44106 RVA: 0x002BB840 File Offset: 0x002B9A40
		public string IconMale
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

		// Token: 0x0600AC4B RID: 44107 RVA: 0x002BB877 File Offset: 0x002B9A77
		public Span<byte> GetIconMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x002BB886 File Offset: 0x002B9A86
		public byte[] GetIconMaleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600AC4D RID: 44109 RVA: 0x002BB8A0 File Offset: 0x002B9AA0
		public string IconFemale
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

		// Token: 0x0600AC4E RID: 44110 RVA: 0x002BB8D7 File Offset: 0x002B9AD7
		public Span<byte> GetIconFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x002BB8E6 File Offset: 0x002B9AE6
		public byte[] GetIconFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x002BB900 File Offset: 0x002B9B00
		public string Name
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

		// Token: 0x0600AC51 RID: 44113 RVA: 0x002BB938 File Offset: 0x002B9B38
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x002BB948 File Offset: 0x002B9B48
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x002BB960 File Offset: 0x002B9B60
		public int RelativeItem
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x002BB9A0 File Offset: 0x002B9BA0
		public int DefaultStrength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 50;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x002BB9E0 File Offset: 0x002B9BE0
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600AC56 RID: 44118 RVA: 0x002BBA20 File Offset: 0x002B9C20
		public float Direction
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x002BBA64 File Offset: 0x002B9C64
		public float HighlightHue
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x002BBAA8 File Offset: 0x002B9CA8
		public float HighlightSaturation
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x002BBAEC File Offset: 0x002B9CEC
		public float HighlightValue
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x002BBB30 File Offset: 0x002B9D30
		public float ShadowHue
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x002BBB74 File Offset: 0x002B9D74
		public float ShadowSaturation
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x002BBBB8 File Offset: 0x002B9DB8
		public float ShadowValue
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600AC5D RID: 44125 RVA: 0x002BBBFC File Offset: 0x002B9DFC
		public float RimLightHue
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x002BBC40 File Offset: 0x002B9E40
		public float RimLightSaturation
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x002BBC84 File Offset: 0x002B9E84
		public float RimLightValue
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FD7 RID: 20439
		private Table __p;
	}
}
