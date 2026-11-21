using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE5 RID: 4069
	public struct PhoneMessageAttachment : IFlatbufferObject
	{
		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x002D50CD File Offset: 0x002D32CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x002D50DA File Offset: 0x002D32DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x002D50E4 File Offset: 0x002D32E4
		public static PhoneMessageAttachment GetRootAsPhoneMessageAttachment(ByteBuffer _bb)
		{
			return PhoneMessageAttachment.GetRootAsPhoneMessageAttachment(_bb, default(PhoneMessageAttachment));
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x002D5100 File Offset: 0x002D3300
		public static PhoneMessageAttachment GetRootAsPhoneMessageAttachment(ByteBuffer _bb, PhoneMessageAttachment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x002D511D File Offset: 0x002D331D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x002D512C File Offset: 0x002D332C
		public PhoneMessageAttachment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x002D513C File Offset: 0x002D333C
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

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x002D5178 File Offset: 0x002D3378
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

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x002D51AF File Offset: 0x002D33AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x002D51BE File Offset: 0x002D33BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x002D51D8 File Offset: 0x002D33D8
		public string Type
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

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x002D520F File Offset: 0x002D340F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x002D521E File Offset: 0x002D341E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x002D5238 File Offset: 0x002D3438
		public string Thumbnail
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

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x002D5270 File Offset: 0x002D3470
		public Span<byte> GetThumbnailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x002D5280 File Offset: 0x002D3480
		public byte[] GetThumbnailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x002D5298 File Offset: 0x002D3498
		public string ThumbnailMaleVariant
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

		// Token: 0x0600B0FB RID: 45307 RVA: 0x002D52D0 File Offset: 0x002D34D0
		public Span<byte> GetThumbnailMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x002D52E0 File Offset: 0x002D34E0
		public byte[] GetThumbnailMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x002D52F8 File Offset: 0x002D34F8
		public string AttachmentPath
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

		// Token: 0x0600B0FE RID: 45310 RVA: 0x002D5330 File Offset: 0x002D3530
		public Span<byte> GetAttachmentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x002D5340 File Offset: 0x002D3540
		public byte[] GetAttachmentPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600B100 RID: 45312 RVA: 0x002D5358 File Offset: 0x002D3558
		public string AttachmentPathMaleVariant
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

		// Token: 0x0600B101 RID: 45313 RVA: 0x002D5390 File Offset: 0x002D3590
		public Span<byte> GetAttachmentPathMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x002D53A0 File Offset: 0x002D35A0
		public byte[] GetAttachmentPathMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600B103 RID: 45315 RVA: 0x002D53B8 File Offset: 0x002D35B8
		public int InformationViewId
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

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600B104 RID: 45316 RVA: 0x002D53F8 File Offset: 0x002D35F8
		public int InformationViewIdMaleVariant
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

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0600B105 RID: 45317 RVA: 0x002D5438 File Offset: 0x002D3638
		public int CoordinateTeleportId
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

		// Token: 0x040055AD RID: 21933
		private Table __p;
	}
}
