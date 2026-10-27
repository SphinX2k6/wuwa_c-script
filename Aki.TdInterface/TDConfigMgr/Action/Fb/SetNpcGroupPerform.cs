using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A62 RID: 10850
	[NullableContext(1)]
	[Nullable(0)]
	public class SetNpcGroupPerform : ActionParams
	{
		// Token: 0x0600EEA9 RID: 61097 RVA: 0x0022B9FB File Offset: 0x00229BFB
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

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x0600EEAA RID: 61098 RVA: 0x0022BA1A File Offset: 0x00229C1A
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x0600EEAB RID: 61099 RVA: 0x0022BA27 File Offset: 0x00229C27
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

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x0600EEAC RID: 61100 RVA: 0x0022BA58 File Offset: 0x00229C58
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

		// Token: 0x0400834A RID: 33610
		private ISetNpcGroupPerform Instance;

		// Token: 0x0400834B RID: 33611
		private ISetNpcGroupPerformType _PerformTypeCache;

		// Token: 0x0400834C RID: 33612
		private bool _PerformTypeInited;
	}
}
