using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F63 RID: 3939
	public struct NewbieCarnivalTask : IFlatbufferObject
	{
		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x002B90D9 File Offset: 0x002B72D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x002B90E6 File Offset: 0x002B72E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x002B90F0 File Offset: 0x002B72F0
		public static NewbieCarnivalTask GetRootAsNewbieCarnivalTask(ByteBuffer _bb)
		{
			return NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(_bb, default(NewbieCarnivalTask));
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x002B910C File Offset: 0x002B730C
		public static NewbieCarnivalTask GetRootAsNewbieCarnivalTask(ByteBuffer _bb, NewbieCarnivalTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x002B9129 File Offset: 0x002B7329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x002B9138 File Offset: 0x002B7338
		public NewbieCarnivalTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x002B9148 File Offset: 0x002B7348
		public int TaskId
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

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x002B9184 File Offset: 0x002B7384
		public int TaskType
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

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x0600A454 RID: 42068 RVA: 0x002B91C0 File Offset: 0x002B73C0
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

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x002B91FC File Offset: 0x002B73FC
		public string TaskName
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

		// Token: 0x0600A456 RID: 42070 RVA: 0x002B9234 File Offset: 0x002B7434
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x002B9244 File Offset: 0x002B7444
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x002B925C File Offset: 0x002B745C
		public int JumpConditionGroups(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x002B929C File Offset: 0x002B749C
		public int JumpConditionGroupsLength
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

		// Token: 0x0600A45A RID: 42074 RVA: 0x002B92C8 File Offset: 0x002B74C8
		public Span<int> GetJumpConditionGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x002B92D8 File Offset: 0x002B74D8
		public int[] GetJumpConditionGroupsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x0600A45C RID: 42076 RVA: 0x002B92F0 File Offset: 0x002B74F0
		public int JumpConditionGroup
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

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x002B9330 File Offset: 0x002B7530
		public int TaskReward
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x002B9370 File Offset: 0x002B7570
		public int JumpId
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

		// Token: 0x0600A45F RID: 42079 RVA: 0x002B93AD File Offset: 0x002B75AD
		[NullableContext(1)]
		public int[] JumpConditionGroups()
		{
			return this.GetJumpConditionGroupsArray();
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x002B93B5 File Offset: 0x002B75B5
		[NullableContext(1)]
		public IEnumerable<int> JumpConditionGroupsIter()
		{
			NewbieCarnivalTask.<JumpConditionGroupsIter>d__30 <JumpConditionGroupsIter>d__ = new NewbieCarnivalTask.<JumpConditionGroupsIter>d__30(-2);
			<JumpConditionGroupsIter>d__.<>3__<>4__this = this;
			return <JumpConditionGroupsIter>d__;
		}

		// Token: 0x04005511 RID: 21777
		private Table __p;
	}
}
