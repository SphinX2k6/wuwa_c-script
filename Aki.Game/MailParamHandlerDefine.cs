using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020021C8 RID: 8648
public class MailParamHandlerDefine : IStaticVariableResetter
{
	// Token: 0x06010CE3 RID: 68835 RVA: 0x00414EFE File Offset: 0x004130FE
	static MailParamHandlerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailParamHandlerDefine.CreateStaticDefaultValue), new Action(MailParamHandlerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06010CE4 RID: 68836 RVA: 0x00414F20 File Offset: 0x00413120
	public static void CreateStaticDefaultValue()
	{
		Dictionary<string, IMailParamHandler> dictionary = new Dictionary<string, IMailParamHandler>();
		dictionary["iconId"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			int showSubIconId;
			if (int.TryParse(value, out showSubIconId))
			{
				instance.SetShowSubIconId(showSubIconId);
			}
		});
		dictionary["color"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			string showSubContentColor = value.StartsWith("#") ? value.Substring(1) : value;
			instance.SetShowSubContentColor(showSubContentColor);
		});
		dictionary["jumpId"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			string[] array = (from part in value.Split('/', StringSplitOptions.None)
			select part.Trim() into part
			where part.Length > 0
			select part).ToArray<string>();
			int num;
			if (array.Length != 0 && int.TryParse(array[0], out num) && num > 0)
			{
				instance.SetShowSubContentJumpId(num);
			}
			int showSubContentJumpParam;
			if (array.Length > 1 && int.TryParse(array[1], out showSubContentJumpParam))
			{
				instance.SetShowSubContentJumpParam(showSubContentJumpParam);
			}
			int showSubContentJumpParam2;
			if (array.Length > 2 && int.TryParse(array[2], out showSubContentJumpParam2))
			{
				instance.SetShowSubContentJumpParam2(showSubContentJumpParam2);
			}
		});
		dictionary["jumpParam"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			int showSubContentJumpParam;
			if (int.TryParse(value, out showSubContentJumpParam))
			{
				instance.SetShowSubContentJumpParam(showSubContentJumpParam);
			}
		});
		dictionary["jumpParam2"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			int showSubContentJumpParam;
			if (int.TryParse(value, out showSubContentJumpParam))
			{
				instance.SetShowSubContentJumpParam2(showSubContentJumpParam);
			}
		});
		dictionary["url"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetSubUrl(value);
		});
		dictionary["showNewMail"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetIfShowNewMail(true);
		});
		dictionary["useDefaultBrowser"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetUseDefaultBrowser(true);
		});
		dictionary["isWenjuanxing"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			int num;
			if (int.TryParse(value, out num))
			{
				instance.SetIsQuestion(num == 1);
			}
		});
		dictionary["wenjuanId"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetQuestionActiveId(value);
		});
		dictionary["wenjuanTitle"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetSubTitle(value);
		});
		dictionary["subTitle"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetSubTitle(value);
		});
		dictionary["wenjuanPass"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetQuestionPass(value);
		});
		dictionary["is_orientation"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetIfLandscape(value == "landscape");
		});
		dictionary["needPlayerInfo"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			instance.SetNeedPlayerInfo(true);
		});
		dictionary["playerInfoFormatStyle"] = new MailParamHandler(delegate(MailData instance, string value)
		{
			int playerInfoFormatStyle;
			if (int.TryParse(value, out playerInfoFormatStyle))
			{
				instance.SetPlayerInfoFormatStyle(playerInfoFormatStyle);
			}
		});
		MailParamHandlerDefine.mailParamHandlerMapDefine = dictionary;
	}

	// Token: 0x06010CE5 RID: 68837 RVA: 0x00415227 File Offset: 0x00413427
	public static void ResetStaticDefaultValue()
	{
		MailParamHandlerDefine.mailParamHandlerMapDefine = null;
	}

	// Token: 0x04007FD1 RID: 32721
	[Nullable(1)]
	public static Dictionary<string, IMailParamHandler> mailParamHandlerMapDefine;
}
