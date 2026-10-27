using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200048D RID: 1165
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractScreenDetectShapeCircle : IInteractScreenDetectShapeBase
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x00046F94 File Offset: 0x00045194
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

		// Token: 0x0600176D RID: 5997 RVA: 0x00046FCC File Offset: 0x000451CC
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

		// Token: 0x0600176E RID: 5998 RVA: 0x00046FDF File Offset: 0x000451DF
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

		// Token: 0x0600176F RID: 5999 RVA: 0x00046FF2 File Offset: 0x000451F2
		public new IInteractScreenDetectShapeCircle_SetValue ToSetValue()
		{
			return new IInteractScreenDetectShapeCircle_SetValue
			{
				Type = this.Type,
				RadiusRatio = this.RadiusRatio
			};
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00047011 File Offset: 0x00045211
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x0004703C File Offset: 0x0004523C
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

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0004704A File Offset: 0x0004524A
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00047079 File Offset: 0x00045279
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

		// Token: 0x0400118E RID: 4494
		[Nullable(2)]
		protected new IInteractScreenDetectShapeCircle FbInstance;

		// Token: 0x0400118F RID: 4495
		[Nullable(2)]
		protected new IInteractScreenDetectShapeCircle_SetValue PocoInterface;
	}
}
