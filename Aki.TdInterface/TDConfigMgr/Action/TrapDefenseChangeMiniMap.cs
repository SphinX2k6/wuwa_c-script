using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BF RID: 9407
	public class TrapDefenseChangeMiniMap : ActionParams
	{
		// Token: 0x0600CC84 RID: 52356 RVA: 0x001D20D0 File Offset: 0x001D02D0
		private TrapDefenseChangeMiniMap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TrapDefenseChangeMiniMap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TrapDefenseChangeMiniMap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TrapDefenseChangeMiniMap_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x001D2108 File Offset: 0x001D0308
		public static TrapDefenseChangeMiniMap Create([Nullable(2)] TrapDefenseChangeMiniMap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrapDefenseChangeMiniMap
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x001D211B File Offset: 0x001D031B
		public static TrapDefenseChangeMiniMap CreateFromSetValue([Nullable(2)] TrapDefenseChangeMiniMap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TrapDefenseChangeMiniMap
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x001D212E File Offset: 0x001D032E
		public TrapDefenseChangeMiniMap_SetValue ToSetValue()
		{
			return new TrapDefenseChangeMiniMap_SetValue
			{
				MiniMapId = this.MiniMapId
			};
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x001D2141 File Offset: 0x001D0341
		// (set) Token: 0x0600CC89 RID: 52361 RVA: 0x001D216C File Offset: 0x001D036C
		public virtual int MiniMapId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MiniMapId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MiniMapId;
			}
			set
			{
				this.GetOrCreatePoco().MiniMapId = value;
			}
		}

		// Token: 0x04007930 RID: 31024
		[Nullable(2)]
		protected new TrapDefenseChangeMiniMap FbInstance;

		// Token: 0x04007931 RID: 31025
		[Nullable(2)]
		protected TrapDefenseChangeMiniMap_SetValue PocoInterface;
	}
}
