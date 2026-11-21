using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020003D6 RID: 982
public class AchievementFinishView : UiViewBase
{
	// Token: 0x060035B1 RID: 13745 RVA: 0x0013B3F1 File Offset: 0x001395F1
	[NullableContext(1)]
	public AchievementFinishView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x0013B404 File Offset: 0x00139604
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x0013B470 File Offset: 0x00139670
	protected override void OnBeforeShow()
	{
		int id = AchievementModel.Instance.CurrentFinishAchievementArray[0];
		AchievementModel.Instance.CurrentFinishAchievementArray.RemoveAt(0);
		this.AchievementData = AchievementModel.Instance.GetAchievementData(id);
		this.RefreshTexture();
		this.RefreshDesc();
		this.ClearTimer();
		this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "Achievement", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
	}

	// Token: 0x060035B4 RID: 13748 RVA: 0x0013B4EC File Offset: 0x001396EC
	private void RefreshTexture()
	{
		int groupId = this.AchievementData.GetGroupId();
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(groupId));
		if (!StringUtils.IsEmpty(achievementGroupData.GetTexture()))
		{
			base.SetTextureByPath(achievementGroupData.GetTexture(), base.GetTexture(0), null, null);
		}
	}

	// Token: 0x060035B5 RID: 13749 RVA: 0x0013B540 File Offset: 0x00139740
	private void RefreshDesc()
	{
		base.GetText(1).SetText(this.AchievementData.GetTitle(), true);
	}

	// Token: 0x060035B6 RID: 13750 RVA: 0x0013B55A File Offset: 0x0013975A
	private void OnTick(float deltaTime)
	{
		this.CurrentRunningTime += deltaTime;
		if (this.CurrentRunningTime >= 4000f)
		{
			base.CloseMe(null);
			this.ClearTimer();
		}
	}

	// Token: 0x060035B7 RID: 13751 RVA: 0x0013B584 File Offset: 0x00139784
	private void ClearTimer()
	{
		this.CurrentRunningTime = 0f;
		if (this.Ticker != -1)
		{
			TickSystem.Instance.Remove(this.Ticker);
			this.Ticker = -1;
		}
	}

	// Token: 0x060035B8 RID: 13752 RVA: 0x0013B5B2 File Offset: 0x001397B2
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
	}

	// Token: 0x04002D26 RID: 11558
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002D27 RID: 11559
	private int Ticker = -1;

	// Token: 0x04002D28 RID: 11560
	private float CurrentRunningTime;

	// Token: 0x020066FE RID: 26366
	private enum EComponents
	{
		// Token: 0x0402206E RID: 139374
		Texture,
		// Token: 0x0402206F RID: 139375
		Desc
	}
}
