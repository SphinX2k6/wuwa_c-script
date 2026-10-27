using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A91 RID: 14993
	public class IConstVarRefT
	{
		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x0601457C RID: 83324 RVA: 0x002F7E01 File Offset: 0x002F6001
		// (set) Token: 0x0601457D RID: 83325 RVA: 0x002F7E09 File Offset: 0x002F6009
		public EVar Type { get; set; }

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x0601457E RID: 83326 RVA: 0x002F7E12 File Offset: 0x002F6012
		// (set) Token: 0x0601457F RID: 83327 RVA: 0x002F7E1A File Offset: 0x002F601A
		public EVarRefSource Source { get; set; }

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x06014580 RID: 83328 RVA: 0x002F7E23 File Offset: 0x002F6023
		// (set) Token: 0x06014581 RID: 83329 RVA: 0x002F7E2B File Offset: 0x002F602B
		public TVarValueUnion Value { get; set; }

		// Token: 0x06014582 RID: 83330 RVA: 0x002F7E34 File Offset: 0x002F6034
		public IConstVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Value = null;
		}
	}
}
