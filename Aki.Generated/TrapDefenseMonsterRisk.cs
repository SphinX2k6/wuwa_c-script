using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001169 RID: 4457
	public struct TrapDefenseMonsterRisk : IFlatbufferObject
	{
		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600E43A RID: 58426 RVA: 0x0033A0D1 File Offset: 0x003382D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x0033A0DE File Offset: 0x003382DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E43C RID: 58428 RVA: 0x0033A0E8 File Offset: 0x003382E8
		public static TrapDefenseMonsterRisk GetRootAsTrapDefenseMonsterRisk(ByteBuffer _bb)
		{
			return TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(_bb, default(TrapDefenseMonsterRisk));
		}

		// Token: 0x0600E43D RID: 58429 RVA: 0x0033A104 File Offset: 0x00338304
		public static TrapDefenseMonsterRisk GetRootAsTrapDefenseMonsterRisk(ByteBuffer _bb, TrapDefenseMonsterRisk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E43E RID: 58430 RVA: 0x0033A121 File Offset: 0x00338321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x0033A130 File Offset: 0x00338330
		public TrapDefenseMonsterRisk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600E440 RID: 58432 RVA: 0x0033A140 File Offset: 0x00338340
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

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600E441 RID: 58433 RVA: 0x0033A17C File Offset: 0x0033837C
		public string Name
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

		// Token: 0x0600E442 RID: 58434 RVA: 0x0033A1B3 File Offset: 0x003383B3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x0033A1C2 File Offset: 0x003383C2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600E444 RID: 58436 RVA: 0x0033A1DC File Offset: 0x003383DC
		public string GridQualityPath
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

		// Token: 0x0600E445 RID: 58437 RVA: 0x0033A213 File Offset: 0x00338413
		public Span<byte> GetGridQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x0033A222 File Offset: 0x00338422
		public byte[] GetGridQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600E447 RID: 58439 RVA: 0x0033A23C File Offset: 0x0033843C
		public string DescQualityPath
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

		// Token: 0x0600E448 RID: 58440 RVA: 0x0033A274 File Offset: 0x00338474
		public Span<byte> GetDescQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x0033A284 File Offset: 0x00338484
		public byte[] GetDescQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600E44A RID: 58442 RVA: 0x0033A29C File Offset: 0x0033849C
		public string Icon
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

		// Token: 0x0600E44B RID: 58443 RVA: 0x0033A2D4 File Offset: 0x003384D4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x0033A2E4 File Offset: 0x003384E4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052AF RID: 21167
		private Table __p;
	}
}
