using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF9 RID: 11001
	public class IOpenQuickHackCameraFovConfig
	{
		// Token: 0x0600F0FC RID: 61692 RVA: 0x0022F733 File Offset: 0x0022D933
		[NullableContext(1)]
		public static IOpenQuickHackCameraFovConfig Create(IOpenQuickHackCameraFovConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenQuickHackCameraFovConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x0600F0FD RID: 61693 RVA: 0x0022F752 File Offset: 0x0022D952
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x0600F0FE RID: 61694 RVA: 0x0022F75F File Offset: 0x0022D95F
		public virtual int Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x0600F0FF RID: 61695 RVA: 0x0022F76C File Offset: 0x0022D96C
		public virtual int Max
		{
			get
			{
				return this.Instance.Max;
			}
		}

		// Token: 0x0400848D RID: 33933
		private IOpenQuickHackCameraFovConfig Instance;
	}
}
