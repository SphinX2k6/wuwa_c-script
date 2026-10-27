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
	// Token: 0x020063E1 RID: 25569
	public class MowingRiskInBattleView : BattleVisibleChildView
	{
		// Token: 0x060404FF RID: 263423 RVA: 0x00F8E358 File Offset: 0x00F8C558
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

		// Token: 0x06040500 RID: 263424 RVA: 0x00F8E41F File Offset: 0x00F8C61F
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEventListeners();
		}

		// Token: 0x06040501 RID: 263425 RVA: 0x00F8E43D File Offset: 0x00F8C63D
		public override void Reset()
		{
			base.Reset();
			this.RemoveEventListeners();
		}

		// Token: 0x06040502 RID: 263426 RVA: 0x00F8E44B File Offset: 0x00F8C64B
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

		// Token: 0x06040503 RID: 263427 RVA: 0x00F8E481 File Offset: 0x00F8C681
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer player = this.Player;
			if (player != null)
			{
				player.LiteExit();
			}
			this.Player = null;
		}

		// Token: 0x06040504 RID: 263428 RVA: 0x00F8E49B File Offset: 0x00F8C69B
		private void OnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MowingBuffView, EMowingBuffViewUsage.InBattle, null);
		}

		// Token: 0x06040505 RID: 263429 RVA: 0x00F8E4B3 File Offset: 0x00F8C6B3
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

		// Token: 0x06040506 RID: 263430 RVA: 0x00F8E4DC File Offset: 0x00F8C6DC
		private void AddEventListeners()
		{
			EventSystem.Instance.Add<IMowingRiskInBattleRootData>(EEventName.MowingRiskInBattleRootUpdate, new Action<IMowingRiskInBattleRootData>(this.HandleMowingRiskInBattleRootUpdate));
			EventSystem.Instance.Add(EEventName.MowingRiskOnNeedPlayLevelUpSequence, new Action(this.HandleMowingRiskOnNeedPlayLevelUpSequence));
			InputDistributeController.Instance.BindAction("割草BUFF信息", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
			InputDistributeController.Instance.BindAction("割草BUFF信息PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
		}

		// Token: 0x06040507 RID: 263431 RVA: 0x00F8E558 File Offset: 0x00F8C758
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.MowingRiskInBattleRootUpdate, new Action<IMowingRiskInBattleRootData>(this.HandleMowingRiskInBattleRootUpdate));
			EventSystem.Instance.Remove(EEventName.MowingRiskOnNeedPlayLevelUpSequence, new Action(this.HandleMowingRiskOnNeedPlayLevelUpSequence));
			InputDistributeController.Instance.UnBindAction("割草BUFF信息", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
			InputDistributeController.Instance.UnBindAction("割草BUFF信息PC触摸板", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputBuffAction));
		}

		// Token: 0x06040508 RID: 263432 RVA: 0x00F8E5D3 File Offset: 0x00F8C7D3
		public void CustomSetActive(bool active)
		{
			base.SetVisible(1, active);
		}

		// Token: 0x06040509 RID: 263433 RVA: 0x00F8E5DD File Offset: 0x00F8C7DD
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

		// Token: 0x0604050A RID: 263434 RVA: 0x00F8E60F File Offset: 0x00F8C80F
		[NullableContext(1)]
		private void HandleMowingRiskInBattleRootUpdate(IMowingRiskInBattleRootData data)
		{
			this.RefreshByCustomData(data);
		}

		// Token: 0x0604050B RID: 263435 RVA: 0x00F8E618 File Offset: 0x00F8C818
		private void HandleMowingRiskOnNeedPlayLevelUpSequence()
		{
			UiSequencePlayer player = this.Player;
			if (player == null)
			{
				return;
			}
			player.LitePlayAsync("Start", false, false);
		}

		// Token: 0x04021762 RID: 137058
		[Nullable(2)]
		private UiSequencePlayer Player;

		// Token: 0x0200C5F9 RID: 50681
		private static class EComponent
		{
			// Token: 0x0403BC5F RID: 244831
			public const int Button = 0;

			// Token: 0x0403BC60 RID: 244832
			public const int LevelText = 1;

			// Token: 0x0403BC61 RID: 244833
			public const int ProgressSprite = 2;
		}

		// Token: 0x0200C5FA RID: 50682
		private static class EVisibleReason
		{
			// Token: 0x0403BC62 RID: 244834
			public const int Default = 1;
		}
	}
}
