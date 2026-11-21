using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C5 RID: 1477
	public class INpcHitShow
	{
		// Token: 0x06001E14 RID: 7700 RVA: 0x000557F0 File Offset: 0x000539F0
		private INpcHitShow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcHitShow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcHitShow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcHitShow_SetValue());
			}
			return result;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00055828 File Offset: 0x00053A28
		public static INpcHitShow Create([Nullable(2)] INpcHitShow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcHitShow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0005583B File Offset: 0x00053A3B
		public static INpcHitShow CreateFromSetValue([Nullable(2)] INpcHitShow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcHitShow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0005584E File Offset: 0x00053A4E
		public INpcHitShow_SetValue ToSetValue()
		{
			return new INpcHitShow_SetValue
			{
				HitMontage = this.HitMontage,
				HitBubble = this.HitBubble,
				BubbleRate = this.BubbleRate
			};
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00055879 File Offset: 0x00053A79
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x000558A4 File Offset: 0x00053AA4
		public virtual string HitMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.HitMontage;
			}
			set
			{
				this.GetOrCreatePoco().HitMontage = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x000558B4 File Offset: 0x00053AB4
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00055915 File Offset: 0x00053B15
		public virtual IBubbleIndex HitBubble
		{
			get
			{
				if (this._HitBubbleInited)
				{
					return this._HitBubbleCache;
				}
				this._HitBubbleInited = true;
				if (this.FbInstance != null)
				{
					this._HitBubbleCache = IBubbleIndex.Create(this.FbInstance.HitBubble);
				}
				else
				{
					INpcHitShow_SetValue pocoInterface = this.PocoInterface;
					this._HitBubbleCache = ((pocoInterface != null) ? pocoInterface.HitBubble : null);
				}
				return this._HitBubbleCache;
			}
			set
			{
				this.GetOrCreatePoco().HitBubble = value;
				this._HitBubbleInited = false;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0005592A File Offset: 0x00053B2A
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00055955 File Offset: 0x00053B55
		public virtual int BubbleRate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BubbleRate;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BubbleRate;
			}
			set
			{
				this.GetOrCreatePoco().BubbleRate = value;
			}
		}

		// Token: 0x04001586 RID: 5510
		[Nullable(2)]
		protected INpcHitShow FbInstance;

		// Token: 0x04001587 RID: 5511
		[Nullable(2)]
		protected INpcHitShow_SetValue PocoInterface;

		// Token: 0x04001588 RID: 5512
		private IBubbleIndex _HitBubbleCache;

		// Token: 0x04001589 RID: 5513
		private bool _HitBubbleInited;
	}
}
