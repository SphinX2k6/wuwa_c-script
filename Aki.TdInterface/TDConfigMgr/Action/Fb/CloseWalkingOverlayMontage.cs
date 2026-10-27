using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9E RID: 10910
	public class CloseWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600EF9B RID: 61339 RVA: 0x0022D3BD File Offset: 0x0022B5BD
		[NullableContext(1)]
		public static CloseWalkingOverlayMontage Create(ICloseWalkingOverlayMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseWalkingOverlayMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x0022D3DC File Offset: 0x0022B5DC
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040083CC RID: 33740
		private ICloseWalkingOverlayMontage Instance;
	}
}
