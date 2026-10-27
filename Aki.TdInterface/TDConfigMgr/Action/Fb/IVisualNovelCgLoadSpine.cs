using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002566 RID: 9574
	public class IVisualNovelCgLoadSpine : IVisualNovelCgBase
	{
		// Token: 0x0600D6F0 RID: 55024 RVA: 0x0020088C File Offset: 0x001FEA8C
		[NullableContext(1)]
		public static IVisualNovelCgLoadSpine Create(IVisualNovelCgLoadSpine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadSpine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600D6F1 RID: 55025 RVA: 0x002008AB File Offset: 0x001FEAAB
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600D6F2 RID: 55026 RVA: 0x002008B8 File Offset: 0x001FEAB8
		public virtual int SpineId
		{
			get
			{
				return this.Instance.SpineId;
			}
		}

		// Token: 0x04007708 RID: 30472
		private IVisualNovelCgLoadSpine Instance;
	}
}
