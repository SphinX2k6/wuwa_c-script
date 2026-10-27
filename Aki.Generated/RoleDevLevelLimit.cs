using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001044 RID: 4164
	public struct RoleDevLevelLimit : IFlatbufferObject
	{
		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x002F9569 File Offset: 0x002F7769
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C810 RID: 51216 RVA: 0x002F9576 File Offset: 0x002F7776
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C811 RID: 51217 RVA: 0x002F9580 File Offset: 0x002F7780
		public static RoleDevLevelLimit GetRootAsRoleDevLevelLimit(ByteBuffer _bb)
		{
			return RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(_bb, default(RoleDevLevelLimit));
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x002F959C File Offset: 0x002F779C
		public static RoleDevLevelLimit GetRootAsRoleDevLevelLimit(ByteBuffer _bb, RoleDevLevelLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x002F95B9 File Offset: 0x002F77B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x002F95C8 File Offset: 0x002F77C8
		public RoleDevLevelLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600C815 RID: 51221 RVA: 0x002F95D8 File Offset: 0x002F77D8
		public int ProjectNum
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

		// Token: 0x0600C816 RID: 51222 RVA: 0x002F9614 File Offset: 0x002F7814
		public IntPair? PlayerLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600C817 RID: 51223 RVA: 0x002F9674 File Offset: 0x002F7874
		public int PlayerLevelLength
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

		// Token: 0x0600C818 RID: 51224 RVA: 0x002F969F File Offset: 0x002F789F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlayerLevelIter()或GetPlayerLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] PlayerLevel()
		{
			return this.PlayerLevelIter().ToArray<IntPair>();
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x002F96AC File Offset: 0x002F78AC
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> PlayerLevelIter()
		{
			RoleDevLevelLimit.<PlayerLevelIter>d__14 <PlayerLevelIter>d__ = new RoleDevLevelLimit.<PlayerLevelIter>d__14(-2);
			<PlayerLevelIter>d__.<>3__<>4__this = this;
			return <PlayerLevelIter>d__;
		}

		// Token: 0x04005142 RID: 20802
		private Table __p;
	}
}
