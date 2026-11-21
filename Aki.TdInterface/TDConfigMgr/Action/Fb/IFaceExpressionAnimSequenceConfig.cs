using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C61 RID: 11361
	public class IFaceExpressionAnimSequenceConfig : IFaceExpressionConfig
	{
		// Token: 0x0600F9C2 RID: 63938 RVA: 0x00244310 File Offset: 0x00242510
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

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x0600F9C3 RID: 63939 RVA: 0x0024432F File Offset: 0x0024252F
		public override EFaceExpressionConfigType Type
		{
			get
			{
				return (EFaceExpressionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x0600F9C4 RID: 63940 RVA: 0x0024433C File Offset: 0x0024253C
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04008877 RID: 34935
		private IFaceExpressionAnimSequenceConfig Instance;
	}
}
