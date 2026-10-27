using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002726 RID: 10022
	public class INewSplineMoveTarget
	{
		// Token: 0x0600DF82 RID: 57218 RVA: 0x00211F1B File Offset: 0x0021011B
		[NullableContext(1)]
		public static INewSplineMoveTarget Create(INewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x0600DF83 RID: 57219 RVA: 0x00211F3A File Offset: 0x0021013A
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007C0E RID: 31758
		private INewSplineMoveTarget Instance;
	}
}
