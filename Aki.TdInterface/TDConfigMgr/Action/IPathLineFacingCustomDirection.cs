using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC4 RID: 7364
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathLineFacingCustomDirection : IPathLineFacingType
	{
		// Token: 0x06009E15 RID: 40469 RVA: 0x00169B50 File Offset: 0x00167D50
		private IPathLineFacingCustomDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingCustomDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingCustomDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingCustomDirection_SetValue());
			}
			return result;
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x00169B88 File Offset: 0x00167D88
		public static IPathLineFacingCustomDirection Create([Nullable(2)] IPathLineFacingCustomDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x00169B9B File Offset: 0x00167D9B
		public static IPathLineFacingCustomDirection CreateFromSetValue([Nullable(2)] IPathLineFacingCustomDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x00169BAE File Offset: 0x00167DAE
		public new IPathLineFacingCustomDirection_SetValue ToSetValue()
		{
			return new IPathLineFacingCustomDirection_SetValue
			{
				Type = this.Type,
				Yaw = this.Yaw
			};
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x00169BCD File Offset: 0x00167DCD
		// (set) Token: 0x06009E1A RID: 40474 RVA: 0x00169BF8 File Offset: 0x00167DF8
		public override EPathLineFacingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathLineFacingType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06009E1B RID: 40475 RVA: 0x00169C06 File Offset: 0x00167E06
		// (set) Token: 0x06009E1C RID: 40476 RVA: 0x00169C35 File Offset: 0x00167E35
		public virtual float Yaw
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Yaw;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Yaw;
			}
			set
			{
				this.GetOrCreatePoco().Yaw = value;
			}
		}

		// Token: 0x04005F98 RID: 24472
		[Nullable(2)]
		protected new IPathLineFacingCustomDirection FbInstance;

		// Token: 0x04005F99 RID: 24473
		[Nullable(2)]
		protected new IPathLineFacingCustomDirection_SetValue PocoInterface;
	}
}
