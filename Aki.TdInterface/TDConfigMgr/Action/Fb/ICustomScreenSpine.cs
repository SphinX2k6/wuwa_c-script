using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269C RID: 9884
	public class ICustomScreenSpine : ICustomScreenTypeBase
	{
		// Token: 0x0600DD3A RID: 56634 RVA: 0x0020DF7A File Offset: 0x0020C17A
		[NullableContext(1)]
		public static ICustomScreenSpine Create(ICustomScreenSpine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0600DD3B RID: 56635 RVA: 0x0020DF99 File Offset: 0x0020C199
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x0600DD3C RID: 56636 RVA: 0x0020DFA6 File Offset: 0x0020C1A6
		public virtual int SpineId
		{
			get
			{
				return this.Instance.SpineId;
			}
		}

		// Token: 0x04007AE0 RID: 31456
		private ICustomScreenSpine Instance;
	}
}
