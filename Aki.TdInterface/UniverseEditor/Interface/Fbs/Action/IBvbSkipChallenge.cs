using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D4 RID: 26836
	public struct IBvbSkipChallenge : IFlatbufferObject
	{
		// Token: 0x1700C53B RID: 50491
		// (get) Token: 0x0602DEB5 RID: 188085 RVA: 0x00646A79 File Offset: 0x00644C79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEB6 RID: 188086 RVA: 0x00646A86 File Offset: 0x00644C86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEB7 RID: 188087 RVA: 0x00646A90 File Offset: 0x00644C90
		public static IBvbSkipChallenge GetRootAsIBvbSkipChallenge(ByteBuffer _bb)
		{
			return IBvbSkipChallenge.GetRootAsIBvbSkipChallenge(_bb, default(IBvbSkipChallenge));
		}

		// Token: 0x0602DEB8 RID: 188088 RVA: 0x00646AAC File Offset: 0x00644CAC
		public static IBvbSkipChallenge GetRootAsIBvbSkipChallenge(ByteBuffer _bb, IBvbSkipChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEB9 RID: 188089 RVA: 0x00646AC9 File Offset: 0x00644CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEBA RID: 188090 RVA: 0x00646AD8 File Offset: 0x00644CD8
		public IBvbSkipChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C53C RID: 50492
		// (get) Token: 0x0602DEBB RID: 188091 RVA: 0x00646AE8 File Offset: 0x00644CE8
		public int ChallengeId
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

		// Token: 0x0602DEBC RID: 188092 RVA: 0x00646B24 File Offset: 0x00644D24
		public static Offset<IBvbSkipChallenge> CreateIBvbSkipChallenge(FlatBufferBuilder builder, int ChallengeId = 0)
		{
			builder.StartTable(1);
			IBvbSkipChallenge.AddChallengeId(builder, ChallengeId);
			return IBvbSkipChallenge.EndIBvbSkipChallenge(builder);
		}

		// Token: 0x0602DEBD RID: 188093 RVA: 0x00646B3A File Offset: 0x00644D3A
		public static void StartIBvbSkipChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DEBE RID: 188094 RVA: 0x00646B43 File Offset: 0x00644D43
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(0, challengeId, 0);
		}

		// Token: 0x0602DEBF RID: 188095 RVA: 0x00646B4E File Offset: 0x00644D4E
		public static Offset<IBvbSkipChallenge> EndIBvbSkipChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSkipChallenge>(builder.EndTable());
		}

		// Token: 0x0602DEC0 RID: 188096 RVA: 0x00646B5C File Offset: 0x00644D5C
		public IBvbSkipChallengeT UnPack()
		{
			IBvbSkipChallengeT bvbSkipChallengeT = new IBvbSkipChallengeT();
			this.UnPackTo(bvbSkipChallengeT);
			return bvbSkipChallengeT;
		}

		// Token: 0x0602DEC1 RID: 188097 RVA: 0x00646B77 File Offset: 0x00644D77
		public void UnPackTo(IBvbSkipChallengeT _o)
		{
			_o.ChallengeId = this.ChallengeId;
		}

		// Token: 0x0602DEC2 RID: 188098 RVA: 0x00646B88 File Offset: 0x00644D88
		public static Offset<IBvbSkipChallenge> Pack(FlatBufferBuilder builder, IBvbSkipChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSkipChallenge>);
			}
			return IBvbSkipChallenge.CreateIBvbSkipChallenge(builder, _o.ChallengeId);
		}

		// Token: 0x040115D3 RID: 71123
		private Table __p;
	}
}
