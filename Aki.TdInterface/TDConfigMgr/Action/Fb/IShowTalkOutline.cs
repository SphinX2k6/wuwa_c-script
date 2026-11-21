using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002861 RID: 10337
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowTalkOutline
	{
		// Token: 0x0600E68B RID: 59019 RVA: 0x00221F60 File Offset: 0x00220160
		[NullableContext(0)]
		public static IShowTalkOutline Create(IShowTalkOutline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkOutline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0600E68C RID: 59020 RVA: 0x00221F7F File Offset: 0x0022017F
		public virtual int TextId
		{
			get
			{
				return this.Instance.TextId;
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0600E68D RID: 59021 RVA: 0x00221F8C File Offset: 0x0022018C
		public virtual string TidOutline
		{
			get
			{
				return this.Instance.TidOutline;
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0600E68E RID: 59022 RVA: 0x00221F99 File Offset: 0x00220199
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x04007EFB RID: 32507
		private IShowTalkOutline Instance;
	}
}
