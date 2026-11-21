using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E6F RID: 20079
	public struct ICheckDangoBrawlChallengeComplete : IFlatbufferObject
	{
		// Token: 0x17008F35 RID: 36661
		// (get) Token: 0x0601F191 RID: 127377 RVA: 0x00456E9D File Offset: 0x0045509D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F192 RID: 127378 RVA: 0x00456EAA File Offset: 0x004550AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F193 RID: 127379 RVA: 0x00456EB4 File Offset: 0x004550B4
		public static ICheckDangoBrawlChallengeComplete GetRootAsICheckDangoBrawlChallengeComplete(ByteBuffer _bb)
		{
			return ICheckDangoBrawlChallengeComplete.GetRootAsICheckDangoBrawlChallengeComplete(_bb, default(ICheckDangoBrawlChallengeComplete));
		}

		// Token: 0x0601F194 RID: 127380 RVA: 0x00456ED0 File Offset: 0x004550D0
		public static ICheckDangoBrawlChallengeComplete GetRootAsICheckDangoBrawlChallengeComplete(ByteBuffer _bb, ICheckDangoBrawlChallengeComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F195 RID: 127381 RVA: 0x00456EED File Offset: 0x004550ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F196 RID: 127382 RVA: 0x00456EFC File Offset: 0x004550FC
		public ICheckDangoBrawlChallengeComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F36 RID: 36662
		// (get) Token: 0x0601F197 RID: 127383 RVA: 0x00456F0C File Offset: 0x0045510C
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

		// Token: 0x17008F37 RID: 36663
		// (get) Token: 0x0601F198 RID: 127384 RVA: 0x00456F48 File Offset: 0x00455148
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

		// Token: 0x0601F199 RID: 127385 RVA: 0x00456F84 File Offset: 0x00455184
		public static Offset<ICheckDangoBrawlChallengeComplete> CreateICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int ChallengeId = 0)
		{
			builder.StartTable(2);
			ICheckDangoBrawlChallengeComplete.AddChallengeId(builder, ChallengeId);
			ICheckDangoBrawlChallengeComplete.AddType(builder, Type);
			return ICheckDangoBrawlChallengeComplete.EndICheckDangoBrawlChallengeComplete(builder);
		}

		// Token: 0x0601F19A RID: 127386 RVA: 0x00456FA1 File Offset: 0x004551A1
		public static void StartICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F19B RID: 127387 RVA: 0x00456FAA File Offset: 0x004551AA
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F19C RID: 127388 RVA: 0x00456FB5 File Offset: 0x004551B5
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(1, challengeId, 0);
		}

		// Token: 0x0601F19D RID: 127389 RVA: 0x00456FC0 File Offset: 0x004551C0
		public static Offset<ICheckDangoBrawlChallengeComplete> EndICheckDangoBrawlChallengeComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoBrawlChallengeComplete>(builder.EndTable());
		}

		// Token: 0x0601F19E RID: 127390 RVA: 0x00456FD0 File Offset: 0x004551D0
		public ICheckDangoBrawlChallengeCompleteT UnPack()
		{
			ICheckDangoBrawlChallengeCompleteT checkDangoBrawlChallengeCompleteT = new ICheckDangoBrawlChallengeCompleteT();
			this.UnPackTo(checkDangoBrawlChallengeCompleteT);
			return checkDangoBrawlChallengeCompleteT;
		}

		// Token: 0x0601F19F RID: 127391 RVA: 0x00456FEB File Offset: 0x004551EB
		public void UnPackTo(ICheckDangoBrawlChallengeCompleteT _o)
		{
			_o.Type = this.Type;
			_o.ChallengeId = this.ChallengeId;
		}

		// Token: 0x0601F1A0 RID: 127392 RVA: 0x00457008 File Offset: 0x00455208
		public static Offset<ICheckDangoBrawlChallengeComplete> Pack(FlatBufferBuilder builder, ICheckDangoBrawlChallengeCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoBrawlChallengeComplete>);
			}
			return ICheckDangoBrawlChallengeComplete.CreateICheckDangoBrawlChallengeComplete(builder, _o.Type, _o.ChallengeId);
		}

		// Token: 0x0400DCA7 RID: 56487
		private Table __p;
	}
}
