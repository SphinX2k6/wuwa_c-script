using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001043 RID: 4163
	public struct RoleDevItemJumpGroup : IFlatbufferObject
	{
		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600C7F7 RID: 51191 RVA: 0x002F91E9 File Offset: 0x002F73E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7F8 RID: 51192 RVA: 0x002F91F6 File Offset: 0x002F73F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7F9 RID: 51193 RVA: 0x002F9200 File Offset: 0x002F7400
		public static RoleDevItemJumpGroup GetRootAsRoleDevItemJumpGroup(ByteBuffer _bb)
		{
			return RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(_bb, default(RoleDevItemJumpGroup));
		}

		// Token: 0x0600C7FA RID: 51194 RVA: 0x002F921C File Offset: 0x002F741C
		public static RoleDevItemJumpGroup GetRootAsRoleDevItemJumpGroup(ByteBuffer _bb, RoleDevItemJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7FB RID: 51195 RVA: 0x002F9239 File Offset: 0x002F7439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7FC RID: 51196 RVA: 0x002F9248 File Offset: 0x002F7448
		public RoleDevItemJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600C7FD RID: 51197 RVA: 0x002F9258 File Offset: 0x002F7458
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

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x002F9294 File Offset: 0x002F7494
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

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600C7FF RID: 51199 RVA: 0x002F92D0 File Offset: 0x002F74D0
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

		// Token: 0x0600C800 RID: 51200 RVA: 0x002F930C File Offset: 0x002F750C
		public int DetectionID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600C801 RID: 51201 RVA: 0x002F934C File Offset: 0x002F754C
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

		// Token: 0x0600C802 RID: 51202 RVA: 0x002F9378 File Offset: 0x002F7578
		public Span<int> GetDetectionIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x002F9388 File Offset: 0x002F7588
		public int[] GetDetectionIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C804 RID: 51204 RVA: 0x002F93A0 File Offset: 0x002F75A0
		public int JumpGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600C805 RID: 51205 RVA: 0x002F93E0 File Offset: 0x002F75E0
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

		// Token: 0x0600C806 RID: 51206 RVA: 0x002F940C File Offset: 0x002F760C
		public Span<int> GetJumpGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x002F941C File Offset: 0x002F761C
		public int[] GetJumpGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x002F9434 File Offset: 0x002F7634
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

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600C809 RID: 51209 RVA: 0x002F9474 File Offset: 0x002F7674
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

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x002F94B4 File Offset: 0x002F76B4
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

		// Token: 0x0600C80B RID: 51211 RVA: 0x002F94F4 File Offset: 0x002F76F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DetectionIDIter()或GetDetectionIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DetectionID()
		{
			RoleDevItemJumpGroup roleDevItemJumpGroup = this;
			return roleDevItemJumpGroup.GetDetectionIDArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x002F9518 File Offset: 0x002F7718
		[NullableContext(1)]
		public readonly IEnumerable<int> DetectionIDIter()
		{
			RoleDevItemJumpGroup.<DetectionIDIter>d__31 <DetectionIDIter>d__ = new RoleDevItemJumpGroup.<DetectionIDIter>d__31(-2);
			<DetectionIDIter>d__.<>3__<>4__this = this;
			return <DetectionIDIter>d__;
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x002F9530 File Offset: 0x002F7730
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用JumpGroupIter()或GetJumpGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] JumpGroup()
		{
			RoleDevItemJumpGroup roleDevItemJumpGroup = this;
			return roleDevItemJumpGroup.GetJumpGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x002F9554 File Offset: 0x002F7754
		[NullableContext(1)]
		public readonly IEnumerable<int> JumpGroupIter()
		{
			RoleDevItemJumpGroup.<JumpGroupIter>d__33 <JumpGroupIter>d__ = new RoleDevItemJumpGroup.<JumpGroupIter>d__33(-2);
			<JumpGroupIter>d__.<>3__<>4__this = this;
			return <JumpGroupIter>d__;
		}

		// Token: 0x04005141 RID: 20801
		private Table __p;
	}
}
