using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080D RID: 2061
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoMovableFloor : IWuWaGoEntityBase
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x00074020 File Offset: 0x00072220
		private IWuWaGoMovableFloor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoMovableFloor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoMovableFloor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoMovableFloor_SetValue());
			}
			return result;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00074058 File Offset: 0x00072258
		public static IWuWaGoMovableFloor Create([Nullable(2)] IWuWaGoMovableFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoMovableFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x0007406B File Offset: 0x0007226B
		public static IWuWaGoMovableFloor CreateFromSetValue([Nullable(2)] IWuWaGoMovableFloor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoMovableFloor
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0007407E File Offset: 0x0007227E
		public new IWuWaGoMovableFloor_SetValue ToSetValue()
		{
			return new IWuWaGoMovableFloor_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				GearLinkData = this.GearLinkData,
				MoveData = this.MoveData
			};
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000740B5 File Offset: 0x000722B5
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000740E0 File Offset: 0x000722E0
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000740F0 File Offset: 0x000722F0
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x00074151 File Offset: 0x00072351
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				if (this.FbInstance != null)
				{
					this._LinkDataCache = IWuWaGoGridLinkData.Create(this.FbInstance.LinkData);
				}
				else
				{
					IWuWaGoMovableFloor_SetValue pocoInterface = this.PocoInterface;
					this._LinkDataCache = ((pocoInterface != null) ? pocoInterface.LinkData : null);
				}
				return this._LinkDataCache;
			}
			set
			{
				this.GetOrCreatePoco().LinkData = value;
				this._LinkDataInited = false;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x00074168 File Offset: 0x00072368
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000741C9 File Offset: 0x000723C9
		[Nullable(2)]
		public virtual IWuWaGoGridLinkData GearLinkData
		{
			[NullableContext(2)]
			get
			{
				if (this._GearLinkDataInited)
				{
					return this._GearLinkDataCache;
				}
				this._GearLinkDataInited = true;
				if (this.FbInstance != null)
				{
					this._GearLinkDataCache = IWuWaGoGridLinkData.Create(this.FbInstance.GearLinkData);
				}
				else
				{
					IWuWaGoMovableFloor_SetValue pocoInterface = this.PocoInterface;
					this._GearLinkDataCache = ((pocoInterface != null) ? pocoInterface.GearLinkData : null);
				}
				return this._GearLinkDataCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GearLinkData = value;
				this._GearLinkDataInited = false;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000741E0 File Offset: 0x000723E0
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00074273 File Offset: 0x00072473
		public virtual List<IWuWaGoMovableGridStatePos> MoveData
		{
			get
			{
				if (this._MoveDataInited)
				{
					return this._MoveDataCache;
				}
				this._MoveDataInited = true;
				if (this.FbInstance != null)
				{
					List<IWuWaGoMovableGridStatePos> moveData = this.FbInstance.MoveData;
					if (moveData != null)
					{
						this._MoveDataCache = new List<IWuWaGoMovableGridStatePos>(moveData.Count);
						for (int i = 0; i < moveData.Count; i++)
						{
							this._MoveDataCache.Add(IWuWaGoMovableGridStatePos.Create(moveData[i]));
						}
					}
				}
				else
				{
					IWuWaGoMovableFloor_SetValue pocoInterface = this.PocoInterface;
					this._MoveDataCache = ((pocoInterface != null) ? pocoInterface.MoveData : null);
				}
				return this._MoveDataCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveData = value;
				this._MoveDataInited = false;
			}
		}

		// Token: 0x04001D98 RID: 7576
		[Nullable(2)]
		protected new IWuWaGoMovableFloor FbInstance;

		// Token: 0x04001D99 RID: 7577
		[Nullable(2)]
		protected new IWuWaGoMovableFloor_SetValue PocoInterface;

		// Token: 0x04001D9A RID: 7578
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001D9B RID: 7579
		private bool _LinkDataInited;

		// Token: 0x04001D9C RID: 7580
		private IWuWaGoGridLinkData _GearLinkDataCache;

		// Token: 0x04001D9D RID: 7581
		private bool _GearLinkDataInited;

		// Token: 0x04001D9E RID: 7582
		private List<IWuWaGoMovableGridStatePos> _MoveDataCache;

		// Token: 0x04001D9F RID: 7583
		private bool _MoveDataInited;
	}
}
