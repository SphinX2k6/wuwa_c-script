using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016B3 RID: 5811
[NullableContext(1)]
[Nullable(0)]
public class MailLinkButton : UiPanelBase
{
	// Token: 0x0600E215 RID: 57877 RVA: 0x00424718 File Offset: 0x00422918
	public MailLinkButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600E216 RID: 57878 RVA: 0x0042472D File Offset: 0x0042292D
	public void SetTitle(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x0600E217 RID: 57879 RVA: 0x0042473D File Offset: 0x0042293D
	public void SetTitleByTextKey(string textKey)
	{
		if (StringUtils.IsEmpty(textKey))
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
	}

	// Token: 0x0600E218 RID: 57880 RVA: 0x0042475F File Offset: 0x0042295F
	public void SetColor(string hex)
	{
		base.GetText(0).SetColor(FColor.FromHex(hex));
	}

	// Token: 0x0600E219 RID: 57881 RVA: 0x00424774 File Offset: 0x00422974
	public void SetJumpIcon(int jumpId)
	{
		UUISprite sprite = base.GetSprite(1);
		sprite.SetUIActive(true);
		MailTo? mailToConfigById = MailConfig.Instance.GetMailToConfigById(jumpId);
		if (mailToConfigById != null && !StringUtils.IsEmpty(mailToConfigById.Value.IconPath))
		{
			this.SetSpriteByPath(mailToConfigById.Value.IconPath, sprite, false, null, null);
			return;
		}
		if (jumpId <= 0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconPageLink");
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			return;
		}
		string functionIconPath = FunctionConfig.Instance.GetFunctionIconPath(jumpId);
		if (StringUtils.IsEmpty(functionIconPath))
		{
			return;
		}
		this.SetSpriteByPath(functionIconPath, sprite, false, null, null);
	}

	// Token: 0x0600E21A RID: 57882 RVA: 0x00424834 File Offset: 0x00422A34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600E21B RID: 57883 RVA: 0x004248A8 File Offset: 0x00422AA8
	protected override void OnStart()
	{
		this.Button = (this.RootActor.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent);
		this.Button.OnClickCallBack.Bind(new Action(this.OnClick));
	}

	// Token: 0x0600E21C RID: 57884 RVA: 0x004248E6 File Offset: 0x00422AE6
	protected override void OnBeforeDestroy()
	{
		this.ClickDelegate = null;
	}

	// Token: 0x0600E21D RID: 57885 RVA: 0x004248EF File Offset: 0x00422AEF
	private void OnClick()
	{
		Action clickDelegate = this.ClickDelegate;
		if (clickDelegate == null)
		{
			return;
		}
		clickDelegate();
	}

	// Token: 0x0400814E RID: 33102
	public Action ClickDelegate;

	// Token: 0x0400814F RID: 33103
	private UUIButtonComponent Button;
}
