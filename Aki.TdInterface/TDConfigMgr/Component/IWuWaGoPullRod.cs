using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B6 RID: 2230
	public class IWuWaGoPullRod : IWuWaGoEntityBase
	{
		// Token: 0x06003013 RID: 12307 RVA: 0x0007B9E4 File Offset: 0x00079BE4
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

		// Token: 0x06003014 RID: 12308 RVA: 0x0007BA1C File Offset: 0x00079C1C
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

		// Token: 0x06003015 RID: 12309 RVA: 0x0007BA2F File Offset: 0x00079C2F
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

		// Token: 0x06003016 RID: 12310 RVA: 0x0007BA42 File Offset: 0x00079C42
		public new IWuWaGoPullRod_SetValue ToSetValue()
		{
			return new IWuWaGoPullRod_SetValue
			{
				Type = this.Type,
				InteractConfig = this.InteractConfig
			};
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x0007BA61 File Offset: 0x00079C61
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x0007BA8C File Offset: 0x00079C8C
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x0007BA9C File Offset: 0x00079C9C
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x0007BB2F File Offset: 0x00079D2F
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

		// Token: 0x04001FC2 RID: 8130
		[Nullable(2)]
		protected new IWuWaGoPullRod FbInstance;

		// Token: 0x04001FC3 RID: 8131
		[Nullable(2)]
		protected new IWuWaGoPullRod_SetValue PocoInterface;

		// Token: 0x04001FC4 RID: 8132
		private List<IWuWaGoInteractStateAction> _InteractConfigCache;

		// Token: 0x04001FC5 RID: 8133
		private bool _InteractConfigInited;
	}
}
