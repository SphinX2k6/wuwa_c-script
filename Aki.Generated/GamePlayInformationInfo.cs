using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEC RID: 3308
	public struct GamePlayInformationInfo : IFlatbufferObject
	{
		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x002488C9 File Offset: 0x00246AC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x002488D6 File Offset: 0x00246AD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x002488E0 File Offset: 0x00246AE0
		public static GamePlayInformationInfo GetRootAsGamePlayInformationInfo(ByteBuffer _bb)
		{
			return GamePlayInformationInfo.GetRootAsGamePlayInformationInfo(_bb, default(GamePlayInformationInfo));
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x002488FC File Offset: 0x00246AFC
		public static GamePlayInformationInfo GetRootAsGamePlayInformationInfo(ByteBuffer _bb, GamePlayInformationInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00248919 File Offset: 0x00246B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00248928 File Offset: 0x00246B28
		public GamePlayInformationInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x0600794F RID: 31055 RVA: 0x00248938 File Offset: 0x00246B38
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06007950 RID: 31056 RVA: 0x00248974 File Offset: 0x00246B74
		public int Type
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

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06007951 RID: 31057 RVA: 0x002489B0 File Offset: 0x00246BB0
		public string Info
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

		// Token: 0x06007952 RID: 31058 RVA: 0x002489E7 File Offset: 0x00246BE7
		public Span<byte> GetInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x002489F6 File Offset: 0x00246BF6
		public byte[] GetInfoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D5D RID: 19805
		private Table __p;
	}
}
