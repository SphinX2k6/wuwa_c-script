using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006606 RID: 26118
	public class FishingCurrencyItem : UiPanelBase
	{
		// Token: 0x06041752 RID: 268114 RVA: 0x00FD9FA8 File Offset: 0x00FD81A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITextureTransitionComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041753 RID: 268115 RVA: 0x00FDA138 File Offset: 0x00FD8338
		protected override UniTask OnBeforeStartAsync()
		{
			FishingCurrencyItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingCurrencyItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041754 RID: 268116 RVA: 0x00FDA17C File Offset: 0x00FD837C
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.FishingShipDataRefresh, new Action(this.FishingShipDataRefresh));
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(7);
			sprite.SetUIActive(true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_FightHp");
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x06041755 RID: 268117 RVA: 0x00FDA230 File Offset: 0x00FD8430
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipDataRefresh, new Action(this.FishingShipDataRefresh));
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.RemoveAttributeListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
			shipData.RemoveAttributeListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
		}

		// Token: 0x06041756 RID: 268118 RVA: 0x00FDA288 File Offset: 0x00FD8488
		protected override void OnBeforeShow()
		{
			this.RefreshItem();
		}

		// Token: 0x06041757 RID: 268119 RVA: 0x00FDA290 File Offset: 0x00FD8490
		public void RefreshItem()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			float currentHp = shipData.GetCurrentHp();
			float maxHp = shipData.GetMaxHp();
			base.GetText(1).SetText(currentHp.ToString() + "/" + maxHp.ToString(), true);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("FishingLowFixTips").GetValueOrDefault();
			UiPanelBase lowPowerTips = this.LowPowerTips;
			if (lowPowerTips == null)
			{
				return;
			}
			lowPowerTips.SetUiActive(currentHp < (float)valueOrDefault);
		}

		// Token: 0x06041758 RID: 268120 RVA: 0x00FDA301 File Offset: 0x00FD8501
		private void OnClickButton()
		{
			HelpController.Instance.OpenHelpById(186);
		}

		// Token: 0x06041759 RID: 268121 RVA: 0x00FDA312 File Offset: 0x00FD8512
		private void FishingShipAttributeRefresh(EAttributeType attrId, float oldValue, float newValue)
		{
			this.RefreshItem();
		}

		// Token: 0x0604175A RID: 268122 RVA: 0x00FDA31A File Offset: 0x00FD851A
		private void FishingShipDataRefresh()
		{
			this.RefreshItem();
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.AddAttributeListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
			shipData.AddAttributeListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
		}

		// Token: 0x0402212B RID: 139563
		[Nullable(2)]
		private UiPanelBase LowPowerTips;

		// Token: 0x0200C812 RID: 51218
		private class EComponentDefine
		{
			// Token: 0x0403C6B0 RID: 247472
			public const int Texture = 0;

			// Token: 0x0403C6B1 RID: 247473
			public const int CountText = 1;

			// Token: 0x0403C6B2 RID: 247474
			public const int Button = 2;

			// Token: 0x0403C6B3 RID: 247475
			public const int TextureButton = 3;

			// Token: 0x0403C6B4 RID: 247476
			public const int TextureTransition = 4;

			// Token: 0x0403C6B5 RID: 247477
			public const int SliderItem = 5;

			// Token: 0x0403C6B6 RID: 247478
			public const int SliderSprite = 6;

			// Token: 0x0403C6B7 RID: 247479
			public const int SpriteIcon = 7;

			// Token: 0x0403C6B8 RID: 247480
			public const int MaxItem = 8;
		}
	}
}
