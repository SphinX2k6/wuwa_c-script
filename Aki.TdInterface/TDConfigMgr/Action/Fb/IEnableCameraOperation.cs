using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294A RID: 10570
	public class IEnableCameraOperation : ICameraOperationType
	{
		// Token: 0x0600EA6F RID: 60015 RVA: 0x00225562 File Offset: 0x00223762
		[NullableContext(1)]
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

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x0600EA70 RID: 60016 RVA: 0x00225581 File Offset: 0x00223781
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400813A RID: 33082
		private IEnableCameraOperation Instance;
	}
}
