using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA7 RID: 7079
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyGridItem : UiPanelBase
{
	// Token: 0x0600D2C4 RID: 53956 RVA: 0x00307414 File Offset: 0x00305614
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D2C5 RID: 53957 RVA: 0x003076B2 File Offset: 0x003058B2
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600D2C6 RID: 53958 RVA: 0x003076CC File Offset: 0x003058CC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchToyGridItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchToyGridItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2C7 RID: 53959 RVA: 0x0030770F File Offset: 0x0030590F
	protected override void OnStart()
	{
		this.SetInfoPanelActive(false);
		base.GetExtendToggle(0).SetSelfInteractive(false);
	}

	// Token: 0x0600D2C8 RID: 53960 RVA: 0x00307728 File Offset: 0x00305928
	private void OnToggleClick(EToggleState toggleState)
	{
		FloroRanchEntityBase entity = this.Entity;
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = (entity != null) ? entity.CheckGetComponent<FloroRanchEntityDataComponent>() : null;
		int obj = (floroRanchEntityDataComponent != null) ? floroRanchEntityDataComponent.Point : -1;
		Action<int> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(obj);
	}

	// Token: 0x0600D2C9 RID: 53961 RVA: 0x00307765 File Offset: 0x00305965
	public void BindClickCallback(Action<int> callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x0600D2CA RID: 53962 RVA: 0x00307770 File Offset: 0x00305970
	public void RefreshItemGrid(FloroRanchEntityBase entity)
	{
		if (entity == null)
		{
			this.SetInfoPanelActive(false);
			return;
		}
		this.Entity = entity;
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = entity.CheckGetComponent<FloroRanchEntityDataComponent>();
		FloroRanchToyDataComponent floroRanchToyDataComponent = entity.CheckGetComponent<FloroRanchToyDataComponent>();
		FloroRanchToyData floroRanchToyData = (floroRanchToyDataComponent != null) ? floroRanchToyDataComponent.ToyData : null;
		base.GetItem(3).SetUIActive(false);
		FloroRanchRarityData toyQualityData = floroRanchToyData.GetToyQualityData();
		if (toyQualityData != null)
		{
			this.SetSpriteByPath(toyQualityData.GetRaritySmallBg(), base.GetSprite(1), true, null, null);
		}
		bool isUnique = floroRanchToyData.GetIsUnique();
		int num = (floroRanchEntityDataComponent != null) ? floroRanchEntityDataComponent.Count : 1;
		if (!isUnique)
		{
			base.GetText(6).SetText(num.ToString(), true);
		}
		base.GetItem(5).SetUIActive(!isUnique && num > 1);
		base.SetTextureByPath(floroRanchToyData.GetIcon(), base.GetTexture(2), null, null);
		FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		bool flag = currentActivityData == null || currentActivityData.IsToyUnlocked(floroRanchToyData.Id);
		base.GetSprite(7).SetUIActive(!flag);
		this.SetInfoPanelActive(true);
		base.GetExtendToggle(0).SetSelfInteractive(true);
		FloroRanchRaceData toyRaceData = floroRanchToyData.GetToyRaceData();
		if (toyRaceData != null)
		{
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			base.SetTextureShowUntilLoaded(toyRaceData.SmallIcon, base.GetTexture(15), null);
		}
		else
		{
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		int level = floroRanchToyDataComponent.Level;
		if (level > 0)
		{
			this.ToyLevelItem.Refresh(level);
			this.ToyLevelItem.SetActive(true);
			return;
		}
		this.ToyLevelItem.SetActive(false);
	}

	// Token: 0x0600D2CB RID: 53963 RVA: 0x00307902 File Offset: 0x00305B02
	public void SetInfoPanelActive(bool isActive)
	{
		base.GetItem(8).SetUIActive(isActive);
		base.GetExtendToggle(0).SetSelfInteractive(isActive);
	}

	// Token: 0x0600D2CC RID: 53964 RVA: 0x00307920 File Offset: 0x00305B20
	public void PlayShowAnim(FloroRanchEntityBase entity)
	{
		this.RefreshItemGrid(entity);
		if (this.UiLevelSequence.IsInSequence())
		{
			this.UiLevelSequence.StopPrevSequence(false, true);
		}
		this.UiLevelSequence.PlaySequence("Start", false, new float?((float)FloroRanchGamePlayModel.Instance.GetTimeDilation()));
	}

	// Token: 0x0600D2CD RID: 53965 RVA: 0x0030796F File Offset: 0x00305B6F
	public void SetSelectState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400609A RID: 24730
	private FloroRanchEntityBase Entity;

	// Token: 0x0400609B RID: 24731
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x0400609C RID: 24732
	public FloroRanchToyLevelItem ToyLevelItem;

	// Token: 0x0400609D RID: 24733
	private Action<int> OnClickCallback = delegate(int point)
	{
	};

	// Token: 0x02008148 RID: 33096
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A321 RID: 172833
		public const int Toggle = 0;

		// Token: 0x0402A322 RID: 172834
		public const int QualitySprite = 1;

		// Token: 0x0402A323 RID: 172835
		public const int IconTexture = 2;

		// Token: 0x0402A324 RID: 172836
		public const int CountDownPanel = 3;

		// Token: 0x0402A325 RID: 172837
		public const int CountdownText = 4;

		// Token: 0x0402A326 RID: 172838
		public const int NumPanel = 5;

		// Token: 0x0402A327 RID: 172839
		public const int NumText = 6;

		// Token: 0x0402A328 RID: 172840
		public const int LockSprite = 7;

		// Token: 0x0402A329 RID: 172841
		public const int InfoPanel = 8;

		// Token: 0x0402A32A RID: 172842
		public const int BgSprite = 9;

		// Token: 0x0402A32B RID: 172843
		public const int IconMaskTexture = 10;

		// Token: 0x0402A32C RID: 172844
		public const int UnknownPanel = 11;

		// Token: 0x0402A32D RID: 172845
		public const int ItemPhantomIcon = 12;

		// Token: 0x0402A32E RID: 172846
		public const int ItemNew = 13;

		// Token: 0x0402A32F RID: 172847
		public const int ToyRaceItem = 14;

		// Token: 0x0402A330 RID: 172848
		public const int ToyRaceIcon = 15;

		// Token: 0x0402A331 RID: 172849
		public const int ToyLevelItem = 16;
	}
}
