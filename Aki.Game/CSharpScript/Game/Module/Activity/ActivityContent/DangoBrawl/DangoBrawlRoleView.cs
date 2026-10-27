using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006834 RID: 26676
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoleView : UiViewBase
	{
		// Token: 0x1700974B RID: 38731
		// (get) Token: 0x06042940 RID: 272704 RVA: 0x0102EA49 File Offset: 0x0102CC49
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x1700974C RID: 38732
		// (get) Token: 0x06042941 RID: 272705 RVA: 0x0102EA55 File Offset: 0x0102CC55
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06042942 RID: 272706 RVA: 0x0102EA62 File Offset: 0x0102CC62
		public DangoBrawlRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042943 RID: 272707 RVA: 0x0102EA74 File Offset: 0x0102CC74
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

		// Token: 0x06042944 RID: 272708 RVA: 0x0102EDA0 File Offset: 0x0102CFA0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoleView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoleView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042945 RID: 272709 RVA: 0x0102EDE3 File Offset: 0x0102CFE3
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

		// Token: 0x06042946 RID: 272710 RVA: 0x0102EE1C File Offset: 0x0102D01C
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

		// Token: 0x06042947 RID: 272711 RVA: 0x0102EEE0 File Offset: 0x0102D0E0
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(11));
			this.RoleModelLoadSerial++;
			this.DestroyLoadingDangoActor();
			this.DestroyRoleDangoActor();
			this.SetRoleLightVisible(false);
		}

		// Token: 0x06042948 RID: 272712 RVA: 0x0102EF15 File Offset: 0x0102D115
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

		// Token: 0x06042949 RID: 272713 RVA: 0x0102EF38 File Offset: 0x0102D138
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
						IsRecommend = ((challengeConfigById != null) ? new bool?(challengeConfigById.GetValueOrDefault().RecommendRoleIdIter().Contains(dangoBrawlRole.Id)) : null),
						IsShowShadow = new bool?(true),
						IsNew = new bool?(this.ActivityData.HasNewRoleRedDot(dangoBrawlRole.Id))
					};
					list.Add(item);
				}
			}
			return (from data in list
			orderby data.IsRecommend.GetValueOrDefault() descending, data.SortIndex
			select data).ToList<DangoBrawlRoleData>();
		}

		// Token: 0x0604294A RID: 272714 RVA: 0x0102F0C8 File Offset: 0x0102D2C8
		private DangoBrawlRoleItem CreateRoleItem()
		{
			return new DangoBrawlRoleItem
			{
				OnClickRole = new Action<DangoBrawlRoleItem>(this.OnClickRole)
			};
		}

		// Token: 0x0604294B RID: 272715 RVA: 0x0102F0E4 File Offset: 0x0102D2E4
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

		// Token: 0x0604294C RID: 272716 RVA: 0x0102F140 File Offset: 0x0102D340
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

		// Token: 0x0604294D RID: 272717 RVA: 0x0102F1A0 File Offset: 0x0102D3A0
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

		// Token: 0x0604294E RID: 272718 RVA: 0x0102F408 File Offset: 0x0102D608
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

		// Token: 0x0604294F RID: 272719 RVA: 0x0102F454 File Offset: 0x0102D654
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

		// Token: 0x06042950 RID: 272720 RVA: 0x0102F4BA File Offset: 0x0102D6BA
		private void DestroyRoleDangoActor()
		{
			if (this.RoleDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.RoleDangoActor);
				this.RoleDangoActor = null;
			}
		}

		// Token: 0x06042951 RID: 272721 RVA: 0x0102F4DB File Offset: 0x0102D6DB
		private void DestroyLoadingDangoActor()
		{
			if (this.LoadingDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.LoadingDangoActor);
				this.LoadingDangoActor = null;
			}
		}

		// Token: 0x06042952 RID: 272722 RVA: 0x0102F4FC File Offset: 0x0102D6FC
		private void SetRoleLightVisible(bool visible)
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("Born_CharacterLight");
			if (actorByTag == null)
			{
				return;
			}
			actorByTag.SetActorHiddenInGame(!visible);
		}

		// Token: 0x06042953 RID: 272723 RVA: 0x0102F51B File Offset: 0x0102D71B
		private void RefreshBackpackPanel(int wobblePlateId)
		{
			this.RefreshBackpackPanelAsync(wobblePlateId).Forget();
		}

		// Token: 0x06042954 RID: 272724 RVA: 0x0102F52C File Offset: 0x0102D72C
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

		// Token: 0x06042955 RID: 272725 RVA: 0x0102F578 File Offset: 0x0102D778
		private UniTask CreateItemTips()
		{
			DangoBrawlRoleView.<CreateItemTips>d__37 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlRoleView.<CreateItemTips>d__37>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06042956 RID: 272726 RVA: 0x0102F5BC File Offset: 0x0102D7BC
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

		// Token: 0x06042957 RID: 272727 RVA: 0x0102F626 File Offset: 0x0102D826
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

		// Token: 0x06042958 RID: 272728 RVA: 0x0102F665 File Offset: 0x0102D865
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x06042959 RID: 272729 RVA: 0x0102F678 File Offset: 0x0102D878
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x0604295A RID: 272730 RVA: 0x0102F689 File Offset: 0x0102D889
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x0604295B RID: 272731 RVA: 0x0102F69C File Offset: 0x0102D89C
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

		// Token: 0x0604295C RID: 272732 RVA: 0x0102F71E File Offset: 0x0102D91E
		private void OnBtnClickLevelDetail()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelDetailView, new DangoBrawlLevelDetailViewOpenData
			{
				LevelId = this.SelectLevelId,
				RetryCount = 0
			}, null);
		}

		// Token: 0x0604295D RID: 272733 RVA: 0x0102F748 File Offset: 0x0102D948
		private void OnBtnClickEnter()
		{
			int selectLevelId = this.SelectLevelId;
			int selectRoleId = this.SelectRoleId;
			bool isEnterSave = this.OutGameData.GetIsEnterSave();
			ActivityDangoBrawlController.Instance.RequestEnterInstanceDungeon(selectLevelId, isEnterSave, selectRoleId).Forget<bool>();
		}

		// Token: 0x0604295E RID: 272734 RVA: 0x0102F781 File Offset: 0x0102D981
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

		// Token: 0x04022AF1 RID: 142065
		private const string DANGO_BRAWL_ROLE_SPAWN_POINT_CASE = "Born_Character";

		// Token: 0x04022AF2 RID: 142066
		private const string DANGO_BRAWL_ROLE_LIGHT_CASE = "Born_CharacterLight";

		// Token: 0x04022AF3 RID: 142067
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022AF4 RID: 142068
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> RoleLayout;

		// Token: 0x04022AF5 RID: 142069
		[Nullable(2)]
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x04022AF6 RID: 142070
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022AF7 RID: 142071
		[Nullable(2)]
		private TsUiSceneDangoActor RoleDangoActor;

		// Token: 0x04022AF8 RID: 142072
		[Nullable(2)]
		private TsUiSceneDangoActor LoadingDangoActor;

		// Token: 0x04022AF9 RID: 142073
		private int RoleModelLoadSerial;

		// Token: 0x04022AFA RID: 142074
		private int SelectLevelId;

		// Token: 0x04022AFB RID: 142075
		private int SelectRoleId;

		// Token: 0x04022AFC RID: 142076
		private int SelectRoleIndex = -1;

		// Token: 0x04022AFD RID: 142077
		private bool IfReturnToLevelView;

		// Token: 0x0200C9EC RID: 51692
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D018 RID: 249880
			CaptionItem,
			// Token: 0x0403D019 RID: 249881
			TexLevelTitleIcon,
			// Token: 0x0403D01A RID: 249882
			TxtLevelType,
			// Token: 0x0403D01B RID: 249883
			TxtLevelName,
			// Token: 0x0403D01C RID: 249884
			BtnLevelDetail,
			// Token: 0x0403D01D RID: 249885
			RoleLayout,
			// Token: 0x0403D01E RID: 249886
			RoleLayoutItem,
			// Token: 0x0403D01F RID: 249887
			TxtRoleName,
			// Token: 0x0403D020 RID: 249888
			TxtOccupationType,
			// Token: 0x0403D021 RID: 249889
			TexOccupation,
			// Token: 0x0403D022 RID: 249890
			TexBagIcon,
			// Token: 0x0403D023 RID: 249891
			TxtDesc,
			// Token: 0x0403D024 RID: 249892
			TxtBagWeight,
			// Token: 0x0403D025 RID: 249893
			BackpackPanelItem,
			// Token: 0x0403D026 RID: 249894
			BtnEnter,
			// Token: 0x0403D027 RID: 249895
			TxtRoleNameExtra,
			// Token: 0x0403D028 RID: 249896
			BtnMask,
			// Token: 0x0403D029 RID: 249897
			ItemTips,
			// Token: 0x0403D02A RID: 249898
			SprOccupationTypeBg
		}
	}
}
