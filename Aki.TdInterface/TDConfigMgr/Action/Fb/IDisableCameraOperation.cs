using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294C RID: 10572
	public class IDisableCameraOperation : ICameraOperationType
	{
		// Token: 0x0600EA77 RID: 60023 RVA: 0x0022563A File Offset: 0x0022383A
		[NullableContext(1)]
		public static IDisableCameraOperation Create(IDisableCameraOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x0600EA78 RID: 60024 RVA: 0x00225659 File Offset: 0x00223859
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400813C RID: 33084
		private IDisableCameraOperation Instance;
	}
}
