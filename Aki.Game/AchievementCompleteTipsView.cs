using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020003D2 RID: 978
[NullableContext(1)]
[Nullable(0)]
public class AchievementCompleteTipsView : UiTickViewBase
{
	// Token: 0x06003578 RID: 13688 RVA: 0x0013A3A4 File Offset: 0x001385A4
	public AchievementCompleteTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x0013A3CC File Offset: 0x001385CC
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

	// Token: 0x0600357A RID: 13690 RVA: 0x0013A43C File Offset: 0x0013863C
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

	// Token: 0x0600357B RID: 13691 RVA: 0x0013A4D8 File Offset: 0x001386D8
	protected override void OnBeforeShow()
	{
		if (this.CloseTimerDown < this.TimeLessClose && !this.IsShowFirst)
		{
			this.CloseTimerDown = 0f;
			this.UiViewSequence.PlaySequence("Start", false, null);
		}
		this.IsShowFirst = false;
	}

	// Token: 0x0600357C RID: 13692 RVA: 0x0013A527 File Offset: 0x00138727
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

	// Token: 0x0600357D RID: 13693 RVA: 0x0013A55C File Offset: 0x0013875C
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

	// Token: 0x0600357E RID: 13694 RVA: 0x0013A5A5 File Offset: 0x001387A5
	private AchievementCompleteTipsStarItem CreateStarItem()
	{
		return new AchievementCompleteTipsStarItem();
	}

	// Token: 0x04002D10 RID: 11536
	private readonly float TimeToClose = 4000f;

	// Token: 0x04002D11 RID: 11537
	private readonly float TimeLessClose = 1500f;

	// Token: 0x04002D12 RID: 11538
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<AchievementCompleteTipsStarItem, bool> StarLayout;

	// Token: 0x04002D13 RID: 11539
	private float CloseTimerDown;

	// Token: 0x04002D14 RID: 11540
	private bool IsShowFirst = true;

	// Token: 0x04002D15 RID: 11541
	private bool HaveClosed;

	// Token: 0x020066F6 RID: 26358
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402203F RID: 139327
		AchievementIcon,
		// Token: 0x04022040 RID: 139328
		AchievementName,
		// Token: 0x04022041 RID: 139329
		LayoutRoot,
		// Token: 0x04022042 RID: 139330
		AchievementStarObj
	}
}
