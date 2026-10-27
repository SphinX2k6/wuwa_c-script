using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039C RID: 924
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixSpeed : IConveyorBeltMove
	{
		// Token: 0x06001267 RID: 4711 RVA: 0x0003CCFC File Offset: 0x0003AEFC
		private IFixSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0003CD34 File Offset: 0x0003AF34
		public static IFixSpeed Create([Nullable(2)] IFixSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0003CD47 File Offset: 0x0003AF47
		public static IFixSpeed CreateFromSetValue([Nullable(2)] IFixSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0003CD5A File Offset: 0x0003AF5A
		public new IFixSpeed_SetValue ToSetValue()
		{
			return new IFixSpeed_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0003CD79 File Offset: 0x0003AF79
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
		public override EConveyorBeltMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConveyorBeltMoveType.FixSpeed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003CDB2 File Offset: 0x0003AFB2
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0003CDDD File Offset: 0x0003AFDD
		public virtual int Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x04000ED6 RID: 3798
		[Nullable(2)]
		protected new IFixSpeed FbInstance;

		// Token: 0x04000ED7 RID: 3799
		[Nullable(2)]
		protected new IFixSpeed_SetValue PocoInterface;
	}
}
