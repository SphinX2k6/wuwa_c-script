using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002761 RID: 10081
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTip : ActionParams
	{
		// Token: 0x0600E098 RID: 57496 RVA: 0x002132CE File Offset: 0x002114CE
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

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x0600E099 RID: 57497 RVA: 0x002132ED File Offset: 0x002114ED
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

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x0600E09A RID: 57498 RVA: 0x0021331C File Offset: 0x0021151C
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

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x0600E09B RID: 57499 RVA: 0x00213352 File Offset: 0x00211552
		[Nullable(2)]
		public virtual string Token
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.Token;
			}
		}

		// Token: 0x04007C61 RID: 31841
		private ICommonTip Instance;

		// Token: 0x04007C62 RID: 31842
		private ICommonTipType _TipOptionCache;

		// Token: 0x04007C63 RID: 31843
		private bool _TipOptionInited;
	}
}
