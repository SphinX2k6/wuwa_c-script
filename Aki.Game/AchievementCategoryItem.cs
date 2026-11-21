using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020003D0 RID: 976
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementCategoryItem : GridProxyAbstract<AchievementCategoryData>
{
	// Token: 0x06003567 RID: 13671 RVA: 0x0013A0AC File Offset: 0x001382AC
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

	// Token: 0x06003568 RID: 13672 RVA: 0x0013A16F File Offset: 0x0013836F
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x0013A177 File Offset: 0x00138377
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x0600356A RID: 13674 RVA: 0x0013A1B1 File Offset: 0x001383B1
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x0600356B RID: 13675 RVA: 0x0013A1EB File Offset: 0x001383EB
	private void OnAchievementGroupDataNotify(int groupId)
	{
		this.RefreshRedPointState();
	}

	// Token: 0x0600356C RID: 13676 RVA: 0x0013A1F3 File Offset: 0x001383F3
	private void OnAchievementDataNotify()
	{
		this.RefreshRedPointState();
	}

	// Token: 0x0600356D RID: 13677 RVA: 0x0013A1FC File Offset: 0x001383FC
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

	// Token: 0x0600356E RID: 13678 RVA: 0x0013A29C File Offset: 0x0013849C
	[NullableContext(1)]
	public override void Refresh(AchievementCategoryData data, bool isSelected, int gridIndex)
	{
		this.CategoryData = data;
		this.RefreshRedPointState();
		this.RefreshNameText();
		this.RefreshIcon();
		this.RefreshProgressText();
	}

	// Token: 0x0600356F RID: 13679 RVA: 0x0013A2BD File Offset: 0x001384BD
	private void RefreshRedPointState()
	{
		base.GetItem(4).SetUIActive(AchievementModel.Instance.GetCategoryRedPointState(this.CategoryData.GetId()));
	}

	// Token: 0x06003570 RID: 13680 RVA: 0x0013A2E0 File Offset: 0x001384E0
	private void RefreshNameText()
	{
		base.GetText(2).SetText(this.CategoryData.GetTitle(), true);
	}

	// Token: 0x06003571 RID: 13681 RVA: 0x0013A2FA File Offset: 0x001384FA
	private void RefreshProgressText()
	{
		base.GetText(3).SetText(this.CategoryData.GetAchievementCategoryProgress(), true);
	}

	// Token: 0x06003572 RID: 13682 RVA: 0x0013A314 File Offset: 0x00138514
	private void RefreshIcon()
	{
		if (!StringUtils.IsEmpty(this.CategoryData.GetTexture()))
		{
			base.SetTextureByPath(this.CategoryData.GetTexture(), base.GetTexture(1), null, null);
		}
	}

	// Token: 0x06003573 RID: 13683 RVA: 0x0013A355 File Offset: 0x00138555
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04002D0F RID: 11535
	[Nullable(2)]
	private AchievementCategoryData CategoryData;

	// Token: 0x020066F4 RID: 26356
	private enum EChildType
	{
		// Token: 0x04022037 RID: 139319
		Button,
		// Token: 0x04022038 RID: 139320
		Texture,
		// Token: 0x04022039 RID: 139321
		NameText,
		// Token: 0x0402203A RID: 139322
		ProgressText,
		// Token: 0x0402203B RID: 139323
		RedPoint
	}
}
