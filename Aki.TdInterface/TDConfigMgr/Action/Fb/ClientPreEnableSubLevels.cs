using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C4 RID: 9924
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientPreEnableSubLevels : ActionParams
	{
		// Token: 0x0600DDF5 RID: 56821 RVA: 0x0020F266 File Offset: 0x0020D466
		public static ClientPreEnableSubLevels Create(IClientPreEnableSubLevels? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientPreEnableSubLevels
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x0600DDF6 RID: 56822 RVA: 0x0020F288 File Offset: 0x0020D488
		public virtual List<string> EnableLevels
		{
			get
			{
				if (this._EnableLevelsInited)
				{
					return this._EnableLevelsCache;
				}
				this._EnableLevelsInited = true;
				int enableLevelsLength = this.Instance.EnableLevelsLength;
				this._EnableLevelsCache = new List<string>(enableLevelsLength);
				for (int i = 0; i < enableLevelsLength; i++)
				{
					this._EnableLevelsCache.Add(this.Instance.EnableLevels(i));
				}
				return this._EnableLevelsCache;
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x0020F2EC File Offset: 0x0020D4EC
		public virtual List<string> DisableLevels
		{
			get
			{
				if (this._DisableLevelsInited)
				{
					return this._DisableLevelsCache;
				}
				this._DisableLevelsInited = true;
				int disableLevelsLength = this.Instance.DisableLevelsLength;
				this._DisableLevelsCache = new List<string>(disableLevelsLength);
				for (int i = 0; i < disableLevelsLength; i++)
				{
					this._DisableLevelsCache.Add(this.Instance.DisableLevels(i));
				}
				return this._DisableLevelsCache;
			}
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x0600DDF8 RID: 56824 RVA: 0x0020F350 File Offset: 0x0020D550
		[Nullable(2)]
		public virtual IEnableSubLevelTransitionWithSceneCapture TransitionOption
		{
			[NullableContext(2)]
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = IEnableSubLevelTransitionWithSceneCapture.Create(this.Instance.TransitionOption);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0600DDF9 RID: 56825 RVA: 0x0020F384 File Offset: 0x0020D584
		public virtual bool? IsWaitForEnableComplete
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsWaitForEnableComplete);
			}
		}

		// Token: 0x04007B3A RID: 31546
		private IClientPreEnableSubLevels Instance;

		// Token: 0x04007B3B RID: 31547
		private List<string> _EnableLevelsCache;

		// Token: 0x04007B3C RID: 31548
		private bool _EnableLevelsInited;

		// Token: 0x04007B3D RID: 31549
		private List<string> _DisableLevelsCache;

		// Token: 0x04007B3E RID: 31550
		private bool _DisableLevelsInited;

		// Token: 0x04007B3F RID: 31551
		[Nullable(2)]
		private IEnableSubLevelTransitionWithSceneCapture _TransitionOptionCache;

		// Token: 0x04007B40 RID: 31552
		private bool _TransitionOptionInited;
	}
}
