using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E35 RID: 3637
	public class ITriggerMatchConfig
	{
		// Token: 0x0600525A RID: 21082 RVA: 0x000CBA98 File Offset: 0x000C9C98
		public static ITriggerMatchConfig Create(ITriggerMatchConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerMatchConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x000CBAB7 File Offset: 0x000C9CB7
		public virtual IEntityMatchConfig EntityMatch
		{
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				this._EntityMatchCache = ComponentReadHelper.ReadITriggerMatchConfig_EntityMatch(this.Instance);
				return this._EntityMatchCache;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x000CBAE8 File Offset: 0x000C9CE8
		public virtual int? EntityMatchCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityMatchCount);
			}
		}

		// Token: 0x04002F08 RID: 12040
		private ITriggerMatchConfig Instance;

		// Token: 0x04002F09 RID: 12041
		private IEntityMatchConfig _EntityMatchCache;

		// Token: 0x04002F0A RID: 12042
		private bool _EntityMatchInited;
	}
}
