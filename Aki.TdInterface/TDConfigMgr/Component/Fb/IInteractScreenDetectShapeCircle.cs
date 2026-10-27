using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A84 RID: 2692
	public class IInteractScreenDetectShapeCircle : IInteractScreenDetectShapeBase
	{
		// Token: 0x06003DE9 RID: 15849 RVA: 0x0009E8EA File Offset: 0x0009CAEA
		[NullableContext(1)]
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

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0009E909 File Offset: 0x0009CB09
		public override EInteractScreenDetectShape Type
		{
			get
			{
				return (EInteractScreenDetectShape)this.Instance.Type;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x0009E916 File Offset: 0x0009CB16
		public virtual float RadiusRatio
		{
			get
			{
				return this.Instance.RadiusRatio;
			}
		}

		// Token: 0x04002273 RID: 8819
		private IInteractScreenDetectShapeCircle Instance;
	}
}
