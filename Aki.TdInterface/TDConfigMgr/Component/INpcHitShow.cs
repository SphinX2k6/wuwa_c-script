using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055E RID: 1374
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcHitShow
	{
		// Token: 0x06001C18 RID: 7192 RVA: 0x00050A34 File Offset: 0x0004EC34
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

		// Token: 0x06001C19 RID: 7193 RVA: 0x00050A6C File Offset: 0x0004EC6C
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

		// Token: 0x06001C1A RID: 7194 RVA: 0x00050A7F File Offset: 0x0004EC7F
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

		// Token: 0x06001C1B RID: 7195 RVA: 0x00050A92 File Offset: 0x0004EC92
		public INpcHitShow_SetValue ToSetValue()
		{
			return new INpcHitShow_SetValue
			{
				HitMontage = this.HitMontage,
				HitBubble = this.HitBubble,
				BubbleRate = this.BubbleRate
			};
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00050ABD File Offset: 0x0004ECBD
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x00050AE8 File Offset: 0x0004ECE8
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

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00050B59 File Offset: 0x0004ED59
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00050B6E File Offset: 0x0004ED6E
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x00050B99 File Offset: 0x0004ED99
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

		// Token: 0x0400141C RID: 5148
		[Nullable(2)]
		protected INpcHitShow FbInstance;

		// Token: 0x0400141D RID: 5149
		[Nullable(2)]
		protected INpcHitShow_SetValue PocoInterface;

		// Token: 0x0400141E RID: 5150
		private IBubbleIndex _HitBubbleCache;

		// Token: 0x0400141F RID: 5151
		private bool _HitBubbleInited;
	}
}
