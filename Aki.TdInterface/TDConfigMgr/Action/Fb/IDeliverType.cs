using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002666 RID: 9830
	public class IDeliverType
	{
		// Token: 0x0600DC48 RID: 56392 RVA: 0x0020C472 File Offset: 0x0020A672
		[NullableContext(1)]
		public static IDeliverType Create(IDeliverType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x0600DC49 RID: 56393 RVA: 0x0020C491 File Offset: 0x0020A691
		public virtual EDeliverType Type
		{
			get
			{
				return (EDeliverType)this.Instance.Type;
			}
		}

		// Token: 0x04007A6A RID: 31338
		private IDeliverType Instance;
	}
}
