using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A56 RID: 10838
	public class IHandInHandInitiatorType
	{
		// Token: 0x0600EE74 RID: 61044 RVA: 0x0022B59E File Offset: 0x0022979E
		[NullableContext(1)]
		public static IHandInHandInitiatorType Create(IHandInHandInitiatorType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x0022B5BD File Offset: 0x002297BD
		public virtual EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008332 RID: 33586
		private IHandInHandInitiatorType Instance;
	}
}
