using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256B RID: 9579
	public class IVisualNovelBackgroundClean : IVisualNovelBackgroundBase
	{
		// Token: 0x0600D702 RID: 55042 RVA: 0x002009B7 File Offset: 0x001FEBB7
		[NullableContext(1)]
		public static IVisualNovelBackgroundClean Create(IVisualNovelBackgroundClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600D703 RID: 55043 RVA: 0x002009D6 File Offset: 0x001FEBD6
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x0400770D RID: 30477
		private IVisualNovelBackgroundClean Instance;
	}
}
