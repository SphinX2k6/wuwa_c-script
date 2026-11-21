using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013DD RID: 5085
public class HudUnitBase : UiPanelBase
{
	// Token: 0x0600C96B RID: 51563 RVA: 0x003BE874 File Offset: 0x003BCA74
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

	// Token: 0x0600C96C RID: 51564 RVA: 0x003BE8CF File Offset: 0x003BCACF
	public virtual void Tick(float delta)
	{
	}

	// Token: 0x0600C96D RID: 51565 RVA: 0x003BE8D1 File Offset: 0x003BCAD1
	public virtual void AfterTick(float delta)
	{
	}

	// Token: 0x0600C96E RID: 51566 RVA: 0x003BE8D4 File Offset: 0x003BCAD4
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

	// Token: 0x0600C96F RID: 51567 RVA: 0x003BE915 File Offset: 0x003BCB15
	public bool GetVisible()
	{
		return VisibleStateUtil.GetVisible(this.VisibleState);
	}

	// Token: 0x0600C970 RID: 51568 RVA: 0x003BE922 File Offset: 0x003BCB22
	protected override void OnBeforeDestroy()
	{
		if (this.TweenAnimMap != null)
		{
			this.TweenAnimMap.Clear();
		}
	}

	// Token: 0x0600C971 RID: 51569 RVA: 0x003BE937 File Offset: 0x003BCB37
	public void SetAnchorOffset(float x, float y)
	{
		if (this.RootItem == null)
		{
			return;
		}
		this.RootItem.SetAnchorOffsetX(x);
		this.RootItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600C972 RID: 51570 RVA: 0x003BE95C File Offset: 0x003BCB5C
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

	// Token: 0x0600C973 RID: 51571 RVA: 0x003BE9D8 File Offset: 0x003BCBD8
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

	// Token: 0x0600C974 RID: 51572 RVA: 0x003BEA10 File Offset: 0x003BCC10
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

	// Token: 0x0400724D RID: 29261
	[Nullable(2)]
	public string ResourceId;

	// Token: 0x0400724E RID: 29262
	protected int VisibleState;

	// Token: 0x0400724F RID: 29263
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<int, ULGUIPlayTweenComponent[]> TweenAnimMap;
}
