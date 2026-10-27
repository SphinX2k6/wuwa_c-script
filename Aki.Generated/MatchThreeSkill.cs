using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E03 RID: 3587
	public struct MatchThreeSkill : IFlatbufferObject
	{
		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x002834D5 File Offset: 0x002816D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009332 RID: 37682 RVA: 0x002834E2 File Offset: 0x002816E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x002834EC File Offset: 0x002816EC
		public static MatchThreeSkill GetRootAsMatchThreeSkill(ByteBuffer _bb)
		{
			return MatchThreeSkill.GetRootAsMatchThreeSkill(_bb, default(MatchThreeSkill));
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x00283508 File Offset: 0x00281708
		public static MatchThreeSkill GetRootAsMatchThreeSkill(ByteBuffer _bb, MatchThreeSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x00283525 File Offset: 0x00281725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00283534 File Offset: 0x00281734
		public MatchThreeSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06009337 RID: 37687 RVA: 0x00283544 File Offset: 0x00281744
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

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x00283580 File Offset: 0x00281780
		public int Type
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

		// Token: 0x06009339 RID: 37689 RVA: 0x002835BC File Offset: 0x002817BC
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600933A RID: 37690 RVA: 0x002835FC File Offset: 0x002817FC
		public int ParamsLength
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

		// Token: 0x0600933B RID: 37691 RVA: 0x00283627 File Offset: 0x00281827
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x00283636 File Offset: 0x00281836
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x00283650 File Offset: 0x00281850
		public int ExtraParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600933E RID: 37694 RVA: 0x00283690 File Offset: 0x00281890
		public int ExtraParamsLength
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

		// Token: 0x0600933F RID: 37695 RVA: 0x002836BC File Offset: 0x002818BC
		public Span<int> GetExtraParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x002836CC File Offset: 0x002818CC
		public int[] GetExtraParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x002836E4 File Offset: 0x002818E4
		public int Energy
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x00283724 File Offset: 0x00281924
		public string Name
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

		// Token: 0x06009343 RID: 37699 RVA: 0x0028375C File Offset: 0x0028195C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x0028376C File Offset: 0x0028196C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x00283784 File Offset: 0x00281984
		public string Desc
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

		// Token: 0x06009346 RID: 37702 RVA: 0x002837BC File Offset: 0x002819BC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x002837CC File Offset: 0x002819CC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06009348 RID: 37704 RVA: 0x002837E4 File Offset: 0x002819E4
		public string Icon
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

		// Token: 0x06009349 RID: 37705 RVA: 0x0028381C File Offset: 0x00281A1C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x0028382C File Offset: 0x00281A2C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600934B RID: 37707 RVA: 0x00283844 File Offset: 0x00281A44
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraParamsIter()或GetExtraParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraParams()
		{
			MatchThreeSkill matchThreeSkill = this;
			return matchThreeSkill.GetExtraParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600934C RID: 37708 RVA: 0x00283868 File Offset: 0x00281A68
		[NullableContext(1)]
		public readonly IEnumerable<int> ExtraParamsIter()
		{
			MatchThreeSkill.<ExtraParamsIter>d__37 <ExtraParamsIter>d__ = new MatchThreeSkill.<ExtraParamsIter>d__37(-2);
			<ExtraParamsIter>d__.<>3__<>4__this = this;
			return <ExtraParamsIter>d__;
		}

		// Token: 0x0600934D RID: 37709 RVA: 0x00283880 File Offset: 0x00281A80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			MatchThreeSkill matchThreeSkill = this;
			return matchThreeSkill.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x002838A4 File Offset: 0x00281AA4
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			MatchThreeSkill.<ParamsIter>d__39 <ParamsIter>d__ = new MatchThreeSkill.<ParamsIter>d__39(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004EA4 RID: 20132
		private Table __p;
	}
}
