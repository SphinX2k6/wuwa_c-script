using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B23 RID: 2851
	public class ActorStateComponent : IComponentBase
	{
		// Token: 0x06004128 RID: 16680 RVA: 0x000A637F File Offset: 0x000A457F
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x000A63A0 File Offset: 0x000A45A0
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

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x000A63D8 File Offset: 0x000A45D8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x000A63EE File Offset: 0x000A45EE
		public virtual string InitState
		{
			get
			{
				return this.Instance.InitState;
			}
		}

		// Token: 0x04002418 RID: 9240
		private IActorStateComponent Instance;
	}
}
