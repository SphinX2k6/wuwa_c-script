using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B2 RID: 9650
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowTalkOutline
	{
		// Token: 0x0600D911 RID: 55569 RVA: 0x0020628C File Offset: 0x0020448C
		[NullableContext(1)]
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

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x0600D912 RID: 55570 RVA: 0x002062AB File Offset: 0x002044AB
		public virtual int TextId
		{
			get
			{
				return this.Instance.TextId;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x0600D913 RID: 55571 RVA: 0x002062B8 File Offset: 0x002044B8
		public virtual string TidOutline
		{
			get
			{
				return this.Instance.TidOutline;
			}
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0600D914 RID: 55572 RVA: 0x002062C5 File Offset: 0x002044C5
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x04007894 RID: 30868
		private IShowTalkOutline Instance;
	}
}
