using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2B RID: 3627
	public struct MoralePlay : IFlatbufferObject
	{
		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06009667 RID: 38503 RVA: 0x0028A525 File Offset: 0x00288725
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x0028A532 File Offset: 0x00288732
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x0028A53C File Offset: 0x0028873C
		public static MoralePlay GetRootAsMoralePlay(ByteBuffer _bb)
		{
			return MoralePlay.GetRootAsMoralePlay(_bb, default(MoralePlay));
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x0028A558 File Offset: 0x00288758
		public static MoralePlay GetRootAsMoralePlay(ByteBuffer _bb, MoralePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x0028A575 File Offset: 0x00288775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x0028A584 File Offset: 0x00288784
		public MoralePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x0600966D RID: 38509 RVA: 0x0028A594 File Offset: 0x00288794
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

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x0600966E RID: 38510 RVA: 0x0028A5D0 File Offset: 0x002887D0
		public int BattleScoreId
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

		// Token: 0x0600966F RID: 38511 RVA: 0x0028A60C File Offset: 0x0028880C
		public int ExpItemId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06009670 RID: 38512 RVA: 0x0028A64C File Offset: 0x0028884C
		public int ExpItemIdLength
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

		// Token: 0x06009671 RID: 38513 RVA: 0x0028A677 File Offset: 0x00288877
		public Span<int> GetExpItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x0028A686 File Offset: 0x00288886
		public int[] GetExpItemIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009673 RID: 38515 RVA: 0x0028A6A0 File Offset: 0x002888A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExpItemIdIter()或GetExpItemIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExpItemId()
		{
			MoralePlay moralePlay = this;
			return moralePlay.GetExpItemIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x0028A6C4 File Offset: 0x002888C4
		[NullableContext(1)]
		public readonly IEnumerable<int> ExpItemIdIter()
		{
			MoralePlay.<ExpItemIdIter>d__18 <ExpItemIdIter>d__ = new MoralePlay.<ExpItemIdIter>d__18(-2);
			<ExpItemIdIter>d__.<>3__<>4__this = this;
			return <ExpItemIdIter>d__;
		}

		// Token: 0x04004ED0 RID: 20176
		private Table __p;
	}
}
