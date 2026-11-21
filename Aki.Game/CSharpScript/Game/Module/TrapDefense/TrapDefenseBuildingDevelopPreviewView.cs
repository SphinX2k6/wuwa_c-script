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
	// Token: 0x02003A8B RID: 14987
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopPreviewView : UiViewBase
	{
		// Token: 0x06026835 RID: 157749 RVA: 0x00ACB300 File Offset: 0x00AC9500
		public TrapDefenseBuildingDevelopPreviewView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026836 RID: 157750 RVA: 0x00ACB314 File Offset: 0x00AC9514
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

		// Token: 0x06026837 RID: 157751 RVA: 0x00ACB530 File Offset: 0x00AC9730
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopPreviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopPreviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026838 RID: 157752 RVA: 0x00ACB573 File Offset: 0x00AC9773
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnLevelUp));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x06026839 RID: 157753 RVA: 0x00ACB5AD File Offset: 0x00AC97AD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, new Action<TrapDefenseBuildingDevelopItemData>(this.OnLevelUp));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(this.OnOrganNetUpdate));
		}

		// Token: 0x0602683A RID: 157754 RVA: 0x00ACB5E8 File Offset: 0x00AC97E8
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.LevelLayout = new GenericLayout<TrapDefenseDevelopPreviewLevelPointItem, bool>(base.GetHorizontalLayout(5), new Func<TrapDefenseDevelopPreviewLevelPointItem>(this.CreateLevelPoint), null, false, true);
			this.ScrollView = new GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo>(base.GetScrollViewWithScrollbar(8), new Func<TrapDefenseDevelopPreviewLevelInfoItem>(this.CreateScrollItem), null, false, null);
		}

		// Token: 0x0602683B RID: 157755 RVA: 0x00ACB660 File Offset: 0x00AC9860
		protected override void OnBeforeShow()
		{
			this.UpdateDetailPanel();
		}

		// Token: 0x0602683C RID: 157756 RVA: 0x00ACB668 File Offset: 0x00AC9868
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.ScrollView = null;
			this.LevelLayout = null;
			this.BtnUpgrade = null;
		}

		// Token: 0x0602683D RID: 157757 RVA: 0x00ACB688 File Offset: 0x00AC9888
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

		// Token: 0x0602683E RID: 157758 RVA: 0x00ACB8E0 File Offset: 0x00AC9AE0
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

		// Token: 0x0602683F RID: 157759 RVA: 0x00ACB96C File Offset: 0x00AC9B6C
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

		// Token: 0x06026840 RID: 157760 RVA: 0x00ACB9F4 File Offset: 0x00AC9BF4
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026841 RID: 157761 RVA: 0x00ACB9FD File Offset: 0x00AC9BFD
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

		// Token: 0x06026842 RID: 157762 RVA: 0x00ACBA3A File Offset: 0x00AC9C3A
		private void OnLevelUp(TrapDefenseBuildingDevelopItemData data)
		{
			if (data != this.CurData)
			{
				return;
			}
			this.UpdateDetailPanel();
		}

		// Token: 0x06026843 RID: 157763 RVA: 0x00ACBA4C File Offset: 0x00AC9C4C
		private void OnOrganNetUpdate()
		{
			this.CanLevelUp = this.BtnUpgrade.RefreshButton(this.CurData);
		}

		// Token: 0x06026844 RID: 157764 RVA: 0x00ACBA65 File Offset: 0x00AC9C65
		private TrapDefenseDevelopPreviewLevelPointItem CreateLevelPoint()
		{
			return new TrapDefenseDevelopPreviewLevelPointItem();
		}

		// Token: 0x06026845 RID: 157765 RVA: 0x00ACBA6C File Offset: 0x00AC9C6C
		private TrapDefenseDevelopPreviewLevelInfoItem CreateScrollItem()
		{
			return new TrapDefenseDevelopPreviewLevelInfoItem();
		}

		// Token: 0x06026846 RID: 157766 RVA: 0x00ACBA74 File Offset: 0x00AC9C74
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

		// Token: 0x040151B5 RID: 86453
		protected PopupCaptionItem CaptionItem;

		// Token: 0x040151B6 RID: 86454
		protected GenericScrollViewNew<TrapDefenseDevelopPreviewLevelInfoItem, ITrapDefenseDevelopPreviewLevelInfo> ScrollView;

		// Token: 0x040151B7 RID: 86455
		protected GenericLayout<TrapDefenseDevelopPreviewLevelPointItem, bool> LevelLayout;

		// Token: 0x040151B8 RID: 86456
		protected TrapDefenseBuildingUpgradeItem BtnUpgrade;

		// Token: 0x040151B9 RID: 86457
		protected List<TrapDefenseBuildingDevelopItemData> ItemList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x040151BA RID: 86458
		protected TrapDefenseBuildingDevelopItemData CurData;

		// Token: 0x040151BB RID: 86459
		protected bool CanLevelUp;

		// Token: 0x040151BC RID: 86460
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009693 RID: 38547
		[NullableContext(0)]
		internal class EMainDefine
		{
			// Token: 0x0402F038 RID: 192568
			public const int CaptionItem = 0;

			// Token: 0x0402F039 RID: 192569
			public const int TexIcon = 1;

			// Token: 0x0402F03A RID: 192570
			public const int TxtTitle = 2;

			// Token: 0x0402F03B RID: 192571
			public const int PanelLayout = 3;

			// Token: 0x0402F03C RID: 192572
			public const int ArtTxtLevel = 4;

			// Token: 0x0402F03D RID: 192573
			public const int LevelLayout = 5;

			// Token: 0x0402F03E RID: 192574
			public const int LevelPoint = 6;

			// Token: 0x0402F03F RID: 192575
			public const int BtnUpgrade = 7;

			// Token: 0x0402F040 RID: 192576
			public const int ScrollView = 8;

			// Token: 0x0402F041 RID: 192577
			public const int InfoItem = 9;

			// Token: 0x0402F042 RID: 192578
			public const int BtnLeft = 10;

			// Token: 0x0402F043 RID: 192579
			public const int BtnRight = 11;
		}
	}
}
