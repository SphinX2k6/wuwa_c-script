using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200576D RID: 22381
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelDetailView : UiViewBase
	{
		// Token: 0x17006A7B RID: 27259
		// (get) Token: 0x0603736F RID: 226159 RVA: 0x00F69F59 File Offset: 0x00F68159
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x06037370 RID: 226160 RVA: 0x00F69F6A File Offset: 0x00F6816A
		public DangoBrawlLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037371 RID: 226161 RVA: 0x00F69F74 File Offset: 0x00F68174
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

		// Token: 0x06037372 RID: 226162 RVA: 0x00F6A148 File Offset: 0x00F68348
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

		// Token: 0x06037373 RID: 226163 RVA: 0x00F6A1EF File Offset: 0x00F683EF
		protected override void OnBeforeDestroy()
		{
			Action onCloseCallback = this.OnCloseCallback;
			if (onCloseCallback == null)
			{
				return;
			}
			onCloseCallback();
		}

		// Token: 0x06037374 RID: 226164 RVA: 0x00F6A204 File Offset: 0x00F68404
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

		// Token: 0x06037375 RID: 226165 RVA: 0x00F6A2D0 File Offset: 0x00F684D0
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

		// Token: 0x06037376 RID: 226166 RVA: 0x00F6A310 File Offset: 0x00F68510
		private DangoBrawlRetryCountItem CreateRetryCountItem()
		{
			return new DangoBrawlRetryCountItem();
		}

		// Token: 0x06037377 RID: 226167 RVA: 0x00F6A317 File Offset: 0x00F68517
		private DangoBrawlProgressItem CreateWinCupItem()
		{
			return new DangoBrawlProgressItem();
		}

		// Token: 0x06037378 RID: 226168 RVA: 0x00F6A31E File Offset: 0x00F6851E
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D2DA RID: 119514
		private int LevelId;

		// Token: 0x0401D2DB RID: 119515
		private int RetryCount;

		// Token: 0x0401D2DC RID: 119516
		[Nullable(2)]
		private Action OnCloseCallback;

		// Token: 0x0401D2DD RID: 119517
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRetryCountItem, DangoBrawlRetryCountInfo> RetryCountLayout;

		// Token: 0x0401D2DE RID: 119518
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlProgressItem, DangoBrawlProgressItemData> WinCupLayout;

		// Token: 0x0200B382 RID: 45954
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040377CE RID: 227278
			BtnCloseMask,
			// Token: 0x040377CF RID: 227279
			BtnClosePopup,
			// Token: 0x040377D0 RID: 227280
			TxtWinConditionTitle,
			// Token: 0x040377D1 RID: 227281
			WinCupLayout,
			// Token: 0x040377D2 RID: 227282
			WinCupItem,
			// Token: 0x040377D3 RID: 227283
			TxtRetryCountTitle,
			// Token: 0x040377D4 RID: 227284
			RetryCountLayout,
			// Token: 0x040377D5 RID: 227285
			RetryCountItem,
			// Token: 0x040377D6 RID: 227286
			TxtEnviromentTitle,
			// Token: 0x040377D7 RID: 227287
			TxtEnviromentDesc
		}
	}
}
