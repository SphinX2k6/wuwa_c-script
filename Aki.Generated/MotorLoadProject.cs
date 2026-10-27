using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5B RID: 3675
	public struct MotorLoadProject : IFlatbufferObject
	{
		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06009AB4 RID: 39604 RVA: 0x00294174 File Offset: 0x00292374
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x00294181 File Offset: 0x00292381
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x00294188 File Offset: 0x00292388
		public static MotorLoadProject GetRootAsMotorLoadProject(ByteBuffer _bb)
		{
			return MotorLoadProject.GetRootAsMotorLoadProject(_bb, default(MotorLoadProject));
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x002941A4 File Offset: 0x002923A4
		public static MotorLoadProject GetRootAsMotorLoadProject(ByteBuffer _bb, MotorLoadProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x002941C1 File Offset: 0x002923C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AB9 RID: 39609 RVA: 0x002941D0 File Offset: 0x002923D0
		public MotorLoadProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x002941E0 File Offset: 0x002923E0
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

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06009ABB RID: 39611 RVA: 0x0029421C File Offset: 0x0029241C
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06009ABC RID: 39612 RVA: 0x0029425C File Offset: 0x0029245C
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

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06009ABD RID: 39613 RVA: 0x00294298 File Offset: 0x00292498
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

		// Token: 0x06009ABE RID: 39614 RVA: 0x002942D0 File Offset: 0x002924D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x002942E0 File Offset: 0x002924E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x002942F8 File Offset: 0x002924F8
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

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00294330 File Offset: 0x00292530
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00294340 File Offset: 0x00292540
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x00294358 File Offset: 0x00292558
		public int Sticker(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06009AC4 RID: 39620 RVA: 0x00294398 File Offset: 0x00292598
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

		// Token: 0x06009AC5 RID: 39621 RVA: 0x002943C4 File Offset: 0x002925C4
		public Span<int> GetStickerBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x002943D4 File Offset: 0x002925D4
		public int[] GetStickerArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06009AC7 RID: 39623 RVA: 0x002943EC File Offset: 0x002925EC
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

		// Token: 0x06009AC8 RID: 39624 RVA: 0x0029442C File Offset: 0x0029262C
		public int Decorations(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06009AC9 RID: 39625 RVA: 0x0029446C File Offset: 0x0029266C
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

		// Token: 0x06009ACA RID: 39626 RVA: 0x00294498 File Offset: 0x00292698
		public Span<int> GetDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x002944A8 File Offset: 0x002926A8
		public int[] GetDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x002944C0 File Offset: 0x002926C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DecorationsIter()或GetDecorationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Decorations()
		{
			MotorLoadProject motorLoadProject = this;
			return motorLoadProject.GetDecorationsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x002944E4 File Offset: 0x002926E4
		[NullableContext(1)]
		public readonly IEnumerable<int> DecorationsIter()
		{
			MotorLoadProject.<DecorationsIter>d__35 <DecorationsIter>d__ = new MotorLoadProject.<DecorationsIter>d__35(-2);
			<DecorationsIter>d__.<>3__<>4__this = this;
			return <DecorationsIter>d__;
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x002944FC File Offset: 0x002926FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StickerIter()或GetStickerBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Sticker()
		{
			MotorLoadProject motorLoadProject = this;
			return motorLoadProject.GetStickerArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00294520 File Offset: 0x00292720
		[NullableContext(1)]
		public readonly IEnumerable<int> StickerIter()
		{
			MotorLoadProject.<StickerIter>d__37 <StickerIter>d__ = new MotorLoadProject.<StickerIter>d__37(-2);
			<StickerIter>d__.<>3__<>4__this = this;
			return <StickerIter>d__;
		}

		// Token: 0x04004F05 RID: 20229
		private Table __p;
	}
}
