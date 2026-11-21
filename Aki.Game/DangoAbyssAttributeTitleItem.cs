using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000EE6 RID: 3814
public class DangoAbyssAttributeTitleItem : UiPanelBase
{
	// Token: 0x06009907 RID: 39175 RVA: 0x002D5E13 File Offset: 0x002D4013
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x06009908 RID: 39176 RVA: 0x002D5E4C File Offset: 0x002D404C
	[NullableContext(1)]
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x06009909 RID: 39177 RVA: 0x002D5E64 File Offset: 0x002D4064
	[NullableContext(1)]
	public void Refresh(DangoAbyssDefine.EquipViewAttributeData data)
	{
		UUIText text = base.GetText(0);
		UUISprite sprite = base.GetSprite(1);
		string textStringId = data.IsValid ? "Text_AttributeValid_Text" : "Text_AttributeNotValid_Text";
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		UUIItem uuiitem = text;
		bool bUseChangeColor = !data.IsValid;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIItem uuiitem2 = sprite;
		bool bUseChangeColor2 = !data.IsValid;
		fcolor = new FColor?(sprite.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		base.SetUiActive(true);
	}

	// Token: 0x020070FB RID: 28923
	private enum ETitleItemComponent
	{
		// Token: 0x04024CD1 RID: 150737
		TextTitle,
		// Token: 0x04024CD2 RID: 150738
		SpriteTitle
	}
}
