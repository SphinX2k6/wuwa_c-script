using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BED RID: 3053
	public struct DeviceRenderFeature : IFlatbufferObject
	{
		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x0021233C File Offset: 0x0021053C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00212349 File Offset: 0x00210549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00212350 File Offset: 0x00210550
		public static DeviceRenderFeature GetRootAsDeviceRenderFeature(ByteBuffer _bb)
		{
			return DeviceRenderFeature.GetRootAsDeviceRenderFeature(_bb, default(DeviceRenderFeature));
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x0021236C File Offset: 0x0021056C
		public static DeviceRenderFeature GetRootAsDeviceRenderFeature(ByteBuffer _bb, DeviceRenderFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00212389 File Offset: 0x00210589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00212398 File Offset: 0x00210598
		public DeviceRenderFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x002123A8 File Offset: 0x002105A8
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

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x002123E4 File Offset: 0x002105E4
		public int DeviceId
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x00212420 File Offset: 0x00210620
		public int QualityType
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x0021245C File Offset: 0x0021065C
		public int DefaultQuality
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060061C3 RID: 25027 RVA: 0x0021249C File Offset: 0x0021069C
		public int FPS
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 30;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060061C4 RID: 25028 RVA: 0x002124DC File Offset: 0x002106DC
		public int ShadowQuality
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060061C5 RID: 25029 RVA: 0x0021251C File Offset: 0x0021071C
		public int FxQuality
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060061C6 RID: 25030 RVA: 0x0021255C File Offset: 0x0021075C
		public int ImageDetail
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x0021259C File Offset: 0x0021079C
		public int AntiAliasing
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060061C8 RID: 25032 RVA: 0x002125DC File Offset: 0x002107DC
		public int AO
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060061C9 RID: 25033 RVA: 0x0021261C File Offset: 0x0021081C
		public int VolumeFog
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060061CA RID: 25034 RVA: 0x0021265C File Offset: 0x0021085C
		public int VolumeLight
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060061CB RID: 25035 RVA: 0x0021269C File Offset: 0x0021089C
		public int MotionBlur
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060061CC RID: 25036 RVA: 0x002126DC File Offset: 0x002108DC
		public int StreamLevel
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x0021271C File Offset: 0x0021091C
		public int VSync
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060061CE RID: 25038 RVA: 0x0021275C File Offset: 0x0021095C
		public int ScreenPercentage
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x0021279C File Offset: 0x0021099C
		public int VegetationDensity
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060061D0 RID: 25040 RVA: 0x002127DC File Offset: 0x002109DC
		public int AnisoLevel
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060061D1 RID: 25041 RVA: 0x0021281C File Offset: 0x00210A1C
		public int SuperResolution
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060061D2 RID: 25042 RVA: 0x0021285C File Offset: 0x00210A5C
		public int NpcDensity
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x0021289C File Offset: 0x00210A9C
		public int Bloom
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x002128DC File Offset: 0x00210ADC
		public int Raytracing
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x0021291C File Offset: 0x00210B1C
		public int LoadingRangeScale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060061D6 RID: 25046 RVA: 0x0021295C File Offset: 0x00210B5C
		public string OtherCommand
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x00212994 File Offset: 0x00210B94
		public Span<byte> GetOtherCommandBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x002129A4 File Offset: 0x00210BA4
		public byte[] GetOtherCommandArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C1A RID: 19482
		private Table __p;
	}
}
