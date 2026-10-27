using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F41 RID: 3905
	public struct PinballWeaponType : IFlatbufferObject
	{
		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600B0ED RID: 45293 RVA: 0x002C6347 File Offset: 0x002C4547
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x002C6354 File Offset: 0x002C4554
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x002C635C File Offset: 0x002C455C
		public static PinballWeaponType GetRootAsPinballWeaponType(ByteBuffer _bb)
		{
			return PinballWeaponType.GetRootAsPinballWeaponType(_bb, default(PinballWeaponType));
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x002C6378 File Offset: 0x002C4578
		public static PinballWeaponType GetRootAsPinballWeaponType(ByteBuffer _bb, PinballWeaponType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0F1 RID: 45297 RVA: 0x002C6395 File Offset: 0x002C4595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x002C63A4 File Offset: 0x002C45A4
		public PinballWeaponType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x002C63B4 File Offset: 0x002C45B4
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

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x002C63F0 File Offset: 0x002C45F0
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

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x002C6427 File Offset: 0x002C4627
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x002C6436 File Offset: 0x002C4636
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x002C6450 File Offset: 0x002C4650
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

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x002C6487 File Offset: 0x002C4687
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x002C6496 File Offset: 0x002C4696
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x002C64B0 File Offset: 0x002C46B0
		public string Icon2
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

		// Token: 0x0600B0FB RID: 45307 RVA: 0x002C64E8 File Offset: 0x002C46E8
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x002C64F8 File Offset: 0x002C46F8
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x002C6510 File Offset: 0x002C4710
		public string Icon3
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

		// Token: 0x0600B0FE RID: 45310 RVA: 0x002C6548 File Offset: 0x002C4748
		public Span<byte> GetIcon3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x002C6558 File Offset: 0x002C4758
		public byte[] GetIcon3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400500B RID: 20491
		private Table __p;
	}
}
