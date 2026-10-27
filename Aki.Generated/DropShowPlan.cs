using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C14 RID: 3092
	public struct DropShowPlan : IFlatbufferObject
	{
		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x0021C950 File Offset: 0x0021AB50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x0021C95D File Offset: 0x0021AB5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x0021C964 File Offset: 0x0021AB64
		public static DropShowPlan GetRootAsDropShowPlan(ByteBuffer _bb)
		{
			return DropShowPlan.GetRootAsDropShowPlan(_bb, default(DropShowPlan));
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x0021C980 File Offset: 0x0021AB80
		public static DropShowPlan GetRootAsDropShowPlan(ByteBuffer _bb, DropShowPlan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0021C99D File Offset: 0x0021AB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0021C9AC File Offset: 0x0021ABAC
		public DropShowPlan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x0021C9BC File Offset: 0x0021ABBC
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

		// Token: 0x0600661F RID: 26143 RVA: 0x0021C9F8 File Offset: 0x0021ABF8
		public int Force(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x0021CA38 File Offset: 0x0021AC38
		public int ForceLength
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

		// Token: 0x06006621 RID: 26145 RVA: 0x0021CA63 File Offset: 0x0021AC63
		public Span<int> GetForceBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x0021CA72 File Offset: 0x0021AC72
		public int[] GetForceArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x0021CA8C File Offset: 0x0021AC8C
		public int Angle(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x0021CACC File Offset: 0x0021ACCC
		public int AngleLength
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

		// Token: 0x06006625 RID: 26149 RVA: 0x0021CAF7 File Offset: 0x0021ACF7
		public Span<int> GetAngleBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x0021CB06 File Offset: 0x0021AD06
		public int[] GetAngleArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x0021CB20 File Offset: 0x0021AD20
		public int VerticalAngle(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x0021CB60 File Offset: 0x0021AD60
		public int VerticalAngleLength
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

		// Token: 0x06006629 RID: 26153 RVA: 0x0021CB8C File Offset: 0x0021AD8C
		public Span<int> GetVerticalAngleBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x0021CB9C File Offset: 0x0021AD9C
		public int[] GetVerticalAngleArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600662B RID: 26155 RVA: 0x0021CBB4 File Offset: 0x0021ADB4
		public int ShowBg
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

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x0021CBF4 File Offset: 0x0021ADF4
		public int ShowTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x0021CC38 File Offset: 0x0021AE38
		public int ShowCout
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x0021CC78 File Offset: 0x0021AE78
		public int Adsorption
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

		// Token: 0x0600662F RID: 26159 RVA: 0x0021CCB8 File Offset: 0x0021AEB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AngleIter()或GetAngleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Angle()
		{
			DropShowPlan dropShowPlan = this;
			return dropShowPlan.GetAngleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x0021CCDC File Offset: 0x0021AEDC
		[NullableContext(1)]
		public readonly IEnumerable<int> AngleIter()
		{
			DropShowPlan.<AngleIter>d__34 <AngleIter>d__ = new DropShowPlan.<AngleIter>d__34(-2);
			<AngleIter>d__.<>3__<>4__this = this;
			return <AngleIter>d__;
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x0021CCF4 File Offset: 0x0021AEF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ForceIter()或GetForceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Force()
		{
			DropShowPlan dropShowPlan = this;
			return dropShowPlan.GetForceArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x0021CD18 File Offset: 0x0021AF18
		[NullableContext(1)]
		public readonly IEnumerable<int> ForceIter()
		{
			DropShowPlan.<ForceIter>d__36 <ForceIter>d__ = new DropShowPlan.<ForceIter>d__36(-2);
			<ForceIter>d__.<>3__<>4__this = this;
			return <ForceIter>d__;
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x0021CD30 File Offset: 0x0021AF30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VerticalAngleIter()或GetVerticalAngleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] VerticalAngle()
		{
			DropShowPlan dropShowPlan = this;
			return dropShowPlan.GetVerticalAngleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x0021CD54 File Offset: 0x0021AF54
		[NullableContext(1)]
		public readonly IEnumerable<int> VerticalAngleIter()
		{
			DropShowPlan.<VerticalAngleIter>d__38 <VerticalAngleIter>d__ = new DropShowPlan.<VerticalAngleIter>d__38(-2);
			<VerticalAngleIter>d__.<>3__<>4__this = this;
			return <VerticalAngleIter>d__;
		}

		// Token: 0x04004C52 RID: 19538
		private Table __p;
	}
}
