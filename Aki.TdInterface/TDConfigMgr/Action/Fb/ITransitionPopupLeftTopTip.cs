using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002922 RID: 10530
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftTopTip : ITransitionPopupStyle
	{
		// Token: 0x0600EA02 RID: 59906 RVA: 0x00228A8E File Offset: 0x00226C8E
		[NullableContext(0)]
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

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x00228AAD File Offset: 0x00226CAD
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x0600EA04 RID: 59908 RVA: 0x00228ABA File Offset: 0x00226CBA
		public virtual string TitleText
		{
			get
			{
				return this.Instance.TitleText;
			}
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x00228AC7 File Offset: 0x00226CC7
		public virtual string ContentText
		{
			get
			{
				return this.Instance.ContentText;
			}
		}

		// Token: 0x040080FE RID: 33022
		private ITransitionPopupLeftTopTip Instance;
	}
}
