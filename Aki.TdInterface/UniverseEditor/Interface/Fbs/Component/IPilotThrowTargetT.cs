using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005743 RID: 22339
	public class IPilotThrowTargetT
	{
		// Token: 0x1700A6AA RID: 42666
		// (get) Token: 0x060256E5 RID: 153317 RVA: 0x0052A756 File Offset: 0x00528956
		// (set) Token: 0x060256E6 RID: 153318 RVA: 0x0052A75E File Offset: 0x0052895E
		public string TidTargetName { get; set; }

		// Token: 0x1700A6AB RID: 42667
		// (get) Token: 0x060256E7 RID: 153319 RVA: 0x0052A767 File Offset: 0x00528967
		// (set) Token: 0x060256E8 RID: 153320 RVA: 0x0052A76F File Offset: 0x0052896F
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A6AC RID: 42668
		// (get) Token: 0x060256E9 RID: 153321 RVA: 0x0052A778 File Offset: 0x00528978
		// (set) Token: 0x060256EA RID: 153322 RVA: 0x0052A780 File Offset: 0x00528980
		public EPilotThrowPointVisualType VisualType { get; set; }

		// Token: 0x1700A6AD RID: 42669
		// (get) Token: 0x060256EB RID: 153323 RVA: 0x0052A789 File Offset: 0x00528989
		// (set) Token: 0x060256EC RID: 153324 RVA: 0x0052A791 File Offset: 0x00528991
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x1700A6AE RID: 42670
		// (get) Token: 0x060256ED RID: 153325 RVA: 0x0052A79A File Offset: 0x0052899A
		// (set) Token: 0x060256EE RID: 153326 RVA: 0x0052A7A2 File Offset: 0x005289A2
		public bool IsQuest { get; set; }

		// Token: 0x1700A6AF RID: 42671
		// (get) Token: 0x060256EF RID: 153327 RVA: 0x0052A7AB File Offset: 0x005289AB
		// (set) Token: 0x060256F0 RID: 153328 RVA: 0x0052A7B3 File Offset: 0x005289B3
		public float UiScale { get; set; }

		// Token: 0x1700A6B0 RID: 42672
		// (get) Token: 0x060256F1 RID: 153329 RVA: 0x0052A7BC File Offset: 0x005289BC
		// (set) Token: 0x060256F2 RID: 153330 RVA: 0x0052A7C4 File Offset: 0x005289C4
		public byte NullMask { get; set; }

		// Token: 0x060256F3 RID: 153331 RVA: 0x0052A7CD File Offset: 0x005289CD
		public IPilotThrowTargetT()
		{
			this.TidTargetName = null;
			this.Position = null;
			this.VisualType = EPilotThrowPointVisualType.Normal;
			this.Conditions = null;
			this.IsQuest = false;
			this.UiScale = 0f;
			this.NullMask = 0;
		}
	}
}
