using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200681D RID: 26653
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelDetailView : UiViewBase
	{
		// Token: 0x1700973A RID: 38714
		// (get) Token: 0x0604281A RID: 272410 RVA: 0x01028A15 File Offset: 0x01026C15
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x0604281B RID: 272411 RVA: 0x01028A26 File Offset: 0x01026C26
		public DangoBrawlLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604281C RID: 272412 RVA: 0x01028A30 File Offset: 0x01026C30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604281D RID: 272413 RVA: 0x01028C04 File Offset: 0x01026E04
		protected override void OnStart()
		{
			DangoBrawlLevelDetailViewOpenData dangoBrawlLevelDetailViewOpenData = this.OpenParam as DangoBrawlLevelDetailViewOpenData;
			if (dangoBrawlLevelDetailViewOpenData != null)
			{
				this.LevelId = dangoBrawlLevelDetailViewOpenData.LevelId;
				this.RetryCount = dangoBrawlLevelDetailViewOpenData.RetryCount;
				this.OnCloseCallback = dangoBrawlLevelDetailViewOpenData.OnCloseCallback;
			}
			else
			{
				object openParam = this.OpenParam;
				if (openParam is int)
				{
					int levelId = (int)openParam;
					this.LevelId = levelId;
				}
			}
			this.RetryCountLayout = new GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo>(base.GetHorizontalLayout(6), new Func<DangoBrawlRetryCountItem>(this.CreateRetryCountItem), null, false, true);
			this.WinCupLayout = new GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData>(base.GetHorizontalLayout(3), new Func<DangoBrawlProgressItem>(this.CreateWinCupItem), null, false, true);
			this.RefreshView();
		}

		// Token: 0x0604281E RID: 272414 RVA: 0x01028CAB File Offset: 0x01026EAB
		protected override void OnBeforeDestroy()
		{
			Action onCloseCallback = this.OnCloseCallback;
			if (onCloseCallback == null)
			{
				return;
			}
			onCloseCallback();
		}

		// Token: 0x0604281F RID: 272415 RVA: 0x01028CC0 File Offset: 0x01026EC0
		private void RefreshView()
		{
			DangoBrawlLevelData levelData = this.OutGameData.GetLevelData(this.LevelId);
			if (levelData == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DangoBrawlBattleUIText_052", new <>z__ReadOnlySingleElementList<object>(levelData.WinCount));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "DangoBrawlBattleUIText_053", new <>z__ReadOnlySingleElementList<object>(levelData.MaxRetryCount));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), levelData.EnvironmentDesc, Array.Empty<object>());
			this.RetryCountLayout.RefreshByData(DangoBrawlUtil.BuildRetryHeartList(levelData.MaxRetryCount, this.RetryCount, false), null, false);
			GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> winCupLayout = this.WinCupLayout;
			if (winCupLayout == null)
			{
				return;
			}
			winCupLayout.RefreshByData(this.BuildWinCupList(levelData.WinCount), null, false);
		}

		// Token: 0x06042820 RID: 272416 RVA: 0x01028D8C File Offset: 0x01026F8C
		private List<DangoBrawlProgressItemData> BuildWinCupList(int totalCount)
		{
			List<DangoBrawlProgressItemData> list = new List<DangoBrawlProgressItemData>(totalCount);
			for (int i = 0; i < totalCount; i++)
			{
				list.Add(new DangoBrawlProgressItemData(i)
				{
					IsWin = true,
					IsLast = (i == totalCount - 1)
				});
			}
			return list;
		}

		// Token: 0x06042821 RID: 272417 RVA: 0x01028DCC File Offset: 0x01026FCC
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x06042822 RID: 272418 RVA: 0x01028DD3 File Offset: 0x01026FD3
		private DangoBrawlProgressItem CreateWinCupItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x06042823 RID: 272419 RVA: 0x01028DDA File Offset: 0x01026FDA
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022A7D RID: 141949
		private int LevelId;

		// Token: 0x04022A7E RID: 141950
		private int RetryCount;

		// Token: 0x04022A7F RID: 141951
		[Nullable(2)]
		private Action OnCloseCallback;

		// Token: 0x04022A80 RID: 141952
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryCountLayout;

		// Token: 0x04022A81 RID: 141953
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> WinCupLayout;

		// Token: 0x0200C9B5 RID: 51637
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CEE1 RID: 249569
			BtnCloseMask,
			// Token: 0x0403CEE2 RID: 249570
			BtnClosePopup,
			// Token: 0x0403CEE3 RID: 249571
			TxtWinConditionTitle,
			// Token: 0x0403CEE4 RID: 249572
			WinCupLayout,
			// Token: 0x0403CEE5 RID: 249573
			WinCupItem,
			// Token: 0x0403CEE6 RID: 249574
			TxtRetryCountTitle,
			// Token: 0x0403CEE7 RID: 249575
			RetryCountLayout,
			// Token: 0x0403CEE8 RID: 249576
			RetryCountItem,
			// Token: 0x0403CEE9 RID: 249577
			TxtEnviromentTitle,
			// Token: 0x0403CEEA RID: 249578
			TxtEnviromentDesc
		}
	}
}
