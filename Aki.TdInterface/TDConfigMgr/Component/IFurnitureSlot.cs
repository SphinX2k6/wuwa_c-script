using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003CC RID: 972
	[NullableContext(1)]
	[Nullable(0)]
	public class IFurnitureSlot
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x0003F5D8 File Offset: 0x0003D7D8
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

		// Token: 0x06001384 RID: 4996 RVA: 0x0003F610 File Offset: 0x0003D810
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

		// Token: 0x06001385 RID: 4997 RVA: 0x0003F623 File Offset: 0x0003D823
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

		// Token: 0x06001386 RID: 4998 RVA: 0x0003F638 File Offset: 0x0003D838
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003F688 File Offset: 0x0003D888
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0003F6E9 File Offset: 0x0003D8E9
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003F700 File Offset: 0x0003D900
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x0003F761 File Offset: 0x0003D961
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

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003F776 File Offset: 0x0003D976
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0003F7A1 File Offset: 0x0003D9A1
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0003F7AF File Offset: 0x0003D9AF
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0003F7D6 File Offset: 0x0003D9D6
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0003F7E4 File Offset: 0x0003D9E4
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0003F80E File Offset: 0x0003DA0E
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

		// Token: 0x04000F8C RID: 3980
		[Nullable(2)]
		protected IFurnitureSlot FbInstance;

		// Token: 0x04000F8D RID: 3981
		[Nullable(2)]
		protected IFurnitureSlot_SetValue PocoInterface;

		// Token: 0x04000F8E RID: 3982
		private IFurnitureCamera _SlotCameraCache;

		// Token: 0x04000F8F RID: 3983
		private bool _SlotCameraInited;

		// Token: 0x04000F90 RID: 3984
		private ISlotShape _SlotShapeCache;

		// Token: 0x04000F91 RID: 3985
		private bool _SlotShapeInited;
	}
}
