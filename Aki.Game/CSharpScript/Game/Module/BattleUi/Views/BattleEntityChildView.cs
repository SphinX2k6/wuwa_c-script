using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD1 RID: 23761
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleEntityChildView : BattleChildView
	{
		// Token: 0x0603C1F8 RID: 246264 RVA: 0x00E642C8 File Offset: 0x00E624C8
		public override void Reset()
		{
			this.Deactivate(this.Entity);
			base.Reset();
		}

		// Token: 0x0603C1F9 RID: 246265 RVA: 0x00E642DC File Offset: 0x00E624DC
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

		// Token: 0x0603C1FA RID: 246266 RVA: 0x00E6433C File Offset: 0x00E6253C
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

		// Token: 0x0603C1FB RID: 246267 RVA: 0x00E64360 File Offset: 0x00E62560
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

		// Token: 0x0603C1FC RID: 246268 RVA: 0x00E643FD File Offset: 0x00E625FD
		protected virtual void OnActivate()
		{
		}

		// Token: 0x0603C1FD RID: 246269 RVA: 0x00E643FF File Offset: 0x00E625FF
		protected virtual void OnDeactivate()
		{
		}

		// Token: 0x0603C1FE RID: 246270 RVA: 0x00E64401 File Offset: 0x00E62601
		protected virtual void AddEntityEvents(Entity entity)
		{
		}

		// Token: 0x0603C1FF RID: 246271 RVA: 0x00E64403 File Offset: 0x00E62603
		protected virtual void RemoveEntityEvents(Entity entity)
		{
			this.ClearAllAttributeChangedCallback(entity);
			this.ClearAllTagCountChangedCallback();
			this.ClearAllTagSignificantChangedCallback();
			this.ClearAllGameplayEffectAppliedCallback();
		}

		// Token: 0x0603C200 RID: 246272 RVA: 0x00E6441E File Offset: 0x00E6261E
		[NullableContext(2)]
		public Entity GetEntity()
		{
			return this.Entity;
		}

		// Token: 0x0603C201 RID: 246273 RVA: 0x00E64428 File Offset: 0x00E62628
		public int? GetEntityId()
		{
			Entity entity = this.Entity;
			if (entity == null)
			{
				return null;
			}
			return new int?(entity.Id);
		}

		// Token: 0x0603C202 RID: 246274 RVA: 0x00E64453 File Offset: 0x00E62653
		public virtual bool IsValid()
		{
			return ObjectSystem.Instance.IsValid(this.Entity);
		}

		// Token: 0x0603C203 RID: 246275 RVA: 0x00E64468 File Offset: 0x00E62668
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

		// Token: 0x0603C204 RID: 246276 RVA: 0x00E64498 File Offset: 0x00E62698
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

		// Token: 0x0603C205 RID: 246277 RVA: 0x00E644C8 File Offset: 0x00E626C8
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

		// Token: 0x0603C206 RID: 246278 RVA: 0x00E6453C File Offset: 0x00E6273C
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

		// Token: 0x0603C207 RID: 246279 RVA: 0x00E64594 File Offset: 0x00E62794
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagCountChangeTaskList)
			{
				tagTask.EndTask();
			}
			this.TagCountChangeTaskList.Clear();
		}

		// Token: 0x0603C208 RID: 246280 RVA: 0x00E645F0 File Offset: 0x00E627F0
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

		// Token: 0x0603C209 RID: 246281 RVA: 0x00E64624 File Offset: 0x00E62824
		protected void ListenForTagAddNewOrRemovedWithTag(BaseTagComponent tagComponent, int gameplayTagId, BaseTagComponent.TTagSwitchedCallback callback, [Nullable(2)] Stat callbackStat = null)
		{
			ITagTask item = tagComponent.ListenForTagAddOrRemove(new int?(gameplayTagId), callback, callbackStat);
			this.TagSignificantChangedTaskList.Add(item);
		}

		// Token: 0x0603C20A RID: 246282 RVA: 0x00E64650 File Offset: 0x00E62850
		private void ClearAllTagSignificantChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
		}

		// Token: 0x0603C20B RID: 246283 RVA: 0x00E646AC File Offset: 0x00E628AC
		private void ClearAllGameplayEffectAppliedCallback()
		{
			foreach (UAsyncTaskEffectApplied uasyncTaskEffectApplied in this.GameplayEffectAppliedTaskList)
			{
				uasyncTaskEffectApplied.EndTask();
			}
			this.GameplayEffectAppliedTaskList.Clear();
		}

		// Token: 0x0401F58A RID: 128394
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401F58B RID: 128395
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x0401F58C RID: 128396
		private readonly List<ITagTask> TagCountChangeTaskList = new List<ITagTask>();

		// Token: 0x0401F58D RID: 128397
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x0401F58E RID: 128398
		private readonly List<UAsyncTaskEffectApplied> GameplayEffectAppliedTaskList = new List<UAsyncTaskEffectApplied>();
	}
}
