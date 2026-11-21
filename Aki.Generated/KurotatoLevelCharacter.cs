using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E88 RID: 3720
	public struct KurotatoLevelCharacter : IFlatbufferObject
	{
		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x0600905A RID: 36954 RVA: 0x0028E222 File Offset: 0x0028C422
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x0028E22F File Offset: 0x0028C42F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x0028E238 File Offset: 0x0028C438
		public static KurotatoLevelCharacter GetRootAsKurotatoLevelCharacter(ByteBuffer _bb)
		{
			return KurotatoLevelCharacter.GetRootAsKurotatoLevelCharacter(_bb, default(KurotatoLevelCharacter));
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x0028E254 File Offset: 0x0028C454
		public static KurotatoLevelCharacter GetRootAsKurotatoLevelCharacter(ByteBuffer _bb, KurotatoLevelCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0028E271 File Offset: 0x0028C471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0028E280 File Offset: 0x0028C480
		public KurotatoLevelCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x0028E290 File Offset: 0x0028C490
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

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x0028E2CC File Offset: 0x0028C4CC
		public int CharacterId
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

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x0028E308 File Offset: 0x0028C508
		public int LevelId
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

		// Token: 0x06009063 RID: 36963 RVA: 0x0028E344 File Offset: 0x0028C544
		public int InitItemIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x0028E384 File Offset: 0x0028C584
		public int InitItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x0028E3B0 File Offset: 0x0028C5B0
		public Span<int> GetInitItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x0028E3C0 File Offset: 0x0028C5C0
		public int[] GetInitItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x0028E3D8 File Offset: 0x0028C5D8
		public int InitWeaponIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06009068 RID: 36968 RVA: 0x0028E418 File Offset: 0x0028C618
		public int InitWeaponIdsLength
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

		// Token: 0x06009069 RID: 36969 RVA: 0x0028E444 File Offset: 0x0028C644
		public Span<int> GetInitWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0028E454 File Offset: 0x0028C654
		public int[] GetInitWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600906B RID: 36971 RVA: 0x0028E46C File Offset: 0x0028C66C
		[NullableContext(1)]
		public int[] InitItemIds()
		{
			return this.GetInitItemIdsArray();
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x0028E474 File Offset: 0x0028C674
		[NullableContext(1)]
		public IEnumerable<int> InitItemIdsIter()
		{
			KurotatoLevelCharacter.<InitItemIdsIter>d__25 <InitItemIdsIter>d__ = new KurotatoLevelCharacter.<InitItemIdsIter>d__25(-2);
			<InitItemIdsIter>d__.<>3__<>4__this = this;
			return <InitItemIdsIter>d__;
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x0028E489 File Offset: 0x0028C689
		[NullableContext(1)]
		public int[] InitWeaponIds()
		{
			return this.GetInitWeaponIdsArray();
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0028E491 File Offset: 0x0028C691
		[NullableContext(1)]
		public IEnumerable<int> InitWeaponIdsIter()
		{
			KurotatoLevelCharacter.<InitWeaponIdsIter>d__27 <InitWeaponIdsIter>d__ = new KurotatoLevelCharacter.<InitWeaponIdsIter>d__27(-2);
			<InitWeaponIdsIter>d__.<>3__<>4__this = this;
			return <InitWeaponIdsIter>d__;
		}

		// Token: 0x04005419 RID: 21529
		private Table __p;
	}
}
