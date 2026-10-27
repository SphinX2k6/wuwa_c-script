using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A4 RID: 25764
	public struct ICommonTipMissionCompleteNew : IFlatbufferObject
	{
		// Token: 0x1700BFB9 RID: 49081
		// (get) Token: 0x0602CA7A RID: 182906 RVA: 0x00621575 File Offset: 0x0061F775
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA7B RID: 182907 RVA: 0x00621582 File Offset: 0x0061F782
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA7C RID: 182908 RVA: 0x0062158C File Offset: 0x0061F78C
		public static ICommonTipMissionCompleteNew GetRootAsICommonTipMissionCompleteNew(ByteBuffer _bb)
		{
			return ICommonTipMissionCompleteNew.GetRootAsICommonTipMissionCompleteNew(_bb, default(ICommonTipMissionCompleteNew));
		}

		// Token: 0x0602CA7D RID: 182909 RVA: 0x006215A8 File Offset: 0x0061F7A8
		public static ICommonTipMissionCompleteNew GetRootAsICommonTipMissionCompleteNew(ByteBuffer _bb, ICommonTipMissionCompleteNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA7E RID: 182910 RVA: 0x006215C5 File Offset: 0x0061F7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA7F RID: 182911 RVA: 0x006215D4 File Offset: 0x0061F7D4
		public ICommonTipMissionCompleteNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFBA RID: 49082
		// (get) Token: 0x0602CA80 RID: 182912 RVA: 0x006215E4 File Offset: 0x0061F7E4
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFBB RID: 49083
		// (get) Token: 0x0602CA81 RID: 182913 RVA: 0x00621620 File Offset: 0x0061F820
		public EQuestCommonTipType QuestType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EQuestCommonTipType.Branch;
				}
				return (EQuestCommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFBC RID: 49084
		// (get) Token: 0x0602CA82 RID: 182914 RVA: 0x0062165C File Offset: 0x0061F85C
		public string TipTextKey
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA83 RID: 182915 RVA: 0x00621693 File Offset: 0x0061F893
		public Span<byte> GetTipTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602CA84 RID: 182916 RVA: 0x006216A2 File Offset: 0x0061F8A2
		public byte[] GetTipTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602CA85 RID: 182917 RVA: 0x006216B0 File Offset: 0x0061F8B0
		public static Offset<ICommonTipMissionCompleteNew> CreateICommonTipMissionCompleteNew(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, EQuestCommonTipType QuestType = EQuestCommonTipType.Branch, StringOffset TipTextKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipMissionCompleteNew.AddTipTextKey(builder, TipTextKeyOffset);
			ICommonTipMissionCompleteNew.AddQuestType(builder, QuestType);
			ICommonTipMissionCompleteNew.AddType(builder, Type);
			return ICommonTipMissionCompleteNew.EndICommonTipMissionCompleteNew(builder);
		}

		// Token: 0x0602CA86 RID: 182918 RVA: 0x006216D4 File Offset: 0x0061F8D4
		public static void StartICommonTipMissionCompleteNew(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CA87 RID: 182919 RVA: 0x006216DD File Offset: 0x0061F8DD
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA88 RID: 182920 RVA: 0x006216E8 File Offset: 0x0061F8E8
		public static void AddQuestType(FlatBufferBuilder builder, EQuestCommonTipType questType)
		{
			builder.AddByte(1, (byte)questType, 0);
		}

		// Token: 0x0602CA89 RID: 182921 RVA: 0x006216F3 File Offset: 0x0061F8F3
		public static void AddTipTextKey(FlatBufferBuilder builder, StringOffset tipTextKeyOffset)
		{
			builder.AddOffset(2, tipTextKeyOffset.Value, 0);
		}

		// Token: 0x0602CA8A RID: 182922 RVA: 0x00621703 File Offset: 0x0061F903
		public static Offset<ICommonTipMissionCompleteNew> EndICommonTipMissionCompleteNew(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipMissionCompleteNew>(builder.EndTable());
		}

		// Token: 0x0602CA8B RID: 182923 RVA: 0x00621710 File Offset: 0x0061F910
		public ICommonTipMissionCompleteNewT UnPack()
		{
			ICommonTipMissionCompleteNewT commonTipMissionCompleteNewT = new ICommonTipMissionCompleteNewT();
			this.UnPackTo(commonTipMissionCompleteNewT);
			return commonTipMissionCompleteNewT;
		}

		// Token: 0x0602CA8C RID: 182924 RVA: 0x0062172B File Offset: 0x0061F92B
		public void UnPackTo(ICommonTipMissionCompleteNewT _o)
		{
			_o.Type = this.Type;
			_o.QuestType = this.QuestType;
			_o.TipTextKey = this.TipTextKey;
		}

		// Token: 0x0602CA8D RID: 182925 RVA: 0x00621754 File Offset: 0x0061F954
		public static Offset<ICommonTipMissionCompleteNew> Pack(FlatBufferBuilder builder, ICommonTipMissionCompleteNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipMissionCompleteNew>);
			}
			StringOffset tipTextKeyOffset = (_o.TipTextKey == null) ? default(StringOffset) : builder.CreateString(_o.TipTextKey);
			return ICommonTipMissionCompleteNew.CreateICommonTipMissionCompleteNew(builder, _o.Type, _o.QuestType, tipTextKeyOffset);
		}

		// Token: 0x04010AB2 RID: 68274
		private Table __p;
	}
}
