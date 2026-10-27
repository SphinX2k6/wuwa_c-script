using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E4 RID: 4324
	public struct SpringChat : IFlatbufferObject
	{
		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600D82F RID: 55343 RVA: 0x0031E94D File Offset: 0x0031CB4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D830 RID: 55344 RVA: 0x0031E95A File Offset: 0x0031CB5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D831 RID: 55345 RVA: 0x0031E964 File Offset: 0x0031CB64
		public static SpringChat GetRootAsSpringChat(ByteBuffer _bb)
		{
			return SpringChat.GetRootAsSpringChat(_bb, default(SpringChat));
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x0031E980 File Offset: 0x0031CB80
		public static SpringChat GetRootAsSpringChat(ByteBuffer _bb, SpringChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x0031E99D File Offset: 0x0031CB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x0031E9AC File Offset: 0x0031CBAC
		public SpringChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600D835 RID: 55349 RVA: 0x0031E9BC File Offset: 0x0031CBBC
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

		// Token: 0x0600D836 RID: 55350 RVA: 0x0031E9F8 File Offset: 0x0031CBF8
		public string ContentList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600D837 RID: 55351 RVA: 0x0031EA34 File Offset: 0x0031CC34
		public int ContentListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D838 RID: 55352 RVA: 0x0031EA60 File Offset: 0x0031CC60
		public int PosList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600D839 RID: 55353 RVA: 0x0031EAA0 File Offset: 0x0031CCA0
		public int PosListLength
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

		// Token: 0x0600D83A RID: 55354 RVA: 0x0031EACB File Offset: 0x0031CCCB
		public Span<int> GetPosListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D83B RID: 55355 RVA: 0x0031EADA File Offset: 0x0031CCDA
		public int[] GetPosListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D83C RID: 55356 RVA: 0x0031EAF4 File Offset: 0x0031CCF4
		public string AnimNameList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600D83D RID: 55357 RVA: 0x0031EB30 File Offset: 0x0031CD30
		public int AnimNameListLength
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

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600D83E RID: 55358 RVA: 0x0031EB5C File Offset: 0x0031CD5C
		public string LeftSpineAtlas
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

		// Token: 0x0600D83F RID: 55359 RVA: 0x0031EB94 File Offset: 0x0031CD94
		public Span<byte> GetLeftSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D840 RID: 55360 RVA: 0x0031EBA4 File Offset: 0x0031CDA4
		public byte[] GetLeftSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600D841 RID: 55361 RVA: 0x0031EBBC File Offset: 0x0031CDBC
		public string LeftSpineSkeletonData
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

		// Token: 0x0600D842 RID: 55362 RVA: 0x0031EBF4 File Offset: 0x0031CDF4
		public Span<byte> GetLeftSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x0031EC04 File Offset: 0x0031CE04
		public byte[] GetLeftSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600D844 RID: 55364 RVA: 0x0031EC1C File Offset: 0x0031CE1C
		public string RightSpineAtlas
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

		// Token: 0x0600D845 RID: 55365 RVA: 0x0031EC54 File Offset: 0x0031CE54
		public Span<byte> GetRightSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x0031EC64 File Offset: 0x0031CE64
		public byte[] GetRightSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600D847 RID: 55367 RVA: 0x0031EC7C File Offset: 0x0031CE7C
		public string RightSpineSkeletonData
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

		// Token: 0x0600D848 RID: 55368 RVA: 0x0031ECB4 File Offset: 0x0031CEB4
		public Span<byte> GetRightSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x0031ECC4 File Offset: 0x0031CEC4
		public byte[] GetRightSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D84A RID: 55370 RVA: 0x0031ECDC File Offset: 0x0031CEDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimNameListIter()或GetAnimNameListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimNameList()
		{
			return this.AnimNameListIter().ToArray<string>();
		}

		// Token: 0x0600D84B RID: 55371 RVA: 0x0031ECE9 File Offset: 0x0031CEE9
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimNameListIter()
		{
			SpringChat.<AnimNameListIter>d__38 <AnimNameListIter>d__ = new SpringChat.<AnimNameListIter>d__38(-2);
			<AnimNameListIter>d__.<>3__<>4__this = this;
			return <AnimNameListIter>d__;
		}

		// Token: 0x0600D84C RID: 55372 RVA: 0x0031ECFE File Offset: 0x0031CEFE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ContentListIter()或GetContentListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ContentList()
		{
			return this.ContentListIter().ToArray<string>();
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x0031ED0B File Offset: 0x0031CF0B
		[NullableContext(1)]
		public readonly IEnumerable<string> ContentListIter()
		{
			SpringChat.<ContentListIter>d__40 <ContentListIter>d__ = new SpringChat.<ContentListIter>d__40(-2);
			<ContentListIter>d__.<>3__<>4__this = this;
			return <ContentListIter>d__;
		}

		// Token: 0x0600D84E RID: 55374 RVA: 0x0031ED20 File Offset: 0x0031CF20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PosListIter()或GetPosListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PosList()
		{
			SpringChat springChat = this;
			return springChat.GetPosListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D84F RID: 55375 RVA: 0x0031ED44 File Offset: 0x0031CF44
		[NullableContext(1)]
		public readonly IEnumerable<int> PosListIter()
		{
			SpringChat.<PosListIter>d__42 <PosListIter>d__ = new SpringChat.<PosListIter>d__42(-2);
			<PosListIter>d__.<>3__<>4__this = this;
			return <PosListIter>d__;
		}

		// Token: 0x04005217 RID: 21015
		private Table __p;
	}
}
