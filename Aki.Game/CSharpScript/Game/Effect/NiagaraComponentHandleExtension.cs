using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x0200726F RID: 29295
	[NullableContext(1)]
	[Nullable(0)]
	public static class NiagaraComponentHandleExtension
	{
		// Token: 0x06047C7B RID: 294011 RVA: 0x0125D1BF File Offset: 0x0125B3BF
		public static bool IsValid([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.IsValid();
			}
			return self.IsT2 && self.AsT2.IsValid();
		}

		// Token: 0x06047C7C RID: 294012 RVA: 0x0125D1EE File Offset: 0x0125B3EE
		public static bool GetForceSolo([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.bForceSolo;
			}
			return self.IsT2 && self.AsT2.bForceSolo;
		}

		// Token: 0x06047C7D RID: 294013 RVA: 0x0125D21D File Offset: 0x0125B41D
		public static void SetForceSolo([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, bool value)
		{
			if (self.IsT1)
			{
				self.AsT1.bForceSolo = value;
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetForceSolo(value);
			}
		}

		// Token: 0x06047C7E RID: 294014 RVA: 0x0125D24C File Offset: 0x0125B44C
		public static void SetNiagaraVariableFloat([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string inVariableName, float inValue)
		{
			if (self.IsT1)
			{
				self.AsT1.SetNiagaraVariableFloat(inVariableName, inValue);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetNiagaraVariableFloat(inVariableName, inValue);
			}
		}

		// Token: 0x06047C7F RID: 294015 RVA: 0x0125D27D File Offset: 0x0125B47D
		public static void SetNiagaraVariableVec3([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string inVariableName, in FVector inValue)
		{
			if (self.IsT1)
			{
				self.AsT1.SetNiagaraVariableVec3(inVariableName, inValue);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetNiagaraVariableVec3(inVariableName, inValue);
			}
		}

		// Token: 0x06047C80 RID: 294016 RVA: 0x0125D2B3 File Offset: 0x0125B4B3
		public static void SetIntParameter([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, in FName inParameterName, int inParam)
		{
			if (self.IsT1)
			{
				self.AsT1.SetIntParameter(inParameterName, inParam);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetIntParameter(inParameterName, inParam);
			}
		}

		// Token: 0x06047C81 RID: 294017 RVA: 0x0125D2E9 File Offset: 0x0125B4E9
		public static void SetFloatParameter([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, in FName inParameterName, float inParam)
		{
			if (self.IsT1)
			{
				self.AsT1.SetFloatParameter(inParameterName, inParam);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetFloatParameter(inParameterName, inParam);
			}
		}

		// Token: 0x06047C82 RID: 294018 RVA: 0x0125D31F File Offset: 0x0125B51F
		public static void SetColorParameter([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, in FName inParameterName, in FLinearColor inParam)
		{
			if (self.IsT1)
			{
				self.AsT1.SetColorParameter(inParameterName, inParam);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetColorParameter(inParameterName, inParam);
			}
		}

		// Token: 0x06047C83 RID: 294019 RVA: 0x0125D35A File Offset: 0x0125B55A
		public static void SetVectorParameter([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, in FName inParameterName, in FVector inParam)
		{
			if (self.IsT1)
			{
				self.AsT1.SetVectorParameter(inParameterName, inParam);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetVectorParameter(inParameterName, inParam);
			}
		}

		// Token: 0x06047C84 RID: 294020 RVA: 0x0125D395 File Offset: 0x0125B595
		public static void SetCastShadow([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, bool castShadow)
		{
			if (self.IsT1)
			{
				self.AsT1.SetCastShadow(castShadow);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetCastShadow(castShadow);
			}
		}

		// Token: 0x06047C85 RID: 294021 RVA: 0x0125D3C4 File Offset: 0x0125B5C4
		public static void SetKuroNiagaraEmitterFloatParam([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string inEmitterName, string inVariableName, float value)
		{
			if (self.IsT1)
			{
				self.AsT1.SetKuroNiagaraEmitterFloatParam(inEmitterName, inVariableName, value);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetKuroNiagaraEmitterFloatParam(inEmitterName, inVariableName, value);
			}
		}

		// Token: 0x06047C86 RID: 294022 RVA: 0x0125D3F7 File Offset: 0x0125B5F7
		public static void SetKuroNiagaraEmitterVectorParam([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string inEmitterName, string inVariableName, in FVector4 value)
		{
			if (self.IsT1)
			{
				self.AsT1.SetKuroNiagaraEmitterVectorParam(inEmitterName, inVariableName, value);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetKuroNiagaraEmitterVectorParam(inEmitterName, inVariableName, value);
			}
		}

		// Token: 0x06047C87 RID: 294023 RVA: 0x0125D42F File Offset: 0x0125B62F
		public static void SetNiagaraVariableLinearColor([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string variableName, in FLinearColor value)
		{
			if (self.IsT1)
			{
				self.AsT1.SetNiagaraVariableLinearColor(variableName, value);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetNiagaraVariableLinearColor(variableName, value);
			}
		}

		// Token: 0x06047C88 RID: 294024 RVA: 0x0125D460 File Offset: 0x0125B660
		[NullableContext(2)]
		public static void SetVariableTypedObject([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, in FName inVariableName, UClassStackOnlyPtr typeClass, UObject inObject)
		{
			if (self.IsT1)
			{
				self.AsT1.SetVariableTypedObject(inVariableName, typeClass, inObject);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetVariableTypedObject(inVariableName, typeClass, inObject);
			}
		}

		// Token: 0x06047C89 RID: 294025 RVA: 0x0125D498 File Offset: 0x0125B698
		public static void SetKuroNiagaraEmitterCustomTexture([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> self, string inEmitterName, string inVariableName, UTexture inTexture)
		{
			if (self.IsT1)
			{
				self.AsT1.SetKuroNiagaraEmitterCustomTexture(inEmitterName, inVariableName, inTexture);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetKuroNiagaraEmitterCustomTexture(inEmitterName, inVariableName, inTexture);
			}
		}
	}
}
