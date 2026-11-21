using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020049CF RID: 18895
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadPsFeedbackListenTagModule
	{
		// Token: 0x0602F526 RID: 193830 RVA: 0x00D33C3C File Offset: 0x00D31E3C
		public void Init()
		{
			this.AddEvents();
			if (Info.Instance.IsInGamepad())
			{
				this.InitPsFeedbackTagSettings();
			}
		}

		// Token: 0x0602F527 RID: 193831 RVA: 0x00D33C56 File Offset: 0x00D31E56
		public void Clear()
		{
			this.RemoveEvents();
			this.ClearListenTagData();
		}

		// Token: 0x0602F528 RID: 193832 RVA: 0x00D33C64 File Offset: 0x00D31E64
		private void AddEvents()
		{
			EventSystem.Instance.Add<global::EInputControllerType, global::EInputControllerType>(EEventName.InputControllerChange, new Action<global::EInputControllerType, global::EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Add<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnCommonKeySettingKeyChange));
			InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x0602F529 RID: 193833 RVA: 0x00D33CFC File Offset: 0x00D31EFC
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<global::EInputControllerType, global::EInputControllerType>(EEventName.InputControllerChange, new Action<global::EInputControllerType, global::EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Remove<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Remove<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnCommonKeySettingKeyChange));
			InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x0602F52A RID: 193834 RVA: 0x00D33D94 File Offset: 0x00D31F94
		private void InitPsFeedbackTagSettings()
		{
			if (this.IsInitListenTags)
			{
				return;
			}
			this.IsInitListenTags = true;
			IReadOnlyList<PsFeedback> allPsFeedbackConfig = GamepadConfig.Instance.GetAllPsFeedbackConfig();
			if (allPsFeedbackConfig != null)
			{
				foreach (PsFeedback psFeedback in allPsFeedbackConfig)
				{
					if (this.GamepadPsFeedbackListenTagsMap == null)
					{
						this.GamepadPsFeedbackListenTagsMap = new Dictionary<int, GamepadPsFeedbackListenTagModule.PsFeedbackTagData>();
					}
					if (!string.IsNullOrEmpty(psFeedback.ListenTag))
					{
						int tagIdByName = GameplayTagUtils.GetTagIdByName(psFeedback.ListenTag);
						this.GamepadPsFeedbackListenTagsMap[tagIdByName] = new GamepadPsFeedbackListenTagModule.PsFeedbackTagData(psFeedback.Id, psFeedback.Priority);
					}
				}
			}
		}

		// Token: 0x0602F52B RID: 193835 RVA: 0x00D33E40 File Offset: 0x00D32040
		[NullableContext(2)]
		private void InitEntityListenTags(Entity entity)
		{
			if (entity == null || this.GamepadPsFeedbackListenTagsMap == null)
			{
				return;
			}
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			int count = this.GamepadPsFeedbackListenTagsMap.Count;
			int num = 0;
			foreach (KeyValuePair<int, GamepadPsFeedbackListenTagModule.PsFeedbackTagData> keyValuePair in this.GamepadPsFeedbackListenTagsMap)
			{
				int key = keyValuePair.Key;
				GamepadPsFeedbackListenTagModule.PsFeedbackTagData value = keyValuePair.Value;
				ITagTask tagTask = (component != null) ? component.ListenForTagAddOrRemove(new int?(key), new BaseTagComponent.TTagSwitchedCallback(this.OnPsFeedbackListenTagChanged), null) : null;
				if (tagTask != null)
				{
					if (this.GamepadPsFeedbackListenTasks == null)
					{
						this.GamepadPsFeedbackListenTasks = new List<ITagTask>();
					}
					this.GamepadPsFeedbackListenTasks.Add(tagTask);
				}
				if (component != null && component.HasTag(key))
				{
					this.AddFeedbackTagData(value, false);
				}
				num++;
				if (num == count)
				{
					List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> gamepadPsFeedbackTagDataQueue = this.GamepadPsFeedbackTagDataQueue;
					if (gamepadPsFeedbackTagDataQueue != null)
					{
						gamepadPsFeedbackTagDataQueue.Sort((GamepadPsFeedbackListenTagModule.PsFeedbackTagData a, GamepadPsFeedbackListenTagModule.PsFeedbackTagData b) => b.Priority - a.Priority);
					}
					this.ApplyFeedbackTagData();
				}
			}
		}

		// Token: 0x0602F52C RID: 193836 RVA: 0x00D33F64 File Offset: 0x00D32164
		private bool AddFeedbackTagData(GamepadPsFeedbackListenTagModule.PsFeedbackTagData tagData, bool needSort = true)
		{
			List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> list = this.GamepadPsFeedbackTagDataQueue;
			if (list == null)
			{
				list = new List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData>();
				this.GamepadPsFeedbackTagDataQueue = list;
			}
			if (!list.Contains(tagData))
			{
				GamepadPsFeedbackListenTagModule.PsFeedbackTagData psFeedbackTagData = (list.Count > 0) ? list[0] : null;
				list.Add(tagData);
				if (needSort)
				{
					list.Sort((GamepadPsFeedbackListenTagModule.PsFeedbackTagData a, GamepadPsFeedbackListenTagModule.PsFeedbackTagData b) => b.Priority - a.Priority);
				}
				return psFeedbackTagData == null || psFeedbackTagData.FeedbackId != list[0].FeedbackId;
			}
			return false;
		}

		// Token: 0x0602F52D RID: 193837 RVA: 0x00D33FF4 File Offset: 0x00D321F4
		private bool RemoveFeedbackTagData(GamepadPsFeedbackListenTagModule.PsFeedbackTagData tagData, bool needSort = true)
		{
			List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> gamepadPsFeedbackTagDataQueue = this.GamepadPsFeedbackTagDataQueue;
			if (gamepadPsFeedbackTagDataQueue != null && gamepadPsFeedbackTagDataQueue.Contains(tagData))
			{
				int num = gamepadPsFeedbackTagDataQueue.IndexOf(tagData);
				gamepadPsFeedbackTagDataQueue.RemoveAt(num);
				if (needSort)
				{
					gamepadPsFeedbackTagDataQueue.Sort((GamepadPsFeedbackListenTagModule.PsFeedbackTagData a, GamepadPsFeedbackListenTagModule.PsFeedbackTagData b) => b.Priority - a.Priority);
				}
				return num == 0;
			}
			return false;
		}

		// Token: 0x0602F52E RID: 193838 RVA: 0x00D34054 File Offset: 0x00D32254
		private void ApplyFeedbackTagData()
		{
			List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> gamepadPsFeedbackTagDataQueue = this.GamepadPsFeedbackTagDataQueue;
			if (gamepadPsFeedbackTagDataQueue == null)
			{
				return;
			}
			if (gamepadPsFeedbackTagDataQueue.Count > 0)
			{
				GamepadPsFeedbackListenTagModule.PsFeedbackTagData psFeedbackTagData = gamepadPsFeedbackTagDataQueue[0];
				if (this.CurrentTagDataFeedbackId != psFeedbackTagData.FeedbackId)
				{
					this.CurrentTagDataFeedbackId = psFeedbackTagData.FeedbackId;
					this.TryRefreshFeedback();
					return;
				}
			}
			else
			{
				this.CurrentTagDataFeedbackId = "";
				this.StopFeedback();
			}
		}

		// Token: 0x0602F52F RID: 193839 RVA: 0x00D340B4 File Offset: 0x00D322B4
		private void ClearListenTagData()
		{
			if (this.GamepadPsFeedbackListenTasks != null)
			{
				foreach (ITagTask tagTask in this.GamepadPsFeedbackListenTasks)
				{
					tagTask.EndTask();
				}
				this.GamepadPsFeedbackListenTasks.Clear();
			}
			if (this.GamepadPsFeedbackTagDataQueue != null)
			{
				this.GamepadPsFeedbackTagDataQueue.Clear();
			}
			this.CurrentTagDataFeedbackId = "";
		}

		// Token: 0x0602F530 RID: 193840 RVA: 0x00D34138 File Offset: 0x00D32338
		private void OnPsFeedbackListenTagChanged(int tagId, bool tagExist)
		{
			GamepadPsFeedbackListenTagModule.PsFeedbackTagData tagData;
			if (this.GamepadPsFeedbackListenTagsMap != null && this.GamepadPsFeedbackListenTagsMap.TryGetValue(tagId, out tagData) && (tagExist ? this.AddFeedbackTagData(tagData, true) : this.RemoveFeedbackTagData(tagData, true)))
			{
				this.ApplyFeedbackTagData();
			}
		}

		// Token: 0x0602F531 RID: 193841 RVA: 0x00D3417A File Offset: 0x00D3237A
		private void OnInputControllerChange(global::EInputControllerType last, global::EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.InitPsFeedbackTagSettings();
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				Entity entity;
				if (baseCharacter == null)
				{
					entity = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
					entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
				}
				this.InitEntityListenTags(entity);
				return;
			}
			this.ClearListenTagData();
		}

		// Token: 0x0602F532 RID: 193842 RVA: 0x00D341B8 File Offset: 0x00D323B8
		private void OnChangeRole(EntityHandle newEntity, EntityHandle oldEntity)
		{
			this.ClearListenTagData();
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.StopFeedback();
			this.InitEntityListenTags(newEntity.Entity);
		}

		// Token: 0x0602F533 RID: 193843 RVA: 0x00D341DF File Offset: 0x00D323DF
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> tagList)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.TryRefreshFeedback();
			}
		}

		// Token: 0x0602F534 RID: 193844 RVA: 0x00D341F4 File Offset: 0x00D323F4
		private void OnCommonKeySettingKeyChange(KeySettingRowData keyData, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad && !string.IsNullOrEmpty(this.CurrentFeedbackId))
			{
				PsFeedback? psFeedbackReason = GamepadConfig.Instance.GetPsFeedbackReason(this.CurrentFeedbackId);
				if (keyData.GetActionOrAxisName() == ((psFeedbackReason != null) ? psFeedbackReason.GetValueOrDefault().ActionName : null))
				{
					this.TryRefreshFeedback();
				}
			}
		}

		// Token: 0x0602F535 RID: 193845 RVA: 0x00D34251 File Offset: 0x00D32451
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			this.IsInCombinationKey = (actionType == InputDistributeDefine.EActionType.Press);
			this.TryRefreshFeedback();
		}

		// Token: 0x0602F536 RID: 193846 RVA: 0x00D34263 File Offset: 0x00D32463
		private void TryRefreshFeedback()
		{
			if (!this.CheckFeedbackCondition())
			{
				this.StopFeedback();
				return;
			}
			this.RefreshFeedback();
		}

		// Token: 0x0602F537 RID: 193847 RVA: 0x00D3427A File Offset: 0x00D3247A
		private bool CheckFeedbackCondition()
		{
			return this.CheckInputDistribute() && !this.IsInCombinationKey;
		}

		// Token: 0x0602F538 RID: 193848 RVA: 0x00D34291 File Offset: 0x00D32491
		private bool CheckInputDistribute()
		{
			return InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("FightInputRoot", false);
		}

		// Token: 0x0602F539 RID: 193849 RVA: 0x00D342A4 File Offset: 0x00D324A4
		private void RefreshFeedback()
		{
			string currentTagDataFeedbackId = this.CurrentTagDataFeedbackId;
			if (string.IsNullOrEmpty(currentTagDataFeedbackId))
			{
				this.StopFeedback();
				return;
			}
			if (this.CurrentFeedbackId == currentTagDataFeedbackId)
			{
				return;
			}
			this.CurrentFeedbackId = currentTagDataFeedbackId;
			GamepadController.Instance.TryAddFeedbackReason(EGamepadPsFeedbackReason.ListenTag, currentTagDataFeedbackId);
		}

		// Token: 0x0602F53A RID: 193850 RVA: 0x00D342E9 File Offset: 0x00D324E9
		private void StopFeedback()
		{
			if (string.IsNullOrEmpty(this.CurrentFeedbackId))
			{
				return;
			}
			this.CurrentFeedbackId = "";
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.ListenTag);
		}

		// Token: 0x04019178 RID: 102776
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, GamepadPsFeedbackListenTagModule.PsFeedbackTagData> GamepadPsFeedbackListenTagsMap;

		// Token: 0x04019179 RID: 102777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> GamepadPsFeedbackTagDataQueue;

		// Token: 0x0401917A RID: 102778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITagTask> GamepadPsFeedbackListenTasks;

		// Token: 0x0401917B RID: 102779
		private bool IsInitListenTags;

		// Token: 0x0401917C RID: 102780
		private string CurrentTagDataFeedbackId = "";

		// Token: 0x0401917D RID: 102781
		private string CurrentFeedbackId = "";

		// Token: 0x0401917E RID: 102782
		private bool IsInCombinationKey;

		// Token: 0x0200A654 RID: 42580
		[Nullable(0)]
		private class PsFeedbackTagData
		{
			// Token: 0x170079F6 RID: 31222
			// (get) Token: 0x06046213 RID: 287251 RVA: 0x015157A2 File Offset: 0x015139A2
			// (set) Token: 0x06046214 RID: 287252 RVA: 0x015157AA File Offset: 0x015139AA
			public string FeedbackId { get; set; }

			// Token: 0x170079F7 RID: 31223
			// (get) Token: 0x06046215 RID: 287253 RVA: 0x015157B3 File Offset: 0x015139B3
			// (set) Token: 0x06046216 RID: 287254 RVA: 0x015157BB File Offset: 0x015139BB
			public int Priority { get; set; }

			// Token: 0x06046217 RID: 287255 RVA: 0x015157C4 File Offset: 0x015139C4
			public PsFeedbackTagData(string feedbackId, int priority)
			{
				this.FeedbackId = feedbackId;
				this.Priority = priority;
			}
		}
	}
}
