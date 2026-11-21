using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCB RID: 3275
	public class SkyboxComponent : IComponentBase
	{
		// Token: 0x06004ACF RID: 19151 RVA: 0x000BBF90 File Offset: 0x000BA190
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x000BBFE8 File Offset: 0x000BA1E8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x000BBFFE File Offset: 0x000BA1FE
		[Nullable(2)]
		public virtual string WeatherDataAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.WeatherDataAsset;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x000BC00B File Offset: 0x000BA20B
		[Nullable(2)]
		public virtual string PPTODDataAsset
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PPTODDataAsset;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x000BC018 File Offset: 0x000BA218
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

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x000BC050 File Offset: 0x000BA250
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

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x000BC088 File Offset: 0x000BA288
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

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x000BC0BE File Offset: 0x000BA2BE
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

		// Token: 0x04002A60 RID: 10848
		private ISkyboxComponent Instance;

		// Token: 0x04002A61 RID: 10849
		private ISkyboxTrigger _TriggerModeCache;

		// Token: 0x04002A62 RID: 10850
		private bool _TriggerModeInited;
	}
}
