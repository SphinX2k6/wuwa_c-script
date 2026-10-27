using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002541 RID: 9537
	public class IShowTalkCameraMotion
	{
		// Token: 0x0600D4A1 RID: 54433 RVA: 0x001F7D2E File Offset: 0x001F5F2E
		[NullableContext(1)]
		public static IShowTalkCameraMotion Create(IShowTalkCameraMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600D4A2 RID: 54434 RVA: 0x001F7D4D File Offset: 0x001F5F4D
		public virtual EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x0400748D RID: 29837
		private IShowTalkCameraMotion Instance;
	}
}
