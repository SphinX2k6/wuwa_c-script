using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF4 RID: 7412
	[NullableContext(1)]
	[Nullable(0)]
	public class IPieceBase
	{
		// Token: 0x06009F13 RID: 40723 RVA: 0x0016B8E8 File Offset: 0x00169AE8
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

		// Token: 0x06009F14 RID: 40724 RVA: 0x0016B920 File Offset: 0x00169B20
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

		// Token: 0x06009F15 RID: 40725 RVA: 0x0016B933 File Offset: 0x00169B33
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

		// Token: 0x06009F16 RID: 40726 RVA: 0x0016B946 File Offset: 0x00169B46
		public IPieceBase_SetValue ToSetValue()
		{
			return new IPieceBase_SetValue
			{
				Index = this.Index,
				Active = this.Active
			};
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x06009F17 RID: 40727 RVA: 0x0016B968 File Offset: 0x00169B68
		// (set) Token: 0x06009F18 RID: 40728 RVA: 0x0016B9C9 File Offset: 0x00169BC9
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

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x06009F19 RID: 40729 RVA: 0x0016B9DE File Offset: 0x00169BDE
		// (set) Token: 0x06009F1A RID: 40730 RVA: 0x0016BA09 File Offset: 0x00169C09
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

		// Token: 0x04006011 RID: 24593
		[Nullable(2)]
		protected IPieceBase FbInstance;

		// Token: 0x04006012 RID: 24594
		[Nullable(2)]
		protected IPieceBase_SetValue PocoInterface;

		// Token: 0x04006013 RID: 24595
		private IPieceIndex _IndexCache;

		// Token: 0x04006014 RID: 24596
		private bool _IndexInited;
	}
}
