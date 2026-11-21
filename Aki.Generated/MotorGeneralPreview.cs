using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3B RID: 3899
	public struct MotorGeneralPreview : IFlatbufferObject
	{
		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x002B09D8 File Offset: 0x002AEBD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x002B09E5 File Offset: 0x002AEBE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x002B09EC File Offset: 0x002AEBEC
		public static MotorGeneralPreview GetRootAsMotorGeneralPreview(ByteBuffer _bb)
		{
			return MotorGeneralPreview.GetRootAsMotorGeneralPreview(_bb, default(MotorGeneralPreview));
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x002B0A08 File Offset: 0x002AEC08
		public static MotorGeneralPreview GetRootAsMotorGeneralPreview(ByteBuffer _bb, MotorGeneralPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x002B0A25 File Offset: 0x002AEC25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x002B0A34 File Offset: 0x002AEC34
		public MotorGeneralPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x002B0A44 File Offset: 0x002AEC44
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

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600A053 RID: 41043 RVA: 0x002B0A80 File Offset: 0x002AEC80
		public int Frame
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

		// Token: 0x0600A054 RID: 41044 RVA: 0x002B0ABC File Offset: 0x002AECBC
		public int Sticker(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600A055 RID: 41045 RVA: 0x002B0AFC File Offset: 0x002AECFC
		public int StickerLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x002B0B27 File Offset: 0x002AED27
		public Span<int> GetStickerBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x002B0B36 File Offset: 0x002AED36
		public int[] GetStickerArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x002B0B50 File Offset: 0x002AED50
		public int Decorations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x002B0B90 File Offset: 0x002AED90
		public int DecorationsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x002B0BBC File Offset: 0x002AEDBC
		public Span<int> GetDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x002B0BCC File Offset: 0x002AEDCC
		public int[] GetDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600A05C RID: 41052 RVA: 0x002B0BE4 File Offset: 0x002AEDE4
		public string Title
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

		// Token: 0x0600A05D RID: 41053 RVA: 0x002B0C1C File Offset: 0x002AEE1C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x002B0C2C File Offset: 0x002AEE2C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x002B0C44 File Offset: 0x002AEE44
		public string SubTitle
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

		// Token: 0x0600A060 RID: 41056 RVA: 0x002B0C7C File Offset: 0x002AEE7C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x002B0C8C File Offset: 0x002AEE8C
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x0600A062 RID: 41058 RVA: 0x002B0CA4 File Offset: 0x002AEEA4
		public bool IsShowIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x002B0CE4 File Offset: 0x002AEEE4
		public string IconTitle
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

		// Token: 0x0600A064 RID: 41060 RVA: 0x002B0D1C File Offset: 0x002AEF1C
		public Span<byte> GetIconTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x002B0D2C File Offset: 0x002AEF2C
		public byte[] GetIconTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x002B0D44 File Offset: 0x002AEF44
		public string Describe
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

		// Token: 0x0600A067 RID: 41063 RVA: 0x002B0D7C File Offset: 0x002AEF7C
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x002B0D8C File Offset: 0x002AEF8C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x002B0DA4 File Offset: 0x002AEFA4
		public string CameraId
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

		// Token: 0x0600A06A RID: 41066 RVA: 0x002B0DDC File Offset: 0x002AEFDC
		public Span<byte> GetCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x002B0DEC File Offset: 0x002AEFEC
		public byte[] GetCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x002B0E04 File Offset: 0x002AF004
		public bool IsFree
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600A06D RID: 41069 RVA: 0x002B0E44 File Offset: 0x002AF044
		public string FreeCamera
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

		// Token: 0x0600A06E RID: 41070 RVA: 0x002B0E7C File Offset: 0x002AF07C
		public Span<byte> GetFreeCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x002B0E8C File Offset: 0x002AF08C
		public byte[] GetFreeCameraArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600A070 RID: 41072 RVA: 0x002B0EA4 File Offset: 0x002AF0A4
		public string FreeCameraConfig
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

		// Token: 0x0600A071 RID: 41073 RVA: 0x002B0EDC File Offset: 0x002AF0DC
		public Span<byte> GetFreeCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x002B0EEC File Offset: 0x002AF0EC
		public byte[] GetFreeCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x002B0F04 File Offset: 0x002AF104
		[NullableContext(1)]
		public int[] Decorations()
		{
			return this.GetDecorationsArray();
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x002B0F0C File Offset: 0x002AF10C
		[NullableContext(1)]
		public IEnumerable<int> DecorationsIter()
		{
			MotorGeneralPreview.<DecorationsIter>d__55 <DecorationsIter>d__ = new MotorGeneralPreview.<DecorationsIter>d__55(-2);
			<DecorationsIter>d__.<>3__<>4__this = this;
			return <DecorationsIter>d__;
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x002B0F21 File Offset: 0x002AF121
		[NullableContext(1)]
		public int[] Sticker()
		{
			return this.GetStickerArray();
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x002B0F29 File Offset: 0x002AF129
		[NullableContext(1)]
		public IEnumerable<int> StickerIter()
		{
			MotorGeneralPreview.<StickerIter>d__57 <StickerIter>d__ = new MotorGeneralPreview.<StickerIter>d__57(-2);
			<StickerIter>d__.<>3__<>4__this = this;
			return <StickerIter>d__;
		}

		// Token: 0x040054E4 RID: 21732
		private Table __p;
	}
}
