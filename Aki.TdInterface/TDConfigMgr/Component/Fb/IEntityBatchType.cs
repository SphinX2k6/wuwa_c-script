using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8B RID: 2955
	public class IEntityBatchType
	{
		// Token: 0x06004396 RID: 17302 RVA: 0x000AB642 File Offset: 0x000A9842
		public static IEntityBatchType Create(IEntityBatchType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x000AB661 File Offset: 0x000A9861
		public virtual EEntityBatchType Type
		{
			get
			{
				return (EEntityBatchType)this.Instance.Type;
			}
		}

		// Token: 0x04002558 RID: 9560
		private IEntityBatchType Instance;
	}
}
