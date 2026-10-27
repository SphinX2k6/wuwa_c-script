using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5A RID: 3930
	public struct PreviewItem : IFlatbufferObject
	{
		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600B354 RID: 45908 RVA: 0x002CB49D File Offset: 0x002C969D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x002CB4AA File Offset: 0x002C96AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x002CB4B4 File Offset: 0x002C96B4
		public static PreviewItem GetRootAsPreviewItem(ByteBuffer _bb)
		{
			return PreviewItem.GetRootAsPreviewItem(_bb, default(PreviewItem));
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x002CB4D0 File Offset: 0x002C96D0
		public static PreviewItem GetRootAsPreviewItem(ByteBuffer _bb, PreviewItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x002CB4ED File Offset: 0x002C96ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x002CB4FC File Offset: 0x002C96FC
		public PreviewItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x002CB50C File Offset: 0x002C970C
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

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600B35B RID: 45915 RVA: 0x002CB548 File Offset: 0x002C9748
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

		// Token: 0x0600B35C RID: 45916 RVA: 0x002CB57F File Offset: 0x002C977F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x002CB58E File Offset: 0x002C978E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x002CB5A8 File Offset: 0x002C97A8
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600B35F RID: 45919 RVA: 0x002CB5E8 File Offset: 0x002C97E8
		public int ShowTypesLength
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

		// Token: 0x0600B360 RID: 45920 RVA: 0x002CB613 File Offset: 0x002C9813
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x002CB622 File Offset: 0x002C9822
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x002CB63C File Offset: 0x002C983C
		public string AttributesDescription
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

		// Token: 0x0600B363 RID: 45923 RVA: 0x002CB674 File Offset: 0x002C9874
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x002CB684 File Offset: 0x002C9884
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600B365 RID: 45925 RVA: 0x002CB69C File Offset: 0x002C989C
		public string BgDescription
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

		// Token: 0x0600B366 RID: 45926 RVA: 0x002CB6D4 File Offset: 0x002C98D4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x002CB6E4 File Offset: 0x002C98E4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x002CB6FC File Offset: 0x002C98FC
		public string IconBig
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

		// Token: 0x0600B369 RID: 45929 RVA: 0x002CB734 File Offset: 0x002C9934
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x002CB744 File Offset: 0x002C9944
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600B36B RID: 45931 RVA: 0x002CB75C File Offset: 0x002C995C
		public string Icon
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

		// Token: 0x0600B36C RID: 45932 RVA: 0x002CB794 File Offset: 0x002C9994
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x002CB7A4 File Offset: 0x002C99A4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x002CB7BC File Offset: 0x002C99BC
		public string IconMiddle
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

		// Token: 0x0600B36F RID: 45935 RVA: 0x002CB7F4 File Offset: 0x002C99F4
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x002CB804 File Offset: 0x002C9A04
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600B371 RID: 45937 RVA: 0x002CB81C File Offset: 0x002C9A1C
		public string IconSmall
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

		// Token: 0x0600B372 RID: 45938 RVA: 0x002CB854 File Offset: 0x002C9A54
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x002CB864 File Offset: 0x002C9A64
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600B374 RID: 45940 RVA: 0x002CB87C File Offset: 0x002C9A7C
		public string PreviewCornerMarker
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

		// Token: 0x0600B375 RID: 45941 RVA: 0x002CB8B4 File Offset: 0x002C9AB4
		public Span<byte> GetPreviewCornerMarkerBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x002CB8C4 File Offset: 0x002C9AC4
		public byte[] GetPreviewCornerMarkerArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600B377 RID: 45943 RVA: 0x002CB8DC File Offset: 0x002C9ADC
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x002CB91C File Offset: 0x002C9B1C
		public int PreviewItemAccess(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600B379 RID: 45945 RVA: 0x002CB95C File Offset: 0x002C9B5C
		public int PreviewItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x002CB988 File Offset: 0x002C9B88
		public Span<int> GetPreviewItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x002CB998 File Offset: 0x002C9B98
		public int[] GetPreviewItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x002CB9B0 File Offset: 0x002C9BB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreviewItemAccessIter()或GetPreviewItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreviewItemAccess()
		{
			PreviewItem previewItem = this;
			return previewItem.GetPreviewItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x002CB9D4 File Offset: 0x002C9BD4
		[NullableContext(1)]
		public readonly IEnumerable<int> PreviewItemAccessIter()
		{
			PreviewItem.<PreviewItemAccessIter>d__55 <PreviewItemAccessIter>d__ = new PreviewItem.<PreviewItemAccessIter>d__55(-2);
			<PreviewItemAccessIter>d__.<>3__<>4__this = this;
			return <PreviewItemAccessIter>d__;
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x002CB9EC File Offset: 0x002C9BEC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowTypesIter()或GetShowTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowTypes()
		{
			PreviewItem previewItem = this;
			return previewItem.GetShowTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x002CBA10 File Offset: 0x002C9C10
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowTypesIter()
		{
			PreviewItem.<ShowTypesIter>d__57 <ShowTypesIter>d__ = new PreviewItem.<ShowTypesIter>d__57(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x04005027 RID: 20519
		private Table __p;
	}
}
