using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003513 RID: 13587
	[NullableContext(2)]
	[Nullable(0)]
	public class ItemMaterialActorController : ItemMaterialControllerBase
	{
		// Token: 0x06022975 RID: 141685 RVA: 0x009D698E File Offset: 0x009D4B8E
		public bool IsValid()
		{
			return this.LifeTimeController != null && this.Actor.IsValid() && this.Data.IsValid();
		}

		// Token: 0x06022976 RID: 141686 RVA: 0x009D69B4 File Offset: 0x009D4BB4
		[NullableContext(1)]
		public ItemMaterialActorController(AActor actor, ItemMaterialControllerActorData data)
		{
			this.LifeTimeController = new EffectLifeTimeController(data.StartTime, data.LoopTime, data.EndTime, EEffectLifeTimeType.Auto, new Action(this.Destroy), null, 0f, 1f);
			this.Actor = actor;
			this.Data = data;
			this.ForEachComponent(this.Actor, delegate(UPrimitiveComponent component)
			{
				if (this.CheckMaterial(component))
				{
					this.CachedComponentMaterials(component);
				}
			});
			this.ForEachDecalComponent(this.Actor, delegate(UDecalComponent decalcomponent)
			{
				if (this.CheckDecalMaterial(decalcomponent))
				{
					this.CachedDecalComponentMaterials(decalcomponent);
				}
			});
			this.CollectParameter();
			this.Play();
		}

		// Token: 0x06022977 RID: 141687 RVA: 0x009D6A67 File Offset: 0x009D4C67
		public AActor GetActor()
		{
			if (!this.Actor.IsValid())
			{
				return null;
			}
			return this.Actor;
		}

		// Token: 0x06022978 RID: 141688 RVA: 0x009D6A7E File Offset: 0x009D4C7E
		public ItemMaterialControllerActorData GetData()
		{
			if (!this.Data.IsValid())
			{
				return null;
			}
			return this.Data;
		}

		// Token: 0x06022979 RID: 141689 RVA: 0x009D6A95 File Offset: 0x009D4C95
		public EffectLifeTimeController GetLifeTimeController()
		{
			return this.LifeTimeController;
		}

		// Token: 0x0602297A RID: 141690 RVA: 0x009D6AA0 File Offset: 0x009D4CA0
		public void CollectParameter()
		{
			RenderStats.Init();
			this.ModelParameters = new EffectMaterialParameters(null, null);
			ItemMaterialControllerActorData data = this.Data;
			if (data != null && data.EnableBaseColorScale)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseBaseColorScale, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_BaseColorScale, this.Data.BaseColorScale);
			}
			ItemMaterialControllerActorData data2 = this.Data;
			if (data2 != null && data2.EnableAddEmissionColor)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseEmissionColor, 1f);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_EmissionColor, this.Data.AddEmissionColor);
			}
			ItemMaterialControllerActorData data3 = this.Data;
			if (data3 != null && data3.EnableRimLight)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseRimLight, 1f);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_RimLightColor, this.Data.RimLightColor);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_RimPower, this.Data.RimPower);
			}
			ItemMaterialControllerActorData data4 = this.Data;
			if (data4 != null && data4.EnableEmissionChange)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseEmissionChange, 1f);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_EmissionLightColorChangeColor, this.Data.EmissionLightColorChangeColor);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_EmissionLightColorChangeStrength, this.Data.EmissionLightColorChangeStrength);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_EmissionLightColorChangeProgress, this.Data.EmissionLightColorChangeProgress);
			}
			ItemMaterialControllerActorData data5 = this.Data;
			if (data5 != null && data5.EnableDissolve)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseDissolve, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_DissolveProgress, this.Data.DissolveProgress);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_DissolveAdjustment, this.Data.DissolveAdjustment);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_DissolveEdageWidth, this.Data.DissolveEdageWidth);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_DissolveEdageColor, this.Data.DissolveEdageColor);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_DissolveEdageStrength, this.Data.DissolveEdageStrength);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_DissolveTex_S_O, this.Data.DissolveTexScaleOffset);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_DissolveTexSpeed, this.Data.DissolveTexSpeed);
				switch (this.Data.DissolveUv)
				{
				case ECharacterControllerUVSwitch.UV1:
					this.ModelParameters.CollectLinearColorConst(RenderConfig.E_Tex_DissolveTexUVSwitch, new FLinearColor(1f, 0f, 0f, 0f));
					break;
				case ECharacterControllerUVSwitch.UV2:
					this.ModelParameters.CollectLinearColorConst(RenderConfig.E_Tex_DissolveTexUVSwitch, new FLinearColor(0f, 1f, 0f, 0f));
					break;
				case ECharacterControllerUVSwitch.UV3:
					this.ModelParameters.CollectLinearColorConst(RenderConfig.E_Tex_DissolveTexUVSwitch, new FLinearColor(0f, 0f, 1f, 0f));
					break;
				case ECharacterControllerUVSwitch.UV4:
					this.ModelParameters.CollectLinearColorConst(RenderConfig.E_Tex_DissolveTexUVSwitch, new FLinearColor(0f, 0f, 0f, 1f));
					break;
				}
			}
			ItemMaterialControllerActorData data6 = this.Data;
			if (data6 != null && data6.EnableScanning)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseScanning, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_ScanningOutlineMixNoiseStrength, this.Data.ScanningOutlineMixNoiseStrength);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_ScanningOutlineStrength, this.Data.ScanningOutlineStrength);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_ScanningOutlineColor, this.Data.ScanningOutlineColor);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_ScanningTex_S_O, this.Data.ScanningOutlineTexScaleOffset);
			}
			ItemMaterialControllerActorData data7 = this.Data;
			if (data7 != null && data7.EnablePivotPainterWorldPositionOffset)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UsePivotPainterWorldPositionOffset, 1f);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_PivotPainterTransform, this.Data.PivotPainterTransform);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_PivotPainter_FloatingThreshold, this.Data.FloatingThreshold);
			}
			ItemMaterialControllerActorData data8 = this.Data;
			if (data8 != null && data8.EnableWorldPositionOffset)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseWPO, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_VertexAnim_TimeDebug, this.Data.VertexAnimTimeDebug);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_VertexAnim_Frame, this.Data.VertexAnimFrame);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_SimpleWPO_Normal, this.Data.WorldPositionOffsetNormal);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_SimpleWPO_Offset, this.Data.WorldPositionOffsetOffset);
			}
			ItemMaterialControllerActorData data9 = this.Data;
			if (data9 != null && data9.DisableFoliageEffect)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_DisableFoliageEffect, 0f);
			}
			ItemMaterialControllerActorData data10 = this.Data;
			if (data10 != null && data10.EnableFoliageEffect)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_DisableFoliageEffect, 1f);
			}
			ItemMaterialControllerActorData data11 = this.Data;
			if (data11 != null && data11.UseRimlightColorSpecil)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseRimlightColorSpecil, 1f);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_RimLightColorSpecil, this.Data.RimLightColorSpecil);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_RimlightColorStrength, this.Data.RimlightColorStrength);
			}
			ItemMaterialControllerActorData data12 = this.Data;
			if (data12 != null && data12.UseEmissionTex)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseEmissionTex, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_EmissionTexStrength, this.Data.EmissionTexStrength);
			}
			ItemMaterialControllerActorData data13 = this.Data;
			if (((data13 != null) ? data13.SimpleUseFlow : null) != null)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_Simple_UseFlow, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_Simple_Uspeed, this.Data.SimpleUspeed);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_Simple_Vspeed, this.Data.SimpleVspeed);
			}
			ItemMaterialControllerActorData data14 = this.Data;
			if (data14 != null && data14.EnableQuanXiPinTu)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseQuanXiPinTu, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_TransparencyQuanXiPinTu, this.Data.TransparencyQuanXiPinTu);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_TransparentColorQuanXiPinTu, this.Data.TransparentColorQuanXiPinTu);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_OpaqueColorQuanXiPinTu, this.Data.OpaqueColorQuanXiPinTu);
			}
			ItemMaterialControllerActorData data15 = this.Data;
			if (data15 != null && data15.EnableQuanXiFengSuo)
			{
				this.ModelParameters.CollectFloatConst(RenderConfig.E_Action_UseQuanXiFengSuo, 1f);
				this.ModelParameters.CollectFloatCurve(RenderConfig.E_Action_TransparencyQuanXiFengSuo, this.Data.TransparencyQuanXiFengSuo);
				this.ModelParameters.CollectLinearColorCurve(RenderConfig.E_Action_TransparentColorQuanXiFengSuo, this.Data.TransparentColorQuanXiFengSuo);
			}
			this.UpdateCustomCurvePar();
		}

		// Token: 0x0602297B RID: 141691 RVA: 0x009D71A4 File Offset: 0x009D53A4
		public void UpdateCustomCurvePar()
		{
			ItemMaterialControllerActorData data = this.Data;
			if (((data != null) ? data.CustomScalarParMap : null) != null)
			{
				TMap<FName, FKuroCurveFloat> customScalarParMap = this.Data.CustomScalarParMap;
				for (int i = customScalarParMap.Num() - 1; i >= 0; i--)
				{
					FName key = customScalarParMap.GetKey(i);
					FKuroCurveFloat fkuroCurveFloat = customScalarParMap.Get(key);
					if (fkuroCurveFloat != null)
					{
						EffectMaterialParameters modelParameters = this.ModelParameters;
						if (modelParameters != null)
						{
							modelParameters.CollectFloatCurve(key, fkuroCurveFloat);
						}
					}
				}
			}
			ItemMaterialControllerActorData data2 = this.Data;
			if (((data2 != null) ? data2.CustomColorParMap : null) != null)
			{
				TMap<FName, FKuroCurveLinearColor> customColorParMap = this.Data.CustomColorParMap;
				for (int j = customColorParMap.Num() - 1; j >= 0; j--)
				{
					FName key2 = customColorParMap.GetKey(j);
					FKuroCurveLinearColor fkuroCurveLinearColor = customColorParMap.Get(key2);
					if (fkuroCurveLinearColor != null)
					{
						EffectMaterialParameters modelParameters2 = this.ModelParameters;
						if (modelParameters2 != null)
						{
							modelParameters2.CollectLinearColorCurve(key2, fkuroCurveLinearColor);
						}
					}
				}
			}
		}

		// Token: 0x0602297C RID: 141692 RVA: 0x009D7280 File Offset: 0x009D5480
		public void ApplyCustomTexPar()
		{
			ItemMaterialControllerActorData data = this.Data;
			if (((data != null) ? data.CustomTexParMap : null) == null)
			{
				return;
			}
			bool revertCustomTexParOnDestroy = this.Data.RevertCustomTexParOnDestroy;
			foreach (KeyValuePair<FName, UTexture> keyValuePair in this.Data.CustomTexParMap)
			{
				FName key = keyValuePair.Key;
				UTexture value = keyValuePair.Value;
				if (value != null && value.IsValid())
				{
					foreach (Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> tuple in this.CachedMaterials)
					{
						foreach (UMaterialInstanceDynamic umaterialInstanceDynamic in tuple.Item3)
						{
							if (umaterialInstanceDynamic != null && umaterialInstanceDynamic.IsValid())
							{
								if (revertCustomTexParOnDestroy)
								{
									this.CachedOriginTexPar.Add(Tuple.Create<UMaterialInstanceDynamic, FName, UTexture>(umaterialInstanceDynamic, key, umaterialInstanceDynamic.K2_GetTextureParameterValue(key)));
								}
								umaterialInstanceDynamic.SetTextureParameterValue(key, value);
							}
						}
					}
					foreach (Tuple<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic> tuple2 in this.CachedDecalMaterials)
					{
						UMaterialInstanceDynamic item = tuple2.Item3;
						if (item != null && item.IsValid())
						{
							if (revertCustomTexParOnDestroy)
							{
								this.CachedOriginTexPar.Add(Tuple.Create<UMaterialInstanceDynamic, FName, UTexture>(item, key, item.K2_GetTextureParameterValue(key)));
							}
							item.SetTextureParameterValue(key, value);
						}
					}
				}
			}
		}

		// Token: 0x0602297D RID: 141693 RVA: 0x009D7470 File Offset: 0x009D5670
		public void RevertCustomTexPar()
		{
			for (int i = this.CachedOriginTexPar.Count - 1; i >= 0; i--)
			{
				Tuple<UMaterialInstanceDynamic, FName, UTexture> tuple = this.CachedOriginTexPar[i];
				if (tuple.Item1.IsValid() && tuple.Item3 != null && tuple.Item3.IsValid())
				{
					tuple.Item1.SetTextureParameterValue(tuple.Item2, tuple.Item3);
				}
			}
			this.CachedOriginTexPar.Clear();
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x009D74E8 File Offset: 0x009D56E8
		public void UpdateParameters(bool forceUpdate)
		{
			if (this.LifeTimeController == null)
			{
				return;
			}
			foreach (Tuple<UPrimitiveComponent, List<UMaterialInterface>, List<UMaterialInstanceDynamic>> tuple in this.CachedMaterials)
			{
				if (tuple.Item3 != null)
				{
					foreach (UMaterialInstanceDynamic umaterialInstanceDynamic in tuple.Item3)
					{
						if (umaterialInstanceDynamic != null && umaterialInstanceDynamic.IsValid() && this.ModelParameters != null)
						{
							this.ModelParameters.Apply(umaterialInstanceDynamic, this.LifeTimeController.PassTime, forceUpdate);
						}
					}
				}
			}
			foreach (Tuple<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic> tuple2 in this.CachedDecalMaterials)
			{
				if (tuple2.Item3 != null && this.ModelParameters != null)
				{
					this.ModelParameters.Apply(tuple2.Item3, this.LifeTimeController.PassTime, forceUpdate);
				}
			}
		}

		// Token: 0x0602297F RID: 141695 RVA: 0x009D7618 File Offset: 0x009D5818
		public void Play()
		{
			EffectLifeTimeController lifeTimeController = this.LifeTimeController;
			if (lifeTimeController != null)
			{
				lifeTimeController.Play();
			}
			this.ApplyCustomTexPar();
			this.UpdateParameters(true);
		}

		// Token: 0x06022980 RID: 141696 RVA: 0x009D7638 File Offset: 0x009D5838
		public void Update(float deltaSecond)
		{
			if (!this.IsValid())
			{
				return;
			}
			EffectLifeTimeController lifeTimeController = this.LifeTimeController;
			if (lifeTimeController != null)
			{
				lifeTimeController.Update(deltaSecond);
			}
			this.UpdateParameters(false);
		}

		// Token: 0x06022981 RID: 141697 RVA: 0x009D765C File Offset: 0x009D585C
		public void Destroy()
		{
			try
			{
				EffectLifeTimeController lifeTimeController = this.LifeTimeController;
				if (lifeTimeController != null && lifeTimeController.IsFinish && this.IsValid() && UKismetSystemLibrary.GetPathName(this.Data) == "/Game/Aki/Effect/MaterialController/ItemMaterial/3_7_MSTL/DA_Fx_3_7_MSTL_DengLong.DA_Fx_3_7_MSTL_DengLong")
				{
					this.LifeTimeController.JumpToEnd();
					this.UpdateParameters(false);
				}
			}
			finally
			{
				this.RevertCustomTexPar();
				this.LifeTimeController = null;
			}
		}

		// Token: 0x06022982 RID: 141698 RVA: 0x009D76D0 File Offset: 0x009D58D0
		public void Stop(bool immediately = false)
		{
			EffectLifeTimeController lifeTimeController = this.LifeTimeController;
			if (lifeTimeController == null)
			{
				return;
			}
			lifeTimeController.Stop(immediately);
		}

		// Token: 0x06022983 RID: 141699 RVA: 0x009D76E4 File Offset: 0x009D58E4
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

		// Token: 0x06022984 RID: 141700 RVA: 0x009D7738 File Offset: 0x009D5938
		[NullableContext(1)]
		public void ForEachDecalComponent([Nullable(2)] AActor actor, Action<UDecalComponent> exec)
		{
			if (actor != null && actor.IsValid())
			{
				TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UDecalComponent.StaticClass());
				int num = tarray.Num();
				for (int i = 0; i < num; i++)
				{
					UDecalComponent udecalComponent = tarray.Get(i) as UDecalComponent;
					if (udecalComponent != null)
					{
						exec(udecalComponent);
					}
				}
			}
		}

		// Token: 0x06022985 RID: 141701 RVA: 0x009D778C File Offset: 0x009D598C
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

		// Token: 0x06022986 RID: 141702 RVA: 0x009D77F0 File Offset: 0x009D59F0
		public bool CheckDecalMaterial(UDecalComponent component)
		{
			if (component == null || !component.IsValid())
			{
				return false;
			}
			BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(component);
			if (worldType == BP_EWorldType.Editor || worldType == BP_EWorldType.EditorPreview)
			{
				UMaterialInterface decalMaterial = component.GetDecalMaterial();
				if (decalMaterial != null && !UKuroRenderingRuntimeBPPluginBPLibrary.MaterialHasParameter_EditorOnly(decalMaterial, RenderConfig.E_Action_UseScanning.ToString()))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06022987 RID: 141703 RVA: 0x009D7840 File Offset: 0x009D5A40
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

		// Token: 0x06022988 RID: 141704 RVA: 0x009D79C0 File Offset: 0x009D5BC0
		public void CachedDecalComponentMaterials(UDecalComponent component)
		{
			if (component == null || !component.IsValid())
			{
				return;
			}
			if (this.CachedDecalMaterials.FindIndex(([Nullable(new byte[]
			{
				1,
				1,
				2,
				2
			})] Tuple<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic> cached) => cached.Item1 == component) < 0)
			{
				UMaterialInterface decalMaterial = component.GetDecalMaterial();
				UMaterialInstanceDynamic umaterialInstanceDynamic;
				if (decalMaterial == null)
				{
					umaterialInstanceDynamic = null;
				}
				else
				{
					UMaterialInstanceDynamic umaterialInstanceDynamic2 = decalMaterial as UMaterialInstanceDynamic;
					if (umaterialInstanceDynamic2 != null)
					{
						umaterialInstanceDynamic = umaterialInstanceDynamic2;
					}
					else
					{
						umaterialInstanceDynamic = component.CreateDynamicMaterialInstance();
					}
				}
				this.CachedDecalMaterials.Add(Tuple.Create<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic>(component, decalMaterial, umaterialInstanceDynamic));
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

		// Token: 0x06022989 RID: 141705 RVA: 0x009D7A88 File Offset: 0x009D5C88
		public void ResetComponentMaterials(UPrimitiveComponent component)
		{
			if (component == null)
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
			if (num >= 0)
			{
				int numMaterials = component.GetNumMaterials();
				for (int i = 0; i < numMaterials; i++)
				{
					component.SetMaterial(i, this.CachedMaterials[num].Item2[i]);
				}
			}
		}

		// Token: 0x0401328A RID: 78474
		[Nullable(1)]
		private const string DENG_LONG_MATERIAL_DATA_PATH = "/Game/Aki/Effect/MaterialController/ItemMaterial/3_7_MSTL/DA_Fx_3_7_MSTL_DengLong.DA_Fx_3_7_MSTL_DengLong";

		// Token: 0x0401328B RID: 78475
		protected EffectLifeTimeController LifeTimeController;

		// Token: 0x0401328C RID: 78476
		[Nullable(1)]
		protected AActor Actor;

		// Token: 0x0401328D RID: 78477
		[Nullable(1)]
		protected ItemMaterialControllerActorData Data;

		// Token: 0x0401328E RID: 78478
		protected EffectMaterialParameters ModelParameters;

		// Token: 0x0401328F RID: 78479
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

		// Token: 0x04013290 RID: 78480
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			2
		})]
		protected List<Tuple<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic>> CachedDecalMaterials = new List<Tuple<UDecalComponent, UMaterialInterface, UMaterialInstanceDynamic>>();

		// Token: 0x04013291 RID: 78481
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})]
		protected List<Tuple<UMaterialInstanceDynamic, FName, UTexture>> CachedOriginTexPar = new List<Tuple<UMaterialInstanceDynamic, FName, UTexture>>();
	}
}
