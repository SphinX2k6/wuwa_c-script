using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7E RID: 3710
	public struct KurotatoDeathrattle : IFlatbufferObject
	{
		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06008F34 RID: 36660 RVA: 0x0028B99B File Offset: 0x00289B9B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0028B9A8 File Offset: 0x00289BA8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0028B9B0 File Offset: 0x00289BB0
		public static KurotatoDeathrattle GetRootAsKurotatoDeathrattle(ByteBuffer _bb)
		{
			return KurotatoDeathrattle.GetRootAsKurotatoDeathrattle(_bb, default(KurotatoDeathrattle));
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0028B9CC File Offset: 0x00289BCC
		public static KurotatoDeathrattle GetRootAsKurotatoDeathrattle(ByteBuffer _bb, KurotatoDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0028B9E9 File Offset: 0x00289BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0028B9F8 File Offset: 0x00289BF8
		public KurotatoDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06008F3A RID: 36666 RVA: 0x0028BA08 File Offset: 0x00289C08
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

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06008F3B RID: 36667 RVA: 0x0028BA44 File Offset: 0x00289C44
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0028BA80 File Offset: 0x00289C80
		public int SpawnDrops(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x0028BAC0 File Offset: 0x00289CC0
		public int SpawnDropsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0028BAEB File Offset: 0x00289CEB
		public Span<int> GetSpawnDropsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x0028BAFA File Offset: 0x00289CFA
		public int[] GetSpawnDropsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x0028BB14 File Offset: 0x00289D14
		public int SpawnDropProbability
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x0028BB54 File Offset: 0x00289D54
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06008F42 RID: 36674 RVA: 0x0028BB94 File Offset: 0x00289D94
		public int SpawnMonstersLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x0028BBC0 File Offset: 0x00289DC0
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x0028BBD0 File Offset: 0x00289DD0
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06008F45 RID: 36677 RVA: 0x0028BBE8 File Offset: 0x00289DE8
		public int SpawnEntityRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06008F46 RID: 36678 RVA: 0x0028BC28 File Offset: 0x00289E28
		public float SpawnEntityDelay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x0028BC69 File Offset: 0x00289E69
		[NullableContext(1)]
		public int[] SpawnDrops()
		{
			return this.GetSpawnDropsArray();
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x0028BC71 File Offset: 0x00289E71
		[NullableContext(1)]
		public IEnumerable<int> SpawnDropsIter()
		{
			KurotatoDeathrattle.<SpawnDropsIter>d__29 <SpawnDropsIter>d__ = new KurotatoDeathrattle.<SpawnDropsIter>d__29(-2);
			<SpawnDropsIter>d__.<>3__<>4__this = this;
			return <SpawnDropsIter>d__;
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x0028BC86 File Offset: 0x00289E86
		[NullableContext(1)]
		public int[] SpawnMonsters()
		{
			return this.GetSpawnMonstersArray();
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0028BC8E File Offset: 0x00289E8E
		[NullableContext(1)]
		public IEnumerable<int> SpawnMonstersIter()
		{
			KurotatoDeathrattle.<SpawnMonstersIter>d__31 <SpawnMonstersIter>d__ = new KurotatoDeathrattle.<SpawnMonstersIter>d__31(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x0400540E RID: 21518
		private Table __p;
	}
}
