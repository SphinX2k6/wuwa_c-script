using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E9 RID: 25577
	public class EffectParameterNiagara
	{
		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x0603DFC9 RID: 253897 RVA: 0x011FD1BB File Offset: 0x011FB3BB
		// (set) Token: 0x0603DFCA RID: 253898 RVA: 0x011FD1C3 File Offset: 0x011FB3C3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ValueTuple<FName, float>> UserParameterFloat { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x0603DFCB RID: 253899 RVA: 0x011FD1CC File Offset: 0x011FB3CC
		// (set) Token: 0x0603DFCC RID: 253900 RVA: 0x011FD1D4 File Offset: 0x011FB3D4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ValueTuple<FName, FLinearColor>> UserParameterColor { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x0603DFCD RID: 253901 RVA: 0x011FD1DD File Offset: 0x011FB3DD
		// (set) Token: 0x0603DFCE RID: 253902 RVA: 0x011FD1E5 File Offset: 0x011FB3E5
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ValueTuple<FName, FVector>> UserParameterVector { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x0603DFCF RID: 253903 RVA: 0x011FD1EE File Offset: 0x011FB3EE
		// (set) Token: 0x0603DFD0 RID: 253904 RVA: 0x011FD1F6 File Offset: 0x011FB3F6
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		public List<ValueTuple<FName, TArray<FVector>>> UserParameterArrayVector { [return: Nullable(new byte[]
		{
			2,
			0,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			0,
			1
		})] set; }

		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x0603DFD1 RID: 253905 RVA: 0x011FD1FF File Offset: 0x011FB3FF
		// (set) Token: 0x0603DFD2 RID: 253906 RVA: 0x011FD207 File Offset: 0x011FB407
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ValueTuple<FName, float>> MaterialParameterFloat { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x0603DFD3 RID: 253907 RVA: 0x011FD210 File Offset: 0x011FB410
		// (set) Token: 0x0603DFD4 RID: 253908 RVA: 0x011FD218 File Offset: 0x011FB418
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ValueTuple<FName, FLinearColor>> MaterialParameterColor { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x0603DFD5 RID: 253909 RVA: 0x011FD224 File Offset: 0x011FB424
		[NullableContext(1)]
		public void ToKuroEffectParameterNiagara(FKuroEffectNiagaraParametersStruct parameters)
		{
			if (this.UserParameterFloat != null)
			{
				foreach (ValueTuple<FName, float> valueTuple in this.UserParameterFloat)
				{
					FKuroParameterFloat value = new FKuroParameterFloat
					{
						Name = valueTuple.Item1,
						Value = valueTuple.Item2
					};
					parameters.UserParameterFloat.Add(value);
				}
			}
			if (this.UserParameterColor != null)
			{
				foreach (ValueTuple<FName, FLinearColor> valueTuple2 in this.UserParameterColor)
				{
					FKuroParameterLinearColor value2 = new FKuroParameterLinearColor
					{
						Name = valueTuple2.Item1,
						Value = valueTuple2.Item2
					};
					parameters.UserParameterColor.Add(value2);
				}
			}
			if (this.UserParameterVector != null)
			{
				foreach (ValueTuple<FName, FVector> valueTuple3 in this.UserParameterVector)
				{
					FKuroParameterVector value3 = new FKuroParameterVector
					{
						Name = valueTuple3.Item1,
						Value = valueTuple3.Item2
					};
					parameters.UserParameterVector.Add(value3);
				}
			}
			if (this.UserParameterArrayVector != null)
			{
				foreach (ValueTuple<FName, TArray<FVector>> valueTuple4 in this.UserParameterArrayVector)
				{
					FKuroParameterArrayVector value4 = new FKuroParameterArrayVector
					{
						Name = valueTuple4.Item1,
						Value = valueTuple4.Item2
					};
					parameters.UserParameterArrayVector.Add(value4);
				}
			}
			if (this.MaterialParameterFloat != null)
			{
				foreach (ValueTuple<FName, float> valueTuple5 in this.MaterialParameterFloat)
				{
					FKuroParameterFloat value5 = new FKuroParameterFloat
					{
						Name = valueTuple5.Item1,
						Value = valueTuple5.Item2
					};
					parameters.MaterialParameterFloat.Add(value5);
				}
			}
			if (this.MaterialParameterColor != null)
			{
				foreach (ValueTuple<FName, FLinearColor> valueTuple6 in this.MaterialParameterColor)
				{
					FKuroParameterLinearColor value6 = new FKuroParameterLinearColor
					{
						Name = valueTuple6.Item1,
						Value = valueTuple6.Item2
					};
					parameters.MaterialParameterColor.Add(value6);
				}
			}
		}
	}
}
