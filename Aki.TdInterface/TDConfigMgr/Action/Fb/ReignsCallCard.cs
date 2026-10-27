using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A52 RID: 10834
	public class ReignsCallCard : ActionParams
	{
		// Token: 0x0600EE69 RID: 61033 RVA: 0x0022B4DB File Offset: 0x002296DB
		[NullableContext(1)]
		public static ReignsCallCard Create(IReignsCallCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCallCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x0022B4FA File Offset: 0x002296FA
		public virtual int CardId
		{
			get
			{
				return this.Instance.CardId;
			}
		}

		// Token: 0x0400832E RID: 33582
		private IReignsCallCard Instance;
	}
}
