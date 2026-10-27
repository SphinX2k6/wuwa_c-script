using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D16 RID: 3350
	public struct GuideDungeonSetDefine : IFlatbufferObject
	{
		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x0024F8A9 File Offset: 0x0024DAA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x0024F8B6 File Offset: 0x0024DAB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x0024F8C0 File Offset: 0x0024DAC0
		public static GuideDungeonSetDefine GetRootAsGuideDungeonSetDefine(ByteBuffer _bb)
		{
			return GuideDungeonSetDefine.GetRootAsGuideDungeonSetDefine(_bb, default(GuideDungeonSetDefine));
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x0024F8DC File Offset: 0x0024DADC
		public static GuideDungeonSetDefine GetRootAsGuideDungeonSetDefine(ByteBuffer _bb, GuideDungeonSetDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x0024F8F9 File Offset: 0x0024DAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x0024F908 File Offset: 0x0024DB08
		public GuideDungeonSetDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x0024F918 File Offset: 0x0024DB18
		public string StrId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x0024F94F File Offset: 0x0024DB4F
		public Span<byte> GetStrIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007C7B RID: 31867 RVA: 0x0024F95E File Offset: 0x0024DB5E
		public byte[] GetStrIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x0024F978 File Offset: 0x0024DB78
		public int DungeonIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x0024F9B8 File Offset: 0x0024DBB8
		public int DungeonIdListLength
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

		// Token: 0x06007C7E RID: 31870 RVA: 0x0024F9E3 File Offset: 0x0024DBE3
		public Span<int> GetDungeonIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x0024F9F2 File Offset: 0x0024DBF2
		public int[] GetDungeonIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x0024FA0C File Offset: 0x0024DC0C
		public int DungeonTypeSetList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x0024FA4C File Offset: 0x0024DC4C
		public int DungeonTypeSetListLength
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

		// Token: 0x06007C82 RID: 31874 RVA: 0x0024FA77 File Offset: 0x0024DC77
		public Span<int> GetDungeonTypeSetListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x0024FA86 File Offset: 0x0024DC86
		public int[] GetDungeonTypeSetListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x0024FAA0 File Offset: 0x0024DCA0
		public int ExcludeIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06007C85 RID: 31877 RVA: 0x0024FAE0 File Offset: 0x0024DCE0
		public int ExcludeIdListLength
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

		// Token: 0x06007C86 RID: 31878 RVA: 0x0024FB0C File Offset: 0x0024DD0C
		public Span<int> GetExcludeIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x0024FB1C File Offset: 0x0024DD1C
		public int[] GetExcludeIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0024FB34 File Offset: 0x0024DD34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonIdListIter()或GetDungeonIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonIdList()
		{
			GuideDungeonSetDefine guideDungeonSetDefine = this;
			return guideDungeonSetDefine.GetDungeonIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x0024FB58 File Offset: 0x0024DD58
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonIdListIter()
		{
			GuideDungeonSetDefine.<DungeonIdListIter>d__28 <DungeonIdListIter>d__ = new GuideDungeonSetDefine.<DungeonIdListIter>d__28(-2);
			<DungeonIdListIter>d__.<>3__<>4__this = this;
			return <DungeonIdListIter>d__;
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x0024FB70 File Offset: 0x0024DD70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonTypeSetListIter()或GetDungeonTypeSetListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonTypeSetList()
		{
			GuideDungeonSetDefine guideDungeonSetDefine = this;
			return guideDungeonSetDefine.GetDungeonTypeSetListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x0024FB94 File Offset: 0x0024DD94
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonTypeSetListIter()
		{
			GuideDungeonSetDefine.<DungeonTypeSetListIter>d__30 <DungeonTypeSetListIter>d__ = new GuideDungeonSetDefine.<DungeonTypeSetListIter>d__30(-2);
			<DungeonTypeSetListIter>d__.<>3__<>4__this = this;
			return <DungeonTypeSetListIter>d__;
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x0024FBAC File Offset: 0x0024DDAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExcludeIdListIter()或GetExcludeIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExcludeIdList()
		{
			GuideDungeonSetDefine guideDungeonSetDefine = this;
			return guideDungeonSetDefine.GetExcludeIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0024FBD0 File Offset: 0x0024DDD0
		[NullableContext(1)]
		public readonly IEnumerable<int> ExcludeIdListIter()
		{
			GuideDungeonSetDefine.<ExcludeIdListIter>d__32 <ExcludeIdListIter>d__ = new GuideDungeonSetDefine.<ExcludeIdListIter>d__32(-2);
			<ExcludeIdListIter>d__.<>3__<>4__this = this;
			return <ExcludeIdListIter>d__;
		}

		// Token: 0x04004D8E RID: 19854
		private Table __p;
	}
}
