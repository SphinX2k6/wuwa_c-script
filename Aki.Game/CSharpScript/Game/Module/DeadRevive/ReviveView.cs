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
	// Token: 0x02005ACC RID: 23244
	[NullableContext(2)]
	[Nullable(0)]
	public class ReviveView : UiTickViewBase
	{
		// Token: 0x0603ADDB RID: 241115 RVA: 0x00E085A0 File Offset: 0x00E067A0
		[NullableContext(1)]
		public ReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ADDC RID: 241116 RVA: 0x00E085B0 File Offset: 0x00E067B0
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

		// Token: 0x0603ADDD RID: 241117 RVA: 0x00E0880C File Offset: 0x00E06A0C
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

		// Token: 0x0603ADDE RID: 241118 RVA: 0x00E08AB6 File Offset: 0x00E06CB6
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

		// Token: 0x0603ADDF RID: 241119 RVA: 0x00E08ACC File Offset: 0x00E06CCC
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

		// Token: 0x0603ADE0 RID: 241120 RVA: 0x00E08B14 File Offset: 0x00E06D14
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

		// Token: 0x0603ADE1 RID: 241121 RVA: 0x00E08CBC File Offset: 0x00E06EBC
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

		// Token: 0x0603ADE2 RID: 241122 RVA: 0x00E08D2A File Offset: 0x00E06F2A
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

		// Token: 0x0603ADE3 RID: 241123 RVA: 0x00E08D43 File Offset: 0x00E06F43
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

		// Token: 0x0603ADE4 RID: 241124 RVA: 0x00E08D78 File Offset: 0x00E06F78
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

		// Token: 0x0603ADE5 RID: 241125 RVA: 0x00E08DD0 File Offset: 0x00E06FD0
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

		// Token: 0x0603ADE6 RID: 241126 RVA: 0x00E08E2C File Offset: 0x00E0702C
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

		// Token: 0x0603ADE7 RID: 241127 RVA: 0x00E08EA0 File Offset: 0x00E070A0
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

		// Token: 0x0603ADE8 RID: 241128 RVA: 0x00E08F08 File Offset: 0x00E07108
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

		// Token: 0x0401EB85 RID: 125829
		private const int TIME_SECOND = 1000;

		// Token: 0x0401EB86 RID: 125830
		private const int AUTO_REVIVE_TIME = 60;

		// Token: 0x0401EB87 RID: 125831
		private float TimeCount;

		// Token: 0x0401EB88 RID: 125832
		private int CountNumber;

		// Token: 0x0401EB89 RID: 125833
		private int ReviveNumber = -1;

		// Token: 0x0401EB8A RID: 125834
		private int AutoReviveCountDownTime;

		// Token: 0x0401EB8B RID: 125835
		private bool IsAutoRevived;

		// Token: 0x0401EB8C RID: 125836
		private UUIText CountDown;

		// Token: 0x0401EB8D RID: 125837
		private UUIText AutoReviveCountDown;

		// Token: 0x0401EB8E RID: 125838
		private UUIInteractionGroup ReviveBtnInteraction;

		// Token: 0x0401EB8F RID: 125839
		private string ItemName;

		// Token: 0x0401EB90 RID: 125840
		private string ItemCd;

		// Token: 0x0401EB91 RID: 125841
		private bool CanRevive;

		// Token: 0x0401EB92 RID: 125842
		private TrainingView TrainingView;

		// Token: 0x0401EB93 RID: 125843
		private bool IsInInstance;

		// Token: 0x0401EB94 RID: 125844
		private bool IsMorale;

		// Token: 0x0200BD1D RID: 48413
		[NullableContext(0)]
		private class EReviveViewComponent
		{
			// Token: 0x04039097 RID: 233623
			public const int Revive = 0;

			// Token: 0x04039098 RID: 233624
			public const int Fail = 1;

			// Token: 0x04039099 RID: 233625
			public const int ReviveBtn = 2;

			// Token: 0x0403909A RID: 233626
			public const int GiveUpBtn = 3;

			// Token: 0x0403909B RID: 233627
			public const int WaitTime = 4;

			// Token: 0x0403909C RID: 233628
			public const int ReviveTitle = 5;

			// Token: 0x0403909D RID: 233629
			public const int ReviveContent = 6;

			// Token: 0x0403909E RID: 233630
			public const int RoleTrainingLayout = 7;

			// Token: 0x0403909F RID: 233631
			public const int ReviveAtLocationBtn = 8;

			// Token: 0x040390A0 RID: 233632
			public const int AutoReviveCountDownText = 9;

			// Token: 0x040390A1 RID: 233633
			public const int ItemTexture = 10;

			// Token: 0x040390A2 RID: 233634
			public const int ItemText = 11;

			// Token: 0x040390A3 RID: 233635
			public const int GiveUpBtnText = 12;
		}
	}
}
