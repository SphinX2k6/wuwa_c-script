using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272C RID: 10028
	public class IStopNewMoveWithSplineType
	{
		// Token: 0x0600DF9E RID: 57246 RVA: 0x0021221E File Offset: 0x0021041E
		[NullableContext(1)]
		public static IStopNewMoveWithSplineType Create(IStopNewMoveWithSplineType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x0021223D File Offset: 0x0021043D
		public virtual EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x04007C18 RID: 31768
		private IStopNewMoveWithSplineType Instance;
	}
}
