using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002252 RID: 8786
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseChangeMiniMap : ActionParams
	{
		// Token: 0x0600C0BE RID: 49342 RVA: 0x001BA94C File Offset: 0x001B8B4C
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

		// Token: 0x0600C0BF RID: 49343 RVA: 0x001BA984 File Offset: 0x001B8B84
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

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x001BA997 File Offset: 0x001B8B97
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

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x001BA9AA File Offset: 0x001B8BAA
		public TrapDefenseChangeMiniMap_SetValue ToSetValue()
		{
			return new TrapDefenseChangeMiniMap_SetValue
			{
				MiniMapId = this.MiniMapId
			};
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x001BA9BD File Offset: 0x001B8BBD
		// (set) Token: 0x0600C0C3 RID: 49347 RVA: 0x001BA9E8 File Offset: 0x001B8BE8
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

		// Token: 0x040072E3 RID: 29411
		[Nullable(2)]
		protected new TrapDefenseChangeMiniMap FbInstance;

		// Token: 0x040072E4 RID: 29412
		[Nullable(2)]
		protected TrapDefenseChangeMiniMap_SetValue PocoInterface;
	}
}
