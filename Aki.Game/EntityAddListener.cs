using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002634 RID: 9780
[NullableContext(1)]
[Nullable(0)]
public class EntityAddListener
{
	// Token: 0x060186BE RID: 100030 RVA: 0x0075FE16 File Offset: 0x0075E016
	public void Init(TCbEntityAddCallback callback, TCbEntityAddFilter filter = null)
	{
		if (this.Inited)
		{
			return;
		}
		this.Inited = true;
		this.CbEntityAdd = callback;
		this.CbFilter = filter;
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnCreateEntity));
	}

	// Token: 0x060186BF RID: 100031 RVA: 0x0075FE52 File Offset: 0x0075E052
	private void OnCreateEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		if (handle == null || !handle.Valid || this.CbEntityAdd == null)
		{
			return;
		}
		if (this.CbFilter != null && !this.CbFilter(handle))
		{
			return;
		}
		this.CbEntityAdd(handle);
	}

	// Token: 0x060186C0 RID: 100032 RVA: 0x0075FE8B File Offset: 0x0075E08B
	public void Clear()
	{
		EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnCreateEntity));
		this.CbEntityAdd = null;
		this.CbFilter = null;
		this.Inited = false;
	}

	// Token: 0x060186C1 RID: 100033 RVA: 0x0075FEC0 File Offset: 0x0075E0C0
	public static TCbDispose ListenMonsterAddOnce(TCbEntityAddCallback callback, int excludeId = 0)
	{
		EntityAddListener listener = new EntityAddListener();
		bool disposed = false;
		listener.Init(delegate(EntityHandle handle)
		{
			if (disposed)
			{
				return;
			}
			if (handle.Id == excludeId)
			{
				return;
			}
			WorldEntity entity = handle.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null || !creatureDataComponent.IsMonster())
			{
				return;
			}
			disposed = true;
			listener.Clear();
			callback(handle);
		}, null);
		return delegate()
		{
			if (disposed)
			{
				return;
			}
			disposed = true;
			listener.Clear();
		};
	}

	// Token: 0x0400D2D1 RID: 53969
	private TCbEntityAddCallback CbEntityAdd;

	// Token: 0x0400D2D2 RID: 53970
	private TCbEntityAddFilter CbFilter;

	// Token: 0x0400D2D3 RID: 53971
	private bool Inited;
}
