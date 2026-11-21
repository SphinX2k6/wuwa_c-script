using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004451 RID: 17489
	public struct IQuestRewardConfig : IFlatbufferObject
	{
		// Token: 0x1700793F RID: 31039
		// (get) Token: 0x06019151 RID: 102737 RVA: 0x00393DE3 File Offset: 0x00391FE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019152 RID: 102738 RVA: 0x00393DF0 File Offset: 0x00391FF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019153 RID: 102739 RVA: 0x00393DF8 File Offset: 0x00391FF8
		public static IQuestRewardConfig GetRootAsIQuestRewardConfig(ByteBuffer _bb)
		{
			return IQuestRewardConfig.GetRootAsIQuestRewardConfig(_bb, default(IQuestRewardConfig));
		}

		// Token: 0x06019154 RID: 102740 RVA: 0x00393E14 File Offset: 0x00392014
		public static IQuestRewardConfig GetRootAsIQuestRewardConfig(ByteBuffer _bb, IQuestRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019155 RID: 102741 RVA: 0x00393E31 File Offset: 0x00392031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019156 RID: 102742 RVA: 0x00393E40 File Offset: 0x00392040
		public IQuestRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007940 RID: 31040
		// (get) Token: 0x06019157 RID: 102743 RVA: 0x00393E50 File Offset: 0x00392050
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

		// Token: 0x17007941 RID: 31041
		// (get) Token: 0x06019158 RID: 102744 RVA: 0x00393E8C File Offset: 0x0039208C
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

		// Token: 0x17007942 RID: 31042
		// (get) Token: 0x06019159 RID: 102745 RVA: 0x00393EC8 File Offset: 0x003920C8
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

		// Token: 0x17007943 RID: 31043
		// (get) Token: 0x0601915A RID: 102746 RVA: 0x00393F28 File Offset: 0x00392128
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

		// Token: 0x0601915B RID: 102747 RVA: 0x00393F65 File Offset: 0x00392165
		public static Offset<IQuestRewardConfig> CreateIQuestRewardConfig(FlatBufferBuilder builder, int RewardId = 0, EItemGetUiType RewardGetUiType = EItemGetUiType.None, Offset<IItemGetUiConfigSpecialQuest> UiConfigOffset = default(Offset<IItemGetUiConfigSpecialQuest>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuestRewardConfig.AddUiConfig(builder, UiConfigOffset);
			IQuestRewardConfig.AddRewardId(builder, RewardId);
			IQuestRewardConfig.AddNullMask(builder, NullMask);
			IQuestRewardConfig.AddRewardGetUiType(builder, RewardGetUiType);
			return IQuestRewardConfig.EndIQuestRewardConfig(builder);
		}

		// Token: 0x0601915C RID: 102748 RVA: 0x00393F91 File Offset: 0x00392191
		public static void StartIQuestRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601915D RID: 102749 RVA: 0x00393F9A File Offset: 0x0039219A
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(0, rewardId, 0);
		}

		// Token: 0x0601915E RID: 102750 RVA: 0x00393FA5 File Offset: 0x003921A5
		public static void AddRewardGetUiType(FlatBufferBuilder builder, EItemGetUiType rewardGetUiType)
		{
			builder.AddByte(1, (byte)rewardGetUiType, 0);
		}

		// Token: 0x0601915F RID: 102751 RVA: 0x00393FB0 File Offset: 0x003921B0
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset)
		{
			builder.AddOffset(2, uiConfigOffset.Value, 0);
		}

		// Token: 0x06019160 RID: 102752 RVA: 0x00393FC0 File Offset: 0x003921C0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019161 RID: 102753 RVA: 0x00393FCB File Offset: 0x003921CB
		public static Offset<IQuestRewardConfig> EndIQuestRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRewardConfig>(builder.EndTable());
		}

		// Token: 0x06019162 RID: 102754 RVA: 0x00393FD8 File Offset: 0x003921D8
		public IQuestRewardConfigT UnPack()
		{
			IQuestRewardConfigT questRewardConfigT = new IQuestRewardConfigT();
			this.UnPackTo(questRewardConfigT);
			return questRewardConfigT;
		}

		// Token: 0x06019163 RID: 102755 RVA: 0x00393FF4 File Offset: 0x003921F4
		public void UnPackTo(IQuestRewardConfigT _o)
		{
			_o.RewardId = this.RewardId;
			_o.RewardGetUiType = this.RewardGetUiType;
			_o.UiConfig = ((this.UiConfig != null) ? this.UiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019164 RID: 102756 RVA: 0x00394054 File Offset: 0x00392254
		public static Offset<IQuestRewardConfig> Pack(FlatBufferBuilder builder, IQuestRewardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestRewardConfig>);
			}
			Offset<IItemGetUiConfigSpecialQuest> uiConfigOffset = (_o.UiConfig == null) ? default(Offset<IItemGetUiConfigSpecialQuest>) : IItemGetUiConfigSpecialQuest.Pack(builder, _o.UiConfig);
			return IQuestRewardConfig.CreateIQuestRewardConfig(builder, _o.RewardId, _o.RewardGetUiType, uiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400C512 RID: 50450
		private Table __p;
	}
}
