using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF4 RID: 7668
	[NullableContext(1)]
	[Nullable(0)]
	public class ISelfVehicle : ITargetVehicle
	{
		// Token: 0x0600A417 RID: 42007 RVA: 0x0017440C File Offset: 0x0017260C
		private ISelfVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00174444 File Offset: 0x00172644
		public static ISelfVehicle Create([Nullable(2)] ISelfVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00174457 File Offset: 0x00172657
		public static ISelfVehicle CreateFromSetValue([Nullable(2)] ISelfVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x0017446A File Offset: 0x0017266A
		public new ISelfVehicle_SetValue ToSetValue()
		{
			return new ISelfVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A41B RID: 42011 RVA: 0x0017447D File Offset: 0x0017267D
		// (set) Token: 0x0600A41C RID: 42012 RVA: 0x001744A8 File Offset: 0x001726A8
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006249 RID: 25161
		[Nullable(2)]
		protected new ISelfVehicle FbInstance;

		// Token: 0x0400624A RID: 25162
		[Nullable(2)]
		protected new ISelfVehicle_SetValue PocoInterface;
	}
}
