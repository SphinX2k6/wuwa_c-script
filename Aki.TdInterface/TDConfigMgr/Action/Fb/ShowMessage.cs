using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F2 RID: 9458
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowMessage : ActionParams
	{
		// Token: 0x0600D336 RID: 54070 RVA: 0x001F52DA File Offset: 0x001F34DA
		public static ShowMessage Create(IShowMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600D337 RID: 54071 RVA: 0x001F52F9 File Offset: 0x001F34F9
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x040073D0 RID: 29648
		private IShowMessage Instance;
	}
}
