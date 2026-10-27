using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D4 RID: 8660
[NullableContext(1)]
[Nullable(0)]
public class MailFavoriteDropDownItem : MailDropDownItem
{
	// Token: 0x06010DCB RID: 69067 RVA: 0x0041A204 File Offset: 0x00418404
	public MailFavoriteDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DCC RID: 69068 RVA: 0x0041A210 File Offset: 0x00418410
	public override MailData[] GetFilteredMailList()
	{
		List<MailData> favoriteMails = MailModel.Instance.GetFavoriteMails(null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：获取收藏邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("length", (favoriteMails != null) ? new int?(favoriteMails.Count) : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return favoriteMails.ToArray();
	}

	// Token: 0x06010DCD RID: 69069 RVA: 0x0041A274 File Offset: 0x00418474
	public override string GetTitleText()
	{
		int favoriteMailCount = MailModel.Instance.GetFavoriteMailCount();
		int favoriteMailCapacity = MailModel.Instance.GetFavoriteMailCapacity();
		if (MailModel.Instance.IsFavoriteMailSpaceNearFull())
		{
			return StringUtils.Format("<color=#c25757>{0}</color>/{1}", new string[]
			{
				favoriteMailCount.ToString(),
				favoriteMailCapacity.ToString()
			});
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Email_Inbox_Number", null);
		if (string.IsNullOrEmpty(localTextNew))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(favoriteMailCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(favoriteMailCapacity);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return StringUtils.Format(localTextNew, new string[]
		{
			favoriteMailCount.ToString(),
			favoriteMailCapacity.ToString()
		});
	}

	// Token: 0x06010DCE RID: 69070 RVA: 0x0041A329 File Offset: 0x00418529
	protected override void OnShowDropDownItemBase(MailFilter data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		base.SetMailCount(this.GetTitleText());
	}
}
