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
	// Token: 0x02005584 RID: 21892
	public class FishingCurrencyItem : UiPanelBase
	{
		// Token: 0x06036417 RID: 222231 RVA: 0x00F21028 File Offset: 0x00F1F228
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

		// Token: 0x06036418 RID: 222232 RVA: 0x00F211B8 File Offset: 0x00F1F3B8
		protected override UniTask OnBeforeStartAsync()
		{
			FishingCurrencyItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingCurrencyItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036419 RID: 222233 RVA: 0x00F211FC File Offset: 0x00F1F3FC
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

		// Token: 0x0603641A RID: 222234 RVA: 0x00F212B0 File Offset: 0x00F1F4B0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipDataRefresh, new Action(this.FishingShipDataRefresh));
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.RemoveAttributeListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
			shipData.RemoveAttributeListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
		}

		// Token: 0x0603641B RID: 222235 RVA: 0x00F21308 File Offset: 0x00F1F508
		protected override void OnBeforeShow()
		{
			this.RefreshItem();
		}

		// Token: 0x0603641C RID: 222236 RVA: 0x00F21310 File Offset: 0x00F1F510
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

		// Token: 0x0603641D RID: 222237 RVA: 0x00F21381 File Offset: 0x00F1F581
		private void OnClickButton()
		{
			HelpController.Instance.OpenHelpById(186);
		}

		// Token: 0x0603641E RID: 222238 RVA: 0x00F21392 File Offset: 0x00F1F592
		private void FishingShipAttributeRefresh(EAttributeType attrId, float oldValue, float newValue)
		{
			this.RefreshItem();
		}

		// Token: 0x0603641F RID: 222239 RVA: 0x00F2139A File Offset: 0x00F1F59A
		private void FishingShipDataRefresh()
		{
			this.RefreshItem();
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.AddAttributeListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
			shipData.AddAttributeListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.FishingShipAttributeRefresh));
		}

		// Token: 0x0401CA5C RID: 117340
		[Nullable(2)]
		private UiPanelBase LowPowerTips;

		// Token: 0x0200B1F5 RID: 45557
		private class EComponentDefine
		{
			// Token: 0x04036FF8 RID: 225272
			public const int Texture = 0;

			// Token: 0x04036FF9 RID: 225273
			public const int CountText = 1;

			// Token: 0x04036FFA RID: 225274
			public const int Button = 2;

			// Token: 0x04036FFB RID: 225275
			public const int TextureButton = 3;

			// Token: 0x04036FFC RID: 225276
			public const int TextureTransition = 4;

			// Token: 0x04036FFD RID: 225277
			public const int SliderItem = 5;

			// Token: 0x04036FFE RID: 225278
			public const int SliderSprite = 6;

			// Token: 0x04036FFF RID: 225279
			public const int SpriteIcon = 7;

			// Token: 0x04037000 RID: 225280
			public const int MaxItem = 8;
		}
	}
}
