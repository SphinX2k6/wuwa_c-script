using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E6 RID: 1254
	public class IInteractScreenDetectShapeCircle : IInteractScreenDetectShapeBase
	{
		// Token: 0x06001906 RID: 6406 RVA: 0x0004ACDC File Offset: 0x00048EDC
		private IInteractScreenDetectShapeCircle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractScreenDetectShapeCircle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractScreenDetectShapeCircle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractScreenDetectShapeCircle_SetValue());
			}
			return result;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0004AD14 File Offset: 0x00048F14
		public static IInteractScreenDetectShapeCircle Create([Nullable(2)] IInteractScreenDetectShapeCircle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeCircle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0004AD27 File Offset: 0x00048F27
		public static IInteractScreenDetectShapeCircle CreateFromSetValue([Nullable(2)] IInteractScreenDetectShapeCircle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeCircle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0004AD3A File Offset: 0x00048F3A
		public new IInteractScreenDetectShapeCircle_SetValue ToSetValue()
		{
			return new IInteractScreenDetectShapeCircle_SetValue
			{
				Type = this.Type,
				RadiusRatio = this.RadiusRatio
			};
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0004AD59 File Offset: 0x00048F59
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0004AD84 File Offset: 0x00048F84
		public override EInteractScreenDetectShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0004AD92 File Offset: 0x00048F92
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0004ADC1 File Offset: 0x00048FC1
		public virtual float RadiusRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RadiusRatio;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RadiusRatio;
			}
			set
			{
				this.GetOrCreatePoco().RadiusRatio = value;
			}
		}

		// Token: 0x040012B0 RID: 4784
		[Nullable(2)]
		protected new IInteractScreenDetectShapeCircle FbInstance;

		// Token: 0x040012B1 RID: 4785
		[Nullable(2)]
		protected new IInteractScreenDetectShapeCircle_SetValue PocoInterface;
	}
}
