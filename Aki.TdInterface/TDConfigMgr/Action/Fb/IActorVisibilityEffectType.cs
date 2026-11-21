using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DD RID: 10205
	public class IActorVisibilityEffectType
	{
		// Token: 0x0600E1B2 RID: 57778 RVA: 0x00212961 File Offset: 0x00210B61
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

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600E1B3 RID: 57779 RVA: 0x00212980 File Offset: 0x00210B80
		public virtual EActorVisibilityEffectType Type
		{
			get
			{
				return (EActorVisibilityEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007AA5 RID: 31397
		private IActorVisibilityEffectType Instance;
	}
}
