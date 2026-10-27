using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006263 RID: 25187
	public struct IBvbSkipChallenge : IFlatbufferObject
	{
		// Token: 0x1700BBB3 RID: 48051
		// (get) Token: 0x0602B754 RID: 178004 RVA: 0x005FBC71 File Offset: 0x005F9E71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B755 RID: 178005 RVA: 0x005FBC7E File Offset: 0x005F9E7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B756 RID: 178006 RVA: 0x005FBC88 File Offset: 0x005F9E88
		public static IBvbSkipChallenge GetRootAsIBvbSkipChallenge(ByteBuffer _bb)
		{
			return IBvbSkipChallenge.GetRootAsIBvbSkipChallenge(_bb, default(IBvbSkipChallenge));
		}

		// Token: 0x0602B757 RID: 178007 RVA: 0x005FBCA4 File Offset: 0x005F9EA4
		public static IBvbSkipChallenge GetRootAsIBvbSkipChallenge(ByteBuffer _bb, IBvbSkipChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B758 RID: 178008 RVA: 0x005FBCC1 File Offset: 0x005F9EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B759 RID: 178009 RVA: 0x005FBCD0 File Offset: 0x005F9ED0
		public IBvbSkipChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBB4 RID: 48052
		// (get) Token: 0x0602B75A RID: 178010 RVA: 0x005FBCE0 File Offset: 0x005F9EE0
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

		// Token: 0x0602B75B RID: 178011 RVA: 0x005FBD1C File Offset: 0x005F9F1C
		public static Offset<IBvbSkipChallenge> CreateIBvbSkipChallenge(FlatBufferBuilder builder, int ChallengeId = 0)
		{
			builder.StartTable(1);
			IBvbSkipChallenge.AddChallengeId(builder, ChallengeId);
			return IBvbSkipChallenge.EndIBvbSkipChallenge(builder);
		}

		// Token: 0x0602B75C RID: 178012 RVA: 0x005FBD32 File Offset: 0x005F9F32
		public static void StartIBvbSkipChallenge(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B75D RID: 178013 RVA: 0x005FBD3B File Offset: 0x005F9F3B
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(0, challengeId, 0);
		}

		// Token: 0x0602B75E RID: 178014 RVA: 0x005FBD46 File Offset: 0x005F9F46
		public static Offset<IBvbSkipChallenge> EndIBvbSkipChallenge(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSkipChallenge>(builder.EndTable());
		}

		// Token: 0x0602B75F RID: 178015 RVA: 0x005FBD54 File Offset: 0x005F9F54
		public IBvbSkipChallengeT UnPack()
		{
			IBvbSkipChallengeT bvbSkipChallengeT = new IBvbSkipChallengeT();
			this.UnPackTo(bvbSkipChallengeT);
			return bvbSkipChallengeT;
		}

		// Token: 0x0602B760 RID: 178016 RVA: 0x005FBD6F File Offset: 0x005F9F6F
		public void UnPackTo(IBvbSkipChallengeT _o)
		{
			_o.ChallengeId = this.ChallengeId;
		}

		// Token: 0x0602B761 RID: 178017 RVA: 0x005FBD80 File Offset: 0x005F9F80
		public static Offset<IBvbSkipChallenge> Pack(FlatBufferBuilder builder, IBvbSkipChallengeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSkipChallenge>);
			}
			return IBvbSkipChallenge.CreateIBvbSkipChallenge(builder, _o.ChallengeId);
		}

		// Token: 0x040107BE RID: 67518
		private Table __p;
	}
}
