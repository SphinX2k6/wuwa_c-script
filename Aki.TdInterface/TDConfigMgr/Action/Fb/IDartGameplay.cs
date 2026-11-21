using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B4A RID: 11082
	public class IDartGameplay : IUiGame
	{
		// Token: 0x0600F3A4 RID: 62372 RVA: 0x00238B0E File Offset: 0x00236D0E
		public static IDartGameplay Create(IDartGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x0600F3A5 RID: 62373 RVA: 0x00238B2D File Offset: 0x00236D2D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x0600F3A6 RID: 62374 RVA: 0x00238B3A File Offset: 0x00236D3A
		public virtual int MachineEntityId
		{
			get
			{
				return this.Instance.MachineEntityId;
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x0600F3A7 RID: 62375 RVA: 0x00238B47 File Offset: 0x00236D47
		public virtual IDartInteractTypeBase InteractType
		{
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ActionReadHelper.ReadIDartGameplay_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x0400859C RID: 34204
		private IDartGameplay Instance;

		// Token: 0x0400859D RID: 34205
		private IDartInteractTypeBase _InteractTypeCache;

		// Token: 0x0400859E RID: 34206
		private bool _InteractTypeInited;
	}
}
