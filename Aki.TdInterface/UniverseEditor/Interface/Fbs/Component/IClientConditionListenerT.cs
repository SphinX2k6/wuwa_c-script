using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005500 RID: 21760
	public class IClientConditionListenerT
	{
		// Token: 0x17009B76 RID: 39798
		// (get) Token: 0x060225ED RID: 140781 RVA: 0x004BC8DB File Offset: 0x004BAADB
		// (set) Token: 0x060225EE RID: 140782 RVA: 0x004BC8E3 File Offset: 0x004BAAE3
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009B77 RID: 39799
		// (get) Token: 0x060225EF RID: 140783 RVA: 0x004BC8EC File Offset: 0x004BAAEC
		// (set) Token: 0x060225F0 RID: 140784 RVA: 0x004BC8F4 File Offset: 0x004BAAF4
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009B78 RID: 39800
		// (get) Token: 0x060225F1 RID: 140785 RVA: 0x004BC8FD File Offset: 0x004BAAFD
		// (set) Token: 0x060225F2 RID: 140786 RVA: 0x004BC905 File Offset: 0x004BAB05
		public string SendSelfEvent { get; set; }

		// Token: 0x17009B79 RID: 39801
		// (get) Token: 0x060225F3 RID: 140787 RVA: 0x004BC90E File Offset: 0x004BAB0E
		// (set) Token: 0x060225F4 RID: 140788 RVA: 0x004BC916 File Offset: 0x004BAB16
		public bool OnlyTriggerWhenConditionBecomesTrue { get; set; }

		// Token: 0x17009B7A RID: 39802
		// (get) Token: 0x060225F5 RID: 140789 RVA: 0x004BC91F File Offset: 0x004BAB1F
		// (set) Token: 0x060225F6 RID: 140790 RVA: 0x004BC927 File Offset: 0x004BAB27
		public byte NullMask { get; set; }

		// Token: 0x060225F7 RID: 140791 RVA: 0x004BC930 File Offset: 0x004BAB30
		public IClientConditionListenerT()
		{
			this.Condition = null;
			this.Actions = null;
			this.SendSelfEvent = null;
			this.OnlyTriggerWhenConditionBecomesTrue = false;
			this.NullMask = 0;
		}
	}
}
