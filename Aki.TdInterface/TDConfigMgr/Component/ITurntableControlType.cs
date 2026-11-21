using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084F RID: 2127
	public class ITurntableControlType
	{
		// Token: 0x06002DC8 RID: 11720 RVA: 0x00076DB8 File Offset: 0x00074FB8
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

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00076DF0 File Offset: 0x00074FF0
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

		// Token: 0x06002DCA RID: 11722 RVA: 0x00076E03 File Offset: 0x00075003
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

		// Token: 0x06002DCB RID: 11723 RVA: 0x00076E16 File Offset: 0x00075016
		public ITurntableControlType_SetValue ToSetValue()
		{
			return new ITurntableControlType_SetValue
			{
				Type = this.Type,
				RotationSpeed = this.RotationSpeed
			};
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x00076E35 File Offset: 0x00075035
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x00076E60 File Offset: 0x00075060
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x00076E6E File Offset: 0x0007506E
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x00076E99 File Offset: 0x00075099
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

		// Token: 0x04001E76 RID: 7798
		[Nullable(2)]
		protected ITurntableControlType FbInstance;

		// Token: 0x04001E77 RID: 7799
		[Nullable(2)]
		protected ITurntableControlType_SetValue PocoInterface;
	}
}
