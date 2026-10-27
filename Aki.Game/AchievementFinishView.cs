using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F21 RID: 3873
public class AchievementFinishView : UiViewBase
{
	// Token: 0x06006219 RID: 25113 RVA: 0x00132ACD File Offset: 0x00130CCD
	[NullableContext(1)]
	public AchievementFinishView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600621A RID: 25114 RVA: 0x00132AE0 File Offset: 0x00130CE0
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

	// Token: 0x0600621B RID: 25115 RVA: 0x00132B4C File Offset: 0x00130D4C
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

	// Token: 0x0600621C RID: 25116 RVA: 0x00132BC8 File Offset: 0x00130DC8
	private void RefreshTexture()
	{
		int groupId = this.AchievementData.GetGroupId();
		AchievementGroupData achievementGroupData = AchievementModel.Instance.GetAchievementGroupData(new int?(groupId));
		if (!StringUtils.IsEmpty(achievementGroupData.GetTexture()))
		{
			base.SetTextureByPath(achievementGroupData.GetTexture(), base.GetTexture(0), null, null);
		}
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x00132C1C File Offset: 0x00130E1C
	private void RefreshDesc()
	{
		base.GetText(1).SetText(this.AchievementData.GetTitle(), true);
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x00132C36 File Offset: 0x00130E36
	private void OnTick(float deltaTime)
	{
		this.CurrentRunningTime += deltaTime;
		if (this.CurrentRunningTime >= 4000f)
		{
			base.CloseMe(null);
			this.ClearTimer();
		}
	}

	// Token: 0x0600621F RID: 25119 RVA: 0x00132C60 File Offset: 0x00130E60
	private void ClearTimer()
	{
		this.CurrentRunningTime = 0f;
		if (this.Ticker != -1)
		{
			TickSystem.Instance.Remove(this.Ticker);
			this.Ticker = -1;
		}
	}

	// Token: 0x06006220 RID: 25120 RVA: 0x00132C8E File Offset: 0x00130E8E
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
	}

	// Token: 0x04002C8D RID: 11405
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002C8E RID: 11406
	private int Ticker = -1;

	// Token: 0x04002C8F RID: 11407
	private float CurrentRunningTime;

	// Token: 0x0200756A RID: 30058
	private enum EComponents
	{
		// Token: 0x04026D23 RID: 159011
		Texture,
		// Token: 0x04026D24 RID: 159012
		Desc
	}
}
