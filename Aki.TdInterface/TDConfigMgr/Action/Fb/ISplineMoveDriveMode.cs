using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200271C RID: 10012
	public class ISplineMoveDriveMode
	{
		// Token: 0x0600DF52 RID: 57170 RVA: 0x002118F1 File Offset: 0x0020FAF1
		[NullableContext(1)]
		public static ISplineMoveDriveMode Create(ISplineMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x0600DF53 RID: 57171 RVA: 0x00211910 File Offset: 0x0020FB10
		public virtual ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x04007BF0 RID: 31728
		private ISplineMoveDriveMode Instance;
	}
}
