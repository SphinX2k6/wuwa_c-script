using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002988 RID: 10632
	public class ClientPreEnableSubLevels : ActionParams
	{
		// Token: 0x0600EBD1 RID: 60369 RVA: 0x0022BAA6 File Offset: 0x00229CA6
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

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x0600EBD2 RID: 60370 RVA: 0x0022BAC8 File Offset: 0x00229CC8
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

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x0600EBD3 RID: 60371 RVA: 0x0022BB2C File Offset: 0x00229D2C
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

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x0600EBD4 RID: 60372 RVA: 0x0022BB90 File Offset: 0x00229D90
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

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x0600EBD5 RID: 60373 RVA: 0x0022BBC4 File Offset: 0x00229DC4
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

		// Token: 0x040081DA RID: 33242
		private IClientPreEnableSubLevels Instance;

		// Token: 0x040081DB RID: 33243
		private List<string> _EnableLevelsCache;

		// Token: 0x040081DC RID: 33244
		private bool _EnableLevelsInited;

		// Token: 0x040081DD RID: 33245
		private List<string> _DisableLevelsCache;

		// Token: 0x040081DE RID: 33246
		private bool _DisableLevelsInited;

		// Token: 0x040081DF RID: 33247
		[Nullable(2)]
		private IEnableSubLevelTransitionWithSceneCapture _TransitionOptionCache;

		// Token: 0x040081E0 RID: 33248
		private bool _TransitionOptionInited;
	}
}
