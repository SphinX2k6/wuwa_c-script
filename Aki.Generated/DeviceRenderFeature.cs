using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCF RID: 3279
	public struct DeviceRenderFeature : IFlatbufferObject
	{
		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x00231968 File Offset: 0x0022FB68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00231975 File Offset: 0x0022FB75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x0023197C File Offset: 0x0022FB7C
		public static DeviceRenderFeature GetRootAsDeviceRenderFeature(ByteBuffer _bb)
		{
			return DeviceRenderFeature.GetRootAsDeviceRenderFeature(_bb, default(DeviceRenderFeature));
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00231998 File Offset: 0x0022FB98
		public static DeviceRenderFeature GetRootAsDeviceRenderFeature(ByteBuffer _bb, DeviceRenderFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x002319B5 File Offset: 0x0022FBB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x002319C4 File Offset: 0x0022FBC4
		public DeviceRenderFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x002319D4 File Offset: 0x0022FBD4
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x00231A10 File Offset: 0x0022FC10
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00231A4C File Offset: 0x0022FC4C
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

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x00231A88 File Offset: 0x0022FC88
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600679C RID: 26524 RVA: 0x00231AC8 File Offset: 0x0022FCC8
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600679D RID: 26525 RVA: 0x00231B08 File Offset: 0x0022FD08
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600679E RID: 26526 RVA: 0x00231B48 File Offset: 0x0022FD48
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

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x00231B88 File Offset: 0x0022FD88
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x00231BC8 File Offset: 0x0022FDC8
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

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x00231C08 File Offset: 0x0022FE08
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

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x00231C48 File Offset: 0x0022FE48
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

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060067A3 RID: 26531 RVA: 0x00231C88 File Offset: 0x0022FE88
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x00231CC8 File Offset: 0x0022FEC8
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

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x00231D08 File Offset: 0x0022FF08
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x00231D48 File Offset: 0x0022FF48
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x00231D88 File Offset: 0x0022FF88
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x00231DC8 File Offset: 0x0022FFC8
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

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x00231E08 File Offset: 0x00230008
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x00231E48 File Offset: 0x00230048
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060067AB RID: 26539 RVA: 0x00231E88 File Offset: 0x00230088
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

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x00231EC8 File Offset: 0x002300C8
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060067AD RID: 26541 RVA: 0x00231F08 File Offset: 0x00230108
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

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x00231F48 File Offset: 0x00230148
		public int LoadingRangeScale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060067AF RID: 26543 RVA: 0x00231F88 File Offset: 0x00230188
		public int LoadingRangeScaleMax
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x00231FC8 File Offset: 0x002301C8
		public int PlannedLoadingRangeScale
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060067B1 RID: 26545 RVA: 0x00232008 File Offset: 0x00230208
		public int PlannedLoadingRangeScaleMax
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x00232048 File Offset: 0x00230248
		public int GrassCullDistance
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x00232088 File Offset: 0x00230288
		public int GrassCullDistanceMax
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x002320C8 File Offset: 0x002302C8
		public string OtherCommand
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x00232100 File Offset: 0x00230300
		public Span<byte> GetOtherCommandBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x00232110 File Offset: 0x00230310
		public byte[] GetOtherCommandArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x040051FC RID: 20988
		private Table __p;
	}
}
