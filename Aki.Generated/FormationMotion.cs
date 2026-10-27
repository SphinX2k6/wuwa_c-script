using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCD RID: 3277
	public struct FormationMotion : IFlatbufferObject
	{
		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x002425C9 File Offset: 0x002407C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x002425D6 File Offset: 0x002407D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x002425E0 File Offset: 0x002407E0
		public static FormationMotion GetRootAsFormationMotion(ByteBuffer _bb)
		{
			return FormationMotion.GetRootAsFormationMotion(_bb, default(FormationMotion));
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x002425FC File Offset: 0x002407FC
		public static FormationMotion GetRootAsFormationMotion(ByteBuffer _bb, FormationMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00242619 File Offset: 0x00240819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00242628 File Offset: 0x00240828
		public FormationMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x00242638 File Offset: 0x00240838
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

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x00242674 File Offset: 0x00240874
		public int RoleId
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

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06007692 RID: 30354 RVA: 0x002426B0 File Offset: 0x002408B0
		public int SkinId
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

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x002426EC File Offset: 0x002408EC
		public int Position
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

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06007694 RID: 30356 RVA: 0x0024272C File Offset: 0x0024092C
		public Vector? FocusPos
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x0024278C File Offset: 0x0024098C
		public Vector? Offset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06007696 RID: 30358 RVA: 0x002427EC File Offset: 0x002409EC
		public Vector? OffsetRotation
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x0024284C File Offset: 0x00240A4C
		public int OffsetTopUI(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06007698 RID: 30360 RVA: 0x0024288C File Offset: 0x00240A8C
		public int OffsetTopUILength
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

		// Token: 0x06007699 RID: 30361 RVA: 0x002428B8 File Offset: 0x00240AB8
		public Span<int> GetOffsetTopUIBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x002428C8 File Offset: 0x00240AC8
		public int[] GetOffsetTopUIArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x002428E0 File Offset: 0x00240AE0
		public int OffsetBottomUI(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x00242920 File Offset: 0x00240B20
		public int OffsetBottomUILength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x0024294C File Offset: 0x00240B4C
		public Span<int> GetOffsetBottomUIBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x0024295C File Offset: 0x00240B5C
		public int[] GetOffsetBottomUIArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00242974 File Offset: 0x00240B74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OffsetBottomUIIter()或GetOffsetBottomUIBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OffsetBottomUI()
		{
			FormationMotion formationMotion = this;
			return formationMotion.GetOffsetBottomUIArray() ?? Array.Empty<int>();
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00242998 File Offset: 0x00240B98
		[NullableContext(1)]
		public readonly IEnumerable<int> OffsetBottomUIIter()
		{
			FormationMotion.<OffsetBottomUIIter>d__33 <OffsetBottomUIIter>d__ = new FormationMotion.<OffsetBottomUIIter>d__33(-2);
			<OffsetBottomUIIter>d__.<>3__<>4__this = this;
			return <OffsetBottomUIIter>d__;
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x002429B0 File Offset: 0x00240BB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OffsetTopUIIter()或GetOffsetTopUIBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OffsetTopUI()
		{
			FormationMotion formationMotion = this;
			return formationMotion.GetOffsetTopUIArray() ?? Array.Empty<int>();
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x002429D4 File Offset: 0x00240BD4
		[NullableContext(1)]
		public readonly IEnumerable<int> OffsetTopUIIter()
		{
			FormationMotion.<OffsetTopUIIter>d__35 <OffsetTopUIIter>d__ = new FormationMotion.<OffsetTopUIIter>d__35(-2);
			<OffsetTopUIIter>d__.<>3__<>4__this = this;
			return <OffsetTopUIIter>d__;
		}

		// Token: 0x04004D3D RID: 19773
		private Table __p;
	}
}
