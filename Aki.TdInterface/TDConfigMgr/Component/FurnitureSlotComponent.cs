using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000194 RID: 404
	public class FurnitureSlotComponent : IComponentBase
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x00020AB8 File Offset: 0x0001ECB8
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

		// Token: 0x06000545 RID: 1349 RVA: 0x00020AF0 File Offset: 0x0001ECF0
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

		// Token: 0x06000546 RID: 1350 RVA: 0x00020B03 File Offset: 0x0001ED03
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

		// Token: 0x06000547 RID: 1351 RVA: 0x00020B16 File Offset: 0x0001ED16
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00020B50 File Offset: 0x0001ED50
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00020B8A File Offset: 0x0001ED8A
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00020B98 File Offset: 0x0001ED98
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00020BC2 File Offset: 0x0001EDC2
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00020C63 File Offset: 0x0001EE63
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00020C78 File Offset: 0x0001EE78
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00020CD9 File Offset: 0x0001EED9
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

		// Token: 0x0400079C RID: 1948
		[Nullable(2)]
		protected new FurnitureSlotComponent FbInstance;

		// Token: 0x0400079D RID: 1949
		[Nullable(2)]
		protected new FurnitureSlotComponent_SetValue PocoInterface;

		// Token: 0x0400079E RID: 1950
		private List<IFurnitureSlot> _SlotsCache;

		// Token: 0x0400079F RID: 1951
		private bool _SlotsInited;

		// Token: 0x040007A0 RID: 1952
		private IFurnitureCamera _FurnitureCameraCache;

		// Token: 0x040007A1 RID: 1953
		private bool _FurnitureCameraInited;
	}
}
