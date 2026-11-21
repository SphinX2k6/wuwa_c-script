using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200500B RID: 20491
	public class ICheckSceneItemDirectionConditionT
	{
		// Token: 0x1700929A RID: 37530
		// (get) Token: 0x0601FFBF RID: 131007 RVA: 0x0047071E File Offset: 0x0046E91E
		// (set) Token: 0x0601FFC0 RID: 131008 RVA: 0x00470726 File Offset: 0x0046E926
		public ECondition Type { get; set; }

		// Token: 0x1700929B RID: 37531
		// (get) Token: 0x0601FFC1 RID: 131009 RVA: 0x0047072F File Offset: 0x0046E92F
		// (set) Token: 0x0601FFC2 RID: 131010 RVA: 0x00470737 File Offset: 0x0046E937
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700929C RID: 37532
		// (get) Token: 0x0601FFC3 RID: 131011 RVA: 0x00470740 File Offset: 0x0046E940
		// (set) Token: 0x0601FFC4 RID: 131012 RVA: 0x00470748 File Offset: 0x0046E948
		public string RotatePoint { get; set; }

		// Token: 0x1700929D RID: 37533
		// (get) Token: 0x0601FFC5 RID: 131013 RVA: 0x00470751 File Offset: 0x0046E951
		// (set) Token: 0x0601FFC6 RID: 131014 RVA: 0x00470759 File Offset: 0x0046E959
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700929E RID: 37534
		// (get) Token: 0x0601FFC7 RID: 131015 RVA: 0x00470762 File Offset: 0x0046E962
		// (set) Token: 0x0601FFC8 RID: 131016 RVA: 0x0047076A File Offset: 0x0046E96A
		public float AngleInterval { get; set; }

		// Token: 0x0601FFC9 RID: 131017 RVA: 0x00470773 File Offset: 0x0046E973
		public ICheckSceneItemDirectionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.RotatePoint = null;
			this.Direction = null;
			this.AngleInterval = 0f;
		}
	}
}
