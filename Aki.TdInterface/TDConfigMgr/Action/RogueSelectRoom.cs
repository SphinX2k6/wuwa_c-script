using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002174 RID: 8564
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueSelectRoom : ActionParams
	{
		// Token: 0x0600BC50 RID: 48208 RVA: 0x001B2418 File Offset: 0x001B0618
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

		// Token: 0x0600BC51 RID: 48209 RVA: 0x001B2450 File Offset: 0x001B0650
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

		// Token: 0x0600BC52 RID: 48210 RVA: 0x001B2463 File Offset: 0x001B0663
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

		// Token: 0x0600BC53 RID: 48211 RVA: 0x001B2476 File Offset: 0x001B0676
		public RogueSelectRoom_SetValue ToSetValue()
		{
			return new RogueSelectRoom_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x001B248C File Offset: 0x001B068C
		// (set) Token: 0x0600BC55 RID: 48213 RVA: 0x001B24ED File Offset: 0x001B06ED
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

		// Token: 0x0400707B RID: 28795
		[Nullable(2)]
		protected new RogueSelectRoom FbInstance;

		// Token: 0x0400707C RID: 28796
		[Nullable(2)]
		protected RogueSelectRoom_SetValue PocoInterface;

		// Token: 0x0400707D RID: 28797
		private IRogueRoleSelectRoom _ConfigCache;

		// Token: 0x0400707E RID: 28798
		private bool _ConfigInited;
	}
}
