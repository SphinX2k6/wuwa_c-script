using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E43 RID: 3651
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph3dComponent : IComponentBase
	{
		// Token: 0x0600527C RID: 21116 RVA: 0x000CB129 File Offset: 0x000C9329
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

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x000CB148 File Offset: 0x000C9348
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

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x000CB180 File Offset: 0x000C9380
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x000CB196 File Offset: 0x000C9396
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

		// Token: 0x04002F8C RID: 12172
		private IGraph3dComponent Instance;

		// Token: 0x04002F8D RID: 12173
		[Nullable(2)]
		private IGraph3dNormal _GraphConfigCache;

		// Token: 0x04002F8E RID: 12174
		private bool _GraphConfigInited;
	}
}
