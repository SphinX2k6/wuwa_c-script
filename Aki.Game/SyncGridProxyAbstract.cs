using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200222E RID: 8750
[NullableContext(1)]
[Nullable(0)]
public abstract class SyncGridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, ISyncGridProxy<TData>, ISyncGridProxy
{
	// Token: 0x170020C9 RID: 8393
	// (get) Token: 0x060159B8 RID: 88504 RVA: 0x00644E37 File Offset: 0x00643037
	// (set) Token: 0x060159B9 RID: 88505 RVA: 0x00644E3F File Offset: 0x0064303F
	public int GridIndex { get; set; }

	// Token: 0x060159BA RID: 88506 RVA: 0x00644E48 File Offset: 0x00643048
	public virtual void Refresh(TData data)
	{
	}

	// Token: 0x060159BB RID: 88507 RVA: 0x00644E4A File Offset: 0x0064304A
	public virtual void Clear()
	{
	}

	// Token: 0x060159BC RID: 88508 RVA: 0x00644E4C File Offset: 0x0064304C
	public void CreateByActor(AActor actor)
	{
		base.CreateByActor(actor, null);
	}

	// Token: 0x060159BD RID: 88509 RVA: 0x00644E56 File Offset: 0x00643056
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x060159BE RID: 88510 RVA: 0x00644E60 File Offset: 0x00643060
	protected override UniTask OnCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x060159BF RID: 88511 RVA: 0x00644E67 File Offset: 0x00643067
	protected override UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x060159C0 RID: 88512 RVA: 0x00644E6E File Offset: 0x0064306E
	void ISyncGridProxy.Refresh(object data)
	{
		this.Refresh((TData)((object)data));
	}
}
