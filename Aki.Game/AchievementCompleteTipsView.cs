using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F1D RID: 3869
[NullableContext(1)]
[Nullable(0)]
public class AchievementCompleteTipsView : UiTickViewBase
{
	// Token: 0x060061E0 RID: 25056 RVA: 0x00131A80 File Offset: 0x0012FC80
	public AchievementCompleteTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x00131AA8 File Offset: 0x0012FCA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060061E2 RID: 25058 RVA: 0x00131B18 File Offset: 0x0012FD18
	protected override void OnStart()
	{
		AchievementData achievementData = this.OpenParam as AchievementData;
		if (achievementData == null)
		{
			return;
		}
		this.StarLayout = new GenericLayout<AchievementCompleteTipsStarItem, bool>(base.GetHorizontalLayout(2), new Func<AchievementCompleteTipsStarItem>(this.CreateStarItem), null, false, true);
		int groupId = achievementData.GetGroupId();
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(groupId));
		if (!StringUtils.IsEmpty(achievementGroupData.GetTexture()))
		{
			base.SetTextureByPath(achievementGroupData.GetTexture(), base.GetTexture(0), null, null);
		}
		base.GetText(1).SetText(achievementData.GetTitle(), true);
		this.RefreshStarLayout(achievementData);
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x00131BB4 File Offset: 0x0012FDB4
	protected override void OnBeforeShow()
	{
		if (this.CloseTimerDown < this.TimeLessClose && !this.IsShowFirst)
		{
			this.CloseTimerDown = 0f;
			this.UiViewSequence.PlaySequence("Start", false, null);
		}
		this.IsShowFirst = false;
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x00131C03 File Offset: 0x0012FE03
	protected override void OnTick(float delta)
	{
		if (this.HaveClosed)
		{
			return;
		}
		this.CloseTimerDown += delta;
		if (this.CloseTimerDown >= this.TimeToClose)
		{
			this.HaveClosed = true;
			base.CloseMe(null);
		}
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x00131C38 File Offset: 0x0012FE38
	private void RefreshStarLayout(AchievementData achievementData)
	{
		List<bool> list = new List<bool>();
		int maxStar = achievementData.GetMaxStar();
		int achievementConfigStar = achievementData.GetAchievementConfigStar();
		for (int i = 0; i < maxStar; i++)
		{
			bool item = achievementConfigStar > i;
			list.Add(item);
		}
		this.StarLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060061E6 RID: 25062 RVA: 0x00131C81 File Offset: 0x0012FE81
	private AchievementCompleteTipsStarItem CreateStarItem()
	{
		return new AchievementCompleteTipsStarItem();
	}

	// Token: 0x04002C77 RID: 11383
	private readonly float TimeToClose = 4000f;

	// Token: 0x04002C78 RID: 11384
	private readonly float TimeLessClose = 1500f;

	// Token: 0x04002C79 RID: 11385
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<AchievementCompleteTipsStarItem, bool> StarLayout;

	// Token: 0x04002C7A RID: 11386
	private float CloseTimerDown;

	// Token: 0x04002C7B RID: 11387
	private bool IsShowFirst = true;

	// Token: 0x04002C7C RID: 11388
	private bool HaveClosed;

	// Token: 0x02007562 RID: 30050
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026CF4 RID: 158964
		AchievementIcon,
		// Token: 0x04026CF5 RID: 158965
		AchievementName,
		// Token: 0x04026CF6 RID: 158966
		LayoutRoot,
		// Token: 0x04026CF7 RID: 158967
		AchievementStarObj
	}
}
