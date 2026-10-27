using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C87 RID: 3207
	public struct FishingPosition : IFlatbufferObject
	{
		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x00232CE9 File Offset: 0x00230EE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x00232CF6 File Offset: 0x00230EF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00232D00 File Offset: 0x00230F00
		public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb)
		{
			return FishingPosition.GetRootAsFishingPosition(_bb, default(FishingPosition));
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00232D1C File Offset: 0x00230F1C
		public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb, FishingPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00232D39 File Offset: 0x00230F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00232D48 File Offset: 0x00230F48
		public FishingPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x00232D58 File Offset: 0x00230F58
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

		// Token: 0x06007007 RID: 28679 RVA: 0x00232D94 File Offset: 0x00230F94
		public int Position(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x00232DD4 File Offset: 0x00230FD4
		public int PositionLength
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

		// Token: 0x06007009 RID: 28681 RVA: 0x00232DFF File Offset: 0x00230FFF
		public Span<int> GetPositionBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x00232E0E File Offset: 0x0023100E
		public int[] GetPositionArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x00232E28 File Offset: 0x00231028
		public int Rotation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x00232E68 File Offset: 0x00231068
		public int RotationLength
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

		// Token: 0x0600700D RID: 28685 RVA: 0x00232E93 File Offset: 0x00231093
		public Span<int> GetRotationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00232EA2 File Offset: 0x002310A2
		public int[] GetRotationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00232EBC File Offset: 0x002310BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionIter()或GetPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Position()
		{
			FishingPosition fishingPosition = this;
			return fishingPosition.GetPositionArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x00232EE0 File Offset: 0x002310E0
		[NullableContext(1)]
		public readonly IEnumerable<int> PositionIter()
		{
			FishingPosition.<PositionIter>d__21 <PositionIter>d__ = new FishingPosition.<PositionIter>d__21(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00232EF8 File Offset: 0x002310F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotationIter()或GetRotationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Rotation()
		{
			FishingPosition fishingPosition = this;
			return fishingPosition.GetRotationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00232F1C File Offset: 0x0023111C
		[NullableContext(1)]
		public readonly IEnumerable<int> RotationIter()
		{
			FishingPosition.<RotationIter>d__23 <RotationIter>d__ = new FishingPosition.<RotationIter>d__23(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x04004CD9 RID: 19673
		private Table __p;
	}
}
