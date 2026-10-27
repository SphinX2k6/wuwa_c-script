using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB9 RID: 3769
	public struct PersonalTips : IFlatbufferObject
	{
		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x002A7EFC File Offset: 0x002A60FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x002A7F09 File Offset: 0x002A6109
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x002A7F10 File Offset: 0x002A6110
		public static PersonalTips GetRootAsPersonalTips(ByteBuffer _bb)
		{
			return PersonalTips.GetRootAsPersonalTips(_bb, default(PersonalTips));
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x002A7F2C File Offset: 0x002A612C
		public static PersonalTips GetRootAsPersonalTips(ByteBuffer _bb, PersonalTips obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x002A7F49 File Offset: 0x002A6149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x002A7F58 File Offset: 0x002A6158
		public PersonalTips __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x002A7F68 File Offset: 0x002A6168
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

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x002A7FA4 File Offset: 0x002A61A4
		public int FunctionId
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

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x002A7FE0 File Offset: 0x002A61E0
		public int Sort
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

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x0600A3C4 RID: 41924 RVA: 0x002A801C File Offset: 0x002A621C
		public string RedDotName
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

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x002A8054 File Offset: 0x002A6254
		public Span<byte> GetRedDotNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x002A8064 File Offset: 0x002A6264
		public byte[] GetRedDotNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x002A807C File Offset: 0x002A627C
		public string Description
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

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x002A80B4 File Offset: 0x002A62B4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x002A80C4 File Offset: 0x002A62C4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x002A80DC File Offset: 0x002A62DC
		public string IconPath
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

		// Token: 0x0600A3CB RID: 41931 RVA: 0x002A8114 File Offset: 0x002A6314
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x002A8124 File Offset: 0x002A6324
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F6F RID: 20335
		private Table __p;
	}
}
