using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF8 RID: 2808
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechFixedPointHook : IMechHookConfigType
	{
		// Token: 0x060040A2 RID: 16546 RVA: 0x000A542A File Offset: 0x000A362A
		[NullableContext(1)]
		public static IMechFixedPointHook Create(IMechFixedPointHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechFixedPointHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x000A5449 File Offset: 0x000A3649
		public override EMechHookConfigType Type
		{
			get
			{
				return (EMechHookConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x000A5456 File Offset: 0x000A3656
		public virtual IMechBehaviorConfig MechBehaviorConfig
		{
			get
			{
				if (this._MechBehaviorConfigInited)
				{
					return this._MechBehaviorConfigCache;
				}
				this._MechBehaviorConfigInited = true;
				this._MechBehaviorConfigCache = IMechBehaviorConfig.Create(this.Instance.MechBehaviorConfig);
				return this._MechBehaviorConfigCache;
			}
		}

		// Token: 0x04002425 RID: 9253
		private IMechFixedPointHook Instance;

		// Token: 0x04002426 RID: 9254
		private IMechBehaviorConfig _MechBehaviorConfigCache;

		// Token: 0x04002427 RID: 9255
		private bool _MechBehaviorConfigInited;
	}
}
