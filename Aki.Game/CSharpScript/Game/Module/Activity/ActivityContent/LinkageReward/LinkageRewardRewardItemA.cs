using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x02006558 RID: 25944
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LinkageRewardRewardItemA : GridProxyAbstract<TimePointRewardData>
	{
		// Token: 0x06041034 RID: 266292 RVA: 0x00FC1A60 File Offset: 0x00FBFC60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06041035 RID: 266293 RVA: 0x00FC1BBC File Offset: 0x00FBFDBC
		protected override UniTask OnBeforeStartAsync()
		{
			LinkageRewardRewardItemA.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LinkageRewardRewardItemA.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041036 RID: 266294 RVA: 0x00FC1BFF File Offset: 0x00FBFDFF
		[NullableContext(1)]
		public override void Refresh(TimePointRewardData data, bool isSelected, int gridIndex)
		{
			this.RefreshWithNextState(data, isSelected, gridIndex, false);
		}

		// Token: 0x06041037 RID: 266295 RVA: 0x00FC1C0C File Offset: 0x00FBFE0C
		[NullableContext(1)]
		public void RefreshWithNextState(TimePointRewardData data, bool isSelected, int gridIndex, bool hasConnector)
		{
			this.Data = data;
			base.GridIndex = gridIndex;
			UUISprite sprite = base.GetSprite(4);
			UUISprite sprite2 = base.GetSprite(5);
			UUISprite sprite3 = base.GetSprite(6);
			UUIItem item = base.GetItem(8);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (data == null)
			{
				return;
			}
			LinkageReward? byId = LinkageRewardActivityConfig.Instance.GetById(data.Id);
			int num = (((byId != null) ? byId.GetValueOrDefault().KeepDropId : 0) > 0) ? byId.Value.KeepDropId : ((byId != null) ? byId.GetValueOrDefault().DropId : 0);
			if (num <= 0)
			{
				return;
			}
			ETimePointRewardState rewardState = data.RewardState;
			this.ApplyConnectorLineState(hasConnector, rewardState > ETimePointRewardState.Lock);
			this.ApplyBackgroundState(rewardState);
			if (sprite != null)
			{
				sprite.SetUIActive(rewardState == ETimePointRewardState.Lock);
			}
			if (sprite2 != null)
			{
				sprite2.SetUIActive(rewardState == ETimePointRewardState.UnlockAndUnClaimed);
			}
			if (sprite3 != null)
			{
				sprite3.SetUIActive(rewardState == ETimePointRewardState.UnlockAndClaimed);
			}
			if (item != null)
			{
				item.SetUIActive(rewardState == ETimePointRewardState.UnlockAndUnClaimed);
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(num);
			if (dropPackagePreviewItemList.Count <= 0 || this.RewardItemGrid == null)
			{
				return;
			}
			TItem titem = dropPackagePreviewItemList[0];
			this.TipItemConfigId = titem.ItemData.ItemId;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = this.Data,
				ItemConfigId = new int?(titem.ItemData.ItemId),
				BottomText = titem.Count.ToString(),
				IsLockVisible = new bool?(rewardState == ETimePointRewardState.Lock),
				IsReceivableVisible = new bool?(false),
				IsReceivedVisible = new bool?(rewardState == ETimePointRewardState.UnlockAndClaimed)
			};
			this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x06041038 RID: 266296 RVA: 0x00FC1DE4 File Offset: 0x00FBFFE4
		private void ApplyConnectorLineState(bool hasConnector, bool isConnectorCompleted)
		{
			UUISprite[] array = new UUISprite[]
			{
				base.GetSprite(1),
				base.GetSprite(2),
				base.GetSprite(3)
			};
			UUISprite uuisprite = array[1];
			foreach (UUISprite uuisprite2 in array)
			{
				if (uuisprite2 != null)
				{
					uuisprite2.SetUIActive(hasConnector);
				}
			}
			if (!hasConnector || uuisprite == null)
			{
				return;
			}
			FColor changeColor = uuisprite.changeColor;
			foreach (UUISprite uuisprite3 in array)
			{
				if (uuisprite3 != null)
				{
					uuisprite3.changeColor = changeColor;
					uuisprite3.useChangeColor = isConnectorCompleted;
					UUIItem uuiitem = uuisprite3;
					FColor? fcolor = new FColor?(changeColor);
					uuiitem.SetChangeColor(isConnectorCompleted, fcolor);
				}
			}
		}

		// Token: 0x06041039 RID: 266297 RVA: 0x00FC1E8C File Offset: 0x00FC008C
		private void ApplyBackgroundState(ETimePointRewardState state)
		{
			UUISprite bg = base.GetSprite(0);
			if (bg == null)
			{
				return;
			}
			string resourceId = "SP_CyberWelfareItemABgLock";
			if (state == ETimePointRewardState.UnlockAndUnClaimed)
			{
				resourceId = "SP_CyberWelfareItemABgSelect";
			}
			else if (state == ETimePointRewardState.UnlockAndClaimed)
			{
				resourceId = "SP_CyberWelfareItemABgFinish";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				return;
			}
			bg.SetUIActive(false);
			this.SetSpriteByPath(resourcePath, bg, false, null, delegate(bool _)
			{
				bg.SetUIActive(true);
			});
		}

		// Token: 0x0604103A RID: 266298 RVA: 0x00FC1F18 File Offset: 0x00FC0118
		private void OnClickedGrid()
		{
			TimePointRewardData data = this.Data;
			if (data == null || data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
			{
				if (this.TipItemConfigId > 0)
				{
					this.TryFocusCurrentItem();
					ItemController.Instance.OpenItemTipsByItemId(this.TipItemConfigId, true, delegate(bool _, int _)
					{
						TimerSystem.Instance.Next(delegate(float _)
						{
							this.TryFocusCurrentItem();
						}, null, null);
					});
				}
				return;
			}
			Action<int, int, bool> onClickToGet = this.OnClickToGet;
			if (onClickToGet == null)
			{
				return;
			}
			onClickToGet(this.Data.Id, base.GridIndex, true);
		}

		// Token: 0x0604103B RID: 266299 RVA: 0x00FC1F8C File Offset: 0x00FC018C
		private void TryFocusCurrentItem()
		{
			SmallItemGrid rewardItemGrid = this.RewardItemGrid;
			UUIItem uuiitem;
			if (rewardItemGrid == null)
			{
				uuiitem = null;
			}
			else
			{
				UUIExtendToggle itemGridExtendToggle = rewardItemGrid.GetItemGridExtendToggle();
				uuiitem = ((itemGridExtendToggle != null) ? itemGridExtendToggle.RootUIComp.Get() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null || !uuiitem2.IsValid())
			{
				UUIItem rootItem = base.GetRootItem();
				if (rootItem != null && rootItem.IsValid())
				{
					UiNavigationNewController instance = UiNavigationNewController.Instance;
					if (instance == null)
					{
						return;
					}
					instance.SetNavigationFocusForView(rootItem, true, false, false);
				}
				return;
			}
			UiNavigationNewController instance2 = UiNavigationNewController.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.SetNavigationFocusForView(uuiitem2, true, false, false);
		}

		// Token: 0x04021E5D RID: 138845
		private TimePointRewardData Data;

		// Token: 0x04021E5E RID: 138846
		private SmallItemGrid RewardItemGrid;

		// Token: 0x04021E5F RID: 138847
		private int TipItemConfigId;

		// Token: 0x04021E60 RID: 138848
		public Action<int, int, bool> OnClickToGet;

		// Token: 0x0200C74E RID: 51022
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403C373 RID: 246643
			public const int SprBg = 0;

			// Token: 0x0403C374 RID: 246644
			public const int SprLine = 1;

			// Token: 0x0403C375 RID: 246645
			public const int SprLine2 = 2;

			// Token: 0x0403C376 RID: 246646
			public const int SprLine3 = 3;

			// Token: 0x0403C377 RID: 246647
			public const int SprLock = 4;

			// Token: 0x0403C378 RID: 246648
			public const int SprSelect = 5;

			// Token: 0x0403C379 RID: 246649
			public const int SprFinish = 6;

			// Token: 0x0403C37A RID: 246650
			public const int ItemBaseB2 = 7;

			// Token: 0x0403C37B RID: 246651
			public const int ItemRedDot = 8;
		}
	}
}
