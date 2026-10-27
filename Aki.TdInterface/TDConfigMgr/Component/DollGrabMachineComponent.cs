using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000052 RID: 82
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineComponent : IComponentBase
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0001A3E4 File Offset: 0x000185E4
		private DollGrabMachineComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DollGrabMachineComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DollGrabMachineComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DollGrabMachineComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001A41C File Offset: 0x0001861C
		public static DollGrabMachineComponent Create([Nullable(2)] DollGrabMachineComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabMachineComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001A42F File Offset: 0x0001862F
		public static DollGrabMachineComponent CreateFromSetValue([Nullable(2)] DollGrabMachineComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DollGrabMachineComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001A444 File Offset: 0x00018644
		public new DollGrabMachineComponent_SetValue ToSetValue()
		{
			return new DollGrabMachineComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BelongType = this.BelongType,
				TimeLimit = this.TimeLimit,
				PlayCost = this.PlayCost,
				Items = this.Items,
				InfiniteModeData = this.InfiniteModeData,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0001A4B8 File Offset: 0x000186B8
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0001A4F2 File Offset: 0x000186F2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DollGrabMachineComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001A500 File Offset: 0x00018700
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0001A52A File Offset: 0x0001872A
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001A538 File Offset: 0x00018738
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BelongType;
				}
				if (this.PocoInterface == null)
				{
					return EDollGrabShowcaseBelongType.LandOfXuanfang;
				}
				return this.PocoInterface.BelongType;
			}
			set
			{
				this.GetOrCreatePoco().BelongType = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001A571 File Offset: 0x00018771
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0001A5A0 File Offset: 0x000187A0
		public virtual float TimeLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeLimit;
			}
			set
			{
				this.GetOrCreatePoco().TimeLimit = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001A5B0 File Offset: 0x000187B0
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0001A5EA File Offset: 0x000187EA
		public virtual float? PlayCost
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayCost;
				}
				DollGrabMachineComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayCost;
			}
			set
			{
				this.GetOrCreatePoco().PlayCost = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001A5F8 File Offset: 0x000187F8
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001A68B File Offset: 0x0001888B
		public virtual List<IDollGrabItem> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				if (this.FbInstance != null)
				{
					List<IDollGrabItem> items = this.FbInstance.Items;
					if (items != null)
					{
						this._ItemsCache = new List<IDollGrabItem>(items.Count);
						for (int i = 0; i < items.Count; i++)
						{
							this._ItemsCache.Add(IDollGrabItem.Create(items[i]));
						}
					}
				}
				else
				{
					DollGrabMachineComponent_SetValue pocoInterface = this.PocoInterface;
					this._ItemsCache = ((pocoInterface != null) ? pocoInterface.Items : null);
				}
				return this._ItemsCache;
			}
			set
			{
				this.GetOrCreatePoco().Items = value;
				this._ItemsInited = false;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001A6A0 File Offset: 0x000188A0
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0001A701 File Offset: 0x00018901
		[Nullable(2)]
		public virtual IDollGrabInfiniteModeData InfiniteModeData
		{
			[NullableContext(2)]
			get
			{
				if (this._InfiniteModeDataInited)
				{
					return this._InfiniteModeDataCache;
				}
				this._InfiniteModeDataInited = true;
				if (this.FbInstance != null)
				{
					this._InfiniteModeDataCache = IDollGrabInfiniteModeData.Create(this.FbInstance.InfiniteModeData);
				}
				else
				{
					DollGrabMachineComponent_SetValue pocoInterface = this.PocoInterface;
					this._InfiniteModeDataCache = ((pocoInterface != null) ? pocoInterface.InfiniteModeData : null);
				}
				return this._InfiniteModeDataCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InfiniteModeData = value;
				this._InfiniteModeDataInited = false;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0001A716 File Offset: 0x00018916
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001A73D File Offset: 0x0001893D
		[Nullable(2)]
		public virtual string AkEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				DollGrabMachineComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AkEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x040001C1 RID: 449
		[Nullable(2)]
		protected new DollGrabMachineComponent FbInstance;

		// Token: 0x040001C2 RID: 450
		[Nullable(2)]
		protected new DollGrabMachineComponent_SetValue PocoInterface;

		// Token: 0x040001C3 RID: 451
		private List<IDollGrabItem> _ItemsCache;

		// Token: 0x040001C4 RID: 452
		private bool _ItemsInited;

		// Token: 0x040001C5 RID: 453
		private IDollGrabInfiniteModeData _InfiniteModeDataCache;

		// Token: 0x040001C6 RID: 454
		private bool _InfiniteModeDataInited;
	}
}
