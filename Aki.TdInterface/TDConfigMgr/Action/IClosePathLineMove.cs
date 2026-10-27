using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E0 RID: 6368
	[NullableContext(1)]
	[Nullable(0)]
	public class IClosePathLineMove : ICloseSplineMovePattern
	{
		// Token: 0x06008889 RID: 34953 RVA: 0x00142E5C File Offset: 0x0014105C
		private IClosePathLineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClosePathLineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClosePathLineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClosePathLineMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x00142E94 File Offset: 0x00141094
		public static IClosePathLineMove Create([Nullable(2)] IClosePathLineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClosePathLineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x00142EA7 File Offset: 0x001410A7
		public static IClosePathLineMove CreateFromSetValue([Nullable(2)] IClosePathLineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClosePathLineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x00142EBA File Offset: 0x001410BA
		public new IClosePathLineMove_SetValue ToSetValue()
		{
			return new IClosePathLineMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x00142ED9 File Offset: 0x001410D9
		// (set) Token: 0x0600888E RID: 34958 RVA: 0x00142F04 File Offset: 0x00141104
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

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600888F RID: 34959 RVA: 0x00142F14 File Offset: 0x00141114
		// (set) Token: 0x06008890 RID: 34960 RVA: 0x00142F4E File Offset: 0x0014114E
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IClosePathLineMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040055B8 RID: 21944
		[Nullable(2)]
		protected new IClosePathLineMove FbInstance;

		// Token: 0x040055B9 RID: 21945
		[Nullable(2)]
		protected new IClosePathLineMove_SetValue PocoInterface;
	}
}
