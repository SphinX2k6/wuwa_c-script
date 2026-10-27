using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297B RID: 10619
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionAnimSequenceConfig : IFaceExpressionConfig
	{
		// Token: 0x0600EB47 RID: 60231 RVA: 0x00226BB8 File Offset: 0x00224DB8
		public static IFaceExpressionAnimSequenceConfig Create(IFaceExpressionAnimSequenceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionAnimSequenceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x0600EB48 RID: 60232 RVA: 0x00226BD7 File Offset: 0x00224DD7
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x0600EB49 RID: 60233 RVA: 0x00226BE4 File Offset: 0x00224DE4
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04008193 RID: 33171
		private IFaceExpressionAnimSequenceConfig Instance;
	}
}
