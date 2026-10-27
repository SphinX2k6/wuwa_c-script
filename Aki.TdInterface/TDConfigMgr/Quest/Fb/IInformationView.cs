using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139C RID: 5020
	public class IInformationView : IShowUi
	{
		// Token: 0x060072C4 RID: 29380 RVA: 0x00113C5C File Offset: 0x00111E5C
		[NullableContext(1)]
		public static IInformationView Create(IInformationView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00113C7B File Offset: 0x00111E7B
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x060072C6 RID: 29382 RVA: 0x00113C88 File Offset: 0x00111E88
		public virtual int InformationViewId
		{
			get
			{
				return this.Instance.InformationViewId;
			}
		}

		// Token: 0x0400425A RID: 16986
		private IInformationView Instance;
	}
}
