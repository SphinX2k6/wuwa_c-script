using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C00 RID: 3072
	public class WeaponComponent : IComponentBase
	{
		// Token: 0x06004690 RID: 18064 RVA: 0x000B238C File Offset: 0x000B058C
		[NullableContext(1)]
		public static WeaponComponent Create(IWeaponComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WeaponComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x000B23AC File Offset: 0x000B05AC
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

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x000B23E4 File Offset: 0x000B05E4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x000B23FA File Offset: 0x000B05FA
		public virtual int WeaponId
		{
			get
			{
				return this.Instance.WeaponId;
			}
		}

		// Token: 0x04002825 RID: 10277
		private IWeaponComponent Instance;
	}
}
