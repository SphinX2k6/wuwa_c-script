using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAE RID: 2990
	public class ITrampleRayDetection
	{
		// Token: 0x0600445C RID: 17500 RVA: 0x000AD45A File Offset: 0x000AB65A
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

		// Token: 0x040025D3 RID: 9683
		private ITrampleRayDetection Instance;
	}
}
