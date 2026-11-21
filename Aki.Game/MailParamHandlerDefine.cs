using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020016AC RID: 5804
public class MailParamHandlerDefine : IStaticVariableResetter
{
	// Token: 0x0600E174 RID: 57716 RVA: 0x004217DE File Offset: 0x0041F9DE
	static MailParamHandlerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailParamHandlerDefine.CreateStaticDefaultValue), new Action(MailParamHandlerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600E175 RID: 57717 RVA: 0x00421800 File Offset: 0x0041FA00
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
			string[] array = value.Split('/', StringSplitOptions.None);
			List<string> list = new List<string>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Length > 0)
				{
					list.Add(text);
				}
			}
			string[] array2 = list.ToArray();
			int num;
			if (array2.Length != 0 && int.TryParse(array2[0], out num) && num > 0)
			{
				instance.SetShowSubContentJumpId(num);
			}
			int showSubContentJumpParam;
			if (array2.Length > 1 && int.TryParse(array2[1], out showSubContentJumpParam))
			{
				instance.SetShowSubContentJumpParam(showSubContentJumpParam);
			}
			int showSubContentJumpParam2;
			if (array2.Length > 2 && int.TryParse(array2[2], out showSubContentJumpParam2))
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

	// Token: 0x0600E176 RID: 57718 RVA: 0x00421B07 File Offset: 0x0041FD07
	public static void ResetStaticDefaultValue()
	{
		MailParamHandlerDefine.mailParamHandlerMapDefine = null;
	}

	// Token: 0x04008118 RID: 33048
	[Nullable(1)]
	public static Dictionary<string, IMailParamHandler> mailParamHandlerMapDefine;
}
