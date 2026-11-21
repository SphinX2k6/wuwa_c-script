using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB3 RID: 19635
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleEntityChildView : BattleChildView
	{
		// Token: 0x0603114E RID: 201038 RVA: 0x00DB48A4 File Offset: 0x00DB2AA4
		public override void Reset()
		{
			this.Deactivate(this.Entity);
			base.Reset();
		}

		// Token: 0x0603114F RID: 201039 RVA: 0x00DB48B8 File Offset: 0x00DB2AB8
		public void Reactivate(Entity entity)
		{
			if (!ObjectSystem.Instance.IsValid(entity))
			{
				return;
			}
			if (this.IsValid())
			{
				int? entityId = this.GetEntityId();
				int id = entity.Id;
				if (!(entityId.GetValueOrDefault() == id & entityId != null))
				{
					this.Deactivate(this.GetEntity());
					this.Activate(entity);
					return;
				}
			}
			else
			{
				this.Activate(entity);
			}
		}

		// Token: 0x06031150 RID: 201040 RVA: 0x00DB4918 File Offset: 0x00DB2B18
		public void Activate(Entity entity)
		{
			if (!ObjectSystem.Instance.IsValid(entity))
			{
				return;
			}
			this.Entity = entity;
			this.OnActivate();
			this.AddEntityEvents(entity);
		}

		// Token: 0x06031151 RID: 201041 RVA: 0x00DB493C File Offset: 0x00DB2B3C
		[NullableContext(2)]
		public void Deactivate(Entity entity)
		{
			if (!ObjectSystem.Instance.IsValid(entity))
			{
				return;
			}
			if (!ObjectSystem.Instance.IsValid(this.Entity))
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "在休眠时，当前实体不存在，请先调用Activate", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int? entityId = this.GetEntityId();
			int id = entity.Id;
			if (!(entityId.GetValueOrDefault() == id & entityId != null))
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "在休眠时，休眠实体不是当前实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.RemoveEntityEvents(entity);
			this.OnDeactivate();
			this.Entity = null;
		}

		// Token: 0x06031152 RID: 201042 RVA: 0x00DB49D9 File Offset: 0x00DB2BD9
		protected virtual void OnActivate()
		{
		}

		// Token: 0x06031153 RID: 201043 RVA: 0x00DB49DB File Offset: 0x00DB2BDB
		protected virtual void OnDeactivate()
		{
		}

		// Token: 0x06031154 RID: 201044 RVA: 0x00DB49DD File Offset: 0x00DB2BDD
		protected virtual void AddEntityEvents(Entity entity)
		{
		}

		// Token: 0x06031155 RID: 201045 RVA: 0x00DB49DF File Offset: 0x00DB2BDF
		protected virtual void RemoveEntityEvents(Entity entity)
		{
			this.ClearAllAttributeChangedCallback(entity);
			this.ClearAllTagCountChangedCallback();
			this.ClearAllTagSignificantChangedCallback();
			this.ClearAllGameplayEffectAppliedCallback();
		}

		// Token: 0x06031156 RID: 201046 RVA: 0x00DB49FA File Offset: 0x00DB2BFA
		[NullableContext(2)]
		public Entity GetEntity()
		{
			return this.Entity;
		}

		// Token: 0x06031157 RID: 201047 RVA: 0x00DB4A04 File Offset: 0x00DB2C04
		public int? GetEntityId()
		{
			Entity entity = this.Entity;
			if (entity == null)
			{
				return null;
			}
			return new int?(entity.Id);
		}

		// Token: 0x06031158 RID: 201048 RVA: 0x00DB4A2F File Offset: 0x00DB2C2F
		public virtual bool IsValid()
		{
			return ObjectSystem.Instance.IsValid(this.Entity);
		}

		// Token: 0x06031159 RID: 201049 RVA: 0x00DB4A44 File Offset: 0x00DB2C44
		protected void ListenForAttributeChanged(Entity entity, EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			if (component == null)
			{
				return;
			}
			component.AddListener(attributeId, onAttributeChanged, null);
			this.AttributeChangedCallbackMap[attributeId] = onAttributeChanged;
		}

		// Token: 0x0603115A RID: 201050 RVA: 0x00DB4A74 File Offset: 0x00DB2C74
		protected void RemoveListenAttributeChanged(Entity entity, EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			if (component == null)
			{
				return;
			}
			component.RemoveListener(attributeId, onAttributeChanged);
			this.AttributeChangedCallbackMap.Remove(attributeId);
		}

		// Token: 0x0603115B RID: 201051 RVA: 0x00DB4AA4 File Offset: 0x00DB2CA4
		private void ClearAllAttributeChangedCallback(Entity entity)
		{
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			if (component == null)
			{
				return;
			}
			foreach (KeyValuePair<EAttributeType, Action<EAttributeType, float, float>> keyValuePair in this.AttributeChangedCallbackMap)
			{
				EAttributeType eattributeType;
				Action<EAttributeType, float, float> action;
				keyValuePair.Deconstruct(out eattributeType, out action);
				EAttributeType attrId = eattributeType;
				Action<EAttributeType, float, float> callback = action;
				component.RemoveListener(attrId, callback);
			}
		}

		// Token: 0x0603115C RID: 201052 RVA: 0x00DB4B18 File Offset: 0x00DB2D18
		protected void ListenForTagCountChanged(Entity entity, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> effectGameplayTag, BaseTagComponent.TTagChangedCallback onGameplayEffectStackChange)
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return;
			}
			int tagId = 0;
			if (effectGameplayTag.IsT1)
			{
				tagId = effectGameplayTag.AsT1;
			}
			else if (effectGameplayTag.IsT2)
			{
				tagId = GameplayTagUtils.GetTagIdByName(effectGameplayTag.AsT2);
			}
			ITagTask item = component.ListenForTagAnyCountChanged(tagId, onGameplayEffectStackChange);
			this.TagCountChangeTaskList.Add(item);
		}

		// Token: 0x0603115D RID: 201053 RVA: 0x00DB4B70 File Offset: 0x00DB2D70
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagCountChangeTaskList)
			{
				tagTask.EndTask();
			}
			this.TagCountChangeTaskList.Clear();
		}

		// Token: 0x0603115E RID: 201054 RVA: 0x00DB4BCC File Offset: 0x00DB2DCC
		protected void ListenForTagSignificantChanged(Entity entity, int gameplayTagId, BaseTagComponent.TTagSwitchedCallback callback)
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return;
			}
			ITagTask item = component.ListenForTagAddOrRemove(new int?(gameplayTagId), callback, null);
			this.TagSignificantChangedTaskList.Add(item);
		}

		// Token: 0x0603115F RID: 201055 RVA: 0x00DB4C00 File Offset: 0x00DB2E00
		protected void ListenForTagAddNewOrRemovedWithTag(BaseTagComponent tagComponent, int gameplayTagId, BaseTagComponent.TTagSwitchedCallback callback, [Nullable(2)] Stat callbackStat = null)
		{
			ITagTask item = tagComponent.ListenForTagAddOrRemove(new int?(gameplayTagId), callback, callbackStat);
			this.TagSignificantChangedTaskList.Add(item);
		}

		// Token: 0x06031160 RID: 201056 RVA: 0x00DB4C2C File Offset: 0x00DB2E2C
		private void ClearAllTagSignificantChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
		}

		// Token: 0x06031161 RID: 201057 RVA: 0x00DB4C88 File Offset: 0x00DB2E88
		private void ClearAllGameplayEffectAppliedCallback()
		{
			foreach (UAsyncTaskEffectApplied uasyncTaskEffectApplied in this.GameplayEffectAppliedTaskList)
			{
				uasyncTaskEffectApplied.EndTask();
			}
			this.GameplayEffectAppliedTaskList.Clear();
		}

		// Token: 0x0401A043 RID: 106563
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401A044 RID: 106564
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x0401A045 RID: 106565
		private readonly List<ITagTask> TagCountChangeTaskList = new List<ITagTask>();

		// Token: 0x0401A046 RID: 106566
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x0401A047 RID: 106567
		private readonly List<UAsyncTaskEffectApplied> GameplayEffectAppliedTaskList = new List<UAsyncTaskEffectApplied>();
	}
}
