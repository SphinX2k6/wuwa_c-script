using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F04 RID: 3844
	public struct PhotoAtmosphere : IFlatbufferObject
	{
		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x002B8E65 File Offset: 0x002B7065
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x002B8E72 File Offset: 0x002B7072
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x002B8E7C File Offset: 0x002B707C
		public static PhotoAtmosphere GetRootAsPhotoAtmosphere(ByteBuffer _bb)
		{
			return PhotoAtmosphere.GetRootAsPhotoAtmosphere(_bb, default(PhotoAtmosphere));
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x002B8E98 File Offset: 0x002B7098
		public static PhotoAtmosphere GetRootAsPhotoAtmosphere(ByteBuffer _bb, PhotoAtmosphere obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x002B8EB5 File Offset: 0x002B70B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x002B8EC4 File Offset: 0x002B70C4
		public PhotoAtmosphere __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x002B8ED4 File Offset: 0x002B70D4
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

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600AB29 RID: 43817 RVA: 0x002B8F10 File Offset: 0x002B7110
		public string Icon
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

		// Token: 0x0600AB2A RID: 43818 RVA: 0x002B8F47 File Offset: 0x002B7147
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x002B8F56 File Offset: 0x002B7156
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600AB2C RID: 43820 RVA: 0x002B8F70 File Offset: 0x002B7170
		public string Name
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

		// Token: 0x0600AB2D RID: 43821 RVA: 0x002B8FA7 File Offset: 0x002B71A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x002B8FB6 File Offset: 0x002B71B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x002B8FD0 File Offset: 0x002B71D0
		public int RelativeItem
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

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600AB30 RID: 43824 RVA: 0x002B9010 File Offset: 0x002B7210
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x002B9050 File Offset: 0x002B7250
		public int EffectType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x002B9090 File Offset: 0x002B7290
		public int DefaultStrength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 50;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FCC RID: 20428
		private Table __p;
	}
}
