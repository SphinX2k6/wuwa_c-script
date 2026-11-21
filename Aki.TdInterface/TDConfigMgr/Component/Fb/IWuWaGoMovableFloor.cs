using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F04 RID: 3844
	public class IWuWaGoMovableFloor : IWuWaGoEntityBase
	{
		// Token: 0x06005677 RID: 22135 RVA: 0x000D4273 File Offset: 0x000D2473
		public static IWuWaGoMovableFloor Create(IWuWaGoMovableFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoMovableFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x000D4292 File Offset: 0x000D2492
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x000D429F File Offset: 0x000D249F
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				this._LinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.LinkData);
				return this._LinkDataCache;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x000D42D3 File Offset: 0x000D24D3
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
				this._GearLinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.GearLinkData);
				return this._GearLinkDataCache;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x000D4308 File Offset: 0x000D2508
		public virtual List<IWuWaGoMovableGridStatePos> MoveData
		{
			get
			{
				if (this._MoveDataInited)
				{
					return this._MoveDataCache;
				}
				this._MoveDataInited = true;
				int moveDataLength = this.Instance.MoveDataLength;
				this._MoveDataCache = new List<IWuWaGoMovableGridStatePos>(moveDataLength);
				for (int i = 0; i < moveDataLength; i++)
				{
					this._MoveDataCache.Add(IWuWaGoMovableGridStatePos.Create(this.Instance.MoveData(i)));
				}
				return this._MoveDataCache;
			}
		}

		// Token: 0x04003193 RID: 12691
		private IWuWaGoMovableFloor Instance;

		// Token: 0x04003194 RID: 12692
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04003195 RID: 12693
		private bool _LinkDataInited;

		// Token: 0x04003196 RID: 12694
		[Nullable(2)]
		private IWuWaGoGridLinkData _GearLinkDataCache;

		// Token: 0x04003197 RID: 12695
		private bool _GearLinkDataInited;

		// Token: 0x04003198 RID: 12696
		private List<IWuWaGoMovableGridStatePos> _MoveDataCache;

		// Token: 0x04003199 RID: 12697
		private bool _MoveDataInited;
	}
}
