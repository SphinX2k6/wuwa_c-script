using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EC3 RID: 3779
	public class ProceduralVisualComponent : IComponentBase
	{
		// Token: 0x0600552D RID: 21805 RVA: 0x000D161D File Offset: 0x000CF81D
		public static ProceduralVisualComponent Create(IProceduralVisualComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProceduralVisualComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x000D163C File Offset: 0x000CF83C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x000D1674 File Offset: 0x000CF874
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06005530 RID: 21808 RVA: 0x000D168A File Offset: 0x000CF88A
		public virtual List<IProceduralVisualBase> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				this._ConfigsCache = ComponentReadHelper.ReadProceduralVisualComponent_Configs(this.Instance);
				return this._ConfigsCache;
			}
		}

		// Token: 0x040030A8 RID: 12456
		private IProceduralVisualComponent Instance;

		// Token: 0x040030A9 RID: 12457
		private List<IProceduralVisualBase> _ConfigsCache;

		// Token: 0x040030AA RID: 12458
		private bool _ConfigsInited;
	}
}
