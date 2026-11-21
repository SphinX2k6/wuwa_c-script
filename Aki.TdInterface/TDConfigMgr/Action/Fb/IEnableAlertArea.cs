using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDE RID: 11486
	public class IEnableAlertArea : IAlertSystemOption
	{
		// Token: 0x0600FBA4 RID: 64420 RVA: 0x00246FCF File Offset: 0x002451CF
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

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x0600FBA5 RID: 64421 RVA: 0x00246FEE File Offset: 0x002451EE
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x0600FBA6 RID: 64422 RVA: 0x00246FFB File Offset: 0x002451FB
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x0600FBA7 RID: 64423 RVA: 0x00247008 File Offset: 0x00245208
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x0600FBA8 RID: 64424 RVA: 0x00247015 File Offset: 0x00245215
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

		// Token: 0x0400897A RID: 35194
		private IEnableAlertArea Instance;

		// Token: 0x0400897B RID: 35195
		private IDisableAlertAreaCondition _AutoDisableConditionCache;

		// Token: 0x0400897C RID: 35196
		private bool _AutoDisableConditionInited;
	}
}
