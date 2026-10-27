using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E2 RID: 6370
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseRacingTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x06008893 RID: 34963 RVA: 0x00142F6C File Offset: 0x0014116C
		private ICloseRacingTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseRacingTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseRacingTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseRacingTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x00142FA4 File Offset: 0x001411A4
		public static ICloseRacingTrackMove Create([Nullable(2)] ICloseRacingTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseRacingTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x00142FB7 File Offset: 0x001411B7
		public static ICloseRacingTrackMove CreateFromSetValue([Nullable(2)] ICloseRacingTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseRacingTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x00142FCA File Offset: 0x001411CA
		public new ICloseRacingTrackMove_SetValue ToSetValue()
		{
			return new ICloseRacingTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x00142FE9 File Offset: 0x001411E9
		// (set) Token: 0x06008898 RID: 34968 RVA: 0x00143014 File Offset: 0x00141214
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

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06008899 RID: 34969 RVA: 0x00143024 File Offset: 0x00141224
		// (set) Token: 0x0600889A RID: 34970 RVA: 0x0014305E File Offset: 0x0014125E
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040055BC RID: 21948
		[Nullable(2)]
		protected new ICloseRacingTrackMove FbInstance;

		// Token: 0x040055BD RID: 21949
		[Nullable(2)]
		protected new ICloseRacingTrackMove_SetValue PocoInterface;
	}
}
