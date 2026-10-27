using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013FE RID: 5118
	public class IPhotographTarget
	{
		// Token: 0x0600746C RID: 29804 RVA: 0x00116834 File Offset: 0x00114A34
		[NullableContext(1)]
		public static IPhotographTarget Create(IPhotographTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x00116853 File Offset: 0x00114A53
		public virtual EPhotographTargetType Type
		{
			get
			{
				return (EPhotographTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04004360 RID: 17248
		private IPhotographTarget Instance;
	}
}
