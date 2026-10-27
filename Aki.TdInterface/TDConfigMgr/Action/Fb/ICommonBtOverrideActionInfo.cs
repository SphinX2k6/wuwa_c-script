using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A79 RID: 10873
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverrideActionInfo : ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x0600EF07 RID: 61191 RVA: 0x0022C49C File Offset: 0x0022A69C
		public static ICommonBtOverrideActionInfo Create(ICommonBtOverrideActionInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideActionInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x0600EF08 RID: 61192 RVA: 0x0022C4BB File Offset: 0x0022A6BB
		public override ECommonBtPlaceholderTargetType Type
		{
			get
			{
				return (ECommonBtPlaceholderTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x0600EF09 RID: 61193 RVA: 0x0022C4C8 File Offset: 0x0022A6C8
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				this._ActionCache = ActionInfo.Create(this.Instance.Action);
				return this._ActionCache;
			}
		}

		// Token: 0x04008383 RID: 33667
		private ICommonBtOverrideActionInfo Instance;

		// Token: 0x04008384 RID: 33668
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04008385 RID: 33669
		private bool _ActionInited;
	}
}
