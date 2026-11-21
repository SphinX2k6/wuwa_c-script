using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E8 RID: 10216
	public class IShowTalkCameraMotion
	{
		// Token: 0x0600E201 RID: 57857 RVA: 0x0021378E File Offset: 0x0021198E
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

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0600E202 RID: 57858 RVA: 0x002137AD File Offset: 0x002119AD
		public virtual EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x04007AE2 RID: 31458
		private IShowTalkCameraMotion Instance;
	}
}
