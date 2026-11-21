using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.StateApplier
{
	// Token: 0x02005B8F RID: 23439
	[NullableContext(1)]
	[Nullable(0)]
	public class LegacyDaDraggableStateApplier : IDraggableStateApplier
	{
		// Token: 0x06039A65 RID: 236133 RVA: 0x010316A2 File Offset: 0x0102F8A2
		[NullableContext(2)]
		public LegacyDaDraggableStateApplier(string daPath)
		{
			this.DaPath = daPath;
		}

		// Token: 0x06039A66 RID: 236134 RVA: 0x010316B1 File Offset: 0x0102F8B1
		public void Initialize(AActor actor)
		{
		}

		// Token: 0x06039A67 RID: 236135 RVA: 0x010316B3 File Offset: 0x0102F8B3
		public void ApplyState(AActor actor, EDraggableState state)
		{
			if (state == EDraggableState.Selected)
			{
				this.AddSelectionMaterial(actor);
				return;
			}
			this.ClearSelectionMaterial();
		}

		// Token: 0x06039A68 RID: 236136 RVA: 0x010316C7 File Offset: 0x0102F8C7
		public void Dispose(AActor actor)
		{
			this.ClearSelectionMaterial();
		}

		// Token: 0x06039A69 RID: 236137 RVA: 0x010316D0 File Offset: 0x0102F8D0
		private void AddSelectionMaterial(AActor actor)
		{
			this.ClearSelectionMaterial();
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			if (this.DaPath == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[LegacyDaDraggableStateApplier] AddSelectionMaterial: DraggableActorEffectDa is empty";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actor", actor);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ISelectionMatCacheEntry selectionMatCacheEntry = SplineConstrainedDragModel.Instance.GetSelectionMatCacheEntry(this.DaPath);
			ItemMaterialControllerActorData itemMaterialControllerActorData = (selectionMatCacheEntry != null) ? selectionMatCacheEntry.Asset : null;
			if (itemMaterialControllerActorData == null || !itemMaterialControllerActorData.IsValid())
			{
				itemMaterialControllerActorData = ResourceSystem.Instance.Load<ItemMaterialControllerActorData>(this.DaPath, "js_undefined");
				if (itemMaterialControllerActorData == null || !itemMaterialControllerActorData.IsValid())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.LevelPlay;
					ELogAuthor author2 = ELogAuthor.XDW;
					string message2 = "[LegacyDaDraggableStateApplier] AddSelectionMaterial sync load failed";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", this.DaPath);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				if (selectionMatCacheEntry != null)
				{
					selectionMatCacheEntry.Asset = itemMaterialControllerActorData;
				}
			}
			this.CurrentHandle = new int?(ItemMaterialManager.Instance.AddMaterialData(actor, itemMaterialControllerActorData));
		}

		// Token: 0x06039A6A RID: 236138 RVA: 0x010317CC File Offset: 0x0102F9CC
		private void ClearSelectionMaterial()
		{
			int? currentHandle = this.CurrentHandle;
			if (currentHandle == null)
			{
				return;
			}
			ItemMaterialManager.Instance.DisableActorData(this.CurrentHandle.Value);
			this.CurrentHandle = null;
		}

		// Token: 0x0401E6CF RID: 124623
		private int? CurrentHandle;

		// Token: 0x0401E6D0 RID: 124624
		[Nullable(2)]
		private readonly string DaPath;
	}
}
