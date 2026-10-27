using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B9 RID: 10169
	public class ITargetEntityType
	{
		// Token: 0x0600E23F RID: 57919 RVA: 0x00216C8A File Offset: 0x00214E8A
		[NullableContext(1)]
		public static ITargetEntityType Create(ITargetEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x0600E240 RID: 57920 RVA: 0x00216CA9 File Offset: 0x00214EA9
		public virtual ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04007D79 RID: 32121
		private ITargetEntityType Instance;
	}
}
