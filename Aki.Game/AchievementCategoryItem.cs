using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F1B RID: 3867
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementCategoryItem : GridProxyAbstract<AchievementCategoryData>
{
	// Token: 0x060061CF RID: 25039 RVA: 0x00131788 File Offset: 0x0012F988
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
		this.BtnBindInfo = list;
	}

	// Token: 0x060061D0 RID: 25040 RVA: 0x0013184B File Offset: 0x0012FA4B
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x060061D1 RID: 25041 RVA: 0x00131853 File Offset: 0x0012FA53
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x0013188D File Offset: 0x0012FA8D
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x060061D3 RID: 25043 RVA: 0x001318C7 File Offset: 0x0012FAC7
	private void OnAchievementGroupDataNotify(int groupId)
	{
		this.RefreshRedPointState();
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x001318CF File Offset: 0x0012FACF
	private void OnAchievementDataNotify()
	{
		this.RefreshRedPointState();
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x001318D8 File Offset: 0x0012FAD8
	private void OnClickItem()
	{
		AchievementModel.Instance.CurrentSelectCategory = this.CategoryData;
		List<AchievementGroupData> achievementCategoryGroups = AchievementModel.Instance.GetAchievementCategoryGroups(this.CategoryData.GetId(), true);
		if (achievementCategoryGroups.Count > 0)
		{
			AchievementModel.Instance.CurrentSelectGroup = achievementCategoryGroups[0];
			AchievementController.Instance.OpenAchievementDetailView(this.CategoryData.GetId(), new int?(achievementCategoryGroups[0].GetId()), -1);
			return;
		}
		AchievementModel.Instance.CurrentSelectGroup = null;
		AchievementController.Instance.OpenAchievementDetailView(this.CategoryData.GetId(), null, -1);
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x00131978 File Offset: 0x0012FB78
	[NullableContext(1)]
	public override void Refresh(AchievementCategoryData data, bool isSelected, int gridIndex)
	{
		this.CategoryData = data;
		this.RefreshRedPointState();
		this.RefreshNameText();
		this.RefreshIcon();
		this.RefreshProgressText();
	}

	// Token: 0x060061D7 RID: 25047 RVA: 0x00131999 File Offset: 0x0012FB99
	private void RefreshRedPointState()
	{
		base.GetItem(4).SetUIActive(AchievementModel.Instance.GetCategoryRedPointState(this.CategoryData.GetId()));
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x001319BC File Offset: 0x0012FBBC
	private void RefreshNameText()
	{
		base.GetText(2).SetText(this.CategoryData.GetTitle(), true);
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x001319D6 File Offset: 0x0012FBD6
	private void RefreshProgressText()
	{
		base.GetText(3).SetText(this.CategoryData.GetAchievementCategoryProgress(), true);
	}

	// Token: 0x060061DA RID: 25050 RVA: 0x001319F0 File Offset: 0x0012FBF0
	private void RefreshIcon()
	{
		if (!StringUtils.IsEmpty(this.CategoryData.GetTexture()))
		{
			base.SetTextureByPath(this.CategoryData.GetTexture(), base.GetTexture(1), null, null);
		}
	}

	// Token: 0x060061DB RID: 25051 RVA: 0x00131A31 File Offset: 0x0012FC31
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04002C76 RID: 11382
	[Nullable(2)]
	private AchievementCategoryData CategoryData;

	// Token: 0x02007560 RID: 30048
	private enum EChildType
	{
		// Token: 0x04026CEC RID: 158956
		Button,
		// Token: 0x04026CED RID: 158957
		Texture,
		// Token: 0x04026CEE RID: 158958
		NameText,
		// Token: 0x04026CEF RID: 158959
		ProgressText,
		// Token: 0x04026CF0 RID: 158960
		RedPoint
	}
}
