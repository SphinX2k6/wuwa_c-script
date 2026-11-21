using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002340 RID: 9024
	public class MoveToPosA : ActionParams
	{
		// Token: 0x0600C46C RID: 50284 RVA: 0x001C2950 File Offset: 0x001C0B50
		private MoveToPosA_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveToPosA 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveToPosA_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveToPosA_SetValue());
			}
			return result;
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x001C2988 File Offset: 0x001C0B88
		public static MoveToPosA Create([Nullable(2)] MoveToPosA instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveToPosA
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x001C299B File Offset: 0x001C0B9B
		public static MoveToPosA CreateFromSetValue([Nullable(2)] MoveToPosA_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveToPosA
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x001C29AE File Offset: 0x001C0BAE
		public MoveToPosA_SetValue ToSetValue()
		{
			return new MoveToPosA_SetValue
			{
				Timeout = this.Timeout,
				Pos = this.Pos
			};
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0600C470 RID: 50288 RVA: 0x001C29CD File Offset: 0x001C0BCD
		// (set) Token: 0x0600C471 RID: 50289 RVA: 0x001C29FC File Offset: 0x001C0BFC
		public virtual float Timeout
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Timeout;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Timeout;
			}
			set
			{
				this.GetOrCreatePoco().Timeout = value;
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600C472 RID: 50290 RVA: 0x001C2A0C File Offset: 0x001C0C0C
		// (set) Token: 0x0600C473 RID: 50291 RVA: 0x001C2A6D File Offset: 0x001C0C6D
		public virtual PosA Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				if (this.FbInstance != null)
				{
					this._PosCache = PosA.Create(this.FbInstance.Pos);
				}
				else
				{
					MoveToPosA_SetValue pocoInterface = this.PocoInterface;
					this._PosCache = ((pocoInterface != null) ? pocoInterface.Pos : null);
				}
				return this._PosCache;
			}
			set
			{
				this.GetOrCreatePoco().Pos = value;
				this._PosInited = false;
			}
		}

		// Token: 0x040074ED RID: 29933
		[Nullable(2)]
		protected new MoveToPosA FbInstance;

		// Token: 0x040074EE RID: 29934
		[Nullable(2)]
		protected MoveToPosA_SetValue PocoInterface;

		// Token: 0x040074EF RID: 29935
		private PosA _PosCache;

		// Token: 0x040074F0 RID: 29936
		private bool _PosInited;
	}
}
