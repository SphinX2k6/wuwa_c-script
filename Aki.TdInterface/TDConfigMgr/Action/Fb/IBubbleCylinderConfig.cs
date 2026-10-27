using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002715 RID: 10005
	public class IBubbleCylinderConfig
	{
		// Token: 0x0600DF2B RID: 57131 RVA: 0x002112A1 File Offset: 0x0020F4A1
		[NullableContext(1)]
		public static IBubbleCylinderConfig Create(IBubbleCylinderConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0600DF2C RID: 57132 RVA: 0x002112C0 File Offset: 0x0020F4C0
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0600DF2D RID: 57133 RVA: 0x002112CD File Offset: 0x0020F4CD
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x04007BD7 RID: 31703
		private IBubbleCylinderConfig Instance;
	}
}
