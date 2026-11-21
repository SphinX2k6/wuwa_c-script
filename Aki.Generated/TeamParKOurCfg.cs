using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124E RID: 4686
	public struct TeamParKOurCfg : IFlatbufferObject
	{
		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x003551A1 File Offset: 0x003533A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x003551AE File Offset: 0x003533AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x003551B8 File Offset: 0x003533B8
		public static TeamParKOurCfg GetRootAsTeamParKOurCfg(ByteBuffer _bb)
		{
			return TeamParKOurCfg.GetRootAsTeamParKOurCfg(_bb, default(TeamParKOurCfg));
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x003551D4 File Offset: 0x003533D4
		public static TeamParKOurCfg GetRootAsTeamParKOurCfg(ByteBuffer _bb, TeamParKOurCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x003551F1 File Offset: 0x003533F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x00355200 File Offset: 0x00353400
		public TeamParKOurCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x00355210 File Offset: 0x00353410
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

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x0035524C File Offset: 0x0035344C
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

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x00355288 File Offset: 0x00353488
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

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x003552C4 File Offset: 0x003534C4
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

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x00355304 File Offset: 0x00353504
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

		// Token: 0x0600EA6C RID: 60012 RVA: 0x0035533C File Offset: 0x0035353C
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x0035534C File Offset: 0x0035354C
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x00355364 File Offset: 0x00353564
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

		// Token: 0x0600EA6F RID: 60015 RVA: 0x0035539C File Offset: 0x0035359C
		public Span<byte> GetDescPicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x003553AC File Offset: 0x003535AC
		public byte[] GetDescPicPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x003553C4 File Offset: 0x003535C4
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

		// Token: 0x0600EA72 RID: 60018 RVA: 0x003553FC File Offset: 0x003535FC
		public Span<byte> GetRomePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x0035540C File Offset: 0x0035360C
		public byte[] GetRomePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x00355424 File Offset: 0x00353624
		public int TaskList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x00355464 File Offset: 0x00353664
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

		// Token: 0x0600EA76 RID: 60022 RVA: 0x00355490 File Offset: 0x00353690
		public Span<int> GetTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x003554A0 File Offset: 0x003536A0
		public int[] GetTaskListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x003554B8 File Offset: 0x003536B8
		[NullableContext(1)]
		public int[] TaskList()
		{
			return this.GetTaskListArray();
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x003554C0 File Offset: 0x003536C0
		[NullableContext(1)]
		public IEnumerable<int> TaskListIter()
		{
			TeamParKOurCfg.<TaskListIter>d__34 <TaskListIter>d__ = new TeamParKOurCfg.<TaskListIter>d__34(-2);
			<TaskListIter>d__.<>3__<>4__this = this;
			return <TaskListIter>d__;
		}

		// Token: 0x04005898 RID: 22680
		private Table __p;
	}
}
