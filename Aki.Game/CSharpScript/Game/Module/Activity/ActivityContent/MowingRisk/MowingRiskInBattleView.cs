using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200535F RID: 21343
	public class MowingRiskInBattleView : BattleVisibleChildView
	{
		// Token: 0x060351C0 RID: 217536 RVA: 0x00ED52F0 File Offset: 0x00ED34F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060351C1 RID: 217537 RVA: 0x00ED53B7 File Offset: 0x00ED35B7
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEventListeners();
		}

		// Token: 0x060351C2 RID: 217538 RVA: 0x00ED53D5 File Offset: 0x00ED35D5
		public override void Reset()
		{
			base.Reset();
			this.RemoveEventListeners();
		}

		// Token: 0x060351C3 RID: 217539 RVA: 0x00ED53E3 File Offset: 0x00ED35E3
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.Player = new UiSequencePlayer(base.GetRootItem());
			this.Player.LiteJumpToEnd("Start");
		}

		// Token: 0x060351C4 RID: 217540 RVA: 0x00ED5419 File Offset: 0x00ED3619
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer player = this.Player;
			if (player != null)
			{
				player.LiteExit();
			}
			this.Player = null;
		}

		// Token: 0x060351C5 RID: 217541 RVA: 0x00ED5433 File Offset: 0x00ED3633
		private void OnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MowingBuffView, EMowingBuffViewUsage.InBattle, null);
		}

		// Token: 0x060351C6 RID: 217542 RVA: 0x00ED544B File Offset: 0x00ED364B
		[NullableContext(1)]
		private void OnInputBuffAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			if (ActivityMowingRiskController.Instance.CheckInInstanceDungeon())
			{
				UiManager.Instance.OpenView(EUiViewName.MowingBuffView, EMowingBuffViewUsage.InBattle, null);
			}
		}

		// Token: 0x060351C7 RID: 217543 RVA: 0x00ED5474 File Offset: 0x00ED3674
		private void AddEventListeners()
		{
			EventSystem.Instance.Add<IMowingRiskInBattleRootData>(EEventName.MowingRiskInBattleRootUpdate, new Action<IMowingRiskInBattleRootData>(this.HandleMowingRiskInBattleRootUpdate));
			EventSystem.Instance.Add(EEventName.MowingRiskOnNeedPlayLevelUpSequence, new Action(this.HandleMowingRiskOnNeedPlayLevelUpSequence));
			InputDistributeController.Instance.BindAction("割草BUFF信息", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
			InputDistributeController.Instance.BindAction("割草BUFF信息PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
		}

		// Token: 0x060351C8 RID: 217544 RVA: 0x00ED54F0 File Offset: 0x00ED36F0
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.MowingRiskInBattleRootUpdate, new Action<IMowingRiskInBattleRootData>(this.HandleMowingRiskInBattleRootUpdate));
			EventSystem.Instance.Remove(EEventName.MowingRiskOnNeedPlayLevelUpSequence, new Action(this.HandleMowingRiskOnNeedPlayLevelUpSequence));
			InputDistributeController.Instance.UnBindAction("割草BUFF信息", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
			InputDistributeController.Instance.UnBindAction("割草BUFF信息PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
		}

		// Token: 0x060351C9 RID: 217545 RVA: 0x00ED556B File Offset: 0x00ED376B
		public void CustomSetActive(bool active)
		{
			base.SetVisible(1, active);
		}

		// Token: 0x060351CA RID: 217546 RVA: 0x00ED5575 File Offset: 0x00ED3775
		[NullableContext(1)]
		public void RefreshByCustomData(IMowingRiskInBattleRootData data)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(data.LevelText, true);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(data.ProgressPercentage);
		}

		// Token: 0x060351CB RID: 217547 RVA: 0x00ED55A7 File Offset: 0x00ED37A7
		[NullableContext(1)]
		private void HandleMowingRiskInBattleRootUpdate(IMowingRiskInBattleRootData data)
		{
			this.RefreshByCustomData(data);
		}

		// Token: 0x060351CC RID: 217548 RVA: 0x00ED55B0 File Offset: 0x00ED37B0
		private void HandleMowingRiskOnNeedPlayLevelUpSequence()
		{
			UiSequencePlayer player = this.Player;
			if (player == null)
			{
				return;
			}
			player.LitePlayAsync("Start", false, false);
		}

		// Token: 0x0401C091 RID: 114833
		[Nullable(2)]
		private UiSequencePlayer Player;

		// Token: 0x0200AFE0 RID: 45024
		private static class EComponent
		{
			// Token: 0x040365BE RID: 222654
			public const int Button = 0;

			// Token: 0x040365BF RID: 222655
			public const int LevelText = 1;

			// Token: 0x040365C0 RID: 222656
			public const int ProgressSprite = 2;
		}

		// Token: 0x0200AFE1 RID: 45025
		private static class EVisibleReason
		{
			// Token: 0x040365C1 RID: 222657
			public const int Default = 1;
		}
	}
}
