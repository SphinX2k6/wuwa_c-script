using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF4 RID: 3572
	public struct GuessJokerAiConfig : IFlatbufferObject
	{
		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x060081FB RID: 33275 RVA: 0x0026CDF2 File Offset: 0x0026AFF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x0026CDFF File Offset: 0x0026AFFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x0026CE08 File Offset: 0x0026B008
		public static GuessJokerAiConfig GetRootAsGuessJokerAiConfig(ByteBuffer _bb)
		{
			return GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(_bb, default(GuessJokerAiConfig));
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x0026CE24 File Offset: 0x0026B024
		public static GuessJokerAiConfig GetRootAsGuessJokerAiConfig(ByteBuffer _bb, GuessJokerAiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x0026CE41 File Offset: 0x0026B041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x0026CE50 File Offset: 0x0026B050
		public GuessJokerAiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06008201 RID: 33281 RVA: 0x0026CE60 File Offset: 0x0026B060
		public int RoleId
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

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06008202 RID: 33282 RVA: 0x0026CE9C File Offset: 0x0026B09C
		public int NpcId
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

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x0026CED8 File Offset: 0x0026B0D8
		public int ChairId
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

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06008204 RID: 33284 RVA: 0x0026CF14 File Offset: 0x0026B114
		public int GamePlayCameraId
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

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06008205 RID: 33285 RVA: 0x0026CF54 File Offset: 0x0026B154
		public int SelectRoleCameraId
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

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06008206 RID: 33286 RVA: 0x0026CF94 File Offset: 0x0026B194
		public int SettleCameraId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06008207 RID: 33287 RVA: 0x0026CFD4 File Offset: 0x0026B1D4
		public string UseSkillText
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x0026D00C File Offset: 0x0026B20C
		public Span<byte> GetUseSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x0026D01C File Offset: 0x0026B21C
		public byte[] GetUseSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x0600820A RID: 33290 RVA: 0x0026D034 File Offset: 0x0026B234
		public string GiveUpSkillText
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

		// Token: 0x0600820B RID: 33291 RVA: 0x0026D06C File Offset: 0x0026B26C
		public Span<byte> GetGiveUpSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0026D07C File Offset: 0x0026B27C
		public byte[] GetGiveUpSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400536A RID: 21354
		private Table __p;
	}
}
