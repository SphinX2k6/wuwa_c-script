using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CF RID: 4815
	public class IBossRushBuffInfoView : IInformationViewType
	{
		// Token: 0x06006E25 RID: 28197 RVA: 0x0010A755 File Offset: 0x00108955
		[NullableContext(1)]
		public static IBossRushBuffInfoView Create(IBossRushBuffInfoView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossRushBuffInfoView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x0010A774 File Offset: 0x00108974
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x04003F21 RID: 16161
		private IBossRushBuffInfoView Instance;
	}
}
