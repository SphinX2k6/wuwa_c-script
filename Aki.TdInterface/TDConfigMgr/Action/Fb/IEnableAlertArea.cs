using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F1 RID: 10737
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableAlertArea : IAlertSystemOption
	{
		// Token: 0x0600ED0D RID: 60685 RVA: 0x0022964B File Offset: 0x0022784B
		public static IEnableAlertArea Create(IEnableAlertArea? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAlertArea
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x0600ED0E RID: 60686 RVA: 0x0022966A File Offset: 0x0022786A
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x0600ED0F RID: 60687 RVA: 0x00229677 File Offset: 0x00227877
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x0600ED10 RID: 60688 RVA: 0x00229684 File Offset: 0x00227884
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x0600ED11 RID: 60689 RVA: 0x00229691 File Offset: 0x00227891
		public virtual IDisableAlertAreaCondition AutoDisableCondition
		{
			get
			{
				if (this._AutoDisableConditionInited)
				{
					return this._AutoDisableConditionCache;
				}
				this._AutoDisableConditionInited = true;
				this._AutoDisableConditionCache = ActionReadHelper.ReadIEnableAlertArea_AutoDisableCondition(this.Instance);
				return this._AutoDisableConditionCache;
			}
		}

		// Token: 0x04008289 RID: 33417
		private IEnableAlertArea Instance;

		// Token: 0x0400828A RID: 33418
		private IDisableAlertAreaCondition _AutoDisableConditionCache;

		// Token: 0x0400828B RID: 33419
		private bool _AutoDisableConditionInited;
	}
}
