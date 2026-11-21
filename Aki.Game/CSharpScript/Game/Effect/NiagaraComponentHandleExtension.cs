using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063EE RID: 25582
	[NullableContext(1)]
	[Nullable(0)]
	public static class NiagaraComponentHandleExtension
	{
		// Token: 0x0603E038 RID: 254008 RVA: 0x011FDB4F File Offset: 0x011FBD4F
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

		// Token: 0x0603E039 RID: 254009 RVA: 0x011FDB7E File Offset: 0x011FBD7E
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

		// Token: 0x0603E03A RID: 254010 RVA: 0x011FDBAD File Offset: 0x011FBDAD
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

		// Token: 0x0603E03B RID: 254011 RVA: 0x011FDBDC File Offset: 0x011FBDDC
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

		// Token: 0x0603E03C RID: 254012 RVA: 0x011FDC0D File Offset: 0x011FBE0D
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

		// Token: 0x0603E03D RID: 254013 RVA: 0x011FDC43 File Offset: 0x011FBE43
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

		// Token: 0x0603E03E RID: 254014 RVA: 0x011FDC79 File Offset: 0x011FBE79
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

		// Token: 0x0603E03F RID: 254015 RVA: 0x011FDCAF File Offset: 0x011FBEAF
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

		// Token: 0x0603E040 RID: 254016 RVA: 0x011FDCEA File Offset: 0x011FBEEA
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

		// Token: 0x0603E041 RID: 254017 RVA: 0x011FDD25 File Offset: 0x011FBF25
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

		// Token: 0x0603E042 RID: 254018 RVA: 0x011FDD54 File Offset: 0x011FBF54
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

		// Token: 0x0603E043 RID: 254019 RVA: 0x011FDD87 File Offset: 0x011FBF87
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

		// Token: 0x0603E044 RID: 254020 RVA: 0x011FDDBF File Offset: 0x011FBFBF
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

		// Token: 0x0603E045 RID: 254021 RVA: 0x011FDDF0 File Offset: 0x011FBFF0
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

		// Token: 0x0603E046 RID: 254022 RVA: 0x011FDE28 File Offset: 0x011FC028
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
