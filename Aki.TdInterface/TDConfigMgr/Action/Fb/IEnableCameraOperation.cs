using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2C RID: 11308
	public class IEnableCameraOperation : ICameraOperationType
	{
		// Token: 0x0600F8DA RID: 63706 RVA: 0x00242B42 File Offset: 0x00240D42
		public static IEnableCameraOperation Create(IEnableCameraOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableCameraOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x0600F8DB RID: 63707 RVA: 0x00242B61 File Offset: 0x00240D61
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008816 RID: 34838
		private IEnableCameraOperation Instance;
	}
}
