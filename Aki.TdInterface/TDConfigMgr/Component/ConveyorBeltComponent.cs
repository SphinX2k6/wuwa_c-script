using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004C RID: 76
	[NullableContext(1)]
	[Nullable(0)]
	public class ConveyorBeltComponent : IComponentBase
	{
		// Token: 0x0600027C RID: 636 RVA: 0x000198D8 File Offset: 0x00017AD8
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

		// Token: 0x0600027D RID: 637 RVA: 0x00019910 File Offset: 0x00017B10
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

		// Token: 0x0600027E RID: 638 RVA: 0x00019923 File Offset: 0x00017B23
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

		// Token: 0x0600027F RID: 639 RVA: 0x00019936 File Offset: 0x00017B36
		public new ConveyorBeltComponent_SetValue ToSetValue()
		{
			return new ConveyorBeltComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				StateGroups = this.StateGroups
			};
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00019964 File Offset: 0x00017B64
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0001999E File Offset: 0x00017B9E
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000199AC File Offset: 0x00017BAC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000199D6 File Offset: 0x00017BD6
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000199E4 File Offset: 0x00017BE4
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00019A77 File Offset: 0x00017C77
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

		// Token: 0x0400018D RID: 397
		[Nullable(2)]
		protected new ConveyorBeltComponent FbInstance;

		// Token: 0x0400018E RID: 398
		[Nullable(2)]
		protected new ConveyorBeltComponent_SetValue PocoInterface;

		// Token: 0x0400018F RID: 399
		private List<IConveyorBeltState> _StateGroupsCache;

		// Token: 0x04000190 RID: 400
		private bool _StateGroupsInited;
	}
}
