using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200119C RID: 4508
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisSingleGrid
	{
		// Token: 0x06006658 RID: 26200 RVA: 0x000F546C File Offset: 0x000F366C
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

		// Token: 0x06006659 RID: 26201 RVA: 0x000F54A4 File Offset: 0x000F36A4
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

		// Token: 0x0600665A RID: 26202 RVA: 0x000F54B7 File Offset: 0x000F36B7
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

		// Token: 0x0600665B RID: 26203 RVA: 0x000F54CA File Offset: 0x000F36CA
		public ITetrisSingleGrid_SetValue ToSetValue()
		{
			return new ITetrisSingleGrid_SetValue
			{
				Block = this.Block
			};
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600665C RID: 26204 RVA: 0x000F54E0 File Offset: 0x000F36E0
		// (set) Token: 0x0600665D RID: 26205 RVA: 0x000F5541 File Offset: 0x000F3741
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

		// Token: 0x04003D66 RID: 15718
		[Nullable(2)]
		protected ITetrisSingleGrid FbInstance;

		// Token: 0x04003D67 RID: 15719
		[Nullable(2)]
		protected ITetrisSingleGrid_SetValue PocoInterface;

		// Token: 0x04003D68 RID: 15720
		private ITetrisSingleBlock _BlockCache;

		// Token: 0x04003D69 RID: 15721
		private bool _BlockInited;
	}
}
