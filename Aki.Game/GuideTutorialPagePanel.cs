using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200128D RID: 4749
public class GuideTutorialPagePanel : UiPanelBase
{
	// Token: 0x0600BC31 RID: 48177 RVA: 0x00379474 File Offset: 0x00377674
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

	// Token: 0x0600BC32 RID: 48178 RVA: 0x0037951F File Offset: 0x0037771F
	protected override void OnStart()
	{
		this.GuideDescribeNew = new GuideDescribeNew(base.GetText(2));
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
	}

	// Token: 0x0600BC33 RID: 48179 RVA: 0x00379551 File Offset: 0x00377751
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600BC34 RID: 48180 RVA: 0x00379565 File Offset: 0x00377765
	[NullableContext(1)]
	public void Init(UUIItem uiItem)
	{
		base.SetRootActor(uiItem.GetOwner(), true);
		this.GuideDescribeNew = new GuideDescribeNew(base.GetText(2));
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetTexture(3).SetUIActive(false);
	}

	// Token: 0x0600BC35 RID: 48181 RVA: 0x003795A4 File Offset: 0x003777A4
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

	// Token: 0x0600BC36 RID: 48182 RVA: 0x00379690 File Offset: 0x00377890
	public void PlayAnime(bool isShow)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(isShow ? "Show" : "Hide", false, null, false);
	}

	// Token: 0x04006C3B RID: 27707
	[Nullable(2)]
	private GuideDescribeNew GuideDescribeNew;

	// Token: 0x04006C3C RID: 27708
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007530 RID: 30000
	private enum ETutorialsPageComponents
	{
		// Token: 0x0402613E RID: 155966
		PnlOffset,
		// Token: 0x0402613F RID: 155967
		TxtSubTitle,
		// Token: 0x04026140 RID: 155968
		TxtTutorials,
		// Token: 0x04026141 RID: 155969
		TexPicture
	}
}
