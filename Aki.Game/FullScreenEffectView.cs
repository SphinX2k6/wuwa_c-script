using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C42 RID: 7234
[NullableContext(1)]
[Nullable(0)]
public class FullScreenEffectView
{
	// Token: 0x0600DA28 RID: 55848 RVA: 0x0032AE30 File Offset: 0x00329030
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

	// Token: 0x0600DA29 RID: 55849 RVA: 0x0032AE84 File Offset: 0x00329084
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

	// Token: 0x0600DA2A RID: 55850 RVA: 0x0032AEE4 File Offset: 0x003290E4
	private void SetRootActor(AActor actor)
	{
		UUIItem rootItem = (UUIItem)actor.GetComponentByClass(UUIItem.StaticClass());
		this.RootActor = actor;
		this.RootItem = rootItem;
	}

	// Token: 0x0600DA2B RID: 55851 RVA: 0x0032AF15 File Offset: 0x00329115
	public static int Compare(FullScreenEffectView a, FullScreenEffectView b)
	{
		return b.Priority - a.Priority;
	}

	// Token: 0x0600DA2C RID: 55852 RVA: 0x0032AF24 File Offset: 0x00329124
	public void Destroy()
	{
		LguiResourceManager.Instance.CancelLoadPrefab(this.HandleId);
		this.NiagaraSet.Clear();
		ActorSystem.Instance.Put("FullScreenEffectView.Destroy", this.RootActor, null);
	}

	// Token: 0x0600DA2D RID: 55853 RVA: 0x0032AF58 File Offset: 0x00329158
	private void BindEffectEven(float _)
	{
		this.NiagaraSet.Clear();
	}

	// Token: 0x0600DA2E RID: 55854 RVA: 0x0032AF65 File Offset: 0x00329165
	private void UnBindEffectEvent()
	{
		if (TimerSystem.Instance.Has(this.NiagaraComponentDelayId))
		{
			TimerSystem.Instance.Remove(this.NiagaraComponentDelayId);
		}
		this.NiagaraSet.Clear();
		this.NiagaraComponentDelayId = null;
	}

	// Token: 0x0600DA2F RID: 55855 RVA: 0x0032AF9C File Offset: 0x0032919C
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

	// Token: 0x0600DA30 RID: 55856 RVA: 0x0032AFE8 File Offset: 0x003291E8
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

	// Token: 0x04006353 RID: 25427
	[Nullable(2)]
	protected UUIItem RootItem;

	// Token: 0x04006354 RID: 25428
	[Nullable(2)]
	protected AActor RootActor;

	// Token: 0x04006355 RID: 25429
	public int Priority;

	// Token: 0x04006356 RID: 25430
	public string Path = string.Empty;

	// Token: 0x04006357 RID: 25431
	private bool Visibility = true;

	// Token: 0x04006358 RID: 25432
	[Nullable(2)]
	private TimerHandle NiagaraComponentDelayId;

	// Token: 0x04006359 RID: 25433
	private readonly HashSet<int> NiagaraSet = new HashSet<int>();

	// Token: 0x0400635A RID: 25434
	private int HandleId;

	// Token: 0x0400635B RID: 25435
	private const int DELAY_TIME = 100;
}
