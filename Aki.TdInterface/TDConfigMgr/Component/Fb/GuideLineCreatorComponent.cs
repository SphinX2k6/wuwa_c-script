using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0C RID: 3084
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent : IComponentBase
	{
		// Token: 0x060046C9 RID: 18121 RVA: 0x000B2955 File Offset: 0x000B0B55
		[NullableContext(1)]
		public static GuideLineCreatorComponent Create(IGuideLineCreatorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GuideLineCreatorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x000B2974 File Offset: 0x000B0B74
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x000B29AC File Offset: 0x000B0BAC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x000B29C2 File Offset: 0x000B0BC2
		public virtual IColorChangeStrategyOfRGB ColorChangeOption
		{
			get
			{
				if (this._ColorChangeOptionInited)
				{
					return this._ColorChangeOptionCache;
				}
				this._ColorChangeOptionInited = true;
				this._ColorChangeOptionCache = IColorChangeStrategyOfRGB.Create(this.Instance.ColorChangeOption);
				return this._ColorChangeOptionCache;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x000B29F6 File Offset: 0x000B0BF6
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x000B2A03 File Offset: 0x000B0C03
		public virtual IGuideLineCreatorScanOption ScanOption
		{
			get
			{
				if (this._ScanOptionInited)
				{
					return this._ScanOptionCache;
				}
				this._ScanOptionInited = true;
				this._ScanOptionCache = IGuideLineCreatorScanOption.Create(this.Instance.ScanOption);
				return this._ScanOptionCache;
			}
		}

		// Token: 0x0400283B RID: 10299
		private IGuideLineCreatorComponent Instance;

		// Token: 0x0400283C RID: 10300
		private IColorChangeStrategyOfRGB _ColorChangeOptionCache;

		// Token: 0x0400283D RID: 10301
		private bool _ColorChangeOptionInited;

		// Token: 0x0400283E RID: 10302
		private IGuideLineCreatorScanOption _ScanOptionCache;

		// Token: 0x0400283F RID: 10303
		private bool _ScanOptionInited;
	}
}
