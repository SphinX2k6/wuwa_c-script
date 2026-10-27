using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCD RID: 3533
	[NullableContext(2)]
	[Nullable(0)]
	public class IFurnitureSlot
	{
		// Token: 0x06005029 RID: 20521 RVA: 0x000C61D5 File Offset: 0x000C43D5
		[NullableContext(1)]
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

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x000C61F4 File Offset: 0x000C43F4
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

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600502B RID: 20523 RVA: 0x000C6228 File Offset: 0x000C4428
		[Nullable(1)]
		public virtual ISlotShape SlotShape
		{
			[NullableContext(1)]
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x000C625C File Offset: 0x000C445C
		public virtual int FurnitureTag
		{
			get
			{
				return this.Instance.FurnitureTag;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600502D RID: 20525 RVA: 0x000C626C File Offset: 0x000C446C
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

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x000C62E4 File Offset: 0x000C44E4
		public virtual int? EdPreviewFurnitureId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002DFC RID: 11772
		private IFurnitureSlot Instance;

		// Token: 0x04002DFD RID: 11773
		private IFurnitureCamera _SlotCameraCache;

		// Token: 0x04002DFE RID: 11774
		private bool _SlotCameraInited;

		// Token: 0x04002DFF RID: 11775
		private ISlotShape _SlotShapeCache;

		// Token: 0x04002E00 RID: 11776
		private bool _SlotShapeInited;

		// Token: 0x04002E01 RID: 11777
		private List<int> _ExcludedFurnitureIdsCache;

		// Token: 0x04002E02 RID: 11778
		private bool _ExcludedFurnitureIdsInited;
	}
}
