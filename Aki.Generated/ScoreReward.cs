using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001189 RID: 4489
	public struct ScoreReward : IFlatbufferObject
	{
		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600D775 RID: 55157 RVA: 0x0032974C File Offset: 0x0032794C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D776 RID: 55158 RVA: 0x00329759 File Offset: 0x00327959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x00329760 File Offset: 0x00327960
		public static ScoreReward GetRootAsScoreReward(ByteBuffer _bb)
		{
			return ScoreReward.GetRootAsScoreReward(_bb, default(ScoreReward));
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x0032977C File Offset: 0x0032797C
		public static ScoreReward GetRootAsScoreReward(ByteBuffer _bb, ScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D779 RID: 55161 RVA: 0x00329799 File Offset: 0x00327999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D77A RID: 55162 RVA: 0x003297A8 File Offset: 0x003279A8
		public ScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600D77B RID: 55163 RVA: 0x003297B8 File Offset: 0x003279B8
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
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x003297F4 File Offset: 0x003279F4
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
		// (get) Token: 0x0600D77D RID: 55165 RVA: 0x00329830 File Offset: 0x00327A30
		public int Score
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

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600D77E RID: 55166 RVA: 0x0032986C File Offset: 0x00327A6C
		public int Reward
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

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600D77F RID: 55167 RVA: 0x003298AC File Offset: 0x00327AAC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D780 RID: 55168 RVA: 0x003298E4 File Offset: 0x00327AE4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x003298F4 File Offset: 0x00327AF4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400579A RID: 22426
		private Table __p;
	}
}
