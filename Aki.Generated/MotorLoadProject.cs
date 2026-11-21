using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F40 RID: 3904
	public struct MotorLoadProject : IFlatbufferObject
	{
		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600A0D4 RID: 41172 RVA: 0x002B1B7C File Offset: 0x002AFD7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x002B1B89 File Offset: 0x002AFD89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x002B1B90 File Offset: 0x002AFD90
		public static MotorLoadProject GetRootAsMotorLoadProject(ByteBuffer _bb)
		{
			return MotorLoadProject.GetRootAsMotorLoadProject(_bb, default(MotorLoadProject));
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x002B1BAC File Offset: 0x002AFDAC
		public static MotorLoadProject GetRootAsMotorLoadProject(ByteBuffer _bb, MotorLoadProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x002B1BC9 File Offset: 0x002AFDC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x002B1BD8 File Offset: 0x002AFDD8
		public MotorLoadProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600A0DA RID: 41178 RVA: 0x002B1BE8 File Offset: 0x002AFDE8
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

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x002B1C24 File Offset: 0x002AFE24
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600A0DC RID: 41180 RVA: 0x002B1C64 File Offset: 0x002AFE64
		public int SortIndex
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

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600A0DD RID: 41181 RVA: 0x002B1CA0 File Offset: 0x002AFEA0
		public string Name
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

		// Token: 0x0600A0DE RID: 41182 RVA: 0x002B1CD8 File Offset: 0x002AFED8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x002B1CE8 File Offset: 0x002AFEE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600A0E0 RID: 41184 RVA: 0x002B1D00 File Offset: 0x002AFF00
		public string Icon
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

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x002B1D38 File Offset: 0x002AFF38
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x002B1D48 File Offset: 0x002AFF48
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x002B1D60 File Offset: 0x002AFF60
		public int Sticker(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600A0E4 RID: 41188 RVA: 0x002B1DA0 File Offset: 0x002AFFA0
		public int StickerLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x002B1DCC File Offset: 0x002AFFCC
		public Span<int> GetStickerBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x002B1DDC File Offset: 0x002AFFDC
		public int[] GetStickerArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600A0E7 RID: 41191 RVA: 0x002B1DF4 File Offset: 0x002AFFF4
		public int Frame
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x002B1E34 File Offset: 0x002B0034
		public int Decorations(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x002B1E74 File Offset: 0x002B0074
		public int DecorationsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x002B1EA0 File Offset: 0x002B00A0
		public Span<int> GetDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x002B1EB0 File Offset: 0x002B00B0
		public int[] GetDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x002B1EC8 File Offset: 0x002B00C8
		[NullableContext(1)]
		public int[] Decorations()
		{
			return this.GetDecorationsArray();
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x002B1ED0 File Offset: 0x002B00D0
		[NullableContext(1)]
		public IEnumerable<int> DecorationsIter()
		{
			MotorLoadProject.<DecorationsIter>d__35 <DecorationsIter>d__ = new MotorLoadProject.<DecorationsIter>d__35(-2);
			<DecorationsIter>d__.<>3__<>4__this = this;
			return <DecorationsIter>d__;
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x002B1EE5 File Offset: 0x002B00E5
		[NullableContext(1)]
		public int[] Sticker()
		{
			return this.GetStickerArray();
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x002B1EED File Offset: 0x002B00ED
		[NullableContext(1)]
		public IEnumerable<int> StickerIter()
		{
			MotorLoadProject.<StickerIter>d__37 <StickerIter>d__ = new MotorLoadProject.<StickerIter>d__37(-2);
			<StickerIter>d__.<>3__<>4__this = this;
			return <StickerIter>d__;
		}

		// Token: 0x040054EA RID: 21738
		private Table __p;
	}
}
