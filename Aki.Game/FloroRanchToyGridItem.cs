using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001066 RID: 4198
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchToyGridItem : UiPanelBase
{
	// Token: 0x0600A6D5 RID: 42709 RVA: 0x003124F4 File Offset: 0x003106F4
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

	// Token: 0x0600A6D6 RID: 42710 RVA: 0x00312792 File Offset: 0x00310992
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600A6D7 RID: 42711 RVA: 0x003127AC File Offset: 0x003109AC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchToyGridItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchToyGridItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A6D8 RID: 42712 RVA: 0x003127EF File Offset: 0x003109EF
	protected override void OnStart()
	{
		this.SetInfoPanelActive(false);
		base.GetExtendToggle(0).SetSelfInteractive(false);
	}

	// Token: 0x0600A6D9 RID: 42713 RVA: 0x00312808 File Offset: 0x00310A08
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

	// Token: 0x0600A6DA RID: 42714 RVA: 0x00312845 File Offset: 0x00310A45
	public void BindClickCallback(Action<int> callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x0600A6DB RID: 42715 RVA: 0x00312850 File Offset: 0x00310A50
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

	// Token: 0x0600A6DC RID: 42716 RVA: 0x003129E2 File Offset: 0x00310BE2
	public void SetInfoPanelActive(bool isActive)
	{
		base.GetItem(8).SetUIActive(isActive);
		base.GetExtendToggle(0).SetSelfInteractive(isActive);
	}

	// Token: 0x0600A6DD RID: 42717 RVA: 0x00312A00 File Offset: 0x00310C00
	public void PlayShowAnim(FloroRanchEntityBase entity)
	{
		this.RefreshItemGrid(entity);
		if (this.UiLevelSequence.IsInSequence())
		{
			this.UiLevelSequence.StopPrevSequence(false, true);
		}
		this.UiLevelSequence.PlaySequence("Start", false, new float?((float)FloroRanchGamePlayModel.Instance.GetTimeDilation()));
	}

	// Token: 0x0600A6DE RID: 42718 RVA: 0x00312A4F File Offset: 0x00310C4F
	public void SetSelectState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04006169 RID: 24937
	private FloroRanchEntityBase Entity;

	// Token: 0x0400616A RID: 24938
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x0400616B RID: 24939
	public FloroRanchToyLevelItem ToyLevelItem;

	// Token: 0x0400616C RID: 24940
	private Action<int> OnClickCallback = delegate(int point)
	{
	};

	// Token: 0x020072D6 RID: 29398
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025655 RID: 153173
		public const int Toggle = 0;

		// Token: 0x04025656 RID: 153174
		public const int QualitySprite = 1;

		// Token: 0x04025657 RID: 153175
		public const int IconTexture = 2;

		// Token: 0x04025658 RID: 153176
		public const int CountDownPanel = 3;

		// Token: 0x04025659 RID: 153177
		public const int CountdownText = 4;

		// Token: 0x0402565A RID: 153178
		public const int NumPanel = 5;

		// Token: 0x0402565B RID: 153179
		public const int NumText = 6;

		// Token: 0x0402565C RID: 153180
		public const int LockSprite = 7;

		// Token: 0x0402565D RID: 153181
		public const int InfoPanel = 8;

		// Token: 0x0402565E RID: 153182
		public const int BgSprite = 9;

		// Token: 0x0402565F RID: 153183
		public const int IconMaskTexture = 10;

		// Token: 0x04025660 RID: 153184
		public const int UnknownPanel = 11;

		// Token: 0x04025661 RID: 153185
		public const int ItemPhantomIcon = 12;

		// Token: 0x04025662 RID: 153186
		public const int ItemNew = 13;

		// Token: 0x04025663 RID: 153187
		public const int ToyRaceItem = 14;

		// Token: 0x04025664 RID: 153188
		public const int ToyRaceIcon = 15;

		// Token: 0x04025665 RID: 153189
		public const int ToyLevelItem = 16;
	}
}
