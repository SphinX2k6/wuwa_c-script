using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C1 RID: 26305
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchRoleDetailView : UiViewBase
	{
		// Token: 0x06041CA5 RID: 269477 RVA: 0x00FF48EB File Offset: 0x00FF2AEB
		public DropCatchRoleDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041CA6 RID: 269478 RVA: 0x00FF48F4 File Offset: 0x00FF2AF4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIText))
			};
		}

		// Token: 0x06041CA7 RID: 269479 RVA: 0x00FF4A30 File Offset: 0x00FF2C30
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchRoleDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchRoleDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041CA8 RID: 269480 RVA: 0x00FF4A74 File Offset: 0x00FF2C74
		protected override void OnBeforeShow()
		{
			DropCatchRoleDetailViewParams dropCatchRoleDetailViewParams = this.OpenParam as DropCatchRoleDetailViewParams;
			IReadOnlyList<DropCatchRoleBook> dropCatchRoleBookAll = DropCatchConfig.Instance.GetDropCatchRoleBookAll();
			this.CurBookConfigId = 0;
			if (dropCatchRoleBookAll != null && dropCatchRoleDetailViewParams != null)
			{
				foreach (DropCatchRoleBook dropCatchRoleBook in dropCatchRoleBookAll)
				{
					if (dropCatchRoleBook.RoleId == dropCatchRoleDetailViewParams.OpenRoleConfigId)
					{
						this.CurBookConfigId = dropCatchRoleBook.Id;
						break;
					}
				}
			}
			this.UpdateRoleLayout();
			this.SetCurrentSelectedRoleDetail();
		}

		// Token: 0x06041CA9 RID: 269481 RVA: 0x00FF4B04 File Offset: 0x00FF2D04
		protected override void OnBeforeHide()
		{
			this.ClearCountdownTimer();
		}

		// Token: 0x06041CAA RID: 269482 RVA: 0x00FF4B0C File Offset: 0x00FF2D0C
		private DropCatchRoleBook? GetCurBookConfig()
		{
			return DropCatchConfig.Instance.GetDropCatchRoleBookById(this.CurBookConfigId);
		}

		// Token: 0x06041CAB RID: 269483 RVA: 0x00FF4B20 File Offset: 0x00FF2D20
		private DropCatchRole? GetCurRoleConfig()
		{
			DropCatchRoleBook? curBookConfig = this.GetCurBookConfig();
			if (curBookConfig == null)
			{
				return null;
			}
			return DropCatchConfig.Instance.GetDropCatchRoleById((curBookConfig != null) ? curBookConfig.GetValueOrDefault().RoleId : 0);
		}

		// Token: 0x06041CAC RID: 269484 RVA: 0x00FF4B6C File Offset: 0x00FF2D6C
		private DropCatchRoleItem InitRoleItem()
		{
			DropCatchRoleItem dropCatchRoleItem = new DropCatchRoleItem();
			dropCatchRoleItem.SetClickCallback(new Action<int, int>(this.OnRoleItemClick));
			return dropCatchRoleItem;
		}

		// Token: 0x06041CAD RID: 269485 RVA: 0x00FF4B85 File Offset: 0x00FF2D85
		private DropCatchRoleInfoItem InitRoleInfoItem()
		{
			return new DropCatchRoleInfoItem();
		}

		// Token: 0x06041CAE RID: 269486 RVA: 0x00FF4B8C File Offset: 0x00FF2D8C
		private void OnRoleItemClick(int configId, int index)
		{
			this.CurBookConfigId = configId;
			this.RoleLayout.SelectGridProxy(index, false);
			this.SetCurrentSelectedRoleDetail();
			this.SequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06041CAF RID: 269487 RVA: 0x00FF4BD0 File Offset: 0x00FF2DD0
		private void UpdateRoleLayout()
		{
			IReadOnlyList<DropCatchRoleBook> dropCatchRoleBookAll = DropCatchConfig.Instance.GetDropCatchRoleBookAll();
			List<IDropCatchRoleItemData> list = new List<IDropCatchRoleItemData>();
			int curIndex = 0;
			if (dropCatchRoleBookAll != null)
			{
				DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(DropCatchActivityController.Instance.ActivityId) as DropCatchActivityData;
				for (int i = 0; i < dropCatchRoleBookAll.Count; i++)
				{
					DropCatchRoleBook dropCatchRoleBook = dropCatchRoleBookAll[i];
					if (this.CurBookConfigId == 0)
					{
						this.CurBookConfigId = dropCatchRoleBook.Id;
					}
					if (dropCatchRoleBook.Id == this.CurBookConfigId)
					{
						curIndex = i;
					}
					bool isUnlock = false;
					DropCatchGameplay? targetRoleLevelInfo = DropCatchConfig.Instance.GetTargetRoleLevelInfo(dropCatchActivityData.Id, dropCatchRoleBook.RoleId);
					DropCatchLevelData levelData = dropCatchActivityData.GetLevelData(targetRoleLevelInfo.Value.Id);
					if (levelData != null && levelData.IsUnlock)
					{
						if (i > 0)
						{
							DropCatchLevelData lastLevelData = dropCatchActivityData.GetLastLevelData(targetRoleLevelInfo.Value.Id);
							if (lastLevelData != null && lastLevelData.HasAnyStar)
							{
								isUnlock = true;
							}
						}
						else
						{
							isUnlock = true;
						}
					}
					DropCatchRoleItemData item = new DropCatchRoleItemData
					{
						BookCfgId = dropCatchRoleBook.Id,
						RoleCfgId = dropCatchRoleBook.RoleId,
						IsUnlock = isUnlock
					};
					list.Add(item);
				}
			}
			this.RoleLayout.RefreshByData(list, delegate
			{
				this.RoleLayout.SelectGridProxy(curIndex, false);
				if (!this.AlreadyPlayedListAnim)
				{
					UUIInturnAnimController animationController = this.AnimationController;
					if (animationController != null)
					{
						animationController.Play("Start", -1, false);
					}
					this.AlreadyPlayedListAnim = true;
				}
			}, false);
		}

		// Token: 0x06041CB0 RID: 269488 RVA: 0x00FF4D30 File Offset: 0x00FF2F30
		private void SetCurrentSelectedRoleDetail()
		{
			this.ClearCountdownTimer();
			IReadOnlyList<IDropCatchRoleItemData> datas = this.RoleLayout.GetDatas();
			IDropCatchRoleItemData dropCatchRoleItemData = null;
			if (datas != null)
			{
				foreach (IDropCatchRoleItemData dropCatchRoleItemData2 in datas)
				{
					if (dropCatchRoleItemData2.BookCfgId == this.CurBookConfigId)
					{
						dropCatchRoleItemData = dropCatchRoleItemData2;
						break;
					}
				}
			}
			if (dropCatchRoleItemData == null)
			{
				return;
			}
			bool isUnlock = dropCatchRoleItemData.IsUnlock;
			if (isUnlock)
			{
				DropCatchActivityController.Instance.SetNewRoleClicked(dropCatchRoleItemData.RoleCfgId);
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(!isUnlock);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(isUnlock);
			}
			UUIItem uuiitem = base.GetVerticalLayout(6).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(isUnlock);
			}
			DropCatchRoleBook? curBookConfig = this.GetCurBookConfig();
			if (curBookConfig != null)
			{
				string text = curBookConfig.Value.Id.ToString();
				this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}", new string[]
				{
					text,
					text
				}), base.GetSprite(3), false, null, null);
			}
			if (isUnlock)
			{
				this.ShowUnlockDetail();
				return;
			}
			this.RefreshLockTips();
			this.ShowLockDetail();
		}

		// Token: 0x06041CB1 RID: 269489 RVA: 0x00FF4E80 File Offset: 0x00FF3080
		private void ShowUnlockDetail()
		{
			DropCatchRole? curRoleConfig = this.GetCurRoleConfig();
			if (curRoleConfig == null)
			{
				return;
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(curRoleConfig.Value.Name);
			}
			this.UpdateRoleInfo().Forget();
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.ShowTextNew(curRoleConfig.Value.Desc);
			}
			List<float> list = new List<float>();
			if (curRoleConfig.Value.GuideMoveSpeed > 0f)
			{
				list.Add(curRoleConfig.Value.GuideMoveSpeed);
			}
			if (curRoleConfig.Value.ReceiveRange != 0f)
			{
				list.Add(curRoleConfig.Value.ReceiveRange);
			}
			if (curRoleConfig.Value.GuideEnergyGetRate != 0f)
			{
				list.Add(curRoleConfig.Value.GuideEnergyGetRate);
			}
			this.RoleInfoLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06041CB2 RID: 269490 RVA: 0x00FF4F80 File Offset: 0x00FF3180
		private void ShowLockDetail()
		{
			DropCatchRole? curRoleConfig = this.GetCurRoleConfig();
			if (curRoleConfig != null)
			{
				base.SetTextureByPath(curRoleConfig.Value.SilhouettePath, base.GetTexture(11), null, null);
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew("CoinCatch_Character_UnlockName");
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("CoinCatch_Character_UnlockInfo");
		}

		// Token: 0x06041CB3 RID: 269491 RVA: 0x00FF4FF4 File Offset: 0x00FF31F4
		private void RefreshLockTips()
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(DropCatchActivityController.Instance.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			DropCatchRole? curRoleConfig = this.GetCurRoleConfig();
			if (curRoleConfig == null)
			{
				return;
			}
			DropCatchGameplay? levelConfig = DropCatchConfig.Instance.GetTargetRoleLevelInfo(dropCatchActivityData.Id, curRoleConfig.Value.Id);
			if (levelConfig == null)
			{
				return;
			}
			DropCatchLevelData dropCatchLevelData = (dropCatchActivityData != null) ? dropCatchActivityData.GetLevelData(levelConfig.Value.Id) : null;
			if (dropCatchLevelData == null)
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = dropCatchLevelData.UnlockTime - serverTime;
			this.UpdateUnlockText(levelConfig.Value.Id);
			if (num > 0.0)
			{
				this.CountdownTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					this.UpdateUnlockText(levelConfig.Value.Id);
				}, 1000f, 1f, null, null, true);
			}
		}

		// Token: 0x06041CB4 RID: 269492 RVA: 0x00FF50FC File Offset: 0x00FF32FC
		private void UpdateUnlockText(int configId)
		{
			string levelUnlockHintText = (ActivityModel.Instance.GetActivityById(DropCatchActivityController.Instance.ActivityId) as DropCatchActivityData).GetLevelUnlockHintText(configId);
			if (levelUnlockHintText != null)
			{
				base.GetText(12).SetText(levelUnlockHintText, true);
			}
		}

		// Token: 0x06041CB5 RID: 269493 RVA: 0x00FF513B File Offset: 0x00FF333B
		private void ClearCountdownTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.CountdownTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CountdownTimerHandle);
			}
			this.CountdownTimerHandle = null;
		}

		// Token: 0x06041CB6 RID: 269494 RVA: 0x00FF5168 File Offset: 0x00FF3368
		private UniTask UpdateRoleInfo()
		{
			DropCatchRoleDetailView.<UpdateRoleInfo>d__26 <UpdateRoleInfo>d__;
			<UpdateRoleInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateRoleInfo>d__.<>4__this = this;
			<UpdateRoleInfo>d__.<>1__state = -1;
			<UpdateRoleInfo>d__.<>t__builder.Start<DropCatchRoleDetailView.<UpdateRoleInfo>d__26>(ref <UpdateRoleInfo>d__);
			return <UpdateRoleInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0402245E RID: 140382
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402245F RID: 140383
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DropCatchRoleItem, IDropCatchRoleItemData> RoleLayout;

		// Token: 0x04022460 RID: 140384
		private GenericLayout<DropCatchRoleInfoItem, float> RoleInfoLayout;

		// Token: 0x04022461 RID: 140385
		[Nullable(2)]
		private TimerHandle CountdownTimerHandle;

		// Token: 0x04022462 RID: 140386
		[Nullable(2)]
		private UUIInturnAnimController AnimationController;

		// Token: 0x04022463 RID: 140387
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04022464 RID: 140388
		private int CurBookConfigId;

		// Token: 0x04022465 RID: 140389
		[Nullable(2)]
		private DropCatchGameplayRoleView RoleView;

		// Token: 0x04022466 RID: 140390
		private bool AlreadyPlayedListAnim;

		// Token: 0x04022467 RID: 140391
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}";
	}
}
