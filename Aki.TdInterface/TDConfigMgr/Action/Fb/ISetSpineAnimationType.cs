using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FE RID: 10750
	public class ISetSpineAnimationType
	{
		// Token: 0x0600ED42 RID: 60738 RVA: 0x00229A2D File Offset: 0x00227C2D
		[NullableContext(1)]
		public static ISetSpineAnimationType Create(ISetSpineAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x0600ED43 RID: 60739 RVA: 0x00229A4C File Offset: 0x00227C4C
		public virtual ESetSpineAnimation Type
		{
			get
			{
				return (ESetSpineAnimation)this.Instance.Type;
			}
		}

		// Token: 0x0400829E RID: 33438
		private ISetSpineAnimationType Instance;
	}
}
