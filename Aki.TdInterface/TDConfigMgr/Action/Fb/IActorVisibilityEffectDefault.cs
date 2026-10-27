using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002537 RID: 9527
	public class IActorVisibilityEffectDefault : IActorVisibilityEffectType
	{
		// Token: 0x0600D455 RID: 54357 RVA: 0x001F6F35 File Offset: 0x001F5135
		[NullableContext(1)]
		public static IActorVisibilityEffectDefault Create(IActorVisibilityEffectDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibilityEffectDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x001F6F54 File Offset: 0x001F5154
		public override EActorVisibilityEffectType Type
		{
			get
			{
				return (EActorVisibilityEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007451 RID: 29777
		private IActorVisibilityEffectDefault Instance;
	}
}
