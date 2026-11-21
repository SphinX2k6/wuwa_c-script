using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B2 RID: 4786
	public struct TurntableActivity : IFlatbufferObject
	{
		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0600F316 RID: 62230 RVA: 0x00368279 File Offset: 0x00366479
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x00368286 File Offset: 0x00366486
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F318 RID: 62232 RVA: 0x00368290 File Offset: 0x00366490
		public static TurntableActivity GetRootAsTurntableActivity(ByteBuffer _bb)
		{
			return TurntableActivity.GetRootAsTurntableActivity(_bb, default(TurntableActivity));
		}

		// Token: 0x0600F319 RID: 62233 RVA: 0x003682AC File Offset: 0x003664AC
		public static TurntableActivity GetRootAsTurntableActivity(ByteBuffer _bb, TurntableActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F31A RID: 62234 RVA: 0x003682C9 File Offset: 0x003664C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F31B RID: 62235 RVA: 0x003682D8 File Offset: 0x003664D8
		public TurntableActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0600F31C RID: 62236 RVA: 0x003682E8 File Offset: 0x003664E8
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

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0600F31D RID: 62237 RVA: 0x00368324 File Offset: 0x00366524
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

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x0600F31E RID: 62238 RVA: 0x00368360 File Offset: 0x00366560
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

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x0600F31F RID: 62239 RVA: 0x0036839C File Offset: 0x0036659C
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

		// Token: 0x0600F320 RID: 62240 RVA: 0x003683D4 File Offset: 0x003665D4
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F321 RID: 62241 RVA: 0x003683E4 File Offset: 0x003665E4
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005905 RID: 22789
		private Table __p;
	}
}
