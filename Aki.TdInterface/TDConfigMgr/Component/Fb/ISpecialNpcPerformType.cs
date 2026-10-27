using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCD RID: 3021
	public class ISpecialNpcPerformType
	{
		// Token: 0x06004575 RID: 17781 RVA: 0x000AFE7D File Offset: 0x000AE07D
		[NullableContext(1)]
		public static ISpecialNpcPerformType Create(ISpecialNpcPerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialNpcPerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x000AFE9C File Offset: 0x000AE09C
		public virtual ESpecialNpcType Type
		{
			get
			{
				return (ESpecialNpcType)this.Instance.Type;
			}
		}

		// Token: 0x04002784 RID: 10116
		private ISpecialNpcPerformType Instance;
	}
}
