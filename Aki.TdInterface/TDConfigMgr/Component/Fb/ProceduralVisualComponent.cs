using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC7 RID: 3527
	[NullableContext(1)]
	[Nullable(0)]
	public class ProceduralVisualComponent : IComponentBase
	{
		// Token: 0x06005008 RID: 20488 RVA: 0x000C5DCD File Offset: 0x000C3FCD
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

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06005009 RID: 20489 RVA: 0x000C5DEC File Offset: 0x000C3FEC
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

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x000C5E24 File Offset: 0x000C4024
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600500B RID: 20491 RVA: 0x000C5E3A File Offset: 0x000C403A
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

		// Token: 0x04002DE2 RID: 11746
		private IProceduralVisualComponent Instance;

		// Token: 0x04002DE3 RID: 11747
		private List<IProceduralVisualBase> _ConfigsCache;

		// Token: 0x04002DE4 RID: 11748
		private bool _ConfigsInited;
	}
}
