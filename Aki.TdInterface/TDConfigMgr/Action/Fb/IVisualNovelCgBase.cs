using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002565 RID: 9573
	public class IVisualNovelCgBase
	{
		// Token: 0x0600D6ED RID: 55021 RVA: 0x00200858 File Offset: 0x001FEA58
		[NullableContext(1)]
		public static IVisualNovelCgBase Create(IVisualNovelCgBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600D6EE RID: 55022 RVA: 0x00200877 File Offset: 0x001FEA77
		public virtual EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x04007707 RID: 30471
		private IVisualNovelCgBase Instance;
	}
}
