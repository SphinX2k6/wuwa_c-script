using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B81 RID: 2945
	public struct CircumScoreReward : IFlatbufferObject
	{
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x001F6F05 File Offset: 0x001F5105
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x001F6F12 File Offset: 0x001F5112
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x001F6F1C File Offset: 0x001F511C
		public static CircumScoreReward GetRootAsCircumScoreReward(ByteBuffer _bb)
		{
			return CircumScoreReward.GetRootAsCircumScoreReward(_bb, default(CircumScoreReward));
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x001F6F38 File Offset: 0x001F5138
		public static CircumScoreReward GetRootAsCircumScoreReward(ByteBuffer _bb, CircumScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x001F6F55 File Offset: 0x001F5155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x001F6F64 File Offset: 0x001F5164
		public CircumScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x001F6F74 File Offset: 0x001F5174
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06005601 RID: 22017 RVA: 0x001F6FB0 File Offset: 0x001F51B0
		public int NeedScore
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x001F6FEC File Offset: 0x001F51EC
		public int DropGroup
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

		// Token: 0x04004B85 RID: 19333
		private Table __p;
	}
}
