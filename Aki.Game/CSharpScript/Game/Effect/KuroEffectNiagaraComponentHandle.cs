using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063F1 RID: 25585
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectNiagaraComponentHandle
	{
		// Token: 0x170075EB RID: 30187
		// (get) Token: 0x0603E075 RID: 254069 RVA: 0x011FE650 File Offset: 0x011FC850
		[Nullable(2)]
		public UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return this.NiagaraComponentInternal;
			}
		}

		// Token: 0x0603E076 RID: 254070 RVA: 0x011FE658 File Offset: 0x011FC858
		public KuroEffectNiagaraComponentHandle(int id)
		{
			this.Id = id;
		}

		// Token: 0x0603E077 RID: 254071 RVA: 0x011FE667 File Offset: 0x011FC867
		public KuroEffectNiagaraComponentHandle(UNiagaraComponent niagaraComponent)
		{
			this.NiagaraComponentInternal = niagaraComponent;
		}

		// Token: 0x0603E078 RID: 254072 RVA: 0x011FE676 File Offset: 0x011FC876
		public bool IsValid()
		{
			return UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_IsValid(this.Id);
		}

		// Token: 0x170075EC RID: 30188
		// (get) Token: 0x0603E079 RID: 254073 RVA: 0x011FE683 File Offset: 0x011FC883
		// (set) Token: 0x0603E07A RID: 254074 RVA: 0x011FE690 File Offset: 0x011FC890
		public bool bForceSolo
		{
			get
			{
				return UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_GetForceSolo(this.Id);
			}
			set
			{
				UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetForceSolo(this.Id, value);
			}
		}

		// Token: 0x0603E07B RID: 254075 RVA: 0x011FE69E File Offset: 0x011FC89E
		public void SetNiagaraVariableFloat(string inVariableName, float inValue)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableFloat(this.Id, inVariableName, inValue);
		}

		// Token: 0x0603E07C RID: 254076 RVA: 0x011FE6AD File Offset: 0x011FC8AD
		public void SetNiagaraVariableVec3(string inVariableName, in FVector inValue)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableVec3(this.Id, inVariableName, inValue);
		}

		// Token: 0x0603E07D RID: 254077 RVA: 0x011FE6BC File Offset: 0x011FC8BC
		public void SetIntParameter(in FName parameterName, int param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetIntParameter(this.Id, parameterName, param);
		}

		// Token: 0x0603E07E RID: 254078 RVA: 0x011FE6CB File Offset: 0x011FC8CB
		public void SetFloatParameter(in FName parameterName, float param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetFloatParameter(this.Id, parameterName, param);
		}

		// Token: 0x0603E07F RID: 254079 RVA: 0x011FE6DA File Offset: 0x011FC8DA
		public void SetColorParameter(in FName parameterName, in FLinearColor param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetColorParameter(this.Id, parameterName, param);
		}

		// Token: 0x0603E080 RID: 254080 RVA: 0x011FE6E9 File Offset: 0x011FC8E9
		public void SetVectorParameter(in FName parameterName, in FVector param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetVectorParameter(this.Id, parameterName, param);
		}

		// Token: 0x0603E081 RID: 254081 RVA: 0x011FE6F8 File Offset: 0x011FC8F8
		public void SetCastShadow(bool castShadow)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetCastShadow(this.Id, castShadow);
		}

		// Token: 0x0603E082 RID: 254082 RVA: 0x011FE706 File Offset: 0x011FC906
		public void SetEnviInteractionComp(UKuroEnviInteractionComponent eIComp)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetEnviInteractionComp(this.Id, eIComp);
		}

		// Token: 0x0603E083 RID: 254083 RVA: 0x011FE714 File Offset: 0x011FC914
		public void SetKuroNiagaraEmitterFloatParam(string inEmitterName, string inVariableName, float value)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam(this.Id, inEmitterName, inVariableName, value);
		}

		// Token: 0x0603E084 RID: 254084 RVA: 0x011FE724 File Offset: 0x011FC924
		public void SetKuroNiagaraEmitterVectorParam(string inEmitterName, string inVariableName, in FVector4 inVector)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam(this.Id, inEmitterName, inVariableName, inVector);
		}

		// Token: 0x0603E085 RID: 254085 RVA: 0x011FE734 File Offset: 0x011FC934
		public void SetNiagaraVariableLinearColor(string variableName, in FLinearColor value)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableLinearColor(this.Id, variableName, value);
		}

		// Token: 0x0603E086 RID: 254086 RVA: 0x011FE743 File Offset: 0x011FC943
		[NullableContext(2)]
		public void SetVariableTypedObject(in FName inVariableName, UClassStackOnlyPtr typeClass, UObject inObject)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetVariableTypedObject(this.Id, inVariableName, typeClass, inObject);
		}

		// Token: 0x0603E087 RID: 254087 RVA: 0x011FE753 File Offset: 0x011FC953
		public void SetKuroNiagaraEmitterCustomTexture(string inEmitterName, string inVariableName, UTexture inTexture)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture(this.Id, inEmitterName, inVariableName, inTexture);
		}

		// Token: 0x04020EA5 RID: 134821
		private readonly int Id;

		// Token: 0x04020EA6 RID: 134822
		[Nullable(2)]
		private readonly UNiagaraComponent NiagaraComponentInternal;
	}
}
