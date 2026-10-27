using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001118 RID: 4376
	public struct TeamParKOurCfg : IFlatbufferObject
	{
		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x0032A04D File Offset: 0x0032824D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD17 RID: 56599 RVA: 0x0032A05A File Offset: 0x0032825A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x0032A064 File Offset: 0x00328264
		public static TeamParKOurCfg GetRootAsTeamParKOurCfg(ByteBuffer _bb)
		{
			return TeamParKOurCfg.GetRootAsTeamParKOurCfg(_bb, default(TeamParKOurCfg));
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x0032A080 File Offset: 0x00328280
		public static TeamParKOurCfg GetRootAsTeamParKOurCfg(ByteBuffer _bb, TeamParKOurCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x0032A09D File Offset: 0x0032829D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x0032A0AC File Offset: 0x003282AC
		public TeamParKOurCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600DD1C RID: 56604 RVA: 0x0032A0BC File Offset: 0x003282BC
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

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600DD1D RID: 56605 RVA: 0x0032A0F8 File Offset: 0x003282F8
		public int ActivityId
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

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600DD1E RID: 56606 RVA: 0x0032A134 File Offset: 0x00328334
		public int InstId
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

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x0032A170 File Offset: 0x00328370
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600DD20 RID: 56608 RVA: 0x0032A1B0 File Offset: 0x003283B0
		public string TitleText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x0032A1E8 File Offset: 0x003283E8
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x0032A1F8 File Offset: 0x003283F8
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600DD23 RID: 56611 RVA: 0x0032A210 File Offset: 0x00328410
		public string DescPicPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x0032A248 File Offset: 0x00328448
		public Span<byte> GetDescPicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DD25 RID: 56613 RVA: 0x0032A258 File Offset: 0x00328458
		public byte[] GetDescPicPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x0032A270 File Offset: 0x00328470
		public string RomePath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x0032A2A8 File Offset: 0x003284A8
		public Span<byte> GetRomePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DD28 RID: 56616 RVA: 0x0032A2B8 File Offset: 0x003284B8
		public byte[] GetRomePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD29 RID: 56617 RVA: 0x0032A2D0 File Offset: 0x003284D0
		public int TaskList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x0032A310 File Offset: 0x00328510
		public int TaskListLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x0032A33C File Offset: 0x0032853C
		public Span<int> GetTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DD2C RID: 56620 RVA: 0x0032A34C File Offset: 0x0032854C
		public int[] GetTaskListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD2D RID: 56621 RVA: 0x0032A364 File Offset: 0x00328564
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskListIter()或GetTaskListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TaskList()
		{
			TeamParKOurCfg teamParKOurCfg = this;
			return teamParKOurCfg.GetTaskListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DD2E RID: 56622 RVA: 0x0032A388 File Offset: 0x00328588
		[NullableContext(1)]
		public readonly IEnumerable<int> TaskListIter()
		{
			TeamParKOurCfg.<TaskListIter>d__34 <TaskListIter>d__ = new TeamParKOurCfg.<TaskListIter>d__34(-2);
			<TaskListIter>d__.<>3__<>4__this = this;
			return <TaskListIter>d__;
		}

		// Token: 0x04005255 RID: 21077
		private Table __p;
	}
}
