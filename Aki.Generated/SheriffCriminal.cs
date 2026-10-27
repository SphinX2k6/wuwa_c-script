using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109E RID: 4254
	public struct SheriffCriminal : IFlatbufferObject
	{
		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600D0C6 RID: 53446 RVA: 0x0030C8D4 File Offset: 0x0030AAD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x0030C8E1 File Offset: 0x0030AAE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x0030C8E8 File Offset: 0x0030AAE8
		public static SheriffCriminal GetRootAsSheriffCriminal(ByteBuffer _bb)
		{
			return SheriffCriminal.GetRootAsSheriffCriminal(_bb, default(SheriffCriminal));
		}

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x0030C904 File Offset: 0x0030AB04
		public static SheriffCriminal GetRootAsSheriffCriminal(ByteBuffer _bb, SheriffCriminal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x0030C921 File Offset: 0x0030AB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x0030C930 File Offset: 0x0030AB30
		public SheriffCriminal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600D0CC RID: 53452 RVA: 0x0030C940 File Offset: 0x0030AB40
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

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600D0CD RID: 53453 RVA: 0x0030C97C File Offset: 0x0030AB7C
		public int InitIdentityId
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

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x0030C9B8 File Offset: 0x0030ABB8
		public int SheriffAnomalyId
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

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600D0CF RID: 53455 RVA: 0x0030C9F4 File Offset: 0x0030ABF4
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

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600D0D0 RID: 53456 RVA: 0x0030CA34 File Offset: 0x0030AC34
		public int Priority
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

		// Token: 0x040051AC RID: 20908
		private Table __p;
	}
}
