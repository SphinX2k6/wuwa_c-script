using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012D8 RID: 4824
	public class ITetrisSingleIndexGrid
	{
		// Token: 0x06006C97 RID: 27799 RVA: 0x00102D34 File Offset: 0x00100F34
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

		// Token: 0x06006C98 RID: 27800 RVA: 0x00102D6C File Offset: 0x00100F6C
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

		// Token: 0x06006C99 RID: 27801 RVA: 0x00102D7F File Offset: 0x00100F7F
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

		// Token: 0x06006C9A RID: 27802 RVA: 0x00102D92 File Offset: 0x00100F92
		public ITetrisSingleIndexGrid_SetValue ToSetValue()
		{
			return new ITetrisSingleIndexGrid_SetValue
			{
				Index = this.Index,
				Value = this.Value
			};
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x00102DB1 File Offset: 0x00100FB1
		// (set) Token: 0x06006C9C RID: 27804 RVA: 0x00102DDC File Offset: 0x00100FDC
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

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x00102DEC File Offset: 0x00100FEC
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x00102E4D File Offset: 0x0010104D
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

		// Token: 0x040040D3 RID: 16595
		[Nullable(2)]
		protected ITetrisSingleIndexGrid FbInstance;

		// Token: 0x040040D4 RID: 16596
		[Nullable(2)]
		protected ITetrisSingleIndexGrid_SetValue PocoInterface;

		// Token: 0x040040D5 RID: 16597
		private ITetrisSingleGrid _ValueCache;

		// Token: 0x040040D6 RID: 16598
		private bool _ValueInited;
	}
}
