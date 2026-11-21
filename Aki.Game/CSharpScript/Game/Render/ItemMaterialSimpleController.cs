using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003512 RID: 13586
	[NullableContext(2)]
	[Nullable(0)]
	public class ItemMaterialSimpleController : ItemMaterialControllerBase
	{
		// Token: 0x0602296E RID: 141678 RVA: 0x009D64FF File Offset: 0x009D46FF
		[NullableContext(1)]
		public ItemMaterialSimpleController(AActor actor)
		{
			this.Actor = actor;
			this.ForEachComponent(this.Actor, delegate(UPrimitiveComponent component)
			{
				if (this.CheckMaterial(component))
				{
					this.CachedComponentMaterials(component);
				}
			});
		}

		// Token: 0x0602296F RID: 141679 RVA: 0x009D6531 File Offset: 0x009D4731
		public AActor GetActor()
		{
			if (!this.Actor.IsValid())
			{
				return null;
			}
			return this.Actor;
		}

		// Token: 0x06022970 RID: 141680 RVA: 0x009D6548 File Offset: 0x009D4748
		[NullableContext(1)]
		public void ForEachComponent([Nullable(2)] AActor actor, Action<UPrimitiveComponent> exec)
		{
			if (actor != null && actor.IsValid())
			{
				TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UPrimitiveComponent.StaticClass());
				int num = tarray.Num();
				for (int i = 0; i < num; i++)
				{
					UPrimitiveComponent uprimitiveComponent = tarray.Get(i) as UPrimitiveComponent;
					if (uprimitiveComponent != null)
					{
						exec(uprimitiveComponent);
					}
				}
			}
		}

		// Token: 0x06022971 RID: 141681 RVA: 0x009D659C File Offset: 0x009D479C
		public bool CheckMaterial(UPrimitiveComponent component)
		{
			if (component == null || !component.IsValid())
			{
				return false;
			}
			BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(component);
			if (worldType == BP_EWorldType.Editor || worldType == BP_EWorldType.EditorPreview)
			{
				int numMaterials = component.GetNumMaterials();
				for (int i = 0; i < numMaterials; i++)
				{
					UMaterialInterface material = component.GetMaterial(i);
					if (material != null && !UKuroRenderingRuntimeBPPluginBPLibrary.MaterialHasParameter_EditorOnly(material, RenderConfig.E_Action_UseScanning.ToString()))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06022972 RID: 141682 RVA: 0x009D6600 File Offset: 0x009D4800
		public void CachedComponentMaterials(UPrimitiveComponent component)
		{
			if (component == null || !component.IsValid())
			{
				return;
			}
			int num = this.CachedMaterials.FindIndex(([Nullable(new byte[]
			{
				1,
				1,
				1,
				1,
				1,
				2
			})] Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> cached) => cached.Item1 == component);
			if (num < 0)
			{
				Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> item = Tuple.Create<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>>(component, new List<UMaterialInterface>(), new List<UMaterialInstanceDynamic>());
				this.CachedMaterials.Add(item);
				num = this.CachedMaterials.Count - 1;
				int numMaterials = component.GetNumMaterials();
				for (int i = 0; i < numMaterials; i++)
				{
					UMaterialInterface material = component.GetMaterial(i);
					UMaterialInstanceDynamic umaterialInstanceDynamic = null;
					this.CachedMaterials[num].Item2.Add(material);
					if (material == null)
					{
						this.CachedMaterials[num].Item3.Add(null);
					}
					else
					{
						UMaterialInstanceDynamic umaterialInstanceDynamic2 = material as UMaterialInstanceDynamic;
						if (umaterialInstanceDynamic2 != null)
						{
							umaterialInstanceDynamic = umaterialInstanceDynamic2;
							this.CachedMaterials[num].Item3.Add(umaterialInstanceDynamic);
						}
						else
						{
							umaterialInstanceDynamic = component.CreateDynamicMaterialInstance(i, material, default(FName));
							this.CachedMaterials[num].Item3.Add(umaterialInstanceDynamic);
						}
					}
					if (umaterialInstanceDynamic == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Render;
						ELogAuthor author = ELogAuthor.LJY;
						string message = "材质控制器 - 使用了空材质";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", component.GetOwner());
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
		}

		// Token: 0x06022973 RID: 141683 RVA: 0x009D6780 File Offset: 0x009D4980
		public void UpdateParameters()
		{
			foreach (Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> tuple in this.CachedMaterials)
			{
				if (tuple.Item3 != null)
				{
					foreach (UMaterialInstanceDynamic umaterialInstanceDynamic in tuple.Item3)
					{
						if (umaterialInstanceDynamic != null && umaterialInstanceDynamic.IsValid() && this.ScalarParameterValue != null)
						{
							foreach (FName fname in this.ScalarParameterValue.Keys)
							{
								umaterialInstanceDynamic.SetScalarParameterValue(fname, this.ScalarParameterValue[fname]);
							}
						}
					}
				}
			}
			foreach (Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> tuple2 in this.CachedMaterials)
			{
				if (tuple2.Item3 != null)
				{
					foreach (UMaterialInstanceDynamic umaterialInstanceDynamic2 in tuple2.Item3)
					{
						if (umaterialInstanceDynamic2 != null && umaterialInstanceDynamic2.IsValid() && this.VectorParameterValue != null)
						{
							foreach (FName fname2 in this.VectorParameterValue.Keys)
							{
								umaterialInstanceDynamic2.SetVectorParameterValue(fname2, this.VectorParameterValue[fname2]);
							}
						}
					}
				}
			}
		}

		// Token: 0x04013286 RID: 78470
		[Nullable(1)]
		protected AActor Actor;

		// Token: 0x04013287 RID: 78471
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			2
		})]
		protected List<Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>>> CachedMaterials = new List<Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>>>();

		// Token: 0x04013288 RID: 78472
		public Dictionary<FName, float> ScalarParameterValue;

		// Token: 0x04013289 RID: 78473
		public Dictionary<FName, FLinearColor> VectorParameterValue;
	}
}
