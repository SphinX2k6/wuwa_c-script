using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E81 RID: 3713
	public struct NewbieCourseV2 : IFlatbufferObject
	{
		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x0029BFE4 File Offset: 0x0029A1E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x0029BFF1 File Offset: 0x0029A1F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x0029BFF8 File Offset: 0x0029A1F8
		public static NewbieCourseV2 GetRootAsNewbieCourseV2(ByteBuffer _bb)
		{
			return NewbieCourseV2.GetRootAsNewbieCourseV2(_bb, default(NewbieCourseV2));
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x0029C014 File Offset: 0x0029A214
		public static NewbieCourseV2 GetRootAsNewbieCourseV2(ByteBuffer _bb, NewbieCourseV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x0029C031 File Offset: 0x0029A231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x0029C040 File Offset: 0x0029A240
		public NewbieCourseV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06009E5F RID: 40543 RVA: 0x0029C050 File Offset: 0x0029A250
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

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06009E60 RID: 40544 RVA: 0x0029C08C File Offset: 0x0029A28C
		public int ActivityId
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

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06009E61 RID: 40545 RVA: 0x0029C0C8 File Offset: 0x0029A2C8
		public int TargetLevel
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

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06009E62 RID: 40546 RVA: 0x0029C104 File Offset: 0x0029A304
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x0029C144 File Offset: 0x0029A344
		public int WeaponPreviewList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06009E64 RID: 40548 RVA: 0x0029C184 File Offset: 0x0029A384
		public int WeaponPreviewListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x0029C1B0 File Offset: 0x0029A3B0
		public Span<int> GetWeaponPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x0029C1C0 File Offset: 0x0029A3C0
		public int[] GetWeaponPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x0029C1D8 File Offset: 0x0029A3D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponPreviewListIter()或GetWeaponPreviewListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponPreviewList()
		{
			NewbieCourseV2 newbieCourseV = this;
			return newbieCourseV.GetWeaponPreviewListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x0029C1FC File Offset: 0x0029A3FC
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponPreviewListIter()
		{
			NewbieCourseV2.<WeaponPreviewListIter>d__22 <WeaponPreviewListIter>d__ = new NewbieCourseV2.<WeaponPreviewListIter>d__22(-2);
			<WeaponPreviewListIter>d__.<>3__<>4__this = this;
			return <WeaponPreviewListIter>d__;
		}

		// Token: 0x04004F2F RID: 20271
		private Table __p;
	}
}
