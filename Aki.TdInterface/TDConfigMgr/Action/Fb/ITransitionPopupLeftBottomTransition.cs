using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265F RID: 9823
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftBottomTransition : ITransitionPopupStyle
	{
		// Token: 0x0600DC2B RID: 56363 RVA: 0x0020C204 File Offset: 0x0020A404
		[NullableContext(1)]
		public static ITransitionPopupLeftBottomTransition Create(ITransitionPopupLeftBottomTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftBottomTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x0600DC2C RID: 56364 RVA: 0x0020C223 File Offset: 0x0020A423
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x0020C230 File Offset: 0x0020A430
		public virtual string TitleText
		{
			get
			{
				return this.Instance.TitleText;
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x0600DC2E RID: 56366 RVA: 0x0020C23D File Offset: 0x0020A43D
		public virtual string ContentText
		{
			get
			{
				return this.Instance.ContentText;
			}
		}

		// Token: 0x04007A5D RID: 31325
		private ITransitionPopupLeftBottomTransition Instance;
	}
}
