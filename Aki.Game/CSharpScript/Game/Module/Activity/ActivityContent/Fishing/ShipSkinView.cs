using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200558E RID: 21902
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipSkinView : UiViewBase
	{
		// Token: 0x06036470 RID: 222320 RVA: 0x00F22F66 File Offset: 0x00F21166
		public ShipSkinView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06036471 RID: 222321 RVA: 0x00F22F70 File Offset: 0x00F21170
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036472 RID: 222322 RVA: 0x00F23100 File Offset: 0x00F21300
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<ShipSkinItem, int>(base.GetScrollViewWithScrollbar(2), new Func<ShipSkinItem>(this.OnCreateGrid), null, false, null);
			IEnumerable<FishingShipSkin> allFishingSkinConfig = FishingConfig.Instance.GetAllFishingSkinConfig();
			List<int> list = new List<int>();
			foreach (FishingShipSkin fishingShipSkin in allFishingSkinConfig)
			{
				list.Add(fishingShipSkin.Id);
			}
			this.ScrollView.RefreshByData(list, delegate
			{
				this.SelectShipSkinId = FishingModel.Instance.CurrentShipSkin;
				List<ShipSkinItem> scrollItemList = this.ScrollView.GetScrollItemList();
				foreach (ShipSkinItem shipSkinItem in scrollItemList)
				{
					if (shipSkinItem.SkinId == this.SelectShipSkinId)
					{
						shipSkinItem.SelectToggle();
						return;
					}
				}
				ShipSkinItem shipSkinItem2 = (scrollItemList.Count > 0) ? scrollItemList[0] : null;
				if (shipSkinItem2 == null)
				{
					return;
				}
				shipSkinItem2.SelectToggle();
			}, false);
		}

		// Token: 0x06036473 RID: 222323 RVA: 0x00F23198 File Offset: 0x00F21398
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x06036474 RID: 222324 RVA: 0x00F231B6 File Offset: 0x00F213B6
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x06036475 RID: 222325 RVA: 0x00F231D4 File Offset: 0x00F213D4
		private void FishingShipSkinChangeSuccess()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036476 RID: 222326 RVA: 0x00F231E0 File Offset: 0x00F213E0
		private void RefreshView(int skinId)
		{
			this.SelectShipSkinId = skinId;
			FishingShipSkin fishingShipSkinConfig = FishingConfig.Instance.GetFishingShipSkinConfig(skinId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), fishingShipSkinConfig.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), fishingShipSkinConfig.DesText, Array.Empty<object>());
			if (FishingModel.Instance.UnlockShipSkin.Contains(this.SelectShipSkinId))
			{
				base.GetButton(6).RootUIComp.Get().SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
			}
			else
			{
				base.GetButton(6).RootUIComp.Get().SetUIActive(false);
				base.GetItem(7).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), fishingShipSkinConfig.LockText, Array.Empty<object>());
			}
			this.ReadItemNewFlag();
		}

		// Token: 0x06036477 RID: 222327 RVA: 0x00F232C4 File Offset: 0x00F214C4
		private ShipSkinItem OnCreateGrid()
		{
			return new ShipSkinItem
			{
				ClickFunc = new Action<UUIExtendToggle, int>(this.OnClickShipSkinItem)
			};
		}

		// Token: 0x06036478 RID: 222328 RVA: 0x00F232DD File Offset: 0x00F214DD
		private void OnClickShipSkinItem(UUIExtendToggle toggle, int skinId)
		{
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectToggle = toggle;
			this.RefreshView(skinId);
		}

		// Token: 0x06036479 RID: 222329 RVA: 0x00F23303 File Offset: 0x00F21503
		private void OnClickConfirmBtn()
		{
			FishingController.Instance.RequestFishingShipSkinChange(this.SelectShipSkinId);
		}

		// Token: 0x0603647A RID: 222330 RVA: 0x00F23318 File Offset: 0x00F21518
		private void ReadItemNewFlag()
		{
			if (!FishingModel.Instance.UnlockShipSkin.Contains(this.SelectShipSkinId))
			{
				return;
			}
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.FishingShipSkinRecord, this.SelectShipSkinId);
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.FishingShipSkinRecord);
			EventSystem.Instance.Emit(EEventName.FishingShipSkinClick);
		}

		// Token: 0x0401CA69 RID: 117353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<ShipSkinItem, int> ScrollView;

		// Token: 0x0401CA6A RID: 117354
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401CA6B RID: 117355
		private int SelectShipSkinId;

		// Token: 0x0200B202 RID: 45570
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403704B RID: 225355
			public const int TitleText = 0;

			// Token: 0x0403704C RID: 225356
			public const int DesText = 1;

			// Token: 0x0403704D RID: 225357
			public const int ShipSkinScrollView = 2;

			// Token: 0x0403704E RID: 225358
			public const int ShipSkinLoopScrollItem = 3;

			// Token: 0x0403704F RID: 225359
			public const int ShipSkinNameText = 4;

			// Token: 0x04037050 RID: 225360
			public const int EffectText = 5;

			// Token: 0x04037051 RID: 225361
			public const int ConfirmBtn = 6;

			// Token: 0x04037052 RID: 225362
			public const int LockItem = 7;

			// Token: 0x04037053 RID: 225363
			public const int LockText = 8;
		}
	}
}
