using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEF RID: 3823
	public struct PhantomMainProperty : IFlatbufferObject
	{
		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600A97F RID: 43391 RVA: 0x002B530D File Offset: 0x002B350D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x002B531A File Offset: 0x002B351A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x002B5324 File Offset: 0x002B3524
		public static PhantomMainProperty GetRootAsPhantomMainProperty(ByteBuffer _bb)
		{
			return PhantomMainProperty.GetRootAsPhantomMainProperty(_bb, default(PhantomMainProperty));
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x002B5340 File Offset: 0x002B3540
		public static PhantomMainProperty GetRootAsPhantomMainProperty(ByteBuffer _bb, PhantomMainProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x002B535D File Offset: 0x002B355D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x002B536C File Offset: 0x002B356C
		public PhantomMainProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600A985 RID: 43397 RVA: 0x002B537C File Offset: 0x002B357C
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

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600A986 RID: 43398 RVA: 0x002B53B8 File Offset: 0x002B35B8
		public int RandGroupId
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

		// Token: 0x0600A987 RID: 43399 RVA: 0x002B53F4 File Offset: 0x002B35F4
		public int PropGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600A988 RID: 43400 RVA: 0x002B5434 File Offset: 0x002B3634
		public int PropGroupLength
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

		// Token: 0x0600A989 RID: 43401 RVA: 0x002B545F File Offset: 0x002B365F
		public Span<int> GetPropGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x002B546E File Offset: 0x002B366E
		public int[] GetPropGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x002B5488 File Offset: 0x002B3688
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropGroupIter()或GetPropGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropGroup()
		{
			PhantomMainProperty phantomMainProperty = this;
			return phantomMainProperty.GetPropGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x002B54AC File Offset: 0x002B36AC
		[NullableContext(1)]
		public readonly IEnumerable<int> PropGroupIter()
		{
			PhantomMainProperty.<PropGroupIter>d__18 <PropGroupIter>d__ = new PhantomMainProperty.<PropGroupIter>d__18(-2);
			<PropGroupIter>d__.<>3__<>4__this = this;
			return <PropGroupIter>d__;
		}

		// Token: 0x04004FB1 RID: 20401
		private Table __p;
	}
}
