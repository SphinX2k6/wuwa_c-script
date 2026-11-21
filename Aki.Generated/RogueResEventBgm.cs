using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E9 RID: 4329
	public struct RogueResEventBgm : IFlatbufferObject
	{
		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600C889 RID: 51337 RVA: 0x00308338 File Offset: 0x00306538
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x00308345 File Offset: 0x00306545
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x0030834C File Offset: 0x0030654C
		public static RogueResEventBgm GetRootAsRogueResEventBgm(ByteBuffer _bb)
		{
			return RogueResEventBgm.GetRootAsRogueResEventBgm(_bb, default(RogueResEventBgm));
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x00308368 File Offset: 0x00306568
		public static RogueResEventBgm GetRootAsRogueResEventBgm(ByteBuffer _bb, RogueResEventBgm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x00308385 File Offset: 0x00306585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x00308394 File Offset: 0x00306594
		public RogueResEventBgm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600C88F RID: 51343 RVA: 0x003083A4 File Offset: 0x003065A4
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

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600C890 RID: 51344 RVA: 0x003083E0 File Offset: 0x003065E0
		public string BgmName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x00308417 File Offset: 0x00306617
		public Span<byte> GetBgmNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x00308426 File Offset: 0x00306626
		public byte[] GetBgmNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600C893 RID: 51347 RVA: 0x00308440 File Offset: 0x00306640
		public string BgmPath
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

		// Token: 0x0600C894 RID: 51348 RVA: 0x00308477 File Offset: 0x00306677
		public Span<byte> GetBgmPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x00308486 File Offset: 0x00306686
		public byte[] GetBgmPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040056D1 RID: 22225
		private Table __p;
	}
}
