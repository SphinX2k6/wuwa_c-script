using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002803 RID: 10243
	public class IMotorSoarInteract : ILeisureInteractType
	{
		// Token: 0x0600E354 RID: 58196 RVA: 0x002183F7 File Offset: 0x002165F7
		[NullableContext(1)]
		public static IMotorSoarInteract Create(IMotorSoarInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x0600E355 RID: 58197 RVA: 0x00218416 File Offset: 0x00216616
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE7 RID: 32231
		private IMotorSoarInteract Instance;
	}
}
