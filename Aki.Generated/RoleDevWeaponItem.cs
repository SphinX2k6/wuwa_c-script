using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001049 RID: 4169
	public struct RoleDevWeaponItem : IFlatbufferObject
	{
		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600C860 RID: 51296 RVA: 0x002F9FB5 File Offset: 0x002F81B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x002F9FC2 File Offset: 0x002F81C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C862 RID: 51298 RVA: 0x002F9FCC File Offset: 0x002F81CC
		public static RoleDevWeaponItem GetRootAsRoleDevWeaponItem(ByteBuffer _bb)
		{
			return RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(_bb, default(RoleDevWeaponItem));
		}

		// Token: 0x0600C863 RID: 51299 RVA: 0x002F9FE8 File Offset: 0x002F81E8
		public static RoleDevWeaponItem GetRootAsRoleDevWeaponItem(ByteBuffer _bb, RoleDevWeaponItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C864 RID: 51300 RVA: 0x002FA005 File Offset: 0x002F8205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x002FA014 File Offset: 0x002F8214
		public RoleDevWeaponItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600C866 RID: 51302 RVA: 0x002FA024 File Offset: 0x002F8224
		public int WeaponType
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

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600C867 RID: 51303 RVA: 0x002FA060 File Offset: 0x002F8260
		public int WeaponItemGroup
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

		// Token: 0x0600C868 RID: 51304 RVA: 0x002FA09C File Offset: 0x002F829C
		public int WeaponTypeExperience(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600C869 RID: 51305 RVA: 0x002FA0DC File Offset: 0x002F82DC
		public int WeaponTypeExperienceLength
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

		// Token: 0x0600C86A RID: 51306 RVA: 0x002FA107 File Offset: 0x002F8307
		public Span<int> GetWeaponTypeExperienceBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x002FA116 File Offset: 0x002F8316
		public int[] GetWeaponTypeExperienceArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600C86C RID: 51308 RVA: 0x002FA130 File Offset: 0x002F8330
		public string WeaponTypeIcon
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

		// Token: 0x0600C86D RID: 51309 RVA: 0x002FA168 File Offset: 0x002F8368
		public Span<byte> GetWeaponTypeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x002FA178 File Offset: 0x002F8378
		public byte[] GetWeaponTypeIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600C86F RID: 51311 RVA: 0x002FA190 File Offset: 0x002F8390
		public string WeaponTypeDescribe
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x002FA1C8 File Offset: 0x002F83C8
		public Span<byte> GetWeaponTypeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x002FA1D8 File Offset: 0x002F83D8
		public byte[] GetWeaponTypeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x002FA1F0 File Offset: 0x002F83F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponTypeExperienceIter()或GetWeaponTypeExperienceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponTypeExperience()
		{
			RoleDevWeaponItem roleDevWeaponItem = this;
			return roleDevWeaponItem.GetWeaponTypeExperienceArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x002FA214 File Offset: 0x002F8414
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponTypeExperienceIter()
		{
			RoleDevWeaponItem.<WeaponTypeExperienceIter>d__26 <WeaponTypeExperienceIter>d__ = new RoleDevWeaponItem.<WeaponTypeExperienceIter>d__26(-2);
			<WeaponTypeExperienceIter>d__.<>3__<>4__this = this;
			return <WeaponTypeExperienceIter>d__;
		}

		// Token: 0x04005147 RID: 20807
		private Table __p;
	}
}
