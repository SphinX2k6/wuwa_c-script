using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115E RID: 4446
	public struct RoleTrialActivity : IFlatbufferObject
	{
		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600D34C RID: 54092 RVA: 0x003207D5 File Offset: 0x0031E9D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D34D RID: 54093 RVA: 0x003207E2 File Offset: 0x0031E9E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D34E RID: 54094 RVA: 0x003207EC File Offset: 0x0031E9EC
		public static RoleTrialActivity GetRootAsRoleTrialActivity(ByteBuffer _bb)
		{
			return RoleTrialActivity.GetRootAsRoleTrialActivity(_bb, default(RoleTrialActivity));
		}

		// Token: 0x0600D34F RID: 54095 RVA: 0x00320808 File Offset: 0x0031EA08
		public static RoleTrialActivity GetRootAsRoleTrialActivity(ByteBuffer _bb, RoleTrialActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D350 RID: 54096 RVA: 0x00320825 File Offset: 0x0031EA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D351 RID: 54097 RVA: 0x00320834 File Offset: 0x0031EA34
		public RoleTrialActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600D352 RID: 54098 RVA: 0x00320844 File Offset: 0x0031EA44
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

		// Token: 0x0600D353 RID: 54099 RVA: 0x00320880 File Offset: 0x0031EA80
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600D354 RID: 54100 RVA: 0x003208C0 File Offset: 0x0031EAC0
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

		// Token: 0x0600D355 RID: 54101 RVA: 0x003208EB File Offset: 0x0031EAEB
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D356 RID: 54102 RVA: 0x003208FA File Offset: 0x0031EAFA
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600D357 RID: 54103 RVA: 0x00320911 File Offset: 0x0031EB11
		[NullableContext(1)]
		public int[] RoleIdList()
		{
			return this.GetRoleIdListArray();
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x00320919 File Offset: 0x0031EB19
		[NullableContext(1)]
		public IEnumerable<int> RoleIdListIter()
		{
			RoleTrialActivity.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new RoleTrialActivity.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x04005766 RID: 22374
		private Table __p;
	}
}
