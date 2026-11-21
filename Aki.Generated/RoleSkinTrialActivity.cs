using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001146 RID: 4422
	public struct RoleSkinTrialActivity : IFlatbufferObject
	{
		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600D17A RID: 53626 RVA: 0x0031C7D8 File Offset: 0x0031A9D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x0031C7E5 File Offset: 0x0031A9E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x0031C7EC File Offset: 0x0031A9EC
		public static RoleSkinTrialActivity GetRootAsRoleSkinTrialActivity(ByteBuffer _bb)
		{
			return RoleSkinTrialActivity.GetRootAsRoleSkinTrialActivity(_bb, default(RoleSkinTrialActivity));
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x0031C808 File Offset: 0x0031AA08
		public static RoleSkinTrialActivity GetRootAsRoleSkinTrialActivity(ByteBuffer _bb, RoleSkinTrialActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x0031C825 File Offset: 0x0031AA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x0031C834 File Offset: 0x0031AA34
		public RoleSkinTrialActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600D180 RID: 53632 RVA: 0x0031C844 File Offset: 0x0031AA44
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

		// Token: 0x0600D181 RID: 53633 RVA: 0x0031C880 File Offset: 0x0031AA80
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600D182 RID: 53634 RVA: 0x0031C8C0 File Offset: 0x0031AAC0
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

		// Token: 0x0600D183 RID: 53635 RVA: 0x0031C8EB File Offset: 0x0031AAEB
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x0031C8FA File Offset: 0x0031AAFA
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x0031C911 File Offset: 0x0031AB11
		[NullableContext(1)]
		public int[] RoleIdList()
		{
			return this.GetRoleIdListArray();
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x0031C919 File Offset: 0x0031AB19
		[NullableContext(1)]
		public IEnumerable<int> RoleIdListIter()
		{
			RoleSkinTrialActivity.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new RoleSkinTrialActivity.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x0400574A RID: 22346
		private Table __p;
	}
}
