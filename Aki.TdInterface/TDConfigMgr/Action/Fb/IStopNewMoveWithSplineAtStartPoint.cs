using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272E RID: 10030
	public class IStopNewMoveWithSplineAtStartPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600DFA4 RID: 57252 RVA: 0x00212286 File Offset: 0x00210486
		[NullableContext(1)]
		public static IStopNewMoveWithSplineAtStartPoint Create(IStopNewMoveWithSplineAtStartPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtStartPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x0600DFA5 RID: 57253 RVA: 0x002122A5 File Offset: 0x002104A5
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x04007C1A RID: 31770
		private IStopNewMoveWithSplineAtStartPoint Instance;
	}
}
