using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020025BC RID: 9660
public class FightPhotoScrollItem : FightPhotoSetupBase
{
	// Token: 0x06013967 RID: 80231 RVA: 0x004E5C74 File Offset: 0x004E3E74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x06013968 RID: 80232 RVA: 0x004E5CFC File Offset: 0x004E3EFC
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(1);
		UUIItem item3 = base.GetItem(2);
		this.AngleAttachView = new NoCircleAttachView<int?, FightPhotoAngleItem>(item.GetOwner() as AUIBaseActor, false);
		this.AngleAttachView.SetIfNeedFakeItem(false);
		this.AngleAttachView.SetMoveMultiFactor(0f);
		this.AngleAttachView.CreateItems(item3.GetOwner() as AUIBaseActor, 0f, new Func<AActor, int, int, FightPhotoAngleItem>(this.CreateMarkItem), EAttachDirection.Horizontal);
		this.AngleAttachView.SetControllerItem(item2);
		this.AngleAttachView.SetItemSelectMode(EAttachMode.OnMovingNearest);
		item3.SetUIActive(false);
		EventSystem.Instance.Add<int>(EEventName.OnSyncFightPhotoTiltAngle, new Action<int>(this.OnSyncFightPhotoTiltAngle));
	}

	// Token: 0x06013969 RID: 80233 RVA: 0x004E5DB8 File Offset: 0x004E3FB8
	public override void Refresh()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.SetupConfig.Value.Name, Array.Empty<object>());
		int num = (int)Math.Round((double)this.SetupConfig.Value.ValueRange(0));
		int num2 = (int)Math.Round((double)this.SetupConfig.Value.ValueRange(1));
		this.AngleMin = num;
		this.AngleMax = num2;
		int num3 = num2 - num + 1;
		int?[] array = new int?[num3];
		for (int i = 0; i < num3; i++)
		{
			array[i] = new int?(num + i);
		}
		int? fightPhotoSetupOption = FightPhotoModel.Instance.GetFightPhotoSetupOption((EFightPhotoSetupOptionType)this.SetupConfig.Value.Id);
		float num4 = (fightPhotoSetupOption != null) ? ((float)fightPhotoSetupOption.GetValueOrDefault()) : this.SetupConfig.Value.ValueRange(2);
		int num5 = Math.Min(num2, Math.Max(num, (int)Math.Round((double)num4)));
		int attachTo = num5 - num;
		this.RefreshAngleText(num5);
		NoCircleAttachView<int?, FightPhotoAngleItem> angleAttachView = this.AngleAttachView;
		if (angleAttachView == null)
		{
			return;
		}
		angleAttachView.ReloadView(array.Length, array, attachTo);
	}

	// Token: 0x0601396A RID: 80234 RVA: 0x004E5EF8 File Offset: 0x004E40F8
	protected override void OnBeforeDestroy()
	{
		if (EventSystem.Instance.Has<int>(EEventName.OnSyncFightPhotoTiltAngle, new Action<int>(this.OnSyncFightPhotoTiltAngle)))
		{
			EventSystem.Instance.Remove<int>(EEventName.OnSyncFightPhotoTiltAngle, new Action<int>(this.OnSyncFightPhotoTiltAngle));
		}
		this.AngleAttachView = null;
	}

	// Token: 0x0601396B RID: 80235 RVA: 0x004E5F45 File Offset: 0x004E4145
	[NullableContext(1)]
	private FightPhotoAngleItem CreateMarkItem(AActor actor, int index, int showNum)
	{
		FightPhotoAngleItem fightPhotoAngleItem = new FightPhotoAngleItem();
		fightPhotoAngleItem.CreateByActorAsync(actor, null, false).Forget();
		fightPhotoAngleItem.OnSelectCallback = new Action<int>(this.OnAngleSelect);
		return fightPhotoAngleItem;
	}

	// Token: 0x0601396C RID: 80236 RVA: 0x004E5F6C File Offset: 0x004E416C
	private void OnAngleSelect(int angle)
	{
		this.RefreshAngleText(angle);
		base.OnSetupValueChange(angle);
	}

	// Token: 0x0601396D RID: 80237 RVA: 0x004E5F7C File Offset: 0x004E417C
	private void RefreshAngleText(int angle)
	{
		string newText = MathUtils.Instance.GetFloatPointFloorString((double)angle, this.SetupConfig.Value.Digits) + this.SetupConfig.Value.Unit;
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0601396E RID: 80238 RVA: 0x004E5FD4 File Offset: 0x004E41D4
	private void OnSyncFightPhotoTiltAngle(int angle)
	{
		if (this.SetupConfig == null || this.SetupConfig.GetValueOrDefault().Id != 3 || this.AngleAttachView == null)
		{
			return;
		}
		int num = Math.Min(this.AngleMax, Math.Max(this.AngleMin, (int)Math.Round((double)angle)));
		this.RefreshAngleText(num);
		this.AngleAttachView.AttachToIndex(num - this.AngleMin, true);
	}

	// Token: 0x040093D3 RID: 37843
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private NoCircleAttachView<int?, FightPhotoAngleItem> AngleAttachView;

	// Token: 0x040093D4 RID: 37844
	private int AngleMin;

	// Token: 0x040093D5 RID: 37845
	private int AngleMax;

	// Token: 0x02008BCA RID: 35786
	private enum EChildType
	{
		// Token: 0x0402D5F7 RID: 185847
		Draggable,
		// Token: 0x0402D5F8 RID: 185848
		ItemContent,
		// Token: 0x0402D5F9 RID: 185849
		ItemScaleMark,
		// Token: 0x0402D5FA RID: 185850
		TxtAngleNum,
		// Token: 0x0402D5FB RID: 185851
		TxtTitle
	}
}
