using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002671 RID: 9841
	public class IChangeEntityStateLoop : ChangeEntityState
	{
		// Token: 0x0600DC94 RID: 56468 RVA: 0x0020CF76 File Offset: 0x0020B176
		[NullableContext(1)]
		public static IChangeEntityStateLoop Create(IChangeEntityStateLoop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x0020CF95 File Offset: 0x0020B195
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x0020CFA2 File Offset: 0x0020B1A2
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x0020CFAF File Offset: 0x0020B1AF
		public virtual ELoopStateType Circulation
		{
			get
			{
				return (ELoopStateType)this.Instance.Circulation;
			}
		}

		// Token: 0x04007A9B RID: 31387
		private IChangeEntityStateLoop Instance;
	}
}
