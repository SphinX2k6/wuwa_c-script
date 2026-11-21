using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001024 RID: 4132
	public struct PinballWeaponQuality : IFlatbufferObject
	{
		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600B6ED RID: 46829 RVA: 0x002E280F File Offset: 0x002E0A0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x002E281C File Offset: 0x002E0A1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x002E2824 File Offset: 0x002E0A24
		public static PinballWeaponQuality GetRootAsPinballWeaponQuality(ByteBuffer _bb)
		{
			return PinballWeaponQuality.GetRootAsPinballWeaponQuality(_bb, default(PinballWeaponQuality));
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x002E2840 File Offset: 0x002E0A40
		public static PinballWeaponQuality GetRootAsPinballWeaponQuality(ByteBuffer _bb, PinballWeaponQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x002E285D File Offset: 0x002E0A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x002E286C File Offset: 0x002E0A6C
		public PinballWeaponQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0600B6F3 RID: 46835 RVA: 0x002E287C File Offset: 0x002E0A7C
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

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600B6F4 RID: 46836 RVA: 0x002E28B8 File Offset: 0x002E0AB8
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

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x002E28EF File Offset: 0x002E0AEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x002E28FE File Offset: 0x002E0AFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x002E2918 File Offset: 0x002E0B18
		public string TexQuality
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

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x002E294F File Offset: 0x002E0B4F
		public Span<byte> GetTexQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x002E295E File Offset: 0x002E0B5E
		public byte[] GetTexQualityArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600B6FA RID: 46842 RVA: 0x002E2978 File Offset: 0x002E0B78
		public string Color
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

		// Token: 0x0600B6FB RID: 46843 RVA: 0x002E29B0 File Offset: 0x002E0BB0
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x002E29C0 File Offset: 0x002E0BC0
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040055EE RID: 21998
		private Table __p;
	}
}
