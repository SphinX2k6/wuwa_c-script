using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002193 RID: 8595
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerSetPlayerPos : ActionParams
	{
		// Token: 0x0600BCCE RID: 48334 RVA: 0x001B3124 File Offset: 0x001B1324
		private ServerSetPlayerPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ServerSetPlayerPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ServerSetPlayerPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ServerSetPlayerPos_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x001B315C File Offset: 0x001B135C
		public static ServerSetPlayerPos Create([Nullable(2)] ServerSetPlayerPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ServerSetPlayerPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x001B316F File Offset: 0x001B136F
		public static ServerSetPlayerPos CreateFromSetValue([Nullable(2)] ServerSetPlayerPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ServerSetPlayerPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x001B3182 File Offset: 0x001B1382
		public ServerSetPlayerPos_SetValue ToSetValue()
		{
			return new ServerSetPlayerPos_SetValue
			{
				Pos = this.Pos
			};
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x001B3198 File Offset: 0x001B1398
		// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x001B31F9 File Offset: 0x001B13F9
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
					ServerSetPlayerPos_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040070B4 RID: 28852
		[Nullable(2)]
		protected new ServerSetPlayerPos FbInstance;

		// Token: 0x040070B5 RID: 28853
		[Nullable(2)]
		protected ServerSetPlayerPos_SetValue PocoInterface;

		// Token: 0x040070B6 RID: 28854
		private PosA _PosCache;

		// Token: 0x040070B7 RID: 28855
		private bool _PosInited;
	}
}
