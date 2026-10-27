using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267D RID: 9853
	public class ClientChangeTeamPosition : ActionParams
	{
		// Token: 0x0600DCC3 RID: 56515 RVA: 0x0020D46A File Offset: 0x0020B66A
		[NullableContext(1)]
		public static ClientChangeTeamPosition Create(IClientChangeTeamPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x0020D489 File Offset: 0x0020B689
		public virtual int PositionId
		{
			get
			{
				return this.Instance.PositionId;
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x0600DCC5 RID: 56517 RVA: 0x0020D498 File Offset: 0x0020B698
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

		// Token: 0x04007AAD RID: 31405
		private IClientChangeTeamPosition Instance;
	}
}
