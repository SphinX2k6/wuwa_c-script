using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012D6 RID: 4822
	public class ITetrisSingleGrid
	{
		// Token: 0x06006C8F RID: 27791 RVA: 0x00102C38 File Offset: 0x00100E38
		private ITetrisSingleGrid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisSingleGrid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisSingleGrid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisSingleGrid_SetValue());
			}
			return result;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00102C70 File Offset: 0x00100E70
		public static ITetrisSingleGrid Create([Nullable(2)] ITetrisSingleGrid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleGrid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00102C83 File Offset: 0x00100E83
		public static ITetrisSingleGrid CreateFromSetValue([Nullable(2)] ITetrisSingleGrid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisSingleGrid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00102C96 File Offset: 0x00100E96
		public ITetrisSingleGrid_SetValue ToSetValue()
		{
			return new ITetrisSingleGrid_SetValue
			{
				Block = this.Block
			};
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06006C93 RID: 27795 RVA: 0x00102CAC File Offset: 0x00100EAC
		// (set) Token: 0x06006C94 RID: 27796 RVA: 0x00102D0D File Offset: 0x00100F0D
		[Nullable(2)]
		public virtual ITetrisSingleBlock Block
		{
			[NullableContext(2)]
			get
			{
				if (this._BlockInited)
				{
					return this._BlockCache;
				}
				this._BlockInited = true;
				if (this.FbInstance != null)
				{
					this._BlockCache = ITetrisSingleBlock.Create(this.FbInstance.Block);
				}
				else
				{
					ITetrisSingleGrid_SetValue pocoInterface = this.PocoInterface;
					this._BlockCache = ((pocoInterface != null) ? pocoInterface.Block : null);
				}
				return this._BlockCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Block = value;
				this._BlockInited = false;
			}
		}

		// Token: 0x040040CE RID: 16590
		[Nullable(2)]
		protected ITetrisSingleGrid FbInstance;

		// Token: 0x040040CF RID: 16591
		[Nullable(2)]
		protected ITetrisSingleGrid_SetValue PocoInterface;

		// Token: 0x040040D0 RID: 16592
		private ITetrisSingleBlock _BlockCache;

		// Token: 0x040040D1 RID: 16593
		private bool _BlockInited;
	}
}
