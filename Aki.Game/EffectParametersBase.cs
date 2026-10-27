using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003480 RID: 13440
[NullableContext(1)]
[Nullable(0)]
public class EffectParametersBase
{
	// Token: 0x0601D20B RID: 119307 RVA: 0x0081E4A8 File Offset: 0x0081C6A8
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

	// Token: 0x0601D20C RID: 119308 RVA: 0x0081E4D4 File Offset: 0x0081C6D4
	public virtual void CollectFloatConst(FName name, float value)
	{
		this.FloatConstMap[name] = value;
	}

	// Token: 0x0601D20D RID: 119309 RVA: 0x0081E4E3 File Offset: 0x0081C6E3
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

	// Token: 0x0601D20E RID: 119310 RVA: 0x0081E50F File Offset: 0x0081C70F
	public virtual void CollectLinearColorConst(FName name, FLinearColor value)
	{
		this.LinearColorConstMap[name] = value;
	}

	// Token: 0x0601D20F RID: 119311 RVA: 0x0081E51E File Offset: 0x0081C71E
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

	// Token: 0x0601D210 RID: 119312 RVA: 0x0081E54A File Offset: 0x0081C74A
	public virtual void CollectVectorConst(FName name, FVector value)
	{
		this.VectorConstMap[name] = value;
	}

	// Token: 0x0601D211 RID: 119313 RVA: 0x0081E559 File Offset: 0x0081C759
	public virtual void RemoveFloatCurveOrConst(FName name)
	{
		this.FloatCurveMap.Remove(name);
		this.FloatConstMap.Remove(name);
	}

	// Token: 0x0601D212 RID: 119314 RVA: 0x0081E575 File Offset: 0x0081C775
	public virtual void RemoveLinearColorCurveOrConst(FName name)
	{
		this.LinearColorCurveMap.Remove(name);
		this.LinearColorConstMap.Remove(name);
	}

	// Token: 0x0601D213 RID: 119315 RVA: 0x0081E591 File Offset: 0x0081C791
	public virtual void RemoveVectorCurveOrConst(FName name)
	{
		this.VectorCurveMap.Remove(name);
		this.VectorConstMap.Remove(name);
	}

	// Token: 0x0601D214 RID: 119316 RVA: 0x0081E5B0 File Offset: 0x0081C7B0
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

	// Token: 0x0601D215 RID: 119317 RVA: 0x0081E5E0 File Offset: 0x0081C7E0
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

	// Token: 0x0601D216 RID: 119318 RVA: 0x0081E860 File Offset: 0x0081CA60
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

	// Token: 0x0400E56B RID: 58731
	protected Dictionary<FName, FKuroCurveFloat> FloatCurveMap = new Dictionary<FName, FKuroCurveFloat>();

	// Token: 0x0400E56C RID: 58732
	protected Dictionary<FName, FKuroCurveLinearColor> LinearColorCurveMap = new Dictionary<FName, FKuroCurveLinearColor>();

	// Token: 0x0400E56D RID: 58733
	protected Dictionary<FName, FKuroCurveVector> VectorCurveMap = new Dictionary<FName, FKuroCurveVector>();

	// Token: 0x0400E56E RID: 58734
	protected Dictionary<FName, float> FloatConstMap = new Dictionary<FName, float>();

	// Token: 0x0400E56F RID: 58735
	protected Dictionary<FName, FLinearColor> LinearColorConstMap = new Dictionary<FName, FLinearColor>();

	// Token: 0x0400E570 RID: 58736
	protected Dictionary<FName, FVector> VectorConstMap = new Dictionary<FName, FVector>();

	// Token: 0x0400E571 RID: 58737
	protected bool HasCurveParameters;
}
