using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8C RID: 10892
	public class ITargetEntityType
	{
		// Token: 0x0600F061 RID: 61537 RVA: 0x00233A5E File Offset: 0x00231C5E
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

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x0600F062 RID: 61538 RVA: 0x00233A7D File Offset: 0x00231C7D
		public virtual ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04008430 RID: 33840
		private ITargetEntityType Instance;
	}
}
