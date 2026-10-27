using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105A RID: 4186
	public struct RoleSkillInput : IFlatbufferObject
	{
		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x002FDE4D File Offset: 0x002FC04D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x002FDE5A File Offset: 0x002FC05A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x002FDE64 File Offset: 0x002FC064
		public static RoleSkillInput GetRootAsRoleSkillInput(ByteBuffer _bb)
		{
			return RoleSkillInput.GetRootAsRoleSkillInput(_bb, default(RoleSkillInput));
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x002FDE80 File Offset: 0x002FC080
		public static RoleSkillInput GetRootAsRoleSkillInput(ByteBuffer _bb, RoleSkillInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA12 RID: 51730 RVA: 0x002FDE9D File Offset: 0x002FC09D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x002FDEAC File Offset: 0x002FC0AC
		public RoleSkillInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x002FDEBC File Offset: 0x002FC0BC
		public int RoleId
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

		// Token: 0x0600CA15 RID: 51733 RVA: 0x002FDEF8 File Offset: 0x002FC0F8
		public int SkillInputIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x002FDF38 File Offset: 0x002FC138
		public int SkillInputIdListLength
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

		// Token: 0x0600CA17 RID: 51735 RVA: 0x002FDF63 File Offset: 0x002FC163
		public Span<int> GetSkillInputIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x002FDF72 File Offset: 0x002FC172
		public int[] GetSkillInputIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x002FDF8C File Offset: 0x002FC18C
		public string Icon
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

		// Token: 0x0600CA1A RID: 51738 RVA: 0x002FDFC3 File Offset: 0x002FC1C3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x002FDFD2 File Offset: 0x002FC1D2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x002FDFEC File Offset: 0x002FC1EC
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600CA1D RID: 51741 RVA: 0x002FE028 File Offset: 0x002FC228
		public int SkillDescListLength
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

		// Token: 0x0600CA1E RID: 51742 RVA: 0x002FE054 File Offset: 0x002FC254
		public string DescList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600CA1F RID: 51743 RVA: 0x002FE090 File Offset: 0x002FC290
		public int DescListLength
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

		// Token: 0x0600CA20 RID: 51744 RVA: 0x002FE0BC File Offset: 0x002FC2BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescListIter()或GetDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescList()
		{
			return this.DescListIter().ToArray<string>();
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x002FE0C9 File Offset: 0x002FC2C9
		[NullableContext(1)]
		public readonly IEnumerable<string> DescListIter()
		{
			RoleSkillInput.<DescListIter>d__26 <DescListIter>d__ = new RoleSkillInput.<DescListIter>d__26(-2);
			<DescListIter>d__.<>3__<>4__this = this;
			return <DescListIter>d__;
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x002FE0DE File Offset: 0x002FC2DE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescListIter()或GetSkillDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x002FE0EB File Offset: 0x002FC2EB
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillDescListIter()
		{
			RoleSkillInput.<SkillDescListIter>d__28 <SkillDescListIter>d__ = new RoleSkillInput.<SkillDescListIter>d__28(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x002FE100 File Offset: 0x002FC300
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillInputIdListIter()或GetSkillInputIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillInputIdList()
		{
			RoleSkillInput roleSkillInput = this;
			return roleSkillInput.GetSkillInputIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x002FE124 File Offset: 0x002FC324
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillInputIdListIter()
		{
			RoleSkillInput.<SkillInputIdListIter>d__30 <SkillInputIdListIter>d__ = new RoleSkillInput.<SkillInputIdListIter>d__30(-2);
			<SkillInputIdListIter>d__.<>3__<>4__this = this;
			return <SkillInputIdListIter>d__;
		}

		// Token: 0x0400515C RID: 20828
		private Table __p;
	}
}
