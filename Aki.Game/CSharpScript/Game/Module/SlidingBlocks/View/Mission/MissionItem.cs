using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Mission
{
	// Token: 0x02003B43 RID: 15171
	public class MissionItem : UiPanelBase
	{
		// Token: 0x06026FF0 RID: 159728 RVA: 0x00AEAD40 File Offset: 0x00AE8F40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnTrackBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026FF1 RID: 159729 RVA: 0x00AEAF34 File Offset: 0x00AE9134
		protected override UniTask OnBeforeStartAsync()
		{
			MissionItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MissionItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026FF2 RID: 159730 RVA: 0x00AEAF77 File Offset: 0x00AE9177
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			if (!Info.Instance.IsInTouch())
			{
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			}
		}

		// Token: 0x06026FF3 RID: 159731 RVA: 0x00AEAFA8 File Offset: 0x00AE91A8
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			if (EventSystem.Instance.Has<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange)))
			{
				EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			}
		}

		// Token: 0x06026FF4 RID: 159732 RVA: 0x00AEAFF4 File Offset: 0x00AE91F4
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.SetShortcutKey();
		}

		// Token: 0x06026FF5 RID: 159733 RVA: 0x00AEAFFC File Offset: 0x00AE91FC
		protected override void OnBeforeDestroy()
		{
			InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06026FF6 RID: 159734 RVA: 0x00AEB019 File Offset: 0x00AE9219
		public void OnTick(float delta)
		{
			ParentStepItem missionStep = this.MissionStep;
			if (missionStep == null)
			{
				return;
			}
			missionStep.OnTick(delta);
		}

		// Token: 0x06026FF7 RID: 159735 RVA: 0x00AEB02C File Offset: 0x00AE922C
		private void SetMainTitleText()
		{
			SlidingBlocksGameServerData serverData = SlidingBlocksModel.Instance.GameData.ServerData;
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(serverData.MainTitleTextKey ?? "");
		}

		// Token: 0x06026FF8 RID: 159736 RVA: 0x00AEB06C File Offset: 0x00AE926C
		private UniTask SetProgressText()
		{
			MissionItem.<SetProgressText>d__11 <SetProgressText>d__;
			<SetProgressText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetProgressText>d__.<>4__this = this;
			<SetProgressText>d__.<>1__state = -1;
			<SetProgressText>d__.<>t__builder.Start<MissionItem.<SetProgressText>d__11>(ref <SetProgressText>d__);
			return <SetProgressText>d__.<>t__builder.Task;
		}

		// Token: 0x06026FF9 RID: 159737 RVA: 0x00AEB0B0 File Offset: 0x00AE92B0
		private void SetShortcutKey()
		{
			UUIItem item = base.GetItem(11);
			UUIText text = base.GetText(2);
			UUISprite sprite = base.GetSprite(10);
			if (SlidingBlocksModel.Instance.GameData.PlayMode != ETetrisPlayMode.MainLine)
			{
				text.SetUIActive(false);
				item.SetUIActive(false);
				sprite.SetUIActive(false);
				return;
			}
			string textById = TextConfig.Instance.GetTextById("ChallengeAgain");
			if (Info.Instance.IsInKeyBoard())
			{
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("玩法放弃");
				if (actionBinding == null)
				{
					item.SetUIActive(false);
					return;
				}
				InputKey pcKey = actionBinding.GetPcKey();
				if (pcKey == null)
				{
					item.SetUIActive(false);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SlidingBlocks;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "pcKey为空";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionMapping", "玩法放弃");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				string newText = "<texture=" + pcKey.GetKeyIconPath() + "/>" + textById;
				text.SetText(newText, true);
			}
			else if (Info.Instance.IsInGamepad())
			{
				string newText2 = this.GetGamepadShortcutString("玩法放弃", textById) ?? textById;
				text.SetText(newText2, true);
			}
			else
			{
				string newText3 = TextConfig.Instance.GetTextById("ChallengeAgain_mobile") ?? textById;
				text.SetText(newText3, true);
			}
			text.SetAlpha(1f);
			text.SetUIActive(true);
			item.SetUIActive(true);
			sprite.SetUIActive(Info.Instance.InputControllerMainType == EInputControllerMainType.Touch);
			InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06026FFA RID: 159738 RVA: 0x00AEB250 File Offset: 0x00AE9450
		[NullableContext(1)]
		[return: Nullable(2)]
		private string GetGamepadShortcutString(string actionName, string sourceString)
		{
			InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName == null)
			{
				return null;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			combinationActionBindingByActionName.GetCurrentPlatformKeyNameMap(dictionary);
			if (dictionary.Count == 0)
			{
				return null;
			}
			string value = actionName;
			string value2 = actionName;
			using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					string text;
					string text2;
					keyValuePair.Deconstruct(out text, out text2);
					string key = text;
					string key2 = text2;
					InputKey key3 = InputSettings.Instance.GetKey(key);
					InputKey key4 = InputSettings.Instance.GetKey(key2);
					if (key3 != null)
					{
						value = key3.GetKeyIconPath();
					}
					if (key4 != null)
					{
						value2 = key4.GetKeyIconPath();
					}
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<texture=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("/>+<texture=");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("/>");
			defaultInterpolatedStringHandler.AppendFormatted(sourceString);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06026FFB RID: 159739 RVA: 0x00AEB35C File Offset: 0x00AE955C
		private void OnTrackBtnClick()
		{
			if (this.IsRequesting)
			{
				return;
			}
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (instanceDungeonInfo == null)
			{
				return;
			}
			BaseBehaviorTree tree = instanceDungeonInfo.Tree;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PlayEnd);
			confirmBoxDataNew.SetCloseFunction(delegate
			{
				if (tree.ContainTag(EBehaviorTreeTag.RollbackWaiting))
				{
					EventSystem.Instance.EmitWithTarget(tree.GetBlackBoard(), EEventName.GeneralLogicTreeRollbackWaitingUpdate);
				}
			});
			confirmBoxDataNew.FunctionMap[1] = null;
			Action<bool> <>9__2;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (tree.ContainTag(EBehaviorTreeTag.RollbackWaiting))
				{
					return;
				}
				this.IsRequesting = true;
				GeneralLogicTreeController instance = GeneralLogicTreeController.Instance;
				long treeIncId = tree.TreeIncId;
				Action<bool> callback;
				if ((callback = <>9__2) == null)
				{
					callback = (<>9__2 = delegate(bool _)
					{
						this.IsRequesting = false;
					});
				}
				instance.RequestGiveUp(treeIncId, callback);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06026FFC RID: 159740 RVA: 0x00AEB3E5 File Offset: 0x00AE95E5
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnTrackBtnClick();
		}

		// Token: 0x040154BE RID: 87230
		[Nullable(2)]
		private ParentStepItem MissionStep;

		// Token: 0x040154BF RID: 87231
		private bool IsRequesting;

		// Token: 0x020097D7 RID: 38871
		private enum EViewComponent
		{
			// Token: 0x0402F5DC RID: 194012
			Icon,
			// Token: 0x0402F5DD RID: 194013
			ParentItem,
			// Token: 0x0402F5DE RID: 194014
			ShortcutKeyText,
			// Token: 0x0402F5DF RID: 194015
			BtnTrack,
			// Token: 0x0402F5E0 RID: 194016
			CompleteItem,
			// Token: 0x0402F5E1 RID: 194017
			ProcessItem,
			// Token: 0x0402F5E2 RID: 194018
			CompleteText,
			// Token: 0x0402F5E3 RID: 194019
			Niagara,
			// Token: 0x0402F5E4 RID: 194020
			TitleText,
			// Token: 0x0402F5E5 RID: 194021
			TitleItem,
			// Token: 0x0402F5E6 RID: 194022
			ShortcutSprite,
			// Token: 0x0402F5E7 RID: 194023
			ShortcutNode
		}
	}
}
