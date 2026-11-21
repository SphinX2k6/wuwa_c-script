using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002923 RID: 10531
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftBottomTransition : ITransitionPopupStyle
	{
		// Token: 0x0600EA07 RID: 59911 RVA: 0x00228ADC File Offset: 0x00226CDC
		[NullableContext(0)]
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

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x0600EA08 RID: 59912 RVA: 0x00228AFB File Offset: 0x00226CFB
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x0600EA09 RID: 59913 RVA: 0x00228B08 File Offset: 0x00226D08
		public virtual string TitleText
		{
			get
			{
				return this.Instance.TitleText;
			}
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x0600EA0A RID: 59914 RVA: 0x00228B15 File Offset: 0x00226D15
		public virtual string ContentText
		{
			get
			{
				return this.Instance.ContentText;
			}
		}

		// Token: 0x040080FF RID: 33023
		private ITransitionPopupLeftBottomTransition Instance;
	}
}
