using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002934 RID: 10548
	public class IInteractiveItemsFunction : EnableFunction
	{
		// Token: 0x0600EA00 RID: 59904 RVA: 0x002247A0 File Offset: 0x002229A0
		[NullableContext(1)]
		public static IInteractiveItemsFunction Create(IInteractiveItemsFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractiveItemsFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x0600EA01 RID: 59905 RVA: 0x002247BF File Offset: 0x002229BF
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x0600EA02 RID: 59906 RVA: 0x002247CC File Offset: 0x002229CC
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04008112 RID: 33042
		private IInteractiveItemsFunction Instance;
	}
}
