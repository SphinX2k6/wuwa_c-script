using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112D RID: 4397
	public struct RoleDevPhantomJumpGroup : IFlatbufferObject
	{
		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600CE64 RID: 52836 RVA: 0x0031541D File Offset: 0x0031361D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE65 RID: 52837 RVA: 0x0031542A File Offset: 0x0031362A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x00315434 File Offset: 0x00313634
		public static RoleDevPhantomJumpGroup GetRootAsRoleDevPhantomJumpGroup(ByteBuffer _bb)
		{
			return RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(_bb, default(RoleDevPhantomJumpGroup));
		}

		// Token: 0x0600CE67 RID: 52839 RVA: 0x00315450 File Offset: 0x00313650
		public static RoleDevPhantomJumpGroup GetRootAsRoleDevPhantomJumpGroup(ByteBuffer _bb, RoleDevPhantomJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x0031546D File Offset: 0x0031366D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x0031547C File Offset: 0x0031367C
		public RoleDevPhantomJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600CE6A RID: 52842 RVA: 0x0031548C File Offset: 0x0031368C
		public int PhantomId
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

		// Token: 0x0600CE6B RID: 52843 RVA: 0x003154C8 File Offset: 0x003136C8
		public int PhantomJumpId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600CE6C RID: 52844 RVA: 0x00315508 File Offset: 0x00313708
		public int PhantomJumpIdLength
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

		// Token: 0x0600CE6D RID: 52845 RVA: 0x00315533 File Offset: 0x00313733
		public Span<int> GetPhantomJumpIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x00315542 File Offset: 0x00313742
		public int[] GetPhantomJumpIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600CE6F RID: 52847 RVA: 0x0031555C File Offset: 0x0031375C
		public int PriorityLevel
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

		// Token: 0x0600CE70 RID: 52848 RVA: 0x00315598 File Offset: 0x00313798
		[NullableContext(1)]
		public int[] PhantomJumpId()
		{
			return this.GetPhantomJumpIdArray();
		}

		// Token: 0x0600CE71 RID: 52849 RVA: 0x003155A0 File Offset: 0x003137A0
		[NullableContext(1)]
		public IEnumerable<int> PhantomJumpIdIter()
		{
			RoleDevPhantomJumpGroup.<PhantomJumpIdIter>d__18 <PhantomJumpIdIter>d__ = new RoleDevPhantomJumpGroup.<PhantomJumpIdIter>d__18(-2);
			<PhantomJumpIdIter>d__.<>3__<>4__this = this;
			return <PhantomJumpIdIter>d__;
		}

		// Token: 0x0400572B RID: 22315
		private Table __p;
	}
}
