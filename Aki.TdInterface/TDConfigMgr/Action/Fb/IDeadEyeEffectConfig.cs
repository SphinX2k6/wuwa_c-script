using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAE RID: 11694
	public class IDeadEyeEffectConfig
	{
		// Token: 0x0600FEC2 RID: 65218 RVA: 0x0024BBC9 File Offset: 0x00249DC9
		public static IDeadEyeEffectConfig Create(IDeadEyeEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadEyeEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x0600FEC3 RID: 65219 RVA: 0x0024BBE8 File Offset: 0x00249DE8
		public virtual string FilterEffect
		{
			get
			{
				return this.Instance.FilterEffect;
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x0600FEC4 RID: 65220 RVA: 0x0024BBF5 File Offset: 0x00249DF5
		[Nullable(2)]
		public virtual string TargetIdleMaterialDa
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TargetIdleMaterialDa;
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x0600FEC5 RID: 65221 RVA: 0x0024BC02 File Offset: 0x00249E02
		[Nullable(2)]
		public virtual string TargetLockedMaterialDa
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TargetLockedMaterialDa;
			}
		}

		// Token: 0x04008B0C RID: 35596
		private IDeadEyeEffectConfig Instance;
	}
}
