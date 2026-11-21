using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020029F4 RID: 10740
[NullableContext(1)]
[Nullable(0)]
public class EffectParametersBase
{
	// Token: 0x0601AF13 RID: 110355 RVA: 0x008457A8 File Offset: 0x008439A8
	public virtual void CollectFloatCurve(FName name, FKuroCurveFloat value)
	{
		this.HasCurveParameters = true;
		if (value.bUseCurve)
		{
			this.FloatCurveMap[name] = value;
			return;
		}
		this.CollectFloatConst(name, value.Constant);
	}

	// Token: 0x0601AF14 RID: 110356 RVA: 0x008457D4 File Offset: 0x008439D4
	public virtual void CollectFloatConst(FName name, float value)
	{
		this.FloatConstMap[name] = value;
	}

	// Token: 0x0601AF15 RID: 110357 RVA: 0x008457E3 File Offset: 0x008439E3
	public virtual void CollectLinearColorCurve(FName name, FKuroCurveLinearColor value)
	{
		this.HasCurveParameters = true;
		if (value.bUseCurve)
		{
			this.LinearColorCurveMap[name] = value;
			return;
		}
		this.CollectLinearColorConst(name, value.Constant);
	}

	// Token: 0x0601AF16 RID: 110358 RVA: 0x0084580F File Offset: 0x00843A0F
	public virtual void CollectLinearColorConst(FName name, FLinearColor value)
	{
		this.LinearColorConstMap[name] = value;
	}

	// Token: 0x0601AF17 RID: 110359 RVA: 0x0084581E File Offset: 0x00843A1E
	public virtual void CollectVectorCurve(FName name, FKuroCurveVector value)
	{
		this.HasCurveParameters = true;
		if (value.bUseCurve)
		{
			this.VectorCurveMap[name] = value;
			return;
		}
		this.CollectVectorConst(name, value.Constant);
	}

	// Token: 0x0601AF18 RID: 110360 RVA: 0x0084584A File Offset: 0x00843A4A
	public virtual void CollectVectorConst(FName name, FVector value)
	{
		this.VectorConstMap[name] = value;
	}

	// Token: 0x0601AF19 RID: 110361 RVA: 0x00845859 File Offset: 0x00843A59
	public virtual void RemoveFloatCurveOrConst(FName name)
	{
		this.FloatCurveMap.Remove(name);
		this.FloatConstMap.Remove(name);
	}

	// Token: 0x0601AF1A RID: 110362 RVA: 0x00845875 File Offset: 0x00843A75
	public virtual void RemoveLinearColorCurveOrConst(FName name)
	{
		this.LinearColorCurveMap.Remove(name);
		this.LinearColorConstMap.Remove(name);
	}

	// Token: 0x0601AF1B RID: 110363 RVA: 0x00845891 File Offset: 0x00843A91
	public virtual void RemoveVectorCurveOrConst(FName name)
	{
		this.VectorCurveMap.Remove(name);
		this.VectorConstMap.Remove(name);
	}

	// Token: 0x0601AF1C RID: 110364 RVA: 0x008458B0 File Offset: 0x00843AB0
	[NullableContext(2)]
	public virtual void Apply(UObject target, float time, bool forceApply)
	{
		if (target == null)
		{
			return;
		}
		if (!forceApply && !this.HasCurveParameters)
		{
			return;
		}
		UMaterialInstanceDynamic umaterialInstanceDynamic = target as UMaterialInstanceDynamic;
		if (umaterialInstanceDynamic != null)
		{
			this.ApplyMaterial(umaterialInstanceDynamic, time, forceApply);
		}
	}

	// Token: 0x0601AF1D RID: 110365 RVA: 0x008458E0 File Offset: 0x00843AE0
	[NullableContext(2)]
	protected void ApplyNiagara(UNiagaraComponent NiagaraComponent, float Time, bool bForceApply)
	{
		if (NiagaraComponent == null)
		{
			return;
		}
		if (bForceApply)
		{
			foreach (KeyValuePair<FName, float> keyValuePair in this.FloatConstMap)
			{
				NiagaraComponent.SetNiagaraVariableFloat(keyValuePair.Key.ToString(), keyValuePair.Value);
			}
			foreach (KeyValuePair<FName, FLinearColor> keyValuePair2 in this.LinearColorConstMap)
			{
				string inVariableName = keyValuePair2.Key.ToString();
				FLinearColor value = keyValuePair2.Value;
				NiagaraComponent.SetNiagaraVariableLinearColor(inVariableName, value);
			}
			foreach (KeyValuePair<FName, FVector> keyValuePair3 in this.VectorConstMap)
			{
				NiagaraComponent.SetNiagaraVariableVec3(keyValuePair3.Key.ToString(), keyValuePair3.Value);
			}
		}
		foreach (KeyValuePair<FName, FKuroCurveFloat> keyValuePair4 in this.FloatCurveMap)
		{
			FKuroCurveFloat value2 = keyValuePair4.Value;
			float value_Float = UKuroCurveLibrary.GetValue_Float(value2, Time);
			NiagaraComponent.SetNiagaraVariableFloat(keyValuePair4.Key.ToString(), value_Float);
		}
		foreach (KeyValuePair<FName, FKuroCurveVector> keyValuePair5 in this.VectorCurveMap)
		{
			FKuroCurveVector value3 = keyValuePair5.Value;
			FVector value_Vector = UKuroCurveLibrary.GetValue_Vector(value3, Time);
			NiagaraComponent.SetNiagaraVariableVec3(keyValuePair5.Key.ToString(), value_Vector);
		}
		foreach (KeyValuePair<FName, FKuroCurveLinearColor> keyValuePair6 in this.LinearColorCurveMap)
		{
			FKuroCurveLinearColor value4 = keyValuePair6.Value;
			FLinearColor value_LinearColor = UKuroCurveLibrary.GetValue_LinearColor(value4, Time);
			NiagaraComponent.SetNiagaraVariableLinearColor(keyValuePair6.Key.ToString(), value_LinearColor);
		}
	}

	// Token: 0x0601AF1E RID: 110366 RVA: 0x00845B60 File Offset: 0x00843D60
	[NullableContext(2)]
	protected void ApplyMaterial(UMaterialInstanceDynamic MaterialInstanceDynamic, float Time, bool bForceApply)
	{
		if (MaterialInstanceDynamic == null)
		{
			return;
		}
		if (bForceApply)
		{
			foreach (KeyValuePair<FName, float> keyValuePair in this.FloatConstMap)
			{
				MaterialInstanceDynamic.SetScalarParameterValue(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (KeyValuePair<FName, FVector> keyValuePair2 in this.VectorConstMap)
			{
				FVector value = keyValuePair2.Value;
				MaterialInstanceDynamic.SetVectorParameterValue(keyValuePair2.Key, new FLinearColor(value.X, value.Y, value.Z, 1f));
			}
			foreach (KeyValuePair<FName, FLinearColor> keyValuePair3 in this.LinearColorConstMap)
			{
				MaterialInstanceDynamic.SetVectorParameterValue(keyValuePair3.Key, keyValuePair3.Value);
			}
		}
		foreach (KeyValuePair<FName, FKuroCurveFloat> keyValuePair4 in this.FloatCurveMap)
		{
			FKuroCurveFloat value2 = keyValuePair4.Value;
			float value_Float = UKuroCurveLibrary.GetValue_Float(value2, Time);
			MaterialInstanceDynamic.SetScalarParameterValue(keyValuePair4.Key, value_Float);
		}
		foreach (KeyValuePair<FName, FKuroCurveVector> keyValuePair5 in this.VectorCurveMap)
		{
			FKuroCurveVector value3 = keyValuePair5.Value;
			FVector value_Vector = UKuroCurveLibrary.GetValue_Vector(value3, Time);
			MaterialInstanceDynamic.SetVectorParameterValue(keyValuePair5.Key, new FLinearColor(value_Vector.X, value_Vector.Y, value_Vector.Z, 1f));
		}
		foreach (KeyValuePair<FName, FKuroCurveLinearColor> keyValuePair6 in this.LinearColorCurveMap)
		{
			FKuroCurveLinearColor value4 = keyValuePair6.Value;
			FLinearColor value_LinearColor = UKuroCurveLibrary.GetValue_LinearColor(value4, Time);
			MaterialInstanceDynamic.SetVectorParameterValue(keyValuePair6.Key, value_LinearColor);
		}
	}

	// Token: 0x0400EA23 RID: 59939
	protected Dictionary<FName, FKuroCurveFloat> FloatCurveMap = new Dictionary<FName, FKuroCurveFloat>();

	// Token: 0x0400EA24 RID: 59940
	protected Dictionary<FName, FKuroCurveLinearColor> LinearColorCurveMap = new Dictionary<FName, FKuroCurveLinearColor>();

	// Token: 0x0400EA25 RID: 59941
	protected Dictionary<FName, FKuroCurveVector> VectorCurveMap = new Dictionary<FName, FKuroCurveVector>();

	// Token: 0x0400EA26 RID: 59942
	protected Dictionary<FName, float> FloatConstMap = new Dictionary<FName, float>();

	// Token: 0x0400EA27 RID: 59943
	protected Dictionary<FName, FLinearColor> LinearColorConstMap = new Dictionary<FName, FLinearColor>();

	// Token: 0x0400EA28 RID: 59944
	protected Dictionary<FName, FVector> VectorConstMap = new Dictionary<FName, FVector>();

	// Token: 0x0400EA29 RID: 59945
	protected bool HasCurveParameters;
}
