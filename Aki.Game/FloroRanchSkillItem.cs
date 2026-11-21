using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200105D RID: 4189
public class FloroRanchSkillItem : UiPanelBase
{
	// Token: 0x0600A69A RID: 42650 RVA: 0x00310EC4 File Offset: 0x0030F0C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A69B RID: 42651 RVA: 0x00310FF0 File Offset: 0x0030F1F0
	public void Refresh(int skillId)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetUIActive(skillId != 0);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(skillId != 0);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(skillId == 0);
		}
		this.RefreshRedDot();
		if (skillId == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FloroRanchSelectSkill", Array.Empty<object>());
			return;
		}
		FloroRanchSkillData floroRanchSkillData = FloroRanchModel.Instance.GetFloroRanchSkillData(skillId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), floroRanchSkillData.Name, Array.Empty<object>());
		base.SetTextureByPath(floroRanchSkillData.Icon, base.GetTexture(0), null, null);
	}

	// Token: 0x0600A69C RID: 42652 RVA: 0x003110AC File Offset: 0x0030F2AC
	public void RefreshRedDot()
	{
		bool uiactive = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).IsSkillHasRedDot();
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A69D RID: 42653 RVA: 0x003110E4 File Offset: 0x0030F2E4
	private void OnButtonClick()
	{
		if (FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true).HasUnFinishedSubIns())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_SkillBlock", Array.Empty<object>());
			return;
		}
		FloroRanchSkillViewParam floroRanchSkillViewParam = new FloroRanchSkillViewParam
		{
			CanSelect = true,
			ActivityDataType = this.ActivityDataType
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchSkillView, floroRanchSkillViewParam, null);
	}

	// Token: 0x04006156 RID: 24918
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x020072C7 RID: 29383
	private class EComponentDefine
	{
		// Token: 0x04025616 RID: 153110
		public const int TextureIcon = 0;

		// Token: 0x04025617 RID: 153111
		public const int SpriteSwitch = 1;

		// Token: 0x04025618 RID: 153112
		public const int TextName = 2;

		// Token: 0x04025619 RID: 153113
		public const int SpriteAdd = 3;

		// Token: 0x0402561A RID: 153114
		public const int Button = 4;

		// Token: 0x0402561B RID: 153115
		public const int ItemRedDot = 5;
	}
}
