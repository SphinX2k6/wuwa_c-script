using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A60 RID: 2656
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshSingleComponent : IComponentBase
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x0009D338 File Offset: 0x0009B538
		public static RefreshSingleComponent Create(IRefreshSingleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshSingleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x0009D358 File Offset: 0x0009B558
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

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x0009D390 File Offset: 0x0009B590
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x0009D3A6 File Offset: 0x0009B5A6
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x0009D3B3 File Offset: 0x0009B5B3
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x0009D3C0 File Offset: 0x0009B5C0
		public virtual string TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x04002213 RID: 8723
		private IRefreshSingleComponent Instance;
	}
}
