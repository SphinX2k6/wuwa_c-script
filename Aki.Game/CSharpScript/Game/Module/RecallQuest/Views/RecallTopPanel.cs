using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.RecallQuest.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02004F1D RID: 20253
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallTopPanel : BattleVisibleChildView
	{
		// Token: 0x06033EE5 RID: 212709 RVA: 0x00C2C110 File Offset: 0x00C2A310
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033EE6 RID: 212710 RVA: 0x00C2C19C File Offset: 0x00C2A39C
		[NullableContext(2)]
		protected override UniTask InitializeAsync(object param = null)
		{
			RecallTopPanel.<InitializeAsync>d__7 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<RecallTopPanel.<InitializeAsync>d__7>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033EE7 RID: 212711 RVA: 0x00C2C1E0 File Offset: 0x00C2A3E0
		private UniTask NewFunctionButton(int functionId)
		{
			RecallTopPanel.<NewFunctionButton>d__8 <NewFunctionButton>d__;
			<NewFunctionButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFunctionButton>d__.<>4__this = this;
			<NewFunctionButton>d__.functionId = functionId;
			<NewFunctionButton>d__.<>1__state = -1;
			<NewFunctionButton>d__.<>t__builder.Start<RecallTopPanel.<NewFunctionButton>d__8>(ref <NewFunctionButton>d__);
			return <NewFunctionButton>d__.<>t__builder.Task;
		}

		// Token: 0x06033EE8 RID: 212712 RVA: 0x00C2C22C File Offset: 0x00C2A42C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleEntranceButton> NewBattleEntranceButton(UUIItem uiItem, ERedDotName? redDotName = null, EFunctionType? functionType = null, bool hideInGamepad = false, bool hideByRoleConfig = true, EBattleUiChild childType = EBattleUiChild.TopButton)
		{
			RecallTopPanel.<NewBattleEntranceButton>d__9 <NewBattleEntranceButton>d__;
			<NewBattleEntranceButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleEntranceButton>.Create();
			<NewBattleEntranceButton>d__.<>4__this = this;
			<NewBattleEntranceButton>d__.uiItem = uiItem;
			<NewBattleEntranceButton>d__.redDotName = redDotName;
			<NewBattleEntranceButton>d__.functionType = functionType;
			<NewBattleEntranceButton>d__.hideInGamepad = hideInGamepad;
			<NewBattleEntranceButton>d__.hideByRoleConfig = hideByRoleConfig;
			<NewBattleEntranceButton>d__.childType = childType;
			<NewBattleEntranceButton>d__.<>1__state = -1;
			<NewBattleEntranceButton>d__.<>t__builder.Start<RecallTopPanel.<NewBattleEntranceButton>d__9>(ref <NewBattleEntranceButton>d__);
			return <NewBattleEntranceButton>d__.<>t__builder.Task;
		}

		// Token: 0x06033EE9 RID: 212713 RVA: 0x00C2C2A2 File Offset: 0x00C2A4A2
		protected override void OnShowBattleChildView()
		{
			this.AddEvents();
			this.RefreshButtonState();
		}

		// Token: 0x06033EEA RID: 212714 RVA: 0x00C2C2B0 File Offset: 0x00C2A4B0
		protected override void OnHideBattleChildView()
		{
			this.RemoveEvents();
		}

		// Token: 0x06033EEB RID: 212715 RVA: 0x00C2C2B8 File Offset: 0x00C2A4B8
		private void AddEvents()
		{
			if (!this.EventListenState)
			{
				EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
				this.EventListenState = true;
			}
		}

		// Token: 0x06033EEC RID: 212716 RVA: 0x00C2C2E5 File Offset: 0x00C2A4E5
		private void RemoveEvents()
		{
			if (this.EventListenState)
			{
				EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
				this.EventListenState = false;
			}
		}

		// Token: 0x06033EED RID: 212717 RVA: 0x00C2C314 File Offset: 0x00C2A514
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (state != QuestState.Finish)
			{
				return;
			}
			bool flag = false;
			int count = RecallQuestModel.Instance.GetCurrentRecallFunctionIds().Count;
			List<int> currentShowFunctionIds = this.CurrentShowFunctionIds;
			int? num = (currentShowFunctionIds != null) ? new int?(currentShowFunctionIds.Count) : null;
			if (!(count == num.GetValueOrDefault() & num != null))
			{
				flag = true;
			}
			if (flag)
			{
				this.RefreshButtonState();
			}
		}

		// Token: 0x06033EEE RID: 212718 RVA: 0x00C2C378 File Offset: 0x00C2A578
		private void RefreshButtonState()
		{
			if (this.ButtonList == null)
			{
				return;
			}
			foreach (BattleEntranceButton battleEntranceButton in this.ButtonList)
			{
				battleEntranceButton.SetVisible(0, false);
				battleEntranceButton.HideBattleVisibleChildView();
			}
			List<int> currentRecallFunctionIds = RecallQuestModel.Instance.GetCurrentRecallFunctionIds();
			this.CurrentShowFunctionIds = currentRecallFunctionIds;
			if (currentRecallFunctionIds != null)
			{
				foreach (int id in currentRecallFunctionIds)
				{
					RecallFunction? recallFunctionConfig = RecallQuestConfig.Instance.GetRecallFunctionConfig(id);
					BattleEntranceButton battleEntranceButton2;
					if (this.FunctionMap.TryGetValue(recallFunctionConfig.Value.FunctionId, out battleEntranceButton2))
					{
						battleEntranceButton2.SetVisible(0, true);
						battleEntranceButton2.ShowBattleVisibleChildView(false);
					}
				}
			}
		}

		// Token: 0x0401B983 RID: 113027
		private readonly Dictionary<int, int> FunctionIndexMap = new Dictionary<int, int>();

		// Token: 0x0401B984 RID: 113028
		private readonly Dictionary<int, BattleEntranceButton> FunctionMap = new Dictionary<int, BattleEntranceButton>();

		// Token: 0x0401B985 RID: 113029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BattleEntranceButton> ButtonList;

		// Token: 0x0401B986 RID: 113030
		[Nullable(2)]
		private List<int> CurrentShowFunctionIds;

		// Token: 0x0401B987 RID: 113031
		private bool EventListenState;

		// Token: 0x0200B065 RID: 45157
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403588F RID: 219279
			public const int SettingBtn = 0;

			// Token: 0x04035890 RID: 219280
			public const int PhotoBtn = 1;

			// Token: 0x04035891 RID: 219281
			public const int TimeBtn = 2;
		}
	}
}
