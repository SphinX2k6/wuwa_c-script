using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001984 RID: 6532
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeliverItemProbeCollectiblesConfig
	{
		// Token: 0x06008BDD RID: 35805 RVA: 0x00148868 File Offset: 0x00146A68
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

		// Token: 0x06008BDE RID: 35806 RVA: 0x001488A0 File Offset: 0x00146AA0
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

		// Token: 0x06008BDF RID: 35807 RVA: 0x001488B3 File Offset: 0x00146AB3
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

		// Token: 0x06008BE0 RID: 35808 RVA: 0x001488C6 File Offset: 0x00146AC6
		public IDeliverItemProbeCollectiblesConfig_SetValue ToSetValue()
		{
			return new IDeliverItemProbeCollectiblesConfig_SetValue
			{
				ViewStyle = this.ViewStyle,
				DeliverType = this.DeliverType,
				MarkerType = this.MarkerType
			};
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x06008BE1 RID: 35809 RVA: 0x001488F4 File Offset: 0x00146AF4
		// (set) Token: 0x06008BE2 RID: 35810 RVA: 0x00148955 File Offset: 0x00146B55
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

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x06008BE3 RID: 35811 RVA: 0x0014896C File Offset: 0x00146B6C
		// (set) Token: 0x06008BE4 RID: 35812 RVA: 0x001489CD File Offset: 0x00146BCD
		public virtual IItemCellIndependentDeliverType DeliverType
		{
			get
			{
				if (this._DeliverTypeInited)
				{
					return this._DeliverTypeCache;
				}
				this._DeliverTypeInited = true;
				if (this.FbInstance != null)
				{
					this._DeliverTypeCache = IItemCellIndependentDeliverType.Create(this.FbInstance.DeliverType);
				}
				else
				{
					IDeliverItemProbeCollectiblesConfig_SetValue pocoInterface = this.PocoInterface;
					this._DeliverTypeCache = ((pocoInterface != null) ? pocoInterface.DeliverType : null);
				}
				return this._DeliverTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().DeliverType = value;
				this._DeliverTypeInited = false;
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x001489E4 File Offset: 0x00146BE4
		// (set) Token: 0x06008BE6 RID: 35814 RVA: 0x00148A45 File Offset: 0x00146C45
		public virtual IPlaceholderCollectibleMarkerType MarkerType
		{
			get
			{
				if (this._MarkerTypeInited)
				{
					return this._MarkerTypeCache;
				}
				this._MarkerTypeInited = true;
				if (this.FbInstance != null)
				{
					this._MarkerTypeCache = IPlaceholderCollectibleMarkerType.Create(this.FbInstance.MarkerType);
				}
				else
				{
					IDeliverItemProbeCollectiblesConfig_SetValue pocoInterface = this.PocoInterface;
					this._MarkerTypeCache = ((pocoInterface != null) ? pocoInterface.MarkerType : null);
				}
				return this._MarkerTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().MarkerType = value;
				this._MarkerTypeInited = false;
			}
		}

		// Token: 0x04005728 RID: 22312
		[Nullable(2)]
		protected IDeliverItemProbeCollectiblesConfig FbInstance;

		// Token: 0x04005729 RID: 22313
		[Nullable(2)]
		protected IDeliverItemProbeCollectiblesConfig_SetValue PocoInterface;

		// Token: 0x0400572A RID: 22314
		private IHandInItemViewStyle _ViewStyleCache;

		// Token: 0x0400572B RID: 22315
		private bool _ViewStyleInited;

		// Token: 0x0400572C RID: 22316
		private IItemCellIndependentDeliverType _DeliverTypeCache;

		// Token: 0x0400572D RID: 22317
		private bool _DeliverTypeInited;

		// Token: 0x0400572E RID: 22318
		private IPlaceholderCollectibleMarkerType _MarkerTypeCache;

		// Token: 0x0400572F RID: 22319
		private bool _MarkerTypeInited;
	}
}
