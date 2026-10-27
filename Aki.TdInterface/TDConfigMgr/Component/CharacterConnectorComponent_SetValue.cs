using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003B RID: 59
	public class CharacterConnectorComponent_SetValue
	{
		// Token: 0x04000150 RID: 336
		public bool? Disabled;

		// Token: 0x04000151 RID: 337
		public bool? EdIsLocked;

		// Token: 0x04000152 RID: 338
		[Nullable(1)]
		public ICharacterConnectorRange LogicType;
	}
}
