using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E00 RID: 19968
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarBase : UiPanelBase
	{
		// Token: 0x060323BD RID: 205757 RVA: 0x00E14C94 File Offset: 0x00E12E94
		public virtual UniTask InitByPathAsync(UUIItem parentItem, string prefabPath)
		{
			SpecialEnergyBarBase.<InitByPathAsync>d__21 <InitByPathAsync>d__;
			<InitByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitByPathAsync>d__.<>4__this = this;
			<InitByPathAsync>d__.parentItem = parentItem;
			<InitByPathAsync>d__.prefabPath = prefabPath;
			<InitByPathAsync>d__.<>1__state = -1;
			<InitByPathAsync>d__.<>t__builder.Start<SpecialEnergyBarBase.<InitByPathAsync>d__21>(ref <InitByPathAsync>d__);
			return <InitByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060323BE RID: 205758 RVA: 0x00E14CE8 File Offset: 0x00E12EE8
		public UniTask InitByActorAsync(AActor actor)
		{
			SpecialEnergyBarBase.<InitByActorAsync>d__22 <InitByActorAsync>d__;
			<InitByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitByActorAsync>d__.<>4__this = this;
			<InitByActorAsync>d__.actor = actor;
			<InitByActorAsync>d__.<>1__state = -1;
			<InitByActorAsync>d__.<>t__builder.Start<SpecialEnergyBarBase.<InitByActorAsync>d__22>(ref <InitByActorAsync>d__);
			return <InitByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060323BF RID: 205759 RVA: 0x00E14D34 File Offset: 0x00E12F34
		public void InitData([Nullable(2)] BattleUiRoleData roleData, SpecialEnergyBarInfo config, bool needInitKeyItem = true)
		{
			this.NeedInitKeyItem = needInitKeyItem;
			if (this.Destroyed || roleData == null)
			{
				return;
			}
			if (this.RoleData != null)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "能量条设置了多次角色的数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearAllAttributeChangedCallback();
				this.ClearAllTagCountChangedCallback();
			}
			this.RoleData = roleData;
			this.Config = config;
			this.AttributeId = (EAttributeType)config.AttributeId;
			this.MaxAttributeId = (EAttributeType)config.MaxAttributeId;
			this.AttributeComponent = this.RoleData.AttributeComponent;
			this.TagComponent = this.RoleData.GameplayTagComponent;
			this.BuffComponent = this.RoleData.BuffComponent;
			this.OnInitData();
			this.PercentMachine.Init(this.GetTargetAttributePercent());
			this.InitKeyEnableTag();
		}

		// Token: 0x060323C0 RID: 205760 RVA: 0x00E14DFA File Offset: 0x00E12FFA
		protected virtual void OnInitData()
		{
		}

		// Token: 0x060323C1 RID: 205761 RVA: 0x00E14DFC File Offset: 0x00E12FFC
		protected virtual void AddEvents()
		{
			this.ListenForAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.ListenForAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x060323C2 RID: 205762 RVA: 0x00E14E2E File Offset: 0x00E1302E
		protected virtual void RemoveEvents()
		{
			this.RemoveListenAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.RemoveListenAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x060323C3 RID: 205763 RVA: 0x00E14E60 File Offset: 0x00E13060
		public void SetVisible(bool bVisible, int type = 0)
		{
			this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, bVisible, type);
			this.RefreshVisible();
		}

		// Token: 0x060323C4 RID: 205764 RVA: 0x00E14E7C File Offset: 0x00E1307C
		protected virtual void RefreshVisible()
		{
			if (base.InAsyncLoading() || base.IsRegister || base.IsCreateOrCreating)
			{
				return;
			}
			if (this.VisibleState == 0)
			{
				if (!base.IsShowOrShowing)
				{
					base.Show(null);
					return;
				}
			}
			else if (base.IsShowOrShowing)
			{
				base.Hide(null);
			}
		}

		// Token: 0x060323C5 RID: 205765 RVA: 0x00E14ECC File Offset: 0x00E130CC
		protected override bool DestroyOverride()
		{
			this.Destroyed = true;
			return false;
		}

		// Token: 0x060323C6 RID: 205766 RVA: 0x00E14ED8 File Offset: 0x00E130D8
		protected override void OnBeforeDestroy()
		{
			if (!base.InAsyncLoading())
			{
				this.RemoveEvents();
			}
			this.ClearAllTweenAnim();
			this.ClearAllAttributeChangedCallback();
			this.ClearAllTagCountChangedCallback();
			if (this.NeedInitKeyItem)
			{
				this.NeedInitKeyItem = false;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.Destroy(null);
				}
				this.KeyItem = null;
			}
			foreach (SpecialEnergyBarKeyItem specialEnergyBarKeyItem in this.ExtraKeyItemList)
			{
				specialEnergyBarKeyItem.Destroy(null);
			}
			this.ExtraKeyItemList.Clear();
			if (this.NeedInitNumItem)
			{
				this.NeedInitNumItem = false;
				SpecialEnergyBarNumItem numItem = this.NumItem;
				if (numItem != null)
				{
					numItem.Destroy(null);
				}
				this.NumItem = null;
			}
			this.RoleData = null;
			this.AttributeComponent = null;
			this.TagComponent = null;
			this.BuffComponent = null;
		}

		// Token: 0x060323C7 RID: 205767 RVA: 0x00E14FC0 File Offset: 0x00E131C0
		public int? GetEntityId()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null)
			{
				return null;
			}
			EntityHandle entityHandle = roleData.EntityHandle;
			if (entityHandle == null)
			{
				return null;
			}
			return new int?(entityHandle.Id);
		}

		// Token: 0x060323C8 RID: 205768 RVA: 0x00E14FFE File Offset: 0x00E131FE
		public virtual void Tick(float delta)
		{
			if (this.PercentMachine.Update(delta))
			{
				this.OnBarPercentChanged();
			}
		}

		// Token: 0x060323C9 RID: 205769 RVA: 0x00E15014 File Offset: 0x00E13214
		private void AttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChanged();
		}

		// Token: 0x060323CA RID: 205770 RVA: 0x00E1501C File Offset: 0x00E1321C
		private void MaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnMaxAttributeChanged();
		}

		// Token: 0x060323CB RID: 205771 RVA: 0x00E15024 File Offset: 0x00E13224
		protected virtual void OnAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x060323CC RID: 205772 RVA: 0x00E1503D File Offset: 0x00E1323D
		protected virtual void OnMaxAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x060323CD RID: 205773 RVA: 0x00E15056 File Offset: 0x00E13256
		protected virtual void OnBarPercentChanged()
		{
		}

		// Token: 0x060323CE RID: 205774 RVA: 0x00E15058 File Offset: 0x00E13258
		protected void ListenForAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			if (attributeId <= EAttributeType.None)
			{
				return;
			}
			BattleUiRoleData roleData = this.RoleData;
			BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
			if (baseAttributeComponent == null)
			{
				return;
			}
			baseAttributeComponent.AddListener(attributeId, onAttributeChanged, null);
			this.AttributeChangedCallbackMap[attributeId] = onAttributeChanged;
		}

		// Token: 0x060323CF RID: 205775 RVA: 0x00E15098 File Offset: 0x00E13298
		protected void RemoveListenAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			if (attributeId <= EAttributeType.None)
			{
				return;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(attributeId, onAttributeChanged);
			this.AttributeChangedCallbackMap.Remove(attributeId);
		}

		// Token: 0x060323D0 RID: 205776 RVA: 0x00E150CC File Offset: 0x00E132CC
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

		// Token: 0x060323D1 RID: 205777 RVA: 0x00E1514C File Offset: 0x00E1334C
		protected void ListenForTagCountChanged(int tagId, BaseTagComponent.TTagChangedCallback onTagCountChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			ITagTask tagTask = (tagComponent != null) ? tagComponent.ListenForTagAnyCountChanged(tagId, onTagCountChange) : null;
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x060323D2 RID: 205778 RVA: 0x00E15180 File Offset: 0x00E13380
		protected void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x060323D3 RID: 205779 RVA: 0x00E151DC File Offset: 0x00E133DC
		protected void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			ITagTask tagTask = (tagComponent != null) ? tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null) : null;
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x060323D4 RID: 205780 RVA: 0x00E15213 File Offset: 0x00E13413
		protected int GetBuffCountByBuffId(long buffId)
		{
			return this.BuffComponent.GetBuffTotalStackById(buffId, false);
		}

		// Token: 0x060323D5 RID: 205781 RVA: 0x00E15224 File Offset: 0x00E13424
		protected UniTask LoadEffects()
		{
			SpecialEnergyBarBase.<LoadEffects>d__45 <LoadEffects>d__;
			<LoadEffects>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffects>d__.<>4__this = this;
			<LoadEffects>d__.<>1__state = -1;
			<LoadEffects>d__.<>t__builder.Start<SpecialEnergyBarBase.<LoadEffects>d__45>(ref <LoadEffects>d__);
			return <LoadEffects>d__.<>t__builder.Task;
		}

		// Token: 0x060323D6 RID: 205782 RVA: 0x00E15268 File Offset: 0x00E13468
		private UniTask LoadNiagara(string path, int index, [Nullable(new byte[]
		{
			1,
			2
		})] List<UNiagaraSystem> niagaraList)
		{
			SpecialEnergyBarBase.<LoadNiagara>d__46 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.index = index;
			<LoadNiagara>d__.niagaraList = niagaraList;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<SpecialEnergyBarBase.<LoadNiagara>d__46>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x060323D7 RID: 205783 RVA: 0x00E152BC File Offset: 0x00E134BC
		protected virtual UniTask InitKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarBase.<InitKeyItem>d__47 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<SpecialEnergyBarBase.<InitKeyItem>d__47>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x060323D8 RID: 205784 RVA: 0x00E15308 File Offset: 0x00E13508
		protected UniTask InitNumItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarBase.<InitNumItem>d__48 <InitNumItem>d__;
			<InitNumItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitNumItem>d__.<>4__this = this;
			<InitNumItem>d__.keyItemContainer = keyItemContainer;
			<InitNumItem>d__.<>1__state = -1;
			<InitNumItem>d__.<>t__builder.Start<SpecialEnergyBarBase.<InitNumItem>d__48>(ref <InitNumItem>d__);
			return <InitNumItem>d__.<>t__builder.Task;
		}

		// Token: 0x060323D9 RID: 205785 RVA: 0x00E15354 File Offset: 0x00E13554
		protected void InitKeyEnableTag()
		{
			int keyEnableTagId = this.Config.KeyEnableTagId;
			if (keyEnableTagId != 0)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				this.HasKeyEnableTag = (tagComponent != null && tagComponent.HasTag(keyEnableTagId));
				this.ListenForTagAddOrRemoveChanged(keyEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnKeyEnableTagChanged));
			}
		}

		// Token: 0x060323DA RID: 205786 RVA: 0x00E1539C File Offset: 0x00E1359C
		protected float GetTargetAttributePercent()
		{
			if (this.AttributeComponent == null)
			{
				return 0f;
			}
			float currentValue = this.AttributeComponent.GetCurrentValue(this.AttributeId);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(this.MaxAttributeId);
			float result = 0f;
			if (currentValue2 > 0f)
			{
				result = currentValue / currentValue2;
			}
			return result;
		}

		// Token: 0x060323DB RID: 205787 RVA: 0x00E153EE File Offset: 0x00E135EE
		protected virtual bool GetKeyEnable()
		{
			return this.PercentMachine.GetCurPercent() >= this.Config.DisableKeyOnPercent && (this.Config.KeyEnableTagId == 0 || this.HasKeyEnableTag);
		}

		// Token: 0x060323DC RID: 205788 RVA: 0x00E15422 File Offset: 0x00E13622
		protected void OnKeyEnableTagChanged(int tagId, bool tagExist)
		{
			this.HasKeyEnableTag = tagExist;
			this.OnKeyEnableChanged();
		}

		// Token: 0x060323DD RID: 205789 RVA: 0x00E15431 File Offset: 0x00E13631
		protected virtual void OnKeyEnableChanged()
		{
		}

		// Token: 0x060323DE RID: 205790 RVA: 0x00E15433 File Offset: 0x00E13633
		public virtual void OnChangeVisibleByTagChange(bool visible)
		{
		}

		// Token: 0x060323DF RID: 205791 RVA: 0x00E15435 File Offset: 0x00E13635
		public virtual void ReplaceFullEffect(UNiagaraSystem niagara)
		{
		}

		// Token: 0x060323E0 RID: 205792 RVA: 0x00E15437 File Offset: 0x00E13637
		public virtual void RevertFullEffect()
		{
		}

		// Token: 0x060323E1 RID: 205793 RVA: 0x00E15439 File Offset: 0x00E13639
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x060323E2 RID: 205794 RVA: 0x00E15462 File Offset: 0x00E13662
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x060323E3 RID: 205795 RVA: 0x00E15475 File Offset: 0x00E13675
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x060323E4 RID: 205796 RVA: 0x00E15488 File Offset: 0x00E13688
		protected virtual void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x060323E5 RID: 205797 RVA: 0x00E1549B File Offset: 0x00E1369B
		protected void SetTweenTimeScale(int componentType, float timeScale)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.SetTweenTimeScale(componentType, timeScale);
		}

		// Token: 0x0401A9EB RID: 109035
		protected bool Destroyed;

		// Token: 0x0401A9EC RID: 109036
		protected string PrefabPath = string.Empty;

		// Token: 0x0401A9ED RID: 109037
		[Nullable(2)]
		protected BattleUiRoleData RoleData;

		// Token: 0x0401A9EE RID: 109038
		[Nullable(2)]
		protected SpecialEnergyBarInfo Config;

		// Token: 0x0401A9EF RID: 109039
		protected EAttributeType AttributeId;

		// Token: 0x0401A9F0 RID: 109040
		protected EAttributeType MaxAttributeId;

		// Token: 0x0401A9F1 RID: 109041
		[Nullable(2)]
		protected BaseAttributeComponent AttributeComponent;

		// Token: 0x0401A9F2 RID: 109042
		[Nullable(2)]
		protected BaseTagComponent TagComponent;

		// Token: 0x0401A9F3 RID: 109043
		[Nullable(2)]
		protected CharacterBuffComponent BuffComponent;

		// Token: 0x0401A9F4 RID: 109044
		protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0401A9F5 RID: 109045
		protected bool HasKeyEnableTag;

		// Token: 0x0401A9F6 RID: 109046
		[Nullable(new byte[]
		{
			1,
			2
		})]
		protected readonly List<UNiagaraSystem> NiagaraList = new List<UNiagaraSystem>();

		// Token: 0x0401A9F7 RID: 109047
		protected bool NeedInitKeyItem = true;

		// Token: 0x0401A9F8 RID: 109048
		[Nullable(2)]
		protected SpecialEnergyBarKeyItem KeyItem;

		// Token: 0x0401A9F9 RID: 109049
		protected readonly List<SpecialEnergyBarKeyItem> ExtraKeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401A9FA RID: 109050
		protected bool NeedInitNumItem;

		// Token: 0x0401A9FB RID: 109051
		[Nullable(2)]
		protected SpecialEnergyBarNumItem NumItem;

		// Token: 0x0401A9FC RID: 109052
		protected readonly SpecialEnergyBarPercentMachine PercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A9FD RID: 109053
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401A9FE RID: 109054
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x0401A9FF RID: 109055
		protected int VisibleState;
	}
}
