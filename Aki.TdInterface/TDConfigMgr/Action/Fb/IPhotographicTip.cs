using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002759 RID: 10073
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographicTip : ICommonTipType
	{
		// Token: 0x0600E06C RID: 57452 RVA: 0x00213058 File Offset: 0x00211258
		public static IPhotographicTip Create(IPhotographicTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x0600E06D RID: 57453 RVA: 0x00213077 File Offset: 0x00211277
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x0600E06E RID: 57454 RVA: 0x00213084 File Offset: 0x00211284
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x04007C57 RID: 31831
		private IPhotographicTip Instance;
	}
}
