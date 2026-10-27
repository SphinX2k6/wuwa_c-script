using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE4 RID: 2788
	public class ITrampleRayDetection
	{
		// Token: 0x06004032 RID: 16434 RVA: 0x000A3E66 File Offset: 0x000A2066
		[NullableContext(1)]
		public static ITrampleRayDetection Create(ITrampleRayDetection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleRayDetection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040023B7 RID: 9143
		private ITrampleRayDetection Instance;
	}
}
