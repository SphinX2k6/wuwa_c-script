using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD4 RID: 3540
	public struct GameStatistic : IFlatbufferObject
	{
		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x00267D7C File Offset: 0x00265F7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x00267D89 File Offset: 0x00265F89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00267D90 File Offset: 0x00265F90
		public static GameStatistic GetRootAsGameStatistic(ByteBuffer _bb)
		{
			return GameStatistic.GetRootAsGameStatistic(_bb, default(GameStatistic));
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00267DAC File Offset: 0x00265FAC
		public static GameStatistic GetRootAsGameStatistic(ByteBuffer _bb, GameStatistic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x00267DC9 File Offset: 0x00265FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x00267DD8 File Offset: 0x00265FD8
		public GameStatistic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00267DE8 File Offset: 0x00265FE8
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00267E24 File Offset: 0x00266024
		public string GoogleGameKey
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

		// Token: 0x06007FA9 RID: 32681 RVA: 0x00267E5B File Offset: 0x0026605B
		public Span<byte> GetGoogleGameKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x00267E6A File Offset: 0x0026606A
		public byte[] GetGoogleGameKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06007FAB RID: 32683 RVA: 0x00267E84 File Offset: 0x00266084
		public string GooglePropertyName
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

		// Token: 0x06007FAC RID: 32684 RVA: 0x00267EBB File Offset: 0x002660BB
		public Span<byte> GetGooglePropertyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x00267ECA File Offset: 0x002660CA
		public byte[] GetGooglePropertyNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005345 RID: 21317
		private Table __p;
	}
}
