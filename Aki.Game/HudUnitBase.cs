using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F1B RID: 7963
public class HudUnitBase : UiPanelBase
{
	// Token: 0x0600F54C RID: 62796 RVA: 0x003B2D88 File Offset: 0x003B0F88
	[NullableContext(1)]
	public UniTask Initialize(string resourceId, bool showAfterCreate, bool needSafeZone)
	{
		HudUnitBase.<Initialize>d__3 <Initialize>d__;
		<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Initialize>d__.<>4__this = this;
		<Initialize>d__.resourceId = resourceId;
		<Initialize>d__.showAfterCreate = showAfterCreate;
		<Initialize>d__.needSafeZone = needSafeZone;
		<Initialize>d__.<>1__state = -1;
		<Initialize>d__.<>t__builder.Start<HudUnitBase.<Initialize>d__3>(ref <Initialize>d__);
		return <Initialize>d__.<>t__builder.Task;
	}

	// Token: 0x0600F54D RID: 62797 RVA: 0x003B2DE3 File Offset: 0x003B0FE3
	public virtual void Tick(float delta)
	{
	}

	// Token: 0x0600F54E RID: 62798 RVA: 0x003B2DE5 File Offset: 0x003B0FE5
	public virtual void AfterTick(float delta)
	{
	}

	// Token: 0x0600F54F RID: 62799 RVA: 0x003B2DE8 File Offset: 0x003B0FE8
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

	// Token: 0x0600F550 RID: 62800 RVA: 0x003B2E29 File Offset: 0x003B1029
	public bool GetVisible()
	{
		return VisibleStateUtil.GetVisible(this.VisibleState);
	}

	// Token: 0x0600F551 RID: 62801 RVA: 0x003B2E36 File Offset: 0x003B1036
	protected override void OnBeforeDestroy()
	{
		if (this.TweenAnimMap != null)
		{
			this.TweenAnimMap.Clear();
		}
	}

	// Token: 0x0600F552 RID: 62802 RVA: 0x003B2E4B File Offset: 0x003B104B
	public void SetAnchorOffset(float x, float y)
	{
		if (this.RootItem == null)
		{
			return;
		}
		this.RootItem.SetAnchorOffsetX(x);
		this.RootItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600F553 RID: 62803 RVA: 0x003B2E70 File Offset: 0x003B1070
	protected void InitTweenAnim(int componentType)
	{
		List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
		TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			list.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
		}
		if (this.TweenAnimMap == null)
		{
			this.TweenAnimMap = new Dictionary<int, ULGUIPlayTweenComponent[]>();
		}
		this.TweenAnimMap[componentType] = list.ToArray();
	}

	// Token: 0x0600F554 RID: 62804 RVA: 0x003B2EEC File Offset: 0x003B10EC
	protected void PlayTweenAnim(int componentType)
	{
		ULGUIPlayTweenComponent[] array;
		this.TweenAnimMap.TryGetValue(componentType, out array);
		if (array != null)
		{
			ULGUIPlayTweenComponent[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Play();
			}
		}
	}

	// Token: 0x0600F555 RID: 62805 RVA: 0x003B2F24 File Offset: 0x003B1124
	protected void StopTweenAnim(int componentType)
	{
		ULGUIPlayTweenComponent[] array;
		this.TweenAnimMap.TryGetValue(componentType, out array);
		if (array != null)
		{
			ULGUIPlayTweenComponent[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Stop();
			}
		}
	}

	// Token: 0x0400716C RID: 29036
	[Nullable(2)]
	public string ResourceId;

	// Token: 0x0400716D RID: 29037
	protected int VisibleState;

	// Token: 0x0400716E RID: 29038
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<int, ULGUIPlayTweenComponent[]> TweenAnimMap;
}
