using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233E RID: 9022
	public class MoveSceneItem : ActionParams
	{
		// Token: 0x0600C45E RID: 50270 RVA: 0x001C27A8 File Offset: 0x001C09A8
		private MoveSceneItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveSceneItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveSceneItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveSceneItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x001C27E0 File Offset: 0x001C09E0
		public static MoveSceneItem Create([Nullable(2)] MoveSceneItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveSceneItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x001C27F3 File Offset: 0x001C09F3
		public static MoveSceneItem CreateFromSetValue([Nullable(2)] MoveSceneItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveSceneItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x001C2806 File Offset: 0x001C0A06
		public MoveSceneItem_SetValue ToSetValue()
		{
			return new MoveSceneItem_SetValue
			{
				EntityId = this.EntityId,
				StopBeforeMove = this.StopBeforeMove,
				MoveConfig = this.MoveConfig,
				BypassClientResponse = this.BypassClientResponse
			};
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600C462 RID: 50274 RVA: 0x001C283D File Offset: 0x001C0A3D
		// (set) Token: 0x0600C463 RID: 50275 RVA: 0x001C2868 File Offset: 0x001C0A68
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600C464 RID: 50276 RVA: 0x001C2878 File Offset: 0x001C0A78
		// (set) Token: 0x0600C465 RID: 50277 RVA: 0x001C28B2 File Offset: 0x001C0AB2
		public virtual bool? StopBeforeMove
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopBeforeMove;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopBeforeMove;
			}
			set
			{
				this.GetOrCreatePoco().StopBeforeMove = value;
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600C466 RID: 50278 RVA: 0x001C28C0 File Offset: 0x001C0AC0
		// (set) Token: 0x0600C467 RID: 50279 RVA: 0x001C28E7 File Offset: 0x001C0AE7
		public virtual IMoveSceneItemType MoveConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveConfig;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveConfig;
			}
			set
			{
				this.GetOrCreatePoco().MoveConfig = value;
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0600C468 RID: 50280 RVA: 0x001C28F8 File Offset: 0x001C0AF8
		// (set) Token: 0x0600C469 RID: 50281 RVA: 0x001C2932 File Offset: 0x001C0B32
		public virtual bool? BypassClientResponse
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BypassClientResponse;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BypassClientResponse;
			}
			set
			{
				this.GetOrCreatePoco().BypassClientResponse = value;
			}
		}

		// Token: 0x040074E7 RID: 29927
		[Nullable(2)]
		protected new MoveSceneItem FbInstance;

		// Token: 0x040074E8 RID: 29928
		[Nullable(2)]
		protected MoveSceneItem_SetValue PocoInterface;
	}
}
