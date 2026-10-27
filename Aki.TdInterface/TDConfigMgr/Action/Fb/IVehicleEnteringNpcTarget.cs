using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B8 RID: 10680
	public class IVehicleEnteringNpcTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600EC33 RID: 60467 RVA: 0x00228112 File Offset: 0x00226312
		[NullableContext(1)]
		public static IVehicleEnteringNpcTarget Create(IVehicleEnteringNpcTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringNpcTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x0600EC34 RID: 60468 RVA: 0x00228131 File Offset: 0x00226331
		public override EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x0600EC35 RID: 60469 RVA: 0x00228140 File Offset: 0x00226340
		public override int? TargetVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetVehicle);
			}
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0600EC36 RID: 60470 RVA: 0x00228176 File Offset: 0x00226376
		public virtual int TargetNpc
		{
			get
			{
				return this.Instance.TargetNpc;
			}
		}

		// Token: 0x0400820C RID: 33292
		private IVehicleEnteringNpcTarget Instance;
	}
}
