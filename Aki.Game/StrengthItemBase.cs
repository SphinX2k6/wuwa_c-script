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

// Token: 0x02001F64 RID: 8036
[NullableContext(1)]
[Nullable(0)]
public class StrengthItemBase : UiPanelBase
{
	// Token: 0x0600F943 RID: 63811 RVA: 0x003C65EC File Offset: 0x003C47EC
	public void Init(UUIItem parentItem, [Nullable(2)] BattleUiRoleData roleData, Action<bool> uiVisibleChanged)
	{
		this.RoleData = roleData;
		this.UiVisibleChanged = uiVisibleChanged;
		this.TargetActive = false;
		this.InitAsync(parentItem).ContinueWith(delegate()
		{
		});
	}

	// Token: 0x0600F944 RID: 63812 RVA: 0x003C663C File Offset: 0x003C483C
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

	// Token: 0x0600F945 RID: 63813 RVA: 0x003C6687 File Offset: 0x003C4887
	protected virtual string GetResourceId()
	{
		return "UiItem_Endurance";
	}

	// Token: 0x0600F946 RID: 63814 RVA: 0x003C668E File Offset: 0x003C488E
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

	// Token: 0x0600F947 RID: 63815 RVA: 0x003C66B9 File Offset: 0x003C48B9
	protected override void OnBeforeShow()
	{
		Action<bool> uiVisibleChanged = this.UiVisibleChanged;
		if (uiVisibleChanged == null)
		{
			return;
		}
		uiVisibleChanged(true);
	}

	// Token: 0x0600F948 RID: 63816 RVA: 0x003C66CC File Offset: 0x003C48CC
	protected override void OnAfterHide()
	{
		Action<bool> uiVisibleChanged = this.UiVisibleChanged;
		if (uiVisibleChanged == null)
		{
			return;
		}
		uiVisibleChanged(false);
	}

	// Token: 0x0600F949 RID: 63817 RVA: 0x003C66DF File Offset: 0x003C48DF
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEvents();
		this.RefreshRoleData(null);
		this.IsAfterStart = false;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F94A RID: 63818 RVA: 0x003C66FB File Offset: 0x003C48FB
	public override void SetActive(bool visibility)
	{
		if (this.TargetActive == visibility)
		{
			return;
		}
		this.TargetActive = visibility;
		base.SetActive(visibility);
	}

	// Token: 0x0600F94B RID: 63819 RVA: 0x003C6715 File Offset: 0x003C4915
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

	// Token: 0x0600F94C RID: 63820 RVA: 0x003C674F File Offset: 0x003C494F
	public virtual void Tick(float delta)
	{
	}

	// Token: 0x0600F94D RID: 63821 RVA: 0x003C6751 File Offset: 0x003C4951
	public bool GetUiVisible()
	{
		return base.IsShowing || base.IsShow;
	}

	// Token: 0x0600F94E RID: 63822 RVA: 0x003C6763 File Offset: 0x003C4963
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x0600F94F RID: 63823 RVA: 0x003C6765 File Offset: 0x003C4965
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600F950 RID: 63824 RVA: 0x003C6768 File Offset: 0x003C4968
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

	// Token: 0x0600F951 RID: 63825 RVA: 0x003C67FE File Offset: 0x003C49FE
	protected virtual void OnEnableByHighPriority(bool b)
	{
	}

	// Token: 0x0600F952 RID: 63826 RVA: 0x003C6800 File Offset: 0x003C4A00
	protected virtual void OnAddEntityEvents()
	{
	}

	// Token: 0x0600F953 RID: 63827 RVA: 0x003C6802 File Offset: 0x003C4A02
	protected virtual void OnRemoveEntityEvents()
	{
	}

	// Token: 0x0600F954 RID: 63828 RVA: 0x003C6804 File Offset: 0x003C4A04
	protected virtual void OnRefreshRoleData()
	{
	}

	// Token: 0x0600F955 RID: 63829 RVA: 0x003C6808 File Offset: 0x003C4A08
	protected void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int? tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(tagId, new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), StrengthItemBase.ListenTagStat);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600F956 RID: 63830 RVA: 0x003C6840 File Offset: 0x003C4A40
	protected void ClearTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0600F957 RID: 63831 RVA: 0x003C689C File Offset: 0x003C4A9C
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

	// Token: 0x0600F958 RID: 63832 RVA: 0x003C68DC File Offset: 0x003C4ADC
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

	// Token: 0x0600F959 RID: 63833 RVA: 0x003C691C File Offset: 0x003C4B1C
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

	// Token: 0x0600F95A RID: 63834 RVA: 0x003C69A8 File Offset: 0x003C4BA8
	protected void InitTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600F95B RID: 63835 RVA: 0x003C69BE File Offset: 0x003C4BBE
	protected void PlayTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600F95C RID: 63836 RVA: 0x003C69CC File Offset: 0x003C4BCC
	protected void StopTweenAnim(int componentType)
	{
		this.TweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x04007428 RID: 29736
	[StaticVariableRuleIgnore]
	private static readonly Stat ListenTagStat = Stat.Create("[StrengthItem]ListenTag", "", "");

	// Token: 0x04007429 RID: 29737
	protected bool IsAfterStart;

	// Token: 0x0400742A RID: 29738
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x0400742B RID: 29739
	[Nullable(2)]
	protected Action<bool> UiVisibleChanged;

	// Token: 0x0400742C RID: 29740
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400742D RID: 29741
	protected readonly Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

	// Token: 0x0400742E RID: 29742
	protected bool TargetActive;

	// Token: 0x0400742F RID: 29743
	protected bool EnableByHighPriority = true;

	// Token: 0x04007430 RID: 29744
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}
