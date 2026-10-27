using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EC RID: 6380
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSplineMovePattern
	{
		// Token: 0x060088C5 RID: 35013 RVA: 0x00143484 File Offset: 0x00141684
		private ICloseSplineMovePattern_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSplineMovePattern 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSplineMovePattern_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSplineMovePattern_SetValue());
			}
			return result;
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x001434BC File Offset: 0x001416BC
		public static ICloseSplineMovePattern Create([Nullable(2)] ICloseSplineMovePattern instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x001434CF File Offset: 0x001416CF
		public static ICloseSplineMovePattern CreateFromSetValue([Nullable(2)] ICloseSplineMovePattern_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x001434E2 File Offset: 0x001416E2
		public ICloseSplineMovePattern_SetValue ToSetValue()
		{
			return new ICloseSplineMovePattern_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x060088C9 RID: 35017 RVA: 0x00143501 File Offset: 0x00141701
		// (set) Token: 0x060088CA RID: 35018 RVA: 0x0014352C File Offset: 0x0014172C
		public virtual ESplineMovePattern Type
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

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x0014353C File Offset: 0x0014173C
		// (set) Token: 0x060088CC RID: 35020 RVA: 0x00143576 File Offset: 0x00141776
		public virtual float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseSplineMovePattern_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040055D0 RID: 21968
		[Nullable(2)]
		protected ICloseSplineMovePattern FbInstance;

		// Token: 0x040055D1 RID: 21969
		[Nullable(2)]
		protected ICloseSplineMovePattern_SetValue PocoInterface;
	}
}
