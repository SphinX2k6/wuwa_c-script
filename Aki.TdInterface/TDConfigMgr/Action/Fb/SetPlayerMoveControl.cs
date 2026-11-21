using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002939 RID: 10553
	public class SetPlayerMoveControl : ActionParams
	{
		// Token: 0x0600EA82 RID: 60034 RVA: 0x00229A7E File Offset: 0x00227C7E
		public static SetPlayerMoveControl Create(ISetPlayerMoveControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerMoveControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x00229A9D File Offset: 0x00227C9D
		public virtual int Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x0600EA84 RID: 60036 RVA: 0x00229AAA File Offset: 0x00227CAA
		public virtual int Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x00229AB7 File Offset: 0x00227CB7
		public virtual int Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x0600EA86 RID: 60038 RVA: 0x00229AC4 File Offset: 0x00227CC4
		public virtual int Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x04008141 RID: 33089
		private ISetPlayerMoveControl Instance;
	}
}
