using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103F RID: 4159
	public struct PreviewItem : IFlatbufferObject
	{
		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x002E7CCD File Offset: 0x002E5ECD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x002E7CDA File Offset: 0x002E5EDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x002E7CE4 File Offset: 0x002E5EE4
		public static PreviewItem GetRootAsPreviewItem(ByteBuffer _bb)
		{
			return PreviewItem.GetRootAsPreviewItem(_bb, default(PreviewItem));
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x002E7D00 File Offset: 0x002E5F00
		public static PreviewItem GetRootAsPreviewItem(ByteBuffer _bb, PreviewItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x002E7D1D File Offset: 0x002E5F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x002E7D2C File Offset: 0x002E5F2C
		public PreviewItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x002E7D3C File Offset: 0x002E5F3C
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

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0600B97C RID: 47484 RVA: 0x002E7D78 File Offset: 0x002E5F78
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

		// Token: 0x0600B97D RID: 47485 RVA: 0x002E7DAF File Offset: 0x002E5FAF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x002E7DBE File Offset: 0x002E5FBE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x002E7DD8 File Offset: 0x002E5FD8
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x002E7E18 File Offset: 0x002E6018
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

		// Token: 0x0600B981 RID: 47489 RVA: 0x002E7E43 File Offset: 0x002E6043
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x002E7E52 File Offset: 0x002E6052
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0600B983 RID: 47491 RVA: 0x002E7E6C File Offset: 0x002E606C
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

		// Token: 0x0600B984 RID: 47492 RVA: 0x002E7EA4 File Offset: 0x002E60A4
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x002E7EB4 File Offset: 0x002E60B4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x002E7ECC File Offset: 0x002E60CC
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

		// Token: 0x0600B987 RID: 47495 RVA: 0x002E7F04 File Offset: 0x002E6104
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x002E7F14 File Offset: 0x002E6114
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x002E7F2C File Offset: 0x002E612C
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

		// Token: 0x0600B98A RID: 47498 RVA: 0x002E7F64 File Offset: 0x002E6164
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x002E7F74 File Offset: 0x002E6174
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600B98C RID: 47500 RVA: 0x002E7F8C File Offset: 0x002E618C
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

		// Token: 0x0600B98D RID: 47501 RVA: 0x002E7FC4 File Offset: 0x002E61C4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x002E7FD4 File Offset: 0x002E61D4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600B98F RID: 47503 RVA: 0x002E7FEC File Offset: 0x002E61EC
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

		// Token: 0x0600B990 RID: 47504 RVA: 0x002E8024 File Offset: 0x002E6224
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x002E8034 File Offset: 0x002E6234
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600B992 RID: 47506 RVA: 0x002E804C File Offset: 0x002E624C
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

		// Token: 0x0600B993 RID: 47507 RVA: 0x002E8084 File Offset: 0x002E6284
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x002E8094 File Offset: 0x002E6294
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x002E80AC File Offset: 0x002E62AC
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

		// Token: 0x0600B996 RID: 47510 RVA: 0x002E80E4 File Offset: 0x002E62E4
		public Span<byte> GetPreviewCornerMarkerBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x002E80F4 File Offset: 0x002E62F4
		public byte[] GetPreviewCornerMarkerArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0600B998 RID: 47512 RVA: 0x002E810C File Offset: 0x002E630C
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

		// Token: 0x0600B999 RID: 47513 RVA: 0x002E814C File Offset: 0x002E634C
		public int PreviewItemAccess(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600B99A RID: 47514 RVA: 0x002E818C File Offset: 0x002E638C
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

		// Token: 0x0600B99B RID: 47515 RVA: 0x002E81B8 File Offset: 0x002E63B8
		public Span<int> GetPreviewItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x002E81C8 File Offset: 0x002E63C8
		public int[] GetPreviewItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x002E81E0 File Offset: 0x002E63E0
		[NullableContext(1)]
		public int[] PreviewItemAccess()
		{
			return this.GetPreviewItemAccessArray();
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x002E81E8 File Offset: 0x002E63E8
		[NullableContext(1)]
		public IEnumerable<int> PreviewItemAccessIter()
		{
			PreviewItem.<PreviewItemAccessIter>d__55 <PreviewItemAccessIter>d__ = new PreviewItem.<PreviewItemAccessIter>d__55(-2);
			<PreviewItemAccessIter>d__.<>3__<>4__this = this;
			return <PreviewItemAccessIter>d__;
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x002E81FD File Offset: 0x002E63FD
		[NullableContext(1)]
		public int[] ShowTypes()
		{
			return this.GetShowTypesArray();
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x002E8205 File Offset: 0x002E6405
		[NullableContext(1)]
		public IEnumerable<int> ShowTypesIter()
		{
			PreviewItem.<ShowTypesIter>d__57 <ShowTypesIter>d__ = new PreviewItem.<ShowTypesIter>d__57(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x0400560C RID: 22028
		private Table __p;
	}
}
