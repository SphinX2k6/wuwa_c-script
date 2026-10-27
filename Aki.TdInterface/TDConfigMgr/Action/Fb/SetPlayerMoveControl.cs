using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267A RID: 9850
	public class SetPlayerMoveControl : ActionParams
	{
		// Token: 0x0600DCB6 RID: 56502 RVA: 0x0020D36E File Offset: 0x0020B56E
		[NullableContext(1)]
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

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x0600DCB7 RID: 56503 RVA: 0x0020D38D File Offset: 0x0020B58D
		public virtual int Left
		{
			get
			{
				return this.Instance.Left;
			}
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x0020D39A File Offset: 0x0020B59A
		public virtual int Right
		{
			get
			{
				return this.Instance.Right;
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x0020D3A7 File Offset: 0x0020B5A7
		public virtual int Forward
		{
			get
			{
				return this.Instance.Forward;
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x0020D3B4 File Offset: 0x0020B5B4
		public virtual int Back
		{
			get
			{
				return this.Instance.Back;
			}
		}

		// Token: 0x04007AAA RID: 31402
		private ISetPlayerMoveControl Instance;
	}
}
