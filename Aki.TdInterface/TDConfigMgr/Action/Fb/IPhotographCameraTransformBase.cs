using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264F RID: 9807
	public class IPhotographCameraTransformBase
	{
		// Token: 0x0600DBEE RID: 56302 RVA: 0x0020BC46 File Offset: 0x00209E46
		[NullableContext(1)]
		public static IPhotographCameraTransformBase Create(IPhotographCameraTransformBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCameraTransformBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0600DBEF RID: 56303 RVA: 0x0020BC65 File Offset: 0x00209E65
		public virtual EPhotographCameraTransform Type
		{
			get
			{
				return (EPhotographCameraTransform)this.Instance.Type;
			}
		}

		// Token: 0x04007A3F RID: 31295
		private IPhotographCameraTransformBase Instance;
	}
}
