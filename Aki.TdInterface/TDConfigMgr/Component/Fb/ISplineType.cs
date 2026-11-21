using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0A RID: 3338
	public class ISplineType
	{
		// Token: 0x06004C0B RID: 19467 RVA: 0x000BE8B9 File Offset: 0x000BCAB9
		public static ISplineType Create(ISplineType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x000BE8D8 File Offset: 0x000BCAD8
		public virtual ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x04002B09 RID: 11017
		private ISplineType Instance;
	}
}
