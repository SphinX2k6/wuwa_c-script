using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B1 RID: 4273
	public struct SignReward : IFlatbufferObject
	{
		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600D25C RID: 53852 RVA: 0x003103D5 File Offset: 0x0030E5D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x003103E2 File Offset: 0x0030E5E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x003103EC File Offset: 0x0030E5EC
		public static SignReward GetRootAsSignReward(ByteBuffer _bb)
		{
			return SignReward.GetRootAsSignReward(_bb, default(SignReward));
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x00310408 File Offset: 0x0030E608
		public static SignReward GetRootAsSignReward(ByteBuffer _bb, SignReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D260 RID: 53856 RVA: 0x00310425 File Offset: 0x0030E625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D261 RID: 53857 RVA: 0x00310434 File Offset: 0x0030E634
		public SignReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600D262 RID: 53858 RVA: 0x00310444 File Offset: 0x0030E644
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

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600D263 RID: 53859 RVA: 0x00310480 File Offset: 0x0030E680
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

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600D264 RID: 53860 RVA: 0x003104BC File Offset: 0x0030E6BC
		public int SignRewardGroup
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

		// Token: 0x040051C4 RID: 20932
		private Table __p;
	}
}
