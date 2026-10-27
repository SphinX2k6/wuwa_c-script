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
	// Token: 0x02005E1B RID: 24091
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarBase : UiPanelBase
	{
		// Token: 0x0603D42E RID: 250926 RVA: 0x00EC3734 File Offset: 0x00EC1934
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

		// Token: 0x0603D42F RID: 250927 RVA: 0x00EC3788 File Offset: 0x00EC1988
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

		// Token: 0x0603D430 RID: 250928 RVA: 0x00EC37D4 File Offset: 0x00EC19D4
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

		// Token: 0x0603D431 RID: 250929 RVA: 0x00EC389A File Offset: 0x00EC1A9A
		protected virtual void OnInitData()
		{
		}

		// Token: 0x0603D432 RID: 250930 RVA: 0x00EC389C File Offset: 0x00EC1A9C
		protected virtual void AddEvents()
		{
			this.ListenForAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.ListenForAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x0603D433 RID: 250931 RVA: 0x00EC38CE File Offset: 0x00EC1ACE
		protected virtual void RemoveEvents()
		{
			this.RemoveListenAttributeChanged(this.AttributeId, new Action<EAttributeType, float, float>(this.AttributeChanged));
			this.RemoveListenAttributeChanged(this.MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChanged));
		}

		// Token: 0x0603D434 RID: 250932 RVA: 0x00EC3900 File Offset: 0x00EC1B00
		public void SetVisible(bool bVisible, int type = 0)
		{
			this.VisibleState = VisibleStateUtil.SetVisible(this.VisibleState, bVisible, type);
			this.RefreshVisible();
		}

		// Token: 0x0603D435 RID: 250933 RVA: 0x00EC391C File Offset: 0x00EC1B1C
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

		// Token: 0x0603D436 RID: 250934 RVA: 0x00EC396C File Offset: 0x00EC1B6C
		protected override bool DestroyOverride()
		{
			this.Destroyed = true;
			return false;
		}

		// Token: 0x0603D437 RID: 250935 RVA: 0x00EC3978 File Offset: 0x00EC1B78
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

		// Token: 0x0603D438 RID: 250936 RVA: 0x00EC3A60 File Offset: 0x00EC1C60
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

		// Token: 0x0603D439 RID: 250937 RVA: 0x00EC3A9E File Offset: 0x00EC1C9E
		public virtual void Tick(float delta)
		{
			if (this.PercentMachine.Update(delta))
			{
				this.OnBarPercentChanged();
			}
		}

		// Token: 0x0603D43A RID: 250938 RVA: 0x00EC3AB4 File Offset: 0x00EC1CB4
		private void AttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChanged();
		}

		// Token: 0x0603D43B RID: 250939 RVA: 0x00EC3ABC File Offset: 0x00EC1CBC
		private void MaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnMaxAttributeChanged();
		}

		// Token: 0x0603D43C RID: 250940 RVA: 0x00EC3AC4 File Offset: 0x00EC1CC4
		protected virtual void OnAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D43D RID: 250941 RVA: 0x00EC3ADD File Offset: 0x00EC1CDD
		protected virtual void OnMaxAttributeChanged()
		{
			this.PercentMachine.SetTargetPercent(this.GetTargetAttributePercent());
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D43E RID: 250942 RVA: 0x00EC3AF6 File Offset: 0x00EC1CF6
		protected virtual void OnBarPercentChanged()
		{
		}

		// Token: 0x0603D43F RID: 250943 RVA: 0x00EC3AF8 File Offset: 0x00EC1CF8
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

		// Token: 0x0603D440 RID: 250944 RVA: 0x00EC3B38 File Offset: 0x00EC1D38
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

		// Token: 0x0603D441 RID: 250945 RVA: 0x00EC3B6C File Offset: 0x00EC1D6C
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

		// Token: 0x0603D442 RID: 250946 RVA: 0x00EC3BEC File Offset: 0x00EC1DEC
		protected void ListenForTagCountChanged(int tagId, BaseTagComponent.TTagChangedCallback onTagCountChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			ITagTask tagTask = (tagComponent != null) ? tagComponent.ListenForTagAnyCountChanged(tagId, onTagCountChange) : null;
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x0603D443 RID: 250947 RVA: 0x00EC3C20 File Offset: 0x00EC1E20
		protected void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0603D444 RID: 250948 RVA: 0x00EC3C7C File Offset: 0x00EC1E7C
		protected void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			ITagTask tagTask = (tagComponent != null) ? tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null) : null;
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x0603D445 RID: 250949 RVA: 0x00EC3CB3 File Offset: 0x00EC1EB3
		protected int GetBuffCountByBuffId(long buffId)
		{
			return this.BuffComponent.GetBuffTotalStackById(buffId, false);
		}

		// Token: 0x0603D446 RID: 250950 RVA: 0x00EC3CC4 File Offset: 0x00EC1EC4
		protected UniTask LoadEffects()
		{
			SpecialEnergyBarBase.<LoadEffects>d__45 <LoadEffects>d__;
			<LoadEffects>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffects>d__.<>4__this = this;
			<LoadEffects>d__.<>1__state = -1;
			<LoadEffects>d__.<>t__builder.Start<SpecialEnergyBarBase.<LoadEffects>d__45>(ref <LoadEffects>d__);
			return <LoadEffects>d__.<>t__builder.Task;
		}

		// Token: 0x0603D447 RID: 250951 RVA: 0x00EC3D08 File Offset: 0x00EC1F08
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

		// Token: 0x0603D448 RID: 250952 RVA: 0x00EC3D5C File Offset: 0x00EC1F5C
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

		// Token: 0x0603D449 RID: 250953 RVA: 0x00EC3DA8 File Offset: 0x00EC1FA8
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

		// Token: 0x0603D44A RID: 250954 RVA: 0x00EC3DF4 File Offset: 0x00EC1FF4
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

		// Token: 0x0603D44B RID: 250955 RVA: 0x00EC3E3C File Offset: 0x00EC203C
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

		// Token: 0x0603D44C RID: 250956 RVA: 0x00EC3E8E File Offset: 0x00EC208E
		protected virtual bool GetKeyEnable()
		{
			return this.PercentMachine.GetCurPercent() >= this.Config.DisableKeyOnPercent && (this.Config.KeyEnableTagId == 0 || this.HasKeyEnableTag);
		}

		// Token: 0x0603D44D RID: 250957 RVA: 0x00EC3EC2 File Offset: 0x00EC20C2
		protected void OnKeyEnableTagChanged(int tagId, bool tagExist)
		{
			this.HasKeyEnableTag = tagExist;
			this.OnKeyEnableChanged();
		}

		// Token: 0x0603D44E RID: 250958 RVA: 0x00EC3ED1 File Offset: 0x00EC20D1
		protected virtual void OnKeyEnableChanged()
		{
		}

		// Token: 0x0603D44F RID: 250959 RVA: 0x00EC3ED3 File Offset: 0x00EC20D3
		public virtual void OnChangeVisibleByTagChange(bool visible)
		{
		}

		// Token: 0x0603D450 RID: 250960 RVA: 0x00EC3ED5 File Offset: 0x00EC20D5
		public virtual void ReplaceFullEffect(UNiagaraSystem niagara)
		{
		}

		// Token: 0x0603D451 RID: 250961 RVA: 0x00EC3ED7 File Offset: 0x00EC20D7
		public virtual void RevertFullEffect()
		{
		}

		// Token: 0x0603D452 RID: 250962 RVA: 0x00EC3ED9 File Offset: 0x00EC20D9
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603D453 RID: 250963 RVA: 0x00EC3F02 File Offset: 0x00EC2102
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D454 RID: 250964 RVA: 0x00EC3F15 File Offset: 0x00EC2115
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603D455 RID: 250965 RVA: 0x00EC3F28 File Offset: 0x00EC2128
		protected virtual void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0603D456 RID: 250966 RVA: 0x00EC3F3B File Offset: 0x00EC213B
		protected void SetTweenTimeScale(int componentType, float timeScale)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.SetTweenTimeScale(componentType, timeScale);
		}

		// Token: 0x0401FF24 RID: 130852
		protected bool Destroyed;

		// Token: 0x0401FF25 RID: 130853
		protected string PrefabPath = string.Empty;

		// Token: 0x0401FF26 RID: 130854
		[Nullable(2)]
		protected BattleUiRoleData RoleData;

		// Token: 0x0401FF27 RID: 130855
		[Nullable(2)]
		protected SpecialEnergyBarInfo Config;

		// Token: 0x0401FF28 RID: 130856
		protected EAttributeType AttributeId;

		// Token: 0x0401FF29 RID: 130857
		protected EAttributeType MaxAttributeId;

		// Token: 0x0401FF2A RID: 130858
		[Nullable(2)]
		protected BaseAttributeComponent AttributeComponent;

		// Token: 0x0401FF2B RID: 130859
		[Nullable(2)]
		protected BaseTagComponent TagComponent;

		// Token: 0x0401FF2C RID: 130860
		[Nullable(2)]
		protected CharacterBuffComponent BuffComponent;

		// Token: 0x0401FF2D RID: 130861
		protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0401FF2E RID: 130862
		protected bool HasKeyEnableTag;

		// Token: 0x0401FF2F RID: 130863
		[Nullable(new byte[]
		{
			1,
			2
		})]
		protected readonly List<UNiagaraSystem> NiagaraList = new List<UNiagaraSystem>();

		// Token: 0x0401FF30 RID: 130864
		protected bool NeedInitKeyItem = true;

		// Token: 0x0401FF31 RID: 130865
		[Nullable(2)]
		protected SpecialEnergyBarKeyItem KeyItem;

		// Token: 0x0401FF32 RID: 130866
		protected readonly List<SpecialEnergyBarKeyItem> ExtraKeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401FF33 RID: 130867
		protected bool NeedInitNumItem;

		// Token: 0x0401FF34 RID: 130868
		[Nullable(2)]
		protected SpecialEnergyBarNumItem NumItem;

		// Token: 0x0401FF35 RID: 130869
		protected readonly SpecialEnergyBarPercentMachine PercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FF36 RID: 130870
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401FF37 RID: 130871
		private readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x0401FF38 RID: 130872
		protected int VisibleState;
	}
}
