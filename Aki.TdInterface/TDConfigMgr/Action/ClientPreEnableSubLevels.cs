using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165C RID: 5724
	public class ClientPreEnableSubLevels : ActionParams
	{
		// Token: 0x0600810F RID: 33039 RVA: 0x00132C88 File Offset: 0x00130E88
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

		// Token: 0x06008110 RID: 33040 RVA: 0x00132CC0 File Offset: 0x00130EC0
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

		// Token: 0x06008111 RID: 33041 RVA: 0x00132CD3 File Offset: 0x00130ED3
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

		// Token: 0x06008112 RID: 33042 RVA: 0x00132CE6 File Offset: 0x00130EE6
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

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x06008113 RID: 33043 RVA: 0x00132D1D File Offset: 0x00130F1D
		// (set) Token: 0x06008114 RID: 33044 RVA: 0x00132D44 File Offset: 0x00130F44
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

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x06008115 RID: 33045 RVA: 0x00132D52 File Offset: 0x00130F52
		// (set) Token: 0x06008116 RID: 33046 RVA: 0x00132D79 File Offset: 0x00130F79
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

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x00132D88 File Offset: 0x00130F88
		// (set) Token: 0x06008118 RID: 33048 RVA: 0x00132DE9 File Offset: 0x00130FE9
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

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x06008119 RID: 33049 RVA: 0x00132E00 File Offset: 0x00131000
		// (set) Token: 0x0600811A RID: 33050 RVA: 0x00132E3A File Offset: 0x0013103A
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

		// Token: 0x04004A71 RID: 19057
		[Nullable(2)]
		protected new ClientPreEnableSubLevels FbInstance;

		// Token: 0x04004A72 RID: 19058
		[Nullable(2)]
		protected ClientPreEnableSubLevels_SetValue PocoInterface;

		// Token: 0x04004A73 RID: 19059
		private IEnableSubLevelTransitionWithSceneCapture _TransitionOptionCache;

		// Token: 0x04004A74 RID: 19060
		private bool _TransitionOptionInited;
	}
}
