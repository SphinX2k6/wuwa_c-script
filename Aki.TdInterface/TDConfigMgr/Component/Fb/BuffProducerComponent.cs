using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD7 RID: 3287
	public class BuffProducerComponent : IComponentBase
	{
		// Token: 0x06004B13 RID: 19219 RVA: 0x000BC8B8 File Offset: 0x000BAAB8
		public static BuffProducerComponent Create(IBuffProducerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BuffProducerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x000BC8D8 File Offset: 0x000BAAD8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x000BC910 File Offset: 0x000BAB10
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x000BC926 File Offset: 0x000BAB26
		public virtual IAddBuffMode AddBuffMode
		{
			get
			{
				if (this._AddBuffModeInited)
				{
					return this._AddBuffModeCache;
				}
				this._AddBuffModeInited = true;
				this._AddBuffModeCache = ComponentReadHelper.ReadBuffProducerComponent_AddBuffMode(this.Instance);
				return this._AddBuffModeCache;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x000BC955 File Offset: 0x000BAB55
		public virtual long BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x04002A80 RID: 10880
		private IBuffProducerComponent Instance;

		// Token: 0x04002A81 RID: 10881
		private IAddBuffMode _AddBuffModeCache;

		// Token: 0x04002A82 RID: 10882
		private bool _AddBuffModeInited;
	}
}
