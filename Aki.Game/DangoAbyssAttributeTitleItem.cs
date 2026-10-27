using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001A27 RID: 6695
public class DangoAbyssAttributeTitleItem : UiPanelBase
{
	// Token: 0x0600C4F7 RID: 50423 RVA: 0x002CACF3 File Offset: 0x002C8EF3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600C4F8 RID: 50424 RVA: 0x002CAD2C File Offset: 0x002C8F2C
	[NullableContext(1)]
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x0600C4F9 RID: 50425 RVA: 0x002CAD44 File Offset: 0x002C8F44
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

	// Token: 0x02007F6C RID: 32620
	private enum ETitleItemComponent
	{
		// Token: 0x04029994 RID: 170388
		TextTitle,
		// Token: 0x04029995 RID: 170389
		SpriteTitle
	}
}
