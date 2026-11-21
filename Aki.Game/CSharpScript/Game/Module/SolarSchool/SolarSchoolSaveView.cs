using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A05 RID: 23045
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolSaveView : UiViewBase
	{
		// Token: 0x17006C65 RID: 27749
		// (get) Token: 0x06038BEE RID: 232430 RVA: 0x00FE1FFE File Offset: 0x00FE01FE
		private bool IsSaveMode
		{
			get
			{
				return this.Mode == ESolarSchoolSaveViewMode.Save;
			}
		}

		// Token: 0x06038BEF RID: 232431 RVA: 0x00FE2009 File Offset: 0x00FE0209
		public SolarSchoolSaveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038BF0 RID: 232432 RVA: 0x00FE201C File Offset: 0x00FE021C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038BF1 RID: 232433 RVA: 0x00FE2170 File Offset: 0x00FE0370
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolSaveView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolSaveView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BF2 RID: 232434 RVA: 0x00FE21B3 File Offset: 0x00FE03B3
		protected override void OnStart()
		{
			this.RefreshSlots();
			GenericScrollViewNew<SolarSchoolSaveSlotItem, SolarSchoolSaveSlotData> slotScroll = this.SlotScroll;
			if (slotScroll == null)
			{
				return;
			}
			slotScroll.PlayTurnAnimation();
		}

		// Token: 0x06038BF3 RID: 232435 RVA: 0x00FE21CB File Offset: 0x00FE03CB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolSaveUpdate, new Action(this.RefreshSlots));
		}

		// Token: 0x06038BF4 RID: 232436 RVA: 0x00FE21E9 File Offset: 0x00FE03E9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolSaveUpdate, new Action(this.RefreshSlots));
		}

		// Token: 0x06038BF5 RID: 232437 RVA: 0x00FE2207 File Offset: 0x00FE0407
		private SolarSchoolSaveSlotItem CreateSlotItem()
		{
			return new SolarSchoolSaveSlotItem
			{
				ClickCallback = new Action<SolarSchoolSaveSlotData>(this.OnSlotClick)
			};
		}

		// Token: 0x06038BF6 RID: 232438 RVA: 0x00FE2220 File Offset: 0x00FE0420
		private void RefreshSlots()
		{
			SolarSchoolActivityData activityData = SolarSchoolModel.Instance.GetActivityData(this.ActivityId);
			if (activityData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 存读档界面刷新失败：取不到活动数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", this.ActivityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int saveSlotCount = SolarSchoolConfig.Instance.GetSaveSlotCount(this.ActivityId);
			int lastSavedSlotId = SolarSchoolSaveView.GetLastSavedSlotId(activityData, saveSlotCount);
			List<SolarSchoolSaveSlotData> list = new List<SolarSchoolSaveSlotData>();
			for (int i = 0; i < saveSlotCount; i++)
			{
				list.Add(new SolarSchoolSaveSlotData
				{
					ActivityId = this.ActivityId,
					SlotId = i,
					Mode = this.Mode,
					Preview = activityData.GetSavePreview(i),
					IsLastSaved = (i == lastSavedSlotId)
				});
			}
			GenericScrollViewNew<SolarSchoolSaveSlotItem, SolarSchoolSaveSlotData> slotScroll = this.SlotScroll;
			if (slotScroll == null)
			{
				return;
			}
			slotScroll.RefreshByData(list, null, false);
		}

		// Token: 0x06038BF7 RID: 232439 RVA: 0x00FE22FC File Offset: 0x00FE04FC
		private static int GetLastSavedSlotId(SolarSchoolActivityData activityData, int slotCount)
		{
			int result = -1;
			long num = 0L;
			for (int i = 0; i < slotCount; i++)
			{
				if (i != 0)
				{
					SolarSchoolSavePreviewPb savePreview = activityData.GetSavePreview(i);
					if (savePreview != null && savePreview.LastSaveTime > num)
					{
						result = i;
						num = savePreview.LastSaveTime;
					}
				}
			}
			return result;
		}

		// Token: 0x06038BF8 RID: 232440 RVA: 0x00FE233C File Offset: 0x00FE053C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length < 2 || configParams[0] != "SaveSlot" || !int.TryParse(configParams[1], out num) || num < 0)
			{
				return null;
			}
			GenericScrollViewNew<SolarSchoolSaveSlotItem, SolarSchoolSaveSlotData> slotScroll = this.SlotScroll;
			UUIItem uuiitem;
			if (slotScroll == null)
			{
				uuiitem = null;
			}
			else
			{
				GenericLayout<SolarSchoolSaveSlotItem, SolarSchoolSaveSlotData> genericLayout = slotScroll.GetGenericLayout();
				if (genericLayout == null)
				{
					uuiitem = null;
				}
				else
				{
					SolarSchoolSaveSlotItem layoutItemByIndex = genericLayout.GetLayoutItemByIndex(num);
					uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetGuideSlotItem() : null);
				}
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			this.SlotScroll.ScrollTo(uuiitem2, false);
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x06038BF9 RID: 232441 RVA: 0x00FE23BC File Offset: 0x00FE05BC
		private void OnSlotClick(SolarSchoolSaveSlotData data)
		{
			if (this.IsSaveMode)
			{
				this.AskConfirm(EConfirmBoxConfigId.SolarSchoolSaveOverwriteConfirm, delegate
				{
					this.DoSave(data.SlotId);
				});
				return;
			}
			EConfirmBoxConfigId configId = SolarSchoolGamePlayModel.Instance.IsInGamePlay ? EConfirmBoxConfigId.SolarSchoolLoadConfirm : EConfirmBoxConfigId.SolarSchoolEntranceLoadConfirm;
			this.AskConfirm(configId, delegate
			{
				this.DoLoad(data.SlotId);
			});
		}

		// Token: 0x06038BFA RID: 232442 RVA: 0x00FE242C File Offset: 0x00FE062C
		private void AskConfirm(EConfirmBoxConfigId configId, Action onConfirm)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(configId);
			confirmBoxDataNew.FunctionMap[2] = onConfirm;
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 存读档确认框弹出失败，检查 ConfirmBox 配表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", (int)configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06038BFB RID: 232443 RVA: 0x00FE248A File Offset: 0x00FE068A
		private void DoSave(int slotId)
		{
			if (!this.CloseAfterSaved)
			{
				SolarSchoolController.Instance.SendManualSave(slotId, null);
				return;
			}
			if (this.IsSaving)
			{
				return;
			}
			this.IsSaving = true;
			SolarSchoolController.Instance.SendManualSave(slotId, delegate(bool ok)
			{
				this.IsSaving = false;
				if (!ok)
				{
					return;
				}
				this.CloseSelf();
			});
		}

		// Token: 0x06038BFC RID: 232444 RVA: 0x00FE24C8 File Offset: 0x00FE06C8
		private void DoLoad(int slotId)
		{
			if (this.IsLoading)
			{
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
				return;
			}
			if (!SolarSchoolModel.Instance.OpenLoadingView())
			{
				return;
			}
			this.IsLoading = true;
			SolarSchoolController.Instance.RequestLoad(this.ActivityId, slotId, delegate(bool ok)
			{
				this.IsLoading = false;
				if (!ok)
				{
					SolarSchoolModel.Instance.CloseLoadingView();
					return;
				}
				this.ReturnToSettingOnClose = false;
				this.CloseSelf();
			}, null);
		}

		// Token: 0x06038BFD RID: 232445 RVA: 0x00FE2534 File Offset: 0x00FE0734
		protected override void OnAfterDestroy()
		{
			if (this.IsDestroyByClear)
			{
				return;
			}
			Action closeCallback = this.CloseCallback;
			this.CloseCallback = null;
			if (closeCallback != null)
			{
				closeCallback();
			}
			if (!this.ReturnToSettingOnClose || !SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				SolarSchoolModel.Instance.CloseSettingView();
				return;
			}
			SolarSchoolModel.Instance.ShowSettingView();
		}

		// Token: 0x0401DDFB RID: 122363
		[Nullable(2)]
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0401DDFC RID: 122364
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolSaveSlotItem, SolarSchoolSaveSlotData> SlotScroll;

		// Token: 0x0401DDFD RID: 122365
		private int ActivityId;

		// Token: 0x0401DDFE RID: 122366
		private ESolarSchoolSaveViewMode Mode = ESolarSchoolSaveViewMode.Save;

		// Token: 0x0401DDFF RID: 122367
		private bool IsLoading;

		// Token: 0x0401DE00 RID: 122368
		private bool IsSaving;

		// Token: 0x0401DE01 RID: 122369
		private bool ReturnToSettingOnClose;

		// Token: 0x0401DE02 RID: 122370
		private bool CloseAfterSaved;

		// Token: 0x0401DE03 RID: 122371
		[Nullable(2)]
		private Action CloseCallback;

		// Token: 0x0200B5B4 RID: 46516
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038303 RID: 230147
			public const int CaptionItem = 0;

			// Token: 0x04038304 RID: 230148
			public const int TexBg01 = 1;

			// Token: 0x04038305 RID: 230149
			public const int TexBg02 = 2;

			// Token: 0x04038306 RID: 230150
			public const int PnlTitleSave = 3;

			// Token: 0x04038307 RID: 230151
			public const int PnlTitleLoad = 4;

			// Token: 0x04038308 RID: 230152
			public const int SvInfo = 5;

			// Token: 0x04038309 RID: 230153
			public const int SaveItem = 6;

			// Token: 0x0403830A RID: 230154
			public const int SpriteLoad = 7;

			// Token: 0x0403830B RID: 230155
			public const int SpriteSave = 8;
		}
	}
}
