using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B0 RID: 2224
	public class IWuWaGoMovableFloor : IWuWaGoEntityBase
	{
		// Token: 0x06002FED RID: 12269 RVA: 0x0007B384 File Offset: 0x00079584
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

		// Token: 0x06002FEE RID: 12270 RVA: 0x0007B3BC File Offset: 0x000795BC
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

		// Token: 0x06002FEF RID: 12271 RVA: 0x0007B3CF File Offset: 0x000795CF
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

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0007B3E2 File Offset: 0x000795E2
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x0007B419 File Offset: 0x00079619
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x0007B444 File Offset: 0x00079644
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x0007B454 File Offset: 0x00079654
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x0007B4B5 File Offset: 0x000796B5
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x0007B4CC File Offset: 0x000796CC
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x0007B52D File Offset: 0x0007972D
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x0007B544 File Offset: 0x00079744
		// (set) Token: 0x06002FF8 RID: 12280 RVA: 0x0007B5D7 File Offset: 0x000797D7
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

		// Token: 0x04001FA4 RID: 8100
		[Nullable(2)]
		protected new IWuWaGoMovableFloor FbInstance;

		// Token: 0x04001FA5 RID: 8101
		[Nullable(2)]
		protected new IWuWaGoMovableFloor_SetValue PocoInterface;

		// Token: 0x04001FA6 RID: 8102
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001FA7 RID: 8103
		private bool _LinkDataInited;

		// Token: 0x04001FA8 RID: 8104
		private IWuWaGoGridLinkData _GearLinkDataCache;

		// Token: 0x04001FA9 RID: 8105
		private bool _GearLinkDataInited;

		// Token: 0x04001FAA RID: 8106
		private List<IWuWaGoMovableGridStatePos> _MoveDataCache;

		// Token: 0x04001FAB RID: 8107
		private bool _MoveDataInited;
	}
}
