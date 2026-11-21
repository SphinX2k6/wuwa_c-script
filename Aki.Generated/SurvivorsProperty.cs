using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001237 RID: 4663
	public struct SurvivorsProperty : IFlatbufferObject
	{
		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600E838 RID: 59448 RVA: 0x00350158 File Offset: 0x0034E358
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x00350165 File Offset: 0x0034E365
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E83A RID: 59450 RVA: 0x0035016C File Offset: 0x0034E36C
		public static SurvivorsProperty GetRootAsSurvivorsProperty(ByteBuffer _bb)
		{
			return SurvivorsProperty.GetRootAsSurvivorsProperty(_bb, default(SurvivorsProperty));
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x00350188 File Offset: 0x0034E388
		public static SurvivorsProperty GetRootAsSurvivorsProperty(ByteBuffer _bb, SurvivorsProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x003501A5 File Offset: 0x0034E3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E83D RID: 59453 RVA: 0x003501B4 File Offset: 0x0034E3B4
		public SurvivorsProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600E83E RID: 59454 RVA: 0x003501C4 File Offset: 0x0034E3C4
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

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600E83F RID: 59455 RVA: 0x00350200 File Offset: 0x0034E400
		public string Key
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

		// Token: 0x0600E840 RID: 59456 RVA: 0x00350237 File Offset: 0x0034E437
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E841 RID: 59457 RVA: 0x00350246 File Offset: 0x0034E446
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600E842 RID: 59458 RVA: 0x00350260 File Offset: 0x0034E460
		public string Name
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

		// Token: 0x0600E843 RID: 59459 RVA: 0x00350297 File Offset: 0x0034E497
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E844 RID: 59460 RVA: 0x003502A6 File Offset: 0x0034E4A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600E845 RID: 59461 RVA: 0x003502C0 File Offset: 0x0034E4C0
		public bool IsBasePermyriad
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600E846 RID: 59462 RVA: 0x00350300 File Offset: 0x0034E500
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600E847 RID: 59463 RVA: 0x00350340 File Offset: 0x0034E540
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600E848 RID: 59464 RVA: 0x00350380 File Offset: 0x0034E580
		public int Priority
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

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600E849 RID: 59465 RVA: 0x003503C0 File Offset: 0x0034E5C0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E84A RID: 59466 RVA: 0x003503F8 File Offset: 0x0034E5F8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E84B RID: 59467 RVA: 0x00350408 File Offset: 0x0034E608
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400587C RID: 22652
		private Table __p;
	}
}
