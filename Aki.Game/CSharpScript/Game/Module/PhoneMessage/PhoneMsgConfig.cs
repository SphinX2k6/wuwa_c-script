using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040B9 RID: 16569
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PhoneMsgConfig : ConfigBase
	{
		// Token: 0x06029E9E RID: 171678 RVA: 0x00BD9A1F File Offset: 0x00BD7C1F
		public ShortMessage? GetPhoneMsgConfig(int shortMessageId)
		{
			return ConfigShortMessageById.GetConfig(shortMessageId, true);
		}

		// Token: 0x06029E9F RID: 171679 RVA: 0x00BD9A28 File Offset: 0x00BD7C28
		public ShortMessage? GetShortMessageByQuestId(int questId)
		{
			if (questId <= 0)
			{
				return null;
			}
			if (this.QuestId2ShortMessageMap == null)
			{
				this.QuestId2ShortMessageMap = new Dictionary<int, ShortMessage>();
				IReadOnlyList<ShortMessage> configList = ConfigShortMessageByAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (ShortMessage value in configList)
					{
						if (value.QuestId > 0 && !this.QuestId2ShortMessageMap.ContainsKey(value.QuestId))
						{
							this.QuestId2ShortMessageMap[value.QuestId] = value;
						}
					}
				}
			}
			ShortMessage value2;
			if (!this.QuestId2ShortMessageMap.TryGetValue(questId, out value2))
			{
				return null;
			}
			return new ShortMessage?(value2);
		}

		// Token: 0x06029EA0 RID: 171680 RVA: 0x00BD9AE8 File Offset: 0x00BD7CE8
		public ChatPartner? GetChatPartnerConfig(int partnerId)
		{
			return ConfigChatPartnerById.GetConfig(partnerId, true);
		}

		// Token: 0x06029EA1 RID: 171681 RVA: 0x00BD9AF1 File Offset: 0x00BD7CF1
		public ChatBg? GetChatBgConfig(int bgId)
		{
			return ConfigChatBgById.GetConfig(bgId, true);
		}

		// Token: 0x06029EA2 RID: 171682 RVA: 0x00BD9AFA File Offset: 0x00BD7CFA
		[NullableContext(2)]
		public IReadOnlyList<ChatBg> GetAllChatBgConfigList()
		{
			return ConfigChatBgAll.GetConfigList(true);
		}

		// Token: 0x06029EA3 RID: 171683 RVA: 0x00BD9B02 File Offset: 0x00BD7D02
		public ChatDialog? GetChatDialogConfig(int dialogId)
		{
			return ConfigChatDialogById.GetConfig(dialogId, true);
		}

		// Token: 0x06029EA4 RID: 171684 RVA: 0x00BD9B0B File Offset: 0x00BD7D0B
		[NullableContext(2)]
		public IReadOnlyList<ChatDialog> GetAllChatDialogConfigList()
		{
			return ConfigChatDialogAll.GetConfigList(true);
		}

		// Token: 0x06029EA5 RID: 171685 RVA: 0x00BD9B13 File Offset: 0x00BD7D13
		public ChatTheme? GetChatThemeConfig(int themeId)
		{
			return ConfigChatThemeById.GetConfig(themeId, true);
		}

		// Token: 0x06029EA6 RID: 171686 RVA: 0x00BD9B1C File Offset: 0x00BD7D1C
		[NullableContext(2)]
		public IReadOnlyList<ChatTheme> GetAllChatThemeConfigList()
		{
			return ConfigChatThemeAll.GetConfigList(true);
		}

		// Token: 0x06029EA7 RID: 171687 RVA: 0x00BD9B24 File Offset: 0x00BD7D24
		public ChatCharm? GetChatCharmConfig(int charmId)
		{
			return ConfigChatCharmById.GetConfig(charmId, true);
		}

		// Token: 0x06029EA8 RID: 171688 RVA: 0x00BD9B2D File Offset: 0x00BD7D2D
		[NullableContext(2)]
		public IReadOnlyList<ChatCharm> GetAllChatCharmConfigList()
		{
			return ConfigChatCharmAll.GetConfigList(true);
		}

		// Token: 0x06029EA9 RID: 171689 RVA: 0x00BD9B35 File Offset: 0x00BD7D35
		public PhoneInputTime? GetPhoneInputTimeConfig(int id)
		{
			return ConfigPhoneInputTimeById.GetConfig(id, true);
		}

		// Token: 0x06029EAA RID: 171690 RVA: 0x00BD9B40 File Offset: 0x00BD7D40
		public ShortMessage? GetShortMessageConfigByPlayFlow(PlayFlow playFlow)
		{
			string flowListName = playFlow.FlowListName;
			int flowId = playFlow.FlowId;
			int stateId = playFlow.StateId;
			IReadOnlyList<ShortMessage> configList = ConfigShortMessageByAll.GetConfigList(true);
			if (configList != null)
			{
				foreach (ShortMessage value in configList)
				{
					string[] array = value.FlowParam();
					if (array.Length == 3)
					{
						string text = array[0];
						string text2 = array[1];
						string text3 = array[2];
						if (text.Length > 0 && text2.Length > 0 && text3.Length > 0 && text == flowListName && int.Parse(text2) == flowId && int.Parse(text3) == stateId)
						{
							return new ShortMessage?(value);
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06029EAB RID: 171691 RVA: 0x00BD9C20 File Offset: 0x00BD7E20
		public ChatFilterType? GetChatFilterTypeConfig(int filterTypeId)
		{
			return ConfigChatFilterTypeById.GetConfig(filterTypeId, true);
		}

		// Token: 0x06029EAC RID: 171692 RVA: 0x00BD9C29 File Offset: 0x00BD7E29
		public IEnumerable<ChatFilterType> GetAllChatFilterTypeConfigList()
		{
			return ConfigChatFilterTypeAll.GetConfigList(true);
		}

		// Token: 0x06029EAD RID: 171693 RVA: 0x00BD9C31 File Offset: 0x00BD7E31
		public ChatPartnerFilter? GetChatPartnerFilterConfig(int filterId)
		{
			return ConfigChatPartnerFilterById.GetConfig(filterId, true);
		}

		// Token: 0x06029EAE RID: 171694 RVA: 0x00BD9C3C File Offset: 0x00BD7E3C
		public IEnumerable<ChatPartnerFilter> GetChatPartnerFilterConfigListByFilterType(int filterTypeId)
		{
			IReadOnlyList<ChatPartnerFilter> configList = ConfigChatPartnerFilterAll.GetConfigList(true);
			if (configList == null)
			{
				return Array.Empty<ChatPartnerFilter>();
			}
			List<ChatPartnerFilter> list = new List<ChatPartnerFilter>();
			foreach (ChatPartnerFilter item in configList)
			{
				if (item.Type == filterTypeId)
				{
					list.Add(item);
				}
			}
			list.Sort((ChatPartnerFilter a, ChatPartnerFilter b) => a.SortId.CompareTo(b.SortId));
			return list;
		}

		// Token: 0x06029EAF RID: 171695 RVA: 0x00BD9CCC File Offset: 0x00BD7ECC
		public IEnumerable<ChatPartnerFilter> GetAllChatPartnerFilterConfigList()
		{
			return ConfigChatPartnerFilterAll.GetConfigList(true) ?? Array.Empty<ChatPartnerFilter>();
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x06029EB0 RID: 171696 RVA: 0x00BD9CDD File Offset: 0x00BD7EDD
		public static PhoneMsgConfig Instance
		{
			get
			{
				return PhoneMsgConfig._Instance;
			}
		}

		// Token: 0x06029EB1 RID: 171697 RVA: 0x00BD9CE4 File Offset: 0x00BD7EE4
		public static PhoneMsgConfig GetOrCreateInstance()
		{
			if (PhoneMsgConfig._Instance == null)
			{
				PhoneMsgConfig.CreateInstance();
			}
			return PhoneMsgConfig._Instance;
		}

		// Token: 0x06029EB2 RID: 171698 RVA: 0x00BD9CF8 File Offset: 0x00BD7EF8
		public static bool CreateInstance()
		{
			if (PhoneMsgConfig._Instance != null)
			{
				return true;
			}
			PhoneMsgConfig._Instance = new PhoneMsgConfig();
			return true;
		}

		// Token: 0x06029EB3 RID: 171699 RVA: 0x00BD9D0E File Offset: 0x00BD7F0E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029EB4 RID: 171700 RVA: 0x00BD9D10 File Offset: 0x00BD7F10
		public static void ResetStaticDefaultValue()
		{
			PhoneMsgConfig._Instance = null;
		}

		// Token: 0x06029EB5 RID: 171701 RVA: 0x00BD9D18 File Offset: 0x00BD7F18
		static PhoneMsgConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgConfig.CreateStaticDefaultValue), new Action(PhoneMsgConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016D62 RID: 93538
		[Nullable(2)]
		private Dictionary<int, ShortMessage> QuestId2ShortMessageMap;

		// Token: 0x04016D63 RID: 93539
		[Nullable(2)]
		private static PhoneMsgConfig _Instance;
	}
}
