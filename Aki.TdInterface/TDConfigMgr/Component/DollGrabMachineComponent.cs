using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000052 RID: 82
	public class DollGrabMachineComponent : IComponentBase
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0001AD58 File Offset: 0x00018F58
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

		// Token: 0x060002BF RID: 703 RVA: 0x0001AD90 File Offset: 0x00018F90
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

		// Token: 0x060002C0 RID: 704 RVA: 0x0001ADA3 File Offset: 0x00018FA3
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

		// Token: 0x060002C1 RID: 705 RVA: 0x0001ADB8 File Offset: 0x00018FB8
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001AE2C File Offset: 0x0001902C
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0001AE66 File Offset: 0x00019066
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001AE74 File Offset: 0x00019074
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0001AE9E File Offset: 0x0001909E
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001AEAC File Offset: 0x000190AC
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0001AED7 File Offset: 0x000190D7
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001AEE5 File Offset: 0x000190E5
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001AF14 File Offset: 0x00019114
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001AF24 File Offset: 0x00019124
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0001AF5E File Offset: 0x0001915E
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0001AF6C File Offset: 0x0001916C
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001AFFF File Offset: 0x000191FF
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0001B014 File Offset: 0x00019214
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0001B075 File Offset: 0x00019275
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0001B08A File Offset: 0x0001928A
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0001B0B1 File Offset: 0x000192B1
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

		// Token: 0x040001C6 RID: 454
		[Nullable(2)]
		protected new DollGrabMachineComponent FbInstance;

		// Token: 0x040001C7 RID: 455
		[Nullable(2)]
		protected new DollGrabMachineComponent_SetValue PocoInterface;

		// Token: 0x040001C8 RID: 456
		private List<IDollGrabItem> _ItemsCache;

		// Token: 0x040001C9 RID: 457
		private bool _ItemsInited;

		// Token: 0x040001CA RID: 458
		private IDollGrabInfiniteModeData _InfiniteModeDataCache;

		// Token: 0x040001CB RID: 459
		private bool _InfiniteModeDataInited;
	}
}
