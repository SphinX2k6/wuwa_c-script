using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AC RID: 4524
	public struct SignReward : IFlatbufferObject
	{
		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x0032F991 File Offset: 0x0032DB91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x0032F99E File Offset: 0x0032DB9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x0032F9A8 File Offset: 0x0032DBA8
		public static SignReward GetRootAsSignReward(ByteBuffer _bb)
		{
			return SignReward.GetRootAsSignReward(_bb, default(SignReward));
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x0032F9C4 File Offset: 0x0032DBC4
		public static SignReward GetRootAsSignReward(ByteBuffer _bb, SignReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA3D RID: 55869 RVA: 0x0032F9E1 File Offset: 0x0032DBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA3E RID: 55870 RVA: 0x0032F9F0 File Offset: 0x0032DBF0
		public SignReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x0032FA00 File Offset: 0x0032DC00
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

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600DA40 RID: 55872 RVA: 0x0032FA3C File Offset: 0x0032DC3C
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

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600DA41 RID: 55873 RVA: 0x0032FA78 File Offset: 0x0032DC78
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

		// Token: 0x040057C3 RID: 22467
		private Table __p;
	}
}
