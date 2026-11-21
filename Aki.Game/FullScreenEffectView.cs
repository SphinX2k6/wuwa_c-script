using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001101 RID: 4353
[NullableContext(1)]
[Nullable(0)]
public class FullScreenEffectView
{
	// Token: 0x0600AE3E RID: 44606 RVA: 0x00336230 File Offset: 0x00334430
	public UniTask Init(string path, int priority)
	{
		FullScreenEffectView.<Init>d__9 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.path = path;
		<Init>d__.priority = priority;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<FullScreenEffectView.<Init>d__9>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE3F RID: 44607 RVA: 0x00336284 File Offset: 0x00334484
	public void SetEffectVisibility(bool visibility, bool eventControl)
	{
		if (eventControl)
		{
			if (visibility)
			{
				this.NiagaraComponentDelayId = TimerSystem.Instance.Delay(new TTimerAction(this.BindEffectEven), 100f, null, null, true, 1f);
			}
			else
			{
				this.UnBindEffectEvent();
			}
		}
		if (this.Visibility != visibility)
		{
			this.RootItem.SetIsUIActive(visibility);
			this.Visibility = visibility;
		}
	}

	// Token: 0x0600AE40 RID: 44608 RVA: 0x003362E4 File Offset: 0x003344E4
	private void SetRootActor(AActor actor)
	{
		UUIItem rootItem = (UUIItem)actor.GetComponentByClass(UUIItem.StaticClass());
		this.RootActor = actor;
		this.RootItem = rootItem;
	}

	// Token: 0x0600AE41 RID: 44609 RVA: 0x00336315 File Offset: 0x00334515
	public static int Compare(FullScreenEffectView a, FullScreenEffectView b)
	{
		return b.Priority - a.Priority;
	}

	// Token: 0x0600AE42 RID: 44610 RVA: 0x00336324 File Offset: 0x00334524
	public void Destroy()
	{
		LguiResourceManager.Instance.CancelLoadPrefab(this.HandleId);
		this.NiagaraSet.Clear();
		ActorSystem.Instance.Put("FullScreenEffectView.Destroy", this.RootActor, null);
	}

	// Token: 0x0600AE43 RID: 44611 RVA: 0x00336358 File Offset: 0x00334558
	private void BindEffectEven(float _)
	{
		this.NiagaraSet.Clear();
	}

	// Token: 0x0600AE44 RID: 44612 RVA: 0x00336365 File Offset: 0x00334565
	private void UnBindEffectEvent()
	{
		if (TimerSystem.Instance.Has(this.NiagaraComponentDelayId))
		{
			TimerSystem.Instance.Remove(this.NiagaraComponentDelayId);
		}
		this.NiagaraSet.Clear();
		this.NiagaraComponentDelayId = null;
	}

	// Token: 0x0600AE45 RID: 44613 RVA: 0x0033639C File Offset: 0x0033459C
	public void DeActive()
	{
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(this.RootActor, UUINiagara.StaticClass(), false);
		for (int i = 0; i < componentsInChildren.Num(); i++)
		{
			UUINiagara uuiniagara = (UUINiagara)componentsInChildren.Get(i);
			if (uuiniagara != null)
			{
				uuiniagara.DeactivateSystem();
			}
		}
	}

	// Token: 0x0600AE46 RID: 44614 RVA: 0x003363E8 File Offset: 0x003345E8
	public bool IsEffectPlay()
	{
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(this.RootActor, UUINiagara.StaticClass(), false);
		for (int i = 0; i < componentsInChildren.Num(); i++)
		{
			if ((UUINiagara)componentsInChildren.Get(i) != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04006425 RID: 25637
	[Nullable(2)]
	protected UUIItem RootItem;

	// Token: 0x04006426 RID: 25638
	[Nullable(2)]
	protected AActor RootActor;

	// Token: 0x04006427 RID: 25639
	public int Priority;

	// Token: 0x04006428 RID: 25640
	public string Path = string.Empty;

	// Token: 0x04006429 RID: 25641
	private bool Visibility = true;

	// Token: 0x0400642A RID: 25642
	[Nullable(2)]
	private TimerHandle NiagaraComponentDelayId;

	// Token: 0x0400642B RID: 25643
	private readonly HashSet<int> NiagaraSet = new HashSet<int>();

	// Token: 0x0400642C RID: 25644
	private int HandleId;

	// Token: 0x0400642D RID: 25645
	private const int DELAY_TIME = 100;
}
