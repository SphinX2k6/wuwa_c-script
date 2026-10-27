using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002979 RID: 10617
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionMorphConfig : IFaceExpressionConfig
	{
		// Token: 0x0600EB3F RID: 60223 RVA: 0x00226B36 File Offset: 0x00224D36
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

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x0600EB40 RID: 60224 RVA: 0x00226B55 File Offset: 0x00224D55
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x0600EB41 RID: 60225 RVA: 0x00226B62 File Offset: 0x00224D62
		public virtual string MorphData
		{
			get
			{
				return this.Instance.MorphData;
			}
		}

		// Token: 0x04008191 RID: 33169
		private IFaceExpressionMorphConfig Instance;
	}
}
