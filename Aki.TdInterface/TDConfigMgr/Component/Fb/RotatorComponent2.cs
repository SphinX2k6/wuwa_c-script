using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B32 RID: 2866
	public class RotatorComponent2 : IComponentBase
	{
		// Token: 0x06004190 RID: 16784 RVA: 0x000A707A File Offset: 0x000A527A
		public static RotatorComponent2 Create(IRotatorComponent2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorComponent2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x000A709C File Offset: 0x000A529C
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

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x000A70D4 File Offset: 0x000A52D4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x000A70EC File Offset: 0x000A52EC
		public virtual List<IStateRotationConfig> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IStateRotationConfig>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IStateRotationConfig.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x04002451 RID: 9297
		private IRotatorComponent2 Instance;

		// Token: 0x04002452 RID: 9298
		private List<IStateRotationConfig> _ConfigCache;

		// Token: 0x04002453 RID: 9299
		private bool _ConfigInited;
	}
}
