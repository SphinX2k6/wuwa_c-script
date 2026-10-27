using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A6E RID: 2670
	[NullableContext(1)]
	[Nullable(0)]
	public class UndergroundComponent : IComponentBase
	{
		// Token: 0x06003D8A RID: 15754 RVA: 0x0009DF61 File Offset: 0x0009C161
		public static UndergroundComponent Create(IUndergroundComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UndergroundComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x0009DF80 File Offset: 0x0009C180
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

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x0009DFB8 File Offset: 0x0009C1B8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x0009DFCE File Offset: 0x0009C1CE
		public virtual int TestState
		{
			get
			{
				return this.Instance.TestState;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x0009DFDB File Offset: 0x0009C1DB
		public virtual bool IsRestartPlayer
		{
			get
			{
				return this.Instance.IsRestartPlayer;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x0009DFE8 File Offset: 0x0009C1E8
		public virtual List<string> DestroyTag
		{
			get
			{
				if (this._DestroyTagInited)
				{
					return this._DestroyTagCache;
				}
				this._DestroyTagInited = true;
				int destroyTagLength = this.Instance.DestroyTagLength;
				this._DestroyTagCache = new List<string>(destroyTagLength);
				for (int i = 0; i < destroyTagLength; i++)
				{
					this._DestroyTagCache.Add(this.Instance.DestroyTag(i));
				}
				return this._DestroyTagCache;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003D90 RID: 15760 RVA: 0x0009E04C File Offset: 0x0009C24C
		public virtual List<IUndergroundStateInfo> StateInfo
		{
			get
			{
				if (this._StateInfoInited)
				{
					return this._StateInfoCache;
				}
				this._StateInfoInited = true;
				int stateInfoLength = this.Instance.StateInfoLength;
				this._StateInfoCache = new List<IUndergroundStateInfo>(stateInfoLength);
				for (int i = 0; i < stateInfoLength; i++)
				{
					this._StateInfoCache.Add(IUndergroundStateInfo.Create(this.Instance.StateInfo(i)));
				}
				return this._StateInfoCache;
			}
		}

		// Token: 0x04002249 RID: 8777
		private IUndergroundComponent Instance;

		// Token: 0x0400224A RID: 8778
		private List<string> _DestroyTagCache;

		// Token: 0x0400224B RID: 8779
		private bool _DestroyTagInited;

		// Token: 0x0400224C RID: 8780
		private List<IUndergroundStateInfo> _StateInfoCache;

		// Token: 0x0400224D RID: 8781
		private bool _StateInfoInited;
	}
}
