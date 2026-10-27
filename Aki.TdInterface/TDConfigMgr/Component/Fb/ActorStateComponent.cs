using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5A RID: 2650
	[NullableContext(1)]
	[Nullable(0)]
	public class ActorStateComponent : IComponentBase
	{
		// Token: 0x06003D08 RID: 15624 RVA: 0x0009CF07 File Offset: 0x0009B107
		public static ActorStateComponent Create(IActorStateComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActorStateComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x0009CF28 File Offset: 0x0009B128
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x0009CF60 File Offset: 0x0009B160
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x0009CF76 File Offset: 0x0009B176
		public virtual string InitState
		{
			get
			{
				return this.Instance.InitState;
			}
		}

		// Token: 0x04002201 RID: 8705
		private IActorStateComponent Instance;
	}
}
