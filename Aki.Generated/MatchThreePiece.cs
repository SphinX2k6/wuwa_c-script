using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE6 RID: 3814
	public struct MatchThreePiece : IFlatbufferObject
	{
		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x002A0D41 File Offset: 0x0029EF41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x002A0D4E File Offset: 0x0029EF4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x002A0D58 File Offset: 0x0029EF58
		public static MatchThreePiece GetRootAsMatchThreePiece(ByteBuffer _bb)
		{
			return MatchThreePiece.GetRootAsMatchThreePiece(_bb, default(MatchThreePiece));
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x002A0D74 File Offset: 0x0029EF74
		public static MatchThreePiece GetRootAsMatchThreePiece(ByteBuffer _bb, MatchThreePiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x002A0D91 File Offset: 0x0029EF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x002A0DA0 File Offset: 0x0029EFA0
		public MatchThreePiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x002A0DB0 File Offset: 0x0029EFB0
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

		// Token: 0x06009921 RID: 39201 RVA: 0x002A0DEC File Offset: 0x0029EFEC
		public int BornComponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06009922 RID: 39202 RVA: 0x002A0E2C File Offset: 0x0029F02C
		public int BornComponentsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x002A0E57 File Offset: 0x0029F057
		public Span<int> GetBornComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x002A0E66 File Offset: 0x0029F066
		public int[] GetBornComponentsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x002A0E80 File Offset: 0x0029F080
		public int Eliminates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06009926 RID: 39206 RVA: 0x002A0EC0 File Offset: 0x0029F0C0
		public int EliminatesLength
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

		// Token: 0x06009927 RID: 39207 RVA: 0x002A0EEB File Offset: 0x0029F0EB
		public Span<int> GetEliminatesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x002A0EFA File Offset: 0x0029F0FA
		public int[] GetEliminatesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06009929 RID: 39209 RVA: 0x002A0F14 File Offset: 0x0029F114
		public int Energy
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

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600992A RID: 39210 RVA: 0x002A0F54 File Offset: 0x0029F154
		public int Score
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x002A0F91 File Offset: 0x0029F191
		[NullableContext(1)]
		public int[] BornComponents()
		{
			return this.GetBornComponentsArray();
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x002A0F99 File Offset: 0x0029F199
		[NullableContext(1)]
		public IEnumerable<int> BornComponentsIter()
		{
			MatchThreePiece.<BornComponentsIter>d__25 <BornComponentsIter>d__ = new MatchThreePiece.<BornComponentsIter>d__25(-2);
			<BornComponentsIter>d__.<>3__<>4__this = this;
			return <BornComponentsIter>d__;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x002A0FAE File Offset: 0x0029F1AE
		[NullableContext(1)]
		public int[] Eliminates()
		{
			return this.GetEliminatesArray();
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x002A0FB6 File Offset: 0x0029F1B6
		[NullableContext(1)]
		public IEnumerable<int> EliminatesIter()
		{
			MatchThreePiece.<EliminatesIter>d__27 <EliminatesIter>d__ = new MatchThreePiece.<EliminatesIter>d__27(-2);
			<EliminatesIter>d__.<>3__<>4__this = this;
			return <EliminatesIter>d__;
		}

		// Token: 0x04005487 RID: 21639
		private Table __p;
	}
}
