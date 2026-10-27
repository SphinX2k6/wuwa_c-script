using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001501 RID: 5377
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientPreEnableSubLevels : ActionParams
	{
		// Token: 0x06007A3C RID: 31292 RVA: 0x00123FA8 File Offset: 0x001221A8
		private ClientPreEnableSubLevels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientPreEnableSubLevels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientPreEnableSubLevels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientPreEnableSubLevels_SetValue());
			}
			return result;
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00123FE0 File Offset: 0x001221E0
		public static ClientPreEnableSubLevels Create([Nullable(2)] ClientPreEnableSubLevels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientPreEnableSubLevels
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00123FF3 File Offset: 0x001221F3
		public static ClientPreEnableSubLevels CreateFromSetValue([Nullable(2)] ClientPreEnableSubLevels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientPreEnableSubLevels
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00124006 File Offset: 0x00122206
		public ClientPreEnableSubLevels_SetValue ToSetValue()
		{
			return new ClientPreEnableSubLevels_SetValue
			{
				EnableLevels = this.EnableLevels,
				DisableLevels = this.DisableLevels,
				TransitionOption = this.TransitionOption,
				IsWaitForEnableComplete = this.IsWaitForEnableComplete
			};
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x06007A40 RID: 31296 RVA: 0x0012403D File Offset: 0x0012223D
		// (set) Token: 0x06007A41 RID: 31297 RVA: 0x00124064 File Offset: 0x00122264
		public virtual List<string> EnableLevels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableLevels;
				}
				ClientPreEnableSubLevels_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableLevels;
			}
			set
			{
				this.GetOrCreatePoco().EnableLevels = value;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x06007A42 RID: 31298 RVA: 0x00124072 File Offset: 0x00122272
		// (set) Token: 0x06007A43 RID: 31299 RVA: 0x00124099 File Offset: 0x00122299
		public virtual List<string> DisableLevels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableLevels;
				}
				ClientPreEnableSubLevels_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableLevels;
			}
			set
			{
				this.GetOrCreatePoco().DisableLevels = value;
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x001240A8 File Offset: 0x001222A8
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x00124109 File Offset: 0x00122309
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
				if (this.FbInstance != null)
				{
					this._TransitionOptionCache = IEnableSubLevelTransitionWithSceneCapture.Create(this.FbInstance.TransitionOption);
				}
				else
				{
					ClientPreEnableSubLevels_SetValue pocoInterface = this.PocoInterface;
					this._TransitionOptionCache = ((pocoInterface != null) ? pocoInterface.TransitionOption : null);
				}
				return this._TransitionOptionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
				this._TransitionOptionInited = false;
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x00124120 File Offset: 0x00122320
		// (set) Token: 0x06007A47 RID: 31303 RVA: 0x0012415A File Offset: 0x0012235A
		public virtual bool? IsWaitForEnableComplete
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWaitForEnableComplete;
				}
				ClientPreEnableSubLevels_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWaitForEnableComplete;
			}
			set
			{
				this.GetOrCreatePoco().IsWaitForEnableComplete = value;
			}
		}

		// Token: 0x040046D2 RID: 18130
		[Nullable(2)]
		protected new ClientPreEnableSubLevels FbInstance;

		// Token: 0x040046D3 RID: 18131
		[Nullable(2)]
		protected ClientPreEnableSubLevels_SetValue PocoInterface;

		// Token: 0x040046D4 RID: 18132
		private IEnableSubLevelTransitionWithSceneCapture _TransitionOptionCache;

		// Token: 0x040046D5 RID: 18133
		private bool _TransitionOptionInited;
	}
}
