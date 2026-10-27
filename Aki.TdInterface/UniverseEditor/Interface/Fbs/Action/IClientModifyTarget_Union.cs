using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DC RID: 25564
	public enum IClientModifyTarget_Union : byte
	{
		// Token: 0x040109B8 RID: 68024
		NONE,
		// Token: 0x040109B9 RID: 68025
		IClientModifyTarget,
		// Token: 0x040109BA RID: 68026
		IClientModifySelfTarget,
		// Token: 0x040109BB RID: 68027
		IClientModifyPlayerTarget
	}
}
