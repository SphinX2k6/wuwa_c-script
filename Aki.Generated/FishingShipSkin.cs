using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6F RID: 3439
	public struct FishingShipSkin : IFlatbufferObject
	{
		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x00252E5D File Offset: 0x0025105D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00252E6A File Offset: 0x0025106A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00252E74 File Offset: 0x00251074
		public static FishingShipSkin GetRootAsFishingShipSkin(ByteBuffer _bb)
		{
			return FishingShipSkin.GetRootAsFishingShipSkin(_bb, default(FishingShipSkin));
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00252E90 File Offset: 0x00251090
		public static FishingShipSkin GetRootAsFishingShipSkin(ByteBuffer _bb, FishingShipSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00252EAD File Offset: 0x002510AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00252EBC File Offset: 0x002510BC
		public FishingShipSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600767B RID: 30331 RVA: 0x00252ECC File Offset: 0x002510CC
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

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x00252F08 File Offset: 0x00251108
		public string Name
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

		// Token: 0x0600767D RID: 30333 RVA: 0x00252F3F File Offset: 0x0025113F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00252F4E File Offset: 0x0025114E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x00252F68 File Offset: 0x00251168
		public string IconTexture
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

		// Token: 0x06007680 RID: 30336 RVA: 0x00252F9F File Offset: 0x0025119F
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00252FAE File Offset: 0x002511AE
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x00252FC8 File Offset: 0x002511C8
		public string BigTexture
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

		// Token: 0x06007683 RID: 30339 RVA: 0x00253000 File Offset: 0x00251200
		public Span<byte> GetBigTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00253010 File Offset: 0x00251210
		public byte[] GetBigTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x00253028 File Offset: 0x00251228
		public string DesText
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

		// Token: 0x06007686 RID: 30342 RVA: 0x00253060 File Offset: 0x00251260
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00253070 File Offset: 0x00251270
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x00253088 File Offset: 0x00251288
		public string LockText
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

		// Token: 0x06007689 RID: 30345 RVA: 0x002530C0 File Offset: 0x002512C0
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x002530D0 File Offset: 0x002512D0
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x002530E8 File Offset: 0x002512E8
		public string Mesh
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

		// Token: 0x0600768C RID: 30348 RVA: 0x00253120 File Offset: 0x00251320
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00253130 File Offset: 0x00251330
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x00253148 File Offset: 0x00251348
		public int TemplateId
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600768F RID: 30351 RVA: 0x00253188 File Offset: 0x00251388
		public int TechLevel
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

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x002531C8 File Offset: 0x002513C8
		public int TechEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052C4 RID: 21188
		private Table __p;
	}
}
