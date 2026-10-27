using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272D RID: 10029
	public class IStopNewMoveWithSplineAtCurrentPos : IStopNewMoveWithSplineType
	{
		// Token: 0x0600DFA1 RID: 57249 RVA: 0x00212252 File Offset: 0x00210452
		[NullableContext(1)]
		public static IStopNewMoveWithSplineAtCurrentPos Create(IStopNewMoveWithSplineAtCurrentPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtCurrentPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x00212271 File Offset: 0x00210471
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x04007C19 RID: 31769
		private IStopNewMoveWithSplineAtCurrentPos Instance;
	}
}
