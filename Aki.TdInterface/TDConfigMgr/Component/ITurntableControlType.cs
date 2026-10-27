using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AC RID: 1964
	[NullableContext(1)]
	[Nullable(0)]
	public class ITurntableControlType
	{
		// Token: 0x06002A98 RID: 10904 RVA: 0x0006FA54 File Offset: 0x0006DC54
		private ITurntableControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITurntableControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITurntableControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITurntableControlType_SetValue());
			}
			return result;
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0006FA8C File Offset: 0x0006DC8C
		public static ITurntableControlType Create([Nullable(2)] ITurntableControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0006FA9F File Offset: 0x0006DC9F
		public static ITurntableControlType CreateFromSetValue([Nullable(2)] ITurntableControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITurntableControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0006FAB2 File Offset: 0x0006DCB2
		public ITurntableControlType_SetValue ToSetValue()
		{
			return new ITurntableControlType_SetValue
			{
				Type = this.Type,
				RotationSpeed = this.RotationSpeed
			};
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x0006FAD1 File Offset: 0x0006DCD1
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x0006FAFC File Offset: 0x0006DCFC
		public virtual EControllerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControllerType.FreeAngle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x0006FB0A File Offset: 0x0006DD0A
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0006FB35 File Offset: 0x0006DD35
		public virtual int RotationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RotationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotationSpeed = value;
			}
		}

		// Token: 0x04001C6A RID: 7274
		[Nullable(2)]
		protected ITurntableControlType FbInstance;

		// Token: 0x04001C6B RID: 7275
		[Nullable(2)]
		protected ITurntableControlType_SetValue PocoInterface;
	}
}
