using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EA RID: 10474
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSplineMove : ISplineMoveConfig
	{
		// Token: 0x0600E8B1 RID: 59569 RVA: 0x00222542 File Offset: 0x00220742
		public static ICloseSplineMove Create(ICloseSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x0600E8B2 RID: 59570 RVA: 0x00222561 File Offset: 0x00220761
		public override ESplineMoveConfigType Type
		{
			get
			{
				return (ESplineMoveConfigType)this.Instance.Type;
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x0600E8B3 RID: 59571 RVA: 0x0022256E File Offset: 0x0022076E
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadICloseSplineMove_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x0600E8B4 RID: 59572 RVA: 0x0022259D File Offset: 0x0022079D
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04008074 RID: 32884
		private ICloseSplineMove Instance;

		// Token: 0x04008075 RID: 32885
		private ITargetEntityType _TargetCache;

		// Token: 0x04008076 RID: 32886
		private bool _TargetInited;
	}
}
