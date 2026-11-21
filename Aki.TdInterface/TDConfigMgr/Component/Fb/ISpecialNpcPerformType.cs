using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9B RID: 3227
	public class ISpecialNpcPerformType
	{
		// Token: 0x060049CE RID: 18894 RVA: 0x000B9F41 File Offset: 0x000B8141
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

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x000B9F60 File Offset: 0x000B8160
		public virtual ESpecialNpcType Type
		{
			get
			{
				return (ESpecialNpcType)this.Instance.Type;
			}
		}

		// Token: 0x040029CC RID: 10700
		private ISpecialNpcPerformType Instance;
	}
}
