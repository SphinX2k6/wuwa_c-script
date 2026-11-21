using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAE RID: 3246
	public class ConveyorBeltComponent : IComponentBase
	{
		// Token: 0x06004A33 RID: 18995 RVA: 0x000BABBB File Offset: 0x000B8DBB
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06004A34 RID: 18996 RVA: 0x000BABDC File Offset: 0x000B8DDC
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

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x000BAC14 File Offset: 0x000B8E14
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06004A36 RID: 18998 RVA: 0x000BAC2C File Offset: 0x000B8E2C
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

		// Token: 0x04002A0F RID: 10767
		private IConveyorBeltComponent Instance;

		// Token: 0x04002A10 RID: 10768
		private List<IConveyorBeltState> _StateGroupsCache;

		// Token: 0x04002A11 RID: 10769
		private bool _StateGroupsInited;
	}
}
