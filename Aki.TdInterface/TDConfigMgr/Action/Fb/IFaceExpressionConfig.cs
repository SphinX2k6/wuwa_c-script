using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002978 RID: 10616
	public class IFaceExpressionConfig
	{
		// Token: 0x0600EB3C RID: 60220 RVA: 0x00226B02 File Offset: 0x00224D02
		[NullableContext(1)]
		public static IFaceExpressionConfig Create(IFaceExpressionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x0600EB3D RID: 60221 RVA: 0x00226B21 File Offset: 0x00224D21
		public virtual EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04008190 RID: 33168
		private IFaceExpressionConfig Instance;
	}
}
