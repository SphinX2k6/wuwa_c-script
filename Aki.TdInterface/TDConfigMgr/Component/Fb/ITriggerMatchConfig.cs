using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3B RID: 3387
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerMatchConfig
	{
		// Token: 0x06004D3E RID: 19774 RVA: 0x000C0354 File Offset: 0x000BE554
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

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06004D3F RID: 19775 RVA: 0x000C0373 File Offset: 0x000BE573
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

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x000C03A4 File Offset: 0x000BE5A4
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

		// Token: 0x04002C48 RID: 11336
		private ITriggerMatchConfig Instance;

		// Token: 0x04002C49 RID: 11337
		private IEntityMatchConfig _EntityMatchCache;

		// Token: 0x04002C4A RID: 11338
		private bool _EntityMatchInited;
	}
}
