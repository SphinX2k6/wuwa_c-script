using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.StateApplier
{
	// Token: 0x02005B90 RID: 23440
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialParamDraggableStateApplier : IDraggableStateApplier
	{
		// Token: 0x06039A6B RID: 236139 RVA: 0x0103180C File Offset: 0x0102FA0C
		public void Initialize(AActor actor)
		{
			this.CollectStaticMeshComponents(actor);
			this.WriteStateParams(0, 0, 0);
		}

		// Token: 0x06039A6C RID: 236140 RVA: 0x01031820 File Offset: 0x0102FA20
		public void ApplyState(AActor actor, EDraggableState state)
		{
			if (this.CachedStaticMeshComponents.Count == 0)
			{
				this.CollectStaticMeshComponents(actor);
			}
			switch (state)
			{
			case EDraggableState.Selectable:
				this.WriteStateParams(1, 0, 0);
				return;
			case EDraggableState.Hover:
				this.WriteStateParams(0, 1, 0);
				return;
			case EDraggableState.Selected:
				this.WriteStateParams(0, 0, 1);
				return;
			}
			this.WriteStateParams(0, 0, 0);
		}

		// Token: 0x06039A6D RID: 236141 RVA: 0x01031880 File Offset: 0x0102FA80
		public void Dispose(AActor actor)
		{
			if (this.CachedStaticMeshComponents.Count == 0)
			{
				this.CollectStaticMeshComponents(actor);
			}
			this.WriteStateParams(0, 0, 0);
			this.CachedStaticMeshComponents = new List<UStaticMeshComponent>();
		}

		// Token: 0x06039A6E RID: 236142 RVA: 0x010318AC File Offset: 0x0102FAAC
		private void CollectStaticMeshComponents(AActor actor)
		{
			this.CachedStaticMeshComponents = new List<UStaticMeshComponent>();
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
			if (tarray == null || tarray.Num() == 0)
			{
				return;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				UStaticMeshComponent ustaticMeshComponent = tarray.Get(i) as UStaticMeshComponent;
				if (ustaticMeshComponent != null && ustaticMeshComponent.IsValid())
				{
					this.CachedStaticMeshComponents.Add(ustaticMeshComponent);
				}
			}
			if (this.CachedStaticMeshComponents.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[MaterialParamDraggableStateApplier] CollectStaticMeshComponents: 可拖拽Actor无StaticMeshComponent来材质表现";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actor", actor);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06039A6F RID: 236143 RVA: 0x0103195C File Offset: 0x0102FB5C
		private void WriteStateParams(int state1, int state2, int state3)
		{
			foreach (UStaticMeshComponent ustaticMeshComponent in this.CachedStaticMeshComponents)
			{
				if (ustaticMeshComponent != null && ustaticMeshComponent.IsValid())
				{
					ustaticMeshComponent.SetScalarParameterValueOnMaterials(FNameUtil.GetDynamicFName("EnableState1").Value, (float)state1);
					ustaticMeshComponent.SetScalarParameterValueOnMaterials(FNameUtil.GetDynamicFName("EnableState2").Value, (float)state2);
					ustaticMeshComponent.SetScalarParameterValueOnMaterials(FNameUtil.GetDynamicFName("EnableState3").Value, (float)state3);
				}
			}
		}

		// Token: 0x0401E6D1 RID: 124625
		private List<UStaticMeshComponent> CachedStaticMeshComponents = new List<UStaticMeshComponent>();
	}
}
