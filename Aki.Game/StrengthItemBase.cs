using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001426 RID: 5158
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemBase : UiPanelBase
{
	// Token: 0x0600CD62 RID: 52578 RVA: 0x003D20D8 File Offset: 0x003D02D8
	public void Init(UUIItem parentItem, [Nullable(2)] BattleUiRoleData roleData, Action<bool> uiVisibleChanged)
	{
		this.RoleData = roleData;
		this.UiVisibleChanged = uiVisibleChanged;
		this.TargetActive = false;
		this.InitAsync(parentItem).ContinueWith(delegate()
		{
		});
	}

	// Token: 0x0600CD63 RID: 52579 RVA: 0x003D2128 File Offset: 0x003D0328
	protected virtual UniTask InitAsync(UUIItem parentItem)
	{
		StrengthItemBase.<InitAsync>d__9 <InitAsync>d__;
		<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAsync>d__.<>4__this = this;
		<InitAsync>d__.parentItem = parentItem;
		<InitAsync>d__.<>1__state = -1;
		<InitAsync>d__.<>t__builder.Start<StrengthItemBase.<InitAsync>d__9>(ref <InitAsync>d__);
		return <InitAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD64 RID: 52580 RVA: 0x003D2173 File Offset: 0x003D0373
	protected virtual string GetResourceId()
	{
		return "UiItem_Endurance";
	}

	// Token: 0x0600CD65 RID: 52581 RVA: 0x003D217A File Offset: 0x003D037A
	protected override void OnStart()
	{
		this.IsAfterStart = true;
		this.OnAddEvents();
		this.OnAddEntityEvents();
		this.OnRefreshRoleData();
		if (!this.EnableByHighPriority)
		{
			this.SetEnableByHighPriority(false, false);
		}
	}

	// Token: 0x0600CD66 RID: 52582 RVA: 0x003D21A5 File Offset: 0x003D03A5
	protected override void OnBeforeShow()
	{
		Action<bool> uiVisibleChanged = this.UiVisibleChanged;
		if (uiVisibleChanged == null)
		{
			return;
		}
		uiVisibleChanged(true);
	}

	// Token: 0x0600CD67 RID: 52583 RVA: 0x003D21B8 File Offset: 0x003D03B8
	protected override void OnAfterHide()
	{
		Action<bool> uiVisibleChanged = this.UiVisibleChanged;
		if (uiVisibleChanged == null)
		{
			return;
		}
		uiVisibleChanged(false);
	}

	// Token: 0x0600CD68 RID: 52584 RVA: 0x003D21CB File Offset: 0x003D03CB
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEvents();
		this.RefreshRoleData(null);
		this.IsAfterStart = false;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CD69 RID: 52585 RVA: 0x003D21E7 File Offset: 0x003D03E7
	public override void SetActive(bool visibility)
	{
		if (this.TargetActive == visibility)
		{
			return;
		}
		this.TargetActive = visibility;
		base.SetActive(visibility);
	}

	// Token: 0x0600CD6A RID: 52586 RVA: 0x003D2201 File Offset: 0x003D0401
	[NullableContext(2)]
	public void RefreshRoleData(BattleUiRoleData roleData)
	{
		if (this.RoleData == roleData)
		{
			return;
		}
		this.ClearTagTask();
		this.ClearAllAttributeChangedCallback();
		this.OnRemoveEntityEvents();
		this.RoleData = roleData;
		if (!this.IsAfterStart)
		{
			return;
		}
		this.OnAddEntityEvents();
		this.OnRefreshRoleData();
	}

	// Token: 0x0600CD6B RID: 52587 RVA: 0x003D223B File Offset: 0x003D043B
	public virtual void Tick(float delta)
	{
	}

	// Token: 0x0600CD6C RID: 52588 RVA: 0x003D223D File Offset: 0x003D043D
	public bool GetUiVisible()
	{
		return base.IsShowing || base.IsShow;
	}

	// Token: 0x0600CD6D RID: 52589 RVA: 0x003D224F File Offset: 0x003D044F
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x0600CD6E RID: 52590 RVA: 0x003D2251 File Offset: 0x003D0451
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600CD6F RID: 52591 RVA: 0x003D2254 File Offset: 0x003D0454
	public unsafe void SetEnableByHighPriority(bool b, bool force = false)
	{
		if (this.EnableByHighPriority == b && !force)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HudUnit;
		ELogAuthor author = ELogAuthor.HWR;
		string message = "体力条 SetEnableStrengthItem";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("", b);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.EnableByHighPriority = b;
		if (!this.IsAfterStart)
		{
			return;
		}
		this.OnEnableByHighPriority(b);
	}

	// Token: 0x0600CD70 RID: 52592 RVA: 0x003D22EA File Offset: 0x003D04EA
	protected virtual void OnEnableByHighPriority(bool b)
	{
	}

	// Token: 0x0600CD71 RID: 52593 RVA: 0x003D22EC File Offset: 0x003D04EC
	protected virtual void OnAddEntityEvents()
	{
	}

	// Token: 0x0600CD72 RID: 52594 RVA: 0x003D22EE File Offset: 0x003D04EE
	protected virtual void OnRemoveEntityEvents()
	{
	}

	// Token: 0x0600CD73 RID: 52595 RVA: 0x003D22F0 File Offset: 0x003D04F0
	protected virtual void OnRefreshRoleData()
	{
	}

	// Token: 0x0600CD74 RID: 52596 RVA: 0x003D22F4 File Offset: 0x003D04F4
	protected void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int? tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(tagId, new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), StrengthItemBase.ListenTagStat);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600CD75 RID: 52597 RVA: 0x003D232C File Offset: 0x003D052C
	protected void ClearTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0600CD76 RID: 52598 RVA: 0x003D2388 File Offset: 0x003D0588
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

	// Token: 0x0600CD77 RID: 52599 RVA: 0x003D23C8 File Offset: 0x003D05C8
	protected void RemoveListenAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
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
		baseAttributeComponent.RemoveListener(attributeId, onAttributeChanged);
		this.AttributeChangedCallbackMap.Remove(attributeId);
	}

	// Token: 0x0600CD78 RID: 52600 RVA: 0x003D2408 File Offset: 0x003D0608
	private void ClearAllAttributeChangedCallback()
	{
		BattleUiRoleData roleData = this.RoleData;
		BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
		if (baseAttributeComponent == null)
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
			baseAttributeComponent.RemoveListener(attrId, callback);
		}
		this.AttributeChangedCallbackMap.Clear();
	}

	// Token: 0x0600CD79 RID: 52601 RVA: 0x003D2494 File Offset: 0x003D0694
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600CD7A RID: 52602 RVA: 0x003D24AA File Offset: 0x003D06AA
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600CD7B RID: 52603 RVA: 0x003D24B8 File Offset: 0x003D06B8
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x04007509 RID: 29961
	[StaticVariableRuleIgnore]
	private static readonly Stat ListenTagStat = Stat.Create("[StrengthItem]ListenTag", "", "");

	// Token: 0x0400750A RID: 29962
	protected bool IsAfterStart;

	// Token: 0x0400750B RID: 29963
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x0400750C RID: 29964
	[Nullable(2)]
	protected Action<bool> UiVisibleChanged;

	// Token: 0x0400750D RID: 29965
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400750E RID: 29966
	protected readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

	// Token: 0x0400750F RID: 29967
	protected bool TargetActive;

	// Token: 0x04007510 RID: 29968
	protected bool EnableByHighPriority = true;

	// Token: 0x04007511 RID: 29969
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}
