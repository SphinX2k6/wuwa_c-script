using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000423 RID: 1059
	public class IFurnitureSlot
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x00043158 File Offset: 0x00041358
		private IFurnitureSlot_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFurnitureSlot 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFurnitureSlot_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFurnitureSlot_SetValue());
			}
			return result;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00043190 File Offset: 0x00041390
		public static IFurnitureSlot Create([Nullable(2)] IFurnitureSlot instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFurnitureSlot
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000431A3 File Offset: 0x000413A3
		public static IFurnitureSlot CreateFromSetValue([Nullable(2)] IFurnitureSlot_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFurnitureSlot
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000431B8 File Offset: 0x000413B8
		public IFurnitureSlot_SetValue ToSetValue()
		{
			return new IFurnitureSlot_SetValue
			{
				SlotCamera = this.SlotCamera,
				SlotShape = this.SlotShape,
				FurnitureTag = this.FurnitureTag,
				ExcludedFurnitureIds = this.ExcludedFurnitureIds,
				EdPreviewFurnitureId = this.EdPreviewFurnitureId
			};
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00043208 File Offset: 0x00041408
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00043269 File Offset: 0x00041469
		[Nullable(2)]
		public virtual IFurnitureCamera SlotCamera
		{
			[NullableContext(2)]
			get
			{
				if (this._SlotCameraInited)
				{
					return this._SlotCameraCache;
				}
				this._SlotCameraInited = true;
				if (this.FbInstance != null)
				{
					this._SlotCameraCache = IFurnitureCamera.Create(this.FbInstance.SlotCamera);
				}
				else
				{
					IFurnitureSlot_SetValue pocoInterface = this.PocoInterface;
					this._SlotCameraCache = ((pocoInterface != null) ? pocoInterface.SlotCamera : null);
				}
				return this._SlotCameraCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SlotCamera = value;
				this._SlotCameraInited = false;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00043280 File Offset: 0x00041480
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x000432E1 File Offset: 0x000414E1
		public virtual ISlotShape SlotShape
		{
			get
			{
				if (this._SlotShapeInited)
				{
					return this._SlotShapeCache;
				}
				this._SlotShapeInited = true;
				if (this.FbInstance != null)
				{
					this._SlotShapeCache = ISlotShape.Create(this.FbInstance.SlotShape);
				}
				else
				{
					IFurnitureSlot_SetValue pocoInterface = this.PocoInterface;
					this._SlotShapeCache = ((pocoInterface != null) ? pocoInterface.SlotShape : null);
				}
				return this._SlotShapeCache;
			}
			set
			{
				this.GetOrCreatePoco().SlotShape = value;
				this._SlotShapeInited = false;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000432F6 File Offset: 0x000414F6
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x00043321 File Offset: 0x00041521
		public virtual int FurnitureTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FurnitureTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FurnitureTag;
			}
			set
			{
				this.GetOrCreatePoco().FurnitureTag = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0004332F File Offset: 0x0004152F
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x00043356 File Offset: 0x00041556
		[Nullable(2)]
		public virtual List<int> ExcludedFurnitureIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludedFurnitureIds;
				}
				IFurnitureSlot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludedFurnitureIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExcludedFurnitureIds = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00043364 File Offset: 0x00041564
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0004338E File Offset: 0x0004158E
		public virtual int? EdPreviewFurnitureId
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPreviewFurnitureId;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPreviewFurnitureId = value;
			}
		}

		// Token: 0x040010A5 RID: 4261
		[Nullable(2)]
		protected IFurnitureSlot FbInstance;

		// Token: 0x040010A6 RID: 4262
		[Nullable(2)]
		protected IFurnitureSlot_SetValue PocoInterface;

		// Token: 0x040010A7 RID: 4263
		private IFurnitureCamera _SlotCameraCache;

		// Token: 0x040010A8 RID: 4264
		private bool _SlotCameraInited;

		// Token: 0x040010A9 RID: 4265
		private ISlotShape _SlotShapeCache;

		// Token: 0x040010AA RID: 4266
		private bool _SlotShapeInited;
	}
}
