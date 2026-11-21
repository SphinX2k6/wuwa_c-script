using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112B RID: 4395
	public struct RoleDevItemJumpGroup : IFlatbufferObject
	{
		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x00314F85 File Offset: 0x00313185
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE42 RID: 52802 RVA: 0x00314F92 File Offset: 0x00313192
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x00314F9C File Offset: 0x0031319C
		public static RoleDevItemJumpGroup GetRootAsRoleDevItemJumpGroup(ByteBuffer _bb)
		{
			return RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(_bb, default(RoleDevItemJumpGroup));
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x00314FB8 File Offset: 0x003131B8
		public static RoleDevItemJumpGroup GetRootAsRoleDevItemJumpGroup(ByteBuffer _bb, RoleDevItemJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE45 RID: 52805 RVA: 0x00314FD5 File Offset: 0x003131D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x00314FE4 File Offset: 0x003131E4
		public RoleDevItemJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x00314FF4 File Offset: 0x003131F4
		public int ItemId
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

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600CE48 RID: 52808 RVA: 0x00315030 File Offset: 0x00313230
		public int ItemType
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

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x0031506C File Offset: 0x0031326C
		public int DetectionType
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

		// Token: 0x0600CE4A RID: 52810 RVA: 0x003150A8 File Offset: 0x003132A8
		public int DetectionID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x003150E8 File Offset: 0x003132E8
		public int DetectionIDLength
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

		// Token: 0x0600CE4C RID: 52812 RVA: 0x00315114 File Offset: 0x00313314
		public Span<int> GetDetectionIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x00315124 File Offset: 0x00313324
		public int[] GetDetectionIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE4E RID: 52814 RVA: 0x0031513C File Offset: 0x0031333C
		public int JumpGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x0031517C File Offset: 0x0031337C
		public int JumpGroupLength
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

		// Token: 0x0600CE50 RID: 52816 RVA: 0x003151A8 File Offset: 0x003133A8
		public Span<int> GetJumpGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x003151B8 File Offset: 0x003133B8
		public int[] GetJumpGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600CE52 RID: 52818 RVA: 0x003151D0 File Offset: 0x003133D0
		public int SpecialJumpGroup
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

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x00315210 File Offset: 0x00313410
		public int SynthesisValue
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

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600CE54 RID: 52820 RVA: 0x00315250 File Offset: 0x00313450
		public int SubGroup
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

		// Token: 0x0600CE55 RID: 52821 RVA: 0x0031528D File Offset: 0x0031348D
		[NullableContext(1)]
		public int[] DetectionID()
		{
			return this.GetDetectionIDArray();
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x00315295 File Offset: 0x00313495
		[NullableContext(1)]
		public IEnumerable<int> DetectionIDIter()
		{
			RoleDevItemJumpGroup.<DetectionIDIter>d__31 <DetectionIDIter>d__ = new RoleDevItemJumpGroup.<DetectionIDIter>d__31(-2);
			<DetectionIDIter>d__.<>3__<>4__this = this;
			return <DetectionIDIter>d__;
		}

		// Token: 0x0600CE57 RID: 52823 RVA: 0x003152AA File Offset: 0x003134AA
		[NullableContext(1)]
		public int[] JumpGroup()
		{
			return this.GetJumpGroupArray();
		}

		// Token: 0x0600CE58 RID: 52824 RVA: 0x003152B2 File Offset: 0x003134B2
		[NullableContext(1)]
		public IEnumerable<int> JumpGroupIter()
		{
			RoleDevItemJumpGroup.<JumpGroupIter>d__33 <JumpGroupIter>d__ = new RoleDevItemJumpGroup.<JumpGroupIter>d__33(-2);
			<JumpGroupIter>d__.<>3__<>4__this = this;
			return <JumpGroupIter>d__;
		}

		// Token: 0x04005729 RID: 22313
		private Table __p;
	}
}
