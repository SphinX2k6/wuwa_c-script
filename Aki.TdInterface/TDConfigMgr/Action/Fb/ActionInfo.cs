using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002776 RID: 10102
	public class ActionInfo
	{
		// Token: 0x0600DFDB RID: 57307 RVA: 0x0020F4BF File Offset: 0x0020D6BF
		public static ActionInfo Create(IActionInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x0020F4DE File Offset: 0x0020D6DE
		public virtual EAction Name
		{
			get
			{
				return (EAction)this.Instance.Name;
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600DFDD RID: 57309 RVA: 0x0020F4EC File Offset: 0x0020D6EC
		public virtual bool? Async
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Async);
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x0020F522 File Offset: 0x0020D722
		public virtual ActionParams Params
		{
			get
			{
				if (this._ParamsInited)
				{
					return this._ParamsCache;
				}
				this._ParamsInited = true;
				this._ParamsCache = ActionReadHelper.ReadActionInfo_Params(this.Instance);
				return this._ParamsCache;
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600DFDF RID: 57311 RVA: 0x0020F554 File Offset: 0x0020D754
		public virtual int? ActionId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ActionId);
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x0020F58C File Offset: 0x0020D78C
		public virtual bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600DFE1 RID: 57313 RVA: 0x0020F5C2 File Offset: 0x0020D7C2
		[Nullable(2)]
		public virtual string ActionGuid
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ActionGuid;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x0020F5D0 File Offset: 0x0020D7D0
		public virtual float? Timeout
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Timeout);
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600DFE3 RID: 57315 RVA: 0x0020F608 File Offset: 0x0020D808
		public virtual bool? EdLocalDisabled
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x0020F61E File Offset: 0x0020D81E
		[Nullable(2)]
		public virtual string EdNote
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040079C8 RID: 31176
		private IActionInfo Instance;

		// Token: 0x040079C9 RID: 31177
		private ActionParams _ParamsCache;

		// Token: 0x040079CA RID: 31178
		private bool _ParamsInited;
	}
}
