using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B8 RID: 10424
	public class ICutCameraTimeParams
	{
		// Token: 0x0600E767 RID: 59239 RVA: 0x0021FBBE File Offset: 0x0021DDBE
		[NullableContext(1)]
		public static ICutCameraTimeParams Create(ICutCameraTimeParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICutCameraTimeParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x0600E768 RID: 59240 RVA: 0x0021FBDD File Offset: 0x0021DDDD
		public virtual float CutStayTime
		{
			get
			{
				return this.Instance.CutStayTime;
			}
		}

		// Token: 0x04007FE4 RID: 32740
		private ICutCameraTimeParams Instance;
	}
}
