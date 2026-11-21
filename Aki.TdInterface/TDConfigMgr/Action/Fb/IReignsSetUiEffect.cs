using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3D RID: 11581
	public class IReignsSetUiEffect : ActionParams
	{
		// Token: 0x0600FCFA RID: 64762 RVA: 0x00248E1A File Offset: 0x0024701A
		public static IReignsSetUiEffect Create(IReignsSetUiEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReignsSetUiEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x0600FCFB RID: 64763 RVA: 0x00248E39 File Offset: 0x00247039
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x0600FCFC RID: 64764 RVA: 0x00248E46 File Offset: 0x00247046
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x04008A1F RID: 35359
		private IReignsSetUiEffect Instance;
	}
}
