using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E9 RID: 9449
	public class IQuestVarContext : IVarContext
	{
		// Token: 0x0600D2F4 RID: 54004 RVA: 0x001F4A7E File Offset: 0x001F2C7E
		[NullableContext(1)]
		public static IQuestVarContext Create(IQuestVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600D2F5 RID: 54005 RVA: 0x001F4A9D File Offset: 0x001F2C9D
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600D2F6 RID: 54006 RVA: 0x001F4AAA File Offset: 0x001F2CAA
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040073B3 RID: 29619
		private IQuestVarContext Instance;
	}
}
