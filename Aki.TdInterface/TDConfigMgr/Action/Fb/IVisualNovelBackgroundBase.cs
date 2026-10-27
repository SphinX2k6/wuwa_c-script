using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002569 RID: 9577
	public class IVisualNovelBackgroundBase
	{
		// Token: 0x0600D6FB RID: 55035 RVA: 0x00200942 File Offset: 0x001FEB42
		[NullableContext(1)]
		public static IVisualNovelBackgroundBase Create(IVisualNovelBackgroundBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x00200961 File Offset: 0x001FEB61
		public virtual EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x0400770B RID: 30475
		private IVisualNovelBackgroundBase Instance;
	}
}
