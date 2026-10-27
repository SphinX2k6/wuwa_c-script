using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.StateApplier
{
	// Token: 0x02006A32 RID: 27186
	[NullableContext(1)]
	[Nullable(0)]
	public class LegacyDaDraggableStateApplier : IDraggableStateApplier
	{
		// Token: 0x06043A17 RID: 277015 RVA: 0x0108CE9A File Offset: 0x0108B09A
		[NullableContext(2)]
		public LegacyDaDraggableStateApplier(string daPath)
		{
			this.DaPath = daPath;
		}

		// Token: 0x06043A18 RID: 277016 RVA: 0x0108CEA9 File Offset: 0x0108B0A9
		public void Initialize(AActor actor)
		{
		}

		// Token: 0x06043A19 RID: 277017 RVA: 0x0108CEAB File Offset: 0x0108B0AB
		public void ApplyState(AActor actor, EDraggableState state)
		{
			if (state == EDraggableState.Selected)
			{
				this.AddSelectionMaterial(actor);
				return;
			}
			this.ClearSelectionMaterial();
		}

		// Token: 0x06043A1A RID: 277018 RVA: 0x0108CEBF File Offset: 0x0108B0BF
		public void Dispose(AActor actor)
		{
			this.ClearSelectionMaterial();
		}

		// Token: 0x06043A1B RID: 277019 RVA: 0x0108CEC8 File Offset: 0x0108B0C8
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

		// Token: 0x06043A1C RID: 277020 RVA: 0x0108CFC4 File Offset: 0x0108B1C4
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

		// Token: 0x040234DD RID: 144605
		private int? CurrentHandle;

		// Token: 0x040234DE RID: 144606
		[Nullable(2)]
		private readonly string DaPath;
	}
}
