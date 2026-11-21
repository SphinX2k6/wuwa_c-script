using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F2 RID: 13554
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectParametersBase
	{
		// Token: 0x060227E2 RID: 141282 RVA: 0x009CA47F File Offset: 0x009C867F
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

		// Token: 0x060227E3 RID: 141283 RVA: 0x009CA4AB File Offset: 0x009C86AB
		public virtual void CollectFloatConst(FName name, float value)
		{
			this.FloatConstMap[name] = value;
		}

		// Token: 0x060227E4 RID: 141284 RVA: 0x009CA4BA File Offset: 0x009C86BA
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

		// Token: 0x060227E5 RID: 141285 RVA: 0x009CA4E6 File Offset: 0x009C86E6
		public virtual void CollectLinearColorConst(FName name, FLinearColor value)
		{
			this.LinearColorConstMap[name] = value;
		}

		// Token: 0x060227E6 RID: 141286 RVA: 0x009CA4F5 File Offset: 0x009C86F5
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

		// Token: 0x060227E7 RID: 141287 RVA: 0x009CA521 File Offset: 0x009C8721
		public virtual void CollectVectorConst(FName name, FVector value)
		{
			this.VectorConstMap[name] = value;
		}

		// Token: 0x060227E8 RID: 141288 RVA: 0x009CA530 File Offset: 0x009C8730
		public virtual void RemoveFloatCurveOrConst(FName name)
		{
			this.FloatCurveMap.Remove(name);
			this.FloatConstMap.Remove(name);
		}

		// Token: 0x060227E9 RID: 141289 RVA: 0x009CA54C File Offset: 0x009C874C
		public virtual void RemoveLinearColorCurveOrConst(FName name)
		{
			this.LinearColorCurveMap.Remove(name);
			this.LinearColorConstMap.Remove(name);
		}

		// Token: 0x060227EA RID: 141290 RVA: 0x009CA568 File Offset: 0x009C8768
		public virtual void RemoveVectorCurveOrConst(FName name)
		{
			this.VectorCurveMap.Remove(name);
			this.VectorConstMap.Remove(name);
		}

		// Token: 0x060227EB RID: 141291 RVA: 0x009CA584 File Offset: 0x009C8784
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

		// Token: 0x060227EC RID: 141292 RVA: 0x009CA5B4 File Offset: 0x009C87B4
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

		// Token: 0x060227ED RID: 141293 RVA: 0x009CA834 File Offset: 0x009C8A34
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

		// Token: 0x04013109 RID: 78089
		protected Dictionary<FName, FKuroCurveFloat> FloatCurveMap = new Dictionary<FName, FKuroCurveFloat>();

		// Token: 0x0401310A RID: 78090
		protected Dictionary<FName, FKuroCurveLinearColor> LinearColorCurveMap = new Dictionary<FName, FKuroCurveLinearColor>();

		// Token: 0x0401310B RID: 78091
		protected Dictionary<FName, FKuroCurveVector> VectorCurveMap = new Dictionary<FName, FKuroCurveVector>();

		// Token: 0x0401310C RID: 78092
		protected Dictionary<FName, float> FloatConstMap = new Dictionary<FName, float>();

		// Token: 0x0401310D RID: 78093
		protected Dictionary<FName, FLinearColor> LinearColorConstMap = new Dictionary<FName, FLinearColor>();

		// Token: 0x0401310E RID: 78094
		protected Dictionary<FName, FVector> VectorConstMap = new Dictionary<FName, FVector>();

		// Token: 0x0401310F RID: 78095
		protected bool HasCurveParameters;
	}
}
