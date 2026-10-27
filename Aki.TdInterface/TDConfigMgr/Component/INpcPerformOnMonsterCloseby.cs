using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000568 RID: 1384
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformOnMonsterCloseby
	{
		// Token: 0x06001C58 RID: 7256 RVA: 0x000511D4 File Offset: 0x0004F3D4
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

		// Token: 0x06001C59 RID: 7257 RVA: 0x0005120C File Offset: 0x0004F40C
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

		// Token: 0x06001C5A RID: 7258 RVA: 0x0005121F File Offset: 0x0004F41F
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

		// Token: 0x06001C5B RID: 7259 RVA: 0x00051232 File Offset: 0x0004F432
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

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00051269 File Offset: 0x0004F469
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00051298 File Offset: 0x0004F498
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000512A8 File Offset: 0x0004F4A8
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x00051309 File Offset: 0x0004F509
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00051320 File Offset: 0x0004F520
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00051381 File Offset: 0x0004F581
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

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00051396 File Offset: 0x0004F596
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x000513C1 File Offset: 0x0004F5C1
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

		// Token: 0x0400143B RID: 5179
		[Nullable(2)]
		protected INpcPerformOnMonsterCloseby FbInstance;

		// Token: 0x0400143C RID: 5180
		[Nullable(2)]
		protected INpcPerformOnMonsterCloseby_SetValue PocoInterface;

		// Token: 0x0400143D RID: 5181
		private IMontageId _MontageCache;

		// Token: 0x0400143E RID: 5182
		private bool _MontageInited;

		// Token: 0x0400143F RID: 5183
		private IBubbleIndex _BubbleCache;

		// Token: 0x04001440 RID: 5184
		private bool _BubbleInited;
	}
}
