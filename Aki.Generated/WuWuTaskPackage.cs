using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E1 RID: 4833
	public struct WuWuTaskPackage : IFlatbufferObject
	{
		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x0600F6F6 RID: 63222 RVA: 0x003710D5 File Offset: 0x0036F2D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x003710E2 File Offset: 0x0036F2E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x003710EC File Offset: 0x0036F2EC
		public static WuWuTaskPackage GetRootAsWuWuTaskPackage(ByteBuffer _bb)
		{
			return WuWuTaskPackage.GetRootAsWuWuTaskPackage(_bb, default(WuWuTaskPackage));
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x00371108 File Offset: 0x0036F308
		public static WuWuTaskPackage GetRootAsWuWuTaskPackage(ByteBuffer _bb, WuWuTaskPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x00371125 File Offset: 0x0036F325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x00371134 File Offset: 0x0036F334
		public WuWuTaskPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x0600F6FC RID: 63228 RVA: 0x00371144 File Offset: 0x0036F344
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

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x0600F6FD RID: 63229 RVA: 0x00371180 File Offset: 0x0036F380
		public int PreWrap
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

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x0600F6FE RID: 63230 RVA: 0x003711BC File Offset: 0x0036F3BC
		public int OpenDay
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

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x0600F6FF RID: 63231 RVA: 0x003711F8 File Offset: 0x0036F3F8
		public int DropId
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

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x0600F700 RID: 63232 RVA: 0x00371238 File Offset: 0x0036F438
		public string Title
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

		// Token: 0x0600F701 RID: 63233 RVA: 0x00371270 File Offset: 0x0036F470
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F702 RID: 63234 RVA: 0x00371280 File Offset: 0x0036F480
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x0600F703 RID: 63235 RVA: 0x00371298 File Offset: 0x0036F498
		public int DescGroupId
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

		// Token: 0x0400593B RID: 22843
		private Table __p;
	}
}
