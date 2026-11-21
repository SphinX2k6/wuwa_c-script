using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDC RID: 3292
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent : IComponentBase
	{
		// Token: 0x06004B2C RID: 19244 RVA: 0x000BCB21 File Offset: 0x000BAD21
		[NullableContext(0)]
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

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x000BCB40 File Offset: 0x000BAD40
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

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x000BCB78 File Offset: 0x000BAD78
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06004B2F RID: 19247 RVA: 0x000BCB8E File Offset: 0x000BAD8E
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

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x000BCBC2 File Offset: 0x000BADC2
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x000BCBCF File Offset: 0x000BADCF
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

		// Token: 0x04002A87 RID: 10887
		private IGuideLineCreatorComponent Instance;

		// Token: 0x04002A88 RID: 10888
		private IColorChangeStrategyOfRGB _ColorChangeOptionCache;

		// Token: 0x04002A89 RID: 10889
		private bool _ColorChangeOptionInited;

		// Token: 0x04002A8A RID: 10890
		private IGuideLineCreatorScanOption _ScanOptionCache;

		// Token: 0x04002A8B RID: 10891
		private bool _ScanOptionInited;
	}
}
