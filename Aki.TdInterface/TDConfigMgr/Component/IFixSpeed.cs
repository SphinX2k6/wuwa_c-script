using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E5 RID: 997
	public class IFixSpeed : IConveyorBeltMove
	{
		// Token: 0x060013AD RID: 5037 RVA: 0x00040034 File Offset: 0x0003E234
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

		// Token: 0x060013AE RID: 5038 RVA: 0x0004006C File Offset: 0x0003E26C
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

		// Token: 0x060013AF RID: 5039 RVA: 0x0004007F File Offset: 0x0003E27F
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

		// Token: 0x060013B0 RID: 5040 RVA: 0x00040092 File Offset: 0x0003E292
		public new IFixSpeed_SetValue ToSetValue()
		{
			return new IFixSpeed_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000400B1 File Offset: 0x0003E2B1
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x000400DC File Offset: 0x0003E2DC
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x000400EA File Offset: 0x0003E2EA
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00040115 File Offset: 0x0003E315
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

		// Token: 0x04000FCE RID: 4046
		[Nullable(2)]
		protected new IFixSpeed FbInstance;

		// Token: 0x04000FCF RID: 4047
		[Nullable(2)]
		protected new IFixSpeed_SetValue PocoInterface;
	}
}
