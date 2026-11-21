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
	// Token: 0x02003EE6 RID: 16102
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallTopPanel : BattleVisibleChildView
	{
		// Token: 0x06028D50 RID: 167248 RVA: 0x00B75784 File Offset: 0x00B73984
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

		// Token: 0x06028D51 RID: 167249 RVA: 0x00B75810 File Offset: 0x00B73A10
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

		// Token: 0x06028D52 RID: 167250 RVA: 0x00B75854 File Offset: 0x00B73A54
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

		// Token: 0x06028D53 RID: 167251 RVA: 0x00B758A0 File Offset: 0x00B73AA0
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

		// Token: 0x06028D54 RID: 167252 RVA: 0x00B75916 File Offset: 0x00B73B16
		protected override void OnShowBattleChildView()
		{
			this.AddEvents();
			this.RefreshButtonState();
		}

		// Token: 0x06028D55 RID: 167253 RVA: 0x00B75924 File Offset: 0x00B73B24
		protected override void OnHideBattleChildView()
		{
			this.RemoveEvents();
		}

		// Token: 0x06028D56 RID: 167254 RVA: 0x00B7592C File Offset: 0x00B73B2C
		private void AddEvents()
		{
			if (!this.EventListenState)
			{
				EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
				this.EventListenState = true;
			}
		}

		// Token: 0x06028D57 RID: 167255 RVA: 0x00B75959 File Offset: 0x00B73B59
		private void RemoveEvents()
		{
			if (this.EventListenState)
			{
				EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
				this.EventListenState = false;
			}
		}

		// Token: 0x06028D58 RID: 167256 RVA: 0x00B75988 File Offset: 0x00B73B88
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

		// Token: 0x06028D59 RID: 167257 RVA: 0x00B759EC File Offset: 0x00B73BEC
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

		// Token: 0x04016356 RID: 90966
		private readonly Dictionary<int, int> FunctionIndexMap = new Dictionary<int, int>();

		// Token: 0x04016357 RID: 90967
		private readonly Dictionary<int, BattleEntranceButton> FunctionMap = new Dictionary<int, BattleEntranceButton>();

		// Token: 0x04016358 RID: 90968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BattleEntranceButton> ButtonList;

		// Token: 0x04016359 RID: 90969
		[Nullable(2)]
		private List<int> CurrentShowFunctionIds;

		// Token: 0x0401635A RID: 90970
		private bool EventListenState;

		// Token: 0x02009A95 RID: 39573
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040302BA RID: 197306
			public const int SettingBtn = 0;

			// Token: 0x040302BB RID: 197307
			public const int PhotoBtn = 1;

			// Token: 0x040302BC RID: 197308
			public const int TimeBtn = 2;
		}
	}
}
