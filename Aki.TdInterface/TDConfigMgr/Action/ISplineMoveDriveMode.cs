using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D8 RID: 8408
	public class ISplineMoveDriveMode
	{
		// Token: 0x0600B282 RID: 45698 RVA: 0x00190DB4 File Offset: 0x0018EFB4
		private ISplineMoveDriveMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveDriveMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveDriveMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveDriveMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x00190DEC File Offset: 0x0018EFEC
		public static ISplineMoveDriveMode Create([Nullable(2)] ISplineMoveDriveMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x00190DFF File Offset: 0x0018EFFF
		public static ISplineMoveDriveMode CreateFromSetValue([Nullable(2)] ISplineMoveDriveMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x00190E12 File Offset: 0x0018F012
		public ISplineMoveDriveMode_SetValue ToSetValue()
		{
			return new ISplineMoveDriveMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x00190E25 File Offset: 0x0018F025
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x00190E50 File Offset: 0x0018F050
		public virtual ESplineMoveDriveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069EB RID: 27115
		[Nullable(2)]
		protected ISplineMoveDriveMode FbInstance;

		// Token: 0x040069EC RID: 27116
		[Nullable(2)]
		protected ISplineMoveDriveMode_SetValue PocoInterface;
	}
}
