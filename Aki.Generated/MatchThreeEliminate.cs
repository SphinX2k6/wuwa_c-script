using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFB RID: 3579
	public struct MatchThreeEliminate : IFlatbufferObject
	{
		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x00281A09 File Offset: 0x0027FC09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x00281A16 File Offset: 0x0027FC16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x00281A20 File Offset: 0x0027FC20
		public static MatchThreeEliminate GetRootAsMatchThreeEliminate(ByteBuffer _bb)
		{
			return MatchThreeEliminate.GetRootAsMatchThreeEliminate(_bb, default(MatchThreeEliminate));
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00281A3C File Offset: 0x0027FC3C
		public static MatchThreeEliminate GetRootAsMatchThreeEliminate(ByteBuffer _bb, MatchThreeEliminate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x00281A59 File Offset: 0x0027FC59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00281A68 File Offset: 0x0027FC68
		public MatchThreeEliminate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x00281A78 File Offset: 0x0027FC78
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

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x0600927A RID: 37498 RVA: 0x00281AB4 File Offset: 0x0027FCB4
		public int Shape
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

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x00281AF0 File Offset: 0x0027FCF0
		public int MatchDir
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

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x0600927C RID: 37500 RVA: 0x00281B2C File Offset: 0x0027FD2C
		public int SpawnType
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

		// Token: 0x0600927D RID: 37501 RVA: 0x00281B6C File Offset: 0x0027FD6C
		public int SpawnExtraComponents(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600927E RID: 37502 RVA: 0x00281BAC File Offset: 0x0027FDAC
		public int SpawnExtraComponentsLength
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

		// Token: 0x0600927F RID: 37503 RVA: 0x00281BD8 File Offset: 0x0027FDD8
		public Span<int> GetSpawnExtraComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x00281BE8 File Offset: 0x0027FDE8
		public int[] GetSpawnExtraComponentsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x00281C00 File Offset: 0x0027FE00
		public int PieceEnergy
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

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06009282 RID: 37506 RVA: 0x00281C40 File Offset: 0x0027FE40
		public int PieceScore
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

		// Token: 0x06009283 RID: 37507 RVA: 0x00281C80 File Offset: 0x0027FE80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnExtraComponentsIter()或GetSpawnExtraComponentsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnExtraComponents()
		{
			MatchThreeEliminate matchThreeEliminate = this;
			return matchThreeEliminate.GetSpawnExtraComponentsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00281CA4 File Offset: 0x0027FEA4
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnExtraComponentsIter()
		{
			MatchThreeEliminate.<SpawnExtraComponentsIter>d__26 <SpawnExtraComponentsIter>d__ = new MatchThreeEliminate.<SpawnExtraComponentsIter>d__26(-2);
			<SpawnExtraComponentsIter>d__.<>3__<>4__this = this;
			return <SpawnExtraComponentsIter>d__;
		}

		// Token: 0x04004E9B RID: 20123
		private Table __p;
	}
}
