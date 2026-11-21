using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A32 RID: 10802
	public class IFrequencyDetectionTip : ICommonTipType
	{
		// Token: 0x0600EEB2 RID: 61106 RVA: 0x0022FFFA File Offset: 0x0022E1FA
		public static IFrequencyDetectionTip Create(IFrequencyDetectionTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyDetectionTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x0600EEB3 RID: 61107 RVA: 0x00230019 File Offset: 0x0022E219
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x0600EEB4 RID: 61108 RVA: 0x00230026 File Offset: 0x0022E226
		public virtual ICommonTalkMessage Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				this._ContentCache = ICommonTalkMessage.Create(this.Instance.Content);
				return this._ContentCache;
			}
		}

		// Token: 0x04008314 RID: 33556
		private IFrequencyDetectionTip Instance;

		// Token: 0x04008315 RID: 33557
		[Nullable(2)]
		private ICommonTalkMessage _ContentCache;

		// Token: 0x04008316 RID: 33558
		private bool _ContentInited;
	}
}
