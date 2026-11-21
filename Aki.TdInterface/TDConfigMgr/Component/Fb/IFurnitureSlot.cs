using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EC9 RID: 3785
	[NullableContext(2)]
	[Nullable(0)]
	public class IFurnitureSlot
	{
		// Token: 0x0600554E RID: 21838 RVA: 0x000D1A25 File Offset: 0x000CFC25
		[NullableContext(0)]
		public static IFurnitureSlot Create(IFurnitureSlot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFurnitureSlot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x000D1A44 File Offset: 0x000CFC44
		public virtual IFurnitureCamera SlotCamera
		{
			get
			{
				if (this._SlotCameraInited)
				{
					return this._SlotCameraCache;
				}
				this._SlotCameraInited = true;
				this._SlotCameraCache = IFurnitureCamera.Create(this.Instance.SlotCamera);
				return this._SlotCameraCache;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x000D1A78 File Offset: 0x000CFC78
		[Nullable(0)]
		public virtual ISlotShape SlotShape
		{
			[NullableContext(0)]
			get
			{
				if (this._SlotShapeInited)
				{
					return this._SlotShapeCache;
				}
				this._SlotShapeInited = true;
				this._SlotShapeCache = ISlotShape.Create(this.Instance.SlotShape);
				return this._SlotShapeCache;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x000D1AAC File Offset: 0x000CFCAC
		public virtual int FurnitureTag
		{
			get
			{
				return this.Instance.FurnitureTag;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x000D1ABC File Offset: 0x000CFCBC
		public virtual List<int> ExcludedFurnitureIds
		{
			get
			{
				if (this._ExcludedFurnitureIdsInited)
				{
					return this._ExcludedFurnitureIdsCache;
				}
				this._ExcludedFurnitureIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int excludedFurnitureIdsLength = this.Instance.ExcludedFurnitureIdsLength;
				this._ExcludedFurnitureIdsCache = new List<int>(excludedFurnitureIdsLength);
				for (int i = 0; i < excludedFurnitureIdsLength; i++)
				{
					this._ExcludedFurnitureIdsCache.Add(this.Instance.ExcludedFurnitureIds(i));
				}
				return this._ExcludedFurnitureIdsCache;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x000D1B34 File Offset: 0x000CFD34
		public virtual int? EdPreviewFurnitureId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040030C2 RID: 12482
		private IFurnitureSlot Instance;

		// Token: 0x040030C3 RID: 12483
		private IFurnitureCamera _SlotCameraCache;

		// Token: 0x040030C4 RID: 12484
		private bool _SlotCameraInited;

		// Token: 0x040030C5 RID: 12485
		private ISlotShape _SlotShapeCache;

		// Token: 0x040030C6 RID: 12486
		private bool _SlotShapeInited;

		// Token: 0x040030C7 RID: 12487
		private List<int> _ExcludedFurnitureIdsCache;

		// Token: 0x040030C8 RID: 12488
		private bool _ExcludedFurnitureIdsInited;
	}
}
