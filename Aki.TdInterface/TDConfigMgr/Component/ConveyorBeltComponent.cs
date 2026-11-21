using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004C RID: 76
	public class ConveyorBeltComponent : IComponentBase
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0001A24C File Offset: 0x0001844C
		private ConveyorBeltComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ConveyorBeltComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ConveyorBeltComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ConveyorBeltComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001A284 File Offset: 0x00018484
		public static ConveyorBeltComponent Create([Nullable(2)] ConveyorBeltComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConveyorBeltComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001A297 File Offset: 0x00018497
		public static ConveyorBeltComponent CreateFromSetValue([Nullable(2)] ConveyorBeltComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ConveyorBeltComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001A2AA File Offset: 0x000184AA
		public new ConveyorBeltComponent_SetValue ToSetValue()
		{
			return new ConveyorBeltComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				StateGroups = this.StateGroups
			};
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001A2D8 File Offset: 0x000184D8
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0001A312 File Offset: 0x00018512
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ConveyorBeltComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001A320 File Offset: 0x00018520
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0001A34A File Offset: 0x0001854A
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001A358 File Offset: 0x00018558
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0001A3EB File Offset: 0x000185EB
		public virtual List<IConveyorBeltState> StateGroups
		{
			get
			{
				if (this._StateGroupsInited)
				{
					return this._StateGroupsCache;
				}
				this._StateGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<IConveyorBeltState> stateGroups = this.FbInstance.StateGroups;
					if (stateGroups != null)
					{
						this._StateGroupsCache = new List<IConveyorBeltState>(stateGroups.Count);
						for (int i = 0; i < stateGroups.Count; i++)
						{
							this._StateGroupsCache.Add(IConveyorBeltState.Create(stateGroups[i]));
						}
					}
				}
				else
				{
					ConveyorBeltComponent_SetValue pocoInterface = this.PocoInterface;
					this._StateGroupsCache = ((pocoInterface != null) ? pocoInterface.StateGroups : null);
				}
				return this._StateGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().StateGroups = value;
				this._StateGroupsInited = false;
			}
		}

		// Token: 0x04000192 RID: 402
		[Nullable(2)]
		protected new ConveyorBeltComponent FbInstance;

		// Token: 0x04000193 RID: 403
		[Nullable(2)]
		protected new ConveyorBeltComponent_SetValue PocoInterface;

		// Token: 0x04000194 RID: 404
		private List<IConveyorBeltState> _StateGroupsCache;

		// Token: 0x04000195 RID: 405
		private bool _StateGroupsInited;
	}
}
