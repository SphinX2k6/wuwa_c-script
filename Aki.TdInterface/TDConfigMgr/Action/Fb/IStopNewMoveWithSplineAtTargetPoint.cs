using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002730 RID: 10032
	public class IStopNewMoveWithSplineAtTargetPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600DFAA RID: 57258 RVA: 0x002122EE File Offset: 0x002104EE
		[NullableContext(1)]
		public static IStopNewMoveWithSplineAtTargetPoint Create(IStopNewMoveWithSplineAtTargetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtTargetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x0600DFAB RID: 57259 RVA: 0x0021230D File Offset: 0x0021050D
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x0600DFAC RID: 57260 RVA: 0x0021231A File Offset: 0x0021051A
		public virtual int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x04007C1C RID: 31772
		private IStopNewMoveWithSplineAtTargetPoint Instance;
	}
}
