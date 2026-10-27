using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200271E RID: 10014
	public class IPositionDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600DF58 RID: 57176 RVA: 0x00211959 File Offset: 0x0020FB59
		[NullableContext(1)]
		public static IPositionDrivenMoveDriveMode Create(IPositionDrivenMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x0600DF59 RID: 57177 RVA: 0x00211978 File Offset: 0x0020FB78
		public override ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x0600DF5A RID: 57178 RVA: 0x00211988 File Offset: 0x0020FB88
		public virtual bool? IsFixedPitch
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFixedPitch);
			}
		}

		// Token: 0x04007BF2 RID: 31730
		private IPositionDrivenMoveDriveMode Instance;
	}
}
