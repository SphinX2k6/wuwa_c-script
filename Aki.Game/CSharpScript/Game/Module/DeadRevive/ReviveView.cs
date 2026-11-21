using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AAD RID: 19117
	[NullableContext(2)]
	[Nullable(0)]
	public class ReviveView : UiTickViewBase
	{
		// Token: 0x0602FD4D RID: 195917 RVA: 0x00D59280 File Offset: 0x00D57480
		[NullableContext(1)]
		public ReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FD4E RID: 195918 RVA: 0x00D59290 File Offset: 0x00D57490
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRevive));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGiveUp));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickReviveAtLocation));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FD4F RID: 195919 RVA: 0x00D594EC File Offset: 0x00D576EC
		protected override void OnStart()
		{
			this.CountDown = base.GetText(4);
			this.AutoReviveCountDown = base.GetText(9);
			this.IsMorale = MoraleBattleModel.Instance.IsMoraleActive();
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			UUIButtonComponent button = base.GetButton(3);
			UUIButtonComponent button2 = base.GetButton(2);
			this.ReviveBtnInteraction = (button2.GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
			this.IsInInstance = GameModeController.Instance.IsInInstance();
			if (!this.IsInInstance)
			{
				button2.GetRootComponent().SetAnchorOffset(button.GetRootComponent().GetAnchorOffset());
				button.GetRootComponent().SetUIActive(false);
				this.InitItemInfo();
			}
			else if (GameModeModel.Instance.IsMulti)
			{
				base.GetButton(2).GetRootComponent().SetUIActive(false);
				LguiUtil.Instance.SetLocalText(base.GetText(12), "ExitInstance", Array.Empty<object>());
				LguiUtil.Instance.SetLocalText(base.GetText(6), "MatchInstanceDead", Array.Empty<object>());
			}
			Revive? reviveConfig = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig != null)
			{
				this.ReviveNumber = reviveConfig.Value.ReviveTimes;
			}
			item2.SetUIActive(true);
			item.SetUIActive(false);
			this.CountNumber = (int)DeadReviveModel.Instance.ReviveLimitTime;
			this.CanRevive = false;
			bool uiactive = true;
			if (this.CountNumber > 0)
			{
				this.CountDown.SetText(this.CountNumber.ToString() + "s", true);
				this.ReviveBtnInteraction.SetInteractable(false);
			}
			else if (this.CountNumber <= 0)
			{
				uiactive = false;
				this.CanRevive = true;
				this.AutoReviveCountDownTime = 60;
				if (!GameModeController.Instance.IsInInstance())
				{
					this.AutoReviveCountDown.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalText(this.AutoReviveCountDown, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveCountDownTime));
			}
			else
			{
				LguiUtil.Instance.SetLocalText(this.CountDown, "ReachReviveCount", Array.Empty<object>());
				this.ReviveBtnInteraction.SetInteractable(false);
			}
			this.CountDown.SetUIActive(uiactive);
			UUIText text = base.GetText(5);
			DeadReviveModel instance = DeadReviveModel.Instance;
			text.ShowTextNew(((instance.ReviveConfig != null) ? instance.ReviveConfig.GetValueOrDefault().ReviveTitle : null) ?? "");
			UUIText text2 = base.GetText(6);
			if (!GameModeController.Instance.IsInInstance() && !GameModeModel.Instance.IsMulti)
			{
				text2.ShowTextNew(this.GetReviveContent());
			}
			this.TrainingView = new TrainingView();
			this.TrainingView.Show(base.GetHorizontalLayout(7), this.GetTrainingDataList());
		}

		// Token: 0x0602FD50 RID: 195920 RVA: 0x00D59796 File Offset: 0x00D57996
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TrainingData> GetTrainingDataList()
		{
			if (this.IsMorale)
			{
				return MoraleModel.Instance.GetMoraleBuffDataList();
			}
			return null;
		}

		// Token: 0x0602FD51 RID: 195921 RVA: 0x00D597AC File Offset: 0x00D579AC
		[NullableContext(1)]
		private string GetReviveContent()
		{
			if (this.IsMorale)
			{
				return "Morale_title_29";
			}
			DeadReviveModel instance = DeadReviveModel.Instance;
			return ((instance.ReviveConfig != null) ? instance.ReviveConfig.GetValueOrDefault().ReviveContent : null) ?? "";
		}

		// Token: 0x0602FD52 RID: 195922 RVA: 0x00D597F4 File Offset: 0x00D579F4
		private void InitItemInfo()
		{
			int num = -1;
			Revive? reviveConfig = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig != null)
			{
				num = reviveConfig.Value.UseItemId;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
			if (itemCountByConfigId <= 0)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(8);
			button.GetRootComponent().SetUIActive(true);
			UUITexture texture = base.GetTexture(10);
			UUIText text = base.GetText(11);
			BuffItemModel instance = BuffItemModel.Instance;
			base.SetItemIcon(texture, num, null, null);
			this.ItemName = ItemConfig.Instance.GetItemName(num);
			int buffItemTotalCdTime = BuffItemConfig.Instance.GetBuffItemTotalCdTime(num);
			if ((double)buffItemTotalCdTime < TimeUtil.Instance.Minute)
			{
				this.ItemCd = buffItemTotalCdTime.ToString() + TextConfig.Instance.GetTextById("Second");
			}
			else
			{
				this.ItemCd = Math.Floor((double)buffItemTotalCdTime / TimeUtil.Instance.Minute).ToString() + TextConfig.Instance.GetTextById("MinuteText");
				double num2 = (double)buffItemTotalCdTime % TimeUtil.Instance.Minute;
				if (num2 > 0.0)
				{
					this.ItemCd = this.ItemCd + num2.ToString() + TextConfig.Instance.GetTextById("Second");
				}
			}
			if (instance.GetBuffItemRemainCdTime(num) > 0.0)
			{
				LguiUtil.Instance.SetLocalText(text, "ReviveItemCd", Array.Empty<object>());
				(button.GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(false);
				return;
			}
			text.SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0602FD53 RID: 195923 RVA: 0x00D5999C File Offset: 0x00D57B9C
		private void OnClickRevive()
		{
			if (this.ReviveNumber == 0)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotRevive", Array.Empty<object>());
				return;
			}
			if (this.CanRevive)
			{
				DeadReviveController.Instance.ReviveRequest(false, new Action<bool>(this.ReviveFinish), null);
				return;
			}
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.YZ, "Time Or Times Limit!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602FD54 RID: 195924 RVA: 0x00D59A0A File Offset: 0x00D57C0A
		private void ReviveFinish(bool result)
		{
			if (!result)
			{
				return;
			}
			if (this.IsMorale)
			{
				MoraleBattleController.Instance.SetReviveFromMoraleBattle(true);
			}
		}

		// Token: 0x0602FD55 RID: 195925 RVA: 0x00D59A23 File Offset: 0x00D57C23
		private void OnClickGiveUp()
		{
			base.CloseMe(null);
			if (DeadReviveModel.Instance.HandleOnClickGiveUpExternal != null)
			{
				DeadReviveModel.Instance.HandleOnClickGiveUpExternal();
				return;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}

		// Token: 0x0602FD56 RID: 195926 RVA: 0x00D59A58 File Offset: 0x00D57C58
		private void OnClickReviveAtLocation()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.UsingItemRevive);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				this.ItemName,
				this.ItemCd
			});
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (this.CanRevive)
				{
					DeadReviveController.Instance.ReviveRequest(true, null, null);
					return;
				}
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.YZ, "Time Or Times Limit!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602FD57 RID: 195927 RVA: 0x00D59AB0 File Offset: 0x00D57CB0
		protected override void OnTick(float delta)
		{
			if ((this.CanRevive || this.CountNumber < 0) && this.IsAutoRevived)
			{
				return;
			}
			this.TimeCount += delta;
			if (this.TimeCount >= 1000f)
			{
				this.TimeCount = 0f;
				this.AutoReviveOnTick();
				this.CanReviveOnTick();
			}
		}

		// Token: 0x0602FD58 RID: 195928 RVA: 0x00D59B0C File Offset: 0x00D57D0C
		private void AutoReviveOnTick()
		{
			if (this.IsInInstance)
			{
				return;
			}
			if (this.IsAutoRevived)
			{
				return;
			}
			if (this.AutoReviveCountDownTime <= 0)
			{
				this.IsAutoRevived = true;
				ConfirmBoxController.Instance.CloseConfirmBoxView();
				this.OnClickRevive();
				return;
			}
			this.AutoReviveCountDownTime--;
			LguiUtil.Instance.SetLocalText(this.AutoReviveCountDown, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveCountDownTime));
		}

		// Token: 0x0602FD59 RID: 195929 RVA: 0x00D59B80 File Offset: 0x00D57D80
		private void CanReviveOnTick()
		{
			if (this.CountNumber <= 0)
			{
				this.CanRevive = true;
				this.CountDown.SetUIActive(false);
				this.ReviveBtnInteraction.SetInteractable(true);
				return;
			}
			this.CountNumber--;
			this.CountDown.SetText(this.CountNumber.ToString() + "s", true);
		}

		// Token: 0x0602FD5A RID: 195930 RVA: 0x00D59BE8 File Offset: 0x00D57DE8
		protected override void OnBeforeDestroy()
		{
			if (this.TrainingView != null)
			{
				this.TrainingView.Clear();
			}
			this.TrainingView = null;
			this.CountDown = null;
			this.AutoReviveCountDown = null;
			this.ReviveBtnInteraction = null;
			this.ItemName = null;
			this.ItemCd = null;
			this.ReviveNumber = -1;
			this.TimeCount = 0f;
			this.CountNumber = 0;
			this.AutoReviveCountDownTime = 0;
			this.CanRevive = false;
			this.IsInInstance = false;
			this.IsAutoRevived = false;
			DeadReviveModel.Instance.ClearExternalHandles();
		}

		// Token: 0x04019641 RID: 104001
		private const int TIME_SECOND = 1000;

		// Token: 0x04019642 RID: 104002
		private const int AUTO_REVIVE_TIME = 60;

		// Token: 0x04019643 RID: 104003
		private float TimeCount;

		// Token: 0x04019644 RID: 104004
		private int CountNumber;

		// Token: 0x04019645 RID: 104005
		private int ReviveNumber = -1;

		// Token: 0x04019646 RID: 104006
		private int AutoReviveCountDownTime;

		// Token: 0x04019647 RID: 104007
		private bool IsAutoRevived;

		// Token: 0x04019648 RID: 104008
		private UUIText CountDown;

		// Token: 0x04019649 RID: 104009
		private UUIText AutoReviveCountDown;

		// Token: 0x0401964A RID: 104010
		private UUIInteractionGroup ReviveBtnInteraction;

		// Token: 0x0401964B RID: 104011
		private string ItemName;

		// Token: 0x0401964C RID: 104012
		private string ItemCd;

		// Token: 0x0401964D RID: 104013
		private bool CanRevive;

		// Token: 0x0401964E RID: 104014
		private TrainingView TrainingView;

		// Token: 0x0401964F RID: 104015
		private bool IsInInstance;

		// Token: 0x04019650 RID: 104016
		private bool IsMorale;

		// Token: 0x0200A725 RID: 42789
		[NullableContext(0)]
		private class EReviveViewComponent
		{
			// Token: 0x04033A61 RID: 211553
			public const int Revive = 0;

			// Token: 0x04033A62 RID: 211554
			public const int Fail = 1;

			// Token: 0x04033A63 RID: 211555
			public const int ReviveBtn = 2;

			// Token: 0x04033A64 RID: 211556
			public const int GiveUpBtn = 3;

			// Token: 0x04033A65 RID: 211557
			public const int WaitTime = 4;

			// Token: 0x04033A66 RID: 211558
			public const int ReviveTitle = 5;

			// Token: 0x04033A67 RID: 211559
			public const int ReviveContent = 6;

			// Token: 0x04033A68 RID: 211560
			public const int RoleTrainingLayout = 7;

			// Token: 0x04033A69 RID: 211561
			public const int ReviveAtLocationBtn = 8;

			// Token: 0x04033A6A RID: 211562
			public const int AutoReviveCountDownText = 9;

			// Token: 0x04033A6B RID: 211563
			public const int ItemTexture = 10;

			// Token: 0x04033A6C RID: 211564
			public const int ItemText = 11;

			// Token: 0x04033A6D RID: 211565
			public const int GiveUpBtnText = 12;
		}
	}
}
