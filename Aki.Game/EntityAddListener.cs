using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020030DC RID: 12508
[NullableContext(1)]
[Nullable(0)]
public class EntityAddListener
{
	// Token: 0x0601ACA2 RID: 109730 RVA: 0x0073A3DA File Offset: 0x007385DA
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

	// Token: 0x0601ACA3 RID: 109731 RVA: 0x0073A416 File Offset: 0x00738616
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

	// Token: 0x0601ACA4 RID: 109732 RVA: 0x0073A44F File Offset: 0x0073864F
	public void Clear()
	{
		EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnCreateEntity));
		this.CbEntityAdd = null;
		this.CbFilter = null;
		this.Inited = false;
	}

	// Token: 0x0601ACA5 RID: 109733 RVA: 0x0073A484 File Offset: 0x00738684
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

	// Token: 0x0400CEE1 RID: 52961
	private TCbEntityAddCallback CbEntityAdd;

	// Token: 0x0400CEE2 RID: 52962
	private TCbEntityAddFilter CbFilter;

	// Token: 0x0400CEE3 RID: 52963
	private bool Inited;
}
