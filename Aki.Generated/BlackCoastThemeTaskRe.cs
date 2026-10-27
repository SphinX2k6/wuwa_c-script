using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B38 RID: 2872
	public struct BlackCoastThemeTaskRe : IFlatbufferObject
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x001E46B8 File Offset: 0x001E28B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x001E46C5 File Offset: 0x001E28C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x001E46CC File Offset: 0x001E28CC
		public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb)
		{
			return BlackCoastThemeTaskRe.GetRootAsBlackCoastThemeTaskRe(_bb, default(BlackCoastThemeTaskRe));
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x001E46E8 File Offset: 0x001E28E8
		public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb, BlackCoastThemeTaskRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x001E4705 File Offset: 0x001E2905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x001E4714 File Offset: 0x001E2914
		public BlackCoastThemeTaskRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x001E4724 File Offset: 0x001E2924
		public int TaskId
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x001E4760 File Offset: 0x001E2960
		public int StageId
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x001E479C File Offset: 0x001E299C
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x001E47D3 File Offset: 0x001E29D3
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x001E47E2 File Offset: 0x001E29E2
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x001E47FC File Offset: 0x001E29FC
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x001E483C File Offset: 0x001E2A3C
		public int DropId
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

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x001E487C File Offset: 0x001E2A7C
		public int JumpId
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

		// Token: 0x04004B33 RID: 19251
		private Table __p;
	}
}
