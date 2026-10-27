using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278D RID: 10125
	[NullableContext(1)]
	[Nullable(0)]
	public class HideTargetRange : ActionParams
	{
		// Token: 0x0600E169 RID: 57705 RVA: 0x00214ED8 File Offset: 0x002130D8
		public static HideTargetRange Create(IHideTargetRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideTargetRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x0600E16A RID: 57706 RVA: 0x00214EF7 File Offset: 0x002130F7
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x0600E16B RID: 57707 RVA: 0x00214F04 File Offset: 0x00213104
		public virtual IHideRangeType HideConfig
		{
			get
			{
				if (this._HideConfigInited)
				{
					return this._HideConfigCache;
				}
				this._HideConfigInited = true;
				this._HideConfigCache = ActionReadHelper.ReadHideTargetRange_HideConfig(this.Instance);
				return this._HideConfigCache;
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x0600E16C RID: 57708 RVA: 0x00214F34 File Offset: 0x00213134
		public virtual bool? IsHideSimpleNpc
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHideSimpleNpc);
			}
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x0600E16D RID: 57709 RVA: 0x00214F6C File Offset: 0x0021316C
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHidePasserByNpc);
			}
		}

		// Token: 0x04007CF5 RID: 31989
		private IHideTargetRange Instance;

		// Token: 0x04007CF6 RID: 31990
		private IHideRangeType _HideConfigCache;

		// Token: 0x04007CF7 RID: 31991
		private bool _HideConfigInited;
	}
}
