using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005784 RID: 22404
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoleView : UiViewBase
	{
		// Token: 0x17006A8C RID: 27276
		// (get) Token: 0x06037494 RID: 226452 RVA: 0x00F6FF85 File Offset: 0x00F6E185
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A8D RID: 27277
		// (get) Token: 0x06037495 RID: 226453 RVA: 0x00F6FF91 File Offset: 0x00F6E191
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06037496 RID: 226454 RVA: 0x00F6FF9E File Offset: 0x00F6E19E
		public DangoBrawlRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037497 RID: 226455 RVA: 0x00F6FFB0 File Offset: 0x00F6E1B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnClickLevelDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnBtnClickEnter));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnBtnClickMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037498 RID: 226456 RVA: 0x00F702DC File Offset: 0x00F6E4DC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoleView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoleView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037499 RID: 226457 RVA: 0x00F7031F File Offset: 0x00F6E51F
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(11));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnViewStartSequence));
		}

		// Token: 0x0603749A RID: 226458 RVA: 0x00F70358 File Offset: 0x00F6E558
		protected override void OnBeforeShow()
		{
			GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.SelectGridProxy(this.SelectRoleIndex, false);
			}
			List<DangoBrawlRoleData> roleDataList = this.GetRoleDataList();
			if (this.SelectRoleIndex >= 0 && this.SelectRoleIndex < roleDataList.Count)
			{
				this.RefreshAllInfo(roleDataList[this.SelectRoleIndex]);
			}
			GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> roleLayout2 = this.RoleLayout;
			DangoBrawlRoleItem dangoBrawlRoleItem = (roleLayout2 != null) ? roleLayout2.GetLayoutItemByIndex(this.SelectRoleIndex) : null;
			if (dangoBrawlRoleItem != null)
			{
				this.MarkRoleItemRead(dangoBrawlRoleItem);
			}
			if (this.SelectLevelId > 0 && this.ActivityData.HasNewLevelRedDot(this.SelectLevelId))
			{
				this.ActivityData.MarkNewLevelRead(new int?(this.SelectLevelId), null);
			}
			ActivityDangoBrawlController.Instance.TryPlayRoleUnlockQueue();
			this.SetRoleLightVisible(true);
		}

		// Token: 0x0603749B RID: 226459 RVA: 0x00F7041C File Offset: 0x00F6E61C
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(11));
			this.RoleModelLoadSerial++;
			this.DestroyLoadingDangoActor();
			this.DestroyRoleDangoActor();
			this.SetRoleLightVisible(false);
		}

		// Token: 0x0603749C RID: 226460 RVA: 0x00F70451 File Offset: 0x00F6E651
		private void OnViewStartSequence(string _)
		{
			GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = roleLayout.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}

		// Token: 0x0603749D RID: 226461 RVA: 0x00F70474 File Offset: 0x00F6E674
		private List<DangoBrawlRoleData> GetRoleDataList()
		{
			DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.SelectLevelId);
			IEnumerable<DangoBrawlRole> roleConfigList = DangoBrawlConfig.Instance.GetRoleConfigList(this.ActivityData.Id);
			List<DangoBrawlRoleData> list = new List<DangoBrawlRoleData>();
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			foreach (DangoBrawlRole dangoBrawlRole in roleConfigList)
			{
				EPlayerGender gender = (EPlayerGender)dangoBrawlRole.Gender;
				if ((gender == playerGender || gender == EPlayerGender.None) && this.OutGameData.IsRoleUnlocked(dangoBrawlRole.Id))
				{
					DangoBrawlRoleData item = new DangoBrawlRoleData
					{
						RoleId = dangoBrawlRole.Id,
						SortIndex = dangoBrawlRole.SortIndex,
						IsUnlocked = true,
						IsRecommend = new bool?(challengeConfigById != null && NoLinq.Contains<int>(challengeConfigById.Value.GetRecommendRoleIdBytes(), dangoBrawlRole.Id)),
						IsShowShadow = new bool?(true),
						IsNew = new bool?(this.ActivityData.HasNewRoleRedDot(dangoBrawlRole.Id))
					};
					list.Add(item);
				}
			}
			NoLinq.SortStable<DangoBrawlRoleData>(list, delegate(DangoBrawlRoleData left, DangoBrawlRoleData right)
			{
				int num = right.IsRecommend.GetValueOrDefault().CompareTo(left.IsRecommend.GetValueOrDefault());
				if (num == 0)
				{
					return left.SortIndex.CompareTo(right.SortIndex);
				}
				return num;
			});
			return list;
		}

		// Token: 0x0603749E RID: 226462 RVA: 0x00F705D4 File Offset: 0x00F6E7D4
		private DangoBrawlRoleItem CreateRoleItem()
		{
			return new DangoBrawlRoleItem
			{
				OnClickRole = new Action<DangoBrawlRoleItem>(this.OnClickRole)
			};
		}

		// Token: 0x0603749F RID: 226463 RVA: 0x00F705F0 File Offset: 0x00F6E7F0
		private void MarkRoleItemRead(DangoBrawlRoleItem item)
		{
			DangoBrawlRoleData roleData = item.RoleData;
			if (roleData == null || !(roleData.IsNew ?? false))
			{
				return;
			}
			this.ActivityData.MarkNewRoleRead(new int?(roleData.RoleId));
			roleData.IsNew = new bool?(false);
			item.SetNewVisible(false);
		}

		// Token: 0x060374A0 RID: 226464 RVA: 0x00F7064C File Offset: 0x00F6E84C
		private void OnClickRole(DangoBrawlRoleItem item)
		{
			DangoBrawlRoleData roleData = item.RoleData;
			if (roleData == null || !roleData.IsUnlocked)
			{
				return;
			}
			this.SelectRoleIndex = item.GridIndex;
			this.SelectRoleId = roleData.RoleId;
			GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.SelectGridProxy(item.GridIndex, false);
			}
			this.RefreshAllInfo(roleData);
			this.MarkRoleItemRead(item);
		}

		// Token: 0x060374A1 RID: 226465 RVA: 0x00F706AC File Offset: 0x00F6E8AC
		private void RefreshAllInfo(DangoBrawlRoleData roleData)
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlOutBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel != null)
			{
				backpackPanel.ClearSelection();
			}
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleData.RoleId);
			if (roleConfigById == null)
			{
				return;
			}
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(roleConfigById.Value.OccupationId);
			if (this.SelectLevelId > 0)
			{
				DangoBrawlChallenge? challengeConfigById = DangoBrawlConfig.Instance.GetChallengeConfigById(this.SelectLevelId);
				if (challengeConfigById != null)
				{
					bool flag = challengeConfigById.Value.Mode == 1;
					string resourceId = flag ? "T_DangoBrawlLevelSmallBg_Normal" : "T_DangoBrawlLevelSmallBg_Adventure";
					string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
					string hexStr = flag ? "6BCFDB" : "f5c7ff";
					string textStringId = flag ? "DangoBrawlGeneral_1002" : "DangoBrawlGeneral_1003";
					base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
					base.GetText(2).SetColor(FColor.FromHex(hexStr));
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(3), challengeConfigById.Value.Name, Array.Empty<object>());
				}
			}
			if (occupationConfigById != null)
			{
				base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(9), null, null);
				FColor color = FColor.FromHex(occupationConfigById.Value.Color);
				UUISprite sprite = base.GetSprite(18);
				if (sprite != null)
				{
					sprite.SetColor(color);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), occupationConfigById.Value.Name, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), roleConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), roleConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), roleConfigById.Value.Desc, Array.Empty<object>());
			this.InitRoleDangoActor(roleConfigById.Value).Forget();
			this.RefreshBackpackPanel(roleConfigById.Value.WobblePlateId);
		}

		// Token: 0x060374A2 RID: 226466 RVA: 0x00F70914 File Offset: 0x00F6EB14
		private UniTask InitRoleDangoActor(DangoBrawlRole roleConfig)
		{
			DangoBrawlRoleView.<InitRoleDangoActor>d__30 <InitRoleDangoActor>d__;
			<InitRoleDangoActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDangoActor>d__.<>4__this = this;
			<InitRoleDangoActor>d__.roleConfig = roleConfig;
			<InitRoleDangoActor>d__.<>1__state = -1;
			<InitRoleDangoActor>d__.<>t__builder.Start<DangoBrawlRoleView.<InitRoleDangoActor>d__30>(ref <InitRoleDangoActor>d__);
			return <InitRoleDangoActor>d__.<>t__builder.Task;
		}

		// Token: 0x060374A3 RID: 226467 RVA: 0x00F70960 File Offset: 0x00F6EB60
		private void PlayRoleDangoIdle(DangoBrawlRole roleConfig)
		{
			TsUiSceneDangoActor actor = this.RoleDangoActor;
			if (actor == null || string.IsNullOrEmpty(roleConfig.MontageIdle))
			{
				return;
			}
			new LoadAsyncPromise<UAnimMontage>(roleConfig.MontageIdle, ResourceSystem.EResourceLoadPriority.Default).Promise.ContinueWith(delegate(UAnimMontage montage)
			{
				if (montage != null && this.RoleDangoActor == actor)
				{
					UiModelAnimationComponent uiModelAnimationComponent = actor.Model.CheckGetComponent<UiModelAnimationComponent>();
					if (uiModelAnimationComponent == null)
					{
						return;
					}
					uiModelAnimationComponent.PlayMontage(montage);
				}
			}).Forget();
		}

		// Token: 0x060374A4 RID: 226468 RVA: 0x00F709C6 File Offset: 0x00F6EBC6
		private void DestroyRoleDangoActor()
		{
			if (this.RoleDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.RoleDangoActor);
				this.RoleDangoActor = null;
			}
		}

		// Token: 0x060374A5 RID: 226469 RVA: 0x00F709E7 File Offset: 0x00F6EBE7
		private void DestroyLoadingDangoActor()
		{
			if (this.LoadingDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.LoadingDangoActor);
				this.LoadingDangoActor = null;
			}
		}

		// Token: 0x060374A6 RID: 226470 RVA: 0x00F70A08 File Offset: 0x00F6EC08
		private void SetRoleLightVisible(bool visible)
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("Born_CharacterLight");
			if (actorByTag == null)
			{
				return;
			}
			actorByTag.SetActorHiddenInGame(!visible);
		}

		// Token: 0x060374A7 RID: 226471 RVA: 0x00F70A27 File Offset: 0x00F6EC27
		private void RefreshBackpackPanel(int wobblePlateId)
		{
			this.RefreshBackpackPanelAsync(wobblePlateId).Forget();
		}

		// Token: 0x060374A8 RID: 226472 RVA: 0x00F70A38 File Offset: 0x00F6EC38
		private UniTask RefreshBackpackPanelAsync(int wobblePlateId)
		{
			DangoBrawlRoleView.<RefreshBackpackPanelAsync>d__36 <RefreshBackpackPanelAsync>d__;
			<RefreshBackpackPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBackpackPanelAsync>d__.<>4__this = this;
			<RefreshBackpackPanelAsync>d__.wobblePlateId = wobblePlateId;
			<RefreshBackpackPanelAsync>d__.<>1__state = -1;
			<RefreshBackpackPanelAsync>d__.<>t__builder.Start<DangoBrawlRoleView.<RefreshBackpackPanelAsync>d__36>(ref <RefreshBackpackPanelAsync>d__);
			return <RefreshBackpackPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374A9 RID: 226473 RVA: 0x00F70A84 File Offset: 0x00F6EC84
		private UniTask CreateItemTips()
		{
			DangoBrawlRoleView.<CreateItemTips>d__37 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlRoleView.<CreateItemTips>d__37>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x060374AA RID: 226474 RVA: 0x00F70AC8 File Offset: 0x00F6ECC8
		private void OnBackpackItemClick(DangoBrawlOutBackpackItemBase item)
		{
			if (this.ItemTips == null || item.MyItemData == null)
			{
				return;
			}
			this.ItemTips.RefreshAndShow(new DangoBrawlItemTipsData
			{
				ItemId = item.MyItemData.MyConfigId,
				From = EDangoBrawlItemTipsFrom.Fixed,
				ShowCombine = new bool?(true),
				ShowSell = new bool?(false),
				OperationMode = EDangoBrawlTipsOperationMode.Selected
			}).Forget();
		}

		// Token: 0x060374AB RID: 226475 RVA: 0x00F70B32 File Offset: 0x00F6ED32
		private void OnItemTipsCombineInfoClick(DangoBrawlItemTipsData data)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = data.ItemId,
				AllowCombine = false,
				UseActData = false,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x060374AC RID: 226476 RVA: 0x00F70B71 File Offset: 0x00F6ED71
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x060374AD RID: 226477 RVA: 0x00F70B84 File Offset: 0x00F6ED84
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x060374AE RID: 226478 RVA: 0x00F70B95 File Offset: 0x00F6ED95
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x060374AF RID: 226479 RVA: 0x00F70BA8 File Offset: 0x00F6EDA8
		private void OnCloseBtnClick()
		{
			if (this.IfReturnToLevelView)
			{
				DangoBrawlLevelData levelData = this.OutGameData.GetLevelData(this.SelectLevelId);
				DangoBrawlLevelViewOpenData param = new DangoBrawlLevelViewOpenData
				{
					LevelId = new int?(this.SelectLevelId),
					IsNormalMode = new bool?(levelData == null || levelData.IsNormalMode),
					IfReturnToMainView = true
				};
				TOpenViewCallBack finishCallback = delegate(bool _, int _)
				{
					base.CloseMe(null);
				};
				UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelView, param, finishCallback);
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x060374B0 RID: 226480 RVA: 0x00F70C2A File Offset: 0x00F6EE2A
		private void OnBtnClickLevelDetail()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelDetailView, new DangoBrawlLevelDetailViewOpenData
			{
				LevelId = this.SelectLevelId,
				RetryCount = 0
			}, null);
		}

		// Token: 0x060374B1 RID: 226481 RVA: 0x00F70C54 File Offset: 0x00F6EE54
		private void OnBtnClickEnter()
		{
			int selectLevelId = this.SelectLevelId;
			int selectRoleId = this.SelectRoleId;
			bool isEnterSave = this.OutGameData.GetIsEnterSave();
			ActivityDangoBrawlController.Instance.RequestEnterInstanceDungeon(selectLevelId, isEnterSave, selectRoleId).Forget<bool>();
		}

		// Token: 0x060374B2 RID: 226482 RVA: 0x00F70C8D File Offset: 0x00F6EE8D
		private void OnBtnClickMask()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlOutBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return;
			}
			backpackPanel.ClearSelection();
		}

		// Token: 0x0401D34E RID: 119630
		private const string DANGO_BRAWL_ROLE_SPAWN_POINT_CASE = "Born_Character";

		// Token: 0x0401D34F RID: 119631
		private const string DANGO_BRAWL_ROLE_LIGHT_CASE = "Born_CharacterLight";

		// Token: 0x0401D350 RID: 119632
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D351 RID: 119633
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> RoleLayout;

		// Token: 0x0401D352 RID: 119634
		[Nullable(2)]
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x0401D353 RID: 119635
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D354 RID: 119636
		[Nullable(2)]
		private TsUiSceneDangoActor RoleDangoActor;

		// Token: 0x0401D355 RID: 119637
		[Nullable(2)]
		private TsUiSceneDangoActor LoadingDangoActor;

		// Token: 0x0401D356 RID: 119638
		private int RoleModelLoadSerial;

		// Token: 0x0401D357 RID: 119639
		private int SelectLevelId;

		// Token: 0x0401D358 RID: 119640
		private int SelectRoleId;

		// Token: 0x0401D359 RID: 119641
		private int SelectRoleIndex = -1;

		// Token: 0x0401D35A RID: 119642
		private bool IfReturnToLevelView;

		// Token: 0x0200B3B8 RID: 46008
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037902 RID: 227586
			CaptionItem,
			// Token: 0x04037903 RID: 227587
			TexLevelTitleIcon,
			// Token: 0x04037904 RID: 227588
			TxtLevelType,
			// Token: 0x04037905 RID: 227589
			TxtLevelName,
			// Token: 0x04037906 RID: 227590
			BtnLevelDetail,
			// Token: 0x04037907 RID: 227591
			RoleLayout,
			// Token: 0x04037908 RID: 227592
			RoleLayoutItem,
			// Token: 0x04037909 RID: 227593
			TxtRoleName,
			// Token: 0x0403790A RID: 227594
			TxtOccupationType,
			// Token: 0x0403790B RID: 227595
			TexOccupation,
			// Token: 0x0403790C RID: 227596
			TexBagIcon,
			// Token: 0x0403790D RID: 227597
			TxtDesc,
			// Token: 0x0403790E RID: 227598
			TxtBagWeight,
			// Token: 0x0403790F RID: 227599
			BackpackPanelItem,
			// Token: 0x04037910 RID: 227600
			BtnEnter,
			// Token: 0x04037911 RID: 227601
			TxtRoleNameExtra,
			// Token: 0x04037912 RID: 227602
			BtnMask,
			// Token: 0x04037913 RID: 227603
			ItemTips,
			// Token: 0x04037914 RID: 227604
			SprOccupationTypeBg
		}
	}
}
