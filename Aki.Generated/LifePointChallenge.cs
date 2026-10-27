using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC6 RID: 3526
	public struct LifePointChallenge : IFlatbufferObject
	{
		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x00277164 File Offset: 0x00275364
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x00277171 File Offset: 0x00275371
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x00277178 File Offset: 0x00275378
		public static LifePointChallenge GetRootAsLifePointChallenge(ByteBuffer _bb)
		{
			return LifePointChallenge.GetRootAsLifePointChallenge(_bb, default(LifePointChallenge));
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x00277194 File Offset: 0x00275394
		public static LifePointChallenge GetRootAsLifePointChallenge(ByteBuffer _bb, LifePointChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x002771B1 File Offset: 0x002753B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x002771C0 File Offset: 0x002753C0
		public LifePointChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x002771D0 File Offset: 0x002753D0
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

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06008DCF RID: 36303 RVA: 0x0027720C File Offset: 0x0027540C
		public int GroupId
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

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x00277248 File Offset: 0x00275448
		public int Difficulty
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

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06008DD1 RID: 36305 RVA: 0x00277284 File Offset: 0x00275484
		public string SubTitle
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

		// Token: 0x06008DD2 RID: 36306 RVA: 0x002772BC File Offset: 0x002754BC
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x002772CC File Offset: 0x002754CC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06008DD4 RID: 36308 RVA: 0x002772E4 File Offset: 0x002754E4
		public string DifficultTexture
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

		// Token: 0x06008DD5 RID: 36309 RVA: 0x0027731C File Offset: 0x0027551C
		public Span<byte> GetDifficultTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x0027732C File Offset: 0x0027552C
		public byte[] GetDifficultTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06008DD7 RID: 36311 RVA: 0x00277344 File Offset: 0x00275544
		public int ActivityId
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

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x00277384 File Offset: 0x00275584
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x002773C4 File Offset: 0x002755C4
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x00277404 File Offset: 0x00275604
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x00277444 File Offset: 0x00275644
		public string Name
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x0027747C File Offset: 0x0027567C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x0027748C File Offset: 0x0027568C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x002774A4 File Offset: 0x002756A4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x002774DC File Offset: 0x002756DC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x002774EC File Offset: 0x002756EC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E5C RID: 20060
		private Table __p;
	}
}
