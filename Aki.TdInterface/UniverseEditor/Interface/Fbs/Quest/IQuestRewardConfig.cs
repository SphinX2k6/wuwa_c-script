using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004010 RID: 16400
	public struct IQuestRewardConfig : IFlatbufferObject
	{
		// Token: 0x1700733D RID: 29501
		// (get) Token: 0x06017AB8 RID: 96952 RVA: 0x00369FEF File Offset: 0x003681EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AB9 RID: 96953 RVA: 0x00369FFC File Offset: 0x003681FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017ABA RID: 96954 RVA: 0x0036A004 File Offset: 0x00368204
		public static IQuestRewardConfig GetRootAsIQuestRewardConfig(ByteBuffer _bb)
		{
			return IQuestRewardConfig.GetRootAsIQuestRewardConfig(_bb, default(IQuestRewardConfig));
		}

		// Token: 0x06017ABB RID: 96955 RVA: 0x0036A020 File Offset: 0x00368220
		public static IQuestRewardConfig GetRootAsIQuestRewardConfig(ByteBuffer _bb, IQuestRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017ABC RID: 96956 RVA: 0x0036A03D File Offset: 0x0036823D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017ABD RID: 96957 RVA: 0x0036A04C File Offset: 0x0036824C
		public IQuestRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700733E RID: 29502
		// (get) Token: 0x06017ABE RID: 96958 RVA: 0x0036A05C File Offset: 0x0036825C
		public int RewardId
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

		// Token: 0x1700733F RID: 29503
		// (get) Token: 0x06017ABF RID: 96959 RVA: 0x0036A098 File Offset: 0x00368298
		public EItemGetUiType RewardGetUiType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007340 RID: 29504
		// (get) Token: 0x06017AC0 RID: 96960 RVA: 0x0036A0D4 File Offset: 0x003682D4
		public IItemGetUiConfigSpecialQuest? UiConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IItemGetUiConfigSpecialQuest?(default(IItemGetUiConfigSpecialQuest).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007341 RID: 29505
		// (get) Token: 0x06017AC1 RID: 96961 RVA: 0x0036A134 File Offset: 0x00368334
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017AC2 RID: 96962 RVA: 0x0036A171 File Offset: 0x00368371
		public static Offset<IQuestRewardConfig> CreateIQuestRewardConfig(FlatBufferBuilder builder, int RewardId = 0, EItemGetUiType RewardGetUiType = EItemGetUiType.None, Offset<IItemGetUiConfigSpecialQuest> UiConfigOffset = default(Offset<IItemGetUiConfigSpecialQuest>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestRewardConfig.AddUiConfig(builder, UiConfigOffset);
			IQuestRewardConfig.AddRewardId(builder, RewardId);
			IQuestRewardConfig.AddNullMask(builder, NullMask);
			IQuestRewardConfig.AddRewardGetUiType(builder, RewardGetUiType);
			return IQuestRewardConfig.EndIQuestRewardConfig(builder);
		}

		// Token: 0x06017AC3 RID: 96963 RVA: 0x0036A19D File Offset: 0x0036839D
		public static void StartIQuestRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017AC4 RID: 96964 RVA: 0x0036A1A6 File Offset: 0x003683A6
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(0, rewardId, 0);
		}

		// Token: 0x06017AC5 RID: 96965 RVA: 0x0036A1B1 File Offset: 0x003683B1
		public static void AddRewardGetUiType(FlatBufferBuilder builder, EItemGetUiType rewardGetUiType)
		{
			builder.AddByte(1, (byte)rewardGetUiType, 0);
		}

		// Token: 0x06017AC6 RID: 96966 RVA: 0x0036A1BC File Offset: 0x003683BC
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset)
		{
			builder.AddOffset(2, uiConfigOffset.Value, 0);
		}

		// Token: 0x06017AC7 RID: 96967 RVA: 0x0036A1CC File Offset: 0x003683CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06017AC8 RID: 96968 RVA: 0x0036A1D7 File Offset: 0x003683D7
		public static Offset<IQuestRewardConfig> EndIQuestRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRewardConfig>(builder.EndTable());
		}

		// Token: 0x06017AC9 RID: 96969 RVA: 0x0036A1E4 File Offset: 0x003683E4
		public IQuestRewardConfigT UnPack()
		{
			IQuestRewardConfigT questRewardConfigT = new IQuestRewardConfigT();
			this.UnPackTo(questRewardConfigT);
			return questRewardConfigT;
		}

		// Token: 0x06017ACA RID: 96970 RVA: 0x0036A200 File Offset: 0x00368400
		public void UnPackTo(IQuestRewardConfigT _o)
		{
			_o.RewardId = this.RewardId;
			_o.RewardGetUiType = this.RewardGetUiType;
			_o.UiConfig = ((this.UiConfig != null) ? this.UiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017ACB RID: 96971 RVA: 0x0036A260 File Offset: 0x00368460
		public static Offset<IQuestRewardConfig> Pack(FlatBufferBuilder builder, IQuestRewardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestRewardConfig>);
			}
			Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset = (_o.UiConfig == null) ? default(Offset<IItemGetUiConfigSpecialQuest>) : IItemGetUiConfigSpecialQuest.Pack(builder, _o.UiConfig);
			return IQuestRewardConfig.CreateIQuestRewardConfig(builder, _o.RewardId, _o.RewardGetUiType, uiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400BB2B RID: 47915
		private Table __p;
	}
}
