using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C07 RID: 3079
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffProducerComponent : IComponentBase
	{
		// Token: 0x060046B0 RID: 18096 RVA: 0x000B26EC File Offset: 0x000B08EC
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

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x000B270C File Offset: 0x000B090C
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x000B2744 File Offset: 0x000B0944
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x000B275A File Offset: 0x000B095A
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

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000B2789 File Offset: 0x000B0989
		public virtual long BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x04002834 RID: 10292
		private IBuffProducerComponent Instance;

		// Token: 0x04002835 RID: 10293
		private IAddBuffMode _AddBuffModeCache;

		// Token: 0x04002836 RID: 10294
		private bool _AddBuffModeInited;
	}
}
