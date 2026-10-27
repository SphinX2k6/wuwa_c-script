using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002720 RID: 10016
	public class IPlayerSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600DF61 RID: 57185 RVA: 0x00211A36 File Offset: 0x0020FC36
		[NullableContext(1)]
		public static IPlayerSplineMoveTarget Create(IPlayerSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x00211A55 File Offset: 0x0020FC55
		public override ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007BF6 RID: 31734
		private IPlayerSplineMoveTarget Instance;
	}
}
