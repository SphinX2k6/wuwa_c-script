using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C60 RID: 11360
	public class IFaceExpressionTextureConfig : IFaceExpressionConfig
	{
		// Token: 0x0600F9BE RID: 63934 RVA: 0x002442CF File Offset: 0x002424CF
		public static IFaceExpressionTextureConfig Create(IFaceExpressionTextureConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionTextureConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x0600F9BF RID: 63935 RVA: 0x002442EE File Offset: 0x002424EE
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x0600F9C0 RID: 63936 RVA: 0x002442FB File Offset: 0x002424FB
		public virtual int FaceIndex
		{
			get
			{
				return this.Instance.FaceIndex;
			}
		}

		// Token: 0x04008876 RID: 34934
		private IFaceExpressionTextureConfig Instance;
	}
}
