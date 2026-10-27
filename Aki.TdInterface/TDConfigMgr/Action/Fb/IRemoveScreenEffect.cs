using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F1 RID: 9713
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemoveScreenEffect : IRemoveEffectBase
	{
		// Token: 0x0600DA43 RID: 55875 RVA: 0x00208726 File Offset: 0x00206926
		public static IRemoveScreenEffect Create(IRemoveScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0600DA44 RID: 55876 RVA: 0x00208745 File Offset: 0x00206945
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0600DA45 RID: 55877 RVA: 0x00208752 File Offset: 0x00206952
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007931 RID: 31025
		private IRemoveScreenEffect Instance;
	}
}
