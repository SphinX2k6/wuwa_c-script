using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000813 RID: 2067
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoPullRod : IWuWaGoEntityBase
	{
		// Token: 0x06002CE3 RID: 11491 RVA: 0x00074680 File Offset: 0x00072880
		private IWuWaGoPullRod_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoPullRod 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoPullRod_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoPullRod_SetValue());
			}
			return result;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000746B8 File Offset: 0x000728B8
		public static IWuWaGoPullRod Create([Nullable(2)] IWuWaGoPullRod instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoPullRod
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000746CB File Offset: 0x000728CB
		public static IWuWaGoPullRod CreateFromSetValue([Nullable(2)] IWuWaGoPullRod_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoPullRod
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000746DE File Offset: 0x000728DE
		public new IWuWaGoPullRod_SetValue ToSetValue()
		{
			return new IWuWaGoPullRod_SetValue
			{
				Type = this.Type,
				InteractConfig = this.InteractConfig
			};
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000746FD File Offset: 0x000728FD
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x00074728 File Offset: 0x00072928
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00074738 File Offset: 0x00072938
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x000747CB File Offset: 0x000729CB
		public virtual List<IWuWaGoInteractStateAction> InteractConfig
		{
			get
			{
				if (this._InteractConfigInited)
				{
					return this._InteractConfigCache;
				}
				this._InteractConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IWuWaGoInteractStateAction> interactConfig = this.FbInstance.InteractConfig;
					if (interactConfig != null)
					{
						this._InteractConfigCache = new List<IWuWaGoInteractStateAction>(interactConfig.Count);
						for (int i = 0; i < interactConfig.Count; i++)
						{
							this._InteractConfigCache.Add(IWuWaGoInteractStateAction.Create(interactConfig[i]));
						}
					}
				}
				else
				{
					IWuWaGoPullRod_SetValue pocoInterface = this.PocoInterface;
					this._InteractConfigCache = ((pocoInterface != null) ? pocoInterface.InteractConfig : null);
				}
				return this._InteractConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InteractConfig = value;
				this._InteractConfigInited = false;
			}
		}

		// Token: 0x04001DB6 RID: 7606
		[Nullable(2)]
		protected new IWuWaGoPullRod FbInstance;

		// Token: 0x04001DB7 RID: 7607
		[Nullable(2)]
		protected new IWuWaGoPullRod_SetValue PocoInterface;

		// Token: 0x04001DB8 RID: 7608
		private List<IWuWaGoInteractStateAction> _InteractConfigCache;

		// Token: 0x04001DB9 RID: 7609
		private bool _InteractConfigInited;
	}
}
