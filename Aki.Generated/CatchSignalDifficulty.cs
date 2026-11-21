using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C41 RID: 3137
	public struct CatchSignalDifficulty : IFlatbufferObject
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x0020F481 File Offset: 0x0020D681
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x0020F48E File Offset: 0x0020D68E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0020F498 File Offset: 0x0020D698
		public static CatchSignalDifficulty GetRootAsCatchSignalDifficulty(ByteBuffer _bb)
		{
			return CatchSignalDifficulty.GetRootAsCatchSignalDifficulty(_bb, default(CatchSignalDifficulty));
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0020F4B4 File Offset: 0x0020D6B4
		public static CatchSignalDifficulty GetRootAsCatchSignalDifficulty(ByteBuffer _bb, CatchSignalDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0020F4D1 File Offset: 0x0020D6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0020F4E0 File Offset: 0x0020D6E0
		public CatchSignalDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x0020F4F0 File Offset: 0x0020D6F0
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x0020F52C File Offset: 0x0020D72C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0020F563 File Offset: 0x0020D763
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0020F572 File Offset: 0x0020D772
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06005833 RID: 22579 RVA: 0x0020F58C File Offset: 0x0020D78C
		public float SpeedRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06005834 RID: 22580 RVA: 0x0020F5CC File Offset: 0x0020D7CC
		public int TapTimeWindow
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x0020F60C File Offset: 0x0020D80C
		public int PressTimeWindow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x0020F64C File Offset: 0x0020D84C
		public int ReleaseTimeWindow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x0020F68C File Offset: 0x0020D88C
		public int TargetCompletion
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 80;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005141 RID: 20801
		private Table __p;
	}
}
