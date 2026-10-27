using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200266D RID: 9837
	public class ChangeEntityState : ActionParams
	{
		// Token: 0x0600DC7F RID: 56447 RVA: 0x0020CD81 File Offset: 0x0020AF81
		[NullableContext(1)]
		public static ChangeEntityState Create(IChangeEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x0600DC80 RID: 56448 RVA: 0x0020CDA0 File Offset: 0x0020AFA0
		public virtual EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x0600DC81 RID: 56449 RVA: 0x0020CDAD File Offset: 0x0020AFAD
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007A95 RID: 31381
		private IChangeEntityState Instance;
	}
}
