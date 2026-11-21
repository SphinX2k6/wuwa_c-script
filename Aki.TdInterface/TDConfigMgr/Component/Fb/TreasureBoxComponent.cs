using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B92 RID: 2962
	public class TreasureBoxComponent : IComponentBase
	{
		// Token: 0x060043B6 RID: 17334 RVA: 0x000ABB0D File Offset: 0x000A9D0D
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

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x000ABB2C File Offset: 0x000A9D2C
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

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x000ABB64 File Offset: 0x000A9D64
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x000ABB7A File Offset: 0x000A9D7A
		public virtual int TypeId
		{
			get
			{
				return this.Instance.TypeId;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x000ABB88 File Offset: 0x000A9D88
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

		// Token: 0x0400256F RID: 9583
		private ITreasureBoxComponent Instance;
	}
}
