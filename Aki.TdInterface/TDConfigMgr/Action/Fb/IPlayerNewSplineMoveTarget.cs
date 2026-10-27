using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002727 RID: 10023
	public class IPlayerNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600DF85 RID: 57221 RVA: 0x00211F4F File Offset: 0x0021014F
		[NullableContext(1)]
		public static IPlayerNewSplineMoveTarget Create(IPlayerNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x0600DF86 RID: 57222 RVA: 0x00211F6E File Offset: 0x0021016E
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007C0F RID: 31759
		private IPlayerNewSplineMoveTarget Instance;
	}
}
