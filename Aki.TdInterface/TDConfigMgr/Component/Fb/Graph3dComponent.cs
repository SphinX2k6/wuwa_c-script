using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F3F RID: 3903
	public class Graph3dComponent : IComponentBase
	{
		// Token: 0x060057A3 RID: 22435 RVA: 0x000D69F1 File Offset: 0x000D4BF1
		public static Graph3dComponent Create(IGraph3dComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Graph3dComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x000D6A10 File Offset: 0x000D4C10
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

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x000D6A48 File Offset: 0x000D4C48
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x000D6A5E File Offset: 0x000D4C5E
		public virtual IGraph3dNormal GraphConfig
		{
			get
			{
				if (this._GraphConfigInited)
				{
					return this._GraphConfigCache;
				}
				this._GraphConfigInited = true;
				this._GraphConfigCache = IGraph3dNormal.Create(this.Instance.GraphConfig);
				return this._GraphConfigCache;
			}
		}

		// Token: 0x04003254 RID: 12884
		private IGraph3dComponent Instance;

		// Token: 0x04003255 RID: 12885
		[Nullable(2)]
		private IGraph3dNormal _GraphConfigCache;

		// Token: 0x04003256 RID: 12886
		private bool _GraphConfigInited;
	}
}
