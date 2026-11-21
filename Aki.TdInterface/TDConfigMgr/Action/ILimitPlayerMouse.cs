using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3D RID: 7485
	public class ILimitPlayerMouse : ILimitPlayerOption
	{
		// Token: 0x06009EF3 RID: 40691 RVA: 0x0016D550 File Offset: 0x0016B750
		private ILimitPlayerMouse_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMouse 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMouse_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMouse_SetValue());
			}
			return result;
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x0016D588 File Offset: 0x0016B788
		public static ILimitPlayerMouse Create([Nullable(2)] ILimitPlayerMouse instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x0016D59B File Offset: 0x0016B79B
		public static ILimitPlayerMouse CreateFromSetValue([Nullable(2)] ILimitPlayerMouse_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x0016D5AE File Offset: 0x0016B7AE
		public new ILimitPlayerMouse_SetValue ToSetValue()
		{
			return new ILimitPlayerMouse_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x0016D5C1 File Offset: 0x0016B7C1
		// (set) Token: 0x06009EF8 RID: 40696 RVA: 0x0016D5EC File Offset: 0x0016B7EC
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060DB RID: 24795
		[Nullable(2)]
		protected new ILimitPlayerMouse FbInstance;

		// Token: 0x040060DC RID: 24796
		[Nullable(2)]
		protected new ILimitPlayerMouse_SetValue PocoInterface;
	}
}
