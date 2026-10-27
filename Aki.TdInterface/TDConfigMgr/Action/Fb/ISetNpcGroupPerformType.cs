using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5A RID: 10842
	public class ISetNpcGroupPerformType
	{
		// Token: 0x0600EE82 RID: 61058 RVA: 0x0022B6AA File Offset: 0x002298AA
		[NullableContext(1)]
		public static ISetNpcGroupPerformType Create(ISetNpcGroupPerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x0600EE83 RID: 61059 RVA: 0x0022B6C9 File Offset: 0x002298C9
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x04008338 RID: 33592
		private ISetNpcGroupPerformType Instance;
	}
}
