using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A68 RID: 2664
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatorComponent2 : IComponentBase
	{
		// Token: 0x06003D67 RID: 15719 RVA: 0x0009DAC2 File Offset: 0x0009BCC2
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x0009DAE4 File Offset: 0x0009BCE4
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x0009DB1C File Offset: 0x0009BD1C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x0009DB34 File Offset: 0x0009BD34
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

		// Token: 0x04002235 RID: 8757
		private IRotatorComponent2 Instance;

		// Token: 0x04002236 RID: 8758
		private List<IStateRotationConfig> _ConfigCache;

		// Token: 0x04002237 RID: 8759
		private bool _ConfigInited;
	}
}
