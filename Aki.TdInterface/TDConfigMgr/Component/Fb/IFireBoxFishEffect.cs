using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E45 RID: 3653
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBoxFishEffect : IGraph3dEffectBase
	{
		// Token: 0x06005284 RID: 21124 RVA: 0x000CB206 File Offset: 0x000C9406
		public static IFireBoxFishEffect Create(IFireBoxFishEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x000CB225 File Offset: 0x000C9425
		public override EGraph3dEffectType Type
		{
			get
			{
				return (EGraph3dEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005286 RID: 21126 RVA: 0x000CB232 File Offset: 0x000C9432
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x04002F90 RID: 12176
		private IFireBoxFishEffect Instance;
	}
}
