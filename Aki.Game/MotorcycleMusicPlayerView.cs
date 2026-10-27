using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022C2 RID: 8898
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicPlayerView : UiViewBase
{
	// Token: 0x0601175C RID: 71516 RVA: 0x004475F4 File Offset: 0x004457F4
	public MotorcycleMusicPlayerView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601175D RID: 71517 RVA: 0x00447668 File Offset: 0x00445868
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(21, typeof(UUISprite)),
			new ValueTuple<int, Type>(22, typeof(UUISprite)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(28, typeof(UUISprite)),
			new ValueTuple<int, Type>(29, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnSort)),
			new ValueTuple<int, Delegate>(14, new Action<EToggleState>(this.OnExtendToggleLike)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtnBack)),
			new ValueTuple<int, Delegate>(16, new Action<EToggleState>(this.OnExtendToggleTogPlay)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickBtnNext)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickBtnType)),
			new ValueTuple<int, Delegate>(19, new Action(this.OnClickBtnLikeMarkPos)),
			new ValueTuple<int, Delegate>(26, new Action(this.OnClickBtnNextAlbum)),
			new ValueTuple<int, Delegate>(27, new Action(this.OnClickBtnPrevAlbum)),
			new ValueTuple<int, Delegate>(29, new Action(this.OnClickBtnHelp))
		};
	}

	// Token: 0x0601175E RID: 71518 RVA: 0x00447A2D File Offset: 0x00445C2D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
		EventSystem.Instance.Add<int>(EEventName.OnMotorMusicForceRefresh, new Action<int>(this.OnMotorMusicForceRefresh));
	}

	// Token: 0x0601175F RID: 71519 RVA: 0x00447A67 File Offset: 0x00445C67
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
		EventSystem.Instance.Remove<int>(EEventName.OnMotorMusicForceRefresh, new Action<int>(this.OnMotorMusicForceRefresh));
	}

	// Token: 0x06011760 RID: 71520 RVA: 0x00447AA4 File Offset: 0x00445CA4
	private void OnMotorMusicForceRefresh(int albumId)
	{
		this.StartAlbumIndex = null;
		this.SelectAlbumId = -1;
		this.InitAlbumUiDataList(albumId);
		this.AlbumListView.ReloadView(this.AlbumUiDataList.Length, this.AlbumUiDataList, 0);
		int num = this.AlbumUiDataList.ToList<IAlbumUiData>().FindIndex((IAlbumUiData x) => x.Id == albumId);
		if (num == -1)
		{
			num = 0;
		}
		this.AlbumListView.AttachToIndex(Math.Max(num - 3, 0), true);
		this.AlbumListView.AttachToIndex(num, false);
		this.RefreshCurMusicInfo();
		this.RefreshMusicInfoAndList();
		this.RefreshPointerTween();
		int albumId2 = (num >= 0 && num < this.AlbumUiDataList.Length) ? this.AlbumUiDataList[num].Id : albumId;
		this.RefreshTimeLimitSprite(albumId2);
	}

	// Token: 0x06011761 RID: 71521 RVA: 0x00447B7C File Offset: 0x00445D7C
	protected UniTask LoadCurveResource()
	{
		MotorcycleMusicPlayerView.<LoadCurveResource>d__27 <LoadCurveResource>d__;
		<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCurveResource>d__.<>1__state = -1;
		<LoadCurveResource>d__.<>t__builder.Start<MotorcycleMusicPlayerView.<LoadCurveResource>d__27>(ref <LoadCurveResource>d__);
		return <LoadCurveResource>d__.<>t__builder.Task;
	}

	// Token: 0x06011762 RID: 71522 RVA: 0x00447BB8 File Offset: 0x00445DB8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicPlayerView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicPlayerView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011763 RID: 71523 RVA: 0x00447BFC File Offset: 0x00445DFC
	private void RefreshTimeLimitSprite(int albumId)
	{
		IAlbumTimeInfo albumTimeInfo = MotorcycleMusicPlayerModel.Instance.GetAlbumTimeInfo(albumId);
		bool flag = false;
		if (albumTimeInfo != null && albumTimeInfo.MusicIds.Count > 0)
		{
			foreach (int musicId in albumTimeInfo.MusicIds)
			{
				if (MotorcycleMusicPlayerModel.Instance.IsTimeLimitMusic(musicId))
				{
					flag = true;
					break;
				}
			}
		}
		UUISprite sprite = base.GetSprite(28);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		UUIButtonComponent button = base.GetButton(29);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "MotorMusic_TimeLimited_Title", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "MotorMusicList", Array.Empty<object>());
	}

	// Token: 0x06011764 RID: 71524 RVA: 0x00447CF0 File Offset: 0x00445EF0
	private void OnClickBtnHelp()
	{
		HelpController.Instance.OpenHelpById(653);
	}

	// Token: 0x06011765 RID: 71525 RVA: 0x00447D01 File Offset: 0x00445F01
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011766 RID: 71526 RVA: 0x00447D0C File Offset: 0x00445F0C
	private void InitScrollView()
	{
		this.AlbumListView = new NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid>(base.GetItem(2).GetOwner(), true);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.AlbumListView.CreateItems(base.GetItem(3).GetOwner(), -(base.GetItem(3).GetWidth() - 276f), new Func<AActor, int, int, MotorcycleAlbumItemGrid>(this.CreateAlbumItem), EAttachDirection.Horizontal);
		this.AlbumListView.SetShowItemNum(7);
		this.AlbumListView.SetMoveItemsCallback(new Action(this.OnMoveItemsCallback));
		this.AlbumListView.SetMoveMultiFactor(MotorcycleMusicPlayerConfig.Instance.GetAlbumVelocity());
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(20);
		UUIItem item2 = base.GetItem(7);
		AUIBaseActor auibaseActor = ((item2 != null) ? item2.GetOwner() : null) as AUIBaseActor;
		if (loopScrollViewComponent == null || auibaseActor == null)
		{
			return;
		}
		this.ScrollView = new LoopScrollView<MotorcycleMusicItemGrid, IMusicUiData>(loopScrollViewComponent, auibaseActor, new Func<MotorcycleMusicItemGrid>(this.CreateMusicItem), false);
	}

	// Token: 0x06011767 RID: 71527 RVA: 0x00447DF8 File Offset: 0x00445FF8
	private void InitMusicListData()
	{
		PhonographConfig instance = PhonographConfig.Instance;
		foreach (PhonographMusic phonographMusic in (((instance != null) ? instance.GetMusicList() : null) ?? new List<PhonographMusic>()))
		{
			int[] albumArray = phonographMusic.GetAlbumArray();
			if (albumArray != null)
			{
				foreach (int key in albumArray)
				{
					if (!this.Album2MusicMap.ContainsKey(key))
					{
						this.Album2MusicMap[key] = new List<int>();
					}
					this.Album2MusicMap[key].Add(phonographMusic.Id);
				}
			}
		}
		this.FavoriteMusicList = MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().ToList<int>();
		foreach (List<int> list in this.Album2MusicMap.Values)
		{
			MotorcycleMusicPlayerModel model = MotorcycleMusicPlayerModel.Instance;
			list.Sort(delegate(int aId, int bId)
			{
				bool flag = model.IsMusicUnlock(aId);
				bool flag2 = model.IsMusicUnlock(bId);
				if (flag == flag2)
				{
					return aId - bId;
				}
				if (!flag)
				{
					return 1;
				}
				return -1;
			});
		}
	}

	// Token: 0x06011768 RID: 71528 RVA: 0x00447F2C File Offset: 0x0044612C
	private void InitLongPressButton()
	{
		LongPressButtonItem longPressButtonItem = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(26)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnLongPressNextButton));
		LongPressButtonItem longPressButtonItem2 = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(27)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnLongPressPreButton));
		longPressButtonItem.ShouldPlayLongPressSound = true;
		longPressButtonItem2.ShouldPlayLongPressSound = true;
	}

	// Token: 0x06011769 RID: 71529 RVA: 0x00447F9C File Offset: 0x0044619C
	protected override void OnBeforeShow()
	{
		FIntPoint viewportSize = this.RootItem.GetRootCanvas().GetViewportSize();
		float num = MathUtils.Instance.RangeClamp(base.GetItem(2).GetPositionInScreen(true).X, 0f, (float)viewportSize.X, -1f, 1f);
		float num2 = MathUtils.Instance.RangeClamp(base.GetItem(2).GetPositionInScreen(true).Y, 0f, (float)viewportSize.Y, 1f, -1f);
		this.ProjectOffset.X = (double)(-(double)num);
		this.ProjectOffset.Y = (double)(-(double)num2);
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = this.ProjectOffset.ToUeVector2D(false);
	}

	// Token: 0x0601176A RID: 71530 RVA: 0x0044805C File Offset: 0x0044625C
	protected override void OnAfterHide()
	{
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = Vector2D.ZeroVector;
	}

	// Token: 0x0601176B RID: 71531 RVA: 0x00448078 File Offset: 0x00446278
	private void OnMoveItemsCallback()
	{
		List<MotorcycleAlbumItemGrid> items = this.AlbumListView.GetItems();
		this.TempAlbumSortDataList.Clear();
		for (int i = 0; i < items.Count; i++)
		{
			if (i >= this.TempAlbumSortDataList.Count)
			{
				this.TempAlbumSortDataList.Add(new MotorcycleMusicPlayerView.TempAlbumSortData
				{
					UiItem = items[i].GetRootItem(),
					Distance = Math.Abs(items[i].GetCurrentMovePercentage() - 0.5f)
				});
			}
			else
			{
				this.TempAlbumSortDataList[i].UiItem = items[i].GetRootItem();
				this.TempAlbumSortDataList[i].Distance = Math.Abs(items[i].GetCurrentMovePercentage() - 0.5f);
			}
		}
		this.TempAlbumSortDataList = (from x in this.TempAlbumSortDataList
		orderby x.Distance
		select x).ToList<MotorcycleMusicPlayerView.TempAlbumSortData>();
		bool flag = false;
		for (int j = 1; j < this.TempAlbumSortDataList.Count; j += 2)
		{
			int hierarchyIndex = this.TempAlbumSortDataList[j - 1].UiItem.GetHierarchyIndex();
			if (this.TempAlbumSortDataList[j].UiItem.GetHierarchyIndex() > hierarchyIndex || (j + 1 < this.TempAlbumSortDataList.Count && this.TempAlbumSortDataList[j + 1].UiItem.GetHierarchyIndex() > hierarchyIndex))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			foreach (MotorcycleMusicPlayerView.TempAlbumSortData tempAlbumSortData in this.TempAlbumSortDataList)
			{
				tempAlbumSortData.UiItem.SetHierarchyIndex(-1);
			}
		}
	}

	// Token: 0x0601176C RID: 71532 RVA: 0x00448248 File Offset: 0x00446448
	private void TimerUpdate(float delta)
	{
		if (MotorcycleMusicPlayerModel.Instance.GetIsPause())
		{
			return;
		}
		this.RotateAngle -= 0.2f;
		if (this.RotateAngle < -360f)
		{
			this.RotateAngle += 360f;
		}
		this.CdRotator.Yaw = this.RotateAngle;
		UUIItem sprite = base.GetSprite(22);
		FRotator frotator = this.CdRotator.ToUeRotator();
		sprite.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0601176D RID: 71533 RVA: 0x004482BF File Offset: 0x004464BF
	private void OnRefreshProgressTimer(float delta)
	{
		this.RefreshCurMusicProgress();
	}

	// Token: 0x0601176E RID: 71534 RVA: 0x004482C8 File Offset: 0x004464C8
	private void InitAlbumUiDataList(int curPlayAlbum)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		List<IAlbumUiData> list = (from x in (from x in ((instance != null) ? instance.GetMusicAlbumList() : null) ?? new List<PhonographAlbum>()
		where MotorcycleMusicPlayerModel.Instance.IsAlbumInTimeRange(x.Id)
		select x).ToList<PhonographAlbum>()
		select new AlbumUiData
		{
			Id = x.Id,
			Config = x,
			UnlockMusicNum = MotorcycleMusicPlayerModel.Instance.GetUnlockMusicByAlbum(x.Id).Count,
			AllMusicNum = (this.Album2MusicMap.ContainsKey(x.Id) ? this.Album2MusicMap[x.Id].Count : 0),
			IsSelected = new bool?(x.Id == curPlayAlbum)
		}).ToList<IAlbumUiData>();
		list.Sort((IAlbumUiData a, IAlbumUiData b) => a.Config.SortIndex - b.Config.SortIndex);
		this.AlbumUiDataList = list.ToArray();
	}

	// Token: 0x0601176F RID: 71535 RVA: 0x00448374 File Offset: 0x00446574
	protected override void OnBeforeDestroy()
	{
		if (this.DescTweenDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnSetDescOffsetX));
			this.DescTweenDelegate = null;
		}
		if (TimerSystem.Instance.Has(this.MusicDescTimer))
		{
			TimerSystem.Instance.Remove(this.MusicDescTimer);
			this.MusicDescTimer = null;
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		if (this.PlayTimeTimer != null)
		{
			TimerSystem.Instance.Remove(this.PlayTimeTimer);
			this.PlayTimeTimer = null;
		}
		this.ClearDescTween();
		if (this.SelectAlbumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			this.SaveTempFavoriteMusicList(true);
			if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
			{
				MotorcycleMusicPlayerModel.Instance.SetPlayList(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().ToList<int>());
			}
		}
		MotorcycleMusicPlayerController.Instance.SendFavoriteUpdateRequest();
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = Vector2D.ZeroVector;
		MotorcycleMusicPlayerModel.Instance.ClearAlbum2MusicCache();
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x06011770 RID: 71536 RVA: 0x00448498 File Offset: 0x00446698
	private void SaveTempFavoriteMusicList(bool isSendRequest = false)
	{
		if (this.FavoriteMusicList == null)
		{
			return;
		}
		List<int> favoriteMusicList = (from x in this.FavoriteMusicList
		where MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(x)
		select x).ToList<int>();
		MotorcycleMusicPlayerModel.Instance.SetFavoriteMusicList(favoriteMusicList);
	}

	// Token: 0x06011771 RID: 71537 RVA: 0x004484EC File Offset: 0x004466EC
	private void OnMotorSwitchMusic()
	{
		int curPlayAlbum = MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum();
		int curPlayMusicId = MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId();
		if (curPlayAlbum != -1 && curPlayMusicId != -1 && this.SelectAlbumId == curPlayAlbum)
		{
			this.RefreshCurMusicInfo();
			Predicate<IMusicUiData> <>9__1;
			this.RefreshMusicList(this.SelectAlbumId, false, false, delegate
			{
				if (this.ScrollView != null)
				{
					List<IMusicUiData> musicUiDataList = this.MusicUiDataList;
					Predicate<IMusicUiData> match;
					if ((match = <>9__1) == null)
					{
						match = (<>9__1 = ((IMusicUiData x) => x.Id == curPlayMusicId));
					}
					int num = musicUiDataList.FindIndex(match);
					if (num != -1 && !this.IsItemInViewport(num, 0))
					{
						this.ScrollView.ScrollToGridIndex(num, false);
					}
				}
			});
			this.AlbumListView.RefreshItems();
		}
		else
		{
			this.RefreshMusicInfoAndList();
		}
		this.PlayDescTween();
	}

	// Token: 0x06011772 RID: 71538 RVA: 0x00448570 File Offset: 0x00446770
	private MotorcycleAlbumItemGrid CreateAlbumItem(AActor actor, int index, int showNum)
	{
		return new MotorcycleAlbumItemGrid(actor)
		{
			OnSelectAlbumItem = new Action<int>(this.OnSelectAlbumItem),
			OnClickAlbumItem = new Action<MotorcycleAlbumItemGrid, int>(this.OnClickAlbumItem),
			OnClickBtnPlay = new Action<MotorcycleAlbumItemGrid, int>(this.OnClickAlbumPlay)
		};
	}

	// Token: 0x06011773 RID: 71539 RVA: 0x004485AE File Offset: 0x004467AE
	private MotorcycleMusicItemGrid CreateMusicItem()
	{
		return new MotorcycleMusicItemGrid
		{
			OnClickCallback = new Action<int>(this.OnClickMusicItem),
			OnClickLikeCallback = new Action<int>(this.OnClickLikeMusic)
		};
	}

	// Token: 0x06011774 RID: 71540 RVA: 0x004485D9 File Offset: 0x004467D9
	private void OnClickMusicItem(int musicId)
	{
		this.PlayMusic(musicId);
	}

	// Token: 0x06011775 RID: 71541 RVA: 0x004485E4 File Offset: 0x004467E4
	private void OnDescTweenComplete()
	{
		if (TimerSystem.Instance.Has(this.MusicDescTimer))
		{
			TimerSystem.Instance.Remove(this.MusicDescTimer);
			this.MusicDescTimer = null;
		}
		this.MusicDescTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnSetDescOffsetX(0f);
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x06011776 RID: 71542 RVA: 0x00448644 File Offset: 0x00446844
	private void OnSetDescOffsetX(float value)
	{
		base.GetText(10).SetAnchorOffsetX(value);
	}

	// Token: 0x06011777 RID: 71543 RVA: 0x00448654 File Offset: 0x00446854
	private void PlayDescTween()
	{
		this.OnSetDescOffsetX(0f);
		if (TimerSystem.Instance.Has(this.MusicDescTimer))
		{
			TimerSystem.Instance.Remove(this.MusicDescTimer);
		}
		this.ClearDescTween();
		this.MusicDescTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			float width = base.GetItem(9).GetWidth();
			float width2 = base.GetText(10).GetWidth();
			if (width2 > width)
			{
				this.ClearDescTween();
				this.DescTween = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DescTweenDelegate, 0f, width - width2, (width2 - width) / 30f, 0f, LTweenEase.Linear);
				this.DescTween.OnCompleteCallBack.Bind(new Action(this.OnDescTweenComplete));
			}
		}, 1500f, null, null, true, 1f);
	}

	// Token: 0x06011778 RID: 71544 RVA: 0x004486BE File Offset: 0x004468BE
	private void ClearDescTween()
	{
		if (this.DescTween != null)
		{
			this.DescTween.Kill(false);
			this.DescTween = null;
		}
	}

	// Token: 0x06011779 RID: 71545 RVA: 0x004486DC File Offset: 0x004468DC
	private void PlayMusic(int musicId)
	{
		int albumId = this.SelectAlbumId;
		if (this.SelectAlbumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			MotorcycleMusicPlayerModel.Instance.SetPlayList(this.FavoriteMusicList ?? new List<int>());
			MotorcycleMusicPlayerModel instance = MotorcycleMusicPlayerModel.Instance;
			if (instance.IsTimeLimitMusic(musicId))
			{
				PhonographConfig instance2 = PhonographConfig.Instance;
				PhonographMusic? phonographMusic = (instance2 != null) ? instance2.GetMusicById(musicId) : null;
				int[] array = (phonographMusic != null) ? phonographMusic.GetValueOrDefault().GetAlbumArray() : null;
				if (array != null)
				{
					foreach (int num in array)
					{
						if (instance.IsTimeLimitAlbum(num))
						{
							albumId = num;
							break;
						}
					}
				}
			}
		}
		else if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() != this.SelectAlbumId && this.SelectAlbumId != MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			MotorcycleMusicPlayerModel.Instance.SetPlayList((from x in MotorcycleMusicPlayerModel.Instance.GetUnlockMusicByAlbum(this.SelectAlbumId)
			select x.Id).ToList<int>());
		}
		MotorcycleMusicPlayerController.Instance.PlayAlbumMusic(albumId, musicId);
		this.RefreshPointerTween();
	}

	// Token: 0x0601177A RID: 71546 RVA: 0x00448818 File Offset: 0x00446A18
	private void OnClickLikeMusic(int musicId)
	{
		if (musicId == -1)
		{
			return;
		}
		if (MotorcycleMusicPlayerModel.Instance.IsMusicNew(musicId))
		{
			MotorcycleMusicPlayerModel.Instance.ClearMusicNew(musicId);
		}
		bool flag = MotorcycleMusicPlayerController.Instance.RequestToggleMusicFavorite(musicId);
		if (MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(musicId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorMusicTips05", Array.Empty<object>());
		}
		if (this.SelectAlbumId != MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
			{
				MotorcycleMusicPlayerModel.Instance.SetPlayList(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().ToList<int>());
			}
			this.RefreshMusicInfoAndList();
			return;
		}
		this.RefreshCurMusicInfo();
		bool flag2 = MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(musicId);
		if (flag && flag2 && !this.FavoriteMusicList.Contains(musicId))
		{
			this.FavoriteMusicList.Insert(0, musicId);
			this.RefreshMusicList(MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId(), false, true, null);
		}
		else
		{
			if (flag && !flag2)
			{
				int num = this.FavoriteMusicList.IndexOf(musicId);
				if (num != -1)
				{
					this.FavoriteMusicList.RemoveAt(num);
				}
			}
			this.RefreshMusicList(MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId(), false, false, null);
		}
		this.AlbumListView.RefreshItems();
	}

	// Token: 0x0601177B RID: 71547 RVA: 0x00448940 File Offset: 0x00446B40
	private void OnClickAlbumPlay(MotorcycleAlbumItemGrid itemGrid, int albumId)
	{
		if (this.SelectAlbumId != albumId)
		{
			NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
			if (albumListView != null)
			{
				albumListView.AttachToIndex(this.AlbumUiDataList.ToList<IAlbumUiData>().FindIndex((IAlbumUiData x) => x.Id == albumId), false);
			}
			this.SelectAlbumId = albumId;
		}
		List<int> musicList = this.GetMusicList(albumId);
		int? num = (musicList != null && musicList.Count > 0) ? new int?(musicList[0]) : null;
		if (num != null && num.Value != 0)
		{
			this.PlayMusic(num.Value);
		}
		this.AlbumListView.RefreshItems();
	}

	// Token: 0x0601177C RID: 71548 RVA: 0x004489FD File Offset: 0x00446BFD
	private void OnClickAlbumItem(MotorcycleAlbumItemGrid itemGrid, int _)
	{
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToIndex(itemGrid.GetCurrentShowItemIndex(), false);
	}

	// Token: 0x0601177D RID: 71549 RVA: 0x00448A18 File Offset: 0x00446C18
	private void OnSelectAlbumItem(int albumId)
	{
		if (this.StartAlbumIndex != null)
		{
			if (albumId != this.StartAlbumIndex.Value)
			{
				return;
			}
			this.StartAlbumIndex = null;
		}
		if (this.SelectAlbumId == albumId)
		{
			return;
		}
		IReadOnlyList<int> favoriteMusicList = MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList();
		if (this.SelectAlbumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
			{
				MotorcycleMusicPlayerModel.Instance.SetPlayList(favoriteMusicList.ToList<int>());
			}
			this.SaveTempFavoriteMusicList(false);
		}
		this.SelectAlbumId = albumId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MotorMusicAlbum", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.AlbumUiDataList.ToList<IAlbumUiData>().FindIndex((IAlbumUiData x) => x.Id == albumId) + 1,
			this.AlbumUiDataList.Length
		}));
		this.RefreshMusicList(albumId, true, false, delegate
		{
			int num = this.MusicUiDataList.FindIndex((IMusicUiData x) => x.Id == MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId());
			int gridIndex = (num != -1) ? num : 0;
			if (this.ScrollView.GetDisplayGridNum() == 0)
			{
				return;
			}
			if (!this.IsItemInViewport(gridIndex, 0))
			{
				this.ScrollView.ScrollToGridIndex(gridIndex, true);
			}
			else
			{
				this.ScrollView.ResetGridController();
			}
			UUIItem grid = this.ScrollView.GetGrid(gridIndex);
			if (grid != null && Info.Instance.IsInGamepad())
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(grid, false, false, false);
			}
		});
		UUIItem uuiitem = base.GetButton(5).RootUIComp.Get();
		bool uiactive;
		if (this.SelectAlbumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			List<int> favoriteMusicList2 = this.FavoriteMusicList;
			uiactive = (((favoriteMusicList2 != null) ? favoriteMusicList2.Count : 0) >= 2);
		}
		else
		{
			uiactive = false;
		}
		uuiitem.SetUIActive(uiactive);
		UUIButtonComponent button = base.GetButton(26);
		if (button != null)
		{
			UUIItem uuiitem2 = button.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(this.AlbumListView.GetCurrentSelectIndex() < this.AlbumUiDataList.Length - 1);
			}
		}
		UUIButtonComponent button2 = base.GetButton(27);
		if (button2 != null)
		{
			UUIItem uuiitem3 = button2.RootUIComp.Get();
			if (uuiitem3 != null)
			{
				uuiitem3.SetUIActive(this.AlbumListView.GetCurrentSelectIndex() > 0);
			}
		}
		base.GetButton(19).RootUIComp.Get().SetUIActive(this.SelectAlbumId != MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId());
		foreach (IAlbumUiData albumUiData in this.AlbumUiDataList)
		{
			albumUiData.IsSelected = new bool?(albumUiData.Id == this.SelectAlbumId);
		}
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView != null)
		{
			albumListView.RefreshItems();
		}
		this.RefreshTimeLimitSprite(this.SelectAlbumId);
	}

	// Token: 0x0601177E RID: 71550 RVA: 0x00448C78 File Offset: 0x00446E78
	private void RefreshCurMusicInfo()
	{
		int curPlayMusicId = MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId();
		if (curPlayMusicId == -1)
		{
			return;
		}
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(curPlayMusicId) : null;
		if (phonographMusic == null)
		{
			return;
		}
		base.GetText(8).ShowTextNew(phonographMusic.Value.Title);
		string multiText = TextConfig.Instance.GetMultiText(phonographMusic.Value.Desc, Array.Empty<string>());
		string newText = (multiText != null) ? Regex.Replace(multiText, "[\\n]+", " ") : "";
		base.GetText(10).SetText(newText, true);
		bool flag = !MotorcycleMusicPlayerModel.Instance.GetIsPause();
		base.GetExtendToggle(16).SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		MotorcycleMusicPlayerModel instance2 = MotorcycleMusicPlayerModel.Instance;
		bool flag2 = instance2 != null && instance2.IsMusicFavorite(curPlayMusicId);
		base.GetExtendToggle(14).SetToggleStateForce(flag2 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshCurMusicProgress();
	}

	// Token: 0x0601177F RID: 71551 RVA: 0x00448D7C File Offset: 0x00446F7C
	private void RefreshCurMusicProgress()
	{
		MotorcycleMusicPlayerModel instance = MotorcycleMusicPlayerModel.Instance;
		int currentPlayTimeFromAudio = MotorcycleMusicPlayerController.Instance.GetCurrentPlayTimeFromAudio();
		float fillAmount = (float)currentPlayTimeFromAudio / (float)instance.CurrentPlayMusicTotalTime;
		if (instance.CurrentPlayMusicTotalTime == 0)
		{
			fillAmount = 0f;
		}
		base.GetSprite(12).SetFillAmount(fillAmount);
		base.GetText(11).SetText(TimeUtil.Instance.GetTimeDataFormat((double)currentPlayTimeFromAudio), true);
		base.GetText(13).SetText("/" + TimeUtil.Instance.GetTimeDataFormat((double)instance.CurrentPlayMusicTotalTime), true);
	}

	// Token: 0x06011780 RID: 71552 RVA: 0x00448E04 File Offset: 0x00447004
	[NullableContext(2)]
	private List<int> GetMusicList(int albumId)
	{
		if (albumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			return this.FavoriteMusicList;
		}
		if (!this.Album2MusicMap.ContainsKey(albumId))
		{
			return null;
		}
		return this.Album2MusicMap[albumId];
	}

	// Token: 0x06011781 RID: 71553 RVA: 0x00448E38 File Offset: 0x00447038
	private bool IsFavoriteMusicExpired(int musicId)
	{
		MotorcycleMusicPlayerModel model = MotorcycleMusicPlayerModel.Instance;
		if (!model.IsTimeLimitMusic(musicId))
		{
			return false;
		}
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return false;
		}
		int[] albumArray = phonographMusic.Value.GetAlbumArray();
		return albumArray != null && !albumArray.Any((int id) => model.IsAlbumInTimeRange(id));
	}

	// Token: 0x06011782 RID: 71554 RVA: 0x00448EB8 File Offset: 0x004470B8
	[NullableContext(2)]
	private void RefreshMusicList(int albumId, bool isClick = false, bool isPlayAnim = false, Action onComplete = null)
	{
		List<int> list = this.Album2MusicMap.ContainsKey(albumId) ? this.Album2MusicMap[albumId] : null;
		if (albumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			if (isClick)
			{
				list = MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().ToList<int>();
				this.FavoriteMusicList = list;
			}
			else
			{
				list = this.FavoriteMusicList;
			}
			list = ((list != null) ? (from id in list
			where !this.IsFavoriteMusicExpired(id)
			select id).ToList<int>() : null);
			this.FavoriteMusicList = list;
			MotorcycleMusicPlayerModel.Instance.SetFavoriteMusicList(list ?? new List<int>());
		}
		if (list == null)
		{
			list = new List<int>();
		}
		List<IMusicUiData> list2 = (from id in list
		select new MusicUiData
		{
			Id = id,
			IsFavorite = new bool?(MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(id))
		}).ToList<IMusicUiData>();
		this.MusicUiDataList = list2;
		this.ScrollView.RefreshByData(list2, false, onComplete, isPlayAnim);
		UUIItem item = base.GetItem(23);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(list2.Count == 0);
	}

	// Token: 0x06011783 RID: 71555 RVA: 0x00448FB2 File Offset: 0x004471B2
	private void RefreshMusicInfoAndList()
	{
		this.RefreshCurMusicInfo();
		this.RefreshMusicList(this.SelectAlbumId, false, false, null);
		this.AlbumListView.RefreshItems();
	}

	// Token: 0x06011784 RID: 71556 RVA: 0x00448FD4 File Offset: 0x004471D4
	private void OnPlayModeChanged()
	{
		this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(MotorcycleMusicPlayerDefine.motorMusicPlayModeIcon[MotorcycleMusicPlayerModel.Instance.GetPlayMode()]), base.GetSprite(21), false, null, null);
	}

	// Token: 0x06011785 RID: 71557 RVA: 0x00449018 File Offset: 0x00447218
	private void OnClickBtnSort()
	{
		if (MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().Count >= 2)
		{
			MusicSortViewOpenParams param = new MusicSortViewOpenParams
			{
				MusicList = this.FavoriteMusicList,
				OnCallback = new Action<List<int>>(this.OnSortFinishCallback)
			};
			UiManager.Instance.OpenView(EUiViewName.MotorcycleMusicSortView, param, null);
		}
	}

	// Token: 0x06011786 RID: 71558 RVA: 0x0044906C File Offset: 0x0044726C
	private void OnSortFinishCallback(List<int> musicList)
	{
		this.FavoriteMusicList = musicList;
		this.RefreshMusicList(this.SelectAlbumId, false, true, null);
		if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			MotorcycleMusicPlayerModel.Instance.SetPlayList(this.FavoriteMusicList.ToList<int>());
		}
	}

	// Token: 0x06011787 RID: 71559 RVA: 0x004490BA File Offset: 0x004472BA
	private void OnExtendToggleLike(EToggleState toggleState)
	{
		this.OnClickLikeMusic(MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId());
	}

	// Token: 0x06011788 RID: 71560 RVA: 0x004490CC File Offset: 0x004472CC
	private void OnClickBtnBack()
	{
		MotorcycleMusicPlayerController.Instance.QuickPlayMusic(false);
		this.RefreshPointerTween();
	}

	// Token: 0x06011789 RID: 71561 RVA: 0x004490DF File Offset: 0x004472DF
	private void OnExtendToggleTogPlay(EToggleState toggleState)
	{
		if (MotorcycleMusicPlayerModel.Instance.GetIsPause())
		{
			MotorcycleMusicPlayerController.Instance.ResumeMusic();
		}
		else
		{
			MotorcycleMusicPlayerController.Instance.PauseMusic();
		}
		this.RefreshPointerTween();
		this.RefreshMusicInfoAndList();
	}

	// Token: 0x0601178A RID: 71562 RVA: 0x00449110 File Offset: 0x00447310
	private void RefreshPointerTween()
	{
		bool isPause = MotorcycleMusicPlayerModel.Instance.GetIsPause();
		if (isPause == this.IsPointerPause)
		{
			return;
		}
		this.IsPointerPause = isPause;
		if (isPause)
		{
			ULGUIPlayTweenComponent startTweenComp = this.StartTweenComp;
			if (startTweenComp != null)
			{
				startTweenComp.Stop();
			}
			ULGUIPlayTweenComponent stopTweenComp = this.StopTweenComp;
			if (stopTweenComp == null)
			{
				return;
			}
			stopTweenComp.Play();
			return;
		}
		else
		{
			ULGUIPlayTweenComponent startTweenComp2 = this.StartTweenComp;
			if (startTweenComp2 != null)
			{
				startTweenComp2.Play();
			}
			ULGUIPlayTweenComponent stopTweenComp2 = this.StopTweenComp;
			if (stopTweenComp2 == null)
			{
				return;
			}
			stopTweenComp2.Stop();
			return;
		}
	}

	// Token: 0x0601178B RID: 71563 RVA: 0x0044917F File Offset: 0x0044737F
	private void OnClickBtnNext()
	{
		MotorcycleMusicPlayerController.Instance.QuickPlayMusic(true);
		this.RefreshPointerTween();
	}

	// Token: 0x0601178C RID: 71564 RVA: 0x00449192 File Offset: 0x00447392
	private void OnLongPressNextButton(bool isShortPress)
	{
		UiNavigationNewController.Instance.ResetNavigationFocusForViewWithDirtyCheck();
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToNextItem(1);
	}

	// Token: 0x0601178D RID: 71565 RVA: 0x004491AF File Offset: 0x004473AF
	private void OnClickBtnNextAlbum()
	{
		UiNavigationNewController.Instance.ResetNavigationFocusForViewWithDirtyCheck();
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToNextItem(1);
	}

	// Token: 0x0601178E RID: 71566 RVA: 0x004491CC File Offset: 0x004473CC
	private void OnLongPressPreButton(bool isShortPress)
	{
		UiNavigationNewController.Instance.ResetNavigationFocusForViewWithDirtyCheck();
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToNextItem(-1);
	}

	// Token: 0x0601178F RID: 71567 RVA: 0x004491E9 File Offset: 0x004473E9
	private void OnClickBtnPrevAlbum()
	{
		UiNavigationNewController.Instance.ResetNavigationFocusForViewWithDirtyCheck();
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToNextItem(-1);
	}

	// Token: 0x06011790 RID: 71568 RVA: 0x00449208 File Offset: 0x00447408
	private void OnClickBtnType()
	{
		EMotorMusicPlayMode emotorMusicPlayMode = MotorcycleMusicPlayerModel.Instance.GetPlayMode();
		switch (emotorMusicPlayMode)
		{
		case EMotorMusicPlayMode.Order:
			emotorMusicPlayMode = EMotorMusicPlayMode.Random;
			break;
		case EMotorMusicPlayMode.Random:
			emotorMusicPlayMode = EMotorMusicPlayMode.Repeat;
			break;
		case EMotorMusicPlayMode.Repeat:
			emotorMusicPlayMode = EMotorMusicPlayMode.Order;
			break;
		}
		MotorcycleMusicPlayerModel.Instance.SetCurPlayMode(emotorMusicPlayMode);
		ScrollingTipsController.Instance.ShowTipsByTextId(MotorcycleMusicPlayerDefine.motorPlayModeName[emotorMusicPlayMode], Array.Empty<object>());
		this.OnPlayModeChanged();
	}

	// Token: 0x06011791 RID: 71569 RVA: 0x0044926C File Offset: 0x0044746C
	private void OnClickBtnLikeMarkPos()
	{
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToIndex(this.AlbumUiDataList.ToList<IAlbumUiData>().FindIndex((IAlbumUiData x) => x.Id == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId()), false);
	}

	// Token: 0x06011792 RID: 71570 RVA: 0x004492BC File Offset: 0x004474BC
	public bool IsItemInViewport(int gridIndex, int tolerance = 0)
	{
		if (this.ScrollView == null)
		{
			return false;
		}
		if (!this.ScrollView.IsGridDisplaying(gridIndex))
		{
			return false;
		}
		UUIItem grid = this.ScrollView.GetGrid(gridIndex);
		if (grid == null)
		{
			return false;
		}
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(20);
		UUIItem uuiitem = loopScrollViewComponent.ContentUIItem.Get();
		AUIBaseActor viewport = loopScrollViewComponent.GetViewport();
		UUIItem uuiitem2 = (viewport != null) ? viewport.GetUIItem() : null;
		if (uuiitem == null || uuiitem2 == null)
		{
			return false;
		}
		float anchorOffsetY = grid.GetAnchorOffsetY();
		float height = grid.GetHeight();
		float height2 = uuiitem2.GetHeight();
		return -anchorOffsetY >= uuiitem.GetAnchorOffsetY() && -anchorOffsetY + height <= uuiitem.GetAnchorOffsetY() + height2;
	}

	// Token: 0x040084A5 RID: 33957
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleMusicItemGrid, IMusicUiData> ScrollView;

	// Token: 0x040084A6 RID: 33958
	private readonly Dictionary<int, List<int>> Album2MusicMap = new Dictionary<int, List<int>>();

	// Token: 0x040084A7 RID: 33959
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> AlbumListView;

	// Token: 0x040084A8 RID: 33960
	private int SelectAlbumId = -1;

	// Token: 0x040084A9 RID: 33961
	private IAlbumUiData[] AlbumUiDataList;

	// Token: 0x040084AA RID: 33962
	[Nullable(2)]
	private List<int> FavoriteMusicList;

	// Token: 0x040084AB RID: 33963
	[Nullable(2)]
	private FLTweenFloatSetterDynamic DescTweenDelegate;

	// Token: 0x040084AC RID: 33964
	[Nullable(2)]
	private ULTweener DescTween;

	// Token: 0x040084AD RID: 33965
	[Nullable(2)]
	private TimerHandle MusicDescTimer;

	// Token: 0x040084AE RID: 33966
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040084AF RID: 33967
	[Nullable(2)]
	private TimerHandle PlayTimeTimer;

	// Token: 0x040084B0 RID: 33968
	private float RotateAngle;

	// Token: 0x040084B1 RID: 33969
	[Nullable(2)]
	private ULGUIPlayTweenComponent StartTweenComp;

	// Token: 0x040084B2 RID: 33970
	[Nullable(2)]
	private ULGUIPlayTweenComponent StopTweenComp;

	// Token: 0x040084B3 RID: 33971
	private readonly Rotator CdRotator = Rotator.Create(0f, 0f, 0f);

	// Token: 0x040084B4 RID: 33972
	private bool IsPointerPause;

	// Token: 0x040084B5 RID: 33973
	private readonly Vector2D ProjectOffset = Vector2D.Create(0.0, 0.0);

	// Token: 0x040084B6 RID: 33974
	private List<MotorcycleMusicPlayerView.TempAlbumSortData> TempAlbumSortDataList = new List<MotorcycleMusicPlayerView.TempAlbumSortData>();

	// Token: 0x040084B7 RID: 33975
	private List<IMusicUiData> MusicUiDataList = new List<IMusicUiData>();

	// Token: 0x040084B8 RID: 33976
	private int? StartAlbumIndex;

	// Token: 0x02008833 RID: 34867
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C413 RID: 181267
		public const int UiItemCaption = 0;

		// Token: 0x0402C414 RID: 181268
		public const int TxtAlbumNum = 1;

		// Token: 0x0402C415 RID: 181269
		public const int PanelDrag = 2;

		// Token: 0x0402C416 RID: 181270
		public const int TogAlbum = 3;

		// Token: 0x0402C417 RID: 181271
		public const int TxtDescName = 4;

		// Token: 0x0402C418 RID: 181272
		public const int BtnSort = 5;

		// Token: 0x0402C419 RID: 181273
		public const int Content = 6;

		// Token: 0x0402C41A RID: 181274
		public const int TogCommon2 = 7;

		// Token: 0x0402C41B RID: 181275
		public const int TxtMusicName = 8;

		// Token: 0x0402C41C RID: 181276
		public const int PanelClip = 9;

		// Token: 0x0402C41D RID: 181277
		public const int TxtDesc = 10;

		// Token: 0x0402C41E RID: 181278
		public const int TxtDescTimeL = 11;

		// Token: 0x0402C41F RID: 181279
		public const int SpriteProgressBar = 12;

		// Token: 0x0402C420 RID: 181280
		public const int TxtDescTimeR = 13;

		// Token: 0x0402C421 RID: 181281
		public const int TogLike = 14;

		// Token: 0x0402C422 RID: 181282
		public const int BtnBack = 15;

		// Token: 0x0402C423 RID: 181283
		public const int TogPlay = 16;

		// Token: 0x0402C424 RID: 181284
		public const int BtnNext = 17;

		// Token: 0x0402C425 RID: 181285
		public const int BtnType = 18;

		// Token: 0x0402C426 RID: 181286
		public const int BtnLikeMarkPos = 19;

		// Token: 0x0402C427 RID: 181287
		public const int SvDefault = 20;

		// Token: 0x0402C428 RID: 181288
		public const int SpritePlayMode = 21;

		// Token: 0x0402C429 RID: 181289
		public const int SpriteCDIcon = 22;

		// Token: 0x0402C42A RID: 181290
		public const int PanelEmpty = 23;

		// Token: 0x0402C42B RID: 181291
		public const int StartTween = 24;

		// Token: 0x0402C42C RID: 181292
		public const int StopTween = 25;

		// Token: 0x0402C42D RID: 181293
		public const int BtnNextAlbum = 26;

		// Token: 0x0402C42E RID: 181294
		public const int BtnPrevAlbum = 27;

		// Token: 0x0402C42F RID: 181295
		public const int SprTimeLimit = 28;

		// Token: 0x0402C430 RID: 181296
		public const int BtnHelpB = 29;
	}

	// Token: 0x02008834 RID: 34868
	[NullableContext(0)]
	private class TempAlbumSortData
	{
		// Token: 0x0402C431 RID: 181297
		[Nullable(1)]
		public UUIItem UiItem;

		// Token: 0x0402C432 RID: 181298
		public float Distance;
	}
}
