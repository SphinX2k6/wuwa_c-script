using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123F RID: 4671
	public struct SurvivorsTask : IFlatbufferObject
	{
		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600E8FD RID: 59645 RVA: 0x00351E45 File Offset: 0x00350045
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x00351E52 File Offset: 0x00350052
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x00351E5C File Offset: 0x0035005C
		public static SurvivorsTask GetRootAsSurvivorsTask(ByteBuffer _bb)
		{
			return SurvivorsTask.GetRootAsSurvivorsTask(_bb, default(SurvivorsTask));
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x00351E78 File Offset: 0x00350078
		public static SurvivorsTask GetRootAsSurvivorsTask(ByteBuffer _bb, SurvivorsTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x00351E95 File Offset: 0x00350095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x00351EA4 File Offset: 0x003500A4
		public SurvivorsTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600E903 RID: 59651 RVA: 0x00351EB4 File Offset: 0x003500B4
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

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x00351EF0 File Offset: 0x003500F0
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

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600E905 RID: 59653 RVA: 0x00351F2C File Offset: 0x0035012C
		public int SortId
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

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600E906 RID: 59654 RVA: 0x00351F68 File Offset: 0x00350168
		public int PageType
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

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600E907 RID: 59655 RVA: 0x00351FA8 File Offset: 0x003501A8
		public string TaskName
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

		// Token: 0x0600E908 RID: 59656 RVA: 0x00351FE0 File Offset: 0x003501E0
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E909 RID: 59657 RVA: 0x00351FF0 File Offset: 0x003501F0
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x00352008 File Offset: 0x00350208
		public int DropId
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

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600E90B RID: 59659 RVA: 0x00352048 File Offset: 0x00350248
		public int JumpId
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

		// Token: 0x04005886 RID: 22662
		private Table __p;
	}
}
