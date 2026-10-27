using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265E RID: 9822
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftTopTip : ITransitionPopupStyle
	{
		// Token: 0x0600DC26 RID: 56358 RVA: 0x0020C1B6 File Offset: 0x0020A3B6
		[NullableContext(1)]
		public static ITransitionPopupLeftTopTip Create(ITransitionPopupLeftTopTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftTopTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x0600DC27 RID: 56359 RVA: 0x0020C1D5 File Offset: 0x0020A3D5
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x0600DC28 RID: 56360 RVA: 0x0020C1E2 File Offset: 0x0020A3E2
		public virtual string TitleText
		{
			get
			{
				return this.Instance.TitleText;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x0600DC29 RID: 56361 RVA: 0x0020C1EF File Offset: 0x0020A3EF
		public virtual string ContentText
		{
			get
			{
				return this.Instance.ContentText;
			}
		}

		// Token: 0x04007A5C RID: 31324
		private ITransitionPopupLeftTopTip Instance;
	}
}
