using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0D RID: 6925
	public class IDeliverItemProbeCollectiblesConfig
	{
		// Token: 0x0600930B RID: 37643 RVA: 0x001581F8 File Offset: 0x001563F8
		private IDeliverItemProbeCollectiblesConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeliverItemProbeCollectiblesConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeliverItemProbeCollectiblesConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeliverItemProbeCollectiblesConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00158230 File Offset: 0x00156430
		public static IDeliverItemProbeCollectiblesConfig Create([Nullable(2)] IDeliverItemProbeCollectiblesConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectiblesConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00158243 File Offset: 0x00156443
		public static IDeliverItemProbeCollectiblesConfig CreateFromSetValue([Nullable(2)] IDeliverItemProbeCollectiblesConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectiblesConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x00158256 File Offset: 0x00156456
		public IDeliverItemProbeCollectiblesConfig_SetValue ToSetValue()
		{
			return new IDeliverItemProbeCollectiblesConfig_SetValue
			{
				ViewStyle = this.ViewStyle,
				CollectiblesDetectionId = this.CollectiblesDetectionId
			};
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x00158278 File Offset: 0x00156478
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x001582D9 File Offset: 0x001564D9
		public virtual IHandInItemViewStyle ViewStyle
		{
			get
			{
				if (this._ViewStyleInited)
				{
					return this._ViewStyleCache;
				}
				this._ViewStyleInited = true;
				if (this.FbInstance != null)
				{
					this._ViewStyleCache = IHandInItemViewStyle.Create(this.FbInstance.ViewStyle);
				}
				else
				{
					IDeliverItemProbeCollectiblesConfig_SetValue pocoInterface = this.PocoInterface;
					this._ViewStyleCache = ((pocoInterface != null) ? pocoInterface.ViewStyle : null);
				}
				return this._ViewStyleCache;
			}
			set
			{
				this.GetOrCreatePoco().ViewStyle = value;
				this._ViewStyleInited = false;
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x001582EE File Offset: 0x001564EE
		// (set) Token: 0x06009312 RID: 37650 RVA: 0x00158319 File Offset: 0x00156519
		public virtual int CollectiblesDetectionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollectiblesDetectionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CollectiblesDetectionId;
			}
			set
			{
				this.GetOrCreatePoco().CollectiblesDetectionId = value;
			}
		}

		// Token: 0x04005B79 RID: 23417
		[Nullable(2)]
		protected IDeliverItemProbeCollectiblesConfig FbInstance;

		// Token: 0x04005B7A RID: 23418
		[Nullable(2)]
		protected IDeliverItemProbeCollectiblesConfig_SetValue PocoInterface;

		// Token: 0x04005B7B RID: 23419
		private IHandInItemViewStyle _ViewStyleCache;

		// Token: 0x04005B7C RID: 23420
		private bool _ViewStyleInited;
	}
}
