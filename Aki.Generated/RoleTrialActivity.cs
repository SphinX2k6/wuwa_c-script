using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001063 RID: 4195
	public struct RoleTrialActivity : IFlatbufferObject
	{
		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x00300EE1 File Offset: 0x002FF0E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x00300EEE File Offset: 0x002FF0EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x00300EF8 File Offset: 0x002FF0F8
		public static RoleTrialActivity GetRootAsRoleTrialActivity(ByteBuffer _bb)
		{
			return RoleTrialActivity.GetRootAsRoleTrialActivity(_bb, default(RoleTrialActivity));
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x00300F14 File Offset: 0x002FF114
		public static RoleTrialActivity GetRootAsRoleTrialActivity(ByteBuffer _bb, RoleTrialActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x00300F31 File Offset: 0x002FF131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x00300F40 File Offset: 0x002FF140
		public RoleTrialActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x00300F50 File Offset: 0x002FF150
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

		// Token: 0x0600CB80 RID: 52096 RVA: 0x00300F8C File Offset: 0x002FF18C
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00300FCC File Offset: 0x002FF1CC
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

		// Token: 0x0600CB82 RID: 52098 RVA: 0x00300FF7 File Offset: 0x002FF1F7
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x00301006 File Offset: 0x002FF206
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x00301020 File Offset: 0x002FF220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleIdListIter()或GetRoleIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleIdList()
		{
			RoleTrialActivity roleTrialActivity = this;
			return roleTrialActivity.GetRoleIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x00301044 File Offset: 0x002FF244
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleIdListIter()
		{
			RoleTrialActivity.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new RoleTrialActivity.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x04005167 RID: 20839
		private Table __p;
	}
}
