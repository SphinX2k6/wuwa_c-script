using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E27 RID: 3623
	public struct HonamiStoryOutDialog : IFlatbufferObject
	{
		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x0027748D File Offset: 0x0027568D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x0027749A File Offset: 0x0027569A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x002774A4 File Offset: 0x002756A4
		public static HonamiStoryOutDialog GetRootAsHonamiStoryOutDialog(ByteBuffer _bb)
		{
			return HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(_bb, default(HonamiStoryOutDialog));
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x002774C0 File Offset: 0x002756C0
		public static HonamiStoryOutDialog GetRootAsHonamiStoryOutDialog(ByteBuffer _bb, HonamiStoryOutDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x002774DD File Offset: 0x002756DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x002774EC File Offset: 0x002756EC
		public HonamiStoryOutDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x002774FC File Offset: 0x002756FC
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

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x060086B4 RID: 34484 RVA: 0x00277538 File Offset: 0x00275738
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

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x00277574 File Offset: 0x00275774
		public int Type
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060086B6 RID: 34486 RVA: 0x002775B0 File Offset: 0x002757B0
		public int Interval
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x002775F0 File Offset: 0x002757F0
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

		// Token: 0x060086B8 RID: 34488 RVA: 0x00277628 File Offset: 0x00275828
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x00277638 File Offset: 0x00275838
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x00277650 File Offset: 0x00275850
		public string Desc
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

		// Token: 0x060086BB RID: 34491 RVA: 0x00277688 File Offset: 0x00275888
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x00277698 File Offset: 0x00275898
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x002776B0 File Offset: 0x002758B0
		public string AudioEvent
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

		// Token: 0x060086BE RID: 34494 RVA: 0x002776E8 File Offset: 0x002758E8
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x002776F8 File Offset: 0x002758F8
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060086C0 RID: 34496 RVA: 0x00277710 File Offset: 0x00275910
		public string MontagePath
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

		// Token: 0x060086C1 RID: 34497 RVA: 0x00277748 File Offset: 0x00275948
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x00277758 File Offset: 0x00275958
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060086C3 RID: 34499 RVA: 0x00277770 File Offset: 0x00275970
		public int EntityId
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

		// Token: 0x040053A2 RID: 21410
		private Table __p;
	}
}
