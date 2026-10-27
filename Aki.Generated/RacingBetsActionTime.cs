using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F87 RID: 3975
	public struct RacingBetsActionTime : IFlatbufferObject
	{
		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x002D4C44 File Offset: 0x002D2E44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x002D4C51 File Offset: 0x002D2E51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x002D4C58 File Offset: 0x002D2E58
		public static RacingBetsActionTime GetRootAsRacingBetsActionTime(ByteBuffer _bb)
		{
			return RacingBetsActionTime.GetRootAsRacingBetsActionTime(_bb, default(RacingBetsActionTime));
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x002D4C74 File Offset: 0x002D2E74
		public static RacingBetsActionTime GetRootAsRacingBetsActionTime(ByteBuffer _bb, RacingBetsActionTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x002D4C91 File Offset: 0x002D2E91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x002D4CA0 File Offset: 0x002D2EA0
		public RacingBetsActionTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600B7E7 RID: 47079 RVA: 0x002D4CB0 File Offset: 0x002D2EB0
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

		// Token: 0x04005055 RID: 20565
		private Table __p;
	}
}
