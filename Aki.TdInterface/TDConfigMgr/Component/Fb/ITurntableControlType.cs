using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C73 RID: 3187
	public class ITurntableControlType
	{
		// Token: 0x0600490B RID: 18699 RVA: 0x000B7655 File Offset: 0x000B5855
		[NullableContext(1)]
		public static ITurntableControlType Create(ITurntableControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x000B7674 File Offset: 0x000B5874
		public virtual EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x000B7681 File Offset: 0x000B5881
		public virtual int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x040029AE RID: 10670
		private ITurntableControlType Instance;
	}
}
