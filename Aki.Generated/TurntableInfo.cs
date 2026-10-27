using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117E RID: 4478
	public struct TurntableInfo : IFlatbufferObject
	{
		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x0033D908 File Offset: 0x0033BB08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x0033D915 File Offset: 0x0033BB15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x0033D91C File Offset: 0x0033BB1C
		public static TurntableInfo GetRootAsTurntableInfo(ByteBuffer _bb)
		{
			return TurntableInfo.GetRootAsTurntableInfo(_bb, default(TurntableInfo));
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x0033D938 File Offset: 0x0033BB38
		public static TurntableInfo GetRootAsTurntableInfo(ByteBuffer _bb, TurntableInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x0033D955 File Offset: 0x0033BB55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x0033D964 File Offset: 0x0033BB64
		public TurntableInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x0033D974 File Offset: 0x0033BB74
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

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x0033D9B0 File Offset: 0x0033BBB0
		public int CostItemId
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

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x0033D9EC File Offset: 0x0033BBEC
		public int CostItemCount
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

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x0033DA28 File Offset: 0x0033BC28
		public int TurntableType
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

		// Token: 0x040052C5 RID: 21189
		private Table __p;
	}
}
