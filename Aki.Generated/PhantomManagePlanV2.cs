using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF2 RID: 3826
	public struct PhantomManagePlanV2 : IFlatbufferObject
	{
		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600A9AC RID: 43436 RVA: 0x002B59C8 File Offset: 0x002B3BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x002B59D5 File Offset: 0x002B3BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x002B59DC File Offset: 0x002B3BDC
		public static PhantomManagePlanV2 GetRootAsPhantomManagePlanV2(ByteBuffer _bb)
		{
			return PhantomManagePlanV2.GetRootAsPhantomManagePlanV2(_bb, default(PhantomManagePlanV2));
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x002B59F8 File Offset: 0x002B3BF8
		public static PhantomManagePlanV2 GetRootAsPhantomManagePlanV2(ByteBuffer _bb, PhantomManagePlanV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x002B5A15 File Offset: 0x002B3C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x002B5A24 File Offset: 0x002B3C24
		public PhantomManagePlanV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600A9B2 RID: 43442 RVA: 0x002B5A34 File Offset: 0x002B3C34
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

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x002B5A70 File Offset: 0x002B3C70
		public int FetterId
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

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600A9B4 RID: 43444 RVA: 0x002B5AAC File Offset: 0x002B3CAC
		public int Cost
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

		// Token: 0x0600A9B5 RID: 43445 RVA: 0x002B5AE8 File Offset: 0x002B3CE8
		public int LockGroup(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x0600A9B6 RID: 43446 RVA: 0x002B5B28 File Offset: 0x002B3D28
		public int LockGroupLength
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

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x002B5B54 File Offset: 0x002B3D54
		public Span<int> GetLockGroupBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A9B8 RID: 43448 RVA: 0x002B5B64 File Offset: 0x002B3D64
		public int[] GetLockGroupArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600A9B9 RID: 43449 RVA: 0x002B5B7C File Offset: 0x002B3D7C
		public int DiscardGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600A9BA RID: 43450 RVA: 0x002B5BBC File Offset: 0x002B3DBC
		public int DiscardGroupLength
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

		// Token: 0x0600A9BB RID: 43451 RVA: 0x002B5BE8 File Offset: 0x002B3DE8
		public Span<int> GetDiscardGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A9BC RID: 43452 RVA: 0x002B5BF8 File Offset: 0x002B3DF8
		public int[] GetDiscardGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600A9BD RID: 43453 RVA: 0x002B5C10 File Offset: 0x002B3E10
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DiscardGroupIter()或GetDiscardGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DiscardGroup()
		{
			PhantomManagePlanV2 phantomManagePlanV = this;
			return phantomManagePlanV.GetDiscardGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x002B5C34 File Offset: 0x002B3E34
		[NullableContext(1)]
		public readonly IEnumerable<int> DiscardGroupIter()
		{
			PhantomManagePlanV2.<DiscardGroupIter>d__25 <DiscardGroupIter>d__ = new PhantomManagePlanV2.<DiscardGroupIter>d__25(-2);
			<DiscardGroupIter>d__.<>3__<>4__this = this;
			return <DiscardGroupIter>d__;
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x002B5C4C File Offset: 0x002B3E4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LockGroupIter()或GetLockGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LockGroup()
		{
			PhantomManagePlanV2 phantomManagePlanV = this;
			return phantomManagePlanV.GetLockGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x002B5C70 File Offset: 0x002B3E70
		[NullableContext(1)]
		public readonly IEnumerable<int> LockGroupIter()
		{
			PhantomManagePlanV2.<LockGroupIter>d__27 <LockGroupIter>d__ = new PhantomManagePlanV2.<LockGroupIter>d__27(-2);
			<LockGroupIter>d__.<>3__<>4__this = this;
			return <LockGroupIter>d__;
		}

		// Token: 0x04004FB5 RID: 20405
		private Table __p;
	}
}
