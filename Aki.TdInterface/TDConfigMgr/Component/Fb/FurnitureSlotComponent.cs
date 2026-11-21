using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ECB RID: 3787
	public class FurnitureSlotComponent : IComponentBase
	{
		// Token: 0x0600555C RID: 21852 RVA: 0x000D1C86 File Offset: 0x000CFE86
		public static FurnitureSlotComponent Create(IFurnitureSlotComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FurnitureSlotComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x000D1CA8 File Offset: 0x000CFEA8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x000D1CE0 File Offset: 0x000CFEE0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x000D1CF8 File Offset: 0x000CFEF8
		public virtual List<IFurnitureSlot> Slots
		{
			get
			{
				if (this._SlotsInited)
				{
					return this._SlotsCache;
				}
				this._SlotsInited = true;
				int slotsLength = this.Instance.SlotsLength;
				this._SlotsCache = new List<IFurnitureSlot>(slotsLength);
				for (int i = 0; i < slotsLength; i++)
				{
					this._SlotsCache.Add(IFurnitureSlot.Create(this.Instance.Slots(i)));
				}
				return this._SlotsCache;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x000D1D61 File Offset: 0x000CFF61
		[Nullable(2)]
		public virtual IFurnitureCamera FurnitureCamera
		{
			[NullableContext(2)]
			get
			{
				if (this._FurnitureCameraInited)
				{
					return this._FurnitureCameraCache;
				}
				this._FurnitureCameraInited = true;
				this._FurnitureCameraCache = IFurnitureCamera.Create(this.Instance.FurnitureCamera);
				return this._FurnitureCameraCache;
			}
		}

		// Token: 0x040030D0 RID: 12496
		private IFurnitureSlotComponent Instance;

		// Token: 0x040030D1 RID: 12497
		private List<IFurnitureSlot> _SlotsCache;

		// Token: 0x040030D2 RID: 12498
		private bool _SlotsInited;

		// Token: 0x040030D3 RID: 12499
		[Nullable(2)]
		private IFurnitureCamera _FurnitureCameraCache;

		// Token: 0x040030D4 RID: 12500
		private bool _FurnitureCameraInited;
	}
}
