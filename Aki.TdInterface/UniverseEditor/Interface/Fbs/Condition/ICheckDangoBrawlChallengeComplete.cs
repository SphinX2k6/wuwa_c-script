using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B5 RID: 18869
	public struct ICheckDangoBrawlChallengeComplete : IFlatbufferObject
	{
		// Token: 0x17008873 RID: 34931
		// (get) Token: 0x0601D752 RID: 120658 RVA: 0x00426755 File Offset: 0x00424955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D753 RID: 120659 RVA: 0x00426762 File Offset: 0x00424962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D754 RID: 120660 RVA: 0x0042676C File Offset: 0x0042496C
		public static ICheckDangoBrawlChallengeComplete GetRootAsICheckDangoBrawlChallengeComplete(ByteBuffer _bb)
		{
			return ICheckDangoBrawlChallengeComplete.GetRootAsICheckDangoBrawlChallengeComplete(_bb, default(ICheckDangoBrawlChallengeComplete));
		}

		// Token: 0x0601D755 RID: 120661 RVA: 0x00426788 File Offset: 0x00424988
		public static ICheckDangoBrawlChallengeComplete GetRootAsICheckDangoBrawlChallengeComplete(ByteBuffer _bb, ICheckDangoBrawlChallengeComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D756 RID: 120662 RVA: 0x004267A5 File Offset: 0x004249A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D757 RID: 120663 RVA: 0x004267B4 File Offset: 0x004249B4
		public ICheckDangoBrawlChallengeComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008874 RID: 34932
		// (get) Token: 0x0601D758 RID: 120664 RVA: 0x004267C4 File Offset: 0x004249C4
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008875 RID: 34933
		// (get) Token: 0x0601D759 RID: 120665 RVA: 0x00426800 File Offset: 0x00424A00
		public int ChallengeId
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

		// Token: 0x0601D75A RID: 120666 RVA: 0x0042683C File Offset: 0x00424A3C
		public static Offset<ICheckDangoBrawlChallengeComplete> CreateICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int ChallengeId = 0)
		{
			builder.StartTable(2);
			ICheckDangoBrawlChallengeComplete.AddChallengeId(builder, ChallengeId);
			ICheckDangoBrawlChallengeComplete.AddType(builder, Type);
			return ICheckDangoBrawlChallengeComplete.EndICheckDangoBrawlChallengeComplete(builder);
		}

		// Token: 0x0601D75B RID: 120667 RVA: 0x00426859 File Offset: 0x00424A59
		public static void StartICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D75C RID: 120668 RVA: 0x00426862 File Offset: 0x00424A62
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D75D RID: 120669 RVA: 0x0042686D File Offset: 0x00424A6D
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(1, challengeId, 0);
		}

		// Token: 0x0601D75E RID: 120670 RVA: 0x00426878 File Offset: 0x00424A78
		public static Offset<ICheckDangoBrawlChallengeComplete> EndICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoBrawlChallengeComplete>(builder.EndTable());
		}

		// Token: 0x0601D75F RID: 120671 RVA: 0x00426888 File Offset: 0x00424A88
		public ICheckDangoBrawlChallengeCompleteT UnPack()
		{
			ICheckDangoBrawlChallengeCompleteT checkDangoBrawlChallengeCompleteT = new ICheckDangoBrawlChallengeCompleteT();
			this.UnPackTo(checkDangoBrawlChallengeCompleteT);
			return checkDangoBrawlChallengeCompleteT;
		}

		// Token: 0x0601D760 RID: 120672 RVA: 0x004268A3 File Offset: 0x00424AA3
		public void UnPackTo(ICheckDangoBrawlChallengeCompleteT _o)
		{
			_o.Type = this.Type;
			_o.ChallengeId = this.ChallengeId;
		}

		// Token: 0x0601D761 RID: 120673 RVA: 0x004268C0 File Offset: 0x00424AC0
		public static Offset<ICheckDangoBrawlChallengeComplete> Pack(FlatBufferBuilder builder, ICheckDangoBrawlChallengeCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoBrawlChallengeComplete>);
			}
			return ICheckDangoBrawlChallengeComplete.CreateICheckDangoBrawlChallengeComplete(builder, _o.Type, _o.ChallengeId);
		}

		// Token: 0x0400D1DB RID: 53723
		private Table __p;
	}
}
