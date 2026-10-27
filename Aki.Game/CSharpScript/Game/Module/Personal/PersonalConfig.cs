using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020052EA RID: 21226
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class PersonalConfig : ConfigBase
	{
		// Token: 0x060364AE RID: 222382 RVA: 0x00CD7AD7 File Offset: 0x00CD5CD7
		public PlayerHeadRe? GetPlayerHeadConfig(int id)
		{
			return ConfigPlayerHeadReById.GetConfig(id, true);
		}

		// Token: 0x060364AF RID: 222383 RVA: 0x00CD7AE0 File Offset: 0x00CD5CE0
		[NullableContext(2)]
		public IReadOnlyList<PlayerHeadRe> GetAllPlayerHeadConfig()
		{
			return ConfigPlayerHeadReAll.GetConfigList(true);
		}

		// Token: 0x060364B0 RID: 222384 RVA: 0x00CD7AE8 File Offset: 0x00CD5CE8
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

		// Token: 0x1700830C RID: 33548
		// (get) Token: 0x060364B1 RID: 222385 RVA: 0x00CD7B42 File Offset: 0x00CD5D42
		public static PersonalConfig Instance
		{
			get
			{
				return PersonalConfig._Instance;
			}
		}

		// Token: 0x060364B2 RID: 222386 RVA: 0x00CD7B49 File Offset: 0x00CD5D49
		public static PersonalConfig GetOrCreateInstance()
		{
			if (PersonalConfig._Instance == null)
			{
				PersonalConfig.CreateInstance();
			}
			return PersonalConfig._Instance;
		}

		// Token: 0x060364B3 RID: 222387 RVA: 0x00CD7B5D File Offset: 0x00CD5D5D
		public static bool CreateInstance()
		{
			if (PersonalConfig._Instance != null)
			{
				return true;
			}
			PersonalConfig._Instance = new PersonalConfig();
			return true;
		}

		// Token: 0x060364B4 RID: 222388 RVA: 0x00CD7B73 File Offset: 0x00CD5D73
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060364B5 RID: 222389 RVA: 0x00CD7B75 File Offset: 0x00CD5D75
		public static void ResetStaticDefaultValue()
		{
			PersonalConfig._Instance = null;
		}

		// Token: 0x060364B6 RID: 222390 RVA: 0x00CD7B7D File Offset: 0x00CD5D7D
		static PersonalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PersonalConfig.CreateStaticDefaultValue), new Action(PersonalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401CB19 RID: 117529
		[Nullable(2)]
		private static PersonalConfig _Instance;
	}
}
