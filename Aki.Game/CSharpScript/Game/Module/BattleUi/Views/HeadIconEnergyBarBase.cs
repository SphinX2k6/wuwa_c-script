using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D16 RID: 19734
	[NullableContext(1)]
	[Nullable(0)]
	public class HeadIconEnergyBarBase : UiPanelBase
	{
		// Token: 0x06031787 RID: 202631 RVA: 0x00DD5064 File Offset: 0x00DD3264
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

		// Token: 0x06031788 RID: 202632 RVA: 0x00DD50A5 File Offset: 0x00DD32A5
		public bool GetVisible()
		{
			return VisibleStateUtil.GetVisible(this.VisibleState);
		}

		// Token: 0x06031789 RID: 202633 RVA: 0x00DD50B4 File Offset: 0x00DD32B4
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

		// Token: 0x0603178A RID: 202634 RVA: 0x00DD5127 File Offset: 0x00DD3327
		public void InitByPath(UUIItem parentItem, string prefabPath)
		{
			base.CreateByPathAsync(prefabPath, parentItem, false);
		}

		// Token: 0x0603178B RID: 202635 RVA: 0x00DD5133 File Offset: 0x00DD3333
		public void ChangeParent(UUIItem parentItem)
		{
			if (this.ParentUiItem == parentItem)
			{
				return;
			}
			this.ParentUiItem = parentItem;
			this.GetOriginalItem().SetUIParent(parentItem, true);
		}

		// Token: 0x0603178C RID: 202636 RVA: 0x00DD5153 File Offset: 0x00DD3353
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

		// Token: 0x0603178D RID: 202637 RVA: 0x00DD5172 File Offset: 0x00DD3372
		protected override void OnStart()
		{
			base.OnStart();
			this.PercentMachine.Init(this.GetTargetAttributePercent(), 0f, 400f, new Action<float, float>(this.TargetPercentChanged));
		}

		// Token: 0x0603178E RID: 202638 RVA: 0x00DD51A1 File Offset: 0x00DD33A1
		protected override void OnBeforeShow()
		{
			this.AddEvents();
			if (this.GetTargetAttributePercent() != this.PercentMachine.GetTargetPercent())
			{
				this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
				this.OnBarPercentChanged();
			}
		}

		// Token: 0x0603178F RID: 202639 RVA: 0x00DD51D3 File Offset: 0x00DD33D3
		protected void TargetPercentChanged(float newPercent, float oldPercent)
		{
			this.OnTargetPercentChanged();
		}

		// Token: 0x06031790 RID: 202640 RVA: 0x00DD51DB File Offset: 0x00DD33DB
		protected override void OnBeforeHide()
		{
			this.RemoveEvents();
		}

		// Token: 0x06031791 RID: 202641 RVA: 0x00DD51E3 File Offset: 0x00DD33E3
		protected override void OnBeforeDestroy()
		{
			this.ClearAllAttributeChangedCallback();
			this.ClearAllTagListeners();
			this.ClearAllTweenAnim();
		}

		// Token: 0x06031792 RID: 202642 RVA: 0x00DD51F7 File Offset: 0x00DD33F7
		protected virtual void AddEvents()
		{
			this.ListenForAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.ListenForAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x06031793 RID: 202643 RVA: 0x00DD5229 File Offset: 0x00DD3429
		protected virtual void RemoveEvents()
		{
			this.RemoveListenAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.RemoveListenAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x06031794 RID: 202644 RVA: 0x00DD525B File Offset: 0x00DD345B
		private void AttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChanged();
		}

		// Token: 0x06031795 RID: 202645 RVA: 0x00DD5263 File Offset: 0x00DD3463
		private void MaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnMaxAttributeChanged();
		}

		// Token: 0x06031796 RID: 202646 RVA: 0x00DD526B File Offset: 0x00DD346B
		protected virtual void OnAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x06031797 RID: 202647 RVA: 0x00DD5284 File Offset: 0x00DD3484
		protected virtual void OnMaxAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x06031798 RID: 202648 RVA: 0x00DD529D File Offset: 0x00DD349D
		protected virtual void OnTargetPercentChanged()
		{
		}

		// Token: 0x06031799 RID: 202649 RVA: 0x00DD529F File Offset: 0x00DD349F
		protected virtual void OnBarPercentChanged()
		{
		}

		// Token: 0x0603179A RID: 202650 RVA: 0x00DD52A4 File Offset: 0x00DD34A4
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

		// Token: 0x0603179B RID: 202651 RVA: 0x00DD52F0 File Offset: 0x00DD34F0
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

		// Token: 0x0603179C RID: 202652 RVA: 0x00DD532C File Offset: 0x00DD352C
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

		// Token: 0x0603179D RID: 202653 RVA: 0x00DD535C File Offset: 0x00DD355C
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

		// Token: 0x0603179E RID: 202654 RVA: 0x00DD53DC File Offset: 0x00DD35DC
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

		// Token: 0x0603179F RID: 202655 RVA: 0x00DD5424 File Offset: 0x00DD3624
		protected void RemoveListenTagAddOrRemove(int tagId)
		{
			Dictionary<int, ITagTask> tagTaskMap = this.TagTaskMap;
			ITagTask tagTask;
			if (tagTaskMap != null && tagTaskMap.Remove(tagId, out tagTask))
			{
				tagTask.EndTask();
			}
		}

		// Token: 0x060317A0 RID: 202656 RVA: 0x00DD5450 File Offset: 0x00DD3650
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

		// Token: 0x060317A1 RID: 202657 RVA: 0x00DD5494 File Offset: 0x00DD3694
		protected void RemoveListenTagCountChanged(int tagId)
		{
			Dictionary<int, ITagTask> tagCountTaskMap = this.TagCountTaskMap;
			ITagTask tagTask;
			if (tagCountTaskMap != null && tagCountTaskMap.Remove(tagId, out tagTask))
			{
				tagTask.EndTask();
			}
		}

		// Token: 0x060317A2 RID: 202658 RVA: 0x00DD54C0 File Offset: 0x00DD36C0
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

		// Token: 0x060317A3 RID: 202659 RVA: 0x00DD5580 File Offset: 0x00DD3780
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x060317A4 RID: 202660 RVA: 0x00DD55A9 File Offset: 0x00DD37A9
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x060317A5 RID: 202661 RVA: 0x00DD55BC File Offset: 0x00DD37BC
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x060317A6 RID: 202662 RVA: 0x00DD55CF File Offset: 0x00DD37CF
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401A325 RID: 107301
		[Nullable(2)]
		public BattleUiRoleData RoleData;

		// Token: 0x0401A326 RID: 107302
		protected HeadIconEnergyBar? Config;

		// Token: 0x0401A327 RID: 107303
		protected bool PlayIncreaseEffect;

		// Token: 0x0401A328 RID: 107304
		protected int VisibleState;

		// Token: 0x0401A329 RID: 107305
		protected HeadIconEnergyBarPercentMachine PercentMachine = new HeadIconEnergyBarPercentMachine();

		// Token: 0x0401A32A RID: 107306
		protected EAttributeType AttributeId;

		// Token: 0x0401A32B RID: 107307
		protected EAttributeType MaxAttributeId;

		// Token: 0x0401A32C RID: 107308
		[Nullable(2)]
		protected BaseAttributeComponent AttributeComponent;

		// Token: 0x0401A32D RID: 107309
		[Nullable(2)]
		protected BaseTagComponent TagComponent;

		// Token: 0x0401A32E RID: 107310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ITagTask> TagTaskMap;

		// Token: 0x0401A32F RID: 107311
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ITagTask> TagCountTaskMap;

		// Token: 0x0401A330 RID: 107312
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401A331 RID: 107313
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();
	}
}
