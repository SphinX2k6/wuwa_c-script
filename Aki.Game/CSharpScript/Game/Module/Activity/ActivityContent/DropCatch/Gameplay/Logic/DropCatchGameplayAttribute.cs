using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005666 RID: 22118
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayAttribute : IDropCatchGameplayAttribute
	{
		// Token: 0x060369C9 RID: 223689 RVA: 0x00F3DB7A File Offset: 0x00F3BD7A
		public DropCatchGameplayAttribute(string attrName, float baseValue)
		{
			this.AttrName = attrName;
			this.BaseValue = baseValue;
			this.FinalValue = this.BaseValue;
		}

		// Token: 0x060369CA RID: 223690 RVA: 0x00F3DB9C File Offset: 0x00F3BD9C
		public float GetBaseValue()
		{
			return this.BaseValue;
		}

		// Token: 0x060369CB RID: 223691 RVA: 0x00F3DBA4 File Offset: 0x00F3BDA4
		public float GetFinalValue()
		{
			return this.FinalValue;
		}

		// Token: 0x060369CC RID: 223692 RVA: 0x00F3DBAC File Offset: 0x00F3BDAC
		public void SetFinalValue(float value)
		{
			this.FinalValue = value;
		}

		// Token: 0x060369CD RID: 223693 RVA: 0x00F3DBB5 File Offset: 0x00F3BDB5
		public string GetAttrName()
		{
			return this.AttrName;
		}

		// Token: 0x060369CE RID: 223694 RVA: 0x00F3DBBD File Offset: 0x00F3BDBD
		public void Reset()
		{
			this.FinalValue = this.BaseValue;
		}

		// Token: 0x0401CDD4 RID: 118228
		private float FinalValue;

		// Token: 0x0401CDD5 RID: 118229
		private readonly string AttrName;

		// Token: 0x0401CDD6 RID: 118230
		private readonly float BaseValue;
	}
}
