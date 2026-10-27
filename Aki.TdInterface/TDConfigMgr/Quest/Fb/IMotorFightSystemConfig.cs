using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012EA RID: 4842
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorFightSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E8F RID: 28303 RVA: 0x0010B1C8 File Offset: 0x001093C8
		public static IMotorFightSystemConfig Create(IMotorFightSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorFightSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x0010B1E7 File Offset: 0x001093E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06006E91 RID: 28305 RVA: 0x0010B1F4 File Offset: 0x001093F4
		public virtual List<IMotorFightSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IMotorFightSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IMotorFightSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x04003F5A RID: 16218
		private IMotorFightSystemConfig Instance;

		// Token: 0x04003F5B RID: 16219
		private List<IMotorFightSystemVar> _VarsCache;

		// Token: 0x04003F5C RID: 16220
		private bool _VarsInited;
	}
}
