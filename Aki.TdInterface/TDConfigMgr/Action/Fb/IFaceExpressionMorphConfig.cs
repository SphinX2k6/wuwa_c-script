using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5F RID: 11359
	public class IFaceExpressionMorphConfig : IFaceExpressionConfig
	{
		// Token: 0x0600F9BA RID: 63930 RVA: 0x0024428E File Offset: 0x0024248E
		public static IFaceExpressionMorphConfig Create(IFaceExpressionMorphConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionMorphConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x0600F9BB RID: 63931 RVA: 0x002442AD File Offset: 0x002424AD
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x0600F9BC RID: 63932 RVA: 0x002442BA File Offset: 0x002424BA
		public virtual string MorphData
		{
			get
			{
				return this.Instance.MorphData;
			}
		}

		// Token: 0x04008875 RID: 34933
		private IFaceExpressionMorphConfig Instance;
	}
}
