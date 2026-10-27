using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017D RID: 381
	[NullableContext(1)]
	[Nullable(0)]
	public class FurnitureSlotComponent : IComponentBase
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x0001FEDC File Offset: 0x0001E0DC
		private FurnitureSlotComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FurnitureSlotComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FurnitureSlotComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FurnitureSlotComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0001FF14 File Offset: 0x0001E114
		public static FurnitureSlotComponent Create([Nullable(2)] FurnitureSlotComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FurnitureSlotComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001FF27 File Offset: 0x0001E127
		public static FurnitureSlotComponent CreateFromSetValue([Nullable(2)] FurnitureSlotComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FurnitureSlotComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001FF3A File Offset: 0x0001E13A
		public new FurnitureSlotComponent_SetValue ToSetValue()
		{
			return new FurnitureSlotComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Slots = this.Slots,
				FurnitureCamera = this.FurnitureCamera
			};
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001FF74 File Offset: 0x0001E174
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0001FFAE File Offset: 0x0001E1AE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FurnitureSlotComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0001FFE6 File Offset: 0x0001E1E6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00020087 File Offset: 0x0001E287
		public virtual List<IFurnitureSlot> Slots
		{
			get
			{
				if (this._SlotsInited)
				{
					return this._SlotsCache;
				}
				this._SlotsInited = true;
				if (this.FbInstance != null)
				{
					List<IFurnitureSlot> slots = this.FbInstance.Slots;
					if (slots != null)
					{
						this._SlotsCache = new List<IFurnitureSlot>(slots.Count);
						for (int i = 0; i < slots.Count; i++)
						{
							this._SlotsCache.Add(IFurnitureSlot.Create(slots[i]));
						}
					}
				}
				else
				{
					FurnitureSlotComponent_SetValue pocoInterface = this.PocoInterface;
					this._SlotsCache = ((pocoInterface != null) ? pocoInterface.Slots : null);
				}
				return this._SlotsCache;
			}
			set
			{
				this.GetOrCreatePoco().Slots = value;
				this._SlotsInited = false;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0002009C File Offset: 0x0001E29C
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000200FD File Offset: 0x0001E2FD
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
				if (this.FbInstance != null)
				{
					this._FurnitureCameraCache = IFurnitureCamera.Create(this.FbInstance.FurnitureCamera);
				}
				else
				{
					FurnitureSlotComponent_SetValue pocoInterface = this.PocoInterface;
					this._FurnitureCameraCache = ((pocoInterface != null) ? pocoInterface.FurnitureCamera : null);
				}
				return this._FurnitureCameraCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FurnitureCamera = value;
				this._FurnitureCameraInited = false;
			}
		}

		// Token: 0x04000746 RID: 1862
		[Nullable(2)]
		protected new FurnitureSlotComponent FbInstance;

		// Token: 0x04000747 RID: 1863
		[Nullable(2)]
		protected new FurnitureSlotComponent_SetValue PocoInterface;

		// Token: 0x04000748 RID: 1864
		private List<IFurnitureSlot> _SlotsCache;

		// Token: 0x04000749 RID: 1865
		private bool _SlotsInited;

		// Token: 0x0400074A RID: 1866
		private IFurnitureCamera _FurnitureCameraCache;

		// Token: 0x0400074B RID: 1867
		private bool _FurnitureCameraInited;
	}
}
