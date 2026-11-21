using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6D RID: 7533
	public class ILiveSendScConfig : ILiveScOperation
	{
		// Token: 0x06009FF3 RID: 40947 RVA: 0x0016F0C8 File Offset: 0x0016D2C8
		private ILiveSendScConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveSendScConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveSendScConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveSendScConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0016F100 File Offset: 0x0016D300
		public static ILiveSendScConfig Create([Nullable(2)] ILiveSendScConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveSendScConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x0016F113 File Offset: 0x0016D313
		public static ILiveSendScConfig CreateFromSetValue([Nullable(2)] ILiveSendScConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveSendScConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x0016F126 File Offset: 0x0016D326
		public new ILiveSendScConfig_SetValue ToSetValue()
		{
			return new ILiveSendScConfig_SetValue
			{
				Type = this.Type,
				ScList = this.ScList
			};
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x0016F145 File Offset: 0x0016D345
		// (set) Token: 0x06009FF8 RID: 40952 RVA: 0x0016F170 File Offset: 0x0016D370
		public override ELiveScOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveScOperationType.Send;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x0016F180 File Offset: 0x0016D380
		// (set) Token: 0x06009FFA RID: 40954 RVA: 0x0016F213 File Offset: 0x0016D413
		public virtual List<ILiveScConfig> ScList
		{
			get
			{
				if (this._ScListInited)
				{
					return this._ScListCache;
				}
				this._ScListInited = true;
				if (this.FbInstance != null)
				{
					List<ILiveScConfig> scList = this.FbInstance.ScList;
					if (scList != null)
					{
						this._ScListCache = new List<ILiveScConfig>(scList.Count);
						for (int i = 0; i < scList.Count; i++)
						{
							this._ScListCache.Add(ILiveScConfig.Create(scList[i]));
						}
					}
				}
				else
				{
					ILiveSendScConfig_SetValue pocoInterface = this.PocoInterface;
					this._ScListCache = ((pocoInterface != null) ? pocoInterface.ScList : null);
				}
				return this._ScListCache;
			}
			set
			{
				this.GetOrCreatePoco().ScList = value;
				this._ScListInited = false;
			}
		}

		// Token: 0x04006147 RID: 24903
		[Nullable(2)]
		protected new ILiveSendScConfig FbInstance;

		// Token: 0x04006148 RID: 24904
		[Nullable(2)]
		protected new ILiveSendScConfig_SetValue PocoInterface;

		// Token: 0x04006149 RID: 24905
		private List<ILiveScConfig> _ScListCache;

		// Token: 0x0400614A RID: 24906
		private bool _ScListInited;
	}
}
