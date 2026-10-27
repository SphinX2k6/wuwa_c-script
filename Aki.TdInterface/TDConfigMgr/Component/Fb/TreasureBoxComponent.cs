using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC8 RID: 2760
	public class TreasureBoxComponent : IComponentBase
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x000A2519 File Offset: 0x000A0719
		[NullableContext(1)]
		public static TreasureBoxComponent Create(ITreasureBoxComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TreasureBoxComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x000A2538 File Offset: 0x000A0738
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

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003F8E RID: 16270 RVA: 0x000A2570 File Offset: 0x000A0770
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x000A2586 File Offset: 0x000A0786
		public virtual int TypeId
		{
			get
			{
				return this.Instance.TypeId;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x000A2594 File Offset: 0x000A0794
		public virtual bool? IsSupportDiscoverDevice
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSupportDiscoverDevice);
			}
		}

		// Token: 0x04002353 RID: 9043
		private ITreasureBoxComponent Instance;
	}
}
