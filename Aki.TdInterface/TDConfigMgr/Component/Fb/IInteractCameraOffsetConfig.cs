using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B43 RID: 2883
	public class IInteractCameraOffsetConfig
	{
		// Token: 0x060041E3 RID: 16867 RVA: 0x000A7A05 File Offset: 0x000A5C05
		public static IInteractCameraOffsetConfig Create(IInteractCameraOffsetConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractCameraOffsetConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x000A7A24 File Offset: 0x000A5C24
		public virtual int? CenterOffsetPercent
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CenterOffsetPercent);
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x000A7A5C File Offset: 0x000A5C5C
		public virtual float? OffsetZ
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.OffsetZ);
			}
		}

		// Token: 0x0400247C RID: 9340
		private IInteractCameraOffsetConfig Instance;
	}
}
