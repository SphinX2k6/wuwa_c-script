using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000376 RID: 886
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanInteractByHit : IFanInteractType
	{
		// Token: 0x0600119B RID: 4507 RVA: 0x0003B3B8 File Offset: 0x000395B8
		private IFanInteractByHit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanInteractByHit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanInteractByHit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanInteractByHit_SetValue());
			}
			return result;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0003B3F0 File Offset: 0x000395F0
		public static IFanInteractByHit Create([Nullable(2)] IFanInteractByHit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0003B403 File Offset: 0x00039603
		public static IFanInteractByHit CreateFromSetValue([Nullable(2)] IFanInteractByHit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0003B416 File Offset: 0x00039616
		public new IFanInteractByHit_SetValue ToSetValue()
		{
			return new IFanInteractByHit_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0003B429 File Offset: 0x00039629
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0003B454 File Offset: 0x00039654
		public override EFanInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFanInteractType.Hit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E69 RID: 3689
		[Nullable(2)]
		protected new IFanInteractByHit FbInstance;

		// Token: 0x04000E6A RID: 3690
		[Nullable(2)]
		protected new IFanInteractByHit_SetValue PocoInterface;
	}
}
