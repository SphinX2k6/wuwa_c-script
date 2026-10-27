using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006716 RID: 26390
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayAttribute : IDropCatchGameplayAttribute
	{
		// Token: 0x06041E7D RID: 269949 RVA: 0x00FFC7AE File Offset: 0x00FFA9AE
		public DropCatchGameplayAttribute(string attrName, float baseValue)
		{
			this.AttrName = attrName;
			this.BaseValue = baseValue;
			this.FinalValue = this.BaseValue;
		}

		// Token: 0x06041E7E RID: 269950 RVA: 0x00FFC7D0 File Offset: 0x00FFA9D0
		public float GetBaseValue()
		{
			return this.BaseValue;
		}

		// Token: 0x06041E7F RID: 269951 RVA: 0x00FFC7D8 File Offset: 0x00FFA9D8
		public float GetFinalValue()
		{
			return this.FinalValue;
		}

		// Token: 0x06041E80 RID: 269952 RVA: 0x00FFC7E0 File Offset: 0x00FFA9E0
		public void SetFinalValue(float value)
		{
			this.FinalValue = value;
		}

		// Token: 0x06041E81 RID: 269953 RVA: 0x00FFC7E9 File Offset: 0x00FFA9E9
		public string GetAttrName()
		{
			return this.AttrName;
		}

		// Token: 0x06041E82 RID: 269954 RVA: 0x00FFC7F1 File Offset: 0x00FFA9F1
		public void Reset()
		{
			this.FinalValue = this.BaseValue;
		}

		// Token: 0x0402257B RID: 140667
		private float FinalValue;

		// Token: 0x0402257C RID: 140668
		private readonly string AttrName;

		// Token: 0x0402257D RID: 140669
		private readonly float BaseValue;
	}
}
