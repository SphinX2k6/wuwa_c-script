using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272F RID: 10031
	public class IStopNewMoveWithSplineAtEndPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600DFA7 RID: 57255 RVA: 0x002122BA File Offset: 0x002104BA
		[NullableContext(1)]
		public static IStopNewMoveWithSplineAtEndPoint Create(IStopNewMoveWithSplineAtEndPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtEndPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x0600DFA8 RID: 57256 RVA: 0x002122D9 File Offset: 0x002104D9
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x04007C1B RID: 31771
		private IStopNewMoveWithSplineAtEndPoint Instance;
	}
}
