using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002502 RID: 9474
	public class IHeadStyle
	{
		// Token: 0x0600D370 RID: 54128 RVA: 0x001F5808 File Offset: 0x001F3A08
		[NullableContext(1)]
		public static IHeadStyle Create(IHeadStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600D371 RID: 54129 RVA: 0x001F5827 File Offset: 0x001F3A27
		public virtual EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x040073EC RID: 29676
		private IHeadStyle Instance;
	}
}
