using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200271D RID: 10013
	public class IInputDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600DF55 RID: 57173 RVA: 0x00211925 File Offset: 0x0020FB25
		[NullableContext(1)]
		public static IInputDrivenMoveDriveMode Create(IInputDrivenMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInputDrivenMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x0600DF56 RID: 57174 RVA: 0x00211944 File Offset: 0x0020FB44
		public override ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x04007BF1 RID: 31729
		private IInputDrivenMoveDriveMode Instance;
	}
}
