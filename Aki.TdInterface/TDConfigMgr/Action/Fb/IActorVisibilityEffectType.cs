using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002536 RID: 9526
	public class IActorVisibilityEffectType
	{
		// Token: 0x0600D452 RID: 54354 RVA: 0x001F6F01 File Offset: 0x001F5101
		[NullableContext(1)]
		public static IActorVisibilityEffectType Create(IActorVisibilityEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibilityEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600D453 RID: 54355 RVA: 0x001F6F20 File Offset: 0x001F5120
		public virtual EActorVisibilityEffectType Type
		{
			get
			{
				return (EActorVisibilityEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007450 RID: 29776
		private IActorVisibilityEffectType Instance;
	}
}
