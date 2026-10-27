using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCF RID: 3535
	[NullableContext(1)]
	[Nullable(0)]
	public class FurnitureSlotComponent : IComponentBase
	{
		// Token: 0x06005037 RID: 20535 RVA: 0x000C6436 File Offset: 0x000C4636
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

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x000C6458 File Offset: 0x000C4658
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

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06005039 RID: 20537 RVA: 0x000C6490 File Offset: 0x000C4690
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x000C64A8 File Offset: 0x000C46A8
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

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x000C6511 File Offset: 0x000C4711
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

		// Token: 0x04002E0A RID: 11786
		private IFurnitureSlotComponent Instance;

		// Token: 0x04002E0B RID: 11787
		private List<IFurnitureSlot> _SlotsCache;

		// Token: 0x04002E0C RID: 11788
		private bool _SlotsInited;

		// Token: 0x04002E0D RID: 11789
		[Nullable(2)]
		private IFurnitureCamera _FurnitureCameraCache;

		// Token: 0x04002E0E RID: 11790
		private bool _FurnitureCameraInited;
	}
}
