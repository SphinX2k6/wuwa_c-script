using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4F RID: 3919
	public struct MotorSticker : IFlatbufferObject
	{
		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x002B4CE0 File Offset: 0x002B2EE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x002B4CED File Offset: 0x002B2EED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x002B4CF4 File Offset: 0x002B2EF4
		public static MotorSticker GetRootAsMotorSticker(ByteBuffer _bb)
		{
			return MotorSticker.GetRootAsMotorSticker(_bb, default(MotorSticker));
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x002B4D10 File Offset: 0x002B2F10
		public static MotorSticker GetRootAsMotorSticker(ByteBuffer _bb, MotorSticker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x002B4D2D File Offset: 0x002B2F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x002B4D3C File Offset: 0x002B2F3C
		public MotorSticker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600A241 RID: 41537 RVA: 0x002B4D4C File Offset: 0x002B2F4C
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

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600A242 RID: 41538 RVA: 0x002B4D88 File Offset: 0x002B2F88
		public int GroupId
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

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600A243 RID: 41539 RVA: 0x002B4DC4 File Offset: 0x002B2FC4
		public int PartId
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

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600A244 RID: 41540 RVA: 0x002B4E00 File Offset: 0x002B3000
		public bool FreeFlag
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x002B4E40 File Offset: 0x002B3040
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600A246 RID: 41542 RVA: 0x002B4E80 File Offset: 0x002B3080
		public int SortIndex
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

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600A247 RID: 41543 RVA: 0x002B4EC0 File Offset: 0x002B30C0
		public string MaterialDA
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

		// Token: 0x0600A248 RID: 41544 RVA: 0x002B4EF8 File Offset: 0x002B30F8
		public Span<byte> GetMaterialDABytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x002B4F08 File Offset: 0x002B3108
		public byte[] GetMaterialDAArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600A24A RID: 41546 RVA: 0x002B4F20 File Offset: 0x002B3120
		public string StickerPath
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

		// Token: 0x0600A24B RID: 41547 RVA: 0x002B4F58 File Offset: 0x002B3158
		public Span<byte> GetStickerPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x002B4F68 File Offset: 0x002B3168
		public byte[] GetStickerPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600A24D RID: 41549 RVA: 0x002B4F80 File Offset: 0x002B3180
		public string StickerPBRPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x002B4FB8 File Offset: 0x002B31B8
		public Span<byte> GetStickerPBRPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x002B4FC8 File Offset: 0x002B31C8
		public byte[] GetStickerPBRPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600A250 RID: 41552 RVA: 0x002B4FE0 File Offset: 0x002B31E0
		public string StickerIconPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x002B5018 File Offset: 0x002B3218
		public Span<byte> GetStickerIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x002B5028 File Offset: 0x002B3228
		public byte[] GetStickerIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x002B5040 File Offset: 0x002B3240
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x002B5078 File Offset: 0x002B3278
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x002B5088 File Offset: 0x002B3288
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600A256 RID: 41558 RVA: 0x002B50A0 File Offset: 0x002B32A0
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x002B50D8 File Offset: 0x002B32D8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x002B50E8 File Offset: 0x002B32E8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600A259 RID: 41561 RVA: 0x002B5100 File Offset: 0x002B3300
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x002B5138 File Offset: 0x002B3338
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x002B5148 File Offset: 0x002B3348
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600A25C RID: 41564 RVA: 0x002B5160 File Offset: 0x002B3360
		public string Title
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x002B5198 File Offset: 0x002B3398
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x002B51A8 File Offset: 0x002B33A8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600A25F RID: 41567 RVA: 0x002B51C0 File Offset: 0x002B33C0
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x002B51F8 File Offset: 0x002B33F8
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x002B5208 File Offset: 0x002B3408
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x002B5220 File Offset: 0x002B3420
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x002B5258 File Offset: 0x002B3458
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x002B5268 File Offset: 0x002B3468
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600A265 RID: 41573 RVA: 0x002B5280 File Offset: 0x002B3480
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x002B52B8 File Offset: 0x002B34B8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x002B52C8 File Offset: 0x002B34C8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x002B52E0 File Offset: 0x002B34E0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x002B5320 File Offset: 0x002B3520
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x002B534C File Offset: 0x002B354C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x002B535C File Offset: 0x002B355C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x002B5374 File Offset: 0x002B3574
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600A26D RID: 41581 RVA: 0x002B53B4 File Offset: 0x002B35B4
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x002B53EC File Offset: 0x002B35EC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x002B53FC File Offset: 0x002B35FC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x002B5414 File Offset: 0x002B3614
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x002B541C File Offset: 0x002B361C
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			MotorSticker.<ItemAccessIter>d__76 <ItemAccessIter>d__ = new MotorSticker.<ItemAccessIter>d__76(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040054FC RID: 21756
		private Table __p;
	}
}
