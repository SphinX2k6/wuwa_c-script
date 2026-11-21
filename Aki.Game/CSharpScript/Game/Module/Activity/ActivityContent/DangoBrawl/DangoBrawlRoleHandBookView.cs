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
	// Token: 0x02005781 RID: 22401
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoleHandBookView : UiViewBase
	{
		// Token: 0x17006A89 RID: 27273
		// (get) Token: 0x0603745C RID: 226396 RVA: 0x00F6ECE3 File Offset: 0x00F6CEE3
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A8A RID: 27274
		// (get) Token: 0x0603745D RID: 226397 RVA: 0x00F6ECEF File Offset: 0x00F6CEEF
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x0603745E RID: 226398 RVA: 0x00F6ECFC File Offset: 0x00F6CEFC
		public DangoBrawlRoleHandBookView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603745F RID: 226399 RVA: 0x00F6ED0C File Offset: 0x00F6CF0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037460 RID: 226400 RVA: 0x00F6EF8C File Offset: 0x00F6D18C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoleHandBookView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037461 RID: 226401 RVA: 0x00F6EFCF File Offset: 0x00F6D1CF
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(7));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnViewStartSequence));
		}

		// Token: 0x06037462 RID: 226402 RVA: 0x00F6F004 File Offset: 0x00F6D204
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
			ActivityDangoBrawlController.Instance.TryPlayRoleUnlockQueue();
			this.SetRoleLightVisible(true);
		}

		// Token: 0x06037463 RID: 226403 RVA: 0x00F6F08D File Offset: 0x00F6D28D
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(7));
			this.RoleModelLoadSerial++;
			this.DestroyLoadingDangoActor();
			this.DestroyRoleDangoActor();
			this.SetRoleLightVisible(false);
		}

		// Token: 0x06037464 RID: 226404 RVA: 0x00F6F0C1 File Offset: 0x00F6D2C1
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

		// Token: 0x06037465 RID: 226405 RVA: 0x00F6F0E4 File Offset: 0x00F6D2E4
		private List<DangoBrawlRoleData> GetRoleDataList()
		{
			IEnumerable<DangoBrawlRole> roleConfigList = DangoBrawlConfig.Instance.GetRoleConfigList(this.ActivityData.Id);
			List<DangoBrawlRoleData> list = new List<DangoBrawlRoleData>();
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			foreach (DangoBrawlRole dangoBrawlRole in roleConfigList)
			{
				EPlayerGender gender = (EPlayerGender)dangoBrawlRole.Gender;
				if (gender == playerGender || gender == EPlayerGender.None)
				{
					bool flag = this.OutGameData.IsRoleUnlocked(dangoBrawlRole.Id);
					list.Add(new DangoBrawlRoleData
					{
						RoleId = dangoBrawlRole.Id,
						SortIndex = dangoBrawlRole.SortIndex,
						IsUnlocked = flag,
						IsShowShadow = new bool?(false),
						IsNew = new bool?(flag && this.ActivityData.HasNewRoleRedDot(dangoBrawlRole.Id))
					});
				}
			}
			list.Sort((DangoBrawlRoleData a, DangoBrawlRoleData b) => a.SortIndex.CompareTo(b.SortIndex));
			return list;
		}

		// Token: 0x06037466 RID: 226406 RVA: 0x00F6F1FC File Offset: 0x00F6D3FC
		private DangoBrawlRoleItem CreateRoleItem()
		{
			return new DangoBrawlRoleItem
			{
				OnClickRole = new Action<DangoBrawlRoleItem>(this.OnClickRole)
			};
		}

		// Token: 0x06037467 RID: 226407 RVA: 0x00F6F218 File Offset: 0x00F6D418
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

		// Token: 0x06037468 RID: 226408 RVA: 0x00F6F274 File Offset: 0x00F6D474
		private void OnClickRole(DangoBrawlRoleItem item)
		{
			DangoBrawlRoleData roleData = item.RoleData;
			if (roleData == null)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_L", false, null);
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

		// Token: 0x06037469 RID: 226409 RVA: 0x00F6F2EC File Offset: 0x00F6D4EC
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
			if (occupationConfigById != null)
			{
				base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(5), null, null);
				FColor color = FColor.FromHex(occupationConfigById.Value.Color);
				UUISprite sprite = base.GetSprite(14);
				if (sprite != null)
				{
					sprite.SetColor(color);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), occupationConfigById.Value.Name, Array.Empty<object>());
			}
			FunctionalPanelConditionLock lockTipsItem = this.LockTipsItem;
			if (lockTipsItem != null)
			{
				lockTipsItem.SetUiActive(!roleData.IsUnlocked);
			}
			base.GetTexture(15).SetUIActive(roleData.IsUnlocked);
			FunctionalPanelConditionLock lockTipsItem2 = this.LockTipsItem;
			if (lockTipsItem2 != null)
			{
				lockTipsItem2.SetTextByTextId(roleConfigById.Value.UnlockCondDesc, Array.Empty<string>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), roleConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), roleConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), roleConfigById.Value.Desc, Array.Empty<object>());
			this.InitRoleDangoActor(roleConfigById.Value).Forget();
			this.RefreshBackpackPanel(roleConfigById.Value.WobblePlateId);
		}

		// Token: 0x0603746A RID: 226410 RVA: 0x00F6F4BC File Offset: 0x00F6D6BC
		private UniTask InitRoleDangoActor(DangoBrawlRole roleConfig)
		{
			DangoBrawlRoleHandBookView.<InitRoleDangoActor>d__29 <InitRoleDangoActor>d__;
			<InitRoleDangoActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDangoActor>d__.<>4__this = this;
			<InitRoleDangoActor>d__.roleConfig = roleConfig;
			<InitRoleDangoActor>d__.<>1__state = -1;
			<InitRoleDangoActor>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<InitRoleDangoActor>d__29>(ref <InitRoleDangoActor>d__);
			return <InitRoleDangoActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603746B RID: 226411 RVA: 0x00F6F508 File Offset: 0x00F6D708
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
					UiModelBase model = actor.Model;
					if (model == null)
					{
						return;
					}
					UiModelAnimationComponent uiModelAnimationComponent = model.CheckGetComponent<UiModelAnimationComponent>();
					if (uiModelAnimationComponent == null)
					{
						return;
					}
					uiModelAnimationComponent.PlayMontage(montage);
				}
			}).Forget();
		}

		// Token: 0x0603746C RID: 226412 RVA: 0x00F6F56E File Offset: 0x00F6D76E
		private void DestroyRoleDangoActor()
		{
			if (this.RoleDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.RoleDangoActor);
				this.RoleDangoActor = null;
			}
		}

		// Token: 0x0603746D RID: 226413 RVA: 0x00F6F58F File Offset: 0x00F6D78F
		private void DestroyLoadingDangoActor()
		{
			if (this.LoadingDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.LoadingDangoActor);
				this.LoadingDangoActor = null;
			}
		}

		// Token: 0x0603746E RID: 226414 RVA: 0x00F6F5B0 File Offset: 0x00F6D7B0
		private void SetRoleLightVisible(bool visible)
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("Born_CharacterLight");
			if (actorByTag == null)
			{
				return;
			}
			actorByTag.SetActorHiddenInGame(!visible);
		}

		// Token: 0x0603746F RID: 226415 RVA: 0x00F6F5CF File Offset: 0x00F6D7CF
		private void RefreshBackpackPanel(int wobblePlateId)
		{
			this.RefreshBackpackPanelAsync(wobblePlateId).Forget();
		}

		// Token: 0x06037470 RID: 226416 RVA: 0x00F6F5E0 File Offset: 0x00F6D7E0
		private UniTask RefreshBackpackPanelAsync(int wobblePlateId)
		{
			DangoBrawlRoleHandBookView.<RefreshBackpackPanelAsync>d__35 <RefreshBackpackPanelAsync>d__;
			<RefreshBackpackPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBackpackPanelAsync>d__.<>4__this = this;
			<RefreshBackpackPanelAsync>d__.wobblePlateId = wobblePlateId;
			<RefreshBackpackPanelAsync>d__.<>1__state = -1;
			<RefreshBackpackPanelAsync>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<RefreshBackpackPanelAsync>d__35>(ref <RefreshBackpackPanelAsync>d__);
			return <RefreshBackpackPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037471 RID: 226417 RVA: 0x00F6F62C File Offset: 0x00F6D82C
		private void OnBackpackItemClick(DangoBrawlOutBackpackItemBase item)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_R", false, null);
			}
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

		// Token: 0x06037472 RID: 226418 RVA: 0x00F6F6B6 File Offset: 0x00F6D8B6
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

		// Token: 0x06037473 RID: 226419 RVA: 0x00F6F6F5 File Offset: 0x00F6D8F5
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x06037474 RID: 226420 RVA: 0x00F6F708 File Offset: 0x00F6D908
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x06037475 RID: 226421 RVA: 0x00F6F719 File Offset: 0x00F6D919
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x06037476 RID: 226422 RVA: 0x00F6F72A File Offset: 0x00F6D92A
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037477 RID: 226423 RVA: 0x00F6F734 File Offset: 0x00F6D934
		private UniTask CreateItemTips()
		{
			DangoBrawlRoleHandBookView.<CreateItemTips>d__42 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<CreateItemTips>d__42>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06037478 RID: 226424 RVA: 0x00F6F777 File Offset: 0x00F6D977
		private void OnClickMask()
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

		// Token: 0x0401D33A RID: 119610
		private const string DANGO_BRAWL_ROLE_SPAWN_POINT_CASE = "Born_Character";

		// Token: 0x0401D33B RID: 119611
		private const string DANGO_BRAWL_ROLE_LIGHT_CASE = "Born_CharacterLight";

		// Token: 0x0401D33C RID: 119612
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D33D RID: 119613
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> RoleLayout;

		// Token: 0x0401D33E RID: 119614
		[Nullable(2)]
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x0401D33F RID: 119615
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D340 RID: 119616
		[Nullable(2)]
		private TsUiSceneDangoActor RoleDangoActor;

		// Token: 0x0401D341 RID: 119617
		[Nullable(2)]
		private TsUiSceneDangoActor LoadingDangoActor;

		// Token: 0x0401D342 RID: 119618
		private int RoleModelLoadSerial;

		// Token: 0x0401D343 RID: 119619
		[Nullable(2)]
		private FunctionalPanelConditionLock LockTipsItem;

		// Token: 0x0401D344 RID: 119620
		private int SelectRoleId;

		// Token: 0x0401D345 RID: 119621
		private int SelectRoleIndex = -1;

		// Token: 0x0200B3AA RID: 45994
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040378B7 RID: 227511
			CaptionItem,
			// Token: 0x040378B8 RID: 227512
			RoleLayout,
			// Token: 0x040378B9 RID: 227513
			RoleLayoutItem,
			// Token: 0x040378BA RID: 227514
			TxtRoleName,
			// Token: 0x040378BB RID: 227515
			TxtOccupationType,
			// Token: 0x040378BC RID: 227516
			TexOccupation,
			// Token: 0x040378BD RID: 227517
			TexBagIcon,
			// Token: 0x040378BE RID: 227518
			TxtDesc,
			// Token: 0x040378BF RID: 227519
			TxtBagWeight,
			// Token: 0x040378C0 RID: 227520
			BackpackPanelItem,
			// Token: 0x040378C1 RID: 227521
			LockTipsItem,
			// Token: 0x040378C2 RID: 227522
			TxtRoleNameExtra,
			// Token: 0x040378C3 RID: 227523
			BtnMask,
			// Token: 0x040378C4 RID: 227524
			ItemTips,
			// Token: 0x040378C5 RID: 227525
			SprOccupationTypeBg,
			// Token: 0x040378C6 RID: 227526
			TexDecorate
		}
	}
}
