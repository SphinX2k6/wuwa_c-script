using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7E RID: 3710
	public struct NewbieCarnivalTask : IFlatbufferObject
	{
		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06009E2C RID: 40492 RVA: 0x0029BA25 File Offset: 0x00299C25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x0029BA32 File Offset: 0x00299C32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x0029BA3C File Offset: 0x00299C3C
		public static NewbieCarnivalTask GetRootAsNewbieCarnivalTask(ByteBuffer _bb)
		{
			return NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(_bb, default(NewbieCarnivalTask));
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x0029BA58 File Offset: 0x00299C58
		public static NewbieCarnivalTask GetRootAsNewbieCarnivalTask(ByteBuffer _bb, NewbieCarnivalTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x0029BA75 File Offset: 0x00299C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x0029BA84 File Offset: 0x00299C84
		public NewbieCarnivalTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x0029BA94 File Offset: 0x00299C94
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

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06009E33 RID: 40499 RVA: 0x0029BAD0 File Offset: 0x00299CD0
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

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x0029BB0C File Offset: 0x00299D0C
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

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06009E35 RID: 40501 RVA: 0x0029BB48 File Offset: 0x00299D48
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

		// Token: 0x06009E36 RID: 40502 RVA: 0x0029BB80 File Offset: 0x00299D80
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x0029BB90 File Offset: 0x00299D90
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06009E38 RID: 40504 RVA: 0x0029BBA8 File Offset: 0x00299DA8
		public int JumpConditionGroups(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x0029BBE8 File Offset: 0x00299DE8
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

		// Token: 0x06009E3A RID: 40506 RVA: 0x0029BC14 File Offset: 0x00299E14
		public Span<int> GetJumpConditionGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x0029BC24 File Offset: 0x00299E24
		public int[] GetJumpConditionGroupsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06009E3C RID: 40508 RVA: 0x0029BC3C File Offset: 0x00299E3C
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

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x06009E3D RID: 40509 RVA: 0x0029BC7C File Offset: 0x00299E7C
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

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x0029BCBC File Offset: 0x00299EBC
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

		// Token: 0x06009E3F RID: 40511 RVA: 0x0029BCFC File Offset: 0x00299EFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用JumpConditionGroupsIter()或GetJumpConditionGroupsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] JumpConditionGroups()
		{
			NewbieCarnivalTask newbieCarnivalTask = this;
			return newbieCarnivalTask.GetJumpConditionGroupsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x0029BD20 File Offset: 0x00299F20
		[NullableContext(1)]
		public readonly IEnumerable<int> JumpConditionGroupsIter()
		{
			NewbieCarnivalTask.<JumpConditionGroupsIter>d__30 <JumpConditionGroupsIter>d__ = new NewbieCarnivalTask.<JumpConditionGroupsIter>d__30(-2);
			<JumpConditionGroupsIter>d__.<>3__<>4__this = this;
			return <JumpConditionGroupsIter>d__;
		}

		// Token: 0x04004F2C RID: 20268
		private Table __p;
	}
}
