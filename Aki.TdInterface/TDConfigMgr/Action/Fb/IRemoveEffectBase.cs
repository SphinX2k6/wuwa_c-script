using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F0 RID: 9712
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemoveEffectBase
	{
		// Token: 0x0600DA3F RID: 55871 RVA: 0x002086E5 File Offset: 0x002068E5
		public static IRemoveEffectBase Create(IRemoveEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x0600DA40 RID: 55872 RVA: 0x00208704 File Offset: 0x00206904
		public virtual EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x0600DA41 RID: 55873 RVA: 0x00208711 File Offset: 0x00206911
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007930 RID: 31024
		private IRemoveEffectBase Instance;
	}
}
