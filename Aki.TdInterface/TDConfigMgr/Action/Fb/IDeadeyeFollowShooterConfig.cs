using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB8 RID: 10936
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeadeyeFollowShooterConfig
	{
		// Token: 0x0600F006 RID: 61446 RVA: 0x0022DE55 File Offset: 0x0022C055
		public static IDeadeyeFollowShooterConfig Create(IDeadeyeFollowShooterConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x0600F007 RID: 61447 RVA: 0x0022DE74 File Offset: 0x0022C074
		public virtual string DeadeyeShooterDa
		{
			get
			{
				return this.Instance.DeadeyeShooterDa;
			}
		}

		// Token: 0x04008406 RID: 33798
		private IDeadeyeFollowShooterConfig Instance;
	}
}
