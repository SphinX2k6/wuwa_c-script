using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE0 RID: 3808
	public struct MatchThreeEliminate : IFlatbufferObject
	{
		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600988F RID: 39055 RVA: 0x0029F9E6 File Offset: 0x0029DBE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x0029F9F3 File Offset: 0x0029DBF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x0029F9FC File Offset: 0x0029DBFC
		public static MatchThreeEliminate GetRootAsMatchThreeEliminate(ByteBuffer _bb)
		{
			return MatchThreeEliminate.GetRootAsMatchThreeEliminate(_bb, default(MatchThreeEliminate));
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x0029FA18 File Offset: 0x0029DC18
		public static MatchThreeEliminate GetRootAsMatchThreeEliminate(ByteBuffer _bb, MatchThreeEliminate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x0029FA35 File Offset: 0x0029DC35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x0029FA44 File Offset: 0x0029DC44
		public MatchThreeEliminate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06009895 RID: 39061 RVA: 0x0029FA54 File Offset: 0x0029DC54
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

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06009896 RID: 39062 RVA: 0x0029FA90 File Offset: 0x0029DC90
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

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06009897 RID: 39063 RVA: 0x0029FACC File Offset: 0x0029DCCC
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

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06009898 RID: 39064 RVA: 0x0029FB08 File Offset: 0x0029DD08
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

		// Token: 0x06009899 RID: 39065 RVA: 0x0029FB48 File Offset: 0x0029DD48
		public int SpawnExtraComponents(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600989A RID: 39066 RVA: 0x0029FB88 File Offset: 0x0029DD88
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

		// Token: 0x0600989B RID: 39067 RVA: 0x0029FBB4 File Offset: 0x0029DDB4
		public Span<int> GetSpawnExtraComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x0029FBC4 File Offset: 0x0029DDC4
		public int[] GetSpawnExtraComponentsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x0029FBDC File Offset: 0x0029DDDC
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

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600989E RID: 39070 RVA: 0x0029FC1C File Offset: 0x0029DE1C
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

		// Token: 0x0600989F RID: 39071 RVA: 0x0029FC59 File Offset: 0x0029DE59
		[NullableContext(1)]
		public int[] SpawnExtraComponents()
		{
			return this.GetSpawnExtraComponentsArray();
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x0029FC61 File Offset: 0x0029DE61
		[NullableContext(1)]
		public IEnumerable<int> SpawnExtraComponentsIter()
		{
			MatchThreeEliminate.<SpawnExtraComponentsIter>d__26 <SpawnExtraComponentsIter>d__ = new MatchThreeEliminate.<SpawnExtraComponentsIter>d__26(-2);
			<SpawnExtraComponentsIter>d__.<>3__<>4__this = this;
			return <SpawnExtraComponentsIter>d__;
		}

		// Token: 0x04005480 RID: 21632
		private Table __p;
	}
}
