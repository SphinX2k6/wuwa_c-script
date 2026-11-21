using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DED RID: 11757
	public class IOpenQuickHackCameraFovConfig
	{
		// Token: 0x0600FFB2 RID: 65458 RVA: 0x0024D43F File Offset: 0x0024B63F
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

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x0600FFB3 RID: 65459 RVA: 0x0024D45E File Offset: 0x0024B65E
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x0600FFB4 RID: 65460 RVA: 0x0024D46B File Offset: 0x0024B66B
		public virtual int Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x0600FFB5 RID: 65461 RVA: 0x0024D478 File Offset: 0x0024B678
		public virtual int Max
		{
			get
			{
				return this.Instance.Max;
			}
		}

		// Token: 0x04008B91 RID: 35729
		private IOpenQuickHackCameraFovConfig Instance;
	}
}
