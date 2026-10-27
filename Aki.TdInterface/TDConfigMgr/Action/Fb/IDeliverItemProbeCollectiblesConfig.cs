using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200266A RID: 9834
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeliverItemProbeCollectiblesConfig
	{
		// Token: 0x0600DC55 RID: 56405 RVA: 0x0020C5AD File Offset: 0x0020A7AD
		public static IDeliverItemProbeCollectiblesConfig Create(IDeliverItemProbeCollectiblesConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectiblesConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x0600DC56 RID: 56406 RVA: 0x0020C5CC File Offset: 0x0020A7CC
		public virtual IHandInItemViewStyle ViewStyle
		{
			get
			{
				if (this._ViewStyleInited)
				{
					return this._ViewStyleCache;
				}
				this._ViewStyleInited = true;
				this._ViewStyleCache = IHandInItemViewStyle.Create(this.Instance.ViewStyle);
				return this._ViewStyleCache;
			}
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x0600DC57 RID: 56407 RVA: 0x0020C600 File Offset: 0x0020A800
		public virtual IItemCellIndependentDeliverType DeliverType
		{
			get
			{
				if (this._DeliverTypeInited)
				{
					return this._DeliverTypeCache;
				}
				this._DeliverTypeInited = true;
				this._DeliverTypeCache = IItemCellIndependentDeliverType.Create(this.Instance.DeliverType);
				return this._DeliverTypeCache;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x0600DC58 RID: 56408 RVA: 0x0020C634 File Offset: 0x0020A834
		public virtual IPlaceholderCollectibleMarkerType MarkerType
		{
			get
			{
				if (this._MarkerTypeInited)
				{
					return this._MarkerTypeCache;
				}
				this._MarkerTypeInited = true;
				this._MarkerTypeCache = IPlaceholderCollectibleMarkerType.Create(this.Instance.MarkerType);
				return this._MarkerTypeCache;
			}
		}

		// Token: 0x04007A70 RID: 31344
		private IDeliverItemProbeCollectiblesConfig Instance;

		// Token: 0x04007A71 RID: 31345
		[Nullable(2)]
		private IHandInItemViewStyle _ViewStyleCache;

		// Token: 0x04007A72 RID: 31346
		private bool _ViewStyleInited;

		// Token: 0x04007A73 RID: 31347
		[Nullable(2)]
		private IItemCellIndependentDeliverType _DeliverTypeCache;

		// Token: 0x04007A74 RID: 31348
		private bool _DeliverTypeInited;

		// Token: 0x04007A75 RID: 31349
		[Nullable(2)]
		private IPlaceholderCollectibleMarkerType _MarkerTypeCache;

		// Token: 0x04007A76 RID: 31350
		private bool _MarkerTypeInited;
	}
}
