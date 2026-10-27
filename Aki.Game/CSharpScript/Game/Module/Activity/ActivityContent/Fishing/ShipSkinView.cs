using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006610 RID: 26128
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipSkinView : UiViewBase
	{
		// Token: 0x060417AB RID: 268203 RVA: 0x00FDBEE6 File Offset: 0x00FDA0E6
		public ShipSkinView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060417AC RID: 268204 RVA: 0x00FDBEF0 File Offset: 0x00FDA0F0
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

		// Token: 0x060417AD RID: 268205 RVA: 0x00FDC080 File Offset: 0x00FDA280
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
				ShipSkinItem shipSkinItem2 = scrollItemList.ElementAtOrDefault(0);
				if (shipSkinItem2 == null)
				{
					return;
				}
				shipSkinItem2.SelectToggle();
			}, false);
		}

		// Token: 0x060417AE RID: 268206 RVA: 0x00FDC118 File Offset: 0x00FDA318
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x060417AF RID: 268207 RVA: 0x00FDC136 File Offset: 0x00FDA336
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingShipSkinChangeSuccess, new Action(this.FishingShipSkinChangeSuccess));
		}

		// Token: 0x060417B0 RID: 268208 RVA: 0x00FDC154 File Offset: 0x00FDA354
		private void FishingShipSkinChangeSuccess()
		{
			base.CloseMe(null);
		}

		// Token: 0x060417B1 RID: 268209 RVA: 0x00FDC160 File Offset: 0x00FDA360
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

		// Token: 0x060417B2 RID: 268210 RVA: 0x00FDC244 File Offset: 0x00FDA444
		private ShipSkinItem OnCreateGrid()
		{
			return new ShipSkinItem
			{
				ClickFunc = new Action<UUIExtendToggle, int>(this.OnClickShipSkinItem)
			};
		}

		// Token: 0x060417B3 RID: 268211 RVA: 0x00FDC25D File Offset: 0x00FDA45D
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

		// Token: 0x060417B4 RID: 268212 RVA: 0x00FDC283 File Offset: 0x00FDA483
		private void OnClickConfirmBtn()
		{
			FishingController.Instance.RequestFishingShipSkinChange(this.SelectShipSkinId);
		}

		// Token: 0x060417B5 RID: 268213 RVA: 0x00FDC298 File Offset: 0x00FDA498
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

		// Token: 0x04022138 RID: 139576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<ShipSkinItem, int> ScrollView;

		// Token: 0x04022139 RID: 139577
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0402213A RID: 139578
		private int SelectShipSkinId;

		// Token: 0x0200C81F RID: 51231
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C703 RID: 247555
			public const int TitleText = 0;

			// Token: 0x0403C704 RID: 247556
			public const int DesText = 1;

			// Token: 0x0403C705 RID: 247557
			public const int ShipSkinScrollView = 2;

			// Token: 0x0403C706 RID: 247558
			public const int ShipSkinLoopScrollItem = 3;

			// Token: 0x0403C707 RID: 247559
			public const int ShipSkinNameText = 4;

			// Token: 0x0403C708 RID: 247560
			public const int EffectText = 5;

			// Token: 0x0403C709 RID: 247561
			public const int ConfirmBtn = 6;

			// Token: 0x0403C70A RID: 247562
			public const int LockItem = 7;

			// Token: 0x0403C70B RID: 247563
			public const int LockText = 8;
		}
	}
}
