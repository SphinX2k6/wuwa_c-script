using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021CF RID: 8655
[NullableContext(1)]
[Nullable(0)]
public class MailLinkButton : UiPanelBase
{
	// Token: 0x06010D84 RID: 68996 RVA: 0x00417E38 File Offset: 0x00416038
	public MailLinkButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06010D85 RID: 68997 RVA: 0x00417E4D File Offset: 0x0041604D
	public void SetTitle(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06010D86 RID: 68998 RVA: 0x00417E5D File Offset: 0x0041605D
	public void SetTitleByTextKey(string textKey)
	{
		if (StringUtils.IsEmpty(textKey))
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
	}

	// Token: 0x06010D87 RID: 68999 RVA: 0x00417E7F File Offset: 0x0041607F
	public void SetColor(string hex)
	{
		base.GetText(0).SetColor(FColor.FromHex(hex));
	}

	// Token: 0x06010D88 RID: 69000 RVA: 0x00417E94 File Offset: 0x00416094
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

	// Token: 0x06010D89 RID: 69001 RVA: 0x00417F54 File Offset: 0x00416154
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

	// Token: 0x06010D8A RID: 69002 RVA: 0x00417FC8 File Offset: 0x004161C8
	protected override void OnStart()
	{
		this.Button = (this.RootActor.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent);
		this.Button.OnClickCallBack.Bind(new Action(this.OnClick));
	}

	// Token: 0x06010D8B RID: 69003 RVA: 0x00418006 File Offset: 0x00416206
	protected override void OnBeforeDestroy()
	{
		this.ClickDelegate = null;
	}

	// Token: 0x06010D8C RID: 69004 RVA: 0x0041800F File Offset: 0x0041620F
	private void OnClick()
	{
		Action clickDelegate = this.ClickDelegate;
		if (clickDelegate == null)
		{
			return;
		}
		clickDelegate();
	}

	// Token: 0x04008007 RID: 32775
	public Action ClickDelegate;

	// Token: 0x04008008 RID: 32776
	private UUIButtonComponent Button;
}
