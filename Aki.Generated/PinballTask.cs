using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101F RID: 4127
	public struct PinballTask : IFlatbufferObject
	{
		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x002E1AE6 File Offset: 0x002DFCE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x002E1AF3 File Offset: 0x002DFCF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x002E1AFC File Offset: 0x002DFCFC
		public static PinballTask GetRootAsPinballTask(ByteBuffer _bb)
		{
			return PinballTask.GetRootAsPinballTask(_bb, default(PinballTask));
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x002E1B18 File Offset: 0x002DFD18
		public static PinballTask GetRootAsPinballTask(ByteBuffer _bb, PinballTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x002E1B35 File Offset: 0x002DFD35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x002E1B44 File Offset: 0x002DFD44
		public PinballTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600B695 RID: 46741 RVA: 0x002E1B54 File Offset: 0x002DFD54
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

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x002E1B90 File Offset: 0x002DFD90
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

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0600B697 RID: 46743 RVA: 0x002E1BCC File Offset: 0x002DFDCC
		public int TaskTab
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

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600B698 RID: 46744 RVA: 0x002E1C08 File Offset: 0x002DFE08
		public int SortId
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

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600B699 RID: 46745 RVA: 0x002E1C48 File Offset: 0x002DFE48
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600B69A RID: 46746 RVA: 0x002E1C88 File Offset: 0x002DFE88
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

		// Token: 0x0600B69B RID: 46747 RVA: 0x002E1CC0 File Offset: 0x002DFEC0
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B69C RID: 46748 RVA: 0x002E1CD0 File Offset: 0x002DFED0
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600B69D RID: 46749 RVA: 0x002E1CE8 File Offset: 0x002DFEE8
		public int DropId
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

		// Token: 0x040055E9 RID: 21993
		private Table __p;
	}
}
