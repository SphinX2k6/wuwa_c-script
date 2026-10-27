using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BE RID: 9662
	[NullableContext(1)]
	[Nullable(0)]
	public class SetCameraMode : ActionParams
	{
		// Token: 0x0600D950 RID: 55632 RVA: 0x00206B34 File Offset: 0x00204D34
		public static SetCameraMode Create(ISetCameraMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x0600D951 RID: 55633 RVA: 0x00206B53 File Offset: 0x00204D53
		public virtual string Mode
		{
			get
			{
				return this.Instance.Mode;
			}
		}

		// Token: 0x040078B6 RID: 30902
		private ISetCameraMode Instance;
	}
}
