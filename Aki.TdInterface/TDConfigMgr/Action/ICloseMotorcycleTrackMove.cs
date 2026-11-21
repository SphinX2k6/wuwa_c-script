using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A6B RID: 6763
	public class ICloseMotorcycleTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x06008FB5 RID: 36789 RVA: 0x00152708 File Offset: 0x00150908
		private ICloseMotorcycleTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseMotorcycleTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseMotorcycleTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseMotorcycleTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x00152740 File Offset: 0x00150940
		public static ICloseMotorcycleTrackMove Create([Nullable(2)] ICloseMotorcycleTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseMotorcycleTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x00152753 File Offset: 0x00150953
		public static ICloseMotorcycleTrackMove CreateFromSetValue([Nullable(2)] ICloseMotorcycleTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseMotorcycleTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x00152766 File Offset: 0x00150966
		public new ICloseMotorcycleTrackMove_SetValue ToSetValue()
		{
			return new ICloseMotorcycleTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x06008FB9 RID: 36793 RVA: 0x00152785 File Offset: 0x00150985
		// (set) Token: 0x06008FBA RID: 36794 RVA: 0x001527B0 File Offset: 0x001509B0
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x06008FBB RID: 36795 RVA: 0x001527C0 File Offset: 0x001509C0
		// (set) Token: 0x06008FBC RID: 36796 RVA: 0x001527FA File Offset: 0x001509FA
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseMotorcycleTrackMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x04005A07 RID: 23047
		[Nullable(2)]
		protected new ICloseMotorcycleTrackMove FbInstance;

		// Token: 0x04005A08 RID: 23048
		[Nullable(2)]
		protected new ICloseMotorcycleTrackMove_SetValue PocoInterface;
	}
}
