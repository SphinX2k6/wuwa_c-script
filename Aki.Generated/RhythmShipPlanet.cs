using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AD RID: 4269
	public struct RhythmShipPlanet : IFlatbufferObject
	{
		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600C310 RID: 49936 RVA: 0x002FC2B5 File Offset: 0x002FA4B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x002FC2C2 File Offset: 0x002FA4C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x002FC2CC File Offset: 0x002FA4CC
		public static RhythmShipPlanet GetRootAsRhythmShipPlanet(ByteBuffer _bb)
		{
			return RhythmShipPlanet.GetRootAsRhythmShipPlanet(_bb, default(RhythmShipPlanet));
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x002FC2E8 File Offset: 0x002FA4E8
		public static RhythmShipPlanet GetRootAsRhythmShipPlanet(ByteBuffer _bb, RhythmShipPlanet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x002FC305 File Offset: 0x002FA505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x002FC314 File Offset: 0x002FA514
		public RhythmShipPlanet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600C316 RID: 49942 RVA: 0x002FC324 File Offset: 0x002FA524
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

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600C317 RID: 49943 RVA: 0x002FC360 File Offset: 0x002FA560
		public int Type
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

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600C318 RID: 49944 RVA: 0x002FC39C File Offset: 0x002FA59C
		public int ActivityId
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

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600C319 RID: 49945 RVA: 0x002FC3D8 File Offset: 0x002FA5D8
		public int OpenDay
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

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600C31A RID: 49946 RVA: 0x002FC418 File Offset: 0x002FA618
		public string Name
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

		// Token: 0x0600C31B RID: 49947 RVA: 0x002FC450 File Offset: 0x002FA650
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x002FC460 File Offset: 0x002FA660
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600C31D RID: 49949 RVA: 0x002FC478 File Offset: 0x002FA678
		public string BgTexture
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x002FC4B0 File Offset: 0x002FA6B0
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x002FC4C0 File Offset: 0x002FA6C0
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600C320 RID: 49952 RVA: 0x002FC4D8 File Offset: 0x002FA6D8
		public int LoadingId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600C321 RID: 49953 RVA: 0x002FC518 File Offset: 0x002FA718
		public int BgId
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

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600C322 RID: 49954 RVA: 0x002FC558 File Offset: 0x002FA758
		public int LevelType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005687 RID: 22151
		private Table __p;
	}
}
