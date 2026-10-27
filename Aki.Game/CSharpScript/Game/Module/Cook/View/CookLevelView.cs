using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B17 RID: 23319
	[NullableContext(1)]
	[Nullable(0)]
	public class CookLevelView : UiViewBase
	{
		// Token: 0x0603B078 RID: 241784 RVA: 0x00E1274F File Offset: 0x00E1094F
		public CookLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B079 RID: 241785 RVA: 0x00E12780 File Offset: 0x00E10980
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(delegate()
			{
				this.OnLeft();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(delegate()
			{
				this.OnRight();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B07A RID: 241786 RVA: 0x00E129B9 File Offset: 0x00E10BB9
		protected override void OnBeforeDestroy()
		{
			this.DisableRedDot();
			if (this.RewardItemLayout != null)
			{
				this.RewardItemLayout.ClearChildren();
				this.RewardItemLayout = null;
			}
			this.StarLayout.ClearChildren();
		}

		// Token: 0x0603B07B RID: 241787 RVA: 0x00E129E8 File Offset: 0x00E10BE8
		protected override UniTask OnBeforeStartAsync()
		{
			CookLevelView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookLevelView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B07C RID: 241788 RVA: 0x00E12A2C File Offset: 0x00E10C2C
		protected override void OnStart()
		{
			this.RewardItemLayout = new GenericLayout<LevelRewardItem, IRewardData>(base.GetHorizontalLayout(7), this.InitReward, null, false, true);
			this.TmpRewardItem = new List<IRewardData>();
			LguiUtil.Instance.SetLocalText(base.GetText(12), "CookUpgradeButtonText", Array.Empty<object>());
			this.StarLayout = new GenericLayoutNew<StarItem>(base.GetHorizontalLayout(11), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.OnCreateStarProxy), null);
			CookModel.Instance.CurrentCookViewType = ECookDataType.CookLevel;
			CookModel.Instance.SelectedCookerLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			this.Refresh();
			this.OnShowRedDot();
		}

		// Token: 0x0603B07D RID: 241789 RVA: 0x00E12ACB File Offset: 0x00E10CCB
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.SetTexBgVisible(false);
				}
			}
			this.RefreshConfirmButton();
		}

		// Token: 0x0603B07E RID: 241790 RVA: 0x00E12AF0 File Offset: 0x00E10CF0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<StarItem> OnCreateStarProxy([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			if (data is bool)
			{
				bool state = (bool)data;
				StarItem starItem = new StarItem();
				starItem.CreateThenShowByActor(uiItem.GetOwner(), null);
				starItem.SetState(state);
				return new LayoutItem<StarItem>
				{
					Key = index,
					Value = starItem
				};
			}
			return null;
		}

		// Token: 0x0603B07F RID: 241791 RVA: 0x00E12B42 File Offset: 0x00E10D42
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.CookerLevelMain, this.ConfirmItem.GetRedDot(), null, 0);
		}

		// Token: 0x0603B080 RID: 241792 RVA: 0x00E12B5D File Offset: 0x00E10D5D
		public void DisableRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.CookerLevelMain);
		}

		// Token: 0x0603B081 RID: 241793 RVA: 0x00E12B6B File Offset: 0x00E10D6B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpgradeCookerLevel, new Action(this.ShowRewardView));
		}

		// Token: 0x0603B082 RID: 241794 RVA: 0x00E12B89 File Offset: 0x00E10D89
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpgradeCookerLevel, new Action(this.ShowRewardView));
		}

		// Token: 0x0603B083 RID: 241795 RVA: 0x00E12BA7 File Offset: 0x00E10DA7
		public void ShowView()
		{
			this.SetActive(true);
		}

		// Token: 0x0603B084 RID: 241796 RVA: 0x00E12BB0 File Offset: 0x00E10DB0
		private void Update()
		{
			CookModel.Instance.SelectedCookerLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			this.Refresh();
		}

		// Token: 0x0603B085 RID: 241797 RVA: 0x00E12BD1 File Offset: 0x00E10DD1
		private void ShowRewardView()
		{
			if (this.TmpRewardItem.Count == 0)
			{
				return;
			}
			this.Update();
		}

		// Token: 0x0603B086 RID: 241798 RVA: 0x00E12BE7 File Offset: 0x00E10DE7
		private void Refresh()
		{
			this.RefreshTypeIconTexture();
			this.RefreshName();
			this.RefreshInfo();
			this.RefreshLevel();
			this.RefreshSumExp();
			this.RefreshExpBarSprite();
			this.RefreshConfirmButton();
			this.RefreshRewardList();
			this.RefreshLeftAndRightButtonEnable();
			this.RefreshRewardItem();
		}

		// Token: 0x0603B087 RID: 241799 RVA: 0x00E12C28 File Offset: 0x00E10E28
		private void RefreshTypeIconTexture()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_CookingType");
			base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		}

		// Token: 0x0603B088 RID: 241800 RVA: 0x00E12C60 File Offset: 0x00E10E60
		private void RefreshName()
		{
			CookLevel cookLevelByLevel = CookModel.Instance.GetCookLevelByLevel(CookModel.Instance.SelectedCookerLevel);
			string localText = CookConfig.Instance.GetLocalText(cookLevelByLevel.Name);
			base.GetText(0).SetText(localText, true);
		}

		// Token: 0x0603B089 RID: 241801 RVA: 0x00E12CA4 File Offset: 0x00E10EA4
		private void RefreshInfo()
		{
			CookLevel cookLevelByLevel = CookModel.Instance.GetCookLevelByLevel(CookModel.Instance.SelectedCookerLevel);
			string localText = CookConfig.Instance.GetLocalText(cookLevelByLevel.AttributesDescription);
			base.GetText(1).SetText(localText, true);
		}

		// Token: 0x0603B08A RID: 241802 RVA: 0x00E12CE8 File Offset: 0x00E10EE8
		private void RefreshLevel()
		{
			int cookerMaxLevel = CookModel.Instance.GetCookerMaxLevel();
			List<bool> list = new List<bool>(cookerMaxLevel);
			for (int i = 0; i < CookModel.Instance.SelectedCookerLevel; i++)
			{
				list.Add(true);
			}
			for (int j = CookModel.Instance.SelectedCookerLevel; j < cookerMaxLevel; j++)
			{
				list.Add(false);
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x0603B08B RID: 241803 RVA: 0x00E12D58 File Offset: 0x00E10F58
		private void RefreshSumExp()
		{
			int totalProficiencys = CookModel.Instance.GetCookerInfo().TotalProficiencys;
			string newText;
			if (CookModel.Instance.SelectedCookerLevel == CookModel.Instance.GetCookerMaxLevel())
			{
				newText = "MAX";
			}
			else
			{
				int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.SelectedCookerLevel);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalProficiencys);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(sumExpByLevel);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0603B08C RID: 241804 RVA: 0x00E12DEC File Offset: 0x00E10FEC
		private void RefreshExpBarSprite()
		{
			int totalProficiencys = CookModel.Instance.GetCookerInfo().TotalProficiencys;
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.SelectedCookerLevel);
			double num = MathUtils.Instance.GetFloatPointFloor((double)totalProficiencys / (double)sumExpByLevel, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(3).SetFillAmount((float)num);
		}

		// Token: 0x0603B08D RID: 241805 RVA: 0x00E12E56 File Offset: 0x00E11056
		private void RefreshConfirmButton()
		{
			this.ConfirmItem.SetEnable();
		}

		// Token: 0x0603B08E RID: 241806 RVA: 0x00E12E64 File Offset: 0x00E11064
		private void RefreshRewardList()
		{
			this.TmpRewardItem.Clear();
			int dropIdByLevel = CookModel.Instance.GetDropIdByLevel(CookModel.Instance.SelectedCookerLevel);
			if (dropIdByLevel == -1)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			base.GetItem(8).SetUIActive(true);
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropIdByLevel);
			if (dropPackage != null)
			{
				for (int i = 0; i < dropPackage.Value.DropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = dropPackage.Value.DropPreview(i);
					if (dicIntInt != null)
					{
						int selectedCookerLevel = CookModel.Instance.SelectedCookerLevel;
						int cookingLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
						this.TmpRewardItem.Add(new RewardData
						{
							RewardId = dicIntInt.Value.Key,
							Count = dicIntInt.Value.Value,
							IsGet = (selectedCookerLevel < cookingLevel)
						});
					}
				}
			}
			this.RewardItemLayout.RefreshByData(this.TmpRewardItem, null, false);
		}

		// Token: 0x0603B08F RID: 241807 RVA: 0x00E12F7C File Offset: 0x00E1117C
		private void RefreshLeftAndRightButtonEnable()
		{
			((base.GetButton(5).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CookModel.Instance.SelectedCookerLevel != 1);
			((base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CookModel.Instance.SelectedCookerLevel != CookModel.Instance.GetCookerMaxLevel());
		}

		// Token: 0x0603B090 RID: 241808 RVA: 0x00E13006 File Offset: 0x00E11206
		private void RefreshRewardItem()
		{
			base.GetItem(10).SetUIActive(CookModel.Instance.SelectedCookerLevel != CookModel.Instance.GetCookerMaxLevel());
		}

		// Token: 0x0603B091 RID: 241809 RVA: 0x00E1302E File Offset: 0x00E1122E
		private void OnClick()
		{
			CookController.Instance.SendCertificateLevelRewardRequest();
		}

		// Token: 0x0603B092 RID: 241810 RVA: 0x00E1303A File Offset: 0x00E1123A
		private void OnLeft()
		{
			CookModel.Instance.SelectedCookerLevel--;
			this.Refresh();
		}

		// Token: 0x0603B093 RID: 241811 RVA: 0x00E13054 File Offset: 0x00E11254
		private void OnRight()
		{
			CookModel.Instance.SelectedCookerLevel++;
			this.Refresh();
		}

		// Token: 0x0401ECB0 RID: 126128
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LevelRewardItem, IRewardData> RewardItemLayout;

		// Token: 0x0401ECB1 RID: 126129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRewardData> TmpRewardItem;

		// Token: 0x0401ECB2 RID: 126130
		[Nullable(2)]
		private ConfirmItem ConfirmItem;

		// Token: 0x0401ECB3 RID: 126131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<StarItem> StarLayout;

		// Token: 0x0401ECB4 RID: 126132
		private readonly Func<LevelRewardItem> InitReward = () => new LevelRewardItem();

		// Token: 0x0200BD51 RID: 48465
		[NullableContext(0)]
		public enum ECookLevelDefine
		{
			// Token: 0x0403918F RID: 233871
			NameText,
			// Token: 0x04039190 RID: 233872
			InfoText,
			// Token: 0x04039191 RID: 233873
			SumExpText,
			// Token: 0x04039192 RID: 233874
			ExpBarSprite,
			// Token: 0x04039193 RID: 233875
			ConfirmItem,
			// Token: 0x04039194 RID: 233876
			LeftButton,
			// Token: 0x04039195 RID: 233877
			RightButton,
			// Token: 0x04039196 RID: 233878
			RewardItemHorizontalLayout,
			// Token: 0x04039197 RID: 233879
			RewardLayoutItem,
			// Token: 0x04039198 RID: 233880
			TypeIconTexture,
			// Token: 0x04039199 RID: 233881
			RewardItem,
			// Token: 0x0403919A RID: 233882
			PnlStar,
			// Token: 0x0403919B RID: 233883
			TxtConfirm
		}
	}
}
