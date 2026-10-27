using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8D RID: 3213
	public struct FishingTech : IFlatbufferObject
	{
		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x00234279 File Offset: 0x00232479
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00234286 File Offset: 0x00232486
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x00234290 File Offset: 0x00232490
		public static FishingTech GetRootAsFishingTech(ByteBuffer _bb)
		{
			return FishingTech.GetRootAsFishingTech(_bb, default(FishingTech));
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x002342AC File Offset: 0x002324AC
		public static FishingTech GetRootAsFishingTech(ByteBuffer _bb, FishingTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x002342C9 File Offset: 0x002324C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x002342D8 File Offset: 0x002324D8
		public FishingTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x002342E8 File Offset: 0x002324E8
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600709A RID: 28826 RVA: 0x00234324 File Offset: 0x00232524
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

		// Token: 0x0600709B RID: 28827 RVA: 0x0023435B File Offset: 0x0023255B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0023436A File Offset: 0x0023256A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600709D RID: 28829 RVA: 0x00234384 File Offset: 0x00232584
		public int Type
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

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600709E RID: 28830 RVA: 0x002343C0 File Offset: 0x002325C0
		public int TreeLevel
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600709F RID: 28831 RVA: 0x00234400 File Offset: 0x00232600
		public int Area
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060070A0 RID: 28832 RVA: 0x00234440 File Offset: 0x00232640
		public int IndexId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060070A1 RID: 28833 RVA: 0x00234480 File Offset: 0x00232680
		public int PreNode
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060070A2 RID: 28834 RVA: 0x002344C0 File Offset: 0x002326C0
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x00234500 File Offset: 0x00232700
		public int Effect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x00234540 File Offset: 0x00232740
		public int EffectLength
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

		// Token: 0x060070A5 RID: 28837 RVA: 0x0023456C File Offset: 0x0023276C
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x0023457C File Offset: 0x0023277C
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x00234594 File Offset: 0x00232794
		public string Icon
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

		// Token: 0x060070A8 RID: 28840 RVA: 0x002345CC File Offset: 0x002327CC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x002345DC File Offset: 0x002327DC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x002345F4 File Offset: 0x002327F4
		public string TagName
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x0023462C File Offset: 0x0023282C
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x0023463C File Offset: 0x0023283C
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00234654 File Offset: 0x00232854
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effect()
		{
			FishingTech fishingTech = this;
			return fishingTech.GetEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x00234678 File Offset: 0x00232878
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIter()
		{
			FishingTech.<EffectIter>d__40 <EffectIter>d__ = new FishingTech.<EffectIter>d__40(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x04004CE2 RID: 19682
		private Table __p;
	}
}
