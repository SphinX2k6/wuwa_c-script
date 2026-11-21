using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A33 RID: 10803
	public class CommonTip : ActionParams
	{
		// Token: 0x0600EEB6 RID: 61110 RVA: 0x00230062 File Offset: 0x0022E262
		public static CommonTip Create(ICommonTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CommonTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x0600EEB7 RID: 61111 RVA: 0x00230081 File Offset: 0x0022E281
		public virtual ICommonTipType TipOption
		{
			get
			{
				if (this._TipOptionInited)
				{
					return this._TipOptionCache;
				}
				this._TipOptionInited = true;
				this._TipOptionCache = ActionReadHelper.ReadCommonTip_TipOption(this.Instance);
				return this._TipOptionCache;
			}
		}

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x0600EEB8 RID: 61112 RVA: 0x002300B0 File Offset: 0x0022E2B0
		public virtual int? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Duration);
			}
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x0600EEB9 RID: 61113 RVA: 0x002300E6 File Offset: 0x0022E2E6
		[Nullable(2)]
		public virtual string Token
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.Token;
			}
		}

		// Token: 0x04008317 RID: 33559
		private ICommonTip Instance;

		// Token: 0x04008318 RID: 33560
		private ICommonTipType _TipOptionCache;

		// Token: 0x04008319 RID: 33561
		private bool _TipOptionInited;
	}
}
