using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026AC RID: 9900
	public class FinishDungeon : ActionParams
	{
		// Token: 0x0600DD89 RID: 56713 RVA: 0x0020E7E2 File Offset: 0x0020C9E2
		[NullableContext(1)]
		public static FinishDungeon Create(IFinishDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x0600DD8A RID: 56714 RVA: 0x0020E801 File Offset: 0x0020CA01
		public virtual bool IsSuccess
		{
			get
			{
				return this.Instance.IsSuccess;
			}
		}

		// Token: 0x04007B04 RID: 31492
		private IFinishDungeon Instance;
	}
}
