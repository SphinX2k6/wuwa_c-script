using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D5 RID: 9173
	public class RogueSelectRoom : ActionParams
	{
		// Token: 0x0600C7DE RID: 51166 RVA: 0x001C95CC File Offset: 0x001C77CC
		private RogueSelectRoom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RogueSelectRoom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RogueSelectRoom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RogueSelectRoom_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x001C9604 File Offset: 0x001C7804
		public static RogueSelectRoom Create([Nullable(2)] RogueSelectRoom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueSelectRoom
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x001C9617 File Offset: 0x001C7817
		public static RogueSelectRoom CreateFromSetValue([Nullable(2)] RogueSelectRoom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RogueSelectRoom
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x001C962A File Offset: 0x001C782A
		public RogueSelectRoom_SetValue ToSetValue()
		{
			return new RogueSelectRoom_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600C7E2 RID: 51170 RVA: 0x001C9640 File Offset: 0x001C7840
		// (set) Token: 0x0600C7E3 RID: 51171 RVA: 0x001C96A1 File Offset: 0x001C78A1
		public virtual IRogueRoleSelectRoom Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IRogueRoleSelectRoom.Create(this.FbInstance.Config);
				}
				else
				{
					RogueSelectRoom_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x040076B0 RID: 30384
		[Nullable(2)]
		protected new RogueSelectRoom FbInstance;

		// Token: 0x040076B1 RID: 30385
		[Nullable(2)]
		protected RogueSelectRoom_SetValue PocoInterface;

		// Token: 0x040076B2 RID: 30386
		private IRogueRoleSelectRoom _ConfigCache;

		// Token: 0x040076B3 RID: 30387
		private bool _ConfigInited;
	}
}
