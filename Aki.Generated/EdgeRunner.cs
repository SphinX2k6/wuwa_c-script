using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C19 RID: 3097
	public struct EdgeRunner : IFlatbufferObject
	{
		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060066F6 RID: 26358 RVA: 0x0021EBB1 File Offset: 0x0021CDB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x0021EBBE File Offset: 0x0021CDBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x0021EBC8 File Offset: 0x0021CDC8
		public static EdgeRunner GetRootAsEdgeRunner(ByteBuffer _bb)
		{
			return EdgeRunner.GetRootAsEdgeRunner(_bb, default(EdgeRunner));
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x0021EBE4 File Offset: 0x0021CDE4
		public static EdgeRunner GetRootAsEdgeRunner(ByteBuffer _bb, EdgeRunner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x0021EC01 File Offset: 0x0021CE01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x0021EC10 File Offset: 0x0021CE10
		public EdgeRunner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060066FC RID: 26364 RVA: 0x0021EC20 File Offset: 0x0021CE20
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x0021EC5C File Offset: 0x0021CE5C
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x0021EC98 File Offset: 0x0021CE98
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x0021ECD4 File Offset: 0x0021CED4
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

		// Token: 0x04004C59 RID: 19545
		private Table __p;
	}
}
