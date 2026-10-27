using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x0200726A RID: 29290
	public class EffectParameterNiagara
	{
		// Token: 0x17009E83 RID: 40579
		// (get) Token: 0x06047C0F RID: 293903 RVA: 0x0125C89B File Offset: 0x0125AA9B
		// (set) Token: 0x06047C10 RID: 293904 RVA: 0x0125C8A3 File Offset: 0x0125AAA3
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

		// Token: 0x17009E84 RID: 40580
		// (get) Token: 0x06047C11 RID: 293905 RVA: 0x0125C8AC File Offset: 0x0125AAAC
		// (set) Token: 0x06047C12 RID: 293906 RVA: 0x0125C8B4 File Offset: 0x0125AAB4
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

		// Token: 0x17009E85 RID: 40581
		// (get) Token: 0x06047C13 RID: 293907 RVA: 0x0125C8BD File Offset: 0x0125AABD
		// (set) Token: 0x06047C14 RID: 293908 RVA: 0x0125C8C5 File Offset: 0x0125AAC5
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

		// Token: 0x17009E86 RID: 40582
		// (get) Token: 0x06047C15 RID: 293909 RVA: 0x0125C8CE File Offset: 0x0125AACE
		// (set) Token: 0x06047C16 RID: 293910 RVA: 0x0125C8D6 File Offset: 0x0125AAD6
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

		// Token: 0x17009E87 RID: 40583
		// (get) Token: 0x06047C17 RID: 293911 RVA: 0x0125C8DF File Offset: 0x0125AADF
		// (set) Token: 0x06047C18 RID: 293912 RVA: 0x0125C8E7 File Offset: 0x0125AAE7
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

		// Token: 0x17009E88 RID: 40584
		// (get) Token: 0x06047C19 RID: 293913 RVA: 0x0125C8F0 File Offset: 0x0125AAF0
		// (set) Token: 0x06047C1A RID: 293914 RVA: 0x0125C8F8 File Offset: 0x0125AAF8
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

		// Token: 0x06047C1B RID: 293915 RVA: 0x0125C904 File Offset: 0x0125AB04
		[NullableContext(1)]
		public void ToKuroEffectParameterNiagara(FKuroEffectNiagaraParametersStruct parameters)
		{
			if (this.UserParameterFloat != null)
			{
				foreach (ValueTuple<FName, float> valueTuple in this.UserParameterFloat)
				{
					FKuroParameterFloat value = new FKuroParameterFloat(valueTuple.Item1, valueTuple.Item2);
					parameters.UserParameterFloat.Add(value);
				}
			}
			if (this.UserParameterColor != null)
			{
				foreach (ValueTuple<FName, FLinearColor> valueTuple2 in this.UserParameterColor)
				{
					FKuroParameterLinearColor value2 = new FKuroParameterLinearColor(valueTuple2.Item1, valueTuple2.Item2);
					parameters.UserParameterColor.Add(value2);
				}
			}
			if (this.UserParameterVector != null)
			{
				foreach (ValueTuple<FName, FVector> valueTuple3 in this.UserParameterVector)
				{
					FKuroParameterVector value3 = new FKuroParameterVector(valueTuple3.Item1, valueTuple3.Item2);
					parameters.UserParameterVector.Add(value3);
				}
			}
			if (this.UserParameterArrayVector != null)
			{
				foreach (ValueTuple<FName, TArray<FVector>> valueTuple4 in this.UserParameterArrayVector)
				{
					FKuroParameterArrayVector value4 = new FKuroParameterArrayVector(valueTuple4.Item1, valueTuple4.Item2);
					parameters.UserParameterArrayVector.Add(value4);
				}
			}
			if (this.MaterialParameterFloat != null)
			{
				foreach (ValueTuple<FName, float> valueTuple5 in this.MaterialParameterFloat)
				{
					FKuroParameterFloat value5 = new FKuroParameterFloat(valueTuple5.Item1, valueTuple5.Item2);
					parameters.MaterialParameterFloat.Add(value5);
				}
			}
			if (this.MaterialParameterColor != null)
			{
				foreach (ValueTuple<FName, FLinearColor> valueTuple6 in this.MaterialParameterColor)
				{
					FKuroParameterLinearColor value6 = new FKuroParameterLinearColor(valueTuple6.Item1, valueTuple6.Item2);
					parameters.MaterialParameterColor.Add(value6);
				}
			}
		}
	}
}
