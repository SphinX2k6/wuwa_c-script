using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007272 RID: 29298
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectNiagaraComponentHandle
	{
		// Token: 0x17009E92 RID: 40594
		// (get) Token: 0x06047CB8 RID: 294072 RVA: 0x0125DCB0 File Offset: 0x0125BEB0
		[Nullable(2)]
		public UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return this.NiagaraComponentInternal;
			}
		}

		// Token: 0x06047CB9 RID: 294073 RVA: 0x0125DCB8 File Offset: 0x0125BEB8
		public KuroEffectNiagaraComponentHandle(int id)
		{
			this.Id = id;
		}

		// Token: 0x06047CBA RID: 294074 RVA: 0x0125DCC7 File Offset: 0x0125BEC7
		public KuroEffectNiagaraComponentHandle(UNiagaraComponent niagaraComponent)
		{
			this.NiagaraComponentInternal = niagaraComponent;
		}

		// Token: 0x06047CBB RID: 294075 RVA: 0x0125DCD6 File Offset: 0x0125BED6
		public bool IsValid()
		{
			return UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_IsValid(this.Id);
		}

		// Token: 0x17009E93 RID: 40595
		// (get) Token: 0x06047CBC RID: 294076 RVA: 0x0125DCE3 File Offset: 0x0125BEE3
		// (set) Token: 0x06047CBD RID: 294077 RVA: 0x0125DCF0 File Offset: 0x0125BEF0
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

		// Token: 0x06047CBE RID: 294078 RVA: 0x0125DCFE File Offset: 0x0125BEFE
		public void SetNiagaraVariableFloat(string inVariableName, float inValue)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableFloat(this.Id, inVariableName, inValue);
		}

		// Token: 0x06047CBF RID: 294079 RVA: 0x0125DD0D File Offset: 0x0125BF0D
		public void SetNiagaraVariableVec3(string inVariableName, in FVector inValue)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableVec3(this.Id, inVariableName, inValue);
		}

		// Token: 0x06047CC0 RID: 294080 RVA: 0x0125DD1C File Offset: 0x0125BF1C
		public void SetIntParameter(in FName parameterName, int param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetIntParameter(this.Id, parameterName, param);
		}

		// Token: 0x06047CC1 RID: 294081 RVA: 0x0125DD2B File Offset: 0x0125BF2B
		public void SetFloatParameter(in FName parameterName, float param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetFloatParameter(this.Id, parameterName, param);
		}

		// Token: 0x06047CC2 RID: 294082 RVA: 0x0125DD3A File Offset: 0x0125BF3A
		public void SetColorParameter(in FName parameterName, in FLinearColor param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetColorParameter(this.Id, parameterName, param);
		}

		// Token: 0x06047CC3 RID: 294083 RVA: 0x0125DD49 File Offset: 0x0125BF49
		public void SetVectorParameter(in FName parameterName, in FVector param)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetVectorParameter(this.Id, parameterName, param);
		}

		// Token: 0x06047CC4 RID: 294084 RVA: 0x0125DD58 File Offset: 0x0125BF58
		public void SetCastShadow(bool castShadow)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetCastShadow(this.Id, castShadow);
		}

		// Token: 0x06047CC5 RID: 294085 RVA: 0x0125DD66 File Offset: 0x0125BF66
		public void SetEnviInteractionComp(UKuroEnviInteractionComponent eIComp)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetEnviInteractionComp(this.Id, eIComp);
		}

		// Token: 0x06047CC6 RID: 294086 RVA: 0x0125DD74 File Offset: 0x0125BF74
		public void SetKuroNiagaraEmitterFloatParam(string inEmitterName, string inVariableName, float value)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam(this.Id, inEmitterName, inVariableName, value);
		}

		// Token: 0x06047CC7 RID: 294087 RVA: 0x0125DD84 File Offset: 0x0125BF84
		public void SetKuroNiagaraEmitterVectorParam(string inEmitterName, string inVariableName, in FVector4 inVector)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam(this.Id, inEmitterName, inVariableName, inVector);
		}

		// Token: 0x06047CC8 RID: 294088 RVA: 0x0125DD94 File Offset: 0x0125BF94
		public void SetNiagaraVariableLinearColor(string variableName, in FLinearColor value)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetNiagaraVariableLinearColor(this.Id, variableName, value);
		}

		// Token: 0x06047CC9 RID: 294089 RVA: 0x0125DDA3 File Offset: 0x0125BFA3
		[NullableContext(2)]
		public void SetVariableTypedObject(in FName inVariableName, UClassStackOnlyPtr typeClass, UObject inObject)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetVariableTypedObject(this.Id, inVariableName, typeClass, inObject);
		}

		// Token: 0x06047CCA RID: 294090 RVA: 0x0125DDB3 File Offset: 0x0125BFB3
		public void SetKuroNiagaraEmitterCustomTexture(string inEmitterName, string inVariableName, UTexture inTexture)
		{
			UKuroEffectSystemHandleHelperLibrary.NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture(this.Id, inEmitterName, inVariableName, inTexture);
		}

		// Token: 0x04025BE6 RID: 154598
		private readonly int Id;

		// Token: 0x04025BE7 RID: 154599
		[Nullable(2)]
		private readonly UNiagaraComponent NiagaraComponentInternal;
	}
}
