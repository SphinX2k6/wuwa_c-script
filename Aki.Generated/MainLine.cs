using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECB RID: 3787
	public struct MainLine : IFlatbufferObject
	{
		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600968A RID: 38538 RVA: 0x0029B1C8 File Offset: 0x002993C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x0029B1D5 File Offset: 0x002993D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x0029B1DC File Offset: 0x002993DC
		public static MainLine GetRootAsMainLine(ByteBuffer _bb)
		{
			return MainLine.GetRootAsMainLine(_bb, default(MainLine));
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x0029B1F8 File Offset: 0x002993F8
		public static MainLine GetRootAsMainLine(ByteBuffer _bb, MainLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x0029B215 File Offset: 0x00299415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x0029B224 File Offset: 0x00299424
		public MainLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06009690 RID: 38544 RVA: 0x0029B234 File Offset: 0x00299434
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

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x0029B270 File Offset: 0x00299470
		public int TaskId
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

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06009692 RID: 38546 RVA: 0x0029B2AC File Offset: 0x002994AC
		public int PrevTaskId
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

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x0029B2E8 File Offset: 0x002994E8
		public string Icon
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

		// Token: 0x06009694 RID: 38548 RVA: 0x0029B320 File Offset: 0x00299520
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x0029B330 File Offset: 0x00299530
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06009696 RID: 38550 RVA: 0x0029B348 File Offset: 0x00299548
		public string UnlockTip
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

		// Token: 0x06009697 RID: 38551 RVA: 0x0029B380 File Offset: 0x00299580
		public Span<byte> GetUnlockTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x0029B390 File Offset: 0x00299590
		public byte[] GetUnlockTipArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x0029B3A8 File Offset: 0x002995A8
		public string TaskName
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

		// Token: 0x0600969A RID: 38554 RVA: 0x0029B3E0 File Offset: 0x002995E0
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x0029B3F0 File Offset: 0x002995F0
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600969C RID: 38556 RVA: 0x0029B408 File Offset: 0x00299608
		public int TaskType
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

		// Token: 0x04005467 RID: 21607
		private Table __p;
	}
}
