using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DF RID: 8415
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveToPosA : ActionParams
	{
		// Token: 0x0600B8E2 RID: 47330 RVA: 0x001AB874 File Offset: 0x001A9A74
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

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x001AB8AC File Offset: 0x001A9AAC
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

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x001AB8BF File Offset: 0x001A9ABF
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

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x001AB8D2 File Offset: 0x001A9AD2
		public MoveToPosA_SetValue ToSetValue()
		{
			return new MoveToPosA_SetValue
			{
				Timeout = this.Timeout,
				Pos = this.Pos
			};
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600B8E6 RID: 47334 RVA: 0x001AB8F1 File Offset: 0x001A9AF1
		// (set) Token: 0x0600B8E7 RID: 47335 RVA: 0x001AB920 File Offset: 0x001A9B20
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

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600B8E8 RID: 47336 RVA: 0x001AB930 File Offset: 0x001A9B30
		// (set) Token: 0x0600B8E9 RID: 47337 RVA: 0x001AB991 File Offset: 0x001A9B91
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

		// Token: 0x04006EBC RID: 28348
		[Nullable(2)]
		protected new MoveToPosA FbInstance;

		// Token: 0x04006EBD RID: 28349
		[Nullable(2)]
		protected MoveToPosA_SetValue PocoInterface;

		// Token: 0x04006EBE RID: 28350
		private PosA _PosCache;

		// Token: 0x04006EBF RID: 28351
		private bool _PosInited;
	}
}
