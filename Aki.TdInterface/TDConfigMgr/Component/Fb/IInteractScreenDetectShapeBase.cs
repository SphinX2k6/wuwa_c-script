using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A83 RID: 2691
	public class IInteractScreenDetectShapeBase
	{
		// Token: 0x06003DE6 RID: 15846 RVA: 0x0009E8B6 File Offset: 0x0009CAB6
		[NullableContext(1)]
		public static IInteractScreenDetectShapeBase Create(IInteractScreenDetectShapeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003DE7 RID: 15847 RVA: 0x0009E8D5 File Offset: 0x0009CAD5
		public virtual EInteractScreenDetectShape Type
		{
			get
			{
				return (EInteractScreenDetectShape)this.Instance.Type;
			}
		}

		// Token: 0x04002272 RID: 8818
		private IInteractScreenDetectShapeBase Instance;
	}
}
