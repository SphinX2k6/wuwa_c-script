using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001401 RID: 5121
	public class IPhotographSubTarget
	{
		// Token: 0x06007478 RID: 29816 RVA: 0x00116947 File Offset: 0x00114B47
		[NullableContext(1)]
		public static IPhotographSubTarget Create(IPhotographSubTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06007479 RID: 29817 RVA: 0x00116966 File Offset: 0x00114B66
		public virtual EPhotographSubTargetType Type
		{
			get
			{
				return (EPhotographSubTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04004365 RID: 17253
		private IPhotographSubTarget Instance;
	}
}
