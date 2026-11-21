using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0F RID: 27407
	public struct ICommonTipMissionCompleteNew : IFlatbufferObject
	{
		// Token: 0x1700C946 RID: 51526
		// (get) Token: 0x0602F1F4 RID: 193012 RVA: 0x0066D149 File Offset: 0x0066B349
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1F5 RID: 193013 RVA: 0x0066D156 File Offset: 0x0066B356
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1F6 RID: 193014 RVA: 0x0066D160 File Offset: 0x0066B360
		public static ICommonTipMissionCompleteNew GetRootAsICommonTipMissionCompleteNew(ByteBuffer _bb)
		{
			return ICommonTipMissionCompleteNew.GetRootAsICommonTipMissionCompleteNew(_bb, default(ICommonTipMissionCompleteNew));
		}

		// Token: 0x0602F1F7 RID: 193015 RVA: 0x0066D17C File Offset: 0x0066B37C
		public static ICommonTipMissionCompleteNew GetRootAsICommonTipMissionCompleteNew(ByteBuffer _bb, ICommonTipMissionCompleteNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1F8 RID: 193016 RVA: 0x0066D199 File Offset: 0x0066B399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1F9 RID: 193017 RVA: 0x0066D1A8 File Offset: 0x0066B3A8
		public ICommonTipMissionCompleteNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C947 RID: 51527
		// (get) Token: 0x0602F1FA RID: 193018 RVA: 0x0066D1B8 File Offset: 0x0066B3B8
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

		// Token: 0x1700C948 RID: 51528
		// (get) Token: 0x0602F1FB RID: 193019 RVA: 0x0066D1F4 File Offset: 0x0066B3F4
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

		// Token: 0x1700C949 RID: 51529
		// (get) Token: 0x0602F1FC RID: 193020 RVA: 0x0066D230 File Offset: 0x0066B430
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

		// Token: 0x0602F1FD RID: 193021 RVA: 0x0066D267 File Offset: 0x0066B467
		public Span<byte> GetTipTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F1FE RID: 193022 RVA: 0x0066D276 File Offset: 0x0066B476
		public byte[] GetTipTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F1FF RID: 193023 RVA: 0x0066D284 File Offset: 0x0066B484
		public static Offset<ICommonTipMissionCompleteNew> CreateICommonTipMissionCompleteNew(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, EQuestCommonTipType QuestType = EQuestCommonTipType.Branch, StringOffset TipTextKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipMissionCompleteNew.AddTipTextKey(builder, TipTextKeyOffset);
			ICommonTipMissionCompleteNew.AddQuestType(builder, QuestType);
			ICommonTipMissionCompleteNew.AddType(builder, Type);
			return ICommonTipMissionCompleteNew.EndICommonTipMissionCompleteNew(builder);
		}

		// Token: 0x0602F200 RID: 193024 RVA: 0x0066D2A8 File Offset: 0x0066B4A8
		public static void StartICommonTipMissionCompleteNew(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F201 RID: 193025 RVA: 0x0066D2B1 File Offset: 0x0066B4B1
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F202 RID: 193026 RVA: 0x0066D2BC File Offset: 0x0066B4BC
		public static void AddQuestType(FlatBufferBuilder builder, EQuestCommonTipType questType)
		{
			builder.AddByte(1, (byte)questType, 0);
		}

		// Token: 0x0602F203 RID: 193027 RVA: 0x0066D2C7 File Offset: 0x0066B4C7
		public static void AddTipTextKey(FlatBufferBuilder builder, StringOffset tipTextKeyOffset)
		{
			builder.AddOffset(2, tipTextKeyOffset.Value, 0);
		}

		// Token: 0x0602F204 RID: 193028 RVA: 0x0066D2D7 File Offset: 0x0066B4D7
		public static Offset<ICommonTipMissionCompleteNew> EndICommonTipMissionCompleteNew(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipMissionCompleteNew>(builder.EndTable());
		}

		// Token: 0x0602F205 RID: 193029 RVA: 0x0066D2E4 File Offset: 0x0066B4E4
		public ICommonTipMissionCompleteNewT UnPack()
		{
			ICommonTipMissionCompleteNewT commonTipMissionCompleteNewT = new ICommonTipMissionCompleteNewT();
			this.UnPackTo(commonTipMissionCompleteNewT);
			return commonTipMissionCompleteNewT;
		}

		// Token: 0x0602F206 RID: 193030 RVA: 0x0066D2FF File Offset: 0x0066B4FF
		public void UnPackTo(ICommonTipMissionCompleteNewT _o)
		{
			_o.Type = this.Type;
			_o.QuestType = this.QuestType;
			_o.TipTextKey = this.TipTextKey;
		}

		// Token: 0x0602F207 RID: 193031 RVA: 0x0066D328 File Offset: 0x0066B528
		public static Offset<ICommonTipMissionCompleteNew> Pack(FlatBufferBuilder builder, ICommonTipMissionCompleteNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipMissionCompleteNew>);
			}
			StringOffset tipTextKeyOffset = (_o.TipTextKey == null) ? default(StringOffset) : builder.CreateString(_o.TipTextKey);
			return ICommonTipMissionCompleteNew.CreateICommonTipMissionCompleteNew(builder, _o.Type, _o.QuestType, tipTextKeyOffset);
		}

		// Token: 0x040118C3 RID: 71875
		private Table __p;
	}
}
