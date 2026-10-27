using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDE RID: 3038
	public struct DangoSkill : IFlatbufferObject
	{
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x00210414 File Offset: 0x0020E614
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00210421 File Offset: 0x0020E621
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00210428 File Offset: 0x0020E628
		public static DangoSkill GetRootAsDangoSkill(ByteBuffer _bb)
		{
			return DangoSkill.GetRootAsDangoSkill(_bb, default(DangoSkill));
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00210444 File Offset: 0x0020E644
		public static DangoSkill GetRootAsDangoSkill(ByteBuffer _bb, DangoSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00210461 File Offset: 0x0020E661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00210470 File Offset: 0x0020E670
		public DangoSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060060C5 RID: 24773 RVA: 0x00210480 File Offset: 0x0020E680
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

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060060C6 RID: 24774 RVA: 0x002104BC File Offset: 0x0020E6BC
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

		// Token: 0x060060C7 RID: 24775 RVA: 0x002104F3 File Offset: 0x0020E6F3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00210502 File Offset: 0x0020E702
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x0021051C File Offset: 0x0020E71C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00210553 File Offset: 0x0020E753
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00210562 File Offset: 0x0020E762
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060060CC RID: 24780 RVA: 0x0021057C File Offset: 0x0020E77C
		public string ActivateDesc
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

		// Token: 0x060060CD RID: 24781 RVA: 0x002105B4 File Offset: 0x0020E7B4
		public Span<byte> GetActivateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x002105C4 File Offset: 0x0020E7C4
		public byte[] GetActivateDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x002105DC File Offset: 0x0020E7DC
		public int SkillEffect
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

		// Token: 0x060060D0 RID: 24784 RVA: 0x0021061C File Offset: 0x0020E81C
		public string Params(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x00210658 File Offset: 0x0020E858
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00210684 File Offset: 0x0020E884
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00210691 File Offset: 0x0020E891
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			DangoSkill.<ParamsIter>d__28 <ParamsIter>d__ = new DangoSkill.<ParamsIter>d__28(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004C0B RID: 19467
		private Table __p;
	}
}
