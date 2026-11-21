using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206C RID: 8300
	public class ISetNpcSequencePerform_SetValue
	{
		// Token: 0x040068D4 RID: 26836
		public ENpcGroupPerformType Type;

		// Token: 0x040068D5 RID: 26837
		public string Sequence;

		// Token: 0x040068D6 RID: 26838
		public List<INpcGroupSequencePlaySetting> PlaySettings;

		// Token: 0x040068D7 RID: 26839
		public INpcGroupSequenceStaticEntityBinding Binding;

		// Token: 0x040068D8 RID: 26840
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcGroupSequenceBlendAnim> BlendOutAnim;
	}
}
