using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFB RID: 3067
	[NullableContext(1)]
	[Nullable(0)]
	public class SkyboxComponent : IComponentBase
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x000B1DC4 File Offset: 0x000AFFC4
		public static SkyboxComponent Create(ISkyboxComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SkyboxComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000B1DE4 File Offset: 0x000AFFE4
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

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000B1E1C File Offset: 0x000B001C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x000B1E32 File Offset: 0x000B0032
		[Nullable(2)]
		public virtual string WeatherDataAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.WeatherDataAsset;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x000B1E3F File Offset: 0x000B003F
		[Nullable(2)]
		public virtual string PPTODDataAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PPTODDataAsset;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x000B1E4C File Offset: 0x000B004C
		public virtual int? SkyboxSetting
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SkyboxSetting);
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06004672 RID: 18034 RVA: 0x000B1E84 File Offset: 0x000B0084
		public virtual float? FadeTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeTime);
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x000B1EBC File Offset: 0x000B00BC
		public virtual float? Priority
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Priority);
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x000B1EF2 File Offset: 0x000B00F2
		public virtual ISkyboxTrigger TriggerMode
		{
			get
			{
				if (this._TriggerModeInited)
				{
					return this._TriggerModeCache;
				}
				this._TriggerModeInited = true;
				this._TriggerModeCache = ComponentReadHelper.ReadSkyboxComponent_TriggerMode(this.Instance);
				return this._TriggerModeCache;
			}
		}

		// Token: 0x04002814 RID: 10260
		private ISkyboxComponent Instance;

		// Token: 0x04002815 RID: 10261
		private ISkyboxTrigger _TriggerModeCache;

		// Token: 0x04002816 RID: 10262
		private bool _TriggerModeInited;
	}
}
