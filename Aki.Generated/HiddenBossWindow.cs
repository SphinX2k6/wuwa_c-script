using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D29 RID: 3369
	public struct HiddenBossWindow : IFlatbufferObject
	{
		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x00253E49 File Offset: 0x00252049
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x00253E56 File Offset: 0x00252056
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x00253E60 File Offset: 0x00252060
		public static HiddenBossWindow GetRootAsHiddenBossWindow(ByteBuffer _bb)
		{
			return HiddenBossWindow.GetRootAsHiddenBossWindow(_bb, default(HiddenBossWindow));
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x00253E7C File Offset: 0x0025207C
		public static HiddenBossWindow GetRootAsHiddenBossWindow(ByteBuffer _bb, HiddenBossWindow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x00253E99 File Offset: 0x00252099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x00253EA8 File Offset: 0x002520A8
		public HiddenBossWindow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x00253EB8 File Offset: 0x002520B8
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

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06007E73 RID: 32371 RVA: 0x00253EF4 File Offset: 0x002520F4
		public string BossName
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

		// Token: 0x06007E74 RID: 32372 RVA: 0x00253F2B File Offset: 0x0025212B
		public Span<byte> GetBossNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x00253F3A File Offset: 0x0025213A
		public byte[] GetBossNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x00253F54 File Offset: 0x00252154
		public int MarkId
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

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06007E77 RID: 32375 RVA: 0x00253F90 File Offset: 0x00252190
		public string IconRefPath
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

		// Token: 0x06007E78 RID: 32376 RVA: 0x00253FC8 File Offset: 0x002521C8
		public Span<byte> GetIconRefPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x00253FD8 File Offset: 0x002521D8
		public byte[] GetIconRefPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DA1 RID: 19873
		private Table __p;
	}
}
