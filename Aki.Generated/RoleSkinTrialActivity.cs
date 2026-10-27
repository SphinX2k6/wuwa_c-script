using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105E RID: 4190
	public struct RoleSkinTrialActivity : IFlatbufferObject
	{
		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x003003C0 File Offset: 0x002FE5C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x003003CD File Offset: 0x002FE5CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x003003D4 File Offset: 0x002FE5D4
		public static RoleSkinTrialActivity GetRootAsRoleSkinTrialActivity(ByteBuffer _bb)
		{
			return RoleSkinTrialActivity.GetRootAsRoleSkinTrialActivity(_bb, default(RoleSkinTrialActivity));
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x003003F0 File Offset: 0x002FE5F0
		public static RoleSkinTrialActivity GetRootAsRoleSkinTrialActivity(ByteBuffer _bb, RoleSkinTrialActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x0030040D File Offset: 0x002FE60D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x0030041C File Offset: 0x002FE61C
		public RoleSkinTrialActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x0030042C File Offset: 0x002FE62C
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

		// Token: 0x0600CB2A RID: 52010 RVA: 0x00300468 File Offset: 0x002FE668
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x003004A8 File Offset: 0x002FE6A8
		public int RoleIdListLength
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

		// Token: 0x0600CB2C RID: 52012 RVA: 0x003004D3 File Offset: 0x002FE6D3
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x003004E2 File Offset: 0x002FE6E2
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x003004FC File Offset: 0x002FE6FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleIdListIter()或GetRoleIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleIdList()
		{
			RoleSkinTrialActivity roleSkinTrialActivity = this;
			return roleSkinTrialActivity.GetRoleIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x00300520 File Offset: 0x002FE720
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleIdListIter()
		{
			RoleSkinTrialActivity.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new RoleSkinTrialActivity.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x04005162 RID: 20834
		private Table __p;
	}
}
