using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB7 RID: 3255
	public struct FloroRanchTask : IFlatbufferObject
	{
		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x0023E02A File Offset: 0x0023C22A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x0023E037 File Offset: 0x0023C237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x0023E040 File Offset: 0x0023C240
		public static FloroRanchTask GetRootAsFloroRanchTask(ByteBuffer _bb)
		{
			return FloroRanchTask.GetRootAsFloroRanchTask(_bb, default(FloroRanchTask));
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x0023E05C File Offset: 0x0023C25C
		public static FloroRanchTask GetRootAsFloroRanchTask(ByteBuffer _bb, FloroRanchTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x0023E079 File Offset: 0x0023C279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x0023E088 File Offset: 0x0023C288
		public FloroRanchTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x0023E098 File Offset: 0x0023C298
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

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06007499 RID: 29849 RVA: 0x0023E0D4 File Offset: 0x0023C2D4
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

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x0023E110 File Offset: 0x0023C310
		public int Index
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

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x0023E14C File Offset: 0x0023C34C
		public string RewardName
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

		// Token: 0x0600749C RID: 29852 RVA: 0x0023E184 File Offset: 0x0023C384
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x0023E194 File Offset: 0x0023C394
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x0023E1AC File Offset: 0x0023C3AC
		public int PageType
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x0023E1EC File Offset: 0x0023C3EC
		public bool LimitTime
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x0023E22C File Offset: 0x0023C42C
		public int DelayTime
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

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x0023E26C File Offset: 0x0023C46C
		public int DropId
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x0023E2AC File Offset: 0x0023C4AC
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D24 RID: 19748
		private Table __p;
	}
}
