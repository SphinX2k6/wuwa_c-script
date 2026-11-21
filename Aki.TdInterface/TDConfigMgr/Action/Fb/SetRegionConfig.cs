using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4D RID: 11341
	public class SetRegionConfig : ActionParams
	{
		// Token: 0x0600F968 RID: 63848 RVA: 0x00243A59 File Offset: 0x00241C59
		public static SetRegionConfig Create(ISetRegionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x0600F969 RID: 63849 RVA: 0x00243A78 File Offset: 0x00241C78
		public virtual ERegionConfigType Type
		{
			get
			{
				return (ERegionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04008853 RID: 34899
		private ISetRegionConfig Instance;
	}
}
