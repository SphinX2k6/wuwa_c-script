using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBC RID: 4028
	public struct PhantomBattleMasterTitle : IFlatbufferObject
	{
		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x002CE086 File Offset: 0x002CC286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x002CE093 File Offset: 0x002CC293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x002CE09C File Offset: 0x002CC29C
		public static PhantomBattleMasterTitle GetRootAsPhantomBattleMasterTitle(ByteBuffer _bb)
		{
			return PhantomBattleMasterTitle.GetRootAsPhantomBattleMasterTitle(_bb, default(PhantomBattleMasterTitle));
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x002CE0B8 File Offset: 0x002CC2B8
		public static PhantomBattleMasterTitle GetRootAsPhantomBattleMasterTitle(ByteBuffer _bb, PhantomBattleMasterTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x002CE0D5 File Offset: 0x002CC2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x002CE0E4 File Offset: 0x002CC2E4
		public PhantomBattleMasterTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x0600ADBE RID: 44478 RVA: 0x002CE0F4 File Offset: 0x002CC2F4
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

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x002CE130 File Offset: 0x002CC330
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

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x002CE167 File Offset: 0x002CC367
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x002CE176 File Offset: 0x002CC376
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002CE190 File Offset: 0x002CC390
		public string Icon
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

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x002CE1C7 File Offset: 0x002CC3C7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x002CE1D6 File Offset: 0x002CC3D6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600ADC5 RID: 44485 RVA: 0x002CE1F0 File Offset: 0x002CC3F0
		public string IconBg
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

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x002CE228 File Offset: 0x002CC428
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x002CE238 File Offset: 0x002CC438
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400557A RID: 21882
		private Table __p;
	}
}
