using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050E9 RID: 20713
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PhoneMsgConfig : ConfigBase
	{
		// Token: 0x06034FA5 RID: 216997 RVA: 0x00C8C737 File Offset: 0x00C8A937
		public ShortMessage? GetPhoneMsgConfig(int shortMessageId)
		{
			return ConfigShortMessageById.GetConfig(shortMessageId, true);
		}

		// Token: 0x06034FA6 RID: 216998 RVA: 0x00C8C740 File Offset: 0x00C8A940
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

		// Token: 0x06034FA7 RID: 216999 RVA: 0x00C8C800 File Offset: 0x00C8AA00
		public ChatPartner? GetChatPartnerConfig(int partnerId)
		{
			return ConfigChatPartnerById.GetConfig(partnerId, true);
		}

		// Token: 0x06034FA8 RID: 217000 RVA: 0x00C8C809 File Offset: 0x00C8AA09
		public ChatBg? GetChatBgConfig(int bgId)
		{
			return ConfigChatBgById.GetConfig(bgId, true);
		}

		// Token: 0x06034FA9 RID: 217001 RVA: 0x00C8C812 File Offset: 0x00C8AA12
		[NullableContext(2)]
		public IReadOnlyList<ChatBg> GetAllChatBgConfigList()
		{
			return ConfigChatBgAll.GetConfigList(true);
		}

		// Token: 0x06034FAA RID: 217002 RVA: 0x00C8C81A File Offset: 0x00C8AA1A
		public ChatDialog? GetChatDialogConfig(int dialogId)
		{
			return ConfigChatDialogById.GetConfig(dialogId, true);
		}

		// Token: 0x06034FAB RID: 217003 RVA: 0x00C8C823 File Offset: 0x00C8AA23
		[NullableContext(2)]
		public IReadOnlyList<ChatDialog> GetAllChatDialogConfigList()
		{
			return ConfigChatDialogAll.GetConfigList(true);
		}

		// Token: 0x06034FAC RID: 217004 RVA: 0x00C8C82B File Offset: 0x00C8AA2B
		public ChatTheme? GetChatThemeConfig(int themeId)
		{
			return ConfigChatThemeById.GetConfig(themeId, true);
		}

		// Token: 0x06034FAD RID: 217005 RVA: 0x00C8C834 File Offset: 0x00C8AA34
		[NullableContext(2)]
		public IReadOnlyList<ChatTheme> GetAllChatThemeConfigList()
		{
			return ConfigChatThemeAll.GetConfigList(true);
		}

		// Token: 0x06034FAE RID: 217006 RVA: 0x00C8C83C File Offset: 0x00C8AA3C
		public ChatCharm? GetChatCharmConfig(int charmId)
		{
			return ConfigChatCharmById.GetConfig(charmId, true);
		}

		// Token: 0x06034FAF RID: 217007 RVA: 0x00C8C845 File Offset: 0x00C8AA45
		[NullableContext(2)]
		public IReadOnlyList<ChatCharm> GetAllChatCharmConfigList()
		{
			return ConfigChatCharmAll.GetConfigList(true);
		}

		// Token: 0x06034FB0 RID: 217008 RVA: 0x00C8C84D File Offset: 0x00C8AA4D
		public PhoneInputTime? GetPhoneInputTimeConfig(int id)
		{
			return ConfigPhoneInputTimeById.GetConfig(id, true);
		}

		// Token: 0x06034FB1 RID: 217009 RVA: 0x00C8C858 File Offset: 0x00C8AA58
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

		// Token: 0x06034FB2 RID: 217010 RVA: 0x00C8C938 File Offset: 0x00C8AB38
		public ChatFilterType? GetChatFilterTypeConfig(int filterTypeId)
		{
			return ConfigChatFilterTypeById.GetConfig(filterTypeId, true);
		}

		// Token: 0x06034FB3 RID: 217011 RVA: 0x00C8C941 File Offset: 0x00C8AB41
		public IEnumerable<ChatFilterType> GetAllChatFilterTypeConfigList()
		{
			return ConfigChatFilterTypeAll.GetConfigList(true);
		}

		// Token: 0x06034FB4 RID: 217012 RVA: 0x00C8C949 File Offset: 0x00C8AB49
		public ChatPartnerFilter? GetChatPartnerFilterConfig(int filterId)
		{
			return ConfigChatPartnerFilterById.GetConfig(filterId, true);
		}

		// Token: 0x06034FB5 RID: 217013 RVA: 0x00C8C954 File Offset: 0x00C8AB54
		public IEnumerable<ChatPartnerFilter> GetChatPartnerFilterConfigListByFilterType(int filterTypeId)
		{
			IReadOnlyList<ChatPartnerFilter> configList = ConfigChatPartnerFilterAll.GetConfigList(true);
			if (configList == null)
			{
				return Enumerable.Empty<ChatPartnerFilter>();
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

		// Token: 0x06034FB6 RID: 217014 RVA: 0x00C8C9E4 File Offset: 0x00C8ABE4
		public IEnumerable<ChatPartnerFilter> GetAllChatPartnerFilterConfigList()
		{
			IEnumerable<ChatPartnerFilter> configList = ConfigChatPartnerFilterAll.GetConfigList(true);
			return configList ?? Enumerable.Empty<ChatPartnerFilter>();
		}

		// Token: 0x17008098 RID: 32920
		// (get) Token: 0x06034FB7 RID: 217015 RVA: 0x00C8CA02 File Offset: 0x00C8AC02
		public static PhoneMsgConfig Instance
		{
			get
			{
				return PhoneMsgConfig._Instance;
			}
		}

		// Token: 0x06034FB8 RID: 217016 RVA: 0x00C8CA09 File Offset: 0x00C8AC09
		public static PhoneMsgConfig GetOrCreateInstance()
		{
			if (PhoneMsgConfig._Instance == null)
			{
				PhoneMsgConfig.CreateInstance();
			}
			return PhoneMsgConfig._Instance;
		}

		// Token: 0x06034FB9 RID: 217017 RVA: 0x00C8CA1D File Offset: 0x00C8AC1D
		public static bool CreateInstance()
		{
			if (PhoneMsgConfig._Instance != null)
			{
				return true;
			}
			PhoneMsgConfig._Instance = new PhoneMsgConfig();
			return true;
		}

		// Token: 0x06034FBA RID: 217018 RVA: 0x00C8CA33 File Offset: 0x00C8AC33
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034FBB RID: 217019 RVA: 0x00C8CA35 File Offset: 0x00C8AC35
		public static void ResetStaticDefaultValue()
		{
			PhoneMsgConfig._Instance = null;
		}

		// Token: 0x06034FBC RID: 217020 RVA: 0x00C8CA3D File Offset: 0x00C8AC3D
		static PhoneMsgConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgConfig.CreateStaticDefaultValue), new Action(PhoneMsgConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C331 RID: 115505
		[Nullable(2)]
		private Dictionary<int, ShortMessage> QuestId2ShortMessageMap;

		// Token: 0x0401C332 RID: 115506
		[Nullable(2)]
		private static PhoneMsgConfig _Instance;
	}
}
