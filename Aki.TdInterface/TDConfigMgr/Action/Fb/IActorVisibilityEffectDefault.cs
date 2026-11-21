using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DE RID: 10206
	public class IActorVisibilityEffectDefault : IActorVisibilityEffectType
	{
		// Token: 0x0600E1B5 RID: 57781 RVA: 0x00212995 File Offset: 0x00210B95
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

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x002129B4 File Offset: 0x00210BB4
		public override EActorVisibilityEffectType Type
		{
			get
			{
				return (EActorVisibilityEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007AA6 RID: 31398
		private IActorVisibilityEffectDefault Instance;
	}
}
