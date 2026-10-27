using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE3 RID: 19171
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopPreviewView : UiViewBase
	{
		// Token: 0x06031AA5 RID: 203429 RVA: 0x00B8734C File Offset: 0x00B8554C
		public TrapDefenseBuildingDevelopPreviewView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031AA6 RID: 203430 RVA: 0x00B87360 File Offset: 0x00B85560
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AA7 RID: 203431 RVA: 0x00B8757C File Offset: 0x00B8577C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopPreviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopPreviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031AA8 RID: 203432 RVA: 0x00B875BF File Offset: 0x00B857BF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnLevelUp));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x06031AA9 RID: 203433 RVA: 0x00B875F9 File Offset: 0x00B857F9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnLevelUp));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x06031AAA RID: 203434 RVA: 0x00B87634 File Offset: 0x00B85834
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.LevelLayout = new GenericLayout<TrapDefenseDevelopPreviewLevelPointItem, bool>(base.GetHorizontalLayout(5), new Func<TrapDefenseDevelopPreviewLevelPointItem>(this.CreateLevelPoint), null, false, true);
			this.ScrollView = new GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo>(base.GetScrollViewWithScrollbar(8), new Func<TrapDefenseDevelopPreviewLevelInfoItem>(this.CreateScrollItem), null, false, null);
		}

		// Token: 0x06031AAB RID: 203435 RVA: 0x00B876AC File Offset: 0x00B858AC
		protected override void OnBeforeShow()
		{
			this.UpdateDetailPanel();
		}

		// Token: 0x06031AAC RID: 203436 RVA: 0x00B876B4 File Offset: 0x00B858B4
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.ScrollView = null;
			this.LevelLayout = null;
			this.BtnUpgrade = null;
		}

		// Token: 0x06031AAD RID: 203437 RVA: 0x00B876D4 File Offset: 0x00B858D4
		protected void UpdateDetailPanel()
		{
			if (this.CurData == null)
			{
				return;
			}
			TrapDefenseBuildingTypeData developTabByData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetDevelopTabByData(this.CurData);
			if (developTabByData != null)
			{
				developTabByData.TempSelectedData = this.CurData;
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(this.CurData.GetIsUnlock());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.CurData.GetName(), Array.Empty<object>());
			base.SetTextureByPath(this.CurData.GetIconPath(), base.GetTexture(1), null, null);
			int level = this.CurData.GetLevel();
			UUIArtText artText = base.GetArtText(4);
			if (artText != null)
			{
				string text;
				if (level < 10)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("0");
					defaultInterpolatedStringHandler.AppendFormatted<int>(level);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(level);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				artText.SetText(text);
			}
			int maxLevel = this.CurData.GetMaxLevel();
			List<bool> list = new List<bool>();
			List<ITrapDefenseDevelopPreviewLevelInfo> list2 = new List<ITrapDefenseDevelopPreviewLevelInfo>();
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(this.CurData.Id);
			for (int i = 1; i <= maxLevel; i++)
			{
				list.Add(i <= level);
				ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
				{
					MachineType = trapDefenseMachineIdInfo.MachineType,
					DataType = trapDefenseMachineIdInfo.DataType,
					Level = i,
					Branch = 0
				};
				int num = TrapDefenseModel.Instance.ComposeMachineId(info);
				TrapDefenseDevelopPreviewLevelInfo item2 = new TrapDefenseDevelopPreviewLevelInfo
				{
					Id = ((i == level) ? this.CurData.Id : num),
					IsCurLevel = (i == level && this.CurData.GetIsUnlock())
				};
				list2.Add(item2);
			}
			this.LevelLayout.RefreshByData(list, null, true);
			this.ScrollView.RefreshByData(list2, delegate
			{
				UUIItem itemByIndex = this.ScrollView.GetItemByIndex(level - 1);
				this.ScrollView.ScrollTo(itemByIndex, false);
			}, true);
			this.CanLevelUp = this.BtnUpgrade.RefreshButton(this.CurData);
			EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingPreviewSelectUpdate, this.CurData);
		}

		// Token: 0x06031AAE RID: 203438 RVA: 0x00B8792C File Offset: 0x00B85B2C
		private void OnClickedLeft()
		{
			if (this.CurData == null)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("SwitchL", false, null, false);
			}
			int num = this.ItemList.IndexOf(this.CurData);
			num--;
			if (num < 0)
			{
				num = this.ItemList.Count - 1;
			}
			this.CurData = this.ItemList[num];
			this.UpdateDetailPanel();
		}

		// Token: 0x06031AAF RID: 203439 RVA: 0x00B879B8 File Offset: 0x00B85BB8
		private void OnClickedRight()
		{
			if (this.CurData == null)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("SwitchR", false, null, false);
			}
			int num = this.ItemList.IndexOf(this.CurData);
			num++;
			if (num >= this.ItemList.Count)
			{
				num = 0;
			}
			this.CurData = this.ItemList[num];
			this.UpdateDetailPanel();
		}

		// Token: 0x06031AB0 RID: 203440 RVA: 0x00B87A40 File Offset: 0x00B85C40
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031AB1 RID: 203441 RVA: 0x00B87A49 File Offset: 0x00B85C49
		private void OnClickedUpgrade()
		{
			if (this.CurData == null)
			{
				return;
			}
			if (!this.CanLevelUp)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Develop_NoEnoughGold", Array.Empty<object>());
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseDevelopLevelUp(this.CurData.Id);
		}

		// Token: 0x06031AB2 RID: 203442 RVA: 0x00B87A86 File Offset: 0x00B85C86
		private void OnLevelUp(TrapDefenseBuildingDevelopItemData data)
		{
			if (data != this.CurData)
			{
				return;
			}
			this.UpdateDetailPanel();
		}

		// Token: 0x06031AB3 RID: 203443 RVA: 0x00B87A98 File Offset: 0x00B85C98
		private void OnOrganNetUpdate()
		{
			this.CanLevelUp = this.BtnUpgrade.RefreshButton(this.CurData);
		}

		// Token: 0x06031AB4 RID: 203444 RVA: 0x00B87AB1 File Offset: 0x00B85CB1
		private TrapDefenseDevelopPreviewLevelPointItem CreateLevelPoint()
		{
			return new TrapDefenseDevelopPreviewLevelPointItem();
		}

		// Token: 0x06031AB5 RID: 203445 RVA: 0x00B87AB8 File Offset: 0x00B85CB8
		private TrapDefenseDevelopPreviewLevelInfoItem CreateScrollItem()
		{
			return new TrapDefenseDevelopPreviewLevelInfoItem();
		}

		// Token: 0x06031AB6 RID: 203446 RVA: 0x00B87AC0 File Offset: 0x00B85CC0
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "MachineUpgradePreview")
			{
				if (configParams.Length < 2)
				{
					return null;
				}
				int num;
				if (!int.TryParse(configParams[1], out num))
				{
					return null;
				}
				if (num >= 0)
				{
					int num2 = num;
					GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> scrollView = this.ScrollView;
					int? num3;
					if (scrollView == null)
					{
						num3 = null;
					}
					else
					{
						GenericLayout<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> genericLayout = scrollView.GetGenericLayout();
						num3 = ((genericLayout != null) ? new int?(genericLayout.GetDatas().Count) : null);
					}
					int? num4 = num3;
					if (num2 < num4.GetValueOrDefault())
					{
						GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> scrollView2 = this.ScrollView;
						UUIItem uuiitem = (scrollView2 != null) ? scrollView2.GetItemByIndex(num) : null;
						if (uuiitem != null)
						{
							GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> scrollView3 = this.ScrollView;
							if (scrollView3 != null)
							{
								scrollView3.ScrollTo(uuiitem, false);
							}
							return new UUIItem[]
							{
								uuiitem,
								uuiitem
							};
						}
						goto IL_B0;
					}
				}
				return null;
			}
			IL_B0:
			return null;
		}

		// Token: 0x0401A863 RID: 108643
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401A864 RID: 108644
		protected GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> ScrollView;

		// Token: 0x0401A865 RID: 108645
		protected GenericLayout<TrapDefenseDevelopPreviewLevelPointItem, bool> LevelLayout;

		// Token: 0x0401A866 RID: 108646
		protected TrapDefenseBuildingUpgradeItem BtnUpgrade;

		// Token: 0x0401A867 RID: 108647
		protected List<TrapDefenseBuildingDevelopItemData> ItemList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x0401A868 RID: 108648
		protected TrapDefenseBuildingDevelopItemData CurData;

		// Token: 0x0401A869 RID: 108649
		protected bool CanLevelUp;

		// Token: 0x0401A86A RID: 108650
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AC73 RID: 44147
		[NullableContext(0)]
		internal class EMainDefine
		{
			// Token: 0x04034687 RID: 214663
			public const int CaptionItem = 0;

			// Token: 0x04034688 RID: 214664
			public const int TexIcon = 1;

			// Token: 0x04034689 RID: 214665
			public const int TxtTitle = 2;

			// Token: 0x0403468A RID: 214666
			public const int PanelLayout = 3;

			// Token: 0x0403468B RID: 214667
			public const int ArtTxtLevel = 4;

			// Token: 0x0403468C RID: 214668
			public const int LevelLayout = 5;

			// Token: 0x0403468D RID: 214669
			public const int LevelPoint = 6;

			// Token: 0x0403468E RID: 214670
			public const int BtnUpgrade = 7;

			// Token: 0x0403468F RID: 214671
			public const int ScrollView = 8;

			// Token: 0x04034690 RID: 214672
			public const int InfoItem = 9;

			// Token: 0x04034691 RID: 214673
			public const int BtnLeft = 10;

			// Token: 0x04034692 RID: 214674
			public const int BtnRight = 11;
		}
	}
}
