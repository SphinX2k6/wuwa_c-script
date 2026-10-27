using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267C RID: 9852
	public class ChangeTeamPosition : ActionParams
	{
		// Token: 0x0600DCBF RID: 56511 RVA: 0x0020D3FD File Offset: 0x0020B5FD
		[NullableContext(1)]
		public static ChangeTeamPosition Create(IChangeTeamPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeTeamPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x0600DCC0 RID: 56512 RVA: 0x0020D41C File Offset: 0x0020B61C
		public virtual int PositionId
		{
			get
			{
				return this.Instance.PositionId;
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x0600DCC1 RID: 56513 RVA: 0x0020D42C File Offset: 0x0020B62C
		public virtual bool? RestoreToPrevious
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RestoreToPrevious);
			}
		}

		// Token: 0x04007AAC RID: 31404
		private IChangeTeamPosition Instance;
	}
}
