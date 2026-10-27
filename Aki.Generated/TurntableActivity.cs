using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117C RID: 4476
	public struct TurntableActivity : IFlatbufferObject
	{
		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600E5A8 RID: 58792 RVA: 0x0033D481 File Offset: 0x0033B681
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x0033D48E File Offset: 0x0033B68E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x0033D498 File Offset: 0x0033B698
		public static TurntableActivity GetRootAsTurntableActivity(ByteBuffer _bb)
		{
			return TurntableActivity.GetRootAsTurntableActivity(_bb, default(TurntableActivity));
		}

		// Token: 0x0600E5AB RID: 58795 RVA: 0x0033D4B4 File Offset: 0x0033B6B4
		public static TurntableActivity GetRootAsTurntableActivity(ByteBuffer _bb, TurntableActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x0033D4D1 File Offset: 0x0033B6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x0033D4E0 File Offset: 0x0033B6E0
		public TurntableActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600E5AE RID: 58798 RVA: 0x0033D4F0 File Offset: 0x0033B6F0
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

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x0033D52C File Offset: 0x0033B72C
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

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x0033D568 File Offset: 0x0033B768
		public int CoinQuestId
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

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600E5B1 RID: 58801 RVA: 0x0033D5A4 File Offset: 0x0033B7A4
		public string QuestDesc
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

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x0033D5DC File Offset: 0x0033B7DC
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x0033D5EC File Offset: 0x0033B7EC
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040052C2 RID: 21186
		private Table __p;
	}
}
