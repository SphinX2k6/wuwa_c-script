using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020042BA RID: 17082
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PersonalConfig : ConfigBase
	{
		// Token: 0x0602B3A9 RID: 177065 RVA: 0x00C251FB File Offset: 0x00C233FB
		public PlayerHeadRe? GetPlayerHeadConfig(int id)
		{
			return ConfigPlayerHeadReById.GetConfig(id, true);
		}

		// Token: 0x0602B3AA RID: 177066 RVA: 0x00C25204 File Offset: 0x00C23404
		[NullableContext(2)]
		public IReadOnlyList<PlayerHeadRe> GetAllPlayerHeadConfig()
		{
			return ConfigPlayerHeadReAll.GetConfigList(true);
		}

		// Token: 0x0602B3AB RID: 177067 RVA: 0x00C2520C File Offset: 0x00C2340C
		public string GetBirthLocalText(int date, EBirthDateType dateType)
		{
			BirthDayText? config = ConfigBirthDayTextByDateAndType.GetConfig(date, (int)dateType, true);
			string text = "";
			if (config != null)
			{
				text = (ConfigMultiTextLang.GetLocalTextNew(config.Value.TextId, null) ?? "");
			}
			if (text == "")
			{
				text = date.ToString();
			}
			return text;
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x0602B3AC RID: 177068 RVA: 0x00C25266 File Offset: 0x00C23466
		public static PersonalConfig Instance
		{
			get
			{
				return PersonalConfig._Instance;
			}
		}

		// Token: 0x0602B3AD RID: 177069 RVA: 0x00C2526D File Offset: 0x00C2346D
		public static PersonalConfig GetOrCreateInstance()
		{
			if (PersonalConfig._Instance == null)
			{
				PersonalConfig.CreateInstance();
			}
			return PersonalConfig._Instance;
		}

		// Token: 0x0602B3AE RID: 177070 RVA: 0x00C25281 File Offset: 0x00C23481
		public static bool CreateInstance()
		{
			if (PersonalConfig._Instance != null)
			{
				return true;
			}
			PersonalConfig._Instance = new PersonalConfig();
			return true;
		}

		// Token: 0x0602B3AF RID: 177071 RVA: 0x00C25297 File Offset: 0x00C23497
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B3B0 RID: 177072 RVA: 0x00C25299 File Offset: 0x00C23499
		public static void ResetStaticDefaultValue()
		{
			PersonalConfig._Instance = null;
		}

		// Token: 0x0602B3B1 RID: 177073 RVA: 0x00C252A1 File Offset: 0x00C234A1
		static PersonalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PersonalConfig.CreateStaticDefaultValue), new Action(PersonalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401754E RID: 95566
		[Nullable(2)]
		private static PersonalConfig _Instance;
	}
}
