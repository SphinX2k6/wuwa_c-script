using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020049CE RID: 18894
	public class GamepadLightBarListenTagModule
	{
		// Token: 0x0602F51B RID: 193819 RVA: 0x00D337B6 File Offset: 0x00D319B6
		public void Init()
		{
			this.AddEvents();
			if (Info.Instance.IsInGamepad())
			{
				this.InitListenTagSettings();
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
			}
		}

		// Token: 0x0602F51C RID: 193820 RVA: 0x00D337F3 File Offset: 0x00D319F3
		public void Clear()
		{
			this.RemoveEvents();
			this.ClearListenTagData();
		}

		// Token: 0x0602F51D RID: 193821 RVA: 0x00D33801 File Offset: 0x00D31A01
		private void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}

		// Token: 0x0602F51E RID: 193822 RVA: 0x00D3383B File Offset: 0x00D31A3B
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}

		// Token: 0x0602F51F RID: 193823 RVA: 0x00D33878 File Offset: 0x00D31A78
		private unsafe void InitListenTagSettings()
		{
			if (this.isInitListenTags)
			{
				return;
			}
			this.isInitListenTags = true;
			IReadOnlyList<DualSenseLightBar> configList = ConfigDualSenseLightBarAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.PsGamepadFeedback, ELogAuthor.CWC, "DualSenseLightBar 全表查询失败, ListenTag 灯带功能不生效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (DualSenseLightBar dualSenseLightBar in configList)
			{
				if (!string.IsNullOrEmpty(dualSenseLightBar.ListenTag) && !string.IsNullOrEmpty(dualSenseLightBar.Id))
				{
					int tagIdByName = GameplayTagUtils.GetTagIdByName(dualSenseLightBar.ListenTag);
					if (this.lightBarListenTagsMap == null)
					{
						this.lightBarListenTagsMap = new Dictionary<int, string>();
					}
					string text;
					if (this.lightBarListenTagsMap.TryGetValue(tagIdByName, out text) && text != dualSenseLightBar.Id)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.PsGamepadFeedback;
						ELogAuthor author = ELogAuthor.CWC;
						string message = "DualSenseLightBar 多行配了同一 ListenTag, 后行覆盖前行";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ListenTag", dualSenseLightBar.ListenTag);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Old", text);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("New", dualSenseLightBar.Id);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					this.lightBarListenTagsMap[tagIdByName] = dualSenseLightBar.Id;
				}
			}
		}

		// Token: 0x0602F520 RID: 193824 RVA: 0x00D339FC File Offset: 0x00D31BFC
		[NullableContext(2)]
		private void InitEntityListenTags(Entity entity)
		{
			if (entity == null || this.lightBarListenTagsMap == null)
			{
				return;
			}
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, string> keyValuePair in this.lightBarListenTagsMap)
			{
				ITagTask tagTask = (component != null) ? component.ListenForTagAddOrRemove(new int?(keyValuePair.Key), new BaseTagComponent.TTagSwitchedCallback(this.OnListenTagChanged), null) : null;
				if (tagTask != null)
				{
					if (this.listenTasks == null)
					{
						this.listenTasks = new List<ITagTask>();
					}
					this.listenTasks.Add(tagTask);
				}
				if (component != null && component.HasTag(keyValuePair.Key))
				{
					GamepadController.Instance.SetLightBar(keyValuePair.Value);
				}
			}
		}

		// Token: 0x0602F521 RID: 193825 RVA: 0x00D33AC8 File Offset: 0x00D31CC8
		private void OnListenTagChanged(int tagId, bool tagExist)
		{
			string text;
			if (this.lightBarListenTagsMap == null || !this.lightBarListenTagsMap.TryGetValue(tagId, out text))
			{
				return;
			}
			if (tagExist)
			{
				GamepadController.Instance.SetLightBar(text);
				return;
			}
			GamepadController.Instance.RemoveLightBar(text);
		}

		// Token: 0x0602F522 RID: 193826 RVA: 0x00D33B0C File Offset: 0x00D31D0C
		private void ClearListenTagData()
		{
			if (this.listenTasks != null)
			{
				foreach (ITagTask tagTask in this.listenTasks)
				{
					tagTask.EndTask();
				}
				this.listenTasks.Clear();
			}
			if (this.lightBarListenTagsMap != null)
			{
				foreach (string id in this.lightBarListenTagsMap.Values)
				{
					GamepadController.Instance.RemoveLightBar(id);
				}
			}
		}

		// Token: 0x0602F523 RID: 193827 RVA: 0x00D33BC4 File Offset: 0x00D31DC4
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.InitListenTagSettings();
				this.ClearListenTagData();
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

		// Token: 0x0602F524 RID: 193828 RVA: 0x00D33C13 File Offset: 0x00D31E13
		[NullableContext(1)]
		private void OnChangeRole(EntityHandle newEntity, EntityHandle oldEntity)
		{
			this.ClearListenTagData();
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.InitEntityListenTags(newEntity.Entity);
		}

		// Token: 0x04019175 RID: 102773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, string> lightBarListenTagsMap;

		// Token: 0x04019176 RID: 102774
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITagTask> listenTasks;

		// Token: 0x04019177 RID: 102775
		private bool isInitListenTags;
	}
}
