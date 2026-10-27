using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C9 RID: 10697
	public class IVehiclePlayerMotor : ITargetVehicle
	{
		// Token: 0x0600EC72 RID: 60530 RVA: 0x0022867A File Offset: 0x0022687A
		[NullableContext(1)]
		public static IVehiclePlayerMotor Create(IVehiclePlayerMotor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePlayerMotor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x00228699 File Offset: 0x00226899
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x0600EC74 RID: 60532 RVA: 0x002286A8 File Offset: 0x002268A8
		public virtual int? SummonPositionEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SummonPositionEntityId);
			}
		}

		// Token: 0x04008229 RID: 33321
		private IVehiclePlayerMotor Instance;
	}
}
