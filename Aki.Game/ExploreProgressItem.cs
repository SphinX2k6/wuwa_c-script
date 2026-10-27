using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ABC RID: 6844
public class ExploreProgressItem : UiPanelBase
{
	// Token: 0x0600CAE1 RID: 51937 RVA: 0x002E3A24 File Offset: 0x002E1C24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnMissionButtonClicked));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnTipsButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CAE2 RID: 51938 RVA: 0x002E3BB3 File Offset: 0x002E1DB3
	private void OnMissionButtonClicked()
	{
		if (this.ExploreAreaItemData == null)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ExploreMissionView, this.ExploreAreaItemData.AreaId, null);
	}

	// Token: 0x0600CAE3 RID: 51939 RVA: 0x002E3BE0 File Offset: 0x002E1DE0
	private void OnTipsButtonClicked()
	{
		ExploreAreaItemData exploreAreaItemData = this.ExploreAreaItemData;
		int? num = (exploreAreaItemData != null) ? exploreAreaItemData.GetPhantomSkillHelpId() : null;
		if (num == null)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(num.Value);
	}

	// Token: 0x0600CAE4 RID: 51940 RVA: 0x002E3C24 File Offset: 0x002E1E24
	[NullableContext(1)]
	public void Refresh(ExploreAreaItemData data)
	{
		this.ExploreAreaItemData = data;
		float num = (float)data.GetProgress();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetNameId(), Array.Empty<object>());
		base.GetSprite(2).SetFillAmount(num / 100f);
		if (data.IsPercent())
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)num));
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		else
		{
			UUIText text2 = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetCurrentCount());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetTotalCount());
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		base.GetItem(3).SetUIActive(data.ExploreType == EExploreType.AreaMission);
		if (data.IsCompleted())
		{
			base.GetItem(5).SetUIActive(false);
			return;
		}
		bool uiactive = data.HasPhantomSkill();
		base.GetItem(5).SetUIActive(uiactive);
		UUIText text3 = base.GetText(7);
		string text4;
		if (data.GetIsPhantomSkillUnlock())
		{
			UUIItem uuiitem = text3;
			bool bUseChangeColor = false;
			FColor? fcolor = null;
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text4 = data.GetUnlockTextId();
		}
		else
		{
			UUIItem uuiitem2 = text3;
			bool bUseChangeColor2 = true;
			FColor? fcolor = new FColor?(text3.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			text4 = data.GetLockTextId();
		}
		if (!string.IsNullOrEmpty(text4))
		{
			LguiUtil.Instance.SetLocalTextNew(text3, text4, Array.Empty<object>());
		}
	}

	// Token: 0x04005D61 RID: 23905
	[Nullable(2)]
	private ExploreAreaItemData ExploreAreaItemData;

	// Token: 0x02008014 RID: 32788
	private enum EChildType
	{
		// Token: 0x04029CFA RID: 171258
		NameText,
		// Token: 0x04029CFB RID: 171259
		ProgressText,
		// Token: 0x04029CFC RID: 171260
		ProgressBarSprite,
		// Token: 0x04029CFD RID: 171261
		MissionButtonItem,
		// Token: 0x04029CFE RID: 171262
		MissionButton,
		// Token: 0x04029CFF RID: 171263
		TipsItem,
		// Token: 0x04029D00 RID: 171264
		TipsButton,
		// Token: 0x04029D01 RID: 171265
		TipsText
	}
}
