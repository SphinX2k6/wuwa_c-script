using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683E RID: 26686
	public class IFocusObjectRotationConfigT
	{
		// Token: 0x1700C641 RID: 50753
		// (get) Token: 0x0602E87F RID: 190591 RVA: 0x0065962F File Offset: 0x0065782F
		// (set) Token: 0x0602E880 RID: 190592 RVA: 0x00659637 File Offset: 0x00657837
		public IVectorInfoT TargetRotation { get; set; }

		// Token: 0x1700C642 RID: 50754
		// (get) Token: 0x0602E881 RID: 190593 RVA: 0x00659640 File Offset: 0x00657840
		// (set) Token: 0x0602E882 RID: 190594 RVA: 0x00659648 File Offset: 0x00657848
		public string SpeedCurve { get; set; }

		// Token: 0x0602E883 RID: 190595 RVA: 0x00659651 File Offset: 0x00657851
		public IFocusObjectRotationConfigT()
		{
			this.TargetRotation = null;
			this.SpeedCurve = null;
		}
	}
}
