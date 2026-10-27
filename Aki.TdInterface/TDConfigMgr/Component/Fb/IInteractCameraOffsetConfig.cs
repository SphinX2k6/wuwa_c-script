using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A79 RID: 2681
	public class IInteractCameraOffsetConfig
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x0009E44D File Offset: 0x0009C64D
		[NullableContext(1)]
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

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x0009E46C File Offset: 0x0009C66C
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

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x0009E4A4 File Offset: 0x0009C6A4
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

		// Token: 0x04002260 RID: 8800
		private IInteractCameraOffsetConfig Instance;
	}
}
