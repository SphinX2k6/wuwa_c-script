using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B38 RID: 2872
	public class UndergroundComponent : IComponentBase
	{
		// Token: 0x060041B3 RID: 16819 RVA: 0x000A7519 File Offset: 0x000A5719
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

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x000A7538 File Offset: 0x000A5738
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

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x000A7570 File Offset: 0x000A5770
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x000A7586 File Offset: 0x000A5786
		public virtual int TestState
		{
			get
			{
				return this.Instance.TestState;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x000A7593 File Offset: 0x000A5793
		public virtual bool IsRestartPlayer
		{
			get
			{
				return this.Instance.IsRestartPlayer;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x000A75A0 File Offset: 0x000A57A0
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

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x000A7604 File Offset: 0x000A5804
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

		// Token: 0x04002465 RID: 9317
		private IUndergroundComponent Instance;

		// Token: 0x04002466 RID: 9318
		private List<string> _DestroyTagCache;

		// Token: 0x04002467 RID: 9319
		private bool _DestroyTagInited;

		// Token: 0x04002468 RID: 9320
		private List<IUndergroundStateInfo> _StateInfoCache;

		// Token: 0x04002469 RID: 9321
		private bool _StateInfoInited;
	}
}
