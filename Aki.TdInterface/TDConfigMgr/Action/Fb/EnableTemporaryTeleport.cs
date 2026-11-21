using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4C RID: 11340
	public class EnableTemporaryTeleport : ActionParams
	{
		// Token: 0x0600F964 RID: 63844 RVA: 0x00243A18 File Offset: 0x00241C18
		public static EnableTemporaryTeleport Create(IEnableTemporaryTeleport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableTemporaryTeleport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x0600F965 RID: 63845 RVA: 0x00243A37 File Offset: 0x00241C37
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x0600F966 RID: 63846 RVA: 0x00243A44 File Offset: 0x00241C44
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x04008852 RID: 34898
		private IEnableTemporaryTeleport Instance;
	}
}
