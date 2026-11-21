using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC5 RID: 6853
	public class IControlTrackingSelf : IControlTrackingType
	{
		// Token: 0x060091AB RID: 37291 RVA: 0x00155CDC File Offset: 0x00153EDC
		private IControlTrackingSelf_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlTrackingSelf 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlTrackingSelf_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlTrackingSelf_SetValue());
			}
			return result;
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x00155D14 File Offset: 0x00153F14
		public static IControlTrackingSelf Create([Nullable(2)] IControlTrackingSelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x00155D27 File Offset: 0x00153F27
		public static IControlTrackingSelf CreateFromSetValue([Nullable(2)] IControlTrackingSelf_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x00155D3A File Offset: 0x00153F3A
		public new IControlTrackingSelf_SetValue ToSetValue()
		{
			return new IControlTrackingSelf_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x060091AF RID: 37295 RVA: 0x00155D4D File Offset: 0x00153F4D
		// (set) Token: 0x060091B0 RID: 37296 RVA: 0x00155D78 File Offset: 0x00153F78
		public override EControlTrackingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlTrackingType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AE1 RID: 23265
		[Nullable(2)]
		protected new IControlTrackingSelf FbInstance;

		// Token: 0x04005AE2 RID: 23266
		[Nullable(2)]
		protected new IControlTrackingSelf_SetValue PocoInterface;
	}
}
