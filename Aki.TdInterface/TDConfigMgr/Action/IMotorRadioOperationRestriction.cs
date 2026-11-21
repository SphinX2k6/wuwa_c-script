using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E17 RID: 7703
	public class IMotorRadioOperationRestriction
	{
		// Token: 0x0600A3D7 RID: 41943 RVA: 0x001768A0 File Offset: 0x00174AA0
		private IMotorRadioOperationRestriction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioOperationRestriction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioOperationRestriction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioOperationRestriction_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x001768D8 File Offset: 0x00174AD8
		public static IMotorRadioOperationRestriction Create([Nullable(2)] IMotorRadioOperationRestriction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioOperationRestriction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x001768EB File Offset: 0x00174AEB
		public static IMotorRadioOperationRestriction CreateFromSetValue([Nullable(2)] IMotorRadioOperationRestriction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioOperationRestriction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x001768FE File Offset: 0x00174AFE
		public IMotorRadioOperationRestriction_SetValue ToSetValue()
		{
			return new IMotorRadioOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600A3DB RID: 41947 RVA: 0x00176911 File Offset: 0x00174B11
		// (set) Token: 0x0600A3DC RID: 41948 RVA: 0x0017693C File Offset: 0x00174B3C
		public virtual EMotorRadioOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400632E RID: 25390
		[Nullable(2)]
		protected IMotorRadioOperationRestriction FbInstance;

		// Token: 0x0400632F RID: 25391
		[Nullable(2)]
		protected IMotorRadioOperationRestriction_SetValue PocoInterface;
	}
}
