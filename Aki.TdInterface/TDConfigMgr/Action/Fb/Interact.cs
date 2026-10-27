using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D5 RID: 9429
	[NullableContext(1)]
	[Nullable(0)]
	public class Interact : ActionParams
	{
		// Token: 0x0600D29A RID: 53914 RVA: 0x001F3EBA File Offset: 0x001F20BA
		public static Interact Create(IInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600D29B RID: 53915 RVA: 0x001F3ED9 File Offset: 0x001F20D9
		public virtual int Who
		{
			get
			{
				return this.Instance.Who;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600D29C RID: 53916 RVA: 0x001F3EE6 File Offset: 0x001F20E6
		public virtual string Param
		{
			get
			{
				return this.Instance.Param;
			}
		}

		// Token: 0x04007383 RID: 29571
		private IInteract Instance;
	}
}
