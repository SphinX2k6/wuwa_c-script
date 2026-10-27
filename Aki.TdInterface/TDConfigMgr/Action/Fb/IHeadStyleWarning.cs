using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002506 RID: 9478
	public class IHeadStyleWarning : IHeadStyle
	{
		// Token: 0x0600D37E RID: 54142 RVA: 0x001F58F2 File Offset: 0x001F3AF2
		[NullableContext(1)]
		public static IHeadStyleWarning Create(IHeadStyleWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600D37F RID: 54143 RVA: 0x001F5911 File Offset: 0x001F3B11
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x040073F0 RID: 29680
		private IHeadStyleWarning Instance;
	}
}
