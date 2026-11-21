using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D56 RID: 11606
	public class SetNpcGroupPerform : ActionParams
	{
		// Token: 0x0600FD5F RID: 64863 RVA: 0x00249706 File Offset: 0x00247906
		public static SetNpcGroupPerform Create(ISetNpcGroupPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetNpcGroupPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x0600FD60 RID: 64864 RVA: 0x00249725 File Offset: 0x00247925
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x0600FD61 RID: 64865 RVA: 0x00249732 File Offset: 0x00247932
		public virtual ISetNpcGroupPerformType PerformType
		{
			get
			{
				if (this._PerformTypeInited)
				{
					return this._PerformTypeCache;
				}
				this._PerformTypeInited = true;
				this._PerformTypeCache = ActionReadHelper.ReadSetNpcGroupPerform_PerformType(this.Instance);
				return this._PerformTypeCache;
			}
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x0600FD62 RID: 64866 RVA: 0x00249764 File Offset: 0x00247964
		public virtual bool? IsWaitActionFinish
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsWaitActionFinish);
			}
		}

		// Token: 0x04008A4E RID: 35406
		private ISetNpcGroupPerform Instance;

		// Token: 0x04008A4F RID: 35407
		private ISetNpcGroupPerformType _PerformTypeCache;

		// Token: 0x04008A50 RID: 35408
		private bool _PerformTypeInited;
	}
}
