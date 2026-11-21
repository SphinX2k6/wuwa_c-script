using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4E RID: 2894
	public class IInteractScreenDetectShapeCircle : IInteractScreenDetectShapeBase
	{
		// Token: 0x06004212 RID: 16914 RVA: 0x000A7EA2 File Offset: 0x000A60A2
		public static IInteractScreenDetectShapeCircle Create(IInteractScreenDetectShapeCircle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeCircle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x000A7EC1 File Offset: 0x000A60C1
		public override EInteractScreenDetectShape Type
		{
			get
			{
				return (EInteractScreenDetectShape)this.Instance.Type;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x000A7ECE File Offset: 0x000A60CE
		public virtual float RadiusRatio
		{
			get
			{
				return this.Instance.RadiusRatio;
			}
		}

		// Token: 0x0400248F RID: 9359
		private IInteractScreenDetectShapeCircle Instance;
	}
}
