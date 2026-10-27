using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045EB RID: 17899
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemMaterialGlobalController : ItemMaterialControllerBase
	{
		// Token: 0x0602E297 RID: 189079 RVA: 0x00AAB38A File Offset: 0x00AA958A
		public bool IsValid()
		{
			return this.ParameterCollection != null && this.ParameterCollection.IsValid() && this.WorldContentObject != null && this.WorldContentObject.IsValid();
		}

		// Token: 0x0602E298 RID: 189080 RVA: 0x00AAB3B8 File Offset: 0x00AA95B8
		public ItemMaterialGlobalController(UObject worldContentObject, ItemMaterialControllerGlobalData data)
		{
			this.LifeTimeController = new EffectLifeTimeController(data.StartTime, data.LoopTime, data.EndTime, EEffectLifeTimeType.Auto, new Action(this.Destroy), null, 0f, 1f);
			this.WorldContentObject = worldContentObject;
			this.Data = data;
			this.Play();
		}

		// Token: 0x0602E299 RID: 189081 RVA: 0x00AAB414 File Offset: 0x00AA9614
		public void UpdateParameters(bool forceUpdate)
		{
			if (!this.IsValid())
			{
				return;
			}
			if (this.Data.EnableBaseColorScale && (forceUpdate || this.Data.BaseColorScale.bUseCurve))
			{
				FKuroCurveFloat fkuroCurveFloat = this.Data.BaseColorScale;
				float value_Float = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, this.LifeTimeController.PassTime);
				UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_GlobalBaseColorScale, value_Float);
			}
			if (this.Data.EnableAddEmissionColor && (forceUpdate || this.Data.AddEmissionColor.bUseCurve))
			{
				FKuroCurveLinearColor fkuroCurveLinearColor = this.Data.AddEmissionColor;
				FLinearColor value_LinearColor = UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, this.LifeTimeController.PassTime);
				UKismetMaterialLibrary.SetVectorParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_GlobalAddEmissionColor, value_LinearColor);
			}
			if (this.Data.EnableScanningOutline)
			{
				if (forceUpdate || this.Data.ScanningOutlineColor.bUseCurve)
				{
					FKuroCurveLinearColor fkuroCurveLinearColor = this.Data.ScanningOutlineColor;
					FLinearColor value_LinearColor2 = UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetVectorParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_ScanningOutline, value_LinearColor2);
				}
				if (forceUpdate || this.Data.ScanningOutlineWidth.bUseCurve)
				{
					FKuroCurveFloat fkuroCurveFloat = this.Data.ScanningOutlineWidth;
					float value_Float2 = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.OutlineWidth, value_Float2);
				}
				if (forceUpdate || this.Data.ScanningBrokenTexScaleOffset.bUseCurve)
				{
					FKuroCurveLinearColor fkuroCurveLinearColor = this.Data.ScanningBrokenTexScaleOffset;
					FLinearColor value_LinearColor3 = UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetVectorParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.BrokenTex_S_O, value_LinearColor3);
				}
				if (forceUpdate || this.Data.ScanningOutlineTexScaleOffset.bUseCurve)
				{
					FKuroCurveLinearColor fkuroCurveLinearColor = this.Data.ScanningOutlineTexScaleOffset;
					FLinearColor value_LinearColor4 = UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetVectorParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.OutlineTex_S_O, value_LinearColor4);
				}
			}
			this.UpdateGlobalRim(forceUpdate);
		}

		// Token: 0x0602E29A RID: 189082 RVA: 0x00AAB628 File Offset: 0x00AA9828
		public void UpdateGlobalRim(bool forceUpdate)
		{
			if (!this.IsValid())
			{
				return;
			}
			if (this.Data.EnableRimLight)
			{
				if (forceUpdate || this.Data.AddRimLightColor.bUseCurve)
				{
					FKuroCurveLinearColor addRimLightColor = this.Data.AddRimLightColor;
					FLinearColor value_LinearColor = UKuroCurveLibrary.GetValue_LinearColor(addRimLightColor, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetVectorParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_GlobalRimLight, value_LinearColor);
				}
				if (forceUpdate || this.Data.RimPower.bUseCurve)
				{
					FKuroCurveFloat fkuroCurveFloat = this.Data.RimPower;
					float value_Float = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_RimPower, value_Float);
				}
				if (forceUpdate || this.Data.RimMix.bUseCurve)
				{
					FKuroCurveFloat fkuroCurveFloat = this.Data.RimMix;
					float value_Float2 = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_RimMix, value_Float2);
				}
				if (forceUpdate || this.Data.RimWidth.bUseCurve)
				{
					FKuroCurveFloat fkuroCurveFloat = this.Data.RimWidth;
					float value_Float3 = UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, this.LifeTimeController.PassTime);
					UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_RimWidth, value_Float3);
				}
			}
		}

		// Token: 0x0602E29B RID: 189083 RVA: 0x00AAB780 File Offset: 0x00AA9980
		public void ResetParameters()
		{
			if (!this.IsValid())
			{
				return;
			}
			if (this.Data.EnableBaseColorScale)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(this.WorldContentObject, this.ParameterCollection, RenderConfig.E_Action_GlobalBaseColorScale, 1f);
			}
			if (this.Data.EnableAddEmissionColor)
			{
				UObject worldContentObject = this.WorldContentObject;
				UMaterialParameterCollection parameterCollection = this.ParameterCollection;
				FName e_Action_GlobalAddEmissionColor = RenderConfig.E_Action_GlobalAddEmissionColor;
				FLinearColor flinearColor = new FLinearColor(0f, 0f, 0f, 1f);
				UKismetMaterialLibrary.SetVectorParameterValue(worldContentObject, parameterCollection, e_Action_GlobalAddEmissionColor, flinearColor);
			}
			if (this.Data.EnableRimLight)
			{
				UObject worldContentObject2 = this.WorldContentObject;
				UMaterialParameterCollection parameterCollection2 = this.ParameterCollection;
				FName e_Action_GlobalRimLight = RenderConfig.E_Action_GlobalRimLight;
				FLinearColor flinearColor = new FLinearColor(0f, 0f, 0f, 1f);
				UKismetMaterialLibrary.SetVectorParameterValue(worldContentObject2, parameterCollection2, e_Action_GlobalRimLight, flinearColor);
			}
			if (this.Data.EnableScanningOutline)
			{
				UObject worldContentObject3 = this.WorldContentObject;
				UMaterialParameterCollection parameterCollection3 = this.ParameterCollection;
				FName e_Action_ScanningOutline = RenderConfig.E_Action_ScanningOutline;
				FLinearColor flinearColor = new FLinearColor(0f, 0f, 0f, 1f);
				UKismetMaterialLibrary.SetVectorParameterValue(worldContentObject3, parameterCollection3, e_Action_ScanningOutline, flinearColor);
			}
		}

		// Token: 0x0602E29C RID: 189084 RVA: 0x00AAB87B File Offset: 0x00AA9A7B
		public void Play()
		{
			EffectLifeTimeController lifeTimeController = this.LifeTimeController;
			if (lifeTimeController != null)
			{
				lifeTimeController.Play();
			}
			this.UpdateParameters(true);
		}

		// Token: 0x0602E29D RID: 189085 RVA: 0x00AAB895 File Offset: 0x00AA9A95
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

		// Token: 0x0602E29E RID: 189086 RVA: 0x00AAB8B9 File Offset: 0x00AA9AB9
		public void Destroy()
		{
			this.ResetParameters();
			this.LifeTimeController = null;
		}

		// Token: 0x04018C53 RID: 101459
		[Nullable(2)]
		protected EffectLifeTimeController LifeTimeController;

		// Token: 0x04018C54 RID: 101460
		protected UObject WorldContentObject;

		// Token: 0x04018C55 RID: 101461
		protected ItemMaterialControllerGlobalData Data;

		// Token: 0x04018C56 RID: 101462
		[Nullable(2)]
		protected UMaterialParameterCollection ParameterCollection;
	}
}
