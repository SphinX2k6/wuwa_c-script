using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CF RID: 1487
	public class INpcPerformOnMonsterCloseby
	{
		// Token: 0x06001E54 RID: 7764 RVA: 0x00055F90 File Offset: 0x00054190
		private INpcPerformOnMonsterCloseby_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcPerformOnMonsterCloseby 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcPerformOnMonsterCloseby_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcPerformOnMonsterCloseby_SetValue());
			}
			return result;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00055FC8 File Offset: 0x000541C8
		public static INpcPerformOnMonsterCloseby Create([Nullable(2)] INpcPerformOnMonsterCloseby instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformOnMonsterCloseby
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00055FDB File Offset: 0x000541DB
		public static INpcPerformOnMonsterCloseby CreateFromSetValue([Nullable(2)] INpcPerformOnMonsterCloseby_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcPerformOnMonsterCloseby
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00055FEE File Offset: 0x000541EE
		public INpcPerformOnMonsterCloseby_SetValue ToSetValue()
		{
			return new INpcPerformOnMonsterCloseby_SetValue
			{
				Range = this.Range,
				Montage = this.Montage,
				Bubble = this.Bubble,
				BubbleRate = this.BubbleRate
			};
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00056025 File Offset: 0x00054225
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00056054 File Offset: 0x00054254
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00056064 File Offset: 0x00054264
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x000560C5 File Offset: 0x000542C5
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				if (this.FbInstance != null)
				{
					this._MontageCache = IMontageId.Create(this.FbInstance.Montage);
				}
				else
				{
					INpcPerformOnMonsterCloseby_SetValue pocoInterface = this.PocoInterface;
					this._MontageCache = ((pocoInterface != null) ? pocoInterface.Montage : null);
				}
				return this._MontageCache;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
				this._MontageInited = false;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000560DC File Offset: 0x000542DC
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0005613D File Offset: 0x0005433D
		public virtual IBubbleIndex Bubble
		{
			get
			{
				if (this._BubbleInited)
				{
					return this._BubbleCache;
				}
				this._BubbleInited = true;
				if (this.FbInstance != null)
				{
					this._BubbleCache = IBubbleIndex.Create(this.FbInstance.Bubble);
				}
				else
				{
					INpcPerformOnMonsterCloseby_SetValue pocoInterface = this.PocoInterface;
					this._BubbleCache = ((pocoInterface != null) ? pocoInterface.Bubble : null);
				}
				return this._BubbleCache;
			}
			set
			{
				this.GetOrCreatePoco().Bubble = value;
				this._BubbleInited = false;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00056152 File Offset: 0x00054352
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0005617D File Offset: 0x0005437D
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

		// Token: 0x040015A5 RID: 5541
		[Nullable(2)]
		protected INpcPerformOnMonsterCloseby FbInstance;

		// Token: 0x040015A6 RID: 5542
		[Nullable(2)]
		protected INpcPerformOnMonsterCloseby_SetValue PocoInterface;

		// Token: 0x040015A7 RID: 5543
		private IMontageId _MontageCache;

		// Token: 0x040015A8 RID: 5544
		private bool _MontageInited;

		// Token: 0x040015A9 RID: 5545
		private IBubbleIndex _BubbleCache;

		// Token: 0x040015AA RID: 5546
		private bool _BubbleInited;
	}
}
