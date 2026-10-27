using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C98 RID: 3224
	public class ILevelAIBehaviourSpline : ILevelAIBehaviourBase
	{
		// Token: 0x060049B9 RID: 18873 RVA: 0x000B8CFE File Offset: 0x000B6EFE
		[NullableContext(1)]
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

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x000B8D1D File Offset: 0x000B6F1D
		public override ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x000B8D2C File Offset: 0x000B6F2C
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

		// Token: 0x04002A1B RID: 10779
		private ILevelAIBehaviourSpline Instance;
	}
}
