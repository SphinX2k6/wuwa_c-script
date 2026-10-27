using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D34 RID: 23860
	[NullableContext(1)]
	[Nullable(0)]
	public class HeadIconEnergyBarBase : UiPanelBase
	{
		// Token: 0x0603C82E RID: 247854 RVA: 0x00E848C4 File Offset: 0x00E82AC4
		public void SetVisible(bool bVisible, int type = 0)
		{
			bool visible = this.GetVisible();
			this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, bVisible, type);
			bool visible2 = this.GetVisible();
			if (visible == visible2 && base.GetActive() == visible2)
			{
				return;
			}
			this.SetActive(bVisible);
		}

		// Token: 0x0603C82F RID: 247855 RVA: 0x00E84905 File Offset: 0x00E82B05
		public bool GetVisible()
		{
			return VisibleStateUtil.GetVisible(this.VisibleState);
		}

		// Token: 0x0603C830 RID: 247856 RVA: 0x00E84914 File Offset: 0x00E82B14
		public void InitData(BattleUiRoleData roleData, HeadIconEnergyBar config)
		{
			this.RoleData = roleData;
			this.Config = new HeadIconEnergyBar?(config);
			this.PlayIncreaseEffect = config.PlayIncreaseEffect;
			this.AttributeComponent = this.RoleData.AttributeComponent;
			this.TagComponent = this.RoleData.GameplayTagComponent;
			this.AttributeId = (EAttributeType)config.AttributeId;
			this.MaxAttributeId = CharacterAttributeTypes.attributeIdsWithMax.GetValueOrDefault(this.AttributeId, EAttributeType.None);
		}

		// Token: 0x0603C831 RID: 247857 RVA: 0x00E84987 File Offset: 0x00E82B87
		public void InitByPath(UUIItem parentItem, string prefabPath)
		{
			base.CreateByPathAsync(prefabPath, parentItem, false);
		}

		// Token: 0x0603C832 RID: 247858 RVA: 0x00E84993 File Offset: 0x00E82B93
		public void ChangeParent(UUIItem parentItem)
		{
			if (this.ParentUiItem == parentItem)
			{
				return;
			}
			this.ParentUiItem = parentItem;
			this.GetOriginalItem().SetUIParent(parentItem, true);
		}

		// Token: 0x0603C833 RID: 247859 RVA: 0x00E849B3 File Offset: 0x00E82BB3
		public virtual void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (this.PercentMachine.Update(delta))
			{
				this.OnBarPercentChanged();
			}
		}

		// Token: 0x0603C834 RID: 247860 RVA: 0x00E849D2 File Offset: 0x00E82BD2
		protected override void OnStart()
		{
			base.OnStart();
			this.PercentMachine.Init(this.GetTargetAttributePercent(), 0f, 400f, new Action<float, float>(this.TargetPercentChanged));
		}

		// Token: 0x0603C835 RID: 247861 RVA: 0x00E84A01 File Offset: 0x00E82C01
		protected override void OnBeforeShow()
		{
			this.AddEvents();
			if (this.GetTargetAttributePercent() != this.PercentMachine.GetTargetPercent())
			{
				this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
				this.OnBarPercentChanged();
			}
		}

		// Token: 0x0603C836 RID: 247862 RVA: 0x00E84A33 File Offset: 0x00E82C33
		protected void TargetPercentChanged(float newPercent, float oldPercent)
		{
			this.OnTargetPercentChanged();
		}

		// Token: 0x0603C837 RID: 247863 RVA: 0x00E84A3B File Offset: 0x00E82C3B
		protected override void OnBeforeHide()
		{
			this.RemoveEvents();
		}

		// Token: 0x0603C838 RID: 247864 RVA: 0x00E84A43 File Offset: 0x00E82C43
		protected override void OnBeforeDestroy()
		{
			this.ClearAllAttributeChangedCallback();
			this.ClearAllTagListeners();
			this.ClearAllTweenAnim();
		}

		// Token: 0x0603C839 RID: 247865 RVA: 0x00E84A57 File Offset: 0x00E82C57
		protected virtual void AddEvents()
		{
			this.ListenForAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.ListenForAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x0603C83A RID: 247866 RVA: 0x00E84A89 File Offset: 0x00E82C89
		protected virtual void RemoveEvents()
		{
			this.RemoveListenAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.RemoveListenAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x0603C83B RID: 247867 RVA: 0x00E84ABB File Offset: 0x00E82CBB
		private void AttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChanged();
		}

		// Token: 0x0603C83C RID: 247868 RVA: 0x00E84AC3 File Offset: 0x00E82CC3
		private void MaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnMaxAttributeChanged();
		}

		// Token: 0x0603C83D RID: 247869 RVA: 0x00E84ACB File Offset: 0x00E82CCB
		protected virtual void OnAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x0603C83E RID: 247870 RVA: 0x00E84AE4 File Offset: 0x00E82CE4
		protected virtual void OnMaxAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x0603C83F RID: 247871 RVA: 0x00E84AFD File Offset: 0x00E82CFD
		protected virtual void OnTargetPercentChanged()
		{
		}

		// Token: 0x0603C840 RID: 247872 RVA: 0x00E84AFF File Offset: 0x00E82CFF
		protected virtual void OnBarPercentChanged()
		{
		}

		// Token: 0x0603C841 RID: 247873 RVA: 0x00E84B04 File Offset: 0x00E82D04
		protected float GetTargetAttributePercent()
		{
			double num = (double)this.AttributeComponent.GetCurrentValue(this.AttributeId);
			double num2 = (double)this.AttributeComponent.GetCurrentValue(this.MaxAttributeId);
			float result = 0f;
			if (num2 > 0.0)
			{
				result = (float)(num / num2);
			}
			return result;
		}

		// Token: 0x0603C842 RID: 247874 RVA: 0x00E84B50 File Offset: 0x00E82D50
		protected void ListenForAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
			if (baseAttributeComponent == null)
			{
				return;
			}
			baseAttributeComponent.AddListener(attributeId, onAttributeChanged, null);
			this.AttributeChangedCallbackMap[attributeId] = onAttributeChanged;
		}

		// Token: 0x0603C843 RID: 247875 RVA: 0x00E84B8C File Offset: 0x00E82D8C
		protected void RemoveListenAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(attributeId, onAttributeChanged);
			this.AttributeChangedCallbackMap.Remove(attributeId);
		}

		// Token: 0x0603C844 RID: 247876 RVA: 0x00E84BBC File Offset: 0x00E82DBC
		private void ClearAllAttributeChangedCallback()
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
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
				attributeComponent.RemoveListener(attrId, callback);
			}
			this.AttributeChangedCallbackMap.Clear();
		}

		// Token: 0x0603C845 RID: 247877 RVA: 0x00E84C3C File Offset: 0x00E82E3C
		protected void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			ITagTask value = tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
			if (this.TagTaskMap == null)
			{
				this.TagTaskMap = new Dictionary<int, ITagTask>();
			}
			this.TagTaskMap[tagId] = value;
		}

		// Token: 0x0603C846 RID: 247878 RVA: 0x00E84C84 File Offset: 0x00E82E84
		protected void RemoveListenTagAddOrRemove(int tagId)
		{
			Dictionary<int, ITagTask> tagTaskMap = this.TagTaskMap;
			ITagTask tagTask;
			if (tagTaskMap != null && tagTaskMap.Remove(tagId, out tagTask))
			{
				tagTask.EndTask();
			}
		}

		// Token: 0x0603C847 RID: 247879 RVA: 0x00E84CB0 File Offset: 0x00E82EB0
		protected void ListenForTagCountChanged(int tagId, BaseTagComponent.TTagChangedCallback onTagCountChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			ITagTask value = tagComponent.ListenForTagAnyCountChanged(tagId, onTagCountChange);
			if (this.TagCountTaskMap == null)
			{
				this.TagCountTaskMap = new Dictionary<int, ITagTask>();
			}
			this.TagCountTaskMap[tagId] = value;
		}

		// Token: 0x0603C848 RID: 247880 RVA: 0x00E84CF4 File Offset: 0x00E82EF4
		protected void RemoveListenTagCountChanged(int tagId)
		{
			Dictionary<int, ITagTask> tagCountTaskMap = this.TagCountTaskMap;
			ITagTask tagTask;
			if (tagCountTaskMap != null && tagCountTaskMap.Remove(tagId, out tagTask))
			{
				tagTask.EndTask();
			}
		}

		// Token: 0x0603C849 RID: 247881 RVA: 0x00E84D20 File Offset: 0x00E82F20
		private void ClearAllTagListeners()
		{
			if (this.TagTaskMap != null)
			{
				foreach (ITagTask tagTask in this.TagTaskMap.Values)
				{
					tagTask.EndTask();
				}
				this.TagTaskMap.Clear();
			}
			if (this.TagCountTaskMap != null)
			{
				foreach (ITagTask tagTask2 in this.TagCountTaskMap.Values)
				{
					tagTask2.EndTask();
				}
				this.TagCountTaskMap.Clear();
			}
		}

		// Token: 0x0603C84A RID: 247882 RVA: 0x00E84DE0 File Offset: 0x00E82FE0
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603C84B RID: 247883 RVA: 0x00E84E09 File Offset: 0x00E83009
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603C84C RID: 247884 RVA: 0x00E84E1C File Offset: 0x00E8301C
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603C84D RID: 247885 RVA: 0x00E84E2F File Offset: 0x00E8302F
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401F86C RID: 129132
		[Nullable(2)]
		public BattleUiRoleData RoleData;

		// Token: 0x0401F86D RID: 129133
		protected HeadIconEnergyBar? Config;

		// Token: 0x0401F86E RID: 129134
		protected bool PlayIncreaseEffect;

		// Token: 0x0401F86F RID: 129135
		protected int VisibleState;

		// Token: 0x0401F870 RID: 129136
		protected HeadIconEnergyBarPercentMachine PercentMachine = new HeadIconEnergyBarPercentMachine();

		// Token: 0x0401F871 RID: 129137
		protected EAttributeType AttributeId;

		// Token: 0x0401F872 RID: 129138
		protected EAttributeType MaxAttributeId;

		// Token: 0x0401F873 RID: 129139
		[Nullable(2)]
		protected BaseAttributeComponent AttributeComponent;

		// Token: 0x0401F874 RID: 129140
		[Nullable(2)]
		protected BaseTagComponent TagComponent;

		// Token: 0x0401F875 RID: 129141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ITagTask> TagTaskMap;

		// Token: 0x0401F876 RID: 129142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ITagTask> TagCountTaskMap;

		// Token: 0x0401F877 RID: 129143
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401F878 RID: 129144
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();
	}
}
