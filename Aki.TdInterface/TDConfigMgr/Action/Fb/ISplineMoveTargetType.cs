using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E2 RID: 10722
	public class ISplineMoveTargetType
	{
		// Token: 0x0600ED3B RID: 60731 RVA: 0x0022E265 File Offset: 0x0022C465
		public static ISplineMoveTargetType Create(ISplineMoveTargetType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x0022E284 File Offset: 0x0022C484
		public virtual ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008294 RID: 33428
		private ISplineMoveTargetType Instance;
	}
}
