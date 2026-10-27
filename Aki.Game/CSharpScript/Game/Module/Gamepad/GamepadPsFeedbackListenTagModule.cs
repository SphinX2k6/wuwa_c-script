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
	// Token: 0x020059F3 RID: 23027
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadPsFeedbackListenTagModule
	{
		// Token: 0x0603A5DD RID: 239069 RVA: 0x00DE36EA File Offset: 0x00DE18EA
		public void Init()
		{
			this.AddEvents();
			if (Info.Instance.IsInGamepad())
			{
				this.InitPsFeedbackTagSettings();
			}
		}

		// Token: 0x0603A5DE RID: 239070 RVA: 0x00DE3704 File Offset: 0x00DE1904
		public void Clear()
		{
			this.RemoveEvents();
			this.ClearListenTagData();
		}

		// Token: 0x0603A5DF RID: 239071 RVA: 0x00DE3714 File Offset: 0x00DE1914
		private void AddEvents()
		{
			EventSystem.Instance.Add<global::EInputControllerType, global::EInputControllerType>(EEventName.InputControllerChange, new Action<global::EInputControllerType, global::EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Add<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnCommonKeySettingKeyChange));
			InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x0603A5E0 RID: 239072 RVA: 0x00DE37AC File Offset: 0x00DE19AC
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<global::EInputControllerType, global::EInputControllerType>(EEventName.InputControllerChange, new Action<global::EInputControllerType, global::EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Remove<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			EventSystem.Instance.Remove<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(EEventName.OnCommonKeySettingKeyChange, new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnCommonKeySettingKeyChange));
			InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x0603A5E1 RID: 239073 RVA: 0x00DE3844 File Offset: 0x00DE1A44
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

		// Token: 0x0603A5E2 RID: 239074 RVA: 0x00DE38F0 File Offset: 0x00DE1AF0
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

		// Token: 0x0603A5E3 RID: 239075 RVA: 0x00DE3A14 File Offset: 0x00DE1C14
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

		// Token: 0x0603A5E4 RID: 239076 RVA: 0x00DE3AA4 File Offset: 0x00DE1CA4
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

		// Token: 0x0603A5E5 RID: 239077 RVA: 0x00DE3B04 File Offset: 0x00DE1D04
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

		// Token: 0x0603A5E6 RID: 239078 RVA: 0x00DE3B64 File Offset: 0x00DE1D64
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

		// Token: 0x0603A5E7 RID: 239079 RVA: 0x00DE3BE8 File Offset: 0x00DE1DE8
		private void OnPsFeedbackListenTagChanged(int tagId, bool tagExist)
		{
			GamepadPsFeedbackListenTagModule.PsFeedbackTagData tagData;
			if (this.GamepadPsFeedbackListenTagsMap != null && this.GamepadPsFeedbackListenTagsMap.TryGetValue(tagId, out tagData) && (tagExist ? this.AddFeedbackTagData(tagData, true) : this.RemoveFeedbackTagData(tagData, true)))
			{
				this.ApplyFeedbackTagData();
			}
		}

		// Token: 0x0603A5E8 RID: 239080 RVA: 0x00DE3C2A File Offset: 0x00DE1E2A
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

		// Token: 0x0603A5E9 RID: 239081 RVA: 0x00DE3C68 File Offset: 0x00DE1E68
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

		// Token: 0x0603A5EA RID: 239082 RVA: 0x00DE3C8F File Offset: 0x00DE1E8F
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> tagList)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.TryRefreshFeedback();
			}
		}

		// Token: 0x0603A5EB RID: 239083 RVA: 0x00DE3CA4 File Offset: 0x00DE1EA4
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

		// Token: 0x0603A5EC RID: 239084 RVA: 0x00DE3D01 File Offset: 0x00DE1F01
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			this.IsInCombinationKey = (actionType == InputDistributeDefine.EActionType.Press);
			this.TryRefreshFeedback();
		}

		// Token: 0x0603A5ED RID: 239085 RVA: 0x00DE3D13 File Offset: 0x00DE1F13
		private void TryRefreshFeedback()
		{
			if (!this.CheckFeedbackCondition())
			{
				this.StopFeedback();
				return;
			}
			this.RefreshFeedback();
		}

		// Token: 0x0603A5EE RID: 239086 RVA: 0x00DE3D2A File Offset: 0x00DE1F2A
		private bool CheckFeedbackCondition()
		{
			return this.CheckInputDistribute() && !this.IsInCombinationKey;
		}

		// Token: 0x0603A5EF RID: 239087 RVA: 0x00DE3D41 File Offset: 0x00DE1F41
		private bool CheckInputDistribute()
		{
			return InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("FightInputRoot", false);
		}

		// Token: 0x0603A5F0 RID: 239088 RVA: 0x00DE3D54 File Offset: 0x00DE1F54
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

		// Token: 0x0603A5F1 RID: 239089 RVA: 0x00DE3D99 File Offset: 0x00DE1F99
		private void StopFeedback()
		{
			if (string.IsNullOrEmpty(this.CurrentFeedbackId))
			{
				return;
			}
			this.CurrentFeedbackId = "";
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.ListenTag);
		}

		// Token: 0x0401E6D1 RID: 124625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, GamepadPsFeedbackListenTagModule.PsFeedbackTagData> GamepadPsFeedbackListenTagsMap;

		// Token: 0x0401E6D2 RID: 124626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<GamepadPsFeedbackListenTagModule.PsFeedbackTagData> GamepadPsFeedbackTagDataQueue;

		// Token: 0x0401E6D3 RID: 124627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITagTask> GamepadPsFeedbackListenTasks;

		// Token: 0x0401E6D4 RID: 124628
		private bool IsInitListenTags;

		// Token: 0x0401E6D5 RID: 124629
		private string CurrentTagDataFeedbackId = "";

		// Token: 0x0401E6D6 RID: 124630
		private string CurrentFeedbackId = "";

		// Token: 0x0401E6D7 RID: 124631
		private bool IsInCombinationKey;

		// Token: 0x0200BC4A RID: 48202
		[Nullable(0)]
		private class PsFeedbackTagData
		{
			// Token: 0x1700A259 RID: 41561
			// (get) Token: 0x0604FCC0 RID: 326848 RVA: 0x0155C356 File Offset: 0x0155A556
			// (set) Token: 0x0604FCC1 RID: 326849 RVA: 0x0155C35E File Offset: 0x0155A55E
			public string FeedbackId { get; set; }

			// Token: 0x1700A25A RID: 41562
			// (get) Token: 0x0604FCC2 RID: 326850 RVA: 0x0155C367 File Offset: 0x0155A567
			// (set) Token: 0x0604FCC3 RID: 326851 RVA: 0x0155C36F File Offset: 0x0155A56F
			public int Priority { get; set; }

			// Token: 0x0604FCC4 RID: 326852 RVA: 0x0155C378 File Offset: 0x0155A578
			public PsFeedbackTagData(string feedbackId, int priority)
			{
				this.FeedbackId = feedbackId;
				this.Priority = priority;
			}
		}
	}
}
