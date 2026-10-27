using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F48 RID: 16200
	public class IMotorFightSystemVarT
	{
		// Token: 0x170070A9 RID: 28841
		// (get) Token: 0x06017084 RID: 94340 RVA: 0x0035249B File Offset: 0x0035069B
		// (set) Token: 0x06017085 RID: 94341 RVA: 0x003524A3 File Offset: 0x003506A3
		public EMotorFightSystemVar VarType { get; set; }

		// Token: 0x170070AA RID: 28842
		// (get) Token: 0x06017086 RID: 94342 RVA: 0x003524AC File Offset: 0x003506AC
		// (set) Token: 0x06017087 RID: 94343 RVA: 0x003524B4 File Offset: 0x003506B4
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06017088 RID: 94344 RVA: 0x003524BD File Offset: 0x003506BD
		public IMotorFightSystemVarT()
		{
			this.VarType = EMotorFightSystemVar.LevelProgress;
			this.VarRef = null;
		}
	}
}
