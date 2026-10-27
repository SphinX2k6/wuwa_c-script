using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116A RID: 4458
	public struct TrapDefenseMonsterTag : IFlatbufferObject
	{
		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600E44D RID: 58445 RVA: 0x0033A2FC File Offset: 0x003384FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x0033A309 File Offset: 0x00338509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x0033A310 File Offset: 0x00338510
		public static TrapDefenseMonsterTag GetRootAsTrapDefenseMonsterTag(ByteBuffer _bb)
		{
			return TrapDefenseMonsterTag.GetRootAsTrapDefenseMonsterTag(_bb, default(TrapDefenseMonsterTag));
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x0033A32C File Offset: 0x0033852C
		public static TrapDefenseMonsterTag GetRootAsTrapDefenseMonsterTag(ByteBuffer _bb, TrapDefenseMonsterTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E451 RID: 58449 RVA: 0x0033A349 File Offset: 0x00338549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x0033A358 File Offset: 0x00338558
		public TrapDefenseMonsterTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600E453 RID: 58451 RVA: 0x0033A368 File Offset: 0x00338568
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

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600E454 RID: 58452 RVA: 0x0033A3A4 File Offset: 0x003385A4
		public string Icon
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

		// Token: 0x0600E455 RID: 58453 RVA: 0x0033A3DB File Offset: 0x003385DB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x0033A3EA File Offset: 0x003385EA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600E457 RID: 58455 RVA: 0x0033A404 File Offset: 0x00338604
		public string Name
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

		// Token: 0x0600E458 RID: 58456 RVA: 0x0033A43B File Offset: 0x0033863B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x0033A44A File Offset: 0x0033864A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B0 RID: 21168
		private Table __p;
	}
}
