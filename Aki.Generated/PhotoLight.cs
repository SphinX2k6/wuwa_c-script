using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF4 RID: 4084
	public struct PhotoLight : IFlatbufferObject
	{
		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600B264 RID: 45668 RVA: 0x002D8425 File Offset: 0x002D6625
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x002D8432 File Offset: 0x002D6632
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x002D843C File Offset: 0x002D663C
		public static PhotoLight GetRootAsPhotoLight(ByteBuffer _bb)
		{
			return PhotoLight.GetRootAsPhotoLight(_bb, default(PhotoLight));
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x002D8458 File Offset: 0x002D6658
		public static PhotoLight GetRootAsPhotoLight(ByteBuffer _bb, PhotoLight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x002D8475 File Offset: 0x002D6675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x002D8484 File Offset: 0x002D6684
		public PhotoLight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x002D8494 File Offset: 0x002D6694
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

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600B26B RID: 45675 RVA: 0x002D84D0 File Offset: 0x002D66D0
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

		// Token: 0x0600B26C RID: 45676 RVA: 0x002D8507 File Offset: 0x002D6707
		public Span<byte> GetIconMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B26D RID: 45677 RVA: 0x002D8516 File Offset: 0x002D6716
		public byte[] GetIconMaleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x002D8530 File Offset: 0x002D6730
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

		// Token: 0x0600B26F RID: 45679 RVA: 0x002D8567 File Offset: 0x002D6767
		public Span<byte> GetIconFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x002D8576 File Offset: 0x002D6776
		public byte[] GetIconFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600B271 RID: 45681 RVA: 0x002D8590 File Offset: 0x002D6790
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

		// Token: 0x0600B272 RID: 45682 RVA: 0x002D85C8 File Offset: 0x002D67C8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x002D85D8 File Offset: 0x002D67D8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x002D85F0 File Offset: 0x002D67F0
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

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600B275 RID: 45685 RVA: 0x002D8630 File Offset: 0x002D6830
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

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x002D8670 File Offset: 0x002D6870
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600B277 RID: 45687 RVA: 0x002D86B0 File Offset: 0x002D68B0
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

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x002D86F4 File Offset: 0x002D68F4
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

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600B279 RID: 45689 RVA: 0x002D8738 File Offset: 0x002D6938
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

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x002D877C File Offset: 0x002D697C
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

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600B27B RID: 45691 RVA: 0x002D87C0 File Offset: 0x002D69C0
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

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x002D8804 File Offset: 0x002D6A04
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

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600B27D RID: 45693 RVA: 0x002D8848 File Offset: 0x002D6A48
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

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x002D888C File Offset: 0x002D6A8C
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

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600B27F RID: 45695 RVA: 0x002D88D0 File Offset: 0x002D6AD0
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

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x002D8914 File Offset: 0x002D6B14
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

		// Token: 0x040055BC RID: 21948
		private Table __p;
	}
}
