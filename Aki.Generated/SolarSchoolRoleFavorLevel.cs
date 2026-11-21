using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FE RID: 4606
	public struct SolarSchoolRoleFavorLevel : IFlatbufferObject
	{
		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600E362 RID: 58210 RVA: 0x003455B9 File Offset: 0x003437B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x003455C6 File Offset: 0x003437C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E364 RID: 58212 RVA: 0x003455D0 File Offset: 0x003437D0
		public static SolarSchoolRoleFavorLevel GetRootAsSolarSchoolRoleFavorLevel(ByteBuffer _bb)
		{
			return SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(_bb, default(SolarSchoolRoleFavorLevel));
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x003455EC File Offset: 0x003437EC
		public static SolarSchoolRoleFavorLevel GetRootAsSolarSchoolRoleFavorLevel(ByteBuffer _bb, SolarSchoolRoleFavorLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x00345609 File Offset: 0x00343809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x00345618 File Offset: 0x00343818
		public SolarSchoolRoleFavorLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x00345628 File Offset: 0x00343828
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

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600E369 RID: 58217 RVA: 0x00345664 File Offset: 0x00343864
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

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600E36A RID: 58218 RVA: 0x003456A0 File Offset: 0x003438A0
		public int ActivityId
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

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x003456DC File Offset: 0x003438DC
		public int FavorLevel
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

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0600E36C RID: 58220 RVA: 0x0034571C File Offset: 0x0034391C
		public string SkillDesc
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

		// Token: 0x0600E36D RID: 58221 RVA: 0x00345754 File Offset: 0x00343954
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x00345764 File Offset: 0x00343964
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0034577C File Offset: 0x0034397C
		public int PreUnlockConditionId
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

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600E370 RID: 58224 RVA: 0x003457BC File Offset: 0x003439BC
		public string PreUnlockIcon
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

		// Token: 0x0600E371 RID: 58225 RVA: 0x003457F4 File Offset: 0x003439F4
		public Span<byte> GetPreUnlockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x00345804 File Offset: 0x00343A04
		public byte[] GetPreUnlockIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600E373 RID: 58227 RVA: 0x0034581C File Offset: 0x00343A1C
		public int UnlockConditionId
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

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600E374 RID: 58228 RVA: 0x0034585C File Offset: 0x00343A5C
		public string UnlockHint
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00345894 File Offset: 0x00343A94
		public Span<byte> GetUnlockHintBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x003458A4 File Offset: 0x00343AA4
		public byte[] GetUnlockHintArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600E377 RID: 58231 RVA: 0x003458BC File Offset: 0x00343ABC
		public int UnlockRewardId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600E378 RID: 58232 RVA: 0x003458FC File Offset: 0x00343AFC
		public int UpgradeFavorValue
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600E379 RID: 58233 RVA: 0x0034593C File Offset: 0x00343B3C
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00345974 File Offset: 0x00343B74
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00345984 File Offset: 0x00343B84
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0400583C RID: 22588
		private Table __p;
	}
}
