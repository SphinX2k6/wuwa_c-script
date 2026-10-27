using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200119E RID: 4510
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisSingleIndexGrid
	{
		// Token: 0x06006660 RID: 26208 RVA: 0x000F5568 File Offset: 0x000F3768
		private ITetrisSingleIndexGrid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisSingleIndexGrid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisSingleIndexGrid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisSingleIndexGrid_SetValue());
			}
			return result;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x000F55A0 File Offset: 0x000F37A0
		public static ITetrisSingleIndexGrid Create([Nullable(2)] ITetrisSingleIndexGrid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleIndexGrid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x000F55B3 File Offset: 0x000F37B3
		public static ITetrisSingleIndexGrid CreateFromSetValue([Nullable(2)] ITetrisSingleIndexGrid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisSingleIndexGrid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x000F55C6 File Offset: 0x000F37C6
		public ITetrisSingleIndexGrid_SetValue ToSetValue()
		{
			return new ITetrisSingleIndexGrid_SetValue
			{
				Index = this.Index,
				Value = this.Value
			};
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x000F55E5 File Offset: 0x000F37E5
		// (set) Token: 0x06006665 RID: 26213 RVA: 0x000F5610 File Offset: 0x000F3810
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x000F5620 File Offset: 0x000F3820
		// (set) Token: 0x06006667 RID: 26215 RVA: 0x000F5681 File Offset: 0x000F3881
		public virtual ITetrisSingleGrid Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				if (this.FbInstance != null)
				{
					this._ValueCache = ITetrisSingleGrid.Create(this.FbInstance.Value);
				}
				else
				{
					ITetrisSingleIndexGrid_SetValue pocoInterface = this.PocoInterface;
					this._ValueCache = ((pocoInterface != null) ? pocoInterface.Value : null);
				}
				return this._ValueCache;
			}
			set
			{
				this.GetOrCreatePoco().Value = value;
				this._ValueInited = false;
			}
		}

		// Token: 0x04003D6B RID: 15723
		[Nullable(2)]
		protected ITetrisSingleIndexGrid FbInstance;

		// Token: 0x04003D6C RID: 15724
		[Nullable(2)]
		protected ITetrisSingleIndexGrid_SetValue PocoInterface;

		// Token: 0x04003D6D RID: 15725
		private ITetrisSingleGrid _ValueCache;

		// Token: 0x04003D6E RID: 15726
		private bool _ValueInited;
	}
}
