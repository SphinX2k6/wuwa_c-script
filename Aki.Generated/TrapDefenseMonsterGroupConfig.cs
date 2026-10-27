using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001168 RID: 4456
	public struct TrapDefenseMonsterGroupConfig : IFlatbufferObject
	{
		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600E430 RID: 58416 RVA: 0x00339FC9 File Offset: 0x003381C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x00339FD6 File Offset: 0x003381D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x00339FE0 File Offset: 0x003381E0
		public static TrapDefenseMonsterGroupConfig GetRootAsTrapDefenseMonsterGroupConfig(ByteBuffer _bb)
		{
			return TrapDefenseMonsterGroupConfig.GetRootAsTrapDefenseMonsterGroupConfig(_bb, default(TrapDefenseMonsterGroupConfig));
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x00339FFC File Offset: 0x003381FC
		public static TrapDefenseMonsterGroupConfig GetRootAsTrapDefenseMonsterGroupConfig(ByteBuffer _bb, TrapDefenseMonsterGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x0033A019 File Offset: 0x00338219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x0033A028 File Offset: 0x00338228
		public TrapDefenseMonsterGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600E436 RID: 58422 RVA: 0x0033A038 File Offset: 0x00338238
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

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600E437 RID: 58423 RVA: 0x0033A074 File Offset: 0x00338274
		public string Monsters
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

		// Token: 0x0600E438 RID: 58424 RVA: 0x0033A0AB File Offset: 0x003382AB
		public Span<byte> GetMonstersBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E439 RID: 58425 RVA: 0x0033A0BA File Offset: 0x003382BA
		public byte[] GetMonstersArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052AE RID: 21166
		private Table __p;
	}
}
