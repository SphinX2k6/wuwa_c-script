using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4F RID: 10831
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsChangeBackground : ActionParams
	{
		// Token: 0x0600EE5E RID: 61022 RVA: 0x0022B425 File Offset: 0x00229625
		public static ReignsChangeBackground Create(IReignsChangeBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x0022B444 File Offset: 0x00229644
		public virtual string Background
		{
			get
			{
				return this.Instance.Background;
			}
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x0600EE60 RID: 61024 RVA: 0x0022B451 File Offset: 0x00229651
		public virtual EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				return (EReignsBackgroundChangeMode)this.Instance.ChangeMode;
			}
		}

		// Token: 0x0400832B RID: 33579
		private IReignsChangeBackground Instance;
	}
}
