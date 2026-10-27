using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002CD5 RID: 11477
[NullableContext(1)]
[Nullable(0)]
public abstract class SyncGridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, ISyncGridProxy<TData>, ISyncGridProxy
{
	// Token: 0x17002076 RID: 8310
	// (get) Token: 0x0601813B RID: 98619 RVA: 0x0061F27F File Offset: 0x0061D47F
	// (set) Token: 0x0601813C RID: 98620 RVA: 0x0061F287 File Offset: 0x0061D487
	public int GridIndex { get; set; }

	// Token: 0x0601813D RID: 98621 RVA: 0x0061F290 File Offset: 0x0061D490
	public virtual void Refresh(TData data)
	{
	}

	// Token: 0x0601813E RID: 98622 RVA: 0x0061F292 File Offset: 0x0061D492
	public virtual void Clear()
	{
	}

	// Token: 0x0601813F RID: 98623 RVA: 0x0061F294 File Offset: 0x0061D494
	public void CreateByActor(AActor actor)
	{
		base.CreateByActor(actor, null);
	}

	// Token: 0x06018140 RID: 98624 RVA: 0x0061F29E File Offset: 0x0061D49E
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x06018141 RID: 98625 RVA: 0x0061F2A8 File Offset: 0x0061D4A8
	protected override UniTask OnCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06018142 RID: 98626 RVA: 0x0061F2AF File Offset: 0x0061D4AF
	protected override UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06018143 RID: 98627 RVA: 0x0061F2B6 File Offset: 0x0061D4B6
	void ISyncGridProxy.Refresh(object data)
	{
		this.Refresh((TData)((object)data));
	}
}
