using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F4 RID: 10740
	public class ICustomAlertValue : ISetAlertValueType
	{
		// Token: 0x0600ED1A RID: 60698 RVA: 0x0022973D File Offset: 0x0022793D
		[NullableContext(1)]
		public static ICustomAlertValue Create(ICustomAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0600ED1B RID: 60699 RVA: 0x0022975C File Offset: 0x0022795C
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x00229769 File Offset: 0x00227969
		public virtual float CustomValue
		{
			get
			{
				return this.Instance.CustomValue;
			}
		}

		// Token: 0x0400828E RID: 33422
		private ICustomAlertValue Instance;
	}
}
