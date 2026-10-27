using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DCB RID: 7627
public class GuideTutorialPagePanel : UiPanelBase
{
	// Token: 0x0600E812 RID: 59410 RVA: 0x0036D774 File Offset: 0x0036B974
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E813 RID: 59411 RVA: 0x0036D81F File Offset: 0x0036BA1F
	protected override void OnStart()
	{
		this.GuideDescribeNew = new GuideDescribeNew(base.GetText(2));
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
	}

	// Token: 0x0600E814 RID: 59412 RVA: 0x0036D851 File Offset: 0x0036BA51
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600E815 RID: 59413 RVA: 0x0036D865 File Offset: 0x0036BA65
	[NullableContext(1)]
	public void Init(UUIItem uiItem)
	{
		base.SetRootActor(uiItem.GetOwner(), true);
		this.GuideDescribeNew = new GuideDescribeNew(base.GetText(2));
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
	}

	// Token: 0x0600E816 RID: 59414 RVA: 0x0036D8A4 File Offset: 0x0036BAA4
	public void RefreshPage(GuideTutorialPage? pageConfig)
	{
		if (pageConfig == null)
		{
			return;
		}
		if (StringUtils.IsEmpty(pageConfig.Value.SubTitle))
		{
			base.GetItem(0).SetUIActive(false);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pageConfig.Value.SubTitle, Array.Empty<object>());
			base.GetItem(0).SetUIActive(true);
		}
		if (!StringUtils.IsEmpty(pageConfig.Value.Pic))
		{
			base.SetTextureByPath(pageConfig.Value.Pic, base.GetTexture(3), null, delegate(bool _)
			{
				base.GetTexture(3).SetUIActive(true);
			});
		}
		base.GetText(2).SetUIActive(true);
		this.GuideDescribeNew.SetUpText(pageConfig.Value.Content, pageConfig.Value.Button());
	}

	// Token: 0x0600E817 RID: 59415 RVA: 0x0036D990 File Offset: 0x0036BB90
	public void PlayAnime(bool isShow)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(isShow ? "Show" : "Hide", false, null, false);
	}

	// Token: 0x04006B5A RID: 27482
	[Nullable(2)]
	private GuideDescribeNew GuideDescribeNew;

	// Token: 0x04006B5B RID: 27483
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020083A9 RID: 33705
	private enum ETutorialsPageComponents
	{
		// Token: 0x0402AE19 RID: 175641
		PnlOffset,
		// Token: 0x0402AE1A RID: 175642
		TxtSubTitle,
		// Token: 0x0402AE1B RID: 175643
		TxtTutorials,
		// Token: 0x0402AE1C RID: 175644
		TexPicture
	}
}
