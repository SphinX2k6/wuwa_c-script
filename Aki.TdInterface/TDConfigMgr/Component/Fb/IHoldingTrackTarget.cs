using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B50 RID: 2896
	[NullableContext(1)]
	[Nullable(0)]
	public class IHoldingTrackTarget
	{
		// Token: 0x060042B7 RID: 17079 RVA: 0x000AA51C File Offset: 0x000A871C
		public static IHoldingTrackTarget Create(IHoldingTrackTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldingTrackTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x000AA53B File Offset: 0x000A873B
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x000AA548 File Offset: 0x000A8748
		public virtual int EffectLength
		{
			get
			{
				return this.Instance.EffectLength;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x000AA555 File Offset: 0x000A8755
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04002593 RID: 9619
		private IHoldingTrackTarget Instance;
	}
}
