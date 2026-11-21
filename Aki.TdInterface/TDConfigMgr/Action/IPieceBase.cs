using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F03 RID: 7939
	public class IPieceBase
	{
		// Token: 0x0600A8F3 RID: 43251 RVA: 0x0017FB48 File Offset: 0x0017DD48
		private IPieceBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPieceBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPieceBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPieceBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x0017FB80 File Offset: 0x0017DD80
		public static IPieceBase Create([Nullable(2)] IPieceBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x0017FB93 File Offset: 0x0017DD93
		public static IPieceBase CreateFromSetValue([Nullable(2)] IPieceBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPieceBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x0017FBA6 File Offset: 0x0017DDA6
		public IPieceBase_SetValue ToSetValue()
		{
			return new IPieceBase_SetValue
			{
				Index = this.Index,
				Active = this.Active
			};
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600A8F7 RID: 43255 RVA: 0x0017FBC8 File Offset: 0x0017DDC8
		// (set) Token: 0x0600A8F8 RID: 43256 RVA: 0x0017FC29 File Offset: 0x0017DE29
		public virtual IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				if (this.FbInstance != null)
				{
					this._IndexCache = IPieceIndex.Create(this.FbInstance.Index);
				}
				else
				{
					IPieceBase_SetValue pocoInterface = this.PocoInterface;
					this._IndexCache = ((pocoInterface != null) ? pocoInterface.Index : null);
				}
				return this._IndexCache;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
				this._IndexInited = false;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x0017FC3E File Offset: 0x0017DE3E
		// (set) Token: 0x0600A8FA RID: 43258 RVA: 0x0017FC69 File Offset: 0x0017DE69
		public virtual bool Active
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Active;
				}
				return this.PocoInterface != null && this.PocoInterface.Active;
			}
			set
			{
				this.GetOrCreatePoco().Active = value;
			}
		}

		// Token: 0x04006584 RID: 25988
		[Nullable(2)]
		protected IPieceBase FbInstance;

		// Token: 0x04006585 RID: 25989
		[Nullable(2)]
		protected IPieceBase_SetValue PocoInterface;

		// Token: 0x04006586 RID: 25990
		private IPieceIndex _IndexCache;

		// Token: 0x04006587 RID: 25991
		private bool _IndexInited;
	}
}
