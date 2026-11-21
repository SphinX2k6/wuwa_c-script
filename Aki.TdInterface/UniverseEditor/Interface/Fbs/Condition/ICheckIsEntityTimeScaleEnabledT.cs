using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F4E RID: 20302
	public class ICheckIsEntityTimeScaleEnabledT
	{
		// Token: 0x17009117 RID: 37143
		// (get) Token: 0x0601F967 RID: 129383 RVA: 0x00464F85 File Offset: 0x00463185
		// (set) Token: 0x0601F968 RID: 129384 RVA: 0x00464F8D File Offset: 0x0046318D
		public ECondition Type { get; set; }

		// Token: 0x17009118 RID: 37144
		// (get) Token: 0x0601F969 RID: 129385 RVA: 0x00464F96 File Offset: 0x00463196
		// (set) Token: 0x0601F96A RID: 129386 RVA: 0x00464F9E File Offset: 0x0046319E
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17009119 RID: 37145
		// (get) Token: 0x0601F96B RID: 129387 RVA: 0x00464FA7 File Offset: 0x004631A7
		// (set) Token: 0x0601F96C RID: 129388 RVA: 0x00464FAF File Offset: 0x004631AF
		public bool Enabled { get; set; }

		// Token: 0x0601F96D RID: 129389 RVA: 0x00464FB8 File Offset: 0x004631B8
		public ICheckIsEntityTimeScaleEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.Enabled = false;
		}
	}
}
