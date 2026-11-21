using System;
using System.Collections.Generic;
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

// Token: 0x020017A6 RID: 6054
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicPlayerView : UiViewBase
{
	// Token: 0x0600EBF4 RID: 60404 RVA: 0x0045424C File Offset: 0x0045244C
	public MotorcycleMusicPlayerView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EBF5 RID: 60405 RVA: 0x004542C0 File Offset: 0x004524C0
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

	// Token: 0x0600EBF6 RID: 60406 RVA: 0x00454685 File Offset: 0x00452885
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
		EventSystem.Instance.Add<int>(EEventName.OnMotorMusicForceRefresh, new Action<int>(this.OnMotorMusicForceRefresh));
	}

	// Token: 0x0600EBF7 RID: 60407 RVA: 0x004546BF File Offset: 0x004528BF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
		EventSystem.Instance.Remove<int>(EEventName.OnMotorMusicForceRefresh, new Action<int>(this.OnMotorMusicForceRefresh));
	}

	// Token: 0x0600EBF8 RID: 60408 RVA: 0x004546FC File Offset: 0x004528FC
	private void OnMotorMusicForceRefresh(int albumId)
	{
		this.StartAlbumIndex = null;
		this.SelectAlbumId = -1;
		this.InitAlbumUiDataList(albumId);
		this.AlbumListView.ReloadView(this.AlbumUiDataList.Length, this.AlbumUiDataList, 0);
		int num = Array.FindIndex<IAlbumUiData>(this.AlbumUiDataList, (IAlbumUiData x) => x.Id == albumId);
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

	// Token: 0x0600EBF9 RID: 60409 RVA: 0x004547D0 File Offset: 0x004529D0
	protected UniTask LoadCurveResource()
	{
		MotorcycleMusicPlayerView.<LoadCurveResource>d__27 <LoadCurveResource>d__;
		<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCurveResource>d__.<>1__state = -1;
		<LoadCurveResource>d__.<>t__builder.Start<MotorcycleMusicPlayerView.<LoadCurveResource>d__27>(ref <LoadCurveResource>d__);
		return <LoadCurveResource>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBFA RID: 60410 RVA: 0x0045480C File Offset: 0x00452A0C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicPlayerView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicPlayerView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBFB RID: 60411 RVA: 0x00454850 File Offset: 0x00452A50
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

	// Token: 0x0600EBFC RID: 60412 RVA: 0x00454944 File Offset: 0x00452B44
	private void OnClickBtnHelp()
	{
		HelpController.Instance.OpenHelpById(653);
	}

	// Token: 0x0600EBFD RID: 60413 RVA: 0x00454955 File Offset: 0x00452B55
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600EBFE RID: 60414 RVA: 0x00454960 File Offset: 0x00452B60
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

	// Token: 0x0600EBFF RID: 60415 RVA: 0x00454A4C File Offset: 0x00452C4C
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
		this.FavoriteMusicList = new List<int>(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList());
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

	// Token: 0x0600EC00 RID: 60416 RVA: 0x00454B80 File Offset: 0x00452D80
	private void InitLongPressButton()
	{
		LongPressButtonItem longPressButtonItem = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(26)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnLongPressNextButton));
		LongPressButtonItem longPressButtonItem2 = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(27)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnLongPressPreButton));
		longPressButtonItem.ShouldPlayLongPressSound = true;
		longPressButtonItem2.ShouldPlayLongPressSound = true;
	}

	// Token: 0x0600EC01 RID: 60417 RVA: 0x00454BF0 File Offset: 0x00452DF0
	protected override void OnBeforeShow()
	{
		FIntPoint viewportSize = this.RootItem.GetRootCanvas().GetViewportSize();
		float num = MathUtils.Instance.RangeClamp(base.GetItem(2).GetPositionInScreen(true).X, 0f, (float)viewportSize.X, -1f, 1f);
		float num2 = MathUtils.Instance.RangeClamp(base.GetItem(2).GetPositionInScreen(true).Y, 0f, (float)viewportSize.Y, 1f, -1f);
		this.ProjectOffset.X = (double)(-(double)num);
		this.ProjectOffset.Y = (double)(-(double)num2);
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = this.ProjectOffset.ToUeVector2D(false);
	}

	// Token: 0x0600EC02 RID: 60418 RVA: 0x00454CB0 File Offset: 0x00452EB0
	protected override void OnAfterHide()
	{
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = Vector2D.ZeroVector;
	}

	// Token: 0x0600EC03 RID: 60419 RVA: 0x00454CCC File Offset: 0x00452ECC
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
		NoLinq.SortStable<MotorcycleMusicPlayerView.TempAlbumSortData>(this.TempAlbumSortDataList, (MotorcycleMusicPlayerView.TempAlbumSortData left, MotorcycleMusicPlayerView.TempAlbumSortData right) => left.Distance.CompareTo(right.Distance));
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

	// Token: 0x0600EC04 RID: 60420 RVA: 0x00454E90 File Offset: 0x00453090
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

	// Token: 0x0600EC05 RID: 60421 RVA: 0x00454F07 File Offset: 0x00453107
	private void OnRefreshProgressTimer(float delta)
	{
		this.RefreshCurMusicProgress();
	}

	// Token: 0x0600EC06 RID: 60422 RVA: 0x00454F10 File Offset: 0x00453110
	private void InitAlbumUiDataList(int curPlayAlbum)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		IReadOnlyList<PhonographAlbum> readOnlyList = ((instance != null) ? instance.GetMusicAlbumList() : null) ?? new List<PhonographAlbum>();
		List<IAlbumUiData> list = new List<IAlbumUiData>(readOnlyList.Count);
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			PhonographAlbum config = readOnlyList[i];
			if (MotorcycleMusicPlayerModel.Instance.IsAlbumInTimeRange(config.Id))
			{
				list.Add(new AlbumUiData
				{
					Id = config.Id,
					Config = config,
					UnlockMusicNum = MotorcycleMusicPlayerModel.Instance.GetUnlockMusicByAlbum(config.Id).Count,
					AllMusicNum = (this.Album2MusicMap.ContainsKey(config.Id) ? this.Album2MusicMap[config.Id].Count : 0),
					IsSelected = new bool?(config.Id == curPlayAlbum)
				});
			}
		}
		list.Sort((IAlbumUiData a, IAlbumUiData b) => a.Config.SortIndex - b.Config.SortIndex);
		this.AlbumUiDataList = list.ToArray();
	}

	// Token: 0x0600EC07 RID: 60423 RVA: 0x00455030 File Offset: 0x00453230
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
				MotorcycleMusicPlayerModel.Instance.SetPlayList(new List<int>(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList()));
			}
		}
		MotorcycleMusicPlayerController.Instance.SendFavoriteUpdateRequest();
		UiLayer.Instance.UiRootItem.GetRootCanvas().ProjectCenterOffset = Vector2D.ZeroVector;
		MotorcycleMusicPlayerModel.Instance.ClearAlbum2MusicCache();
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x0600EC08 RID: 60424 RVA: 0x00455154 File Offset: 0x00453354
	private void SaveTempFavoriteMusicList(bool isSendRequest = false)
	{
		if (this.FavoriteMusicList == null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in this.FavoriteMusicList)
		{
			if (MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(num))
			{
				list.Add(num);
			}
		}
		MotorcycleMusicPlayerModel.Instance.SetFavoriteMusicList(list);
	}

	// Token: 0x0600EC09 RID: 60425 RVA: 0x004551D0 File Offset: 0x004533D0
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

	// Token: 0x0600EC0A RID: 60426 RVA: 0x00455254 File Offset: 0x00453454
	private MotorcycleAlbumItemGrid CreateAlbumItem(AActor actor, int index, int showNum)
	{
		return new MotorcycleAlbumItemGrid(actor)
		{
			OnSelectAlbumItem = new Action<int>(this.OnSelectAlbumItem),
			OnClickAlbumItem = new Action<MotorcycleAlbumItemGrid, int>(this.OnClickAlbumItem),
			OnClickBtnPlay = new Action<MotorcycleAlbumItemGrid, int>(this.OnClickAlbumPlay)
		};
	}

	// Token: 0x0600EC0B RID: 60427 RVA: 0x00455292 File Offset: 0x00453492
	private MotorcycleMusicItemGrid CreateMusicItem()
	{
		return new MotorcycleMusicItemGrid
		{
			OnClickCallback = new Action<int>(this.OnClickMusicItem),
			OnClickLikeCallback = new Action<int>(this.OnClickLikeMusic)
		};
	}

	// Token: 0x0600EC0C RID: 60428 RVA: 0x004552BD File Offset: 0x004534BD
	private void OnClickMusicItem(int musicId)
	{
		this.PlayMusic(musicId);
	}

	// Token: 0x0600EC0D RID: 60429 RVA: 0x004552C8 File Offset: 0x004534C8
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

	// Token: 0x0600EC0E RID: 60430 RVA: 0x00455328 File Offset: 0x00453528
	private void OnSetDescOffsetX(float value)
	{
		base.GetText(10).SetAnchorOffsetX(value);
	}

	// Token: 0x0600EC0F RID: 60431 RVA: 0x00455338 File Offset: 0x00453538
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

	// Token: 0x0600EC10 RID: 60432 RVA: 0x004553A2 File Offset: 0x004535A2
	private void ClearDescTween()
	{
		if (this.DescTween != null)
		{
			this.DescTween.Kill(false);
			this.DescTween = null;
		}
	}

	// Token: 0x0600EC11 RID: 60433 RVA: 0x004553C0 File Offset: 0x004535C0
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
			MotorcycleMusicPlayerModel.Instance.SetPlayList(MotorcycleMusicPlayerModel.Instance.GetUnlockMusicByAlbum(this.SelectAlbumId).ConvertAll<int>((PhonographMusic x) => x.Id));
		}
		MotorcycleMusicPlayerController.Instance.PlayAlbumMusic(albumId, musicId, false);
		this.RefreshPointerTween();
	}

	// Token: 0x0600EC12 RID: 60434 RVA: 0x004554F8 File Offset: 0x004536F8
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
				MotorcycleMusicPlayerModel.Instance.SetPlayList(new List<int>(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList()));
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

	// Token: 0x0600EC13 RID: 60435 RVA: 0x00455620 File Offset: 0x00453820
	private void OnClickAlbumPlay(MotorcycleAlbumItemGrid itemGrid, int albumId)
	{
		if (this.SelectAlbumId != albumId)
		{
			NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
			if (albumListView != null)
			{
				albumListView.AttachToIndex(Array.FindIndex<IAlbumUiData>(this.AlbumUiDataList, (IAlbumUiData x) => x.Id == albumId), false);
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

	// Token: 0x0600EC14 RID: 60436 RVA: 0x004556D8 File Offset: 0x004538D8
	private void OnClickAlbumItem(MotorcycleAlbumItemGrid itemGrid, int _)
	{
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToIndex(itemGrid.GetCurrentShowItemIndex(), false);
	}

	// Token: 0x0600EC15 RID: 60437 RVA: 0x004556F4 File Offset: 0x004538F4
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
				MotorcycleMusicPlayerModel.Instance.SetPlayList(new List<int>(favoriteMusicList));
			}
			this.SaveTempFavoriteMusicList(false);
		}
		this.SelectAlbumId = albumId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MotorMusicAlbum", new <>z__ReadOnlyArray<object>(new object[]
		{
			Array.FindIndex<IAlbumUiData>(this.AlbumUiDataList, (IAlbumUiData x) => x.Id == albumId) + 1,
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

	// Token: 0x0600EC16 RID: 60438 RVA: 0x00455950 File Offset: 0x00453B50
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

	// Token: 0x0600EC17 RID: 60439 RVA: 0x00455A54 File Offset: 0x00453C54
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

	// Token: 0x0600EC18 RID: 60440 RVA: 0x00455ADC File Offset: 0x00453CDC
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

	// Token: 0x0600EC19 RID: 60441 RVA: 0x00455B10 File Offset: 0x00453D10
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
		return albumArray != null && !Array.Exists<int>(albumArray, (int id) => model.IsAlbumInTimeRange(id));
	}

	// Token: 0x0600EC1A RID: 60442 RVA: 0x00455B90 File Offset: 0x00453D90
	[NullableContext(2)]
	private void RefreshMusicList(int albumId, bool isClick = false, bool isPlayAnim = false, Action onComplete = null)
	{
		List<int> list = this.Album2MusicMap.ContainsKey(albumId) ? this.Album2MusicMap[albumId] : null;
		if (albumId == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			if (isClick)
			{
				list = new List<int>(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList());
				this.FavoriteMusicList = list;
			}
			else
			{
				list = this.FavoriteMusicList;
			}
			if (list != null)
			{
				List<int> list2 = new List<int>(list.Count);
				foreach (int num in list)
				{
					if (!this.IsFavoriteMusicExpired(num))
					{
						list2.Add(num);
					}
				}
				list = list2;
			}
			this.FavoriteMusicList = list;
			MotorcycleMusicPlayerModel.Instance.SetFavoriteMusicList(list ?? new List<int>());
		}
		if (list == null)
		{
			list = new List<int>();
		}
		List<IMusicUiData> list3 = new List<IMusicUiData>(list.Count);
		for (int i = 0; i < list.Count; i++)
		{
			int id = list[i];
			list3.Add(new MusicUiData
			{
				Id = id,
				IsFavorite = new bool?(MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(id))
			});
		}
		this.MusicUiDataList = list3;
		this.ScrollView.RefreshByData(list3, false, onComplete, isPlayAnim);
		UUIItem item = base.GetItem(23);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(list3.Count == 0);
	}

	// Token: 0x0600EC1B RID: 60443 RVA: 0x00455CF8 File Offset: 0x00453EF8
	private void RefreshMusicInfoAndList()
	{
		this.RefreshCurMusicInfo();
		this.RefreshMusicList(this.SelectAlbumId, false, false, null);
		this.AlbumListView.RefreshItems();
	}

	// Token: 0x0600EC1C RID: 60444 RVA: 0x00455D1C File Offset: 0x00453F1C
	private void OnPlayModeChanged()
	{
		this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(MotorcycleMusicPlayerDefine.motorMusicPlayModeIcon[MotorcycleMusicPlayerModel.Instance.GetPlayMode()]), base.GetSprite(21), false, null, null);
	}

	// Token: 0x0600EC1D RID: 60445 RVA: 0x00455D60 File Offset: 0x00453F60
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

	// Token: 0x0600EC1E RID: 60446 RVA: 0x00455DB4 File Offset: 0x00453FB4
	private void OnSortFinishCallback(List<int> musicList)
	{
		this.FavoriteMusicList = musicList;
		this.RefreshMusicList(this.SelectAlbumId, false, true, null);
		if (MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			MotorcycleMusicPlayerModel.Instance.SetPlayList(new List<int>(this.FavoriteMusicList));
		}
	}

	// Token: 0x0600EC1F RID: 60447 RVA: 0x00455E02 File Offset: 0x00454002
	private void OnExtendToggleLike(EToggleState toggleState)
	{
		this.OnClickLikeMusic(MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId());
	}

	// Token: 0x0600EC20 RID: 60448 RVA: 0x00455E14 File Offset: 0x00454014
	private void OnClickBtnBack()
	{
		MotorcycleMusicPlayerController.Instance.QuickPlayMusic(false);
		this.RefreshPointerTween();
	}

	// Token: 0x0600EC21 RID: 60449 RVA: 0x00455E27 File Offset: 0x00454027
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

	// Token: 0x0600EC22 RID: 60450 RVA: 0x00455E58 File Offset: 0x00454058
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

	// Token: 0x0600EC23 RID: 60451 RVA: 0x00455EC7 File Offset: 0x004540C7
	private void OnClickBtnNext()
	{
		MotorcycleMusicPlayerController.Instance.QuickPlayMusic(true);
		this.RefreshPointerTween();
	}

	// Token: 0x0600EC24 RID: 60452 RVA: 0x00455EDA File Offset: 0x004540DA
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

	// Token: 0x0600EC25 RID: 60453 RVA: 0x00455EF7 File Offset: 0x004540F7
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

	// Token: 0x0600EC26 RID: 60454 RVA: 0x00455F14 File Offset: 0x00454114
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

	// Token: 0x0600EC27 RID: 60455 RVA: 0x00455F31 File Offset: 0x00454131
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

	// Token: 0x0600EC28 RID: 60456 RVA: 0x00455F50 File Offset: 0x00454150
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

	// Token: 0x0600EC29 RID: 60457 RVA: 0x00455FB1 File Offset: 0x004541B1
	private void OnClickBtnLikeMarkPos()
	{
		NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> albumListView = this.AlbumListView;
		if (albumListView == null)
		{
			return;
		}
		albumListView.AttachToIndex(Array.FindIndex<IAlbumUiData>(this.AlbumUiDataList, (IAlbumUiData x) => x.Id == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId()), false);
	}

	// Token: 0x0600EC2A RID: 60458 RVA: 0x00455FF0 File Offset: 0x004541F0
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

	// Token: 0x040085E3 RID: 34275
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleMusicItemGrid, IMusicUiData> ScrollView;

	// Token: 0x040085E4 RID: 34276
	private readonly Dictionary<int, List<int>> Album2MusicMap = new Dictionary<int, List<int>>();

	// Token: 0x040085E5 RID: 34277
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<IAlbumUiData, MotorcycleAlbumItemGrid> AlbumListView;

	// Token: 0x040085E6 RID: 34278
	private int SelectAlbumId = -1;

	// Token: 0x040085E7 RID: 34279
	private IAlbumUiData[] AlbumUiDataList;

	// Token: 0x040085E8 RID: 34280
	[Nullable(2)]
	private List<int> FavoriteMusicList;

	// Token: 0x040085E9 RID: 34281
	[Nullable(2)]
	private FLTweenFloatSetterDynamic DescTweenDelegate;

	// Token: 0x040085EA RID: 34282
	[Nullable(2)]
	private ULTweener DescTween;

	// Token: 0x040085EB RID: 34283
	[Nullable(2)]
	private TimerHandle MusicDescTimer;

	// Token: 0x040085EC RID: 34284
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040085ED RID: 34285
	[Nullable(2)]
	private TimerHandle PlayTimeTimer;

	// Token: 0x040085EE RID: 34286
	private float RotateAngle;

	// Token: 0x040085EF RID: 34287
	[Nullable(2)]
	private ULGUIPlayTweenComponent StartTweenComp;

	// Token: 0x040085F0 RID: 34288
	[Nullable(2)]
	private ULGUIPlayTweenComponent StopTweenComp;

	// Token: 0x040085F1 RID: 34289
	private readonly Rotator CdRotator = Rotator.Create(0f, 0f, 0f);

	// Token: 0x040085F2 RID: 34290
	private bool IsPointerPause;

	// Token: 0x040085F3 RID: 34291
	private readonly Vector2D ProjectOffset = Vector2D.Create(0.0, 0.0);

	// Token: 0x040085F4 RID: 34292
	private List<MotorcycleMusicPlayerView.TempAlbumSortData> TempAlbumSortDataList = new List<MotorcycleMusicPlayerView.TempAlbumSortData>();

	// Token: 0x040085F5 RID: 34293
	private List<IMusicUiData> MusicUiDataList = new List<IMusicUiData>();

	// Token: 0x040085F6 RID: 34294
	private int? StartAlbumIndex;

	// Token: 0x020079B8 RID: 31160
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402771A RID: 161562
		public const int UiItemCaption = 0;

		// Token: 0x0402771B RID: 161563
		public const int TxtAlbumNum = 1;

		// Token: 0x0402771C RID: 161564
		public const int PanelDrag = 2;

		// Token: 0x0402771D RID: 161565
		public const int TogAlbum = 3;

		// Token: 0x0402771E RID: 161566
		public const int TxtDescName = 4;

		// Token: 0x0402771F RID: 161567
		public const int BtnSort = 5;

		// Token: 0x04027720 RID: 161568
		public const int Content = 6;

		// Token: 0x04027721 RID: 161569
		public const int TogCommon2 = 7;

		// Token: 0x04027722 RID: 161570
		public const int TxtMusicName = 8;

		// Token: 0x04027723 RID: 161571
		public const int PanelClip = 9;

		// Token: 0x04027724 RID: 161572
		public const int TxtDesc = 10;

		// Token: 0x04027725 RID: 161573
		public const int TxtDescTimeL = 11;

		// Token: 0x04027726 RID: 161574
		public const int SpriteProgressBar = 12;

		// Token: 0x04027727 RID: 161575
		public const int TxtDescTimeR = 13;

		// Token: 0x04027728 RID: 161576
		public const int TogLike = 14;

		// Token: 0x04027729 RID: 161577
		public const int BtnBack = 15;

		// Token: 0x0402772A RID: 161578
		public const int TogPlay = 16;

		// Token: 0x0402772B RID: 161579
		public const int BtnNext = 17;

		// Token: 0x0402772C RID: 161580
		public const int BtnType = 18;

		// Token: 0x0402772D RID: 161581
		public const int BtnLikeMarkPos = 19;

		// Token: 0x0402772E RID: 161582
		public const int SvDefault = 20;

		// Token: 0x0402772F RID: 161583
		public const int SpritePlayMode = 21;

		// Token: 0x04027730 RID: 161584
		public const int SpriteCDIcon = 22;

		// Token: 0x04027731 RID: 161585
		public const int PanelEmpty = 23;

		// Token: 0x04027732 RID: 161586
		public const int StartTween = 24;

		// Token: 0x04027733 RID: 161587
		public const int StopTween = 25;

		// Token: 0x04027734 RID: 161588
		public const int BtnNextAlbum = 26;

		// Token: 0x04027735 RID: 161589
		public const int BtnPrevAlbum = 27;

		// Token: 0x04027736 RID: 161590
		public const int SprTimeLimit = 28;

		// Token: 0x04027737 RID: 161591
		public const int BtnHelpB = 29;
	}

	// Token: 0x020079B9 RID: 31161
	[NullableContext(0)]
	private class TempAlbumSortData
	{
		// Token: 0x04027738 RID: 161592
		[Nullable(1)]
		public UUIItem UiItem;

		// Token: 0x04027739 RID: 161593
		public float Distance;
	}
}
