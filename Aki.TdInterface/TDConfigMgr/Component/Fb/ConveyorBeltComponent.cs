using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDF RID: 3039
	[NullableContext(1)]
	[Nullable(0)]
	public class ConveyorBeltComponent : IComponentBase
	{
		// Token: 0x060045D5 RID: 17877 RVA: 0x000B0A3F File Offset: 0x000AEC3F
		public static ConveyorBeltComponent Create(IConveyorBeltComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConveyorBeltComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x000B0A60 File Offset: 0x000AEC60
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x000B0A98 File Offset: 0x000AEC98
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x000B0AB0 File Offset: 0x000AECB0
		public virtual List<IConveyorBeltState> StateGroups
		{
			get
			{
				if (this._StateGroupsInited)
				{
					return this._StateGroupsCache;
				}
				this._StateGroupsInited = true;
				int stateGroupsLength = this.Instance.StateGroupsLength;
				this._StateGroupsCache = new List<IConveyorBeltState>(stateGroupsLength);
				for (int i = 0; i < stateGroupsLength; i++)
				{
					this._StateGroupsCache.Add(IConveyorBeltState.Create(this.Instance.StateGroups(i)));
				}
				return this._StateGroupsCache;
			}
		}

		// Token: 0x040027C4 RID: 10180
		private IConveyorBeltComponent Instance;

		// Token: 0x040027C5 RID: 10181
		private List<IConveyorBeltState> _StateGroupsCache;

		// Token: 0x040027C6 RID: 10182
		private bool _StateGroupsInited;
	}
}
