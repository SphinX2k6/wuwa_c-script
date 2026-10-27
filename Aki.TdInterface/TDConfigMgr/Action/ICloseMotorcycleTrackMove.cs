using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018DE RID: 6366
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseMotorcycleTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600887F RID: 34943 RVA: 0x00142D4C File Offset: 0x00140F4C
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

		// Token: 0x06008880 RID: 34944 RVA: 0x00142D84 File Offset: 0x00140F84
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

		// Token: 0x06008881 RID: 34945 RVA: 0x00142D97 File Offset: 0x00140F97
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

		// Token: 0x06008882 RID: 34946 RVA: 0x00142DAA File Offset: 0x00140FAA
		public new ICloseMotorcycleTrackMove_SetValue ToSetValue()
		{
			return new ICloseMotorcycleTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x00142DC9 File Offset: 0x00140FC9
		// (set) Token: 0x06008884 RID: 34948 RVA: 0x00142DF4 File Offset: 0x00140FF4
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

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x00142E04 File Offset: 0x00141004
		// (set) Token: 0x06008886 RID: 34950 RVA: 0x00142E3E File Offset: 0x0014103E
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

		// Token: 0x040055B4 RID: 21940
		[Nullable(2)]
		protected new ICloseMotorcycleTrackMove FbInstance;

		// Token: 0x040055B5 RID: 21941
		[Nullable(2)]
		protected new ICloseMotorcycleTrackMove_SetValue PocoInterface;
	}
}
