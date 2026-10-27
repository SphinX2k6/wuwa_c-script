using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002551 RID: 9553
[NullableContext(1)]
[Nullable(0)]
public class PhonographView : UiTickViewBase
{
	// Token: 0x060133EA RID: 78826 RVA: 0x004C9303 File Offset: 0x004C7503
	public PhonographView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060133EB RID: 78827 RVA: 0x004C9318 File Offset: 0x004C7518
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickSetBgMusic)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickLimitTimeRule))
		};
	}

	// Token: 0x060133EC RID: 78828 RVA: 0x004C9490 File Offset: 0x004C7690
	protected override UniTask OnBeforeStartAsync()
	{
		PhonographView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhonographView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060133ED RID: 78829 RVA: 0x004C94D3 File Offset: 0x004C76D3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhonographMusicForceRefresh, new Action<int>(this.OnMusicForceRefresh));
	}

	// Token: 0x060133EE RID: 78830 RVA: 0x004C94F1 File Offset: 0x004C76F1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhonographMusicForceRefresh, new Action<int>(this.OnMusicForceRefresh));
	}

	// Token: 0x060133EF RID: 78831 RVA: 0x004C9510 File Offset: 0x004C7710
	protected override void OnTick(float delta)
	{
		if (this.MusicGenericLayout.IsLock)
		{
			return;
		}
		foreach (PhonographMusicPlayItem phonographMusicPlayItem in this.MusicGenericLayout.GetLayoutItemList())
		{
			phonographMusicPlayItem.OnTick();
		}
	}

	// Token: 0x060133F0 RID: 78832 RVA: 0x004C9574 File Offset: 0x004C7774
	protected override void OnBeforeDestroy()
	{
		PhonographModel.Instance.NewMusicIds = new List<int>();
		if (PhonographModel.Instance.IsGlobal)
		{
			if (PhonographModel.Instance.CurrentPlayMusicId != PhonographModel.Instance.RecordMusicId)
			{
				PhonographController.Instance.StopMusic(false);
				if (PhonographModel.Instance.RecordMusicId != 0)
				{
					PhonographController.Instance.PlayGlobalMusic(PhonographModel.Instance.RecordMusicId, true);
					return;
				}
			}
		}
		else if (PhonographModel.Instance.CurrentPlayMusicId != PhonographModel.Instance.RecordMusicId)
		{
			PhonographController.Instance.StopMusic(false);
			PhonographModel instance = PhonographModel.Instance;
			int? num = (instance != null) ? instance.EntityId : null;
			if (PhonographModel.Instance.RecordMusicId != 0)
			{
				int musicId = PhonographController.Instance.PlayMusic(PhonographModel.Instance.RecordMusicId, false);
				PhonographModel.Instance.SetPlayIdRecord(num.Value, musicId);
			}
		}
	}

	// Token: 0x060133F1 RID: 78833 RVA: 0x004C9658 File Offset: 0x004C7858
	protected UniTask RefreshAlbumList(int selectMusicId)
	{
		PhonographView.<RefreshAlbumList>d__16 <RefreshAlbumList>d__;
		<RefreshAlbumList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAlbumList>d__.<>4__this = this;
		<RefreshAlbumList>d__.selectMusicId = selectMusicId;
		<RefreshAlbumList>d__.<>1__state = -1;
		<RefreshAlbumList>d__.<>t__builder.Start<PhonographView.<RefreshAlbumList>d__16>(ref <RefreshAlbumList>d__);
		return <RefreshAlbumList>d__.<>t__builder.Task;
	}

	// Token: 0x060133F2 RID: 78834 RVA: 0x004C96A4 File Offset: 0x004C78A4
	protected void RefreshAlbumInfo(int albumId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographAlbum? phonographAlbum = (instance != null) ? instance.GetMusicAlbumById(albumId) : null;
		if (phonographAlbum == null)
		{
			return;
		}
		PhonographAlbum value = phonographAlbum.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.Desc, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Title, Array.Empty<object>());
		MotorcycleMusicPlayerModel instance2 = MotorcycleMusicPlayerModel.Instance;
		if (instance2 != null && instance2.IsTimeLimitAlbum(albumId))
		{
			UUIButtonComponent button = base.GetButton(12);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(true);
			return;
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(12);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060133F3 RID: 78835 RVA: 0x004C9794 File Offset: 0x004C7994
	protected void OnClickLimitTimeRule()
	{
		HelpController.Instance.OpenHelpById(653);
	}

	// Token: 0x060133F4 RID: 78836 RVA: 0x004C97A8 File Offset: 0x004C79A8
	protected void RefreshMusicInfo(int musicId)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return;
		}
		PhonographMusic value = phonographMusic.Value;
		if (PhonographModel.Instance.IsUnlockMusic(musicId))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.Desc, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.UnlockConditionText, Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Title, Array.Empty<object>());
		this.RefreshSwitchBtn(musicId);
	}

	// Token: 0x060133F5 RID: 78837 RVA: 0x004C9850 File Offset: 0x004C7A50
	protected void RefreshSwitchBtn(int musicId)
	{
		UUIItem rootComponent = base.GetButton(7).GetRootComponent();
		if (rootComponent != null)
		{
			rootComponent.SetUIActive(musicId != 0 && PhonographModel.Instance.IsUnlockMusic(musicId));
		}
		bool flag = PhonographModel.Instance.RecordMusicId == musicId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), flag ? "PhonographSwitchBtnNormal" : "PhonographSwitchBtnSelect", Array.Empty<object>());
	}

	// Token: 0x060133F6 RID: 78838 RVA: 0x004C98B9 File Offset: 0x004C7AB9
	protected PhonographAlbumItem OnCreateAlbumItem()
	{
		return new PhonographAlbumItem
		{
			OnClickAlbumItem = new Action<int, int>(this.OnClickAlbumItem)
		};
	}

	// Token: 0x060133F7 RID: 78839 RVA: 0x004C98D2 File Offset: 0x004C7AD2
	protected PhonographMusicPlayItem OnCreateMusicItem()
	{
		return new PhonographMusicPlayItem
		{
			OnClickMusicItem = new Action<int, int>(this.OnClickMusicItem)
		};
	}

	// Token: 0x060133F8 RID: 78840 RVA: 0x004C98EC File Offset: 0x004C7AEC
	protected void OnClickAlbumItem(int albumId, int gridIndex)
	{
		PhonographView.<>c__DisplayClass23_0 CS$<>8__locals1 = new PhonographView.<>c__DisplayClass23_0();
		CS$<>8__locals1.<>4__this = this;
		this.CurrentAlbumId = albumId;
		this.AlbumGenericLayout.SelectGridProxy(gridIndex, false);
		List<int> list;
		List<int> collection = this.MusicMap.TryGetValue(albumId, out list) ? list : new List<int>();
		CS$<>8__locals1.filterList = new List<int>(collection);
		CS$<>8__locals1.filterList.Sort(delegate(int a, int b)
		{
			bool flag = PhonographModel.Instance.CurrentPlayMusicId == a;
			bool flag2 = PhonographModel.Instance.CurrentPlayMusicId == b;
			if (flag && !flag2)
			{
				return -1;
			}
			if (!flag && flag2)
			{
				return 1;
			}
			if (PhonographModel.Instance.IsNewMusic(a) && !PhonographModel.Instance.IsNewMusic(b))
			{
				return -1;
			}
			if (!PhonographModel.Instance.IsNewMusic(a) && PhonographModel.Instance.IsNewMusic(b))
			{
				return 1;
			}
			if (PhonographModel.Instance.IsUnlockMusic(a) && !PhonographModel.Instance.IsUnlockMusic(b))
			{
				return -1;
			}
			if (!PhonographModel.Instance.IsUnlockMusic(a) && PhonographModel.Instance.IsUnlockMusic(b))
			{
				return 1;
			}
			return a - b;
		});
		int num = 0;
		CS$<>8__locals1.selectIndex = -1;
		foreach (int num2 in CS$<>8__locals1.filterList)
		{
			if (PhonographModel.Instance.IsUnlockMusic(num2))
			{
				num++;
			}
			PhonographModel instance = PhonographModel.Instance;
			if (instance != null && instance.CurrentPlayMusicId == num2)
			{
				CS$<>8__locals1.selectIndex = CS$<>8__locals1.filterList.IndexOf(num2);
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "PrefabTextItem_1090321532_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			CS$<>8__locals1.filterList.Count
		}));
		PhonographModel.Instance.CurrentSelectMusicId = ((CS$<>8__locals1.selectIndex != -1) ? CS$<>8__locals1.filterList[CS$<>8__locals1.selectIndex] : 0);
		this.RefreshSwitchBtn(PhonographModel.Instance.CurrentSelectMusicId);
		GenericLayout<PhonographMusicPlayItem, IPhonographMusicItemData> musicGenericLayout = this.MusicGenericLayout;
		if (musicGenericLayout != null)
		{
			UUIInturnAnimController uiAnimController = musicGenericLayout.GetUiAnimController();
			if (uiAnimController != null)
			{
				uiAnimController.Stop();
			}
		}
		UiAsyncTask task = new UiAsyncTask("PhonographView.OnClickAlbumItem", delegate()
		{
			PhonographView.<>c__DisplayClass23_0.<<OnClickAlbumItem>b__1>d <<OnClickAlbumItem>b__1>d;
			<<OnClickAlbumItem>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickAlbumItem>b__1>d.<>4__this = CS$<>8__locals1;
			<<OnClickAlbumItem>b__1>d.<>1__state = -1;
			<<OnClickAlbumItem>b__1>d.<>t__builder.Start<PhonographView.<>c__DisplayClass23_0.<<OnClickAlbumItem>b__1>d>(ref <<OnClickAlbumItem>b__1>d);
			return <<OnClickAlbumItem>b__1>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely("Album", false, false, null, null, false);
		}
		this.RefreshAlbumInfo(albumId);
	}

	// Token: 0x060133F9 RID: 78841 RVA: 0x004C9AD0 File Offset: 0x004C7CD0
	protected void OnClickMusicItem(int musicId, int gridIndex)
	{
		PhonographModel.Instance.CurrentSelectMusicId = musicId;
		if (!PhonographModel.Instance.IsUnlockMusic(musicId))
		{
			this.RefreshMusicInfo(musicId);
			this.MusicGenericLayout.SelectGridProxy(gridIndex, false);
			return;
		}
		this.MusicGenericLayout.SelectGridProxy(gridIndex, false);
		this.EventHandleId = PhonographController.Instance.PlayMusic(musicId, PhonographModel.Instance.IsGlobal);
		PhonographModel instance = PhonographModel.Instance;
		if (instance != null)
		{
			instance.RemoveNewMusic(musicId);
		}
		this.RefreshMusicInfo(musicId);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely("Single", false, false, null, null, false);
		}
		EventSystem.Instance.Emit(EEventName.OnPhonographRemoveNewTag);
		EventSystem.Instance.Emit(EEventName.OnPhonographSwitchMusic);
		PhonographPlayLogEvent phonographPlayLogEvent = new PhonographPlayLogEvent();
		phonographPlayLogEvent.i_item_id = musicId;
		phonographPlayLogEvent.i_album_id = this.CurrentAlbumId;
		LogReportController.Instance.LogReport(phonographPlayLogEvent);
	}

	// Token: 0x060133FA RID: 78842 RVA: 0x004C9BB4 File Offset: 0x004C7DB4
	protected void OnClickSetBgMusic()
	{
		int currentSelectMusicId = PhonographModel.Instance.CurrentSelectMusicId;
		int num = (PhonographModel.Instance.RecordMusicId == currentSelectMusicId) ? 0 : currentSelectMusicId;
		PhonographModel.Instance.RecordMusicId = num;
		if (PhonographModel.Instance.IsGlobal)
		{
			PhonographModel.Instance.GlobalMusicId = num;
			PhonographController.Instance.SendMusicSaveRequest(num);
		}
		else
		{
			PhonographModel instance = PhonographModel.Instance;
			int? num2 = (instance != null) ? instance.EntityId : null;
			if (num2 != null)
			{
				if (num == 0)
				{
					PhonographModel.Instance.RemovePlayIdRecord(num2.Value);
				}
				else
				{
					PhonographModel.Instance.SetPlayIdRecord(num2.Value, this.EventHandleId);
				}
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.OnPhonographSetBgm, num);
		this.RefreshSwitchBtn(currentSelectMusicId);
		if (num != 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("PhonographSwitchMusicSuccess", Array.Empty<object>());
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("PhonographSwitchMusicCancel", Array.Empty<object>());
	}

	// Token: 0x060133FB RID: 78843 RVA: 0x004C9CA4 File Offset: 0x004C7EA4
	protected void OnMusicForceRefresh(int albumId)
	{
		PhonographView.<>c__DisplayClass26_0 CS$<>8__locals1 = new PhonographView.<>c__DisplayClass26_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.defaultMusicId = MotorcycleMusicPlayerModel.Instance.GetDefaultMusicId();
		UiAsyncTask task = new UiAsyncTask("PhonographView.OnMusicForceRefresh", delegate()
		{
			PhonographView.<>c__DisplayClass26_0.<<OnMusicForceRefresh>b__0>d <<OnMusicForceRefresh>b__0>d;
			<<OnMusicForceRefresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnMusicForceRefresh>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnMusicForceRefresh>b__0>d.<>1__state = -1;
			<<OnMusicForceRefresh>b__0>d.<>t__builder.Start<PhonographView.<>c__DisplayClass26_0.<<OnMusicForceRefresh>b__0>d>(ref <<OnMusicForceRefresh>b__0>d);
			return <<OnMusicForceRefresh>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x0400914A RID: 37194
	private const int PHONO_MUSIC_HELP_ID = 653;

	// Token: 0x0400914B RID: 37195
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PhonographAlbumItem, int> AlbumGenericLayout;

	// Token: 0x0400914C RID: 37196
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<PhonographMusicPlayItem, IPhonographMusicItemData> MusicGenericLayout;

	// Token: 0x0400914D RID: 37197
	protected Dictionary<int, List<int>> MusicMap = new Dictionary<int, List<int>>();

	// Token: 0x0400914E RID: 37198
	[Nullable(2)]
	protected PopupCaptionItem CaptionComponent;

	// Token: 0x0400914F RID: 37199
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x04009150 RID: 37200
	private int EventHandleId;

	// Token: 0x04009151 RID: 37201
	private int CurrentAlbumId;

	// Token: 0x02008B10 RID: 35600
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402D269 RID: 184937
		public const int CaptionItem = 0;

		// Token: 0x0402D26A RID: 184938
		public const int AlbumVerticalLayout = 1;

		// Token: 0x0402D26B RID: 184939
		public const int AlbumItem = 2;

		// Token: 0x0402D26C RID: 184940
		public const int TxtAlbumName = 3;

		// Token: 0x0402D26D RID: 184941
		public const int MusicVerticalLayout = 4;

		// Token: 0x0402D26E RID: 184942
		public const int MusicItem = 5;

		// Token: 0x0402D26F RID: 184943
		public const int TxtAlbumTitle = 6;

		// Token: 0x0402D270 RID: 184944
		public const int BtnSetBgMusic = 7;

		// Token: 0x0402D271 RID: 184945
		public const int TxtDescription = 8;

		// Token: 0x0402D272 RID: 184946
		public const int TxtMusicNum = 9;

		// Token: 0x0402D273 RID: 184947
		public const int TxtSwitchBtn = 10;

		// Token: 0x0402D274 RID: 184948
		public const int ScrollView = 11;

		// Token: 0x0402D275 RID: 184949
		public const int BtnTimeLimit = 12;
	}
}
