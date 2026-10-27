using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005999 RID: 22937
	public class IStartRotationConfigT
	{
		// Token: 0x1700AC21 RID: 44065
		// (get) Token: 0x06026D8E RID: 159118 RVA: 0x00558ADF File Offset: 0x00556CDF
		// (set) Token: 0x06026D8F RID: 159119 RVA: 0x00558AE7 File Offset: 0x00556CE7
		public IVectorInfoT TargetRotation { get; set; }

		// Token: 0x1700AC22 RID: 44066
		// (get) Token: 0x06026D90 RID: 159120 RVA: 0x00558AF0 File Offset: 0x00556CF0
		// (set) Token: 0x06026D91 RID: 159121 RVA: 0x00558AF8 File Offset: 0x00556CF8
		public float AngularSpeed { get; set; }

		// Token: 0x06026D92 RID: 159122 RVA: 0x00558B01 File Offset: 0x00556D01
		public IStartRotationConfigT()
		{
			this.TargetRotation = null;
			this.AngularSpeed = 0f;
		}
	}
}
