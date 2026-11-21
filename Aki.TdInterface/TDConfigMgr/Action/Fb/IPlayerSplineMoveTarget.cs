using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E9 RID: 10729
	[NullableContext(2)]
	[Nullable(0)]
	public class IPlayerSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600ED54 RID: 60756 RVA: 0x0022E453 File Offset: 0x0022C653
		[NullableContext(0)]
		public static IPlayerSplineMoveTarget Create(IPlayerSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x0600ED55 RID: 60757 RVA: 0x0022E472 File Offset: 0x0022C672
		public override ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x0600ED56 RID: 60758 RVA: 0x0022E47F File Offset: 0x0022C67F
		public virtual IThreeStageSplineMoveMontage CustomMoveMontage
		{
			get
			{
				if (this._CustomMoveMontageInited)
				{
					return this._CustomMoveMontageCache;
				}
				this._CustomMoveMontageInited = true;
				this._CustomMoveMontageCache = IThreeStageSplineMoveMontage.Create(this.Instance.CustomMoveMontage);
				return this._CustomMoveMontageCache;
			}
		}

		// Token: 0x0400829D RID: 33437
		private IPlayerSplineMoveTarget Instance;

		// Token: 0x0400829E RID: 33438
		private IThreeStageSplineMoveMontage _CustomMoveMontageCache;

		// Token: 0x0400829F RID: 33439
		private bool _CustomMoveMontageInited;
	}
}
