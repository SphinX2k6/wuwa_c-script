using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFC RID: 3324
	public struct EdgeRunner : IFlatbufferObject
	{
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x0023E029 File Offset: 0x0023C229
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x0023E036 File Offset: 0x0023C236
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x0023E040 File Offset: 0x0023C240
		public static EdgeRunner GetRootAsEdgeRunner(ByteBuffer _bb)
		{
			return EdgeRunner.GetRootAsEdgeRunner(_bb, default(EdgeRunner));
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x0023E05C File Offset: 0x0023C25C
		public static EdgeRunner GetRootAsEdgeRunner(ByteBuffer _bb, EdgeRunner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x0023E079 File Offset: 0x0023C279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x0023E088 File Offset: 0x0023C288
		public EdgeRunner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06006CEF RID: 27887 RVA: 0x0023E098 File Offset: 0x0023C298
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

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x0023E0D4 File Offset: 0x0023C2D4
		public int ScoreItemId
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

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06006CF1 RID: 27889 RVA: 0x0023E110 File Offset: 0x0023C310
		public int QuestId
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x0023E14C File Offset: 0x0023C34C
		public int EndQuestId
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

		// Token: 0x0400523C RID: 21052
		private Table __p;
	}
}
