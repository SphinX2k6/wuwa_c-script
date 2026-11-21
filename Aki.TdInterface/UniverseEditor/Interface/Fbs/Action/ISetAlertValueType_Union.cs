using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775F RID: 30559
	public enum ISetAlertValueType_Union : byte
	{
		// Token: 0x04012978 RID: 76152
		NONE,
		// Token: 0x04012979 RID: 76153
		ISetAlertValueType,
		// Token: 0x0401297A RID: 76154
		IAddOrSubAlertValue,
		// Token: 0x0401297B RID: 76155
		ICustomAlertValue,
		// Token: 0x0401297C RID: 76156
		IMinAlertValue,
		// Token: 0x0401297D RID: 76157
		IMaxAlertValue
	}
}
