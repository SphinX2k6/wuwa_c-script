using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FC RID: 9212
	public class ServerSetPlayerPos : ActionParams
	{
		// Token: 0x0600C87E RID: 51326 RVA: 0x001CA61C File Offset: 0x001C881C
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

		// Token: 0x0600C87F RID: 51327 RVA: 0x001CA654 File Offset: 0x001C8854
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

		// Token: 0x0600C880 RID: 51328 RVA: 0x001CA667 File Offset: 0x001C8867
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

		// Token: 0x0600C881 RID: 51329 RVA: 0x001CA67A File Offset: 0x001C887A
		public ServerSetPlayerPos_SetValue ToSetValue()
		{
			return new ServerSetPlayerPos_SetValue
			{
				Pos = this.Pos
			};
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600C882 RID: 51330 RVA: 0x001CA690 File Offset: 0x001C8890
		// (set) Token: 0x0600C883 RID: 51331 RVA: 0x001CA6F1 File Offset: 0x001C88F1
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

		// Token: 0x040076F6 RID: 30454
		[Nullable(2)]
		protected new ServerSetPlayerPos FbInstance;

		// Token: 0x040076F7 RID: 30455
		[Nullable(2)]
		protected ServerSetPlayerPos_SetValue PocoInterface;

		// Token: 0x040076F8 RID: 30456
		private PosA _PosCache;

		// Token: 0x040076F9 RID: 30457
		private bool _PosInited;
	}
}
