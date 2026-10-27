using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001059 RID: 4185
	public struct RoleSkillFightTrick : IFlatbufferObject
	{
		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600C9FC RID: 51708 RVA: 0x002FDBF9 File Offset: 0x002FBDF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x002FDC06 File Offset: 0x002FBE06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x002FDC10 File Offset: 0x002FBE10
		public static RoleSkillFightTrick GetRootAsRoleSkillFightTrick(ByteBuffer _bb)
		{
			return RoleSkillFightTrick.GetRootAsRoleSkillFightTrick(_bb, default(RoleSkillFightTrick));
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x002FDC2C File Offset: 0x002FBE2C
		public static RoleSkillFightTrick GetRootAsRoleSkillFightTrick(ByteBuffer _bb, RoleSkillFightTrick obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x002FDC49 File Offset: 0x002FBE49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x002FDC58 File Offset: 0x002FBE58
		public RoleSkillFightTrick __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600CA02 RID: 51714 RVA: 0x002FDC68 File Offset: 0x002FBE68
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

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600CA03 RID: 51715 RVA: 0x002FDCA4 File Offset: 0x002FBEA4
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

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600CA04 RID: 51716 RVA: 0x002FDCE0 File Offset: 0x002FBEE0
		public string SkillTitle
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

		// Token: 0x0600CA05 RID: 51717 RVA: 0x002FDD17 File Offset: 0x002FBF17
		public Span<byte> GetSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x002FDD26 File Offset: 0x002FBF26
		public byte[] GetSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x002FDD40 File Offset: 0x002FBF40
		public int SkillDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600CA08 RID: 51720 RVA: 0x002FDD80 File Offset: 0x002FBF80
		public int SkillDescLength
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

		// Token: 0x0600CA09 RID: 51721 RVA: 0x002FDDAC File Offset: 0x002FBFAC
		public Span<int> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x002FDDBC File Offset: 0x002FBFBC
		public int[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600CA0B RID: 51723 RVA: 0x002FDDD4 File Offset: 0x002FBFD4
		public int Type
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

		// Token: 0x0600CA0C RID: 51724 RVA: 0x002FDE14 File Offset: 0x002FC014
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescIter()或GetSkillDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillDesc()
		{
			RoleSkillFightTrick roleSkillFightTrick = this;
			return roleSkillFightTrick.GetSkillDescArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x002FDE38 File Offset: 0x002FC038
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillDescIter()
		{
			RoleSkillFightTrick.<SkillDescIter>d__24 <SkillDescIter>d__ = new RoleSkillFightTrick.<SkillDescIter>d__24(-2);
			<SkillDescIter>d__.<>3__<>4__this = this;
			return <SkillDescIter>d__;
		}

		// Token: 0x0400515B RID: 20827
		private Table __p;
	}
}
