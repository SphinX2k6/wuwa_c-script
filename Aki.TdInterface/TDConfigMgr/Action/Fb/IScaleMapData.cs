using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FA RID: 10490
	[NullableContext(1)]
	[Nullable(0)]
	public class IScaleMapData
	{
		// Token: 0x0600E8F7 RID: 59639 RVA: 0x00222C35 File Offset: 0x00220E35
		public static IScaleMapData Create(IScaleMapData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScaleMapData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x00222C54 File Offset: 0x00220E54
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x0600E8F9 RID: 59641 RVA: 0x00222C61 File Offset: 0x00220E61
		public virtual float Scale
		{
			get
			{
				return this.Instance.Scale;
			}
		}

		// Token: 0x0400809C RID: 32924
		private IScaleMapData Instance;
	}
}
