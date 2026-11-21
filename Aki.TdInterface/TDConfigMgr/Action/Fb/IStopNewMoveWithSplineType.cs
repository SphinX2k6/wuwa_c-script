using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F8 RID: 10744
	public class IStopNewMoveWithSplineType
	{
		// Token: 0x0600ED9E RID: 60830 RVA: 0x0022ED56 File Offset: 0x0022CF56
		public static IStopNewMoveWithSplineType Create(IStopNewMoveWithSplineType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x0600ED9F RID: 60831 RVA: 0x0022ED75 File Offset: 0x0022CF75
		public virtual EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x040082C6 RID: 33478
		private IStopNewMoveWithSplineType Instance;
	}
}
