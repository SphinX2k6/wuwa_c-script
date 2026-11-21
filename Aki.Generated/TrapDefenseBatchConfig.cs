using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128D RID: 4749
	public struct TrapDefenseBatchConfig : IFlatbufferObject
	{
		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x0036148D File Offset: 0x0035F68D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EFE7 RID: 61415 RVA: 0x0036149A File Offset: 0x0035F69A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EFE8 RID: 61416 RVA: 0x003614A4 File Offset: 0x0035F6A4
		public static TrapDefenseBatchConfig GetRootAsTrapDefenseBatchConfig(ByteBuffer _bb)
		{
			return TrapDefenseBatchConfig.GetRootAsTrapDefenseBatchConfig(_bb, default(TrapDefenseBatchConfig));
		}

		// Token: 0x0600EFE9 RID: 61417 RVA: 0x003614C0 File Offset: 0x0035F6C0
		public static TrapDefenseBatchConfig GetRootAsTrapDefenseBatchConfig(ByteBuffer _bb, TrapDefenseBatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EFEA RID: 61418 RVA: 0x003614DD File Offset: 0x0035F6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EFEB RID: 61419 RVA: 0x003614EC File Offset: 0x0035F6EC
		public TrapDefenseBatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x003614FC File Offset: 0x0035F6FC
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

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0600EFED RID: 61421 RVA: 0x00361538 File Offset: 0x0035F738
		public string SpawnMonsters
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

		// Token: 0x0600EFEE RID: 61422 RVA: 0x0036156F File Offset: 0x0035F76F
		public Span<byte> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EFEF RID: 61423 RVA: 0x0036157E File Offset: 0x0035F77E
		public byte[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0600EFF0 RID: 61424 RVA: 0x00361598 File Offset: 0x0035F798
		public string Splines
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

		// Token: 0x0600EFF1 RID: 61425 RVA: 0x003615CF File Offset: 0x0035F7CF
		public Span<byte> GetSplinesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EFF2 RID: 61426 RVA: 0x003615DE File Offset: 0x0035F7DE
		public byte[] GetSplinesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040058DF RID: 22751
		private Table __p;
	}
}
