using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7A RID: 3450
	public class ILevelAIBehaviourSpline : ILevelAIBehaviourBase
	{
		// Token: 0x06004E67 RID: 20071 RVA: 0x000C370E File Offset: 0x000C190E
		public static ILevelAIBehaviourSpline Create(ILevelAIBehaviourSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAIBehaviourSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x000C372D File Offset: 0x000C192D
		public override ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x000C373C File Offset: 0x000C193C
		public virtual int? SplineEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SplineEntityId);
			}
		}

		// Token: 0x04002C95 RID: 11413
		private ILevelAIBehaviourSpline Instance;
	}
}
