using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001155 RID: 4437
	public struct RoleTowerScoreReward : IFlatbufferObject
	{
		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600D2AB RID: 53931 RVA: 0x0031F1FD File Offset: 0x0031D3FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x0031F20A File Offset: 0x0031D40A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2AD RID: 53933 RVA: 0x0031F214 File Offset: 0x0031D414
		public static RoleTowerScoreReward GetRootAsRoleTowerScoreReward(ByteBuffer _bb)
		{
			return RoleTowerScoreReward.GetRootAsRoleTowerScoreReward(_bb, default(RoleTowerScoreReward));
		}

		// Token: 0x0600D2AE RID: 53934 RVA: 0x0031F230 File Offset: 0x0031D430
		public static RoleTowerScoreReward GetRootAsRoleTowerScoreReward(ByteBuffer _bb, RoleTowerScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x0031F24D File Offset: 0x0031D44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x0031F25C File Offset: 0x0031D45C
		public RoleTowerScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600D2B1 RID: 53937 RVA: 0x0031F26C File Offset: 0x0031D46C
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

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x0031F2A8 File Offset: 0x0031D4A8
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

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600D2B3 RID: 53939 RVA: 0x0031F2E4 File Offset: 0x0031D4E4
		public int NeedScore
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

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600D2B4 RID: 53940 RVA: 0x0031F320 File Offset: 0x0031D520
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

		// Token: 0x0400575C RID: 22364
		private Table __p;
	}
}
