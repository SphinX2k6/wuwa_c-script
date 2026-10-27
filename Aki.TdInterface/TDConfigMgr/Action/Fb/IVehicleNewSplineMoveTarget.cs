using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272A RID: 10026
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600DF91 RID: 57233 RVA: 0x0021203E File Offset: 0x0021023E
		public static IVehicleNewSplineMoveTarget Create(IVehicleNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x0021205D File Offset: 0x0021025D
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x0600DF93 RID: 57235 RVA: 0x0021206A File Offset: 0x0021026A
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadIVehicleNewSplineMoveTarget_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x0600DF94 RID: 57236 RVA: 0x0021209C File Offset: 0x0021029C
		public virtual bool? IsLookDir
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLookDir);
			}
		}

		// Token: 0x04007C12 RID: 31762
		private IVehicleNewSplineMoveTarget Instance;

		// Token: 0x04007C13 RID: 31763
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x04007C14 RID: 31764
		private bool _TargetVehicleInited;
	}
}
