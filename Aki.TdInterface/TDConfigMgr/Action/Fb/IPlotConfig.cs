using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AE RID: 9646
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotConfig
	{
		// Token: 0x0600D8FE RID: 55550 RVA: 0x00206126 File Offset: 0x00204326
		public static IPlotConfig Create(IPlotConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0600D8FF RID: 55551 RVA: 0x00206145 File Offset: 0x00204345
		public virtual string EdPlotNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x00206148 File Offset: 0x00204348
		public virtual bool EdPlotHandleJump
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0600D901 RID: 55553 RVA: 0x0020614B File Offset: 0x0020434B
		public virtual string EdPlotFileId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0600D902 RID: 55554 RVA: 0x00206150 File Offset: 0x00204350
		public virtual EVisualNovelLayout? EdPlotLayout
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400788C RID: 30860
		private IPlotConfig Instance;
	}
}
