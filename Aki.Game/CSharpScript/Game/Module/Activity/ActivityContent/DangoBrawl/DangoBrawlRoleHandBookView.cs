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
	// Token: 0x02006831 RID: 26673
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRoleHandBookView : UiViewBase
	{
		// Token: 0x17009748 RID: 38728
		// (get) Token: 0x06042908 RID: 272648 RVA: 0x0102D7A7 File Offset: 0x0102B9A7
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17009749 RID: 38729
		// (get) Token: 0x06042909 RID: 272649 RVA: 0x0102D7B3 File Offset: 0x0102B9B3
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x0604290A RID: 272650 RVA: 0x0102D7C0 File Offset: 0x0102B9C0
		public DangoBrawlRoleHandBookView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604290B RID: 272651 RVA: 0x0102D7D0 File Offset: 0x0102B9D0
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

		// Token: 0x0604290C RID: 272652 RVA: 0x0102DA50 File Offset: 0x0102BC50
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRoleHandBookView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604290D RID: 272653 RVA: 0x0102DA93 File Offset: 0x0102BC93
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

		// Token: 0x0604290E RID: 272654 RVA: 0x0102DAC8 File Offset: 0x0102BCC8
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

		// Token: 0x0604290F RID: 272655 RVA: 0x0102DB51 File Offset: 0x0102BD51
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(7));
			this.RoleModelLoadSerial++;
			this.DestroyLoadingDangoActor();
			this.DestroyRoleDangoActor();
			this.SetRoleLightVisible(false);
		}

		// Token: 0x06042910 RID: 272656 RVA: 0x0102DB85 File Offset: 0x0102BD85
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

		// Token: 0x06042911 RID: 272657 RVA: 0x0102DBA8 File Offset: 0x0102BDA8
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

		// Token: 0x06042912 RID: 272658 RVA: 0x0102DCC0 File Offset: 0x0102BEC0
		private DangoBrawlRoleItem CreateRoleItem()
		{
			return new DangoBrawlRoleItem
			{
				OnClickRole = new Action<DangoBrawlRoleItem>(this.OnClickRole)
			};
		}

		// Token: 0x06042913 RID: 272659 RVA: 0x0102DCDC File Offset: 0x0102BEDC
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

		// Token: 0x06042914 RID: 272660 RVA: 0x0102DD38 File Offset: 0x0102BF38
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

		// Token: 0x06042915 RID: 272661 RVA: 0x0102DDB0 File Offset: 0x0102BFB0
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

		// Token: 0x06042916 RID: 272662 RVA: 0x0102DF80 File Offset: 0x0102C180
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

		// Token: 0x06042917 RID: 272663 RVA: 0x0102DFCC File Offset: 0x0102C1CC
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

		// Token: 0x06042918 RID: 272664 RVA: 0x0102E032 File Offset: 0x0102C232
		private void DestroyRoleDangoActor()
		{
			if (this.RoleDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.RoleDangoActor);
				this.RoleDangoActor = null;
			}
		}

		// Token: 0x06042919 RID: 272665 RVA: 0x0102E053 File Offset: 0x0102C253
		private void DestroyLoadingDangoActor()
		{
			if (this.LoadingDangoActor != null)
			{
				UiSceneManager.Instance.DestroyDangoActor(this.LoadingDangoActor);
				this.LoadingDangoActor = null;
			}
		}

		// Token: 0x0604291A RID: 272666 RVA: 0x0102E074 File Offset: 0x0102C274
		private void SetRoleLightVisible(bool visible)
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("Born_CharacterLight");
			if (actorByTag == null)
			{
				return;
			}
			actorByTag.SetActorHiddenInGame(!visible);
		}

		// Token: 0x0604291B RID: 272667 RVA: 0x0102E093 File Offset: 0x0102C293
		private void RefreshBackpackPanel(int wobblePlateId)
		{
			this.RefreshBackpackPanelAsync(wobblePlateId).Forget();
		}

		// Token: 0x0604291C RID: 272668 RVA: 0x0102E0A4 File Offset: 0x0102C2A4
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

		// Token: 0x0604291D RID: 272669 RVA: 0x0102E0F0 File Offset: 0x0102C2F0
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

		// Token: 0x0604291E RID: 272670 RVA: 0x0102E17A File Offset: 0x0102C37A
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

		// Token: 0x0604291F RID: 272671 RVA: 0x0102E1B9 File Offset: 0x0102C3B9
		private void OnBackpackItemDeselect()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x06042920 RID: 272672 RVA: 0x0102E1CC File Offset: 0x0102C3CC
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x06042921 RID: 272673 RVA: 0x0102E1DD File Offset: 0x0102C3DD
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x06042922 RID: 272674 RVA: 0x0102E1EE File Offset: 0x0102C3EE
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042923 RID: 272675 RVA: 0x0102E1F8 File Offset: 0x0102C3F8
		private UniTask CreateItemTips()
		{
			DangoBrawlRoleHandBookView.<CreateItemTips>d__42 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlRoleHandBookView.<CreateItemTips>d__42>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06042924 RID: 272676 RVA: 0x0102E23B File Offset: 0x0102C43B
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

		// Token: 0x04022ADD RID: 142045
		private const string DANGO_BRAWL_ROLE_SPAWN_POINT_CASE = "Born_Character";

		// Token: 0x04022ADE RID: 142046
		private const string DANGO_BRAWL_ROLE_LIGHT_CASE = "Born_CharacterLight";

		// Token: 0x04022ADF RID: 142047
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022AE0 RID: 142048
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRoleItem, DangoBrawlRoleData> RoleLayout;

		// Token: 0x04022AE1 RID: 142049
		[Nullable(2)]
		private DangoBrawlOutBackpackPanel BackpackPanel;

		// Token: 0x04022AE2 RID: 142050
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022AE3 RID: 142051
		[Nullable(2)]
		private TsUiSceneDangoActor RoleDangoActor;

		// Token: 0x04022AE4 RID: 142052
		[Nullable(2)]
		private TsUiSceneDangoActor LoadingDangoActor;

		// Token: 0x04022AE5 RID: 142053
		private int RoleModelLoadSerial;

		// Token: 0x04022AE6 RID: 142054
		[Nullable(2)]
		private FunctionalPanelConditionLock LockTipsItem;

		// Token: 0x04022AE7 RID: 142055
		private int SelectRoleId;

		// Token: 0x04022AE8 RID: 142056
		private int SelectRoleIndex = -1;

		// Token: 0x0200C9DE RID: 51678
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CFCD RID: 249805
			CaptionItem,
			// Token: 0x0403CFCE RID: 249806
			RoleLayout,
			// Token: 0x0403CFCF RID: 249807
			RoleLayoutItem,
			// Token: 0x0403CFD0 RID: 249808
			TxtRoleName,
			// Token: 0x0403CFD1 RID: 249809
			TxtOccupationType,
			// Token: 0x0403CFD2 RID: 249810
			TexOccupation,
			// Token: 0x0403CFD3 RID: 249811
			TexBagIcon,
			// Token: 0x0403CFD4 RID: 249812
			TxtDesc,
			// Token: 0x0403CFD5 RID: 249813
			TxtBagWeight,
			// Token: 0x0403CFD6 RID: 249814
			BackpackPanelItem,
			// Token: 0x0403CFD7 RID: 249815
			LockTipsItem,
			// Token: 0x0403CFD8 RID: 249816
			TxtRoleNameExtra,
			// Token: 0x0403CFD9 RID: 249817
			BtnMask,
			// Token: 0x0403CFDA RID: 249818
			ItemTips,
			// Token: 0x0403CFDB RID: 249819
			SprOccupationTypeBg,
			// Token: 0x0403CFDC RID: 249820
			TexDecorate
		}
	}
}
